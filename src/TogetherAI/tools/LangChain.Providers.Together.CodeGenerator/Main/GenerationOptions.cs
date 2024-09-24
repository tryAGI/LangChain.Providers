namespace LangChain.Providers.Together.CodeGenerator.Main;

public class GenerationOptions
{
    public string OutputFolder { get; set; } = "Generated";
    public Func<string, string, string, string>? ReplaceEnumNameFunc { get; set; }
    public string TogetherApiKey { get; set; } = string.Empty;
}