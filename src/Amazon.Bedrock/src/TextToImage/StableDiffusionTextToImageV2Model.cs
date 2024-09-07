using System.Diagnostics;
using System.Text.Json.Nodes;
using LangChain.Providers.Amazon.Bedrock.Internal;

// ReSharper disable once CheckNamespace
namespace LangChain.Providers.Amazon.Bedrock;

public class StableDiffusionTextToImageV2Model(
    BedrockProvider provider,
    string id)
    : TextToImageModel(id), ITextToImageModel
{
    public async Task<TextToImageResponse> GenerateImageAsync(
        TextToImageRequest request,
        TextToImageSettings? settings = null,
        CancellationToken cancellationToken = default)
    {
        request = request ?? throw new ArgumentNullException(nameof(request));

        var watch = Stopwatch.StartNew();

        var usedSettings = StableDiffusionSettings.Calculate(
            requestSettings: settings,
            modelSettings: Settings,
            providerSettings: provider.TextToImageSettings);

        var bodyJson = CreateBodyJson(request.Prompt, usedSettings);

        var response = await provider.Api.InvokeModelAsync<StableDiffusionSD3Response>(
            Id,
            bodyJson,
            cancellationToken).ConfigureAwait(false);

        var images = response?.Images.Select(Data.FromBase64).ToList() ?? [];

        var usage = Usage.Empty with
        {
            Time = watch.Elapsed,
        };
        AddUsage(usage);
        provider.AddUsage(usage);

        return new TextToImageResponse
        {
            Images = images,
            UsedSettings = TextToImageSettings.Default,
            Usage = usage,
        };
    }

    /// <summary>
    /// Creates the request body JSON for the Cohere model based on the provided prompt and settings.
    /// </summary>
    /// <param name="prompt">The input prompt for the model.</param>
    /// <param name="usedSettings">The settings to use for the request.</param>
    /// <returns>A `JsonObject` representing the request body.</returns>
    private static JsonObject CreateBodyJson(string prompt, StableDiffusionSettings usedSettings)
    {
        var bodyJson = new JsonObject
        {
            ["prompt"] = prompt,
            ["mode"] = usedSettings.Mode,
            ["aspect_ratio"] = usedSettings.AspectRatio,
            ["output_format"] = usedSettings.OutputFormat,
        };
        return bodyJson;
    }
}