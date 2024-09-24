using LangChain.Providers.OpenAI;

namespace LangChain.Providers.Together;

/// <summary>
/// </summary>
public class TogetherModel(TogetherProvider provider, string id) : OpenAiChatModel(provider, id)
{
    public TogetherModel(TogetherProvider provider,
        TogetherModelIds id) : this(provider, TogetherModelProvider.GetModelById(id).Id ?? throw new InvalidOperationException("Model not found"))
    {
    }
}