using System.Diagnostics;
using System.Runtime.CompilerServices;
using LLama;
using LLama.Common;
using LLama.Sampling;

namespace LangChain.Providers.LLamaSharp;

/// <summary>
/// 
/// </summary>
[CLSCompliant(false)]
public class LLamaSharpModelChat : LLamaSharpModelBase
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="path"></param>
    /// <returns></returns>
    public static LLamaSharpModelChat FromPath(string path)
    {
        return new LLamaSharpModelChat(new LLamaSharpConfiguration
        {
            PathToModelFile = path,
        });
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="configuration"></param>
    public LLamaSharpModelChat(LLamaSharpConfiguration configuration) : base(configuration)
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="res"></param>
    /// <returns></returns>
    private static string SanitizeOutput(string res)
    {
        return res
            .Replace("Human:", string.Empty)
            .Replace("Assistant:", string.Empty)
            .Trim();
    }

    public override async IAsyncEnumerable<ChatResponse> GenerateAsync(
        ChatRequest request,
        ChatSettings? settings = null,
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        request = request ?? throw new ArgumentNullException(nameof(request));

        var prompt = ToPrompt(request.Messages);

        var watch = Stopwatch.StartNew();


        var context = Model.CreateContext(Parameters);
        var ex = new InteractiveExecutor(context);
        ChatSession session = new ChatSession(ex);
        var inferenceParams = new InferenceParams()
        {
            AntiPrompts = new List<string> { "Human:" },
            MaxTokens = Configuration.MaxTokens,
            SamplingPipeline = new DefaultSamplingPipeline
            {
                RepeatPenalty = Configuration.RepeatPenalty,
                Temperature = Configuration.Temperature,
            },
        };

        var buf = "";
        await foreach (var text in session.ChatAsync(
           message: new ChatHistory.Message(AuthorRole.User, prompt),
           inferenceParams: inferenceParams,
           cancellationToken: cancellationToken))
        {
            buf += text;
        }

        buf = LLamaSharpModelChat.SanitizeOutput(buf);
        var result = request.Messages.ToList();
        result.Add(buf.AsAiMessage());

        watch.Stop();

        // Unsupported
        var usage = Usage.Empty with
        {
            Time = watch.Elapsed,
        };
        TotalUsage += usage;

        yield return new ChatResponse
        {
            Messages = result,
            Usage = usage,
            UsedSettings = ChatSettings.Default,
        };
    }
}