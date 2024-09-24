using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

// ReSharper disable once CheckNamespace
namespace LangChain.Providers.Anthropic;

/// <summary>
/// </summary>
public partial class AnthropicChatModel(
    AnthropicProvider provider,
    string id) : ChatModel(id), IPaidLargeLanguageModel
{
    #region Methods

    private static global::Anthropic.Message ToRequestMessage(Message message)
    {
        return message.Role switch
        {
            MessageRole.System or MessageRole.Ai => new global::Anthropic.Message
            {
                Role = global::Anthropic.MessageRole.Assistant,
                Content = message.Content,
            },
            MessageRole.Human => new global::Anthropic.Message
            {
                Role = global::Anthropic.MessageRole.User,
                Content = message.Content,
            },
            MessageRole.ToolCall => throw new NotImplementedException(),
            MessageRole.ToolResult => throw new NotImplementedException(),
            _ => throw new NotImplementedException()
        };
    }

    private static Message ToMessage(global::Anthropic.Message message)
    {
        switch (message.Role)
        {
            case global::Anthropic.MessageRole.User:
                return new Message(string.Join("\r\n", message.Content.Value2!.Select(s => s.IsText ? s.Text!.Text : string.Empty)), MessageRole.Human);
            case global::Anthropic.MessageRole.Assistant:
                return new Message(string.Join("\r\n", message.Content.Value2!.Select(s => s.IsText ? s.Text!.Text : string.Empty)), MessageRole.Ai);
        }

        return new Message(string.Join("\r\n", message.Content.Value2!.Select(s => s.IsText ? s.Text!.Text : string.Empty)), MessageRole.Ai);
    }

    private Usage GetUsage(global::Anthropic.Usage? usage)
    {
        var completionTokens = usage?.OutputTokens ?? 0;
        var promptTokens = usage?.InputTokens ?? 0;

        return Usage.Empty with
        {
            InputTokens = promptTokens,
            OutputTokens = completionTokens,
            Messages = 1,
            PriceInUsd = TryCalculatePriceInUsd(
                outputTokens: completionTokens,
                inputTokens: promptTokens),
        };
    }

    private Usage GetUsage(global::Anthropic.MessageDeltaUsage? usage)
    {
        var completionTokens = usage?.OutputTokens ?? 0;

        return Usage.Empty with
        {
            InputTokens = 0,
            OutputTokens = completionTokens,
            Messages = 0,
            PriceInUsd = TryCalculatePriceInUsd(
                outputTokens: completionTokens,
                inputTokens: 0),
        };
    }

    /// <inheritdoc />
    public override async IAsyncEnumerable<ChatResponse> GenerateAsync(
        ChatRequest request,
        ChatSettings? settings = null,
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        request = request ?? throw new ArgumentNullException(nameof(request));

        var messages = request.Messages.ToList();
        var watch = Stopwatch.StartNew();
        var usedSettings = AnthropicChatSettings.Calculate(
            requestSettings: settings,
            modelSettings: Settings,
            providerSettings: provider.ChatSettings);
        // var tools = request.Tools
        //     .Concat(GlobalTools)
        //     .Select(x => new ChatCompletionTool
        //     {
        //         Type = ChatCompletionToolType.Function,
        //         Function = new FunctionObject
        //         {
        //             Name = x.Type,
        //             Description = x.Description,
        //             Parameters = x.Items != null
        //                 ? ToTool<FunctionParameters>(x.Items)
        //                 : new FunctionParameters(),
        //         },
        //     })
        //     .ToArray();
        // tools = tools.Length > 0 ? tools : null;
        var systemMessage = messages.FirstOrDefault(m => m.Role == MessageRole.System).Content;

        do
        {
            var chatRequest = new CreateMessageRequest
            {
                Model = Id,
                Messages = messages
                    .Select(ToRequestMessage)
                    .ToList(),
                System = string.IsNullOrWhiteSpace(systemMessage) ? null : systemMessage,
                MaxTokens =
                    usedSettings.MaxTokens ??
                    CreateMessageRequestModelExtensions.ToEnum(Id)?.GetOutputLength() ??
                    4096,
                Stream = usedSettings.UseStreaming ?? false,
                StopSequences = usedSettings.StopSequences?.ToArray(),
                Temperature = usedSettings.Temperature ?? 1.0,
                Tools = null,
            };
            OnRequestSent(request);

            IReadOnlyList<ChatToolCall>? toolCalls = null;
            Usage? usage = null;
            ChatResponseFinishReason? finishReason = null;
            if (usedSettings.UseStreaming == true)
            {
                var enumerable = provider.Api.CreateMessageAsStreamAsync(
                    chatRequest,
                    cancellationToken).ConfigureAwait(false);

                var stringBuilder = new StringBuilder(capacity: 1024);
                await foreach (MessageStreamEvent streamResponse in enumerable)
                {
                    usage ??= Usage.Empty;
                    if (streamResponse.IsStart)
                    {
                        usage += GetUsage(streamResponse.Start?.Message.Usage);
                    }
                    var streamDelta = streamResponse.ContentBlockDelta;
                    var delta = new ChatResponseDelta
                    {
                        Content = streamDelta?.Delta.Text?.Text ?? string.Empty,
                    };
                    // toolCalls ??= streamDelta?.ToolCalls?.Select(x => new ChatToolCall
                    // {
                    //     Id = x.Id ?? string.Empty,
                    //     ToolName = x.Function?.Name ?? string.Empty,
                    //     ToolArguments = x.Function?.Arguments ?? string.Empty,
                    // }).ToList();
                    usage += GetUsage(streamResponse.Delta?.Usage);
                    finishReason ??= streamResponse.Delta?.Delta.StopReason switch
                    {
                        StopReason.EndTurn => ChatResponseFinishReason.Stop,
                        StopReason.MaxTokens => ChatResponseFinishReason.Length,
                        StopReason.StopSequence => ChatResponseFinishReason.Stop,
                        StopReason.ToolUse => ChatResponseFinishReason.ToolCalls,
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
                var response = await provider.Api.CreateMessageAsync(
                    chatRequest,
                    cancellationToken).ConfigureAwait(false);
                var newMessage = ToMessage(response);
                messages.Add(newMessage);
                toolCalls = response.Content.Value2?
                    .Where(x => x.ToolUse != null)
                    .Select(x => new ChatToolCall
                    {
                        Id = x.ToolUse!.Id,
                        ToolName = x.ToolUse.Name,
                        ToolArguments = x.ToolUse.Input.AsJson(),
                    })
                    .ToList();

                OnDeltaReceived(new ChatResponseDelta
                {
                    Content = newMessage.Content + Environment.NewLine,
                });
                usage = GetUsage(response.Usage) with
                {
                    Time = watch.Elapsed,
                };
                finishReason = response.StopReason switch
                {
                    StopReason.EndTurn => ChatResponseFinishReason.Stop,
                    StopReason.MaxTokens => ChatResponseFinishReason.Length,
                    StopReason.StopSequence => ChatResponseFinishReason.Stop,
                    StopReason.ToolUse => ChatResponseFinishReason.ToolCalls,
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

    private static Task CallFunctionsAsync(Message newMessage, List<Message> messages,
        CancellationToken cancellationToken = default)
    {
        return Task.CompletedTask;
        // var function = newMessage.Content.ToAnthropicToolCall(GlobalTools);
        //
        // if (!string.IsNullOrEmpty(function.FunctionName))
        // {
        //     var call = Calls[function.FunctionName];
        //     var result = await call(function.Arguments?.ToString() ?? string.Empty, cancellationToken).ConfigureAwait(false);
        //     messages.Add(result.ToAnthropicToolResponseMessage(function.FunctionName));
        // }
    }

    /// <inheritdoc />
    public double? TryCalculatePriceInUsd(int inputTokens, int outputTokens)
    {
        return CreateMessageRequestModelExtensions.ToEnum(Id)?.TryGetPriceInUsd(
            inputTokens: inputTokens,
            outputTokens: outputTokens);
    }

    #endregion
}