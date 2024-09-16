using LangChain.Providers.OpenAI;
using OpenAI;

namespace LangChain.Providers.Fireworks;

/// <summary>
/// 
/// </summary>
public class FireworksConfiguration : OpenAiConfiguration
{
    /// <summary>
    /// 
    /// </summary>
    public new const string SectionName = "Fireworks";

    /// <summary>
    /// 
    /// </summary>
    public new string? Endpoint { get; set; } = CustomProviders.FireworksBaseUrl;
}