// ReSharper disable once CheckNamespace
namespace LangChain.Providers;

public abstract partial class ChatModel(string id) : Model<ChatSettings>(id), IChatModel<ChatRequest, ChatResponse, ChatSettings>
{
    #region Events

    public virtual int ContextLength { get; protected set; }

    /// <inheritdoc cref="IChatModel.DeltaReceived"/>
    public event EventHandler<ChatResponseDelta>? DeltaReceived;

    protected void OnDeltaReceived(ChatResponseDelta delta)
    {
        DeltaReceived?.Invoke(this, delta);
    }

    /// <inheritdoc cref="IChatModel.ResponseReceived"/>
    public event EventHandler<ChatResponse>? ResponseReceived;

    protected void OnResponseReceived(ChatResponse response)
    {
        ResponseReceived?.Invoke(this, response);
    }

    /// <inheritdoc cref="IChatModel.RequestSent"/>
    public event EventHandler<ChatRequest>? RequestSent;

    protected void OnRequestSent(ChatRequest request)
    {
        RequestSent?.Invoke(this, request);
    }

    #endregion

    public abstract IAsyncEnumerable<ChatResponse> GenerateAsync(
        ChatRequest request,
        ChatSettings? settings = null,
        CancellationToken cancellationToken = default);
}