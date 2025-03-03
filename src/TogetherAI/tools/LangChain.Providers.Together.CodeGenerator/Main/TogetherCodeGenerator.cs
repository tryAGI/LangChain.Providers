﻿using System.Net;
using System.Text;
using System.Text.Json;
using H;
using LangChain.Providers.Together.CodeGenerator.Classes;
using Newtonsoft.Json.Linq;
using static System.Globalization.CultureInfo;
using static System.Text.RegularExpressions.Regex;

// ReSharper disable LocalizableElement

namespace LangChain.Providers.Together.CodeGenerator.Main;

internal static class TogetherCodeGenerator
{
    #region Public Methods

    /// <summary>
    ///     Generate Models and Enum files
    /// </summary>
    /// <param name="options"></param>
    /// <returns></returns>
    public static async Task GenerateCodesAsync(GenerationOptions options)
    {
        options = options ?? throw new ArgumentNullException(nameof(options));

        if (string.IsNullOrEmpty(options.TogetherApiKey))
            throw new ArgumentException(nameof(options.TogetherApiKey));

        
        //Load Together Ai Model Info...
        Console.WriteLine("Loading Model Page...");
        var models = await GetModelInfosAsync(options).ConfigureAwait(false);
        Console.WriteLine($"{models.Length} Models Found...");


        //Run loop for each model
        var textModels = GetTextModels(models,options);
        var embeddingModels = GetEmbeddingModels(models,options);
        
        //Sort Models by index
        var sorted = textModels.OrderBy(s => s.Index).ToList();

        //Create AllModels.cs
       // Console.WriteLine("Creating AllModels.cs...");
        //await CreateAllModelsFile(sorted, options.OutputFolder).ConfigureAwait(false);

        //Create AllEmbeddingModels.cs
       // Console.WriteLine("Creating AllEmbeddingModels.cs...");
       // await CreateAllEmbeddingModelsFile(embeddingModels, options.OutputFolder).ConfigureAwait(false);

        sorted.AddRange(embeddingModels);
        //Create TogetherModelIds.cs
        Console.WriteLine("Creating TogetherModelIds.cs...");
        await CreateTogetherModelIdsFile(sorted, options.OutputFolder).ConfigureAwait(false);

        //Create TogetherModelIds.cs
        Console.WriteLine("Creating TogetherModelProvider.cs...");
        await CreateTogetherModelProviderFile(sorted, options.OutputFolder).ConfigureAwait(false);

        Console.WriteLine($"{textModels.Count} Models added into repo.");
        Console.WriteLine("Task Completed!");
    }

    private static async Task CreateAllEmbeddingModelsFile(List<ModelInfo> sorted, string outputFolder)
    {
        var sb3 = new StringBuilder();
        foreach (var item in sorted)
        {
            sb3.AppendLine(item.PredefinedClassCode);
            sb3.AppendLine();
        }

        var classesFileContent =
            Resources.AllModels_cs.AsString()
                .Replace("{{TogetherClasses}}", sb3.ToString(), StringComparison.InvariantCulture);
        var path1 = Path.Join(outputFolder, "Predefined");
        Directory.CreateDirectory(path1);
        var fileName = Path.Combine(path1, "AllEmbeddingModels.cs");
        await File.WriteAllTextAsync(fileName, classesFileContent).ConfigureAwait(false);
        Console.WriteLine($"Saved to {fileName}");
    }

    private static List<ModelInfo> GetEmbeddingModels(ModelData[] models, GenerationOptions options = null)
    {
        List<ModelInfo> list = new();
        var duplicateSet = new HashSet<string?>();

        int count = 0;
        for (var i = 0; i < models.Length; i++)
        {
            var item = ParseEmbeddingModelInfo(count, models[i], options);

            if (item != null && duplicateSet.Add(item.EnumMemberName))
            {
                list.Add(item);
                count++;
            }
        }

        return list;
    }

    private static List<ModelInfo> GetTextModels(ModelData[] models, GenerationOptions options = null)
    {
        List<ModelInfo> list = new();
        var duplicateSet = new HashSet<string?>();

        int count = 0;
        for (var i = 0; i < models.Length; i++)
        {
            var item = ParseModelInfo(count, models[i], options);

            if (item != null && duplicateSet.Add(item.EnumMemberName))
            {
                list.Add(item);
                count++;
            }
        }

        return list;
    }

    private static async Task<ModelData[]> GetModelInfosAsync(GenerationOptions options)
    {
        var modelInfoText = await GetStringAsync(new Uri("https://api.together.xyz/api/models?&info"), options)
            .ConfigureAwait(false);

        return JsonSerializer.Deserialize<ModelData[]>(modelInfoText);
    }

    #endregion

    #region Private Methods

