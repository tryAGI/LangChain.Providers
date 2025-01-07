using LangChain.Providers.OpenAI;
using tryAGI.OpenAI;

namespace LangChain.Providers.Fireworks;

public class FireworksProvider : OpenAiProvider
{
    public FireworksProvider(FireworksConfiguration configuration) : base(configuration)
    {
    }

    public FireworksProvider(string apiKey) : base(apiKey, customEndpoint: CustomProviders.FireworksBaseUrl)
    {
    }
}