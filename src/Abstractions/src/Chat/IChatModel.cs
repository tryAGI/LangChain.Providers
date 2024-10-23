using CSharpToJsonSchema;

namespace LangChain.Providers;

/// <summary>
/// Defines a large language model that can be used for chat.
/// </summary>
public interface IChatModel : IModel<ChatSettings>
{
    /// <summary>
    /// Max input tokens for the model.
    /// </summary>
    public int ContextLength { get; }

    /// <summary>
    /// Allows to call global tools automatically.
    /// </summary>
    public bool CallToolsAutomatically { get; set; }

    /// <summary>
    /// Allows to reply to tool calls automatically.
    /// </summary>
    public bool ReplyToToolCallsAutomatically { get; set; }

    /// <summary>
    /// Occurs when token generated in streaming mode.
    /// </summary>
    event EventHandler<ChatResponseDelta>? DeltaReceived;

    /// <summary>
    /// Occurs when completed response generated.
    /// </summary>
    event EventHandler<ChatResponse>? ResponseReceived;

    /// <summary>
    /// Occurs before request is sent to the model.
    /// </summary>
    event EventHandler<ChatRequest>? RequestSent;


    /// <summary>
    /// Run the LLM on the given prompt and input.
    /// </summary>
    /// <param name="request"></param>
    /// <param name="settings"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public IAsyncEnumerable<ChatResponse> GenerateAsync(
        ChatRequest request,
        ChatSettings? settings = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Adds user-defined OpenAI tools to each request to the model.
    /// </summary>
    /// <param name="tools"></param>
    /// <param name="calls"></param>
    /// <returns></returns>
    void AddGlobalTools(
        ICollection<Tool> tools,
        IReadOnlyDictionary<string, Func<string, CancellationToken, Task<string>>> calls);

    /// <summary>
    /// Clears all global tools.
    /// </summary>
    void ClearGlobalTools();
}