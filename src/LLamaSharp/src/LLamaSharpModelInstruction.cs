using LLama.Common;
using LLama;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LLama.Sampling;

namespace LangChain.Providers.LLamaSharp;

/// <summary>
/// 
/// </summary>
[CLSCompliant(false)]
public class LLamaSharpModelInstruction : LLamaSharpModelBase, IChatModel
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="path"></param>
    /// <param name="temperature"></param>
    /// <returns></returns>
    public static LLamaSharpModelInstruction FromPath(string path, float temperature = 0)
    {
        return new LLamaSharpModelInstruction(new LLamaSharpConfiguration
        {
            PathToModelFile = path,
            Temperature = temperature
        });
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="configuration"></param>
    public LLamaSharpModelInstruction(LLamaSharpConfiguration configuration) : base(configuration)
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
            .Replace("\n>", string.Empty)
            .Trim();
    }

    /// <inheritdoc />
    public override async IAsyncEnumerable<ChatResponse> GenerateAsync(
        ChatRequest request,
        ChatSettings? settings = null,
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        request = request ?? throw new ArgumentNullException(nameof(request));

        var prompt = ToPrompt(request.Messages);

        var watch = Stopwatch.StartNew();


        var context = Model.CreateContext(Parameters);
        var ex = new InstructExecutor(context);

        var inferenceParams = new InferenceParams
        {
            AntiPrompts = Configuration.AntiPrompts,
            MaxTokens = Configuration.MaxTokens,
            SamplingPipeline = new DefaultSamplingPipeline
            {
                RepeatPenalty = Configuration.RepeatPenalty,
                Temperature = Configuration.Temperature,
            },
        };

        OnRequestSent(request);

        var buf = "";
        await foreach (var text in ex.InferAsync(prompt,
                           inferenceParams, cancellationToken).ConfigureAwait(false))
        {
            buf += text;
            foreach (string antiPrompt in Configuration.AntiPrompts)
            {
                if (buf.EndsWith(antiPrompt, StringComparison.Ordinal))
                {
                    buf = buf.Substring(0, buf.Length - antiPrompt.Length);
                    break;
                }
            }

            OnDeltaReceived(new ChatResponseDelta
            {
                Content = text,
            });
        }

        buf = SanitizeOutput(buf);

        var result = request.Messages.ToList();
        result.Add(buf.AsAiMessage());

        watch.Stop();

        // Unsupported
        var usage = Usage.Empty with
        {
            Time = watch.Elapsed,
        };
        TotalUsage += usage;

        var chatResponse = new ChatResponse
        {
            Messages = result,
            Usage = usage,
            UsedSettings = ChatSettings.Default,
        };
        OnResponseReceived(chatResponse);

        yield return chatResponse;
    }
}