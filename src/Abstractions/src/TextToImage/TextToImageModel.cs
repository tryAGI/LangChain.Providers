namespace LangChain.Providers;

public abstract class TextToImageModel(string id) : Model<TextToImageSettings>(id)
{
    #region Events

    /// <summary>
    /// Occurs before request is sent to the model.
    /// </summary>
    public event EventHandler<TextToImageRequest>? RequestSent;

    protected void OnRequestSent(TextToImageRequest request)
    {
        RequestSent?.Invoke(this, request);
    }

    #endregion
}