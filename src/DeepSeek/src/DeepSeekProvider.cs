using LangChain.Providers.OpenAI;
using tryAGI.OpenAI;

namespace LangChain.Providers.DeepSeek;

public class DeepSeekProvider : OpenAiProvider
{
    public DeepSeekProvider(DeepSeekConfiguration configuration) : base(configuration)
    {
    }

    public DeepSeekProvider(string apiKey) : base(apiKey, CustomProviders.DeepSeekBaseUrl)
    {
    }
}