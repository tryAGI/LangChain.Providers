// ReSharper disable once CheckNamespace
namespace LangChain.Providers.Amazon.Bedrock.Predefined.Stability;

/// <inheritdoc />
public class StableDiffusionSDXLModel(BedrockProvider provider)
    : StableDiffusionTextToImageV1Model(provider, id: "stability.stable-diffusion-xl-v1");

/// <inheritdoc />
public class StableDiffusionSD3LargeModel(BedrockProvider provider)
    : StableDiffusionTextToImageV2Model(provider, id: "stability.sd3-large-v1:0");

/// <inheritdoc />
public class StableDiffusionImageCoreModel(BedrockProvider provider)
    : StableDiffusionTextToImageV2Model(provider, id: "stability.stable-image-core-v1:0");

/// <inheritdoc />
public class StableDiffusionImageUltraModel(BedrockProvider provider)
    : StableDiffusionTextToImageV2Model(provider, id: "stability.stable-image-ultra-v1:0");