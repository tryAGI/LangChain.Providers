// ReSharper disable once CheckNamespace

using Ollama;

namespace LangChain.Providers.Ollama;

public class OllamaChatSettings : ChatSettings
{
    /// <summary>
    /// 
    /// </summary>
    public new static OllamaChatSettings Default { get; } = new()
    {
        StopSequences = ChatSettings.Default.StopSequences,
        User = ChatSettings.Default.User,
        UseStreaming = ChatSettings.Default.UseStreaming,
    };

    /// <inheritdoc cref="GenerateChatCompletionRequest.Format"/>
    public ResponseFormat? Format { get; set; }

    /// <inheritdoc cref="GenerateChatCompletionRequest.KeepAlive"/>
    public int? KeepAlive { get; init; }

    /// <inheritdoc cref="RequestOptions.NumKeep"/>
    public int? NumKeep { get; set; }

    /// <inheritdoc cref="RequestOptions.Seed"/>
    public int? Seed { get; set; }

    /// <inheritdoc cref="RequestOptions.NumPredict"/>
    public int? NumPredict { get; set; }

    /// <inheritdoc cref="RequestOptions.TopK"/>
    public int? TopK { get; set; }

    /// <inheritdoc cref="RequestOptions.TopP"/>
    public float? TopP { get; set; }

    /// <inheritdoc cref="RequestOptions.MinP"/>
    public float? MinP { get; set; }

    /// <inheritdoc cref="RequestOptions.TfsZ"/>
    public float? TfsZ { get; set; }

    /// <inheritdoc cref="RequestOptions.TypicalP"/>
    public float? TypicalP { get; set; }

    /// <inheritdoc cref="RequestOptions.RepeatLastN"/>
    public int? RepeatLastN { get; set; }

    /// <inheritdoc cref="RequestOptions.Temperature"/>
    public float? Temperature { get; set; }

    /// <inheritdoc cref="RequestOptions.RepeatPenalty"/>
    public float? RepeatPenalty { get; set; }

    /// <inheritdoc cref="RequestOptions.PresencePenalty"/>
    public float? PresencePenalty { get; set; }

    /// <inheritdoc cref="RequestOptions.FrequencyPenalty"/>
    public float? FrequencyPenalty { get; set; }

    /// <inheritdoc cref="RequestOptions.Mirostat"/>
    public int? Mirostat { get; set; }

    /// <inheritdoc cref="RequestOptions.MirostatTau"/>
    public float? MirostatTau { get; set; }

    /// <inheritdoc cref="RequestOptions.MirostatEta"/>
    public float? MirostatEta { get; set; }

    /// <inheritdoc cref="RequestOptions.PenalizeNewline"/>
    public bool? PenalizeNewline { get; set; }

    /// <inheritdoc cref="RequestOptions.Numa"/>
    public bool? Numa { get; set; }

    /// <inheritdoc cref="RequestOptions.NumCtx"/>
    public int? NumCtx { get; set; }

    /// <inheritdoc cref="RequestOptions.NumBatch"/>
    public int? NumBatch { get; set; }

    /// <inheritdoc cref="RequestOptions.NumGpu"/>
    public int? NumGpu { get; set; }

    /// <inheritdoc cref="RequestOptions.MainGpu"/>
    public int? MainGpu { get; set; }

    /// <inheritdoc cref="RequestOptions.LowVram"/>
    public bool? LowVram { get; set; }

    /// <inheritdoc cref="RequestOptions.F16Kv"/>
    public bool? F16Kv { get; set; }

    /// <inheritdoc cref="RequestOptions.LogitsAll"/>
    public bool? LogitsAll { get; set; }

    /// <inheritdoc cref="RequestOptions.VocabOnly"/>
    public bool? VocabOnly { get; set; }

    /// <inheritdoc cref="RequestOptions.UseMmap"/>
    public bool? UseMmap { get; set; }

