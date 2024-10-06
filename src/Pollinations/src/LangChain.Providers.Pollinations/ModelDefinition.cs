using System.Text.Json.Serialization;

namespace LangChain.Providers.Pollinations;

// as defined here https://text.pollinations.ai/models
public class ModelDefinition
{
    [JsonPropertyName("name")] public string? Name { get; set; }
    [JsonPropertyName("type")] public string? Type { get; set; }
    [JsonPropertyName("description")] public string? Description { get; set; }
    [JsonPropertyName("censored")] public bool? Censored { get; set; }
    [JsonPropertyName("baseModel")] public bool? BaseModel { get; set; }
}