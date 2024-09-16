namespace LangChain.Providers;

public abstract class TextToImageModel(string id) : Model<TextToImageSettings>(id)
{
    #region Events

    /// <inheritdoc cref="IChatModel.RequestSent"/>
    public event EventHandler<TextToImageRequest>? RequestSent;

    protected void OnRequestSent(TextToImageRequest request)
    {
        RequestSent?.Invoke(this, request);
    }

    #endregion
}