    /// <inheritdoc cref="RequestOptions.UseMlock"/>
    public bool? UseMlock { get; set; }

    /// <inheritdoc cref="RequestOptions.NumThread"/>
    public int? NumThread { get; set; }

    /// <summary>
    /// Calculate the settings to use for the request.
    /// </summary>
    /// <param name="requestSettings"></param>
    /// <param name="modelSettings"></param>
    /// <param name="providerSettings"></param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public new static OllamaChatSettings Calculate(
        ChatSettings? requestSettings,
        ChatSettings? modelSettings,
        ChatSettings? providerSettings)
    {
        var requestSettingsCasted = requestSettings as OllamaChatSettings;
        var modelSettingsCasted = modelSettings as OllamaChatSettings;
        var providerSettingsCasted = providerSettings as OllamaChatSettings;

        return new OllamaChatSettings
        {
            StopSequences =
                requestSettings?.StopSequences ??
                modelSettings?.StopSequences ??
                providerSettings?.StopSequences ??
                Default.StopSequences ??
                throw new InvalidOperationException("Default StopSequences is not set."),
            User =
                requestSettings?.User ??
                modelSettings?.User ??
                providerSettings?.User ??
                Default.User ??
                throw new InvalidOperationException("Default User is not set."),
            UseStreaming =
                requestSettings?.UseStreaming ??
                modelSettings?.UseStreaming ??
                providerSettings?.UseStreaming ??
                Default.UseStreaming ??
                throw new InvalidOperationException("Default UseStreaming is not set."),
            Format =
                requestSettingsCasted?.Format ??
                modelSettingsCasted?.Format ??
                providerSettingsCasted?.Format ??
                Default.Format,
            KeepAlive =
                requestSettingsCasted?.KeepAlive ??
                modelSettingsCasted?.KeepAlive ??
                providerSettingsCasted?.KeepAlive ??
                Default.KeepAlive,
            NumKeep =
                requestSettingsCasted?.NumKeep ??
                modelSettingsCasted?.NumKeep ??
                providerSettingsCasted?.NumKeep ??
                Default.NumKeep,
            Seed =
                requestSettingsCasted?.Seed ??
                modelSettingsCasted?.Seed ??
                providerSettingsCasted?.Seed ??
                Default.Seed,
            NumPredict =
                requestSettingsCasted?.NumPredict ??
                modelSettingsCasted?.NumPredict ??
                providerSettingsCasted?.NumPredict ??
                Default.NumPredict,
            TopK =
                requestSettingsCasted?.TopK ??
                modelSettingsCasted?.TopK ??
                providerSettingsCasted?.TopK ??
                Default.TopK,
            TopP =
                requestSettingsCasted?.TopP ??
                modelSettingsCasted?.TopP ??
                providerSettingsCasted?.TopP ??
                Default.TopP,
            MinP =
                requestSettingsCasted?.MinP ??
                modelSettingsCasted?.MinP ??
                providerSettingsCasted?.MinP ??
                Default.MinP,
            TfsZ =
                requestSettingsCasted?.TfsZ ??
                modelSettingsCasted?.TfsZ ??
                providerSettingsCasted?.TfsZ ??
                Default.TfsZ,
            TypicalP =
                requestSettingsCasted?.TypicalP ??
                modelSettingsCasted?.TypicalP ??
                providerSettingsCasted?.TypicalP ??
                Default.TypicalP,
            RepeatLastN =
                requestSettingsCasted?.RepeatLastN ??
                modelSettingsCasted?.RepeatLastN ??
                providerSettingsCasted?.RepeatLastN ??
                Default.RepeatLastN,
            Temperature =
                requestSettingsCasted?.Temperature ??
                modelSettingsCasted?.Temperature ??
                providerSettingsCasted?.Temperature ??
                Default.Temperature,
            RepeatPenalty =
                requestSettingsCasted?.RepeatPenalty ??
                modelSettingsCasted?.RepeatPenalty ??
                providerSettingsCasted?.RepeatPenalty ??
                Default.RepeatPenalty,
            PresencePenalty =
                requestSettingsCasted?.PresencePenalty ??
                modelSettingsCasted?.PresencePenalty ??
                providerSettingsCasted?.PresencePenalty ??
                Default.PresencePenalty,
            FrequencyPenalty =
                requestSettingsCasted?.FrequencyPenalty ??
                modelSettingsCasted?.FrequencyPenalty ??
                providerSettingsCasted?.FrequencyPenalty ??
                Default.FrequencyPenalty,
            Mirostat =
                requestSettingsCasted?.Mirostat ??
                modelSettingsCasted?.Mirostat ??
                providerSettingsCasted?.Mirostat ??
                Default.Mirostat,
            MirostatTau =
                requestSettingsCasted?.MirostatTau ??
                modelSettingsCasted?.MirostatTau ??
                providerSettingsCasted?.MirostatTau ??
                Default.MirostatTau,
            MirostatEta =
                requestSettingsCasted?.MirostatEta ??
                modelSettingsCasted?.MirostatEta ??
                providerSettingsCasted?.MirostatEta ??
                Default.MirostatEta,
            PenalizeNewline =
                requestSettingsCasted?.PenalizeNewline ??
                modelSettingsCasted?.PenalizeNewline ??
                providerSettingsCasted?.PenalizeNewline ??
                Default.PenalizeNewline,
            Numa =
                requestSettingsCasted?.Numa ??
                modelSettingsCasted?.Numa ??
                providerSettingsCasted?.Numa ??
                Default.Numa,
            NumCtx =
                requestSettingsCasted?.NumCtx ??
                modelSettingsCasted?.NumCtx ??
                providerSettingsCasted?.NumCtx ??
                Default.NumCtx,
            NumBatch =
                requestSettingsCasted?.NumBatch ??
                modelSettingsCasted?.NumBatch ??
                providerSettingsCasted?.NumBatch ??
                Default.NumBatch,
            NumGpu =
                requestSettingsCasted?.NumGpu ??
                modelSettingsCasted?.NumGpu ??
                providerSettingsCasted?.NumGpu ??
                Default.NumGpu,
            MainGpu =
                requestSettingsCasted?.MainGpu ??
                modelSettingsCasted?.MainGpu ??
                providerSettingsCasted?.MainGpu ??
                Default.MainGpu,
            LowVram =
                requestSettingsCasted?.LowVram ??
                modelSettingsCasted?.LowVram ??
                providerSettingsCasted?.LowVram ??
                Default.LowVram,
            F16Kv =
                requestSettingsCasted?.F16Kv ??
                modelSettingsCasted?.F16Kv ??
                providerSettingsCasted?.F16Kv ??
                Default.F16Kv,
            LogitsAll =
                requestSettingsCasted?.LogitsAll ??
                modelSettingsCasted?.LogitsAll ??
                providerSettingsCasted?.LogitsAll ??
                Default.LogitsAll,
            VocabOnly =
                requestSettingsCasted?.VocabOnly ??
                modelSettingsCasted?.VocabOnly ??
                providerSettingsCasted?.VocabOnly ??
                Default.VocabOnly,
            UseMmap =
                requestSettingsCasted?.UseMmap ??
                modelSettingsCasted?.UseMmap ??
                providerSettingsCasted?.UseMmap ??
                Default.UseMmap,
            UseMlock =
                requestSettingsCasted?.UseMlock ??
                modelSettingsCasted?.UseMlock ??
                providerSettingsCasted?.UseMlock ??
                Default.UseMlock,
            NumThread =
                requestSettingsCasted?.NumThread ??
                modelSettingsCasted?.NumThread ??
                providerSettingsCasted?.NumThread ??
                Default.NumThread,
        };
    }
}