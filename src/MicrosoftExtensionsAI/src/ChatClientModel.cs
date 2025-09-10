using CSharpToJsonSchema;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace LangChain.Providers.MicrosoftExtensionsAI;

/// <summary>Provides a <see cref="IChatModel"/> based on an <see cref="IChatClient"/>.</summary>
public sealed class ChatClientModel : ChatModel, IChatModel
{
    private readonly IChatClient _clientWithFunctionInvocation;

    /// <summary>Initializes a new instance of the <see cref="ChatClientModel"/>.</summary>
    /// <param name="client">The <see cref="IChatClient"/> to use for inference.</param>
    /// <param name="id">The ID to use for the <see cref="ChatModel"/>.</param>
    public ChatClientModel(IChatClient client, string? id = null) : base(id ?? $"chatClient{Guid.NewGuid():N}")
    {
        Client = client ?? throw new ArgumentNullException(nameof(client));

        _clientWithFunctionInvocation = client.GetService<FunctionInvokingChatClient>() is null ?
            new FunctionInvokingChatClient(client) :
            client;
    }

    /// <summary>Gets the underlying <see cref="IChatClient"/>.</summary>
    public IChatClient Client { get; }

    /// <inheritdoc />
    public override async IAsyncEnumerable<ChatResponse> GenerateAsync(
        ChatRequest request,
        ChatSettings? settings = null,
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        _ = request ?? throw new ArgumentNullException(nameof(request));

        IChatClient client = CallToolsAutomatically ? _clientWithFunctionInvocation : Client;

        settings ??= ChatSettings.Default;
        ChatOptions? options =
            settings is ChatClientSettings chatClientSettings ? chatClientSettings.Options :
            settings.StopSequences is { Count: > 0 } stopSequences ? new ChatOptions { StopSequences = [.. stopSequences] } :
            null;

        options ??= new ChatOptions();
        foreach (var tool in request.Tools.Concat(GlobalTools))
        {
            (options.Tools ??= []).Add(new ToolAIFunction(tool, Calls));
        }

        List<ChatMessage> messages = request.Messages is { Count: > 0 } requestMessages ?
            requestMessages.Select(m =>
            {
                ChatRole role = m.Role switch
                {
                    MessageRole.Human => ChatRole.User,
                    MessageRole.System => ChatRole.System,
                    MessageRole.ToolResult => ChatRole.Tool,
                    _ => ChatRole.Assistant,
                };

                return new ChatMessage(role, m.Content);
            }).ToList() : [];

        OnRequestSent(request);
        Stopwatch sw = Stopwatch.StartNew();

        ChatResponse langchainResponse;
        if (settings?.UseStreaming ?? false)
        {
            List<ChatResponseUpdate> updates = [];
            await foreach (var update in client.GetStreamingResponseAsync(messages, options, cancellationToken).ConfigureAwait(false))
            {
                List<Message>? updateMessages = null;
                UsageDetails? usageDetails = null;
                updates.Add(update);
                foreach (var content in update.Contents)
                {
                    switch (content)
                    {
                        case TextContent tc:
                            OnDeltaReceived(new ChatResponseDelta { Content = tc.Text });
                            break;

                        case UsageContent uc:
                            if (usageDetails is null)
                            {
                                usageDetails = uc.Details;
                            }
                            else
                            {
                                usageDetails.Add(uc.Details);
                            }
                            break;
                    }

                    if (ToMessage(update.Role, content) is { } message)
                    {
                        (updateMessages ??= []).Add(message);
                    }
                }

                if (updateMessages is not null)
                {
                    yield return new ChatResponse
                    {
                        Messages = updateMessages,
                        UsedSettings = settings!,
                        Usage = ToUsage(usageDetails, sw),
                    };
                }
            }

            langchainResponse = ToResponse(request, updates.ToChatResponse(), sw, settings, request.Messages.Count);
        }
        else
        {
            var response = await client.GetResponseAsync(messages, options, cancellationToken).ConfigureAwait(false);
            OnDeltaReceived(new ChatResponseDelta() { Content = response.Text });

            langchainResponse = ToResponse(request, response, sw, settings, request.Messages.Count);
        }

        AddUsage(langchainResponse.Usage);
        OnResponseReceived(langchainResponse);
        yield return langchainResponse;
    }

