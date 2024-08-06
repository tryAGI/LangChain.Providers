using LangChain.Providers.OpenAI;
using OpenAI;

namespace LangChain.Providers.TogetherAi;

public class TogetherAiProvider : OpenAiProvider
{
    public TogetherAiProvider(TogetherAiConfiguration configuration) : base(configuration)
    {
    }

    public TogetherAiProvider(string apiKey) : base(apiKey, CustomProviders.TogetherBaseUrl)
    {
    }
}