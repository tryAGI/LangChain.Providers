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

    public void Dispose()
    {
        Api.Dispose();
    }
}