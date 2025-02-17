using GenerativeAI;

namespace LangChain.Providers.Google.Predefined;

/// <inheritdoc cref="GoogleAIModels.GeminiPro" />
public class GoogleTextEmbedding(GoogleProvider provider)
    : GoogleEmbeddingModel(
        provider, GoogleAIModels.TextEmbedding);
