using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using OpenAI.Chat;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;
using System.Text.Json.Serialization;
namespace LangChain.Providers.Azure;

/// <summary>
/// Wrapper around Azure OpenAI large language models
/// </summary>
public class AzureOpenAiChatModel(
    AzureOpenAiProvider provider,
    string id)
    : ChatModel(id),
        IChatModelWithTokenCounting,
        IPaidLargeLanguageModel,
        IChatModel<ChatRequest, ChatResponse, AzureOpenAiChatSettings>
{
    #region Properties

    private string ChatModel { get; } = id;

    /// <inheritdoc/>
    public override int ContextLength => provider.Configurations.ContextSize;

    #endregion

    #region Methods

    /// <inheritdoc/>
    public override async IAsyncEnumerable<ChatResponse> GenerateAsync(
        ChatRequest request,
        ChatSettings? settings = null,
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        request = request ?? throw new ArgumentNullException(nameof(request));

        var messages = request.Messages.ToList();
        var watch = Stopwatch.StartNew();

        var usedSettings = AzureOpenAiChatSettings.Calculate(
            requestSettings: settings,
            modelSettings: Settings,
            providerSettings: provider.ChatSettings);

        List<ChatTool> tools = ExtarctTools(request);              

        do
        {
#pragma warning disable OPENAI001 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
            var chatCompletionsOptions = new ChatCompletionOptions
            {
                Temperature = (float?)usedSettings.Temperature,
                FrequencyPenalty = (float?)usedSettings.FrequencyPenalty,
                TopP = (float?)usedSettings.TopP,
                PresencePenalty = (float?)usedSettings.PresencePenalty,
                Seed = usedSettings.Seed,
                MaxOutputTokenCount = usedSettings.MaxCompletionTokens,
            };
#pragma warning restore OPENAI001 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.

            usedSettings.StopSequences?.ToList().ForEach(stop =>
            {
                chatCompletionsOptions.StopSequences.Add(stop);
            });

            tools.ForEach(tool =>
            {
                chatCompletionsOptions.Tools.Add(tool);
            });

            OnRequestSent(request);

            IReadOnlyList<ChatToolCall>? toolCalls = null;
            Usage? usage = null;
            ChatResponseFinishReason? finishReason = null;

            var chatMessage = messages.Select(ToRequestMessage).ToList();
            if (usedSettings.UseStreaming == true)
            {
                var enumerable = provider.ChatClient.CompleteChatStreamingAsync(
                    chatMessage,
                    chatCompletionsOptions,
                    cancellationToken).ConfigureAwait(false);

                var stringBuilder = new StringBuilder(capacity: 1024);


                await foreach (StreamingChatCompletionUpdate streamResponse in enumerable)
                {
                    foreach (ChatMessageContentPart contentPart in streamResponse.ContentUpdate)
                    {
                        var delta = new ChatResponseDelta
                        {
                            Content = contentPart.Text,
                        };
                        OnDeltaReceived(delta);
                        stringBuilder.Append(contentPart.Text);

                        toolCalls ??= streamResponse?.ToolCallUpdates?.Select(x => new ChatToolCall
                        {
                            Id = x.ToolCallId ?? string.Empty,
                            ToolName = x.FunctionName ?? string.Empty,
                            ToolArguments = x.FunctionArgumentsUpdate?.ToString() ?? string.Empty,
                        }).ToList();

                        usage ??= GetUsage(streamResponse?.Usage);
                        finishReason ??= streamResponse?.FinishReason switch
                        {
                            ChatFinishReason.Length => ChatResponseFinishReason.Length,
                            ChatFinishReason.Stop => ChatResponseFinishReason.Stop,
                            ChatFinishReason.ContentFilter => ChatResponseFinishReason.ContentFilter,
                            ChatFinishReason.FunctionCall => ChatResponseFinishReason.ToolCalls,
                            ChatFinishReason.ToolCalls => ChatResponseFinishReason.ToolCalls,
                            _ => null,
                        };

                        yield return new ChatResponse
                        {
                            Messages = messages,
                            UsedSettings = usedSettings,
                            Delta = delta,
                            Usage = Usage.Empty,
                        };
                    }
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
                var response = await provider.ChatClient.CompleteChatAsync(
                    chatMessage,
                    chatCompletionsOptions,
                    cancellationToken).ConfigureAwait(false);
                if (response == null)
                {
                    yield break;
                }
                
                var message = response.Value.Content.FirstOrDefault()?.Text;
                var newMessages = ToMessages(response.Value);
                messages.AddRange(newMessages);
                toolCalls = response.Value?.ToolCalls.Select(x => new ChatToolCall
                {
                    Id = x.Id,
                    ToolName = x.FunctionName,
                    ToolArguments = x.FunctionArguments.ToString(),
                }).ToList();

                OnDeltaReceived(new ChatResponseDelta
                {
                    Content = message + Environment.NewLine,
                });
                usage = GetUsage(response?.Value?.Usage) with
                {
                    Time = watch.Elapsed,
                };
                finishReason = response?.Value?.FinishReason switch
                {
                    ChatFinishReason.Length => ChatResponseFinishReason.Length,
                    ChatFinishReason.Stop => ChatResponseFinishReason.Stop,
                    ChatFinishReason.ContentFilter => ChatResponseFinishReason.ContentFilter,
                    ChatFinishReason.FunctionCall => ChatResponseFinishReason.ToolCalls,
                    ChatFinishReason.ToolCalls => ChatResponseFinishReason.ToolCalls,
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

    private List<ChatTool> ExtarctTools(ChatRequest request)
    {
        //var parameters = request.Tools.Concat(GlobalTools).Select(s => JsonSerializer.Serialize(s.Parameters, new JsonSerializerOptions
        //{
        //    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
        //})).ToList();

        //var testParameter = BinaryData.FromBytes("""
        //             {
        //                 "type": "object",
        //                 "description": "Get the current weather in a given location",                         
        //                 "properties": {
        //                     "location": {
        //                         "type": "string",
        //                         "description": "The city and state, e.g. San Francisco, CA",
        //                         "additionalProperties": false
        //                     }
        //                 },
        //                 "required": ["location"],
        //                 "additionalProperties": false                         
        //             }
        //             """u8.ToArray());

        var tools = request.Tools.Concat(GlobalTools).Select(s => ChatTool.CreateFunctionTool(
            s.Name ?? string.Empty, s.Description, BinaryData.FromString(JsonSerializer.Serialize(s.Parameters, SourceGenerationContext.Default.String))
            )).ToList();
        return tools;
    }

    [CLSCompliant(false)]
    protected virtual ChatMessage ToRequestMessage(Message message)
    {
        switch (message.Role)
        {
            case MessageRole.System:
                return new SystemChatMessage(message.Content);
            case MessageRole.Ai:
                return new AssistantChatMessage(message.Content);
            case MessageRole.Human:
                return new UserChatMessage(message.Content);

            case MessageRole.ToolCall:
                var toolNameAndId = message.ToolName?.Split(':') ??
                                    throw new ArgumentException("Invalid functionCall name and id string"); 
                
                var toolCall = OpenAI.Chat.ChatToolCall.CreateFunctionToolCall(toolNameAndId.ElementAtOrDefault(1),
                        toolNameAndId.ElementAtOrDefault(0),
                        BinaryData.FromString(message.Content));
                
                OpenAI.Chat.ChatToolCall[] chatToolCalls = { toolCall };
                return new AssistantChatMessage(chatToolCalls);

            case MessageRole.ToolResult:
                var nameAndId = message.ToolName?.Split(':') ??
                    throw new ArgumentException("Invalid functionCall name and id string");
                return new ToolChatMessage(nameAndId.ElementAtOrDefault(1) ?? string.Empty, message.Content);

            default:
                throw new ArgumentOutOfRangeException(nameof(message));
        }
    }
    
    [CLSCompliant(false)]
    protected static IReadOnlyCollection<Message> ToMessages(ChatCompletion message)
    {
        message = message ?? throw new ArgumentNullException(nameof(message));

        if (message.ToolCalls?.Count > 0)
        {
            var messages = new List<Message>();
            foreach (var call in message.ToolCalls)
            {
                messages.Add(new Message(
                    Content: call.FunctionArguments.ToString(),
                    Role: MessageRole.ToolCall,
                    ToolName: $"{call.FunctionName}:{call.Id}"));
            }

            return messages;
        }

        return [new Message(
            Content: message.Content[0]?.Text ?? string.Empty,
            Role: MessageRole.Ai)];
    }

    private Usage GetUsage(ChatTokenUsage? chatTokenUsage)
    {
        var outputTokens = chatTokenUsage?.OutputTokenCount ?? 0;
        var inputTokens = chatTokenUsage?.InputTokenCount ?? 0;
        var priceInUsd = 0.0;

        return Usage.Empty with
        {
            InputTokens = inputTokens,
            OutputTokens = outputTokens,
            Messages = 1,
            PriceInUsd = priceInUsd,
        };
    }    

    public int CountTokens(string text)
    {
        throw new NotImplementedException();
    }

    public int CountTokens(IReadOnlyCollection<Message> messages)
    {
        throw new NotImplementedException();
    }

    public int CountTokens(ChatRequest request)
    {
        throw new NotImplementedException();
    }

    public IAsyncEnumerable<ChatResponse> GenerateAsync(
        ChatRequest request,
        AzureOpenAiChatSettings? settings = default,
        CancellationToken cancellationToken = default)
    {
        return GenerateAsync(request, (ChatSettings?)settings, cancellationToken);
    }

    public double? TryCalculatePriceInUsd(int inputTokens, int outputTokens)
    {
        throw new NotImplementedException();
    }

    #endregion
}

[JsonSourceGenerationOptions(DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault)]
[JsonSerializable(typeof(string))]
public partial class SourceGenerationContext : JsonSerializerContext;