using System.Net;
using System.Text;
using System.Text.Json;
using System.Web;
using HtmlAgilityPack;
using LangChain.Providers.OpenRouter.CodeGenerator.Classes;
using LangChain.Providers.OpenRouter.CodeGenerator.Helpers;
using static System.Globalization.CultureInfo;
using static System.Text.RegularExpressions.Regex;

// ReSharper disable LocalizableElement

namespace LangChain.Providers.OpenRouter.CodeGenerator.Main;

internal static class OpenRouterCodeGenerator
{
    #region Public Methods

    /// <summary>
    /// Generate Models and Enum files
    /// </summary>
    /// <param name="options"></param>
    /// <returns></returns>
    public static async Task GenerateCodesAsync(GenerationOptions options)
    {
        options = options ?? throw new ArgumentNullException(nameof(options));

        //Load Open Router Docs Page...
        Console.WriteLine("Loading Model Page...");

        var html = await GetStringAsync(new Uri("https://openrouter.ai/api/v1/models")).ConfigureAwait(false);

        //Parse Json Object
        var modelsResponse = JsonSerializer.Deserialize<ListModelsResponse>(html);

        Console.WriteLine($"{modelsResponse.Models.Count} Models Found...");

        //Run Parallel loop for each model
        var list = new List<ModelInfo>();

        foreach (var model in modelsResponse.Models)
        {
            var modelInfo = ParseModelInfo(model, options);
            if (modelInfo == null) continue;
            list.Add(modelInfo);
        }

        //Sort Models by index
        var sorted = list.OrderBy(s => s.Index).ToList();

        //Create AllModels.cs
        // Console.WriteLine("Creating AllModels.cs...");
        //await CreateAllModelsFile(sorted, options.OutputFolder).ConfigureAwait(false);

        //Create OpenRouterModelIds.cs
        Console.WriteLine("Creating OpenRouterModelIds.cs...");
        await CreateOpenRouterModelIdsFile(sorted, options.OutputFolder).ConfigureAwait(false);

        //Create OpenRouterModelIds.cs
        Console.WriteLine("Creating OpenRouterModelProvider.cs...");
        await CreateOpenRouterModelProviderFile(sorted, options.OutputFolder).ConfigureAwait(false);

        Console.WriteLine("Task Completed!");
    }

    #endregion

    #region Private Methods

    /// <summary>
    ///     Creates Codes\OpenRouterModelProvider.cs
    /// </summary>
    /// <param name="sorted"></param>
    /// <param name="outputFolder"></param>
    /// <returns></returns>
    private static async Task CreateOpenRouterModelProviderFile(List<ModelInfo> sorted, string outputFolder)
    {
        var sb3 = new StringBuilder();
        var first = true;
        HashSet<string?> keys = new HashSet<string?>();
        foreach (var item in sorted)
        {
            if (!keys.Add(item.EnumMemberName))
                continue;

            if (first)
            {
                sb3.AppendLine(item.DicAddCode);
                first = false;
                continue;
            }

            sb3.AppendLine($"        {item.DicAddCode}");
        }

        var dicsAdd =
            H.Resources.OpenRouterModelProvider_cs.AsString()
                .Replace("{{DicAdd}}", sb3.ToString(), StringComparison.InvariantCulture);
        Directory.CreateDirectory(outputFolder);
        var fileName = Path.Combine(outputFolder, "OpenRouterModelProvider.cs");
        await File.WriteAllTextAsync(fileName, dicsAdd).ConfigureAwait(false);
        Console.WriteLine($"Saved to {fileName}");
    }

    /// <summary>
    ///     Creates Codes\OpenRouterModelIds.cs
    /// </summary>
    /// <param name="sorted"></param>
    /// <param name="outputFolder"></param>
    /// <returns></returns>
    private static async Task CreateOpenRouterModelIdsFile(List<ModelInfo> sorted, string outputFolder)
    {
        var sb3 = new StringBuilder();
        foreach (var item in sorted)
        {
            var tem = item.EnumMemberCode?
                    .Replace("\r\n", "\n", StringComparison.InvariantCulture)
                    .Replace("\n", "\n        ", StringComparison.InvariantCulture)
                ;
            sb3.Append(tem);
        }

        var modelIdsContent =
            H.Resources.OpenRouterModelIds_cs.AsString()
                .Replace("{{ModelIds}}", sb3.ToString(), StringComparison.InvariantCulture);
        Directory.CreateDirectory(outputFolder);
        var fileName = Path.Combine(outputFolder, "OpenRouterModelIds.cs");
        await File.WriteAllTextAsync(fileName, modelIdsContent).ConfigureAwait(false);
        Console.WriteLine($"Saved to {fileName}");
    }

