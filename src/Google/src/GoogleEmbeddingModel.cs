using GenerativeAI;
using GenerativeAI.Exceptions;
using GenerativeAI.Types;

namespace LangChain.Providers.Google;

using System.Diagnostics;

public class GoogleEmbeddingModel(
    GoogleProvider provider,
    string id)
    : Model<EmbeddingSettings>(id), IEmbeddingModel
{

    public EmbeddingModel EmbeddingModel { get; } =
        new EmbeddingModel(provider.ApiKey, id, httpClient: provider.HttpClient);


    public async Task<EmbeddingResponse> CreateEmbeddingsAsync(EmbeddingRequest request,
        EmbeddingSettings? settings = null,
        CancellationToken cancellationToken = default)
    {
        request = request ?? throw new ArgumentNullException(nameof(request));

        var watch = Stopwatch.StartNew();

        var usedSettings = GoogleEmbeddingSettings.Calculate(
            requestSettings: settings,
            modelSettings: Settings,
            providerSettings: provider.EmbeddingSettings);

        var embedRequest = new EmbedContentRequest();
        embedRequest.Content = new Content();
        embedRequest.Content.AddParts(request.Strings.Select(s => new Part(s)));

        embedRequest.OutputDimensionality = usedSettings.OutputDimensionality;
        var embedResponse = await this.EmbeddingModel.EmbedContentAsync(embedRequest, cancellationToken)
            .ConfigureAwait(false);

        var usage = Usage.Empty with
        {
            Time = watch.Elapsed,
        };
        AddUsage(usage);
        provider.AddUsage(usage);

        if (embedResponse.Embedding == null)
            throw new GenerativeAIException("Failed to create embeddings.", "");
        var values = embedResponse.Embedding.Values.ToList();

        return new EmbeddingResponse
        {
            Values = new[] { values.ToArray() }.ToArray(),
            Usage = Usage.Empty,
            UsedSettings = usedSettings,
            Dimensions = values.Count,
        };
    }
}