    /// <summary>
    ///     Creates Codes\TogetherModelProvider.cs
    /// </summary>
    /// <param name="sorted"></param>
    /// <param name="outputFolder"></param>
    /// <returns></returns>
    private static async Task CreateTogetherModelProviderFile(List<ModelInfo> sorted, string outputFolder)
    {
        var sb3 = new StringBuilder();
        var first = true;
        var keys = new HashSet<string?>();
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
            Resources.TogetherAiModelProvider_cs.AsString()
                .Replace("{{DicAdd}}", sb3.ToString(), StringComparison.InvariantCulture);
        Directory.CreateDirectory(outputFolder);
        var fileName = Path.Combine(outputFolder, "TogetherModelProvider.cs");
        await File.WriteAllTextAsync(fileName, dicsAdd).ConfigureAwait(false);
        Console.WriteLine($"Saved to {fileName}");
    }

    /// <summary>
    ///     Creates Codes\TogetherModelIds.cs
    /// </summary>
    /// <param name="sorted"></param>
    /// <param name="outputFolder"></param>
    /// <returns></returns>
    private static async Task CreateTogetherModelIdsFile(List<ModelInfo> sorted, string outputFolder)
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
            Resources.TogetherAiModelIds_cs.AsString()
                .Replace("{{ModelIds}}", sb3.ToString(), StringComparison.InvariantCulture);
        Directory.CreateDirectory(outputFolder);
        var fileName = Path.Combine(outputFolder, "TogetherModelIds.cs");
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
            Resources.AllModels_cs.AsString()
                .Replace("{{TogetherClasses}}", sb3.ToString(), StringComparison.InvariantCulture);
        var path1 = Path.Join(outputFolder, "Predefined");
        Directory.CreateDirectory(path1);
        var fileName = Path.Combine(path1, "AllModels.cs");
        await File.WriteAllTextAsync(fileName, classesFileContent).ConfigureAwait(false);
        Console.WriteLine($"Saved to {fileName}");
    }

    /// <summary>
    ///     Parses Model info from open router docs
    /// </summary>
    /// <param name="i"></param>
    /// <param name="modelToken"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    private static ModelInfo? ParseModelInfo(int i, ModelData? modelToken, GenerationOptions options)
    {
        if (modelToken == null)
            return null;
        
        if ((string?)modelToken.DisplayType != "chat" && (string?)modelToken.DisplayType != "code" )
            return null;
        
        if (modelToken.Instances == null ) return null;

        //Modal Name
        var modelName = modelToken.DisplayName;

        if (string.IsNullOrEmpty(modelName))
            return null;

        //Model Id
        var modelId = modelToken.Name;

        if(string.IsNullOrEmpty(modelId))
            return null;
        var organization = modelToken.CreatorOrganization;
        var enumMemberName = GetModelIdsEnumMemberFromName(modelId, modelName, options);


        var length = modelToken.ContextLength;
        if (length == null)
            return null;
        var contextLength = (modelToken.ContextLength ?? 0);
        var tokenLength = contextLength.ToString();
        var promptCost = (double)(modelToken.Pricing?.Input ?? 0) * 0.004;
        var completionCost = (double)(modelToken.Pricing?.Output ?? 0) * 0.004;

        var description =
            FormattableString.Invariant($"Name: {(string)modelName} <br/>\r\n/// Organization: {organization} <br/>\r\n/// Context Length: {contextLength} <br/>\r\n/// Prompt Cost: ${promptCost}/MTok <br/>\r\n/// Completion Cost: ${promptCost}/MTok <br/>\r\n/// Description: {(string?)modelToken.Description} <br/>\r\n/// HuggingFace Url: <a href=\"https://huggingface.co/{modelId}\">https://huggingface.co/{modelId}</a>");

        //Enum Member code with doc
        var enumMemberCode = GetEnumMemberCode(enumMemberName, description);

        //Code for adding ChatModel into Dictionary<Together AiModelIds,ChatModels>() 
        var dicAddCode = GetDicAddCode(enumMemberName, modelId, tokenLength, promptCost / (1000 * 1000),
            completionCost / (1000 * 1000));

        //Code for Predefined Model Class
        var predefinedClassCode = GetPreDefinedClassCode(enumMemberName);

        return new ModelInfo
        {
            DicAddCode = dicAddCode,
            EnumMemberName = enumMemberName,
            Index = i,
            ModelId = modelId,
            ModelName = modelName,
            PredefinedClassCode = predefinedClassCode,
            EnumMemberCode = enumMemberCode,
            Description = description,
            ModeType = GetModelType(modelToken.DisplayType),
        };
    }
    
    /// <summary>
    ///     Parses Model info from open router docs
    /// </summary>
    /// <param name="i"></param>
    /// <param name="modelToken"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    private static ModelInfo? ParseEmbeddingModelInfo(int i, ModelData? modelToken, GenerationOptions options)
    {
        if (modelToken == null)
            return null;
        
        if ((string?)modelToken.DisplayType != "embedding" )
            return null;
        
        if (modelToken.Instances == null ) return null;

        //Modal Name
        var modelName = modelToken.DisplayName;

        if (string.IsNullOrEmpty(modelName))
            return null;

        //Model Id
        var modelId = modelToken.Name;

        if(string.IsNullOrEmpty(modelId))
            return null;
        var organization = modelToken.CreatorOrganization;
        var enumMemberName = GetModelIdsEnumMemberFromName(modelId, modelName, options);


        // var length = modelToken.ContextLength;
        // if (length == null)
        //     return null;
        // var contextLength = (modelToken.ContextLength ?? 0);
        //var tokenLength = contextLength.ToString();
        var promptCost = (double)(modelToken.Pricing?.Input ?? 0) * 0.004;
        var completionCost = (double)(modelToken.Pricing?.Output ?? 0) * 0.004;

        var description =
            FormattableString.Invariant($"Name: {(string)modelName} <br/>\r\n/// Organization: {organization} <br/>\r\n/// Prompt Cost: ${promptCost}/MTok <br/>\r\n/// Completion Cost: ${promptCost}/MTok <br/>\r\n/// Description: {(string?)modelToken.Description} <br/>\r\n/// HuggingFace Url: <a href=\"https://huggingface.co/{modelId}\">https://huggingface.co/{modelId}</a>");

        //Enum Member code with doc
        var enumMemberCode = GetEnumMemberCode(enumMemberName, description);

        //Code for adding ChatModel into Dictionary<Together AiModelIds,ChatModels>() 
        var dicAddCode = GetDicAddCode(enumMemberName, modelId, "0", promptCost / (1000 * 1000),
            completionCost / (1000 * 1000));

        //Code for Predefined Model Class
        var predefinedClassCode = GetPreDefinedEmbeddingClassCode(enumMemberName);

        return new ModelInfo
        {
            DicAddCode = dicAddCode,
            EnumMemberName = enumMemberName,
            Index = i,
            ModelId = modelId,
            ModelName = modelName,
            PredefinedClassCode = predefinedClassCode,
            EnumMemberCode = enumMemberCode,
            Description = description,
            ModeType = GetModelType(modelToken.DisplayType),
        };
    }

    private static ModelType GetModelType(string displayType)
    {
        return displayType switch
        {
            "chat" or "code" => ModelType.Text,
            "embedding" => ModelType.Embedding,
            "image" => ModelType.Image,
            _ => throw new ArgumentOutOfRangeException(nameof(displayType), displayType, null)
        };
    }

    private static string GetEnumMemberCode(string enumMemberName, string description)
    {
        var sb2 = new StringBuilder();

        sb2.AppendLine();
        sb2.AppendLine("/// <summary>");
        sb2.AppendLine($"/// {description}");
        sb2.AppendLine("/// </summary>");
        sb2.AppendLine($"{enumMemberName},");

        return sb2.ToString();
    }

    private static string GetPreDefinedClassCode(string enumMemberName)
    {
        var sb = new StringBuilder();
        sb.AppendLine(
            $"/// <inheritdoc cref=\"TogetherModelIds.{enumMemberName}\"/>\r\n/// <param name=\"provider\">Together AI Provider Instance</param>");
        sb.AppendLine(
            $"public class {enumMemberName}Model(TogetherProvider provider) : TogetherModel(provider, TogetherModelIds.{enumMemberName});");
        return sb.ToString();
    }
    
    private static string GetPreDefinedEmbeddingClassCode(string enumMemberName)
    {
        var sb = new StringBuilder();
        sb.AppendLine(
            $"/// <inheritdoc cref=\"TogetherModelIds.{enumMemberName}\"/>\r\n/// <param name=\"provider\">Together AI Provider Instance</param>");
        sb.AppendLine(
            $"public class {enumMemberName}EmbeddingModel(TogetherProvider provider) : TogetherEmbeddingModel(provider, TogetherModelIds.{enumMemberName});");
        return sb.ToString();
    }

    private static string GetDicAddCode(string enumMemberName, string modelId, string tokenLength, double promptCost,
        double completionCost)
    {
        return "{ " +
               FormattableString.Invariant($"TogetherModelIds.{enumMemberName}, ToMetadata(\"{modelId}\",{tokenLength},{promptCost},{completionCost})") +
               "},";
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

        return enumType;
    }


    /// <summary>
    ///     Get String From Uri
    /// </summary>
    /// <returns></returns>
    private static async Task<string> GetStringAsync(Uri uri, GenerationOptions options,
        CancellationToken cancellationToken = default)
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
        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {options.TogetherApiKey}");

        using var cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
        cancellationTokenSource.CancelAfter(TimeSpan.FromMinutes(5));

        while (!cancellationToken.IsCancellationRequested)
            try
            {
                return await client.GetStringAsync(uri, cancellationToken).ConfigureAwait(false);
            }
            catch (HttpRequestException)
            {
                await Task.Delay(TimeSpan.FromSeconds(5), cancellationToken).ConfigureAwait(false);
            }

        throw new TaskCanceledException();
    }

    #endregion
}