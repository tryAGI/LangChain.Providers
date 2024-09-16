// ReSharper disable once CheckNamespace
namespace LangChain.Providers;

#pragma warning disable CA2225

/// <summary>
/// 
/// </summary>
public class ChatResponseDelta
{
    /// <summary>
    /// The contents of the chunk message.
    /// </summary>
    public string Content { get; set; } = string.Empty;
}