using LangChain.Providers.OpenAI;

namespace LangChain.Providers.Pollinations;

public class PollinationsProvider : OpenAiProvider
{
    public PollinationsProvider(PollinationsConfiguration config) : base(config)
    {
    }
}