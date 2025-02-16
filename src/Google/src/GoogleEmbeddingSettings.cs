using GenerativeAI.Types;

namespace LangChain.Providers.Google;

public class GoogleEmbeddingSettings:EmbeddingSettings
{
    /// <summary>
    /// Optional. Optional reduced dimension for the output embedding. If set, excessive values in the output embedding are truncated from the end. Supported by newer models since 2024 only. You cannot set this value if using the earlier model (models/embedding-001).
    /// </summary>
    public int? OutputDimensionality { get; set; }
    public new static GoogleEmbeddingSettings Default { get; } = new()
    {
        OutputDimensionality = null
    };
    
    /// <summary>
    /// Calculate the settings to use for the request.
    /// </summary>
    /// <param name="requestSettings"></param>
    /// <param name="modelSettings"></param>
    /// <param name="providerSettings"></param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public new static GoogleEmbeddingSettings Calculate(
        EmbeddingSettings? requestSettings,
        EmbeddingSettings? modelSettings,
        EmbeddingSettings? providerSettings)
    {
        var requestSettingsCasted = requestSettings as GoogleEmbeddingSettings;
        var modelSettingsCasted = modelSettings as GoogleEmbeddingSettings;
        var providerSettingsCasted = providerSettings as GoogleEmbeddingSettings;

        return new GoogleEmbeddingSettings
        {
            OutputDimensionality =
                requestSettingsCasted?.OutputDimensionality ??
                modelSettingsCasted?.OutputDimensionality ??
                providerSettingsCasted?.OutputDimensionality ??
                Default.OutputDimensionality
        };
    }
}