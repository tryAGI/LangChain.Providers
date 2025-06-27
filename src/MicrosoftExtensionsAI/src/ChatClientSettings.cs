// ReSharper disable once CheckNamespace
namespace LangChain.Providers.MicrosoftExtensionsAI;

/// <summary>Settings for use with a <see cref="ChatClientModel"/>.</summary>
public sealed class ChatClientSettings : ChatSettings
{
    /// <summary>Gets or sets the <see cref="ChatOptions"/> to use with a request to the <see cref="IChatClient"/>.</summary>
    public ChatOptions? Options { get; set; }
}