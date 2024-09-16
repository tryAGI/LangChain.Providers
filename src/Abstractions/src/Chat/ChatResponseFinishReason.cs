namespace LangChain.Providers;

/// <summary>
/// The reason the model stopped generating tokens. This will be `stop` if the model hit a natural stop point or a provided stop sequence,<br/>
/// `length` if the maximum number of tokens specified in the request was reached,<br/>
/// `content_filter` if content was omitted due to a flag from our content filters,<br/>
/// `tool_calls` if the model called a tool, or `function_call` (deprecated) if the model called a function.
/// </summary>
public enum ChatResponseFinishReason
{
    /// <summary>
    /// 
    /// </summary>
    Stop,
    
    /// <summary>
    /// 
    /// </summary>
    Length,
    
    /// <summary>
    /// 
    /// </summary>
    ToolCalls,
    
    /// <summary>
    /// 
    /// </summary>
    ContentFilter,
}