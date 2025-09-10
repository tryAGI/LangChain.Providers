// ReSharper disable once CheckNamespace
namespace LangChain.Providers.MicrosoftExtensionsAI;

/// <summary>Settings for use with a <see cref="EmbeddingGeneratorModel"/>.</summary>
public sealed class EmbeddingGeneratorSettings : EmbeddingSettings
{
    /// <summary>Gets or sets the <see cref="EmbeddingGenerationOptions"/> to use with a request to the <see cref="IEmbeddingGenerator"/>.</summary>
    public EmbeddingGenerationOptions? Options { get; set; }
}