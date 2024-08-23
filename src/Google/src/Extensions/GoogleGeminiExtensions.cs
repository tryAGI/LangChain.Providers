using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using GenerativeAI.Tools;
using GenerativeAI.Types;

namespace LangChain.Providers.Google.Extensions;

internal static class GoogleGeminiExtensions
{
    public static bool IsFunctionCall(this EnhancedGenerateContentResponse response)
    {
        return response.GetFunction() != null;
    }

    public static List<GenerativeAITool> ToGenerativeAiTools(this IEnumerable<OpenApiSchema> functions)
    {
        return new List<GenerativeAITool>([
            new GenerativeAITool
            {
                FunctionDeclaration = functions.Select(x => new ChatCompletionFunction
                {
                    Name = x.Type,
                    Description = x.Description,
                    Parameters = x.ToFunctionParameters()
                }).ToList(),
            }
        ]);
    }
    public static ChatCompletionFunctionParameters ToFunctionParameters(this OpenApiSchema schema)
    {
        if (schema.Items == null) return new ChatCompletionFunctionParameters();
        var parameters = new ChatCompletionFunctionParameters();

        parameters.AdditionalProperties.Add("type", schema.Items.Type);
        if (!string.IsNullOrEmpty(schema.Items.Description))
            parameters.AdditionalProperties.Add("description", schema.Items.Description);
        parameters.AdditionalProperties.Add("properties", schema.Items.Properties);
        parameters.AdditionalProperties.Add("required", schema.Items.Required);

        return parameters;
    }
    public static string GetString(this IDictionary<string, object>? arguments)
    {
        if (arguments == null)
            return string.Empty;

        var dictionary = arguments.ToDictionary(
            x => x.Key,
            x => x.Value.ToString() ?? string.Empty);

        return JsonSerializer.Serialize(dictionary, SourceGenerationContext.Default.DictionaryStringString);
    }
}

[JsonSourceGenerationOptions(
    PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
    Converters = [typeof(JsonStringEnumConverter)])]
[JsonSerializable(typeof(Dictionary<string, string>))]
internal sealed partial class SourceGenerationContext : JsonSerializerContext;