    /// <summary>
    ///     Creates Codes\Predefined\AllModels.cs file
    /// </summary>
    /// <param name="sorted"></param>
    /// <param name="outputFolder"></param>
    /// <returns></returns>
    private static async Task CreateAllModelsFile(List<ModelInfo> sorted, string outputFolder)
    {
        var sb3 = new StringBuilder();
        foreach (var item in sorted)
        {
            sb3.AppendLine(item.PredefinedClassCode);
            sb3.AppendLine();
        }

        var classesFileContent =
            H.Resources.AllModels_cs.AsString()
                .Replace("{{OpenRouterClasses}}", sb3.ToString(), StringComparison.InvariantCulture);
        var path1 = Path.Join(outputFolder, "Predefined");
        Directory.CreateDirectory(path1);
        var fileName = Path.Combine(path1, "AllModels.cs");
        await File.WriteAllTextAsync(fileName, classesFileContent).ConfigureAwait(false);
        Console.WriteLine($"Saved to {fileName}");
    }

    /// <summary>
    /// Parses model information and generates a ModelInfo object based on the provided model and generation options.
    /// </summary>
    /// <param name="model">The model containing relevant details such as name, id, description, context length, and pricing information.</param>
    /// <param name="options">Generation options used for customization during the parsing process.</param>
    /// <returns>A ModelInfo object containing parsed information, or null if the input model information is insufficient.</returns>
    private static ModelInfo? ParseModelInfo(Model model, GenerationOptions options)
    {
        //Modal Name
        var modelName = model.Name;

        if (string.IsNullOrEmpty(modelName))
            return null;

        //Model Id
        var modelId = model.Id;

        var enumMemberName = GetModelIdsEnumMemberFromName(modelId, modelName, options);

        var description = GetDescription(model);

        //Enum Member code with doc
        var enumMemberCode = GetEnumMemberCode(enumMemberName, description);

        //Parse Cost of Prompt/Input per 1000 token
        var promptCostText = model.Pricing?.Prompt;


        //Parse Cost of Completion/Output Tokens
        var completionCostText = model.Pricing?.Completion;

        //Parse Context Length

        var tokenLength =
            model.ContextLength;

        //Calculate Cost per Token
        if (double.TryParse(promptCostText, out var promptCost)) promptCost = promptCost / 1000000;

        if (double.TryParse(completionCostText, out var completionCost)) completionCost = completionCost / 1000000;


        //Code for adding ChatModel into Dictionary<OpenRouterModelIds,ChatModels>() 
        var dicAddCode = GetDicAddCode(enumMemberName, modelId, tokenLength.ToString(), promptCost, completionCost);

        //Code for Predefined Model Class
        var predefinedClassCode = GetPreDefinedClassCode(enumMemberName);

        return new ModelInfo
        {
            DicAddCode = dicAddCode,
            EnumMemberName = enumMemberName,
            //Index = i,
            ModelId = modelId,
            ModelName = modelName,
            PredefinedClassCode = predefinedClassCode,
            EnumMemberCode = enumMemberCode,
            Description = description
        };
    }

    private static string GetEnumMemberCode(string enumMemberName, string description)
    {
        var sb2 = new StringBuilder();

        sb2.AppendLine();
        sb2.AppendLine("/// <summary>");
        sb2.AppendLine(
            $"/// {description.Replace("&", "and", StringComparison.OrdinalIgnoreCase).Replace("<", "less ", StringComparison.OrdinalIgnoreCase).Replace("less br/>", "<br/>", StringComparison.OrdinalIgnoreCase)}");
        sb2.AppendLine("/// </summary>");
        sb2.AppendLine($"{enumMemberName},");

        return sb2.ToString();
    }

