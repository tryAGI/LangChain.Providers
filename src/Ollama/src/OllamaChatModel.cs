using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Ollama;

namespace LangChain.Providers.Ollama;

/// <summary>
/// 
/// </summary>
public class OllamaChatModel(
    OllamaProvider provider,
    string id)
    : ChatModel(id), IChatModel
{
    /// <summary>
    /// Provider of the model.
    /// </summary>
    public OllamaProvider Provider { get; } = provider ?? throw new ArgumentNullException(nameof(provider));

    /// <inheritdoc />
    public override async IAsyncEnumerable<ChatResponse> GenerateAsync(
        ChatRequest request,
        ChatSettings? settings = null,
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        request = request ?? throw new ArgumentNullException(nameof(request));

        try
        {
            var runningModels = await GetRunningModels().ConfigureAwait(false);

            if (!runningModels.Any(x => x.Contains(Id)))
            {
                await Provider.Api.Models.PullModelAsync(Id, cancellationToken: cancellationToken)
                    .EnsureSuccessAsync().ConfigureAwait(false);
            }
        }
        catch (HttpRequestException)
        {
            // Ignore
        }

        var usedSettings = OllamaChatSettings.Calculate(
            requestSettings: settings,
            modelSettings: Settings,
            providerSettings: provider.ChatSettings);
        var watch = Stopwatch.StartNew();
        var tools = request.Tools
            .Concat(GlobalTools)
            .Select(x => new Tool
            {
                Type = ToolType.Function,
                Function = new ToolFunction
                {
                    Name = x.Type,
                    Description = x.Description,
                    Parameters = x.Items != null
                        ? ToTool<ToolFunctionParams>(x.Items)
                        : new ToolFunctionParams(),
                },
            })
            .ToArray();
        tools = tools.Length > 0 ? tools : null;
        var response = Provider.Api.Chat.GenerateChatCompletionAsync(
            model: Id,
            messages: request.Messages.Select(x => new global::Ollama.Message
            {
                Role = x.Role switch
                {
                    MessageRole.Human => global::Ollama.MessageRole.User,
                    MessageRole.Ai => global::Ollama.MessageRole.Assistant,
                    MessageRole.System => global::Ollama.MessageRole.System,
                    MessageRole.ToolCall => global::Ollama.MessageRole.Tool,
                    _ => global::Ollama.MessageRole.User,
                },
                Content = x.Content,
            }).ToList(),
            format: usedSettings.Format,
            options: new RequestOptions
            {
                Temperature = usedSettings.Temperature,
                Stop = usedSettings.StopSequences?.ToList(),

                NumKeep = usedSettings.NumKeep,
                Seed = usedSettings.Seed,
                NumPredict = usedSettings.NumPredict,
                TopK = usedSettings.TopK,
                TopP = usedSettings.TopP,
                MinP = usedSettings.MinP,
                TfsZ = usedSettings.TfsZ,
                TypicalP = usedSettings.TypicalP,
                RepeatLastN = usedSettings.RepeatLastN,
                RepeatPenalty = usedSettings.RepeatPenalty,
                PresencePenalty = usedSettings.PresencePenalty,
                FrequencyPenalty = usedSettings.FrequencyPenalty,
                Mirostat = usedSettings.Mirostat,
                MirostatTau = usedSettings.MirostatTau,
                MirostatEta = usedSettings.MirostatEta,
                PenalizeNewline = usedSettings.PenalizeNewline,
                Numa = usedSettings.Numa,
                NumCtx = usedSettings.NumCtx,
                NumBatch = usedSettings.NumBatch,
                NumGpu = usedSettings.NumGpu,
                MainGpu = usedSettings.MainGpu,
                LowVram = usedSettings.LowVram,
                F16Kv = usedSettings.F16Kv,
                LogitsAll = usedSettings.LogitsAll,
                VocabOnly = usedSettings.VocabOnly,
                UseMmap = usedSettings.UseMmap,
                UseMlock = usedSettings.UseMlock,
                NumThread = usedSettings.NumThread,
            },
            stream: usedSettings.UseStreaming ?? true,
            keepAlive: usedSettings.KeepAlive,
            tools: tools,
            cancellationToken: cancellationToken);

        OnRequestSent(request);

        GenerateChatCompletionResponse? lastResponse = null;
        IReadOnlyList<ChatToolCall>? toolCalls = null;
        var stringBuilder = new StringBuilder(capacity: 1024);
        await foreach (var completion in response)
        {
            lastResponse = completion;
            var delta = new ChatResponseDelta
            {
                Content = completion.Message.Content,
            };

            toolCalls ??= completion.Message.ToolCalls?.Select(x => new ChatToolCall
            {
                Id = x.Function?.Name ?? string.Empty,
                ToolName = x.Function?.Name ?? string.Empty,
                ToolArguments = x.Function?.Arguments.AsJson() ?? string.Empty,
            }).ToList();
            OnDeltaReceived(delta);
            stringBuilder.Append(delta.Content);
        }

        var result = request.Messages.ToList();
        result.Add(stringBuilder.ToString().AsAiMessage());

        var usage = Usage.Empty with
        {
            InputTokens = lastResponse?.PromptEvalCount ?? 0,
            OutputTokens = lastResponse?.EvalCount ?? 0,
            Messages = 1,
            Time = watch.Elapsed,
        };
        AddUsage(usage);
        provider.AddUsage(usage);

        var chatResponse = new ChatResponse
        {
            Messages = result,
            Usage = usage,
            UsedSettings = usedSettings,
            FinishReason = lastResponse?.DoneReason?.Value2 switch
            {
                DoneReasonEnum.Stop => ChatResponseFinishReason.Stop,
                DoneReasonEnum.Length => ChatResponseFinishReason.Length,
                DoneReasonEnum.Load => null,
                _ => null,
            },
        };
        OnResponseReceived(chatResponse);

        yield return chatResponse;
    }


    private async Task<IReadOnlyList<string>> GetRunningModels()
    {
        var models = await Provider.Api.Models.ListRunningModelsAsync().ConfigureAwait(false);
        return models.Models.Select(model => model.Model).ToList();
    }

    private static T ToTool<T>(OpenApiSchema schema) where T : global::Ollama.OpenApiSchema, new()
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        return new T
        {
            Type = schema.Type,
            Description = schema.Description,
            Items = schema.Items != null
                ? ToTool<global::Ollama.OpenApiSchema>(schema.Items)
                : null,
            Properties = schema.Properties
                .ToDictionary(
                    x => x.Key,
                    x => ToTool<global::Ollama.OpenApiSchema>(x.Value)),
            Required = schema.Required,
            Enum = schema.Enum,
        };
    }
}