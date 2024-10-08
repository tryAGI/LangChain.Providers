// ReSharper disable once CheckNamespace
namespace LangChain.Providers.Amazon.Bedrock.Predefined.Amazon;

/// <inheritdoc />
public class TitanTextExpressV1Model(BedrockProvider provider)
    : AmazonTitanChatModel(provider, id: "amazon.titan-text-express-v1");

/// <inheritdoc />
public class TitanTextLiteV1Model(BedrockProvider provider)
    : AmazonTitanChatModel(provider, id: "amazon.titan-text-lite-v1");

/// <inheritdoc />
public class TitanEmbedTextV1Model(BedrockProvider provider)
    : AmazonTitanEmbeddingModel(provider, id: "amazon.titan-embed-text-v1");

/// <inheritdoc />
public class TitanEmbedTextV2Model(BedrockProvider provider)
    : AmazonTitanEmbeddingV2Model(provider, id: "amazon.titan-embed-text-v2:0");

/// <inheritdoc />
public class TitanEmbedImageV1Model(BedrockProvider provider)
    : AmazonTitanImageEmbeddingModel(provider, id: "amazon.titan-embed-image-v1");

/// <inheritdoc />
public class TitanImageGeneratorV1Model(BedrockProvider provider)
    : AmazonTitanTextToImageModel(provider, id: "amazon.titan-image-generator-v1");

/// <inheritdoc />
public class TitanImageGeneratorV2Model(BedrockProvider provider)
    : AmazonTitanTextToImageModel(provider, id: "amazon.titan-image-generator-v2:0");

/// <inheritdoc />
public class TitanTextPremierV1Model(BedrockProvider provider)
    : AmazonTitanChatModel(provider, id: "amazon.titan-text-premier-v1");
