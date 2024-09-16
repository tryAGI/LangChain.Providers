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
    /// <param name="toolName"></param>
    /// <returns></returns>
    public static Message AsToolCallMessage(this string text, string toolName)
    {
        return new Message(text, MessageRole.ToolCall, ToolName: toolName);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="text"></param>
    /// <param name="toolName"></param>
    /// <returns></returns>
    public static Message AsToolResultMessage(this string text, string toolName)
    {
        return new Message(text, MessageRole.ToolResult, ToolName: toolName);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="json"></param>
    /// <param name="call"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static Message AsToolResultMessage(this string json, ChatToolCall call)
    {
        call = call ?? throw new ArgumentNullException(nameof(call));

        return new Message(json, MessageRole.ToolResult, $"{call.ToolName}:{call.Id}");
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
                builder.Append(message.ToolName);
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