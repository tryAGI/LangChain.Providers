using System.Text;

// ReSharper disable once CheckNamespace
namespace LangChain.Providers;

/// <summary>
/// 
/// </summary>
public static class MessageStringExtensions
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public static Message AsSystemMessage(this string text)
    {
        return new Message(text, MessageRole.System);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public static Message AsHumanMessage(this string text)
    {
        return new Message(text, MessageRole.Human);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public static Message AsAiMessage(this string text)
    {
        return new Message(text, MessageRole.Ai);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public static Message AsChatMessage(this string text)
    {
        return new Message(text, MessageRole.Chat);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="text"></param>
    /// <param name="functionName"></param>
    /// <returns></returns>
    public static Message AsFunctionCallMessage(this string text, string functionName)
    {
        return new Message(text, MessageRole.ToolCall, FunctionName: functionName);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="text"></param>
    /// <param name="functionName"></param>
    /// <returns></returns>
    public static Message AsFunctionResultMessage(this string text, string functionName)
    {
        return new Message(text, MessageRole.ToolResult, FunctionName: functionName);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="messages"></param>
    /// <returns></returns>
    public static string AsHistory(this IReadOnlyCollection<Message> messages)
    {
        messages = messages ?? throw new ArgumentNullException(nameof(messages));

        var builder = new StringBuilder(capacity: messages.Count * 64);
        foreach (var message in messages)
        {
            builder.Append(message.Role switch
            {
                MessageRole.System => "System: ",
                MessageRole.Ai => "AI: ",
                MessageRole.ToolCall => "Tool call: ",
                MessageRole.Human => "Human: ",
                MessageRole.ToolResult => "Tool result: ",
                _ => "Human: ",
            });
            if (message.Role is MessageRole.ToolCall or MessageRole.ToolResult)
            {
                builder.Append(message.FunctionName);
            }
            if (message.Role == MessageRole.ToolCall)
            {
                builder.Append('(');
            }
            else if (message.Role == MessageRole.ToolResult)
            {
                builder.Append(" -> ");
            }
            builder.Append(message.Content);
            if (message.Role == MessageRole.ToolCall)
            {
                builder.Append(')');
            }
            builder.AppendLine();
        }

        return builder.ToString();
    }
}