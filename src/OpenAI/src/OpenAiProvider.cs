using OpenAI;

namespace LangChain.Providers.OpenAI;

/// <summary>
/// https://openai.com/
/// </summary>
public class OpenAiProvider : Provider
{
    #region Properties

    /// <summary>
    /// 
    /// </summary>
    public OpenAiApi Api { get; private set; }

    #endregion

    #region Constructors

    public OpenAiProvider(OpenAiApi openAiApi)
        : base(id: OpenAiConfiguration.SectionName)
    {
        Api = openAiApi ?? throw new ArgumentNullException(nameof(openAiApi));
    }

    public OpenAiProvider(OpenAiConfiguration configuration)
        : base(id: OpenAiConfiguration.SectionName)
    {
        configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        var apiKey = configuration.ApiKey ?? throw new ArgumentException("ApiKey is not defined", nameof(configuration));

        Api = configuration.Endpoint != null &&
              !string.IsNullOrWhiteSpace(configuration.Endpoint)
                ? new OpenAiApi(baseUri: new Uri(configuration.Endpoint))
                : new OpenAiApi();
        Api.AuthorizeUsingBearer(apiKey);
        ChatSettings = configuration.ChatSettings;
        EmbeddingSettings = configuration.EmbeddingSettings;
        TextToImageSettings = configuration.TextToImageSettings;
        ModerationSettings = configuration.ModerationSettings;
        SpeechToTextSettings = configuration.SpeechToTextSettings;
        TextToSpeechSettings = configuration.TextToSpeechSettings;
        ImageToTextSettings = configuration.ImageToTextSettings;
    }

    public OpenAiProvider(
        string apiKey,
        string? customEndpoint = null)
        : base(id: OpenAiConfiguration.SectionName)
    {
        apiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));

        Api = customEndpoint != null
            ? new OpenAiApi(baseUri: new Uri(customEndpoint))
            : new OpenAiApi();
        Api.AuthorizeUsingBearer(apiKey);
    }

    #endregion

    /// <inheritdoc cref="ToOpenAiProvider(string)"/>
    public static implicit operator OpenAiProvider(string apiKey)
    {
        return ToOpenAiProvider(apiKey);
    }

    /// <summary>
    /// Explicitly converts a string to a <see cref="OpenAiProvider"/> with this string as apiKey parameter. <br/>
    /// </summary>
    /// <param name="apiKey"></param>
    /// <returns></returns>
    public static OpenAiProvider ToOpenAiProvider(string apiKey)
    {
        return new OpenAiProvider(apiKey);
    }
}
