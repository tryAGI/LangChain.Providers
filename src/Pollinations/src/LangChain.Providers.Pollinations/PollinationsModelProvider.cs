using System.Text.Json;

namespace LangChain.Providers.Pollinations;

public class PollinationsModelProvider
{

    public static async Task<List<ModelDefinition>> GetModels()
    {
        using (HttpClient client = new HttpClient())
        {
            var response = await client.GetAsync(new Uri("https://text.pollinations.ai/models")).ConfigureAwait(false);

            return JsonSerializer.Deserialize<List<ModelDefinition>>(await response.Content.ReadAsStringAsync()
                       .ConfigureAwait(false))
                   ?? throw new JsonException(
                       $"Unable to parse response from {client.BaseAddress}\n response was: {response.Content}");
        }
    }

    public Dictionary<string, ModelDefinition> AvailableModels { get; } = new();

    public PollinationsModelProvider()
    {
        foreach (var modelDef in GetModels().Result)
        {
            AvailableModels[modelDef.Name!] = modelDef; // Name should not be null if the JSON was parsed , I think?
        }
    }
}