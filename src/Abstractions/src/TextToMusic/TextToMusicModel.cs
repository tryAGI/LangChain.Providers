namespace LangChain.Providers;

public abstract class TextToMusicModel(string id) : Model<TextToMusicSettings>(id)
{
    #region Events

    /// <summary>
    /// Occurs before request is sent to the model.
    /// </summary>
    public event EventHandler<TextToMusicRequest>? RequestSent;

    protected void OnRequestSent(TextToMusicRequest request)
    {
        RequestSent?.Invoke(this, request);
    }

    #endregion
}