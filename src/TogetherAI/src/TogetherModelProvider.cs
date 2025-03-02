using tryAGI.OpenAI;

namespace LangChain.Providers.Together;

/// <summary>
/// Contains all the Together Ai models.
/// </summary>
public static class TogetherModelProvider
{
    private static Dictionary<TogetherModelIds, ChatModelMetadata> Models { get; set; } = new()
    {
        { TogetherModelIds.Gemma2Instruct27B, ToMetadata("google/gemma-2-27b-it",8192,8.000000000000001E-07,8.000000000000001E-07)},
        { TogetherModelIds.MetaLlama370BInstructTurbo, ToMetadata("meta-llama/Meta-Llama-3-70B-Instruct-Turbo",8192,8.8E-07,8.8E-07)},
        { TogetherModelIds.Qwen2Vl72BInstruct, ToMetadata("Qwen/Qwen2-VL-72B-Instruct",32768,1.2E-06,1.2E-06)},
        { TogetherModelIds.MetaLlamaVisionFree, ToMetadata("meta-llama/Llama-Vision-Free",131072,0,0)},
        { TogetherModelIds.MythomaxL213B, ToMetadata("Gryphe/MythoMax-L2-13b",4096,3E-07,3E-07)},
        { TogetherModelIds.Qwen2572BInstructTurbo, ToMetadata("Qwen/Qwen2.5-72B-Instruct-Turbo",131072,1.2E-06,1.2E-06)},
        { TogetherModelIds.MetaLlama3370BInstructTurboFree, ToMetadata("meta-llama/Llama-3.3-70B-Instruct-Turbo-Free",131072,0,0)},
        { TogetherModelIds.MetaLlama3211BVisionInstructTurbo, ToMetadata("meta-llama/Llama-3.2-11B-Vision-Instruct-Turbo",131072,1.8E-07,1.8E-07)},
        { TogetherModelIds.MistralSmall24BInstruct2501, ToMetadata("mistralai/Mistral-Small-24B-Instruct-2501",32768,8.000000000000001E-07,8.000000000000001E-07)},
        { TogetherModelIds.Mixtral8X22bInstructV01, ToMetadata("mistralai/Mixtral-8x22B-Instruct-v0.1",65536,1.2E-06,1.2E-06)},
        { TogetherModelIds.MetaLlama38BInstructTurbo, ToMetadata("meta-llama/Meta-Llama-3-8B-Instruct-Turbo",8192,1.8E-07,1.8E-07)},
        { TogetherModelIds.NousHermes2Mixtral8X7BDpo, ToMetadata("NousResearch/Nous-Hermes-2-Mixtral-8x7B-DPO",32768,6E-07,6E-07)},
        { TogetherModelIds.MetaLlama318BInstructTurbo, ToMetadata("meta-llama/Meta-Llama-3.1-8B-Instruct-Turbo-classifier",131072,1.8E-07,1.8E-07)},
        { TogetherModelIds.DeepseekV3, ToMetadata("deepseek-ai/DeepSeek-V3",131072,1.25E-06,1.25E-06)},
        { TogetherModelIds.DeepseekR1, ToMetadata("deepseek-ai/DeepSeek-R1",163840,3E-06,7E-06)},
        { TogetherModelIds.Qwen2Instruct72B, ToMetadata("Qwen/Qwen2-72B-Instruct",32768,9.000000000000001E-07,9.000000000000001E-07)},
        { TogetherModelIds.MetaLlama38BInstructLite, ToMetadata("meta-llama/Meta-Llama-3-8B-Instruct-Lite",8192,1.0000000000000001E-07,1.0000000000000001E-07)},
        { TogetherModelIds.UpstageSolarInstructV111B, ToMetadata("upstage/SOLAR-10.7B-Instruct-v1.0",4096,3E-07,3E-07)},
        { TogetherModelIds.TogetherAiMoa1, ToMetadata("togethercomputer/MoA-1",32768,0,0)},
        { TogetherModelIds.QwenQwq32BPreview, ToMetadata("Qwen/QwQ-32B-Preview",32768,1.2E-06,1.2E-06)},
        { TogetherModelIds.MetaLlama31405BInstructTurbo, ToMetadata("meta-llama/Meta-Llama-3.1-405B-Instruct-Turbo",130815,3.5E-06,3.5E-06)},
        { TogetherModelIds.MetaLlama3170BInstructTurbo, ToMetadata("meta-llama/Meta-Llama-3.1-70B-Instruct-Turbo",131072,8.8E-07,8.8E-07)},
        { TogetherModelIds.Mistral7BInstructV02, ToMetadata("mistralai/Mistral-7B-Instruct-v0.2",32768,2.0000000000000002E-07,2.0000000000000002E-07)},
        { TogetherModelIds.DbrxInstruct, ToMetadata("databricks/dbrx-instruct",32768,1.2E-06,1.2E-06)},
        { TogetherModelIds.MetaLlama38BInstructReference, ToMetadata("meta-llama/Llama-3-8b-chat-hf",8192,2.0000000000000002E-07,2.0000000000000002E-07)},
        { TogetherModelIds.GemmaInstruct2B, ToMetadata("google/gemma-2b-it",8192,1.0000000000000001E-07,1.0000000000000001E-07)},
        { TogetherModelIds.MetaLlama370BInstructLite, ToMetadata("meta-llama/Meta-Llama-3-70B-Instruct-Lite",8192,5.4E-07,5.4E-07)},
        { TogetherModelIds.Gemma2Instruct9B, ToMetadata("google/gemma-2-9b-it",8192,3E-07,3E-07)},
        { TogetherModelIds.MetaLlama3370BInstructTurbo, ToMetadata("meta-llama/Llama-3.3-70B-Instruct-Turbo",131072,8.8E-07,8.8E-07)},
        { TogetherModelIds.GrypheMythomaxL2Lite13B, ToMetadata("Gryphe/MythoMax-L2-13b-Lite",4096,1.0000000000000001E-07,1.0000000000000001E-07)},
        { TogetherModelIds.MetaLlama3290BVisionInstructTurbo, ToMetadata("meta-llama/Llama-3.2-90B-Vision-Instruct-Turbo",131072,1.2E-06,1.2E-06)},
        { TogetherModelIds.Llama2Chat7B, ToMetadata("meta-llama/Llama-2-7b-chat-hf",4096,2.0000000000000002E-07,2.0000000000000002E-07)},
        { TogetherModelIds.DeepseekR1DistillLlama70B, ToMetadata("deepseek-ai/DeepSeek-R1-Distill-Llama-70B",131072,2E-06,2E-06)},
        { TogetherModelIds.DeepseekR1DistillQwen15B, ToMetadata("deepseek-ai/DeepSeek-R1-Distill-Qwen-1.5B",131072,1.8E-07,1.8E-07)},
        { TogetherModelIds.Llama2Chat13B, ToMetadata("meta-llama/Llama-2-13b-chat-hf",4096,2.2E-07,2.2E-07)},
        { TogetherModelIds.Typhoon158BInstruct, ToMetadata("scb10x/scb10x-llama3-typhoon-v1-5-8b-instruct",8192,1.8E-07,1.8E-07)},
        { TogetherModelIds.Typhoon15X70BAwq, ToMetadata("scb10x/scb10x-llama3-typhoon-v1-5x-4f316",8192,8.8E-07,8.8E-07)},
        { TogetherModelIds.Llama31Nemotron70BInstructHf, ToMetadata("nvidia/Llama-3.1-Nemotron-70B-Instruct-HF",32768,8.8E-07,8.8E-07)},
        { TogetherModelIds.Qwen25Coder32BInstruct, ToMetadata("Qwen/Qwen2.5-Coder-32B-Instruct",16384,8.000000000000001E-07,8.000000000000001E-07)},
        { TogetherModelIds.Wizardlm28X22b, ToMetadata("microsoft/WizardLM-2-8x22B",65536,1.2E-06,1.2E-06)},
        { TogetherModelIds.Mistral7BInstructV03, ToMetadata("mistralai/Mistral-7B-Instruct-v0.3",32768,2.0000000000000002E-07,2.0000000000000002E-07)},
        { TogetherModelIds.Typhoon270BInstruct, ToMetadata("scb10x/scb10x-llama3-1-typhoon2-60256",8192,8.8E-07,8.8E-07)},
        { TogetherModelIds.Qwen257BInstructTurbo, ToMetadata("Qwen/Qwen2.5-7B-Instruct-Turbo",32768,3E-07,3E-07)},
        { TogetherModelIds.Typhoon28BInstruct, ToMetadata("scb10x/scb10x-llama3-1-typhoon-18370",8192,1.8E-07,1.8E-07)},
        { TogetherModelIds.MetaLlama323BInstructTurbo, ToMetadata("meta-llama/Llama-3.2-3B-Instruct-Turbo",131072,6E-08,6E-08)},
        { TogetherModelIds.MetaLlama370BInstructReference, ToMetadata("meta-llama/Llama-3-70b-chat-hf",8192,8.8E-07,8.8E-07)},
        { TogetherModelIds.Mixtral8X7BInstructV01, ToMetadata("mistralai/Mixtral-8x7B-Instruct-v0.1",32768,6E-07,6E-07)},
        { TogetherModelIds.TogetherAiMoa1Turbo, ToMetadata("togethercomputer/MoA-1-Turbo",32768,0,0)},
        { TogetherModelIds.DeepseekR1DistillLlama70BFree, ToMetadata("deepseek-ai/DeepSeek-R1-Distill-Llama-70B-free",8192,0,0)},
        { TogetherModelIds.DeepseekR1DistillQwen14B, ToMetadata("deepseek-ai/DeepSeek-R1-Distill-Qwen-14B",131072,1.6000000000000001E-06,1.6000000000000001E-06)},
        { TogetherModelIds.Mistral7BInstruct, ToMetadata("mistralai/Mistral-7B-Instruct-v0.1",32768,2.0000000000000002E-07,2.0000000000000002E-07)},

    };

    public static ChatModelMetadata ToMetadata(string? id, int? contextLength, double? pricePerInputTokenInUsd, double? pricePerOutputTokenInUsd)
    {
        return new ChatModelMetadata
        {
            Id = id,
            ContextLength = contextLength,
            PricePerInputTokenInUsd = pricePerInputTokenInUsd,
            PricePerOutputTokenInUsd = pricePerOutputTokenInUsd,
        };
    }

    [CLSCompliant(false)]
    public static ChatModelMetadata GetModelById(TogetherModelIds modelId)
    {
        if (Models.TryGetValue(modelId, out var id))
        {
            return id;
        }

        throw new ArgumentException($"Invalid Together Ai Model {modelId}");
    }
}