    private static string GetPreDefinedClassCode(string enumMemberName)
    {
        var sb = new StringBuilder();
        sb.AppendLine(
            $"/// <inheritdoc cref=\"OpenRouterModelIds.{enumMemberName}\"/>\r\n/// <param name=\"provider\">Open Router Provider Instance</param>");
        if (enumMemberName.StartsWith("_", StringComparison.OrdinalIgnoreCase))
        {
            sb.AppendLine(
                $"public class {enumMemberName}Model(OpenRouterProvider provider) : OpenRouterModel(provider, OpenRouterModelIds.{enumMemberName});");
        }
        else
        {
            sb.AppendLine(
                $"public class {enumMemberName.Replace("_", "", StringComparison.OrdinalIgnoreCase)}Model(OpenRouterProvider provider) : OpenRouterModel(provider, OpenRouterModelIds.{enumMemberName});");
        }

        return sb.ToString();
    }

    private static string GetDicAddCode(string enumMemberName, string modelId, string tokenLength, double promptCost,
        double completionCost)
    {
        return FormattableString.Invariant($@"
        [OpenRouterModelIds.{enumMemberName}] = new ChatModelMetadata
        {{
            Id = ""{modelId}"",
            ContextLength = {tokenLength},
            PricePerInputTokenInUsd = {promptCost},
            PricePerOutputTokenInUsd = {completionCost},
        }},
");
    }

    /// <summary>
    ///     Creates Enum Member name from Model Name with C# convention
    /// </summary>
    /// <param name="modelId"></param>
    /// <param name="modelName"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    private static string GetModelIdsEnumMemberFromName(string modelId, string modelName, GenerationOptions options)
    {
        var enumType = Replace(modelName, "[_.: -]", "_");
        enumType = Replace(enumType, "[()]", "");

        enumType = enumType
            .Replace("__", "_", StringComparison.InvariantCulture)
            .Replace("_🐬", "", StringComparison.InvariantCulture);

        enumType = CurrentCulture.TextInfo.ToTitleCase(enumType
            .Replace("_", " ", StringComparison.InvariantCulture).ToLower(CurrentCulture));

        enumType = options.ReplaceEnumNameFunc?.Invoke(enumType, modelId, modelName) ?? enumType;

        int x;
        if (int.TryParse(enumType[0].ToString(), out x))
        {
            enumType = "_" + enumType;
        }
        return enumType;
    }

    /// <summary>
    /// Extracts a detailed description from the given model.
    /// </summary>
    /// <param name="model">The model instance containing the description field.</param>
    /// <returns>A formatted string representation of the model's description.</returns>
    private static string GetDescription(Model model)
    {
        var sb = new StringBuilder();
        var first = true;
        foreach (var text in model.Description.Split("\r\n".ToCharArray()))
        {
            var text3 = text;
            if (first)
            {
                sb.AppendLine(text3 + "  <br/>");
                first = false;
            }

            if (sb.ToString().Contains(text3, StringComparison.OrdinalIgnoreCase))
                continue;
            sb.AppendLine($"/// {text3}  <br/>");
        }

        var html = sb.ToString().Trim();

        return html;
    }

    /// <summary>
    ///     Creates HttpClient
    /// </summary>
    /// <returns></returns>
    private static async Task<string> GetStringAsync(Uri uri, CancellationToken cancellationToken = default)
    {
        using var handler = new HttpClientHandler();
        handler.CheckCertificateRevocationList = true;
        handler.AutomaticDecompression =
            DecompressionMethods.Deflate | DecompressionMethods.Brotli | DecompressionMethods.GZip;
        using var client = new HttpClient(handler);
        client.DefaultRequestHeaders.Add("Accept", "*/*");
        client.DefaultRequestHeaders.Add("UserAgent",
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/123.0.0.0 Safari/537.36");
        client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate, br");

        using var cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
        cancellationTokenSource.CancelAfter(TimeSpan.FromMinutes(5));

        while (!cancellationToken.IsCancellationRequested)
        {
            try
            {
                return await client.GetStringAsync(uri, cancellationToken).ConfigureAwait(false);
            }
            catch (HttpRequestException)
            {
                await Task.Delay(TimeSpan.FromSeconds(5), cancellationToken).ConfigureAwait(false);
            }
        }

        throw new TaskCanceledException();
    }

    #endregion
}