using LangChain.Providers.OpenAI;
using tryAGI.OpenAI;

namespace LangChain.Providers.DeepInfra;

public class DeepInfraProvider : OpenAiProvider
{
    public DeepInfraProvider(DeepInfraConfiguration configuration) : base(configuration)
    {
    }

    public DeepInfraProvider(string apiKey) : base(apiKey, CustomProviders.DeepInfraBaseUrl)
    {

    }
}