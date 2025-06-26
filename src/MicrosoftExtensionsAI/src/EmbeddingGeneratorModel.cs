namespace LangChain.Providers.MicrosoftExtensionsAI;

/// <summary>Provides an <see cref="IEmbeddingModel"/> based on an <see cref="IEmbeddingGenerator"/>.</summary>
public sealed class EmbeddingGeneratorModel : Model<EmbeddingSettings>, IEmbeddingModel
{
    /// <summary>Initializes a new instance of the <see cref="EmbeddingGeneratorModel"/>.</summary>
    /// <param name="generator">The <see cref="IEmbeddingGenerator"/> to use.</param>
    /// <param name="id">The ID to use for the <see cref="IEmbeddingModel"/>.</param>
    public EmbeddingGeneratorModel(IEmbeddingGenerator generator, string? id = null) : base(id ?? $"embeddingGenerator{Guid.NewGuid():N}")
    {
        Generator = generator ?? throw new ArgumentNullException(nameof(generator));
    }

    /// <summary>Gets the underlying <see cref="IEmbeddingGenerator"/>.</summary>
    public IEmbeddingGenerator Generator { get; }

    /// <inheritdoc />
    public async Task<EmbeddingResponse> CreateEmbeddingsAsync(
        EmbeddingRequest request,
        EmbeddingSettings? settings = null,
        CancellationToken cancellationToken = default)
    {
        _ = request ?? throw new ArgumentNullException(nameof(request));

        if (request.Images is { Count: > 0 } && request.Strings.Count > 0)
        {
            throw new ArgumentException("Request cannot contain both images and strings.");
        }

        settings ??= EmbeddingSettings.Default;
        EmbeddingGenerationOptions? options =
            settings is EmbeddingGeneratorSettings generatorSettings ? generatorSettings.Options :
            null;

        if (request.Strings is { Count: > 0 } strings)
        {
            return Generator is IEmbeddingGenerator<string, Embedding<float>> generator ? 
                Process(await generator.GenerateAsync(strings, options, cancellationToken).ConfigureAwait(false)) :
                throw new InvalidOperationException("The generator does not support string embeddings.");
        }
        
        if (request.Images is { Count: > 0 } images)
        {
            return Generator is IEmbeddingGenerator<DataContent, Embedding<float>> generator ?
                Process(await generator.GenerateAsync([.. images.Select(i => new DataContent(i.ToByteArray(), "image/*"))], options, cancellationToken).ConfigureAwait(false)) :
                throw new InvalidOperationException("The generator does not support string embeddings.");
        }
        
        return Process([]);

        EmbeddingResponse Process(GeneratedEmbeddings<Embedding<float>> results)
        {
            Usage usage = results.Usage is { } resultsUsage ?
                new Usage
                {
                    InputTokens = (int?)resultsUsage.InputTokenCount ?? 0,
                    OutputTokens = (int?)resultsUsage.OutputTokenCount ?? 0,
                } :
                Usage.Empty;

            AddUsage(usage);

            return new EmbeddingResponse
            {
                Dimensions = results.FirstOrDefault()?.Vector.Length ?? 0,
                UsedSettings = settings,
                Usage = usage,
                Values = [.. results.Select(r => r.Vector.ToArray())],
            };
        }
    }
}