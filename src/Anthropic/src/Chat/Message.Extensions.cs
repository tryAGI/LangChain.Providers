// ReSharper disable once CheckNamespace
namespace LangChain.Providers.Anthropic;

internal static class MessageExtensions
{
    private static readonly char[] Separator = [':'];

    public static ToolUseBlock ToToolUseBlock(this Message message)
    {
        var nameAndId = message.ToolName?.Split(Separator, StringSplitOptions.RemoveEmptyEntries) ??
                        throw new ArgumentException("Invalid functionCall name and id string");

        if (nameAndId.Length < 2)
            throw new ArgumentException("Invalid functionCall name and id string");

        return new ToolUseBlock
        {
            Id = nameAndId[1],
            Name = nameAndId[0],
            Input = message.Content,
        };
    }
}
