using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

#pragma warning disable CS3001 // Argument type is not CLS-compliant

// ReSharper disable once CheckNamespace
namespace LangChain.Providers.OpenAI;

public partial class OpenAiChatModel(
    OpenAiProvider provider,
    string id)
    : ChatModel(id),
        IChatModelWithTokenCounting,
        IPaidLargeLanguageModel,
        IChatModel<ChatRequest, ChatResponse, OpenAiChatSettings>
{
    public OpenAiChatModel(
        OpenAiProvider provider,
        CreateChatCompletionRequestModel id)
        : this(provider, id.ToValueString())
    {
    }

    #region Properties

    private string ChatModel { get; } = id;

    /// <inheritdoc/>
    public override int ContextLength => CreateChatCompletionRequestModelExtensions.ToEnum(ChatModel)?.GetContextLength() ?? 0;

    #endregion

    #region Methods

    protected virtual ChatCompletionRequestMessage ToRequestMessage(Message message)
    {
        switch (message.Role)
        {
            case MessageRole.System:
                return new ChatCompletionRequestSystemMessage
                {
                    Role = ChatCompletionRequestSystemMessageRole.System,
                    Content = message.Content,
                };
            case MessageRole.Ai:
                return new ChatCompletionRequestAssistantMessage
                {
                    Role = ChatCompletionRequestAssistantMessageRole.Assistant,
                    Content = message.Content,
                };
            case MessageRole.Human:
                return new ChatCompletionRequestUserMessage
                {
                    Role = ChatCompletionRequestUserMessageRole.User,
                    Content = message.Content,
                };
            case MessageRole.ToolCall:
                return new ChatCompletionRequestAssistantMessage
                {
                    Role = ChatCompletionRequestAssistantMessageRole.Assistant,
                    Content = message.Content,
                    ToolCalls = message.ToToolCalls(),
                };
            case MessageRole.ToolResult:
                var nameAndId = message.ToolName?.Split(':') ??
                    throw new ArgumentException("Invalid functionCall name and id string");

                return new ChatCompletionRequestToolMessage
                {
                    Role = ChatCompletionRequestToolMessageRole.Tool,
                    Content = message.Content,
                    ToolCallId = nameAndId.ElementAtOrDefault(1) ?? string.Empty,
                };
            default:
                throw new ArgumentOutOfRangeException(nameof(message));
        }
    }

    protected static IReadOnlyCollection<Message> ToMessages(ChatCompletionResponseMessage message)
    {
        message = message ?? throw new ArgumentNullException(nameof(message));

        if (message.ToolCalls?.Count > 0)
        {
            var messages = new List<Message>();
            foreach (var call in message.ToolCalls)
            {
                messages.Add(new Message(
                    Content: call.Function.Arguments,
                    Role: MessageRole.ToolCall,
                    ToolName: $"{call.Function.Name}:{call.Id}"));
            }

            return messages;
        }

        return [new Message(
            Content: message.Content ?? string.Empty,
            Role: MessageRole.Ai)];
    }

    private Usage GetUsage(CreateChatCompletionResponse response)
    {
        var outputTokens = response.Usage?.CompletionTokens ?? 0;
        var inputTokens = response.Usage?.PromptTokens ?? 0;
        var priceInUsd = TryCalculatePriceInUsd(
            outputTokens: outputTokens,
            inputTokens: inputTokens);

        return Usage.Empty with
        {
            InputTokens = inputTokens,
            OutputTokens = outputTokens,
            Messages = 1,
            PriceInUsd = priceInUsd,
        };
    }

    private Usage? GetUsage(CreateChatCompletionStreamResponse response)
    {
        if (response.Usage == null)
        {
            return null;
        }

        var outputTokens = response.Usage?.CompletionTokens ?? 0;
        var inputTokens = response.Usage?.PromptTokens ?? 0;
        var priceInUsd = TryCalculatePriceInUsd(
            outputTokens: outputTokens,
            inputTokens: inputTokens);

        return Usage.Empty with
        {
            InputTokens = inputTokens,
            OutputTokens = outputTokens,
            Messages = 1,
            PriceInUsd = priceInUsd,
        };
    }

    /// <inheritdoc cref="IChatModel.GenerateAsync(ChatRequest, ChatSettings, CancellationToken)"/>
    public override async IAsyncEnumerable<ChatResponse> GenerateAsync(
        ChatRequest request,
        ChatSettings? settings = null,
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        request = request ?? throw new ArgumentNullException(nameof(request));

        var messages = request.Messages.ToList();
        var watch = Stopwatch.StartNew();

        var usedSettings = OpenAiChatSettings.Calculate(
            requestSettings: settings,
            modelSettings: Settings,
            providerSettings: provider.ChatSettings);
        var tools = request.Tools
            .Concat(GlobalTools)
            .Select(x => new ChatCompletionTool
            {
                Type = ChatCompletionToolType.Function,
                Function = new FunctionObject
                {
                    Name = x.Name ?? string.Empty,
                    Description = x.Description,
                    Parameters = x.Parameters ?? new FunctionParameters(),
                },
            })
            .ToArray();
        tools = tools.Length > 0 ? tools : null;

        do
        {
            var chatRequest = new CreateChatCompletionRequest
            {
                Model = Id,
                Messages = messages
                    .Select(ToRequestMessage)
                    .ToArray(),
                Seed = usedSettings.Seed,
                Stop = usedSettings.StopSequences!.ToArray(),
                User = usedSettings.User,
                Temperature = usedSettings.Temperature,
                FrequencyPenalty = usedSettings.FrequencyPenalty,
                N = usedSettings.Number,
                MaxCompletionTokens = usedSettings.MaxCompletionTokens,
                TopP = usedSettings.TopP,
                PresencePenalty = usedSettings.PresencePenalty,
                LogitBias = usedSettings.LogitBias?
                    .ToDictionary(
                        x => x.Key,
                        x => (int)x.Value) ?? [],
                Tools = tools,
                StreamOptions = usedSettings.UseStreaming == true
                    ? new ChatCompletionStreamOptions
                    {
                        IncludeUsage = true,
                    }
                    : null,
            };
            OnRequestSent(request);

            IReadOnlyList<ChatToolCall>? toolCalls = null;
            Usage? usage = null;
            ChatResponseFinishReason? finishReason = null;
            if (usedSettings.UseStreaming == true)
            {
                var enumerable = provider.Client.Chat.CreateChatCompletionAsStreamAsync(
                    chatRequest,
                    cancellationToken).ConfigureAwait(false);

                var stringBuilder = new StringBuilder(capacity: 1024);
                await foreach (CreateChatCompletionStreamResponse streamResponse in enumerable)
                {
                    var choice = streamResponse.Choices.ElementAtOrDefault(0);
                    var streamDelta = choice?.Delta;
                    var delta = new ChatResponseDelta
                    {
                        Content = streamDelta?.Content ?? string.Empty,
                    };
                    toolCalls ??= streamDelta?.ToolCalls?.Select(x => new ChatToolCall
                    {
                        Id = x.Id ?? string.Empty,
                        ToolName = x.Function?.Name ?? string.Empty,
                        ToolArguments = x.Function?.Arguments ?? string.Empty,
                    }).ToList();
                    usage ??= GetUsage(streamResponse);
                    finishReason ??= choice?.FinishReason switch
                    {
                        CreateChatCompletionStreamResponseChoiceFinishReason.Length => ChatResponseFinishReason.Length,
                        CreateChatCompletionStreamResponseChoiceFinishReason.Stop => ChatResponseFinishReason.Stop,
                        CreateChatCompletionStreamResponseChoiceFinishReason.ContentFilter => ChatResponseFinishReason.ContentFilter,
                        CreateChatCompletionStreamResponseChoiceFinishReason.FunctionCall => ChatResponseFinishReason.ToolCalls,
                        CreateChatCompletionStreamResponseChoiceFinishReason.ToolCalls => ChatResponseFinishReason.ToolCalls,
                        _ => null,
                    };

                    OnDeltaReceived(delta);
                    stringBuilder.Append(delta.Content);

                    yield return new ChatResponse
                    {
                        Messages = messages,
                        UsedSettings = usedSettings,
                        Delta = delta,
                        Usage = Usage.Empty,
                    };
                }
                OnDeltaReceived(new ChatResponseDelta
                {
                    Content = Environment.NewLine,
                });
                stringBuilder.Append(Environment.NewLine);

                Message newMessage = stringBuilder.ToString().AsAiMessage();
                messages.Add(newMessage);
            }
            else
            {
                var response = await provider.Client.Chat.CreateChatCompletionAsync(
                    chatRequest,
                    cancellationToken).ConfigureAwait(false);
                var message = response.Choices.First().Message;
                var newMessages = ToMessages(message);
                messages.AddRange(newMessages);
                toolCalls = message.ToolCalls?.Select(x => new ChatToolCall
                {
                    Id = x.Id,
                    ToolName = x.Function.Name,
                    ToolArguments = x.Function.Arguments,
                }).ToList();

                OnDeltaReceived(new ChatResponseDelta
                {
                    Content = message.Content + Environment.NewLine,
                });
                usage = GetUsage(response) with
                {
                    Time = watch.Elapsed,
                };
                finishReason = response.Choices.First().FinishReason switch
                {
                    CreateChatCompletionResponseChoiceFinishReason.Length => ChatResponseFinishReason.Length,
                    CreateChatCompletionResponseChoiceFinishReason.Stop => ChatResponseFinishReason.Stop,
                    CreateChatCompletionResponseChoiceFinishReason.ContentFilter => ChatResponseFinishReason.ContentFilter,
                    CreateChatCompletionResponseChoiceFinishReason.FunctionCall => ChatResponseFinishReason.ToolCalls,
                    CreateChatCompletionResponseChoiceFinishReason.ToolCalls => ChatResponseFinishReason.ToolCalls,
                    _ => null,
                };
            }

            usage ??= Usage.Empty;
            usage = usage.Value with
            {
                Time = watch.Elapsed,
            };
            AddUsage(usage.Value);
            provider.AddUsage(usage.Value);

            var newResponse = new ChatResponse
            {
                Messages = messages,
                UsedSettings = usedSettings,
                Usage = usage.Value,
                ToolCalls = toolCalls ?? [],
                FinishReason = finishReason,
            };
            OnResponseReceived(newResponse);
            yield return newResponse;

            if (CallToolsAutomatically && toolCalls is { Count: > 0 })
            {
                await CallToolsAsync(toolCalls, messages, cancellationToken).ConfigureAwait(false);

                if (!ReplyToToolCallsAutomatically)
                {
                    yield break;
                }
            }
            else
            {
                yield break;
            }
        }
        while (true);
    }

    public IAsyncEnumerable<ChatResponse> GenerateAsync(
        ChatRequest request,
        OpenAiChatSettings? settings = default,
        CancellationToken cancellationToken = default)
    {
        return GenerateAsync(request, (ChatSettings?)settings, cancellationToken);
    }

    /// <inheritdoc/>
    public double? TryCalculatePriceInUsd(int inputTokens, int outputTokens)
    {
        return CreateChatCompletionRequestModelExtensions
            .ToEnum(ChatModel)?
            .TryGetPriceInUsd(
                outputTokens: outputTokens,
                inputTokens: inputTokens);
    }

    #endregion
}