using LangChain.Providers.OpenAI;

namespace LangChain.Providers.DeepInfra;

public class DeepInfraEmbeddingModel(DeepInfraProvider provider, string id)
    : OpenAiEmbeddingModel(provider, id)
{
    public DeepInfraEmbeddingModel(DeepInfraProvider provider,
        DeepInfraModelIds id) : this(provider,
        DeepInfraModelProvider.GetModelById(id).Id ?? throw new InvalidOperationException("Model not found"))
    {
    }
}