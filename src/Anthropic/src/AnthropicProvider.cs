namespace LangChain.Providers.Anthropic;

/// <inheritdoc />
public class AnthropicProvider(string apiKey)
    : Provider(id: AnthropicConfiguration.SectionName)
{
    public AnthropicApi Api { get; } = new(apiKey);

    /// <summary>
    /// </summary>
    /// <param name="configuration"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static AnthropicProvider FromConfiguration(AnthropicConfiguration configuration)
    {
        configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));

        return new AnthropicProvider(configuration.ApiKey);
    }
}