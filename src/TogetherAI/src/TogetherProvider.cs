using LangChain.Providers.OpenAI;
using tryAGI.OpenAI;

namespace LangChain.Providers.Together;

public class TogetherProvider : OpenAiProvider
{
    public TogetherProvider(TogetherConfiguration configuration) : base(configuration)
    {
    }

    public TogetherProvider(string apiKey) : base(apiKey, CustomProviders.TogetherBaseUrl)
    {
    }
}