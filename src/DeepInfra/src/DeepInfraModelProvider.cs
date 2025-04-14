using tryAGI.OpenAI;

namespace LangChain.Providers.DeepInfra;

/// <summary>
/// Contains all the DeepInfra models.
/// </summary>
public static class DeepInfraModelProvider
{
    private static Dictionary<DeepInfraModelIds, ChatModelMetadata> Models { get; set; } = new()
    {
        { DeepInfraModelIds.Llama4Maverick17B128EInstructFp8, ToMetadata("meta-llama/Llama-4-Maverick-17B-128E-Instruct-FP8",1048576,1.8E-07,6E-07)},
        { DeepInfraModelIds.Llama4Scout17B16EInstruct, ToMetadata("meta-llama/Llama-4-Scout-17B-16E-Instruct",327680,8E-08,3E-07)},
        { DeepInfraModelIds.DeepseekR1Turbo, ToMetadata("deepseek-ai/DeepSeek-R1-Turbo",32768,1E-06,3E-06)},
        { DeepInfraModelIds.DeepseekR1, ToMetadata("deepseek-ai/DeepSeek-R1",163840,5.4E-07,2.1800000000000003E-06)},
        { DeepInfraModelIds.Qwq32B, ToMetadata("Qwen/QwQ-32B",131072,1.5E-07,2.0000000000000002E-07)},
        { DeepInfraModelIds.DeepseekV30324, ToMetadata("deepseek-ai/DeepSeek-V3-0324",163840,3.5E-07,8.900000000000001E-07)},
        { DeepInfraModelIds.Gemma327BIt, ToMetadata("google/gemma-3-27b-it",131072,1.0000000000000001E-07,2.0000000000000002E-07)},
        { DeepInfraModelIds.Gemma312BIt, ToMetadata("google/gemma-3-12b-it",131072,5.0000000000000004E-08,1.0000000000000001E-07)},
        { DeepInfraModelIds.Gemma34BIt, ToMetadata("google/gemma-3-4b-it",131072,2E-08,4E-08)},
        { DeepInfraModelIds.Phi4MultimodalInstruct, ToMetadata("microsoft/Phi-4-multimodal-instruct",131072,5.0000000000000004E-08,1.0000000000000001E-07)},
        { DeepInfraModelIds.DeepseekR1DistillLlama70B, ToMetadata("deepseek-ai/DeepSeek-R1-Distill-Llama-70B",131072,1.2E-07,4.0000000000000003E-07)},
        { DeepInfraModelIds.DeepseekV3, ToMetadata("deepseek-ai/DeepSeek-V3",163840,3.8E-07,8.900000000000001E-07)},
        { DeepInfraModelIds.Llama3370BInstructTurbo, ToMetadata("meta-llama/Llama-3.3-70B-Instruct-Turbo",131072,1.2E-07,2.8E-07)},
        { DeepInfraModelIds.Llama3370BInstruct, ToMetadata("meta-llama/Llama-3.3-70B-Instruct",131072,2.3000000000000002E-07,4.0000000000000003E-07)},
        { DeepInfraModelIds.MistralSmall24BInstruct2501, ToMetadata("mistralai/Mistral-Small-24B-Instruct-2501",32768,7E-08,1.4E-07)},
        { DeepInfraModelIds.DeepseekR1DistillQwen32B, ToMetadata("deepseek-ai/DeepSeek-R1-Distill-Qwen-32B",131072,1.2E-07,1.8E-07)},
        { DeepInfraModelIds.Phi4, ToMetadata("microsoft/phi-4",16384,7E-08,1.4E-07)},
        { DeepInfraModelIds.MetaLlama3170BInstruct, ToMetadata("meta-llama/Meta-Llama-3.1-70B-Instruct",131072,2.3000000000000002E-07,4.0000000000000003E-07)},
        { DeepInfraModelIds.MetaLlama318BInstruct, ToMetadata("meta-llama/Meta-Llama-3.1-8B-Instruct",131072,3E-08,5.0000000000000004E-08)},
        { DeepInfraModelIds.MetaLlama31405BInstruct, ToMetadata("meta-llama/Meta-Llama-3.1-405B-Instruct",32768,8.000000000000001E-07,8.000000000000001E-07)},
        { DeepInfraModelIds.MetaLlama318BInstructTurbo, ToMetadata("meta-llama/Meta-Llama-3.1-8B-Instruct-Turbo",131072,2E-08,4E-08)},
        { DeepInfraModelIds.MetaLlama3170BInstructTurbo, ToMetadata("meta-llama/Meta-Llama-3.1-70B-Instruct-Turbo",131072,1.2E-07,2.8E-07)},
        { DeepInfraModelIds.Qwen25Coder32BInstruct, ToMetadata("Qwen/Qwen2.5-Coder-32B-Instruct",32768,7E-08,1.5E-07)},
        { DeepInfraModelIds.Llama31Nemotron70BInstruct, ToMetadata("nvidia/Llama-3.1-Nemotron-70B-Instruct",131072,1.2E-07,3E-07)},
        { DeepInfraModelIds.Qwen2572BInstruct, ToMetadata("Qwen/Qwen2.5-72B-Instruct",32768,1.2E-07,3.9E-07)},
        { DeepInfraModelIds.Llama3290BVisionInstruct, ToMetadata("meta-llama/Llama-3.2-90B-Vision-Instruct",32768,3.5E-07,4.0000000000000003E-07)},
        { DeepInfraModelIds.Llama3211BVisionInstruct, ToMetadata("meta-llama/Llama-3.2-11B-Vision-Instruct",131072,5.0000000000000004E-08,5.0000000000000004E-08)},
        { DeepInfraModelIds.Wizardlm28X22b, ToMetadata("microsoft/WizardLM-2-8x22B",65536,5E-07,5E-07)},
        { DeepInfraModelIds.ChronosHermes13BV2, ToMetadata("Austism/chronos-hermes-13b-v2",4096,1.3E-07,1.3E-07)},
        { DeepInfraModelIds.MythomaxL213B, ToMetadata("Gryphe/MythoMax-L2-13b",4096,6E-08,6E-08)},
        { DeepInfraModelIds.MythomaxL213BTurbo, ToMetadata("Gryphe/MythoMax-L2-13b-turbo",4096,1.3E-07,1.3E-07)},
        { DeepInfraModelIds.Llama213BTiefighter, ToMetadata("KoboldAI/LLaMA2-13B-Tiefighter",4096,1.0000000000000001E-07,1.0000000000000001E-07)},
        { DeepInfraModelIds.Hermes3Llama31405B, ToMetadata("NousResearch/Hermes-3-Llama-3.1-405B",131072,8.000000000000001E-07,8.000000000000001E-07)},
        { DeepInfraModelIds.SkyT132BPreview, ToMetadata("NovaSky-AI/Sky-T1-32B-Preview",32768,1.2E-07,1.8E-07)},
        { DeepInfraModelIds.PhindCodellama34BV2, ToMetadata("Phind/Phind-CodeLlama-34B-v2",4096,6E-07,6E-07)},
        { DeepInfraModelIds.Qvq72BPreview, ToMetadata("Qwen/QVQ-72B-Preview",32000,2.5E-07,5E-07)},
        { DeepInfraModelIds.Qwq32BPreview, ToMetadata("Qwen/QwQ-32B-Preview",32768,1.2E-07,1.8E-07)},
        { DeepInfraModelIds.Qwen272BInstruct, ToMetadata("Qwen/Qwen2-72B-Instruct",32768,3.5E-07,4.0000000000000003E-07)},
        { DeepInfraModelIds.Qwen27BInstruct, ToMetadata("Qwen/Qwen2-7B-Instruct",32768,6E-08,6E-08)},
        { DeepInfraModelIds.Qwen257BInstruct, ToMetadata("Qwen/Qwen2.5-7B-Instruct",32768,5.0000000000000004E-08,1.0000000000000001E-07)},
        { DeepInfraModelIds.Qwen25Coder7B, ToMetadata("Qwen/Qwen2.5-Coder-7B",32768,2E-08,5.0000000000000004E-08)},
        { DeepInfraModelIds.L370BEuryaleV21, ToMetadata("Sao10K/L3-70B-Euryale-v2.1",8192,7E-07,8.000000000000001E-07)},
        { DeepInfraModelIds.L38BLunarisV1, ToMetadata("Sao10K/L3-8B-Lunaris-v1",8192,3E-08,6E-08)},
        { DeepInfraModelIds.L38BLunarisV1Turbo, ToMetadata("Sao10K/L3-8B-Lunaris-v1-Turbo",8192,2E-08,5.0000000000000004E-08)},
        { DeepInfraModelIds.L3170BEuryaleV22, ToMetadata("Sao10K/L3.1-70B-Euryale-v2.2",131072,7E-07,8.000000000000001E-07)},
        { DeepInfraModelIds.L3370BEuryaleV23, ToMetadata("Sao10K/L3.3-70B-Euryale-v2.3",131072,7E-07,8.000000000000001E-07)},
        { DeepInfraModelIds.Claude37SonnetLatest, ToMetadata("anthropic/claude-3-7-sonnet-latest",200000,3.2999999999999997E-06,1.65E-05)},
        { DeepInfraModelIds.Starcoder215BInstructV01, ToMetadata("bigcode/starcoder2-15b-instruct-v0.1",null,1.5E-07,1.5E-07)},
        { DeepInfraModelIds.Dolphin26Mixtral8X7B, ToMetadata("cognitivecomputations/dolphin-2.6-mixtral-8x7b",32768,2.4E-07,2.4E-07)},
        { DeepInfraModelIds.Dolphin291Llama370B, ToMetadata("cognitivecomputations/dolphin-2.9.1-llama-3-70b",8192,3.5E-07,4.0000000000000003E-07)},
        { DeepInfraModelIds.Airoboros70B, ToMetadata("deepinfra/airoboros-70b",4096,7E-07,9.000000000000001E-07)},
        { DeepInfraModelIds.Codegemma7BIt, ToMetadata("google/codegemma-7b-it",8192,7E-08,7E-08)},
        { DeepInfraModelIds.Gemini15Flash, ToMetadata("google/gemini-1.5-flash",1000000,8E-08,3E-07)},
        { DeepInfraModelIds.Gemini15Flash8B, ToMetadata("google/gemini-1.5-flash-8b",1000000,4E-08,1.5E-07)},
        { DeepInfraModelIds.Gemini20Flash001, ToMetadata("google/gemini-2.0-flash-001",1000000,1.0000000000000001E-07,4.0000000000000003E-07)},
        { DeepInfraModelIds.Gemma117BIt, ToMetadata("google/gemma-1.1-7b-it",8192,7E-08,7E-08)},
        { DeepInfraModelIds.Gemma227BIt, ToMetadata("google/gemma-2-27b-it",8192,2.7E-07,2.7E-07)},
        { DeepInfraModelIds.Gemma29BIt, ToMetadata("google/gemma-2-9b-it",8192,3E-08,6E-08)},
        { DeepInfraModelIds.Lzlv70BFp16Hf, ToMetadata("lizpreciatior/lzlv_70b_fp16_hf",4096,3.5E-07,4.0000000000000003E-07)},
        { DeepInfraModelIds.ReflectionLlama3170B, ToMetadata("mattshumer/Reflection-Llama-3.1-70B",8192,3.5E-07,4.0000000000000003E-07)},
        { DeepInfraModelIds.Llama213BChatHf, ToMetadata("meta-llama/Llama-2-13b-chat-hf",4096,1.3E-07,1.3E-07)},
        { DeepInfraModelIds.Llama270BChatHf, ToMetadata("meta-llama/Llama-2-70b-chat-hf",4096,6.4E-07,8.000000000000001E-07)},
        { DeepInfraModelIds.Llama321BInstruct, ToMetadata("meta-llama/Llama-3.2-1B-Instruct",131072,1E-08,1E-08)},
        { DeepInfraModelIds.Llama323BInstruct, ToMetadata("meta-llama/Llama-3.2-3B-Instruct",131072,2E-08,2E-08)},
        { DeepInfraModelIds.MetaLlama370BInstruct, ToMetadata("meta-llama/Meta-Llama-3-70B-Instruct",8192,3E-07,4.0000000000000003E-07)},
        { DeepInfraModelIds.MetaLlama38BInstruct, ToMetadata("meta-llama/Meta-Llama-3-8B-Instruct",8192,3E-08,6E-08)},
        { DeepInfraModelIds.Phi3Medium4KInstruct, ToMetadata("microsoft/Phi-3-medium-4k-instruct",4096,1.4E-07,1.4E-07)},
        { DeepInfraModelIds.Wizardlm27B, ToMetadata("microsoft/WizardLM-2-7B",32768,6E-08,6E-08)},
        { DeepInfraModelIds.Mistral7BInstructV01, ToMetadata("mistralai/Mistral-7B-Instruct-v0.1",32768,6E-08,6E-08)},
        { DeepInfraModelIds.Mistral7BInstructV02, ToMetadata("mistralai/Mistral-7B-Instruct-v0.2",32768,6E-08,6E-08)},
        { DeepInfraModelIds.Mistral7BInstructV03, ToMetadata("mistralai/Mistral-7B-Instruct-v0.3",32768,4E-08,6E-08)},
        { DeepInfraModelIds.MistralNemoInstruct2407, ToMetadata("mistralai/Mistral-Nemo-Instruct-2407",131072,3E-08,8E-08)},
        { DeepInfraModelIds.Mixtral8X22bInstructV01, ToMetadata("mistralai/Mixtral-8x22B-Instruct-v0.1",65536,6.5E-07,6.5E-07)},
        { DeepInfraModelIds.Mixtral8X7BInstructV01, ToMetadata("mistralai/Mixtral-8x7B-Instruct-v0.1",32768,2.4E-07,2.4E-07)},
        { DeepInfraModelIds.Nemotron4340BInstruct, ToMetadata("nvidia/Nemotron-4-340B-Instruct",4096,4.2000000000000004E-06,4.2000000000000004E-06)},
        { DeepInfraModelIds.MinicpmLlama3V25, ToMetadata("openbmb/MiniCPM-Llama3-V-2_5",8192,3.4000000000000003E-07,3.4000000000000003E-07)},
        { DeepInfraModelIds.OpenChat368B, ToMetadata("openchat/openchat-3.6-8b",8192,6E-08,6E-08)},
        { DeepInfraModelIds.OpenChat35, ToMetadata("openchat/openchat_3.5",8192,6E-08,6E-08)},
        { DeepInfraModelIds.BgeBaseEnV15, ToMetadata("BAAI/bge-base-en-v1.5",512,0,0)},
        { DeepInfraModelIds.BgeEnIcl, ToMetadata("BAAI/bge-en-icl",8192,1E-08,0)},
        { DeepInfraModelIds.BgeLargeEnV15, ToMetadata("BAAI/bge-large-en-v1.5",512,1E-08,0)},
        { DeepInfraModelIds.BgeM3, ToMetadata("BAAI/bge-m3",8192,1E-08,0)},
        { DeepInfraModelIds.BgeM3Multi, ToMetadata("BAAI/bge-m3-multi",8192,1E-08,0)},
        { DeepInfraModelIds.E5BaseV2, ToMetadata("intfloat/e5-base-v2",512,0,0)},
        { DeepInfraModelIds.E5LargeV2, ToMetadata("intfloat/e5-large-v2",512,1E-08,0)},
        { DeepInfraModelIds.MultilingualE5Large, ToMetadata("intfloat/multilingual-e5-large",512,1E-08,0)},
        { DeepInfraModelIds.AllMinilmL12V2, ToMetadata("sentence-transformers/all-MiniLM-L12-v2",512,0,0)},
        { DeepInfraModelIds.AllMinilmL6V2, ToMetadata("sentence-transformers/all-MiniLM-L6-v2",512,0,0)},
        { DeepInfraModelIds.AllMpnetBaseV2, ToMetadata("sentence-transformers/all-mpnet-base-v2",512,0,0)},
        { DeepInfraModelIds.ClipVitB32, ToMetadata("sentence-transformers/clip-ViT-B-32",77,0,0)},
        { DeepInfraModelIds.ClipVitB32MultilingualV1, ToMetadata("sentence-transformers/clip-ViT-B-32-multilingual-v1",512,0,0)},
        { DeepInfraModelIds.MultiQaMpnetBaseDotV1, ToMetadata("sentence-transformers/multi-qa-mpnet-base-dot-v1",512,0,0)},
        { DeepInfraModelIds.ParaphraseMinilmL6V2, ToMetadata("sentence-transformers/paraphrase-MiniLM-L6-v2",512,0,0)},
        { DeepInfraModelIds.Text2vecBaseChinese, ToMetadata("shibing624/text2vec-base-chinese",512,0,0)},
        { DeepInfraModelIds.GteBase, ToMetadata("thenlper/gte-base",512,0,0)},
        { DeepInfraModelIds.GteLarge, ToMetadata("thenlper/gte-large",512,1E-08,0)},

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
    public static ChatModelMetadata GetModelById(DeepInfraModelIds modelId)
    {
        if (Models.TryGetValue(modelId, out var id))
        {
            return id;
        }

        throw new ArgumentException($"Invalid Deep Infra Model {modelId}");
    }
}