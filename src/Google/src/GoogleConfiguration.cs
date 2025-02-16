namespace LangChain.Providers.Google;

/// <summary>
/// Configuration options for the Google AI provider.
/// </summary>
public class GoogleConfiguration
{
    /// <summary>
    /// Gets or sets the API key used for authentication with the Google AI service.
    /// </summary>
    public string? ApiKey { get; set; }

    /// <summary>
    /// Gets or sets the ID of the model to use. The default value is "gemini-1.5-flash".
    /// </summary>
    public string? ModelId { get; set; } = "gemini-1.5-flash";

    /// <summary>
    /// Gets or sets the Top-K sampling value, which determines the number of highest-probability tokens considered during decoding.
    /// </summary>
    public int? TopK { get; set; } = default!;

    /// <summary>
    /// Gets or sets the Top-P sampling value, which determines the cumulative probability threshold for token selection during decoding.
    /// </summary>
    public double? TopP { get; set; } = default!;

    /// <summary>
    /// Gets or sets the temperature value, which controls the randomness of the output. 
    /// Higher values produce more random results, while lower values make the output more deterministic. The default is 1.0.
    /// </summary>
    public double? Temperature { get; set; } = 1D;

    /// <summary>
    /// Gets or sets the maximum number of output tokens allowed in the response.
    /// </summary>
    public int? MaxOutputTokens { get; set; } = default!;
}