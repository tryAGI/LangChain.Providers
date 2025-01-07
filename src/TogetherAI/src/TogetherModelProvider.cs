using tryAGI.OpenAI;

namespace LangChain.Providers.Together;

/// <summary>
/// Contains all the Together Ai models.
/// </summary>
public static class TogetherModelProvider
{
    private static Dictionary<TogetherModelIds, ChatModelMetadata> Models { get; set; } = new()
    {
        { TogetherModelIds.CodeLlamaInstruct34B, ToMetadata("codellama/CodeLlama-34b-Instruct-hf",16384,7.760000000000001E-07,7.760000000000001E-07)},
        { TogetherModelIds.UpstageSolarInstructV111B, ToMetadata("upstage/SOLAR-10.7B-Instruct-v1.0",4096,3E-07,3E-07)},
        { TogetherModelIds.NousHermes2Yi34B, ToMetadata("NousResearch/Nous-Hermes-2-Yi-34B",4096,8.000000000000001E-07,8.000000000000001E-07)},
        { TogetherModelIds.Llama38BChatHfInt4, ToMetadata("togethercomputer/Llama-3-8b-chat-hf-int4",8192,2.0000000000000002E-07,2.0000000000000002E-07)},
        { TogetherModelIds.StripedhyenaNous7B, ToMetadata("togethercomputer/StripedHyena-Nous-7B",32768,2.0000000000000002E-07,2.0000000000000002E-07)},
        { TogetherModelIds.GemmaInstruct2B, ToMetadata("google/gemma-2b-it",8192,1.0000000000000001E-07,1.0000000000000001E-07)},
        { TogetherModelIds.MythomaxL213B, ToMetadata("Gryphe/MythoMax-L2-13b",4096,3E-07,3E-07)},
        { TogetherModelIds.Mistral7BInstruct, ToMetadata("mistralai/Mistral-7B-Instruct-v0.1",4096,2.0000000000000002E-07,2.0000000000000002E-07)},
        { TogetherModelIds.Mistral7BInstructV02, ToMetadata("mistralai/Mistral-7B-Instruct-v0.2",32768,2.0000000000000002E-07,2.0000000000000002E-07)},
        { TogetherModelIds.Qwen2Instruct72B, ToMetadata("Qwen/Qwen2-72B-Instruct",32768,9.000000000000001E-07,9.000000000000001E-07)},
        { TogetherModelIds.Qwen15Chat72B, ToMetadata("Qwen/Qwen1.5-72B-Chat",32768,9.000000000000001E-07,9.000000000000001E-07)},
        { TogetherModelIds.DeepseekLlmChat67B, ToMetadata("deepseek-ai/deepseek-llm-67b-chat",4096,9.000000000000001E-07,9.000000000000001E-07)},
        { TogetherModelIds.TogethercomputerLlama38BInstructInt8, ToMetadata("togethercomputer/Llama-3-8b-chat-hf-int8",8192,2.0000000000000002E-07,2.0000000000000002E-07)},
        { TogetherModelIds.Mistral7BInstructV03, ToMetadata("mistralai/Mistral-7B-Instruct-v0.3",32768,2.0000000000000002E-07,2.0000000000000002E-07)},
        { TogetherModelIds.Qwen15Chat110B, ToMetadata("Qwen/Qwen1.5-110B-Chat",32768,1.8000000000000001E-06,1.8000000000000001E-06)},
        { TogetherModelIds.Llama2Chat13B, ToMetadata("meta-llama/Llama-2-13b-chat-hf",4096,2.2E-07,2.2E-07)},
        { TogetherModelIds.Gemma2Instruct27B, ToMetadata("google/gemma-2-27b-it",8192,8.000000000000001E-07,8.000000000000001E-07)},
        { TogetherModelIds.MetaLlama370BInstructTurbo, ToMetadata("meta-llama/Meta-Llama-3-70B-Instruct-Turbo",8192,8.8E-07,8.8E-07)},
        { TogetherModelIds.MetaLlama370BInstructLite, ToMetadata("meta-llama/Meta-Llama-3-70B-Instruct-Lite",8192,5.4E-07,5.4E-07)},
        { TogetherModelIds.Gemma2Instruct9B, ToMetadata("google/gemma-2-9b-it",8192,3E-07,3E-07)},
        { TogetherModelIds.MetaLlama38BInstructReference, ToMetadata("meta-llama/Llama-3-8b-chat-hf",8192,2.0000000000000002E-07,2.0000000000000002E-07)},
        { TogetherModelIds.MetaLlama3170BInstructTurbo, ToMetadata("meta-llama/Meta-Llama-3.1-70B-Instruct-Turbo",32768,8.8E-07,8.8E-07)},
        { TogetherModelIds.MetaLlama318BInstructTurbo, ToMetadata("meta-llama/Meta-Llama-3.1-8B-Instruct-Turbo",32768,1.8E-07,1.8E-07)},
        { TogetherModelIds.Wizardlm28X22b, ToMetadata("microsoft/WizardLM-2-8x22B",65536,1.2E-06,1.2E-06)},
        { TogetherModelIds.Mixtral8X7BInstructV01, ToMetadata("mistralai/Mixtral-8x7B-Instruct-v0.1",32768,6E-07,6E-07)},
        { TogetherModelIds.MetaLlama31405BInstructTurbo, ToMetadata("meta-llama/Meta-Llama-3.1-405B-Instruct-Lite-Pro",4096,0,0)},
        { TogetherModelIds.MetaLlama370BInstructReference, ToMetadata("meta-llama/Llama-3-70b-chat-hf",8192,9.000000000000001E-07,9.000000000000001E-07)},
        { TogetherModelIds.DbrxInstruct, ToMetadata("databricks/dbrx-instruct",32768,1.2E-06,1.2E-06)},
        { TogetherModelIds.NousHermes2Mixtral8X7BDpo, ToMetadata("NousResearch/Nous-Hermes-2-Mixtral-8x7B-DPO",32768,6E-07,6E-07)},
        { TogetherModelIds.MetaLlama38BInstructTurbo, ToMetadata("meta-llama/Meta-Llama-3-8B-Instruct-Turbo",8192,1.8E-07,1.8E-07)},
        { TogetherModelIds.MetaLlama38BInstructLite, ToMetadata("meta-llama/Meta-Llama-3-8B-Instruct-Lite",8192,1.0000000000000001E-07,1.0000000000000001E-07)},
        { TogetherModelIds.MetaLlama318BInstruct, ToMetadata("meta-llama/Meta-Llama-3.1-8B-Instruct-Reference",16384,2.0000000000000002E-07,2.0000000000000002E-07)},
        { TogetherModelIds.Mixtral8X22bInstructV01, ToMetadata("mistralai/Mixtral-8x22B-Instruct-v0.1",65536,1.2E-06,1.2E-06)},
        { TogetherModelIds.GrypheMythomaxL2Lite13B, ToMetadata("Gryphe/MythoMax-L2-13b-Lite",4096,2.0000000000000002E-07,4.0000000000000003E-07)},
        { TogetherModelIds.Llama2Chat7B, ToMetadata("meta-llama/Llama-2-7b-chat-hf",4096,2.0000000000000002E-07,2.0000000000000002E-07)},
        { TogetherModelIds.LlavaNextMistral7B, ToMetadata("llava-hf/llava-v1.6-mistral-7b-hf",4096,1.8E-07,1.8E-07)},
        { TogetherModelIds.WizardlmV1213B, ToMetadata("WizardLM/WizardLM-13B-V1.2",4096,2.0000000000000002E-07,2.0000000000000002E-07)},
        { TogetherModelIds.Qwen2Instruct15B, ToMetadata("Qwen/Qwen2-1.5B-Instruct",32768,2E-08,2E-08)},
        { TogetherModelIds.OpenHermes2Mistral7B, ToMetadata("teknium/OpenHermes-2-Mistral-7B",8192,2.0000000000000002E-07,2.0000000000000002E-07)},
        { TogetherModelIds.Qwen2Instruct7B, ToMetadata("Qwen/Qwen2-7B-Instruct",32768,9.000000000000001E-07,9.000000000000001E-07)},
        { TogetherModelIds.RemmSlerpL213B, ToMetadata("Undi95/ReMM-SLERP-L2-13B",4096,3E-07,3E-07)},
        { TogetherModelIds.ToppyM7B, ToMetadata("Undi95/Toppy-M-7B",4096,2.0000000000000002E-07,2.0000000000000002E-07)},
        { TogetherModelIds.PhindCodeLlamaV234B, ToMetadata("Phind/Phind-CodeLlama-34B-v2",16384,8.000000000000001E-07,8.000000000000001E-07)},
        { TogetherModelIds.OpenChat35, ToMetadata("openchat/openchat-3.5-1210",8192,2.0000000000000002E-07,2.0000000000000002E-07)},
        { TogetherModelIds.ChronosHermes13B, ToMetadata("Austism/chronos-hermes-13b",2048,3E-07,3E-07)},
        { TogetherModelIds.SnorkelMistralPairrmDpo7B, ToMetadata("snorkelai/Snorkel-Mistral-PairRM-DPO",32768,2.0000000000000002E-07,2.0000000000000002E-07)},
        { TogetherModelIds.Qwen15Chat14B, ToMetadata("Qwen/Qwen1.5-14B-Chat",32768,3E-07,3E-07)},
        { TogetherModelIds.Qwen15Chat18B, ToMetadata("Qwen/Qwen1.5-1.8B-Chat",32768,1.0000000000000001E-07,1.0000000000000001E-07)},
        { TogetherModelIds.SnowflakeArcticInstruct, ToMetadata("Snowflake/snowflake-arctic-instruct",4096,2.4E-06,2.4E-06)},
        { TogetherModelIds.NousHermes2Mixtral8X7BSft, ToMetadata("NousResearch/Nous-Hermes-2-Mixtral-8x7B-SFT",32768,6E-07,6E-07)},
        { TogetherModelIds.DeepseekCoderInstruct33B, ToMetadata("deepseek-ai/deepseek-coder-33b-instruct",16384,8.000000000000001E-07,8.000000000000001E-07)},
        { TogetherModelIds.CodeLlamaPython34B, ToMetadata("codellama/CodeLlama-34b-Python-hf",16384,7.760000000000001E-07,7.760000000000001E-07)},
        { TogetherModelIds.NousHermesLlama213B, ToMetadata("NousResearch/Nous-Hermes-Llama2-13b",4096,3E-07,3E-07)},
        { TogetherModelIds.VicunaV1513B, ToMetadata("lmsys/vicuna-13b-v1.5",4096,3E-07,3E-07)},
        { TogetherModelIds.CodeLlamaPython70B, ToMetadata("codellama/CodeLlama-70b-Python-hf",4096,9.000000000000001E-07,9.000000000000001E-07)},
        { TogetherModelIds.CodeLlamaInstruct13B, ToMetadata("codellama/CodeLlama-13b-Instruct-hf",16384,2.2E-07,2.2E-07)},
        { TogetherModelIds.WizardcoderPythonV1034B, ToMetadata("WizardLM/WizardCoder-Python-34B-V1.0",8192,8.000000000000001E-07,8.000000000000001E-07)},
        { TogetherModelIds.NousHermes2MistralDpo7B, ToMetadata("NousResearch/Nous-Hermes-2-Mistral-7B-DPO",32768,2.0000000000000002E-07,2.0000000000000002E-07)},
        { TogetherModelIds.Alpaca7B, ToMetadata("togethercomputer/alpaca-7b",2048,2.0000000000000002E-07,2.0000000000000002E-07)},
        { TogetherModelIds.Platypus2Instruct70B, ToMetadata("garage-bAInd/Platypus2-70B-instruct",4096,9.000000000000001E-07,9.000000000000001E-07)},
        { TogetherModelIds.GemmaInstruct7B, ToMetadata("google/gemma-7b-it",8192,2.0000000000000002E-07,2.0000000000000002E-07)},
        { TogetherModelIds.OlmoInstruct7B, ToMetadata("allenai/OLMo-7B-Instruct",2048,2.0000000000000002E-07,2.0000000000000002E-07)},
        { TogetherModelIds.UpstageSolarInstructV111BInt4, ToMetadata("togethercomputer/SOLAR-10.7B-Instruct-v1.0-int4",4096,3E-07,3E-07)},
        { TogetherModelIds.OpenOrcaMistral7B8K, ToMetadata("Open-Orca/Mistral-7B-OpenOrca",8192,2.0000000000000002E-07,2.0000000000000002E-07)},
        { TogetherModelIds.NousHermesLlama27B, ToMetadata("NousResearch/Nous-Hermes-llama-2-7b",4096,2.0000000000000002E-07,2.0000000000000002E-07)},
        { TogetherModelIds.Qwen15Chat32B, ToMetadata("Qwen/Qwen1.5-32B-Chat",32768,8.000000000000001E-07,8.000000000000001E-07)},
        { TogetherModelIds.NousCapybaraV197B, ToMetadata("NousResearch/Nous-Capybara-7B-V1p9",8192,2.0000000000000002E-07,2.0000000000000002E-07)},
        { TogetherModelIds.MetaLlama38BInstruct, ToMetadata("meta-llama/Meta-Llama-3-8B-Instruct",8192,2.0000000000000002E-07,2.0000000000000002E-07)},
        { TogetherModelIds.VicunaV157B, ToMetadata("lmsys/vicuna-7b-v1.5",4096,2.0000000000000002E-07,2.0000000000000002E-07)},
        { TogetherModelIds._01AiYiChat34B, ToMetadata("zero-one-ai/Yi-34B-Chat",4096,8.000000000000001E-07,8.000000000000001E-07)},
        { TogetherModelIds.MetaLlama370BInstruct, ToMetadata("meta-llama/Meta-Llama-3-70B-Instruct",8192,9.000000000000001E-07,9.000000000000001E-07)},
        { TogetherModelIds.CodeLlama70B, ToMetadata("codellama/CodeLlama-70b-hf",16384,9.000000000000001E-07,9.000000000000001E-07)},
        { TogetherModelIds.CodeLlamaInstruct70B, ToMetadata("codellama/CodeLlama-70b-Instruct-hf",4096,9.000000000000001E-07,9.000000000000001E-07)},
        { TogetherModelIds.Hermes2ThetaLlama370B, ToMetadata("NousResearch/Hermes-2-Theta-Llama-3-70B",8192,0,0)},
        { TogetherModelIds.Qwen15Chat7B, ToMetadata("Qwen/Qwen1.5-7B-Chat",32768,2.0000000000000002E-07,2.0000000000000002E-07)},
        { TogetherModelIds.Dolphin25Mixtral8X7B, ToMetadata("cognitivecomputations/dolphin-2.5-mixtral-8x7b",32768,6E-07,6E-07)},
        { TogetherModelIds.CodeLlamaPython13B, ToMetadata("codellama/CodeLlama-13b-Python-hf",16384,2.2E-07,2.2E-07)},
        { TogetherModelIds.Qwen15Chat05B, ToMetadata("Qwen/Qwen1.5-0.5B-Chat",32768,1.0000000000000001E-07,1.0000000000000001E-07)},
        { TogetherModelIds.CodeLlamaInstruct7B, ToMetadata("codellama/CodeLlama-7b-Instruct-hf",16384,2.0000000000000002E-07,2.0000000000000002E-07)},
        { TogetherModelIds.OpenHermes25Mistral7B, ToMetadata("teknium/OpenHermes-2p5-Mistral-7B",8192,2.0000000000000002E-07,2.0000000000000002E-07)},
        { TogetherModelIds.Qwen15Chat4B, ToMetadata("Qwen/Qwen1.5-4B-Chat",32768,1.0000000000000001E-07,1.0000000000000001E-07)},
        { TogetherModelIds.Llama2Chat70B, ToMetadata("meta-llama/Llama-2-70b-chat-hf",4096,9.000000000000001E-07,9.000000000000001E-07)},
        { TogetherModelIds.CodeLlamaPython7B, ToMetadata("codellama/CodeLlama-7b-Python-hf",16384,2.0000000000000002E-07,2.0000000000000002E-07)},
        { TogetherModelIds.CarsonMl318br, ToMetadata("carson/ml318br",8192,2.0000000000000002E-07,2.0000000000000002E-07)},
        { TogetherModelIds.Llama370BInstructGradient1048K, ToMetadata("gradientai/Llama-3-70B-Instruct-Gradient-1048k",1048576,0,0)},
        { TogetherModelIds.MetaLlama3170BInstruct, ToMetadata("meta-llama/Meta-Llama-3.1-70B-Instruct-Reference",8192,9.000000000000001E-07,9.000000000000001E-07)},

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