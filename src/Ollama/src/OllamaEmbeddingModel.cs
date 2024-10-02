using Ollama;

namespace LangChain.Providers.Ollama;

/// <summary>
/// 
/// </summary>
public class OllamaEmbeddingModel(
    OllamaProvider provider,
    string id)
    : Model<EmbeddingSettings>(id), IEmbeddingModel
{
    /// <summary>
    /// Provider of the model.
    /// </summary>
    public OllamaProvider Provider { get; } = provider ?? throw new ArgumentNullException(nameof(provider));

    //public int MaximumInputLength => 0;

    /// <inheritdoc />
    public async Task<EmbeddingResponse> CreateEmbeddingsAsync(
        EmbeddingRequest request,
        EmbeddingSettings? settings = null,
        CancellationToken cancellationToken = default)
    {
        request = request ?? throw new ArgumentNullException(nameof(request));

        try
        {
            var runningModels =
                await Provider.Api.Models.ListRunningModelsAsync(cancellationToken).ConfigureAwait(false);
            if (runningModels.Models != null &&
                runningModels.Models.All(x => x.Model?.Contains(Id) != true))
            {
                await Provider.Api.Models.PullModelAsync(Id, cancellationToken: cancellationToken)
                    .EnsureSuccessAsync().ConfigureAwait(false);
            }
        }
        catch (HttpRequestException)
        {
            // Ignore
        }

        var results = new List<IList<double>>(capacity: request.Strings.Count);
        foreach (var prompt in request.Strings)
        {
            var response = await Provider.Api.Embeddings.GenerateEmbeddingAsync(
                model: Id,
                prompt: prompt,
                options: new RequestOptions
                {
                    F16Kv = null,
                },
                keepAlive: null,
                cancellationToken).ConfigureAwait(false);

            results.Add(response.Embedding ?? []);
        }

        return new EmbeddingResponse
        {
            Values = results
                .Select(x => x.Select(y => (float)y).ToArray())
                .ToArray(),
            UsedSettings = EmbeddingSettings.Default,
            Dimensions = results.FirstOrDefault()?.Count ?? 0,
        };
    }
}