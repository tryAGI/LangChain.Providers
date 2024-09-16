// ReSharper disable once CheckNamespace
namespace LangChain.Providers;

/// <summary>
/// Defines a large language model that can be used for chat.
/// </summary>
public interface IChatModel<in TRequest, out TResponse, in TSettings> : IChatModel
{
    /// <summary>
    /// Run the LLM on the given prompt and input.
    /// </summary>
    /// <param name="request"></param>
    /// <param name="settings"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public IAsyncEnumerable<TResponse> GenerateAsync(
        TRequest request,
        TSettings? settings = default,
        CancellationToken cancellationToken = default);
}