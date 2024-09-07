// ReSharper disable once CheckNamespace
namespace LangChain.Providers.Amazon.Bedrock;

public class StableDiffusionSettings : TextToImageSettings
{
    public new static StableDiffusionSettings Default { get; } = new()
    {
        Mode = "text-to-image",
        AspectRatio = "1:1",
        OutputFormat = "jpeg",
    };

    /// <summary>
    /// 
    /// </summary>
    public string? Mode{ get; init; }
    /// <summary>
    /// 
    /// </summary>
    public string? AspectRatio { get; init; }

    /// <summary>
    /// 
    /// </summary>
    public string? OutputFormat { get; init; }

    
    /// <summary>
    /// Calculate the settings to use for the request.
    /// </summary>
    /// <param name="requestSettings"></param>
    /// <param name="modelSettings"></param>
    /// <param name="providerSettings"></param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public static StableDiffusionSettings Calculate(
        TextToImageSettings? requestSettings,
        TextToImageSettings? modelSettings,
        TextToImageSettings? providerSettings)
    {
        var requestSettingsCasted = requestSettings as StableDiffusionSettings;
        var modelSettingsCasted = modelSettings as StableDiffusionSettings;
        var providerSettingsCasted = providerSettings as StableDiffusionSettings;

        return new StableDiffusionSettings
        {
            Mode =
              requestSettingsCasted?.Mode ??
              modelSettingsCasted?.Mode ??
              providerSettingsCasted?.Mode ??
              Default.Mode ??
              throw new InvalidOperationException("Default Mode is not set."),
            AspectRatio =
              requestSettingsCasted?.AspectRatio ??
              modelSettingsCasted?.AspectRatio ??
              providerSettingsCasted?.AspectRatio ??
              Default.AspectRatio ??
              throw new InvalidOperationException("Default AspectRatio is not set."),
            OutputFormat =
              requestSettingsCasted?.OutputFormat ??
              modelSettingsCasted?.OutputFormat ??
              providerSettingsCasted?.OutputFormat ??
              Default.OutputFormat ??
              throw new InvalidOperationException("Default OutputFormat is not set."),
        };
    }
}