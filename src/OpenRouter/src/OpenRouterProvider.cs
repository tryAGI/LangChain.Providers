using LangChain.Providers.OpenAI;
using tryAGI.OpenAI;

namespace LangChain.Providers.OpenRouter;

public class OpenRouterProvider : OpenAiProvider
{
    public OpenRouterProvider(OpenRouterConfiguration configuration) : base(configuration)
    {
    }

    public OpenRouterProvider(string apiKey) : base(apiKey, customEndpoint: CustomProviders.OpenRouterBaseUrl)
    {
    }
}