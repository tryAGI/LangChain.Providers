using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace LangChain.Providers;

/// <summary>
/// 
/// </summary>
public static class AsyncEnumerableExtensions
{
	/// <summary>
	/// Waits for the enumerable to complete and combines the responses into a single response.
	/// </summary>
	/// <param name="enumerable"></param>
	/// <returns></returns>
	public static async Task<ChatResponse> WaitAsync(
		this IAsyncEnumerable<ChatResponse> enumerable)
	{
		enumerable = enumerable ?? throw new ArgumentNullException(nameof(enumerable));
		
		ChatResponse? currentResponse = default;
		await foreach (var response in enumerable.ConfigureAwait(false))
		{
			currentResponse = response;
		}

		return currentResponse ?? new ChatResponse
		{
			Messages = [],
			UsedSettings = ChatSettings.Default,
			Usage = Usage.Empty,
		};
	}

	/// <summary>
	/// Waits for the enumerable to complete and combines the responses into a single response.
	/// </summary>
	/// <param name="enumerable"></param>
	/// <returns></returns>
	public static TaskAwaiter<ChatResponse> GetAwaiter(
		this IAsyncEnumerable<ChatResponse> enumerable)
	{
		enumerable = enumerable ?? throw new ArgumentNullException(nameof(enumerable));
		
		return enumerable.WaitAsync().GetAwaiter();
	}
}