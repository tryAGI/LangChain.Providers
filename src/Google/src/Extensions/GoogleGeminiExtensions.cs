using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using CSharpToJsonSchema;
using GenerativeAI;
using GenerativeAI.Types;
using Tool = CSharpToJsonSchema.Tool;

namespace LangChain.Providers.Google.Extensions;

internal static class GoogleGeminiExtensions
{
    public static bool IsFunctionCall(this GenerateContentResponse response)
    {
        return response.GetFunction() != null;
    }

    public static List<GenerativeAI.Types.Tool?> ToGenerativeAiTools(this IEnumerable<Tool> functions)
    {
        var declarations = functions
            .Where(x => x != null)
            .Select(x => new FunctionDeclaration
            {
                Name = x.Name ?? string.Empty,
                Description = x.Description ?? string.Empty,
                Parameters = x.Parameters is OpenApiSchema schema ? ToFunctionParameters(schema) : null,
            })
            .ToList();

        if (declarations.Any())
        {
            return new List<GenerativeAI.Types.Tool?>
            {
                new GenerativeAI.Types.Tool
                {
                    FunctionDeclarations = declarations
                }
            };
        }

        return null;
    }

    public static string GetStringForFunctionArgs(this object? arguments)
    {
        if (arguments == null)
            return string.Empty;
        if (arguments is JsonElement jsonElement)
            return jsonElement.ToString();
        else if (arguments is JsonNode jsonNode)
        {
            return jsonNode.ToJsonString();
        }
        else throw new Exception("Unknown type");
    }

    public static Schema? ToFunctionParameters(this OpenApiSchema openApiSchema)
    {
        var text = JsonSerializer.Serialize(openApiSchema,CSharpToJsonSchema.OpenApiSchemaJsonContext.Default.OpenApiSchema);
        return JsonSerializer.Deserialize<Schema?>(text,TypesSerializerContext.Default.Schema);
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