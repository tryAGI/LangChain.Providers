// ReSharper disable once CheckNamespace
using System.Diagnostics.CodeAnalysis;

namespace LangChain.Providers.MicrosoftExtensionsAI;

/// <summary>Settings for use with a <see cref="SpeechToTextClientModel"/>.</summary>
[Experimental("MEAI001")]
public sealed class SpeechToTextClientSettings : SpeechToTextSettings
{
    /// <summary>Gets or sets the <see cref="SpeechToTextOptions"/> to use with a request to the <see cref="ISpeechToTextClient"/>.</summary>
    public SpeechToTextOptions? Options { get; set; }
}