using System.Diagnostics.CodeAnalysis;

#pragma warning disable CA1849

namespace LangChain.Providers.MicrosoftExtensionsAI;

/// <summary>Provides an <see cref="ISpeechToTextModel"/> based on an <see cref="ISpeechToTextClient"/>.</summary>
[Experimental("MEAI001")]
public sealed class SpeechToTextClientModel : Model<SpeechToTextSettings>, ISpeechToTextModel
{
    /// <summary>Initializes a new instance of the <see cref="SpeechToTextClientModel"/>.</summary>
    /// <param name="client">The <see cref="ISpeechToTextClient"/> to use.</param>
    /// <param name="id">The ID to use for the <see cref="ISpeechToTextModel"/>.</param>
    public SpeechToTextClientModel(ISpeechToTextClient client, string id) : base(id)
    {
        Client = client ?? throw new ArgumentNullException(nameof(client));
    }

    /// <summary>Gets the underlying <see cref="ISpeechToTextClient"/>.</summary>
    public ISpeechToTextClient Client { get; }

    /// <inheritdoc />
    public async Task<SpeechToTextResponse> TranscribeAsync(SpeechToTextRequest request, SpeechToTextSettings? settings = null, CancellationToken cancellationToken = default)
    {
        _ = request ?? throw new ArgumentNullException(nameof(request));

        settings ??= SpeechToTextSettings.Default;

        SpeechToTextOptions? options =
            settings is SpeechToTextClientSettings clientSettings ? clientSettings.Options :
            null;

        try
        {
            var response = await Client.GetTextAsync(request.Stream, options, cancellationToken).ConfigureAwait(false);
            return new SpeechToTextResponse()
            {
                Text = response.Text,
            };
        }
        finally
        {
            if (request.OwnsStream)
            {
                request.Stream.Dispose();
            }
        }
    }
}