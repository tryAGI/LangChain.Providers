using LangChain.Providers.OpenAI;
using tryAGI.OpenAI;

namespace LangChain.Providers.DeepSeek;

/// <summary>
/// </summary>
public class DeepSeekConfiguration : OpenAiConfiguration
{
    /// <summary>
    /// </summary>
    public new const string SectionName = "DeepSeek";

    /// <summary>
    /// Initializes a new instance with the DeepSeek API endpoint.
    /// </summary>
    public DeepSeekConfiguration()
    {
        Endpoint = CustomProviders.DeepSeekBaseUrl;
    }
}
