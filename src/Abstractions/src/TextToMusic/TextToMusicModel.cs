namespace LangChain.Providers;

public abstract class TextToMusicModel(string id) : Model<TextToMusicSettings>(id)
{
    #region Events

    /// <inheritdoc cref="IChatModel.RequestSent"/>
    public event EventHandler<TextToMusicRequest>? RequestSent;

    protected void OnRequestSent(TextToMusicRequest request)
    {
        RequestSent?.Invoke(this, request);
    }

    #endregion
}