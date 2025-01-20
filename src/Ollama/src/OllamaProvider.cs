using Ollama;

namespace LangChain.Providers.Ollama;

/// <summary>
/// 
/// </summary>
/// <param name="url"></param>
public sealed class OllamaProvider(
    string url = "http://localhost:11434/api")
    : Provider(id: "ollama"), IDisposable
{
    /// <summary>
    /// 
    /// </summary>
    public OllamaApiClient Api { get; } = new(httpClient: new HttpClient
    {
        Timeout = TimeSpan.FromHours(1),
    }, baseUri: new Uri(url));

    /// <summary>
    /// OllamaChatModel and OllamaEmbeddingModel will pull models automatically if this is true.
    /// </summary>
    public bool CanPullModelsAutomatically { get; set; } = true;

    public void Dispose()
    {
        Api.Dispose();
    }

    public async Task PullModelIfRequiredAndAllowedAsync(
        string id,
        CancellationToken cancellationToken = default)
    {
        if (!CanPullModelsAutomatically)
        {
            return;
        }

        try
        {
            // Pull the model if it is not running
            var runningModels = await Api.Models.ListRunningModelsAsync(cancellationToken).ConfigureAwait(false);
            if (runningModels.Models != null &&
                runningModels.Models.All(x => x.Model?.Contains(id) != true))
            {
                await Api.Models.PullModelAsync(id, cancellationToken: cancellationToken)
                    .EnsureSuccessAsync().ConfigureAwait(false);
            }
        }
        catch (HttpRequestException)
        {
            // Ignore
        }
    }
}