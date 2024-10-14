using LangChain.Providers.OpenAI;

namespace LangChain.Providers.Pollinations;

public class PollinationsConfiguration : OpenAiConfiguration
{
    public new const string SectionName = "Pollinations";


    public PollinationsConfiguration()
    {
        Endpoint = "https://text.pollinations.ai/openai";
    }

}