    private static ChatResponse ToResponse(
        ChatRequest request, Microsoft.Extensions.AI.ChatResponse response, Stopwatch sw, ChatSettings? settings, int messageCount = 0)
    {
        List<Message> responseMessages = [];
        foreach (var message in response.Messages)
        {
            MessageRole role = ToMessageRole(message.Role);
            foreach (var content in message.Contents)
            {
                if (ToMessage(message.Role, content) is { } msg)
                {
                    responseMessages.Add(msg);
                }
            }
        }

        return new()
        {
            FinishReason =
                response.FinishReason == ChatFinishReason.Stop ? ChatResponseFinishReason.Stop :
                response.FinishReason == ChatFinishReason.Length ? ChatResponseFinishReason.Length :
                response.FinishReason == ChatFinishReason.ToolCalls ? ChatResponseFinishReason.ToolCalls :
                response.FinishReason == ChatFinishReason.ContentFilter ? ChatResponseFinishReason.ContentFilter :
                null,

            UsedSettings = settings ?? new(),

            Messages = [.. request.Messages, .. responseMessages],

            ToolCalls = [.. response.Messages.SelectMany(m => m.Contents).OfType<FunctionCallContent>().Select(fc => new ChatToolCall
                {
                    Id = fc.Name,
                    ToolName = fc.Name,
                    ToolArguments = JsonSerializer.Serialize(fc.Arguments, OpenApiSchemaJsonContext.Default.IDictionaryStringObject),
                })],

            Usage = ToUsage(response.Usage, sw, messageCount),
        };
    }

    private static Usage ToUsage(UsageDetails? usageDetails, Stopwatch sw, int messageCount = 0) =>
        usageDetails is null && messageCount == 0 ?
            Usage.Empty :
            new Usage
            {
                InputTokens = (int?)usageDetails?.InputTokenCount ?? 0,
                OutputTokens = (int?)usageDetails?.OutputTokenCount ?? 0,
                Messages = messageCount,
                Time = sw.Elapsed,
            };

    private static MessageRole ToMessageRole(ChatRole? role) =>
        role == ChatRole.User ? MessageRole.Human :
        role == ChatRole.Assistant ? MessageRole.Ai :
        role == ChatRole.System ? MessageRole.System :
        role == ChatRole.Tool ? MessageRole.ToolResult :
        MessageRole.Chat;

    private static Message? ToMessage(ChatRole? role, AIContent content) =>
        content switch
        {
            TextContent textContent => (Message?)new Message(textContent.Text, ToMessageRole(role)),
            FunctionCallContent functionCallContent => (Message?)new Message
            {
                Role = ToMessageRole(role),
                ToolName = functionCallContent.Name,
            },
            _ => null,
        };

    private sealed class ToolAIFunction(Tool tool, Dictionary<string, Func<string, CancellationToken, Task<string>>>? calls) : AIFunction
    {
        public override string Name => tool.Name ?? base.Name;

        public override string Description => tool.Description ?? base.Description;

        public override JsonElement JsonSchema { get; } =
            tool.Parameters is not null ?
                JsonSerializer.SerializeToElement(tool.Parameters, OpenApiSchemaJsonContext.Default.GetTypeInfo(tool.Parameters.GetType())!) :
                default;

        public override JsonSerializerOptions JsonSerializerOptions => OpenApiSchemaJsonContext.Default.Options;

        protected override ValueTask<object?> InvokeCoreAsync(AIFunctionArguments arguments, CancellationToken cancellationToken)
        {
            if (calls is null || !calls.TryGetValue(Name, out var call))
            {
                throw new InvalidOperationException($"No function call registered for tool '{Name}'.");
            }

            string args = JsonSerializer.Serialize(arguments, OpenApiSchemaJsonContext.Default.IDictionaryStringObject);

            return new ValueTask<object?>(call(args, cancellationToken));
        }
    }
}