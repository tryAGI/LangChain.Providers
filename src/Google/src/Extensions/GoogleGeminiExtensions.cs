using System.Text.Json;
using System.Text.Json.Serialization;
using CSharpToJsonSchema;
using GenerativeAI.Tools;
using GenerativeAI.Types;

namespace LangChain.Providers.Google.Extensions;

internal static class GoogleGeminiExtensions
{
    public static bool IsFunctionCall(this EnhancedGenerateContentResponse response)
    {
        return response.GetFunction() != null;
    }

    public static List<GenerativeAITool> ToGenerativeAiTools(this IEnumerable<Tool> functions)
    {
        return new List<GenerativeAITool>([
            new GenerativeAITool
            {
                FunctionDeclaration = functions.Select(x => new ChatCompletionFunction
                {
                    Name = x.Name ?? string.Empty,
                    Description = x.Description ?? string.Empty,
                    Parameters = ToFunctionParameters((OpenApiSchema)x.Parameters!),
                }).ToList(),
            }
        ]);
    }
    public static ChatCompletionFunctionParameters ToFunctionParameters(this OpenApiSchema schema)
    {
        if (schema.Items == null) return new ChatCompletionFunctionParameters();
        var parameters = new ChatCompletionFunctionParameters();

        parameters.AdditionalProperties.Add("type", schema.Items.Type);
        if (schema.Items.Description != null && !string.IsNullOrEmpty(schema.Items.Description))
            parameters.AdditionalProperties.Add("description", schema.Items.Description);
        if (schema.Items.Properties != null)
            parameters.AdditionalProperties.Add("properties", schema.Items.Properties);
        if (schema.Items.Required != null)
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
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
[JsonSerializable(typeof(Dictionary<string, string>))]
internal sealed partial class SourceGenerationContext : JsonSerializerContext;