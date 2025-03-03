using System.Diagnostics;
using LangChain.Providers.OpenAI;
using Together;
using tryAGI.OpenAI;
using EmbeddingsClient = Together.EmbeddingsClient;

namespace LangChain.Providers.Together;

/// <summary>
/// </summary>
public class TogetherEmbeddingModel(TogetherProvider provider, string id)
    : Model<EmbeddingSettings>(id), IEmbeddingModel
{
    public TogetherEmbeddingModel(TogetherProvider provider,
        TogetherModelIds id) : this(provider,
        TogetherModelProvider.GetModelById(id).Id ?? throw new InvalidOperationException("Model not found"))
    {
    }

    private TogetherApi _client 
    {
        get
        {
            var togetherClient = new TogetherApi(provider.Client.HttpClient, provider.Client.BaseUri);
            var value = provider.Client.Authorizations[0].Value;
            togetherClient.AuthorizeUsingBearer(value);
            return togetherClient;
        }
    }

    /// <summary>
    /// API has limit of 2048 elements in array per request
    /// so we need to split texts into batches
    /// https://platform.openai.com/docs/api-reference/embeddings
    /// </summary>
    public int EmbeddingBatchSize { get; init; } = 2048;

    /// <inheritdoc/>
    public int MaximumInputLength => (int)(CreateEmbeddingRequestModelExtensions.ToEnum(Id)?.GetMaxInputTokens() ?? 0);


    /// <inheritdoc/>
    public async Task<EmbeddingResponse> CreateEmbeddingsAsync(
        EmbeddingRequest request,
        EmbeddingSettings? settings = default,
        CancellationToken cancellationToken = default)
    {
        request = request ?? throw new ArgumentNullException(nameof(request));

        var watch = Stopwatch.StartNew();

        var index = 0;
        var batches = new List<string[]>();
        while (index < request.Strings.Count)
        {
            batches.Add(request.Strings.Skip(index).Take(EmbeddingBatchSize).ToArray());
            index += EmbeddingBatchSize;
        }

        var usedSettings = OpenAiEmbeddingSettings.Calculate(
            requestSettings: settings,
            modelSettings: Settings,
            providerSettings: provider.EmbeddingSettings);


        var results = await Task.WhenAll(batches.Select(async batch =>
        {
            var response = await _client.Embeddings.EmbeddingsAsync(new EmbeddingsRequest()
                {
                    Input = batch,
                    Model = Id
                },
                cancellationToken: cancellationToken).ConfigureAwait(false);

            return response.Data
                .Select(static x => x.Embedding
                    .Select(static x => (float)x)
                    .ToArray())
                .ToArray();
        })).ConfigureAwait(false);

        return new EmbeddingResponse
        {
            Values = results
                .SelectMany(x => x)
                .ToArray(),
            UsedSettings = usedSettings,
            Usage = Usage,
            Dimensions = results.FirstOrDefault()?.FirstOrDefault()?.Length ?? 0,
        };
    }
}