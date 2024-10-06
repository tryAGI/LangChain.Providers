using LangChain.Providers.OpenAI;

namespace LangChain.Providers.Pollinations;

public class PollinationsModel : OpenAiChatModel
{
    public PollinationsModel(PollinationsProvider provider, string id) : base(provider, id)
    {
        PollinationsModelProvider modelProvider = new();

        if (!modelProvider.AvailableModels.ContainsKey(id))
        {
            throw new ArgumentOutOfRangeException($"Pollinations does not provide the model {id}");
        }
    }
}