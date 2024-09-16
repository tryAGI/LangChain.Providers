// ReSharper disable once CheckNamespace
namespace LangChain.Providers.OpenAI;

internal static class MessageExtensions
{
    private static readonly char[] Separator = [':'];

    public static IList<ChatCompletionMessageToolCall> ToToolCalls(this Message message)
    {
        var nameAndId = message.ToolName?.Split(Separator, StringSplitOptions.RemoveEmptyEntries) ??
                        throw new ArgumentException("Invalid functionCall name and id string");

        if (nameAndId.Length < 2)
            throw new ArgumentException("Invalid functionCall name and id string");

        return [
            new ChatCompletionMessageToolCall
            {
                Id = nameAndId[1],
                Type = ChatCompletionMessageToolCallType.Function,
                Function = new ChatCompletionMessageToolCallFunction
                {
                    Name = nameAndId[0],
                    Arguments = message.Content,
                },
            }
        ];
    }
    public static ChatCompletionTool GetTool(this Message message)
    {
        var nameAndId = message.ToolName?.Split(Separator, StringSplitOptions.RemoveEmptyEntries) ??
                        throw new ArgumentException("Invalid functionCall name and id string");

        if (nameAndId.Length < 2)
            throw new ArgumentException("Invalid functionCall name and id string");

        return new ChatCompletionTool
        {
            Type = ChatCompletionToolType.Function,
            Function = new FunctionObject
            {
                Name = nameAndId[0],
                Parameters = new FunctionParameters(),
            },
        };
    }
}
