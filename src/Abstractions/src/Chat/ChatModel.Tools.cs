// ReSharper disable once CheckNamespace

using CSharpToJsonSchema;

namespace LangChain.Providers;

public partial class ChatModel
{
    #region Properties

    /// <inheritdoc />
    public bool CallToolsAutomatically { get; set; } = true;

    /// <inheritdoc />
    public bool ReplyToToolCallsAutomatically { get; set; } = true;

    [CLSCompliant(false)]
    protected IList<Tool> GlobalTools { get; } = [];
    protected Dictionary<string, Func<string, CancellationToken, Task<string>>> Calls { get; } = [];

    #endregion

    #region Methods

    /// <inheritdoc />
    public void AddGlobalTools(
        ICollection<Tool> tools,
        IReadOnlyDictionary<string, Func<string, CancellationToken, Task<string>>> calls)
    {
        tools = tools ?? throw new ArgumentNullException(nameof(tools));
        calls = calls ?? throw new ArgumentNullException(nameof(calls));

        foreach (var tool in tools)
        {
            GlobalTools.Add(tool);
        }
        foreach (var call in calls)
        {
            Calls.Add(call.Key, call.Value);
        }
    }

    /// <inheritdoc />
    public void ClearGlobalTools()
    {
        GlobalTools.Clear();
        Calls.Clear();
    }

    protected virtual async Task CallToolsAsync(
        IReadOnlyList<ChatToolCall> toolCalls,
        IList<Message> messages,
        CancellationToken cancellationToken = default)
    {
        toolCalls = toolCalls ?? throw new ArgumentNullException(nameof(toolCalls));
        messages = messages ?? throw new ArgumentNullException(nameof(messages));

        foreach (var call in toolCalls)
        {
            var func = Calls[call.ToolName];
            var json = await func(call.ToolArguments, cancellationToken).ConfigureAwait(false);
            messages.Add(json.AsToolResultMessage(call));
        }
    }

    #endregion
}