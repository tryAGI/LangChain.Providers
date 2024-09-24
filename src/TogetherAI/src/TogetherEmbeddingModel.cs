using LangChain.Providers.OpenAI;

namespace LangChain.Providers.Together;

/// <summary>
/// </summary>
public class TogetherEmbeddingModel(TogetherProvider provider, string id)
    : OpenAiEmbeddingModel(provider, id);