namespace LangChain.Providers.OpenRouter.CodeGenerator.Main;

internal sealed class GenerationOptions
{
    public string OutputFolder { get; set; } = "Generated";
    public Func<string, string, string, string>? ReplaceEnumNameFunc { get; set; }
}