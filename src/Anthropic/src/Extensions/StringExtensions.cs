namespace LangChain.Providers.Anthropic.Extensions;

/// <summary>
/// </summary>
internal static class StringExtensions
{
    /// <summary>
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static global::Anthropic.Message AsHumanMessage(this string content)
    {
        return new global::Anthropic.Message
        {
            Content = new List<Block>
            {
                new TextBlock
                {
                    Text = content,
                },
            },
            Role = global::Anthropic.MessageRole.User,
        };
    }

    /// <summary>
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static global::Anthropic.Message AsAssistantMessage(this string content)
    {
        return new global::Anthropic.Message
        {
            Content = new List<Block>
            {
                new TextBlock
                {
                    Text = content,
                },
            },
            Role = global::Anthropic.MessageRole.Assistant,
        };
    }

    /// <summary>
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static string AsPrompt(this string content)
    {
        return $"\n\n{content.AsHumanMessage()}\n\nAssistant:";
    }

    /// <summary>
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static string AsPrompt(this string[] content)
    {
        return AsPrompt(string.Join("\n\n", content));
    }
}