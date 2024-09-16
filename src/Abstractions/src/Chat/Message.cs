// ReSharper disable once CheckNamespace
namespace LangChain.Providers;

/// <summary>
/// 
/// </summary>
/// <param name="Content"></param>
/// <param name="Role"></param>
/// <param name="ToolName"></param>
public readonly record struct Message(
    string Content,
    MessageRole Role,
    string? ToolName = null)
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static Message Human(string content) => new(content, MessageRole.Human);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static Message Ai(string content) => new(content, MessageRole.Ai);

    /// <summary>
    /// 
    /// </summary>
    public static Message Empty { get; } = new(
        Content: string.Empty,
        Role: MessageRole.Human,
        ToolName: null);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static Message operator +(Message a, Message b)
    {
        return a with { Content = a.Content + b.Content };
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static Message Add(Message left, Message right)
    {
        return left + right;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        if (ToolName != null)
        {
            return $"{Role}({ToolName}):\n{Content}";
        }
        
        return $"{Role}: {Content}";
    }
}