using tryAGI.OpenAI;

namespace LangChain.Providers.OpenRouter;

/// <summary>
/// Contains all the OpenRouter models.
/// </summary>
public static class OpenRouterModelProvider
{
    private static Dictionary<OpenRouterModelIds, ChatModelMetadata> Models { get; set; } = new()
    {
        
        [OpenRouterModelIds.MoonshotAiMoonlight16BA3bInstructFree] = new ChatModelMetadata
        {
            Id = "moonshotai/moonlight-16b-a3b-instruct:free",
            ContextLength = 8192,
            PricePerInputTokenInUsd = 0,
            PricePerOutputTokenInUsd = 0,
        },

        
        [OpenRouterModelIds.NousDeephermes3Llama38BPreviewFree] = new ChatModelMetadata
        {
            Id = "nousresearch/deephermes-3-llama-3-8b-preview:free",
            ContextLength = 131072,
            PricePerInputTokenInUsd = 0,
            PricePerOutputTokenInUsd = 0,
        },

        
        [OpenRouterModelIds.OpenAiGpt45Preview] = new ChatModelMetadata
        {
            Id = "openai/gpt-4.5-preview",
            ContextLength = 128000,
            PricePerInputTokenInUsd = 7.5E-11,
            PricePerOutputTokenInUsd = 1.5E-10,
        },

        
        [OpenRouterModelIds.GoogleGemini20FlashLite] = new ChatModelMetadata
        {
            Id = "google/gemini-2.0-flash-lite-001",
            ContextLength = 1048576,
            PricePerInputTokenInUsd = 7.5E-14,
            PricePerOutputTokenInUsd = 3E-13,
        },

        
        [OpenRouterModelIds.AnthropicClaude37SonnetSelfModerated] = new ChatModelMetadata
        {
            Id = "anthropic/claude-3.7-sonnet:beta",
            ContextLength = 200000,
            PricePerInputTokenInUsd = 3E-12,
            PricePerOutputTokenInUsd = 1.5E-11,
        },

        
        [OpenRouterModelIds.AnthropicClaude37Sonnet] = new ChatModelMetadata
        {
            Id = "anthropic/claude-3.7-sonnet",
            ContextLength = 200000,
            PricePerInputTokenInUsd = 3E-12,
            PricePerOutputTokenInUsd = 1.5E-11,
        },

        
        [OpenRouterModelIds.AnthropicClaude37SonnetThinking] = new ChatModelMetadata
        {
            Id = "anthropic/claude-3.7-sonnet:thinking",
            ContextLength = 200000,
            PricePerInputTokenInUsd = 3E-12,
            PricePerOutputTokenInUsd = 1.5E-11,
        },

        
        [OpenRouterModelIds.PerplexityR11776] = new ChatModelMetadata
        {
            Id = "perplexity/r1-1776",
            ContextLength = 128000,
            PricePerInputTokenInUsd = 2E-12,
            PricePerOutputTokenInUsd = 8E-12,
        },

        
        [OpenRouterModelIds.MistralSaba] = new ChatModelMetadata
        {
            Id = "mistralai/mistral-saba",
            ContextLength = 32000,
            PricePerInputTokenInUsd = 1.9999999999999998E-13,
            PricePerOutputTokenInUsd = 6E-13,
        },

        
        [OpenRouterModelIds.Dolphin30R1Mistral24BFree] = new ChatModelMetadata
        {
            Id = "cognitivecomputations/dolphin3.0-r1-mistral-24b:free",
            ContextLength = 32768,
            PricePerInputTokenInUsd = 0,
            PricePerOutputTokenInUsd = 0,
        },

        
        [OpenRouterModelIds.Dolphin30Mistral24BFree] = new ChatModelMetadata
        {
            Id = "cognitivecomputations/dolphin3.0-mistral-24b:free",
            ContextLength = 32768,
            PricePerInputTokenInUsd = 0,
            PricePerOutputTokenInUsd = 0,
        },

        
        [OpenRouterModelIds.LlamaGuard38B] = new ChatModelMetadata
        {
            Id = "meta-llama/llama-guard-3-8b",
            ContextLength = 8192,
            PricePerInputTokenInUsd = 1.9999999999999998E-13,
            PricePerOutputTokenInUsd = 1.9999999999999998E-13,
        },

        
        [OpenRouterModelIds.OpenAiO3MiniHigh] = new ChatModelMetadata
        {
            Id = "openai/o3-mini-high",
            ContextLength = 200000,
            PricePerInputTokenInUsd = 1.1E-12,
            PricePerOutputTokenInUsd = 4.4E-12,
        },

        
        [OpenRouterModelIds.Llama31Tulu3405B] = new ChatModelMetadata
        {
            Id = "allenai/llama-3.1-tulu-3-405b",
            ContextLength = 16000,
            PricePerInputTokenInUsd = 5.0000000000000005E-12,
            PricePerOutputTokenInUsd = 1.0000000000000001E-11,
        },

        
        [OpenRouterModelIds.DeepseekR1DistillLlama8B] = new ChatModelMetadata
        {
            Id = "deepseek/deepseek-r1-distill-llama-8b",
            ContextLength = 32000,
            PricePerInputTokenInUsd = 4E-14,
            PricePerOutputTokenInUsd = 4E-14,
        },

        
        [OpenRouterModelIds.GoogleGeminiFlash20] = new ChatModelMetadata
        {
            Id = "google/gemini-2.0-flash-001",
            ContextLength = 1000000,
            PricePerInputTokenInUsd = 9.999999999999999E-14,
            PricePerOutputTokenInUsd = 3.9999999999999996E-13,
        },

        
        [OpenRouterModelIds.GoogleGeminiFlashLite20PreviewFree] = new ChatModelMetadata
        {
            Id = "google/gemini-2.0-flash-lite-preview-02-05:free",
            ContextLength = 1000000,
            PricePerInputTokenInUsd = 0,
            PricePerOutputTokenInUsd = 0,
        },

        
        [OpenRouterModelIds.GoogleGeminiPro20ExperimentalFree] = new ChatModelMetadata
        {
            Id = "google/gemini-2.0-pro-exp-02-05:free",
            ContextLength = 2000000,
            PricePerInputTokenInUsd = 0,
            PricePerOutputTokenInUsd = 0,
        },

        
        [OpenRouterModelIds.QwenQwenVlPlusFree] = new ChatModelMetadata
        {
            Id = "qwen/qwen-vl-plus:free",
            ContextLength = 7500,
            PricePerInputTokenInUsd = 0,
            PricePerOutputTokenInUsd = 0,
        },

        
        [OpenRouterModelIds.AionlabsAion10] = new ChatModelMetadata
        {
            Id = "aion-labs/aion-1.0",
            ContextLength = 32768,
            PricePerInputTokenInUsd = 4E-12,
            PricePerOutputTokenInUsd = 8E-12,
        },

        
        [OpenRouterModelIds.AionlabsAion10Mini] = new ChatModelMetadata
        {
            Id = "aion-labs/aion-1.0-mini",
            ContextLength = 32768,
            PricePerInputTokenInUsd = 6.999999999999999E-13,
            PricePerOutputTokenInUsd = 1.3999999999999999E-12,
        },

        
        [OpenRouterModelIds.AionlabsAionRp108B] = new ChatModelMetadata
        {
            Id = "aion-labs/aion-rp-llama-3.1-8b",
            ContextLength = 32768,
            PricePerInputTokenInUsd = 1.9999999999999998E-13,
            PricePerOutputTokenInUsd = 1.9999999999999998E-13,
        },

        
        [OpenRouterModelIds.QwenQwenTurbo] = new ChatModelMetadata
        {
            Id = "qwen/qwen-turbo",
            ContextLength = 1000000,
            PricePerInputTokenInUsd = 4.9999999999999995E-14,
            PricePerOutputTokenInUsd = 1.9999999999999998E-13,
        },

        
        [OpenRouterModelIds.QwenQwen25Vl72BInstructFree] = new ChatModelMetadata
        {
            Id = "qwen/qwen2.5-vl-72b-instruct:free",
            ContextLength = 131072,
            PricePerInputTokenInUsd = 0,
            PricePerOutputTokenInUsd = 0,
        },

        
        [OpenRouterModelIds.QwenQwen25Vl72BInstruct] = new ChatModelMetadata
        {
            Id = "qwen/qwen2.5-vl-72b-instruct",
            ContextLength = 32000,
            PricePerInputTokenInUsd = 6.999999999999999E-13,
            PricePerOutputTokenInUsd = 6.999999999999999E-13,
        },

        
        [OpenRouterModelIds.QwenQwenPlus] = new ChatModelMetadata
        {
            Id = "qwen/qwen-plus",
            ContextLength = 131072,
            PricePerInputTokenInUsd = 3.9999999999999996E-13,
            PricePerOutputTokenInUsd = 1.2E-12,
        },

        
        [OpenRouterModelIds.QwenQwenMax] = new ChatModelMetadata
        {
            Id = "qwen/qwen-max",
            ContextLength = 32768,
            PricePerInputTokenInUsd = 1.5999999999999998E-12,
            PricePerOutputTokenInUsd = 6.399999999999999E-12,
        },

        
        [OpenRouterModelIds.OpenAiO3Mini] = new ChatModelMetadata
        {
            Id = "openai/o3-mini",
            ContextLength = 200000,
            PricePerInputTokenInUsd = 1.1E-12,
            PricePerOutputTokenInUsd = 4.4E-12,
        },

        
        [OpenRouterModelIds.DeepseekR1DistillQwen15B] = new ChatModelMetadata
        {
            Id = "deepseek/deepseek-r1-distill-qwen-1.5b",
            ContextLength = 131072,
            PricePerInputTokenInUsd = 1.8E-13,
            PricePerOutputTokenInUsd = 1.8E-13,
        },

        
        [OpenRouterModelIds.MistralMistralSmall3Free] = new ChatModelMetadata
        {
            Id = "mistralai/mistral-small-24b-instruct-2501:free",
            ContextLength = 32000,
            PricePerInputTokenInUsd = 0,
            PricePerOutputTokenInUsd = 0,
        },

        
        [OpenRouterModelIds.MistralMistralSmall3] = new ChatModelMetadata
        {
            Id = "mistralai/mistral-small-24b-instruct-2501",
            ContextLength = 32768,
            PricePerInputTokenInUsd = 7E-14,
            PricePerOutputTokenInUsd = 1.4E-13,
        },

        
        [OpenRouterModelIds.DeepseekR1DistillQwen32B] = new ChatModelMetadata
        {
            Id = "deepseek/deepseek-r1-distill-qwen-32b",
            ContextLength = 131072,
            PricePerInputTokenInUsd = 1.2E-13,
            PricePerOutputTokenInUsd = 1.8E-13,
        },

        
        [OpenRouterModelIds.DeepseekR1DistillQwen14B] = new ChatModelMetadata
        {
            Id = "deepseek/deepseek-r1-distill-qwen-14b",
            ContextLength = 131072,
            PricePerInputTokenInUsd = 1.5999999999999998E-12,
            PricePerOutputTokenInUsd = 1.5999999999999998E-12,
        },

        
        [OpenRouterModelIds.PerplexitySonarReasoning] = new ChatModelMetadata
        {
            Id = "perplexity/sonar-reasoning",
            ContextLength = 127000,
            PricePerInputTokenInUsd = 1E-12,
            PricePerOutputTokenInUsd = 5.0000000000000005E-12,
        },

        
        [OpenRouterModelIds.PerplexitySonar] = new ChatModelMetadata
        {
            Id = "perplexity/sonar",
            ContextLength = 127072,
            PricePerInputTokenInUsd = 1E-12,
            PricePerOutputTokenInUsd = 1E-12,
        },

        
        [OpenRouterModelIds.LiquidLfm7B] = new ChatModelMetadata
        {
            Id = "liquid/lfm-7b",
            ContextLength = 32768,
            PricePerInputTokenInUsd = 1E-14,
            PricePerOutputTokenInUsd = 1E-14,
        },

        
        [OpenRouterModelIds.LiquidLfm3B] = new ChatModelMetadata
        {
            Id = "liquid/lfm-3b",
            ContextLength = 32768,
            PricePerInputTokenInUsd = 2E-14,
            PricePerOutputTokenInUsd = 2E-14,
        },

        
        [OpenRouterModelIds.DeepseekR1DistillLlama70BFree] = new ChatModelMetadata
        {
            Id = "deepseek/deepseek-r1-distill-llama-70b:free",
            ContextLength = 128000,
            PricePerInputTokenInUsd = 0,
            PricePerOutputTokenInUsd = 0,
        },

        
        [OpenRouterModelIds.DeepseekR1DistillLlama70B] = new ChatModelMetadata
        {
            Id = "deepseek/deepseek-r1-distill-llama-70b",
            ContextLength = 131072,
            PricePerInputTokenInUsd = 2.3E-13,
            PricePerOutputTokenInUsd = 6.9E-13,
        },

        
        [OpenRouterModelIds.GoogleGemini20FlashThinkingExperimental0121Free] = new ChatModelMetadata
        {
            Id = "google/gemini-2.0-flash-thinking-exp:free",
            ContextLength = 1048576,
            PricePerInputTokenInUsd = 0,
            PricePerOutputTokenInUsd = 0,
        },

        
        [OpenRouterModelIds.DeepseekR1Free] = new ChatModelMetadata
        {
            Id = "deepseek/deepseek-r1:free",
            ContextLength = 163840,
            PricePerInputTokenInUsd = 0,
            PricePerOutputTokenInUsd = 0,
        },

        
        [OpenRouterModelIds.DeepseekR1] = new ChatModelMetadata
        {
            Id = "deepseek/deepseek-r1",
            ContextLength = 64000,
            PricePerInputTokenInUsd = 5.5E-13,
            PricePerOutputTokenInUsd = 2.19E-12,
        },

        
        [OpenRouterModelIds.RogueRose103Bv02Free] = new ChatModelMetadata
        {
            Id = "sophosympatheia/rogue-rose-103b-v0.2:free",
            ContextLength = 4096,
            PricePerInputTokenInUsd = 0,
            PricePerOutputTokenInUsd = 0,
        },

        
        [OpenRouterModelIds.MinimaxMinimax01] = new ChatModelMetadata
        {
            Id = "minimax/minimax-01",
            ContextLength = 1000192,
            PricePerInputTokenInUsd = 1.9999999999999998E-13,
            PricePerOutputTokenInUsd = 1.1E-12,
        },

        
        [OpenRouterModelIds.MistralCodestral2501] = new ChatModelMetadata
        {
            Id = "mistralai/codestral-2501",
            ContextLength = 256000,
            PricePerInputTokenInUsd = 3E-13,
            PricePerOutputTokenInUsd = 9E-13,
        },

        
        [OpenRouterModelIds.MicrosoftPhi4] = new ChatModelMetadata
        {
            Id = "microsoft/phi-4",
            ContextLength = 16384,
            PricePerInputTokenInUsd = 7E-14,
            PricePerOutputTokenInUsd = 1.4E-13,
        },

        
        [OpenRouterModelIds.Sao10kLlama3170BHanamiX1] = new ChatModelMetadata
        {
            Id = "sao10k/l3.1-70b-hanami-x1",
            ContextLength = 16000,
            PricePerInputTokenInUsd = 3E-12,
            PricePerOutputTokenInUsd = 3E-12,
        },

        
        [OpenRouterModelIds.DeepseekDeepseekV3Free] = new ChatModelMetadata
        {
            Id = "deepseek/deepseek-chat:free",
            ContextLength = 131072,
            PricePerInputTokenInUsd = 0,
            PricePerOutputTokenInUsd = 0,
        },

        
        [OpenRouterModelIds.DeepseekDeepseekV3] = new ChatModelMetadata
        {
            Id = "deepseek/deepseek-chat",
            ContextLength = 131072,
            PricePerInputTokenInUsd = 1.2500000000000001E-12,
            PricePerOutputTokenInUsd = 1.2500000000000001E-12,
        },

        
        [OpenRouterModelIds.QwenQvq72BPreview] = new ChatModelMetadata
        {
            Id = "qwen/qvq-72b-preview",
            ContextLength = 32000,
            PricePerInputTokenInUsd = 2.5E-13,
            PricePerOutputTokenInUsd = 5E-13,
        },

        
        [OpenRouterModelIds.GoogleGemini20FlashThinkingExperimentalFree] = new ChatModelMetadata
        {
            Id = "google/gemini-2.0-flash-thinking-exp-1219:free",
            ContextLength = 40000,
            PricePerInputTokenInUsd = 0,
            PricePerOutputTokenInUsd = 0,
        },

        
        [OpenRouterModelIds.Sao10kLlama33Euryale70B] = new ChatModelMetadata
        {
            Id = "sao10k/l3.3-euryale-70b",
            ContextLength = 131072,
            PricePerInputTokenInUsd = 6.999999999999999E-13,
            PricePerOutputTokenInUsd = 7.999999999999999E-13,
        },

        
        [OpenRouterModelIds.OpenAiO1] = new ChatModelMetadata
        {
            Id = "openai/o1",
            ContextLength = 200000,
            PricePerInputTokenInUsd = 1.5E-11,
            PricePerOutputTokenInUsd = 6E-11,
        },

        
        [OpenRouterModelIds.EvaLlama33370B] = new ChatModelMetadata
        {
            Id = "eva-unit-01/eva-llama-3.33-70b",
            ContextLength = 16384,
            PricePerInputTokenInUsd = 4E-12,
            PricePerOutputTokenInUsd = 6E-12,
        },

        
        [OpenRouterModelIds.XaiGrok2Vision1212] = new ChatModelMetadata
        {
            Id = "x-ai/grok-2-vision-1212",
            ContextLength = 32768,
            PricePerInputTokenInUsd = 2E-12,
            PricePerOutputTokenInUsd = 1.0000000000000001E-11,
        },

        
        [OpenRouterModelIds.XaiGrok21212] = new ChatModelMetadata
        {
            Id = "x-ai/grok-2-1212",
            ContextLength = 131072,
            PricePerInputTokenInUsd = 2E-12,
            PricePerOutputTokenInUsd = 1.0000000000000001E-11,
        },

        
        [OpenRouterModelIds.CohereCommandR7B122024] = new ChatModelMetadata
        {
            Id = "cohere/command-r7b-12-2024",
            ContextLength = 128000,
            PricePerInputTokenInUsd = 3.75E-14,
            PricePerOutputTokenInUsd = 1.5E-13,
        },

        
        [OpenRouterModelIds.GoogleGeminiFlash20ExperimentalFree] = new ChatModelMetadata
        {
            Id = "google/gemini-2.0-flash-exp:free",
            ContextLength = 1048576,
            PricePerInputTokenInUsd = 0,
            PricePerOutputTokenInUsd = 0,
        },

        
        [OpenRouterModelIds.GoogleGeminiExperimental1206Free] = new ChatModelMetadata
        {
            Id = "google/gemini-exp-1206:free",
            ContextLength = 2097152,
            PricePerInputTokenInUsd = 0,
            PricePerOutputTokenInUsd = 0,
        },

        
        [OpenRouterModelIds.MetaLlama3370BInstructFree] = new ChatModelMetadata
        {
            Id = "meta-llama/llama-3.3-70b-instruct:free",
            ContextLength = 131072,
            PricePerInputTokenInUsd = 0,
            PricePerOutputTokenInUsd = 0,
        },

        
        [OpenRouterModelIds.MetaLlama3370BInstruct] = new ChatModelMetadata
        {
            Id = "meta-llama/llama-3.3-70b-instruct",
            ContextLength = 131072,
            PricePerInputTokenInUsd = 1.2E-13,
            PricePerOutputTokenInUsd = 3E-13,
        },

        
        [OpenRouterModelIds.AmazonNovaLite10] = new ChatModelMetadata
        {
            Id = "amazon/nova-lite-v1",
            ContextLength = 300000,
            PricePerInputTokenInUsd = 6E-14,
            PricePerOutputTokenInUsd = 2.4E-13,
        },

        
        [OpenRouterModelIds.AmazonNovaMicro10] = new ChatModelMetadata
        {
            Id = "amazon/nova-micro-v1",
            ContextLength = 128000,
            PricePerInputTokenInUsd = 3.5E-14,
            PricePerOutputTokenInUsd = 1.4E-13,
        },

        
        [OpenRouterModelIds.AmazonNovaPro10] = new ChatModelMetadata
        {
            Id = "amazon/nova-pro-v1",
            ContextLength = 300000,
            PricePerInputTokenInUsd = 7.999999999999999E-13,
            PricePerOutputTokenInUsd = 3.1999999999999997E-12,
        },

        
        [OpenRouterModelIds.QwenQwq32BPreview] = new ChatModelMetadata
        {
            Id = "qwen/qwq-32b-preview",
            ContextLength = 32768,
            PricePerInputTokenInUsd = 1.2E-13,
            PricePerOutputTokenInUsd = 1.8E-13,
        },

        
        [OpenRouterModelIds.GoogleLearnlm15ProExperimentalFree] = new ChatModelMetadata
        {
            Id = "google/learnlm-1.5-pro-experimental:free",
            ContextLength = 40960,
            PricePerInputTokenInUsd = 0,
            PricePerOutputTokenInUsd = 0,
        },

        
        [OpenRouterModelIds.EvaQwen2572B] = new ChatModelMetadata
        {
            Id = "eva-unit-01/eva-qwen-2.5-72b",
            ContextLength = 32000,
            PricePerInputTokenInUsd = 6.999999999999999E-13,
            PricePerOutputTokenInUsd = 6.999999999999999E-13,
        },

        
        [OpenRouterModelIds.OpenAiGpt4O20241120] = new ChatModelMetadata
        {
            Id = "openai/gpt-4o-2024-11-20",
            ContextLength = 128000,
            PricePerInputTokenInUsd = 2.5000000000000003E-12,
            PricePerOutputTokenInUsd = 1.0000000000000001E-11,
        },

        
        [OpenRouterModelIds.MistralLarge2411] = new ChatModelMetadata
        {
            Id = "mistralai/mistral-large-2411",
            ContextLength = 128000,
            PricePerInputTokenInUsd = 2E-12,
            PricePerOutputTokenInUsd = 6E-12,
        },

        
        [OpenRouterModelIds.MistralLarge2407] = new ChatModelMetadata
        {
            Id = "mistralai/mistral-large-2407",
            ContextLength = 128000,
            PricePerInputTokenInUsd = 2E-12,
            PricePerOutputTokenInUsd = 6E-12,
        },

        
        [OpenRouterModelIds.MistralPixtralLarge2411] = new ChatModelMetadata
        {
            Id = "mistralai/pixtral-large-2411",
            ContextLength = 128000,
            PricePerInputTokenInUsd = 2E-12,
            PricePerOutputTokenInUsd = 6E-12,
        },

        
        [OpenRouterModelIds.XaiGrokVisionBeta] = new ChatModelMetadata
        {
            Id = "x-ai/grok-vision-beta",
            ContextLength = 8192,
            PricePerInputTokenInUsd = 5.0000000000000005E-12,
            PricePerOutputTokenInUsd = 1.5E-11,
        },

        
        [OpenRouterModelIds.InfermaticMistralNemoInferor12B] = new ChatModelMetadata
        {
            Id = "infermatic/mn-inferor-12b",
            ContextLength = 16384,
            PricePerInputTokenInUsd = 7.999999999999999E-13,
            PricePerOutputTokenInUsd = 1.2E-12,
        },

        
        [OpenRouterModelIds.Qwen25Coder32BInstructFree] = new ChatModelMetadata
        {
            Id = "qwen/qwen-2.5-coder-32b-instruct:free",
            ContextLength = 128000,
            PricePerInputTokenInUsd = 0,
            PricePerOutputTokenInUsd = 0,
        },

        
        [OpenRouterModelIds.Qwen25Coder32BInstruct] = new ChatModelMetadata
        {
            Id = "qwen/qwen-2.5-coder-32b-instruct",
            ContextLength = 33000,
            PricePerInputTokenInUsd = 7E-14,
            PricePerOutputTokenInUsd = 1.6E-13,
        },

        
        [OpenRouterModelIds.Sorcererlm8X22b] = new ChatModelMetadata
        {
            Id = "raifle/sorcererlm-8x22b",
            ContextLength = 16000,
            PricePerInputTokenInUsd = 4.5E-12,
            PricePerOutputTokenInUsd = 4.5E-12,
        },

        
        [OpenRouterModelIds.EvaQwen2532B] = new ChatModelMetadata
        {
            Id = "eva-unit-01/eva-qwen-2.5-32b",
            ContextLength = 16384,
            PricePerInputTokenInUsd = 2.6000000000000002E-12,
            PricePerOutputTokenInUsd = 3.4E-12,
        },

        
        [OpenRouterModelIds.Unslopnemo12B] = new ChatModelMetadata
        {
            Id = "thedrummer/unslopnemo-12b",
            ContextLength = 32000,
            PricePerInputTokenInUsd = 5E-13,
            PricePerOutputTokenInUsd = 5E-13,
        },

        
        [OpenRouterModelIds.AnthropicClaude35Haiku20241022SelfModerated] = new ChatModelMetadata
        {
            Id = "anthropic/claude-3.5-haiku-20241022:beta",
            ContextLength = 200000,
            PricePerInputTokenInUsd = 7.999999999999999E-13,
            PricePerOutputTokenInUsd = 4E-12,
        },

        
        [OpenRouterModelIds.AnthropicClaude35Haiku20241022] = new ChatModelMetadata
        {
            Id = "anthropic/claude-3.5-haiku-20241022",
            ContextLength = 200000,
            PricePerInputTokenInUsd = 7.999999999999999E-13,
            PricePerOutputTokenInUsd = 4E-12,
        },

        
        [OpenRouterModelIds.AnthropicClaude35HaikuSelfModerated] = new ChatModelMetadata
        {
            Id = "anthropic/claude-3.5-haiku:beta",
            ContextLength = 200000,
            PricePerInputTokenInUsd = 7.999999999999999E-13,
            PricePerOutputTokenInUsd = 4E-12,
        },

        
        [OpenRouterModelIds.AnthropicClaude35Haiku] = new ChatModelMetadata
        {
            Id = "anthropic/claude-3.5-haiku",
            ContextLength = 200000,
            PricePerInputTokenInUsd = 7.999999999999999E-13,
            PricePerOutputTokenInUsd = 4E-12,
        },

        
        [OpenRouterModelIds.NeversleepLumimaidV0270B] = new ChatModelMetadata
        {
            Id = "neversleep/llama-3.1-lumimaid-70b",
            ContextLength = 16384,
            PricePerInputTokenInUsd = 3.375E-12,
            PricePerOutputTokenInUsd = 4.5E-12,
        },

        
        [OpenRouterModelIds.MagnumV472B] = new ChatModelMetadata
        {
            Id = "anthracite-org/magnum-v4-72b",
            ContextLength = 16384,
            PricePerInputTokenInUsd = 1.875E-12,
            PricePerOutputTokenInUsd = 2.25E-12,
        },

        
        [OpenRouterModelIds.AnthropicClaude35SonnetSelfModerated] = new ChatModelMetadata
        {
            Id = "anthropic/claude-3.5-sonnet:beta",
            ContextLength = 200000,
            PricePerInputTokenInUsd = 3E-12,
            PricePerOutputTokenInUsd = 1.5E-11,
        },

        
        [OpenRouterModelIds.AnthropicClaude35Sonnet] = new ChatModelMetadata
        {
            Id = "anthropic/claude-3.5-sonnet",
            ContextLength = 200000,
            PricePerInputTokenInUsd = 3E-12,
            PricePerOutputTokenInUsd = 1.5E-11,
        },

        
        [OpenRouterModelIds.XaiGrokBeta] = new ChatModelMetadata
        {
            Id = "x-ai/grok-beta",
            ContextLength = 131072,
            PricePerInputTokenInUsd = 5.0000000000000005E-12,
            PricePerOutputTokenInUsd = 1.5E-11,
        },

        
        [OpenRouterModelIds.MistralMinistral8B] = new ChatModelMetadata
        {
            Id = "mistralai/ministral-8b",
            ContextLength = 128000,
            PricePerInputTokenInUsd = 9.999999999999999E-14,
            PricePerOutputTokenInUsd = 9.999999999999999E-14,
        },

        
        [OpenRouterModelIds.MistralMinistral3B] = new ChatModelMetadata
        {
            Id = "mistralai/ministral-3b",
            ContextLength = 128000,
            PricePerInputTokenInUsd = 4E-14,
            PricePerOutputTokenInUsd = 4E-14,
        },

        
        [OpenRouterModelIds.Qwen257BInstruct] = new ChatModelMetadata
        {
            Id = "qwen/qwen-2.5-7b-instruct",
            ContextLength = 32768,
            PricePerInputTokenInUsd = 2.4999999999999998E-14,
            PricePerOutputTokenInUsd = 4.9999999999999995E-14,
        },

        
        [OpenRouterModelIds.NvidiaLlama31Nemotron70BInstructFree] = new ChatModelMetadata
        {
            Id = "nvidia/llama-3.1-nemotron-70b-instruct:free",
            ContextLength = 131072,
            PricePerInputTokenInUsd = 0,
            PricePerOutputTokenInUsd = 0,
        },

        
        [OpenRouterModelIds.NvidiaLlama31Nemotron70BInstruct] = new ChatModelMetadata
        {
            Id = "nvidia/llama-3.1-nemotron-70b-instruct",
            ContextLength = 131000,
            PricePerInputTokenInUsd = 1.2E-13,
            PricePerOutputTokenInUsd = 3E-13,
        },

        
        [OpenRouterModelIds.InflectionInflection3Pi] = new ChatModelMetadata
        {
            Id = "inflection/inflection-3-pi",
            ContextLength = 8000,
            PricePerInputTokenInUsd = 2.5000000000000003E-12,
            PricePerOutputTokenInUsd = 1.0000000000000001E-11,
        },

        
        [OpenRouterModelIds.InflectionInflection3Productivity] = new ChatModelMetadata
        {
            Id = "inflection/inflection-3-productivity",
            ContextLength = 8000,
            PricePerInputTokenInUsd = 2.5000000000000003E-12,
            PricePerOutputTokenInUsd = 1.0000000000000001E-11,
        },

        
        [OpenRouterModelIds.GoogleGeminiFlash158B] = new ChatModelMetadata
        {
            Id = "google/gemini-flash-1.5-8b",
            ContextLength = 1000000,
            PricePerInputTokenInUsd = 3.75E-14,
            PricePerOutputTokenInUsd = 1.5E-13,
        },

        
        [OpenRouterModelIds.MagnumV272B] = new ChatModelMetadata
        {
            Id = "anthracite-org/magnum-v2-72b",
            ContextLength = 32768,
            PricePerInputTokenInUsd = 3E-12,
            PricePerOutputTokenInUsd = 3E-12,
        },

        
        [OpenRouterModelIds.LiquidLfm40BMoe] = new ChatModelMetadata
        {
            Id = "liquid/lfm-40b",
            ContextLength = 32768,
            PricePerInputTokenInUsd = 1.5E-13,
            PricePerOutputTokenInUsd = 1.5E-13,
        },

        
        [OpenRouterModelIds.Rocinante12B] = new ChatModelMetadata
        {
            Id = "thedrummer/rocinante-12b",
            ContextLength = 32768,
            PricePerInputTokenInUsd = 2.5E-13,
            PricePerOutputTokenInUsd = 5E-13,
        },

        
        [OpenRouterModelIds.MetaLlama323BInstruct] = new ChatModelMetadata
        {
            Id = "meta-llama/llama-3.2-3b-instruct",
            ContextLength = 131000,
            PricePerInputTokenInUsd = 1.5E-14,
            PricePerOutputTokenInUsd = 2.4999999999999998E-14,
        },

        
        [OpenRouterModelIds.MetaLlama321BInstructFree] = new ChatModelMetadata
        {
            Id = "meta-llama/llama-3.2-1b-instruct:free",
            ContextLength = 131072,
            PricePerInputTokenInUsd = 0,
            PricePerOutputTokenInUsd = 0,
        },

        
        [OpenRouterModelIds.MetaLlama321BInstruct] = new ChatModelMetadata
        {
            Id = "meta-llama/llama-3.2-1b-instruct",
            ContextLength = 131072,
            PricePerInputTokenInUsd = 1E-14,
            PricePerOutputTokenInUsd = 1E-14,
        },

        
        [OpenRouterModelIds.MetaLlama3290BVisionInstruct] = new ChatModelMetadata
        {
            Id = "meta-llama/llama-3.2-90b-vision-instruct",
            ContextLength = 4096,
            PricePerInputTokenInUsd = 7.999999999999999E-13,
            PricePerOutputTokenInUsd = 1.5999999999999998E-12,
        },

        
        [OpenRouterModelIds.MetaLlama3211BVisionInstructFree] = new ChatModelMetadata
        {
            Id = "meta-llama/llama-3.2-11b-vision-instruct:free",
            ContextLength = 131072,
            PricePerInputTokenInUsd = 0,
            PricePerOutputTokenInUsd = 0,
        },

        
        [OpenRouterModelIds.MetaLlama3211BVisionInstruct] = new ChatModelMetadata
        {
            Id = "meta-llama/llama-3.2-11b-vision-instruct",
            ContextLength = 16384,
            PricePerInputTokenInUsd = 5.5000000000000005E-14,
            PricePerOutputTokenInUsd = 5.5000000000000005E-14,
        },

        
        [OpenRouterModelIds.Qwen2572BInstruct] = new ChatModelMetadata
        {
            Id = "qwen/qwen-2.5-72b-instruct",
            ContextLength = 128000,
            PricePerInputTokenInUsd = 1.3E-13,
            PricePerOutputTokenInUsd = 3.9999999999999996E-13,
        },

        
        [OpenRouterModelIds.Qwen2Vl72BInstruct] = new ChatModelMetadata
        {
            Id = "qwen/qwen-2-vl-72b-instruct",
            ContextLength = 4096,
            PricePerInputTokenInUsd = 3.9999999999999996E-13,
            PricePerOutputTokenInUsd = 3.9999999999999996E-13,
        },

        
        [OpenRouterModelIds.NeversleepLumimaidV028B] = new ChatModelMetadata
        {
            Id = "neversleep/llama-3.1-lumimaid-8b",
            ContextLength = 32768,
            PricePerInputTokenInUsd = 1.875E-13,
            PricePerOutputTokenInUsd = 1.125E-12,
        },

        
        [OpenRouterModelIds.OpenAiO1Mini20240912] = new ChatModelMetadata
        {
            Id = "openai/o1-mini-2024-09-12",
            ContextLength = 128000,
            PricePerInputTokenInUsd = 1.1E-12,
            PricePerOutputTokenInUsd = 4.4E-12,
        },

        
        [OpenRouterModelIds.OpenAiO1Preview] = new ChatModelMetadata
        {
            Id = "openai/o1-preview",
            ContextLength = 128000,
            PricePerInputTokenInUsd = 1.5E-11,
            PricePerOutputTokenInUsd = 6E-11,
        },

        
        [OpenRouterModelIds.OpenAiO1Preview20240912] = new ChatModelMetadata
        {
            Id = "openai/o1-preview-2024-09-12",
            ContextLength = 128000,
            PricePerInputTokenInUsd = 1.5E-11,
            PricePerOutputTokenInUsd = 6E-11,
        },

        
        [OpenRouterModelIds.OpenAiO1Mini] = new ChatModelMetadata
        {
            Id = "openai/o1-mini",
            ContextLength = 128000,
            PricePerInputTokenInUsd = 1.1E-12,
            PricePerOutputTokenInUsd = 4.4E-12,
        },

        
        [OpenRouterModelIds.MistralPixtral12B] = new ChatModelMetadata
        {
            Id = "mistralai/pixtral-12b",
            ContextLength = 4096,
            PricePerInputTokenInUsd = 9.999999999999999E-14,
            PricePerOutputTokenInUsd = 9.999999999999999E-14,
        },

        
        [OpenRouterModelIds.CohereCommandR082024] = new ChatModelMetadata
        {
            Id = "cohere/command-r-08-2024",
            ContextLength = 128000,
            PricePerInputTokenInUsd = 1.4250000000000002E-13,
            PricePerOutputTokenInUsd = 5.700000000000001E-13,
        },

        
        [OpenRouterModelIds.CohereCommandRPlus082024] = new ChatModelMetadata
        {
            Id = "cohere/command-r-plus-08-2024",
            ContextLength = 128000,
            PricePerInputTokenInUsd = 2.3750000000000003E-12,
            PricePerOutputTokenInUsd = 9.500000000000001E-12,
        },

        
        [OpenRouterModelIds.Qwen2Vl7BInstruct] = new ChatModelMetadata
        {
            Id = "qwen/qwen-2-vl-7b-instruct",
            ContextLength = 4096,
            PricePerInputTokenInUsd = 9.999999999999999E-14,
            PricePerOutputTokenInUsd = 9.999999999999999E-14,
        },

        
        [OpenRouterModelIds.Sao10kLlama31Euryale70BV22] = new ChatModelMetadata
        {
            Id = "sao10k/l3.1-euryale-70b",
            ContextLength = 131072,
            PricePerInputTokenInUsd = 6.999999999999999E-13,
            PricePerOutputTokenInUsd = 7.999999999999999E-13,
        },

        
        [OpenRouterModelIds.GoogleGeminiFlash158BExperimental] = new ChatModelMetadata
        {
            Id = "google/gemini-flash-1.5-8b-exp",
            ContextLength = 1000000,
            PricePerInputTokenInUsd = 0,
            PricePerOutputTokenInUsd = 0,
        },

        
        [OpenRouterModelIds.Ai21Jamba15Large] = new ChatModelMetadata
        {
            Id = "ai21/jamba-1-5-large",
            ContextLength = 256000,
            PricePerInputTokenInUsd = 2E-12,
            PricePerOutputTokenInUsd = 8E-12,
        },

        
        [OpenRouterModelIds.Ai21Jamba15Mini] = new ChatModelMetadata
        {
            Id = "ai21/jamba-1-5-mini",
            ContextLength = 256000,
            PricePerInputTokenInUsd = 1.9999999999999998E-13,
            PricePerOutputTokenInUsd = 3.9999999999999996E-13,
        },

        
        [OpenRouterModelIds.MicrosoftPhi35Mini128KInstruct] = new ChatModelMetadata
        {
            Id = "microsoft/phi-3.5-mini-128k-instruct",
            ContextLength = 128000,
            PricePerInputTokenInUsd = 9.999999999999999E-14,
            PricePerOutputTokenInUsd = 9.999999999999999E-14,
        },

        
        [OpenRouterModelIds.NousHermes370BInstruct] = new ChatModelMetadata
        {
            Id = "nousresearch/hermes-3-llama-3.1-70b",
            ContextLength = 131000,
            PricePerInputTokenInUsd = 1.2E-13,
            PricePerOutputTokenInUsd = 3E-13,
        },

        
        [OpenRouterModelIds.NousHermes3405BInstruct] = new ChatModelMetadata
        {
            Id = "nousresearch/hermes-3-llama-3.1-405b",
            ContextLength = 131000,
            PricePerInputTokenInUsd = 7.999999999999999E-13,
            PricePerOutputTokenInUsd = 7.999999999999999E-13,
        },

        
        [OpenRouterModelIds.OpenAiChatgpt4O] = new ChatModelMetadata
        {
            Id = "openai/chatgpt-4o-latest",
            ContextLength = 128000,
            PricePerInputTokenInUsd = 5.0000000000000005E-12,
            PricePerOutputTokenInUsd = 1.5E-11,
        },

        
        [OpenRouterModelIds.Sao10kLlama38BLunaris] = new ChatModelMetadata
        {
            Id = "sao10k/l3-lunaris-8b",
            ContextLength = 8192,
            PricePerInputTokenInUsd = 3E-14,
            PricePerOutputTokenInUsd = 6E-14,
        },

        
        [OpenRouterModelIds.AetherwiingStarcannon12B] = new ChatModelMetadata
        {
            Id = "aetherwiing/mn-starcannon-12b",
            ContextLength = 16384,
            PricePerInputTokenInUsd = 7.999999999999999E-13,
            PricePerOutputTokenInUsd = 1.2E-12,
        },

        
        [OpenRouterModelIds.OpenAiGpt4O20240806] = new ChatModelMetadata
        {
            Id = "openai/gpt-4o-2024-08-06",
            ContextLength = 128000,
            PricePerInputTokenInUsd = 2.5000000000000003E-12,
            PricePerOutputTokenInUsd = 1.0000000000000001E-11,
        },

        
        [OpenRouterModelIds.MetaLlama31405BBase] = new ChatModelMetadata
        {
            Id = "meta-llama/llama-3.1-405b",
            ContextLength = 32768,
            PricePerInputTokenInUsd = 2E-12,
            PricePerOutputTokenInUsd = 2E-12,
        },

        
        [OpenRouterModelIds.MistralNemo12BCeleste] = new ChatModelMetadata
        {
            Id = "nothingiisreal/mn-celeste-12b",
            ContextLength = 16384,
            PricePerInputTokenInUsd = 7.999999999999999E-13,
            PricePerOutputTokenInUsd = 1.2E-12,
        },

        
        [OpenRouterModelIds.PerplexityLlama31Sonar8B] = new ChatModelMetadata
        {
            Id = "perplexity/llama-3.1-sonar-small-128k-chat",
            ContextLength = 131072,
            PricePerInputTokenInUsd = 1.9999999999999998E-13,
            PricePerOutputTokenInUsd = 1.9999999999999998E-13,
        },

        
        [OpenRouterModelIds.PerplexityLlama31Sonar70B] = new ChatModelMetadata
        {
            Id = "perplexity/llama-3.1-sonar-large-128k-chat",
            ContextLength = 131072,
            PricePerInputTokenInUsd = 1E-12,
            PricePerOutputTokenInUsd = 1E-12,
        },

        
        [OpenRouterModelIds.PerplexityLlama31Sonar70BOnline] = new ChatModelMetadata
        {
            Id = "perplexity/llama-3.1-sonar-large-128k-online",
            ContextLength = 127072,
            PricePerInputTokenInUsd = 1E-12,
            PricePerOutputTokenInUsd = 1E-12,
        },

        
        [OpenRouterModelIds.PerplexityLlama31Sonar8BOnline] = new ChatModelMetadata
        {
            Id = "perplexity/llama-3.1-sonar-small-128k-online",
            ContextLength = 127072,
            PricePerInputTokenInUsd = 1.9999999999999998E-13,
            PricePerOutputTokenInUsd = 1.9999999999999998E-13,
        },

        
        [OpenRouterModelIds.MetaLlama31405BInstruct] = new ChatModelMetadata
        {
            Id = "meta-llama/llama-3.1-405b-instruct",
            ContextLength = 32768,
            PricePerInputTokenInUsd = 7.999999999999999E-13,
            PricePerOutputTokenInUsd = 7.999999999999999E-13,
        },

        
        [OpenRouterModelIds.MetaLlama318BInstructFree] = new ChatModelMetadata
        {
            Id = "meta-llama/llama-3.1-8b-instruct:free",
            ContextLength = 131072,
            PricePerInputTokenInUsd = 0,
            PricePerOutputTokenInUsd = 0,
        },

        
        [OpenRouterModelIds.MetaLlama318BInstruct] = new ChatModelMetadata
        {
            Id = "meta-llama/llama-3.1-8b-instruct",
            ContextLength = 131072,
            PricePerInputTokenInUsd = 2E-14,
            PricePerOutputTokenInUsd = 4.9999999999999995E-14,
        },

        
        [OpenRouterModelIds.MetaLlama3170BInstruct] = new ChatModelMetadata
        {
            Id = "meta-llama/llama-3.1-70b-instruct",
            ContextLength = 131072,
            PricePerInputTokenInUsd = 1.2E-13,
            PricePerOutputTokenInUsd = 3E-13,
        },

        
        [OpenRouterModelIds.MistralMistralNemoFree] = new ChatModelMetadata
        {
            Id = "mistralai/mistral-nemo:free",
            ContextLength = 128000,
            PricePerInputTokenInUsd = 0,
            PricePerOutputTokenInUsd = 0,
        },

        
        [OpenRouterModelIds.MistralMistralNemo] = new ChatModelMetadata
        {
            Id = "mistralai/mistral-nemo",
            ContextLength = 131072,
            PricePerInputTokenInUsd = 3.5E-14,
            PricePerOutputTokenInUsd = 8E-14,
        },

        
        [OpenRouterModelIds.MistralCodestralMamba] = new ChatModelMetadata
        {
            Id = "mistralai/codestral-mamba",
            ContextLength = 256000,
            PricePerInputTokenInUsd = 2.5E-13,
            PricePerOutputTokenInUsd = 2.5E-13,
        },

        
        [OpenRouterModelIds.OpenAiGpt4OMini] = new ChatModelMetadata
        {
            Id = "openai/gpt-4o-mini",
            ContextLength = 128000,
            PricePerInputTokenInUsd = 1.5E-13,
            PricePerOutputTokenInUsd = 6E-13,
        },

        
        [OpenRouterModelIds.OpenAiGpt4OMini20240718] = new ChatModelMetadata
        {
            Id = "openai/gpt-4o-mini-2024-07-18",
            ContextLength = 128000,
            PricePerInputTokenInUsd = 1.5E-13,
            PricePerOutputTokenInUsd = 6E-13,
        },

        
        [OpenRouterModelIds.Qwen27BInstructFree] = new ChatModelMetadata
        {
            Id = "qwen/qwen-2-7b-instruct:free",
            ContextLength = 8192,
            PricePerInputTokenInUsd = 0,
            PricePerOutputTokenInUsd = 0,
        },

        
        [OpenRouterModelIds.Qwen27BInstruct] = new ChatModelMetadata
        {
            Id = "qwen/qwen-2-7b-instruct",
            ContextLength = 32768,
            PricePerInputTokenInUsd = 5.4000000000000003E-14,
            PricePerOutputTokenInUsd = 5.4000000000000003E-14,
        },

        
        [OpenRouterModelIds.GoogleGemma227B] = new ChatModelMetadata
        {
            Id = "google/gemma-2-27b-it",
            ContextLength = 8192,
            PricePerInputTokenInUsd = 2.7E-13,
            PricePerOutputTokenInUsd = 2.7E-13,
        },

        
        [OpenRouterModelIds.Magnum72B] = new ChatModelMetadata
        {
            Id = "alpindale/magnum-72b",
            ContextLength = 16384,
            PricePerInputTokenInUsd = 1.875E-12,
            PricePerOutputTokenInUsd = 2.25E-12,
        },

        
        [OpenRouterModelIds.GoogleGemma29BFree] = new ChatModelMetadata
        {
            Id = "google/gemma-2-9b-it:free",
            ContextLength = 8192,
            PricePerInputTokenInUsd = 0,
            PricePerOutputTokenInUsd = 0,
        },

        
        [OpenRouterModelIds.GoogleGemma29B] = new ChatModelMetadata
        {
            Id = "google/gemma-2-9b-it",
            ContextLength = 8192,
            PricePerInputTokenInUsd = 3E-14,
            PricePerOutputTokenInUsd = 6E-14,
        },

        
        [OpenRouterModelIds._01AiYiLarge] = new ChatModelMetadata
        {
            Id = "01-ai/yi-large",
            ContextLength = 32768,
            PricePerInputTokenInUsd = 3E-12,
            PricePerOutputTokenInUsd = 3E-12,
        },

        
        [OpenRouterModelIds.Ai21JambaInstruct] = new ChatModelMetadata
        {
            Id = "ai21/jamba-instruct",
            ContextLength = 256000,
            PricePerInputTokenInUsd = 5E-13,
            PricePerOutputTokenInUsd = 6.999999999999999E-13,
        },

        
        [OpenRouterModelIds.AnthropicClaude35Sonnet20240620SelfModerated] = new ChatModelMetadata
        {
            Id = "anthropic/claude-3.5-sonnet-20240620:beta",
            ContextLength = 200000,
            PricePerInputTokenInUsd = 3E-12,
            PricePerOutputTokenInUsd = 1.5E-11,
        },

        
        [OpenRouterModelIds.AnthropicClaude35Sonnet20240620] = new ChatModelMetadata
        {
            Id = "anthropic/claude-3.5-sonnet-20240620",
            ContextLength = 200000,
            PricePerInputTokenInUsd = 3E-12,
            PricePerOutputTokenInUsd = 1.5E-11,
        },

        
        [OpenRouterModelIds.Sao10kLlama3Euryale70BV21] = new ChatModelMetadata
        {
            Id = "sao10k/l3-euryale-70b",
            ContextLength = 8192,
            PricePerInputTokenInUsd = 6.999999999999999E-13,
            PricePerOutputTokenInUsd = 7.999999999999999E-13,
        },

        
        [OpenRouterModelIds.Dolphin292Mixtral8X22b] = new ChatModelMetadata
        {
            Id = "cognitivecomputations/dolphin-mixtral-8x22b",
            ContextLength = 16000,
            PricePerInputTokenInUsd = 9E-13,
            PricePerOutputTokenInUsd = 9E-13,
        },

        
        [OpenRouterModelIds.Qwen272BInstruct] = new ChatModelMetadata
        {
            Id = "qwen/qwen-2-72b-instruct",
            ContextLength = 32768,
            PricePerInputTokenInUsd = 9E-13,
            PricePerOutputTokenInUsd = 9E-13,
        },

        
        [OpenRouterModelIds.MistralMistral7BInstructFree] = new ChatModelMetadata
        {
            Id = "mistralai/mistral-7b-instruct:free",
            ContextLength = 8192,
            PricePerInputTokenInUsd = 0,
            PricePerOutputTokenInUsd = 0,
        },

        
        [OpenRouterModelIds.MistralMistral7BInstruct] = new ChatModelMetadata
        {
            Id = "mistralai/mistral-7b-instruct",
            ContextLength = 32768,
            PricePerInputTokenInUsd = 3E-14,
            PricePerOutputTokenInUsd = 5.5000000000000005E-14,
        },

        
        [OpenRouterModelIds.MistralMistral7BInstructV03] = new ChatModelMetadata
        {
            Id = "mistralai/mistral-7b-instruct-v0.3",
            ContextLength = 32768,
            PricePerInputTokenInUsd = 3E-14,
            PricePerOutputTokenInUsd = 5.5000000000000005E-14,
        },

        
        [OpenRouterModelIds.NousresearchHermes2ProLlama38B] = new ChatModelMetadata
        {
            Id = "nousresearch/hermes-2-pro-llama-3-8b",
            ContextLength = 131000,
            PricePerInputTokenInUsd = 2.4999999999999998E-14,
            PricePerOutputTokenInUsd = 4E-14,
        },

        
        [OpenRouterModelIds.MicrosoftPhi3Mini128KInstructFree] = new ChatModelMetadata
        {
            Id = "microsoft/phi-3-mini-128k-instruct:free",
            ContextLength = 8192,
            PricePerInputTokenInUsd = 0,
            PricePerOutputTokenInUsd = 0,
        },

        
        [OpenRouterModelIds.MicrosoftPhi3Mini128KInstruct] = new ChatModelMetadata
        {
            Id = "microsoft/phi-3-mini-128k-instruct",
            ContextLength = 128000,
            PricePerInputTokenInUsd = 9.999999999999999E-14,
            PricePerOutputTokenInUsd = 9.999999999999999E-14,
        },

        
        [OpenRouterModelIds.MicrosoftPhi3Medium128KInstructFree] = new ChatModelMetadata
        {
            Id = "microsoft/phi-3-medium-128k-instruct:free",
            ContextLength = 8192,
            PricePerInputTokenInUsd = 0,
            PricePerOutputTokenInUsd = 0,
        },

        
        [OpenRouterModelIds.MicrosoftPhi3Medium128KInstruct] = new ChatModelMetadata
        {
            Id = "microsoft/phi-3-medium-128k-instruct",
            ContextLength = 128000,
            PricePerInputTokenInUsd = 1E-12,
            PricePerOutputTokenInUsd = 1E-12,
        },

        
        [OpenRouterModelIds.NeversleepLlama3Lumimaid70B] = new ChatModelMetadata
        {
            Id = "neversleep/llama-3-lumimaid-70b",
            ContextLength = 8192,
            PricePerInputTokenInUsd = 3.375E-12,
            PricePerOutputTokenInUsd = 4.5E-12,
        },

        
        [OpenRouterModelIds.GoogleGeminiFlash15] = new ChatModelMetadata
        {
            Id = "google/gemini-flash-1.5",
            ContextLength = 1000000,
            PricePerInputTokenInUsd = 7.5E-14,
            PricePerOutputTokenInUsd = 3E-13,
        },

        
        [OpenRouterModelIds.DeepseekV25] = new ChatModelMetadata
        {
            Id = "deepseek/deepseek-chat-v2.5",
            ContextLength = 8192,
            PricePerInputTokenInUsd = 2E-12,
            PricePerOutputTokenInUsd = 2E-12,
        },

        
        [OpenRouterModelIds.OpenAiGpt4O20240513] = new ChatModelMetadata
        {
            Id = "openai/gpt-4o-2024-05-13",
            ContextLength = 128000,
            PricePerInputTokenInUsd = 5.0000000000000005E-12,
            PricePerOutputTokenInUsd = 1.5E-11,
        },

        
        [OpenRouterModelIds.MetaLlama38BBase] = new ChatModelMetadata
        {
            Id = "meta-llama/llama-3-8b",
            ContextLength = 8192,
            PricePerInputTokenInUsd = 4.9999999999999995E-14,
            PricePerOutputTokenInUsd = 8E-14,
        },

        
        [OpenRouterModelIds.MetaLlama370BBase] = new ChatModelMetadata
        {
            Id = "meta-llama/llama-3-70b",
            ContextLength = 8192,
            PricePerInputTokenInUsd = 5.9E-13,
            PricePerOutputTokenInUsd = 7.9E-13,
        },

        
        [OpenRouterModelIds.MetaLlamaguard28B] = new ChatModelMetadata
        {
            Id = "meta-llama/llama-guard-2-8b",
            ContextLength = 8192,
            PricePerInputTokenInUsd = 1.9999999999999998E-13,
            PricePerOutputTokenInUsd = 1.9999999999999998E-13,
        },

        
        [OpenRouterModelIds.OpenAiGpt4O] = new ChatModelMetadata
        {
            Id = "openai/gpt-4o",
            ContextLength = 128000,
            PricePerInputTokenInUsd = 2.5000000000000003E-12,
            PricePerOutputTokenInUsd = 1.0000000000000001E-11,
        },

        
        [OpenRouterModelIds.OpenAiGpt4OExtended] = new ChatModelMetadata
        {
            Id = "openai/gpt-4o:extended",
            ContextLength = 128000,
            PricePerInputTokenInUsd = 6E-12,
            PricePerOutputTokenInUsd = 1.8E-11,
        },

        
        [OpenRouterModelIds.NeversleepLlama3Lumimaid8BExtended] = new ChatModelMetadata
        {
            Id = "neversleep/llama-3-lumimaid-8b:extended",
            ContextLength = 24576,
            PricePerInputTokenInUsd = 1.875E-13,
            PricePerOutputTokenInUsd = 1.125E-12,
        },

        
        [OpenRouterModelIds.NeversleepLlama3Lumimaid8B] = new ChatModelMetadata
        {
            Id = "neversleep/llama-3-lumimaid-8b",
            ContextLength = 24576,
            PricePerInputTokenInUsd = 1.875E-13,
            PricePerOutputTokenInUsd = 1.125E-12,
        },

        
        [OpenRouterModelIds.Fimbulvetr11BV2] = new ChatModelMetadata
        {
            Id = "sao10k/fimbulvetr-11b-v2",
            ContextLength = 4096,
            PricePerInputTokenInUsd = 7.999999999999999E-13,
            PricePerOutputTokenInUsd = 1.2E-12,
        },

        
        [OpenRouterModelIds.MetaLlama38BInstructFree] = new ChatModelMetadata
        {
            Id = "meta-llama/llama-3-8b-instruct:free",
            ContextLength = 8192,
            PricePerInputTokenInUsd = 0,
            PricePerOutputTokenInUsd = 0,
        },

        
        [OpenRouterModelIds.MetaLlama38BInstruct] = new ChatModelMetadata
        {
            Id = "meta-llama/llama-3-8b-instruct",
            ContextLength = 8192,
            PricePerInputTokenInUsd = 3E-14,
            PricePerOutputTokenInUsd = 6E-14,
        },

        
        [OpenRouterModelIds.MetaLlama370BInstruct] = new ChatModelMetadata
        {
            Id = "meta-llama/llama-3-70b-instruct",
            ContextLength = 8192,
            PricePerInputTokenInUsd = 2.3E-13,
            PricePerOutputTokenInUsd = 3.9999999999999996E-13,
        },

        
        [OpenRouterModelIds.MistralMixtral8X22bInstruct] = new ChatModelMetadata
        {
            Id = "mistralai/mixtral-8x22b-instruct",
            ContextLength = 65536,
            PricePerInputTokenInUsd = 9E-13,
            PricePerOutputTokenInUsd = 9E-13,
        },

        
        [OpenRouterModelIds.Wizardlm28X22b] = new ChatModelMetadata
        {
            Id = "microsoft/wizardlm-2-8x22b",
            ContextLength = 65536,
            PricePerInputTokenInUsd = 5E-13,
            PricePerOutputTokenInUsd = 5E-13,
        },

        
        [OpenRouterModelIds.Wizardlm27B] = new ChatModelMetadata
        {
            Id = "microsoft/wizardlm-2-7b",
            ContextLength = 32000,
            PricePerInputTokenInUsd = 7E-14,
            PricePerOutputTokenInUsd = 7E-14,
        },

        
        [OpenRouterModelIds.GoogleGeminiPro15] = new ChatModelMetadata
        {
            Id = "google/gemini-pro-1.5",
            ContextLength = 2000000,
            PricePerInputTokenInUsd = 1.2500000000000001E-12,
            PricePerOutputTokenInUsd = 5.0000000000000005E-12,
        },

        
        [OpenRouterModelIds.OpenAiGpt4Turbo] = new ChatModelMetadata
        {
            Id = "openai/gpt-4-turbo",
            ContextLength = 128000,
            PricePerInputTokenInUsd = 1.0000000000000001E-11,
            PricePerOutputTokenInUsd = 3E-11,
        },

        
        [OpenRouterModelIds.CohereCommandRPlus] = new ChatModelMetadata
        {
            Id = "cohere/command-r-plus",
            ContextLength = 128000,
            PricePerInputTokenInUsd = 2.8499999999999998E-12,
            PricePerOutputTokenInUsd = 1.4250000000000001E-11,
        },

        
        [OpenRouterModelIds.CohereCommandRPlus042024] = new ChatModelMetadata
        {
            Id = "cohere/command-r-plus-04-2024",
            ContextLength = 128000,
            PricePerInputTokenInUsd = 2.8499999999999998E-12,
            PricePerOutputTokenInUsd = 1.4250000000000001E-11,
        },

        
        [OpenRouterModelIds.DatabricksDbrx132BInstruct] = new ChatModelMetadata
        {
            Id = "databricks/dbrx-instruct",
            ContextLength = 32768,
            PricePerInputTokenInUsd = 1.2E-12,
            PricePerOutputTokenInUsd = 1.2E-12,
        },

        
        [OpenRouterModelIds.MidnightRose70B] = new ChatModelMetadata
        {
            Id = "sophosympatheia/midnight-rose-70b",
            ContextLength = 4096,
            PricePerInputTokenInUsd = 7.999999999999999E-13,
            PricePerOutputTokenInUsd = 7.999999999999999E-13,
        },

        
        [OpenRouterModelIds.CohereCommand] = new ChatModelMetadata
        {
            Id = "cohere/command",
            ContextLength = 4096,
            PricePerInputTokenInUsd = 9.5E-13,
            PricePerOutputTokenInUsd = 1.9E-12,
        },

        
        [OpenRouterModelIds.CohereCommandR] = new ChatModelMetadata
        {
            Id = "cohere/command-r",
            ContextLength = 128000,
            PricePerInputTokenInUsd = 4.75E-13,
            PricePerOutputTokenInUsd = 1.4249999999999999E-12,
        },

        
        [OpenRouterModelIds.AnthropicClaude3HaikuSelfModerated] = new ChatModelMetadata
        {
            Id = "anthropic/claude-3-haiku:beta",
            ContextLength = 200000,
            PricePerInputTokenInUsd = 2.5E-13,
            PricePerOutputTokenInUsd = 1.2500000000000001E-12,
        },

        
        [OpenRouterModelIds.AnthropicClaude3Haiku] = new ChatModelMetadata
        {
            Id = "anthropic/claude-3-haiku",
            ContextLength = 200000,
            PricePerInputTokenInUsd = 2.5E-13,
            PricePerOutputTokenInUsd = 1.2500000000000001E-12,
        },

        
        [OpenRouterModelIds.AnthropicClaude3OpusSelfModerated] = new ChatModelMetadata
        {
            Id = "anthropic/claude-3-opus:beta",
            ContextLength = 200000,
            PricePerInputTokenInUsd = 1.5E-11,
            PricePerOutputTokenInUsd = 7.5E-11,
        },

        
        [OpenRouterModelIds.AnthropicClaude3Opus] = new ChatModelMetadata
        {
            Id = "anthropic/claude-3-opus",
            ContextLength = 200000,
            PricePerInputTokenInUsd = 1.5E-11,
            PricePerOutputTokenInUsd = 7.5E-11,
        },

        
        [OpenRouterModelIds.AnthropicClaude3SonnetSelfModerated] = new ChatModelMetadata
        {
            Id = "anthropic/claude-3-sonnet:beta",
            ContextLength = 200000,
            PricePerInputTokenInUsd = 3E-12,
            PricePerOutputTokenInUsd = 1.5E-11,
        },

        
        [OpenRouterModelIds.AnthropicClaude3Sonnet] = new ChatModelMetadata
        {
            Id = "anthropic/claude-3-sonnet",
            ContextLength = 200000,
            PricePerInputTokenInUsd = 3E-12,
            PricePerOutputTokenInUsd = 1.5E-11,
        },

        
        [OpenRouterModelIds.CohereCommandR032024] = new ChatModelMetadata
        {
            Id = "cohere/command-r-03-2024",
            ContextLength = 128000,
            PricePerInputTokenInUsd = 4.75E-13,
            PricePerOutputTokenInUsd = 1.4249999999999999E-12,
        },

        
        [OpenRouterModelIds.MistralLarge] = new ChatModelMetadata
        {
            Id = "mistralai/mistral-large",
            ContextLength = 128000,
            PricePerInputTokenInUsd = 2E-12,
            PricePerOutputTokenInUsd = 6E-12,
        },

        
        [OpenRouterModelIds.GoogleGemma7B] = new ChatModelMetadata
        {
            Id = "google/gemma-7b-it",
            ContextLength = 8192,
            PricePerInputTokenInUsd = 1.5E-13,
            PricePerOutputTokenInUsd = 1.5E-13,
        },

        
        [OpenRouterModelIds.OpenAiGpt35TurboOlderV0613] = new ChatModelMetadata
        {
            Id = "openai/gpt-3.5-turbo-0613",
            ContextLength = 4095,
            PricePerInputTokenInUsd = 1E-12,
            PricePerOutputTokenInUsd = 2E-12,
        },

        
        [OpenRouterModelIds.OpenAiGpt4TurboPreview] = new ChatModelMetadata
        {
            Id = "openai/gpt-4-turbo-preview",
            ContextLength = 128000,
            PricePerInputTokenInUsd = 1.0000000000000001E-11,
            PricePerOutputTokenInUsd = 3E-11,
        },

        
        [OpenRouterModelIds.NousHermes2Mixtral8X7BDpo] = new ChatModelMetadata
        {
            Id = "nousresearch/nous-hermes-2-mixtral-8x7b-dpo",
            ContextLength = 32768,
            PricePerInputTokenInUsd = 6E-13,
            PricePerOutputTokenInUsd = 6E-13,
        },

        
        [OpenRouterModelIds.MistralSmall] = new ChatModelMetadata
        {
            Id = "mistralai/mistral-small",
            ContextLength = 32000,
            PricePerInputTokenInUsd = 1.9999999999999998E-13,
            PricePerOutputTokenInUsd = 6E-13,
        },

        
        [OpenRouterModelIds.MistralTiny] = new ChatModelMetadata
        {
            Id = "mistralai/mistral-tiny",
            ContextLength = 32000,
            PricePerInputTokenInUsd = 2.5E-13,
            PricePerOutputTokenInUsd = 2.5E-13,
        },

        
        [OpenRouterModelIds.MistralMedium] = new ChatModelMetadata
        {
            Id = "mistralai/mistral-medium",
            ContextLength = 32000,
            PricePerInputTokenInUsd = 2.7499999999999998E-12,
            PricePerOutputTokenInUsd = 8.1E-12,
        },

        
        [OpenRouterModelIds.Dolphin26Mixtral8X7B] = new ChatModelMetadata
        {
            Id = "cognitivecomputations/dolphin-mixtral-8x7b",
            ContextLength = 32768,
            PricePerInputTokenInUsd = 5E-13,
            PricePerOutputTokenInUsd = 5E-13,
        },

        
        [OpenRouterModelIds.GoogleGeminiProVision10] = new ChatModelMetadata
        {
            Id = "google/gemini-pro-vision",
            ContextLength = 16384,
            PricePerInputTokenInUsd = 5E-13,
            PricePerOutputTokenInUsd = 1.5E-12,
        },

        
        [OpenRouterModelIds.GoogleGeminiPro10] = new ChatModelMetadata
        {
            Id = "google/gemini-pro",
            ContextLength = 32760,
            PricePerInputTokenInUsd = 5E-13,
            PricePerOutputTokenInUsd = 1.5E-12,
        },

        
        [OpenRouterModelIds.MistralMixtral8X7BBase] = new ChatModelMetadata
        {
            Id = "mistralai/mixtral-8x7b",
            ContextLength = 32768,
            PricePerInputTokenInUsd = 6E-13,
            PricePerOutputTokenInUsd = 6E-13,
        },

        
        [OpenRouterModelIds.MistralMixtral8X7BInstruct] = new ChatModelMetadata
        {
            Id = "mistralai/mixtral-8x7b-instruct",
            ContextLength = 32768,
            PricePerInputTokenInUsd = 2.4E-13,
            PricePerOutputTokenInUsd = 2.4E-13,
        },

        
        [OpenRouterModelIds.OpenChat357BFree] = new ChatModelMetadata
        {
            Id = "openchat/openchat-7b:free",
            ContextLength = 8192,
            PricePerInputTokenInUsd = 0,
            PricePerOutputTokenInUsd = 0,
        },

        
        [OpenRouterModelIds.OpenChat357B] = new ChatModelMetadata
        {
            Id = "openchat/openchat-7b",
            ContextLength = 8192,
            PricePerInputTokenInUsd = 5.5000000000000005E-14,
            PricePerOutputTokenInUsd = 5.5000000000000005E-14,
        },

        
        [OpenRouterModelIds.Noromaid20B] = new ChatModelMetadata
        {
            Id = "neversleep/noromaid-20b",
            ContextLength = 8192,
            PricePerInputTokenInUsd = 1.5E-12,
            PricePerOutputTokenInUsd = 2.25E-12,
        },

        
        [OpenRouterModelIds.AnthropicClaudeV2SelfModerated] = new ChatModelMetadata
        {
            Id = "anthropic/claude-2:beta",
            ContextLength = 200000,
            PricePerInputTokenInUsd = 8E-12,
            PricePerOutputTokenInUsd = 2.4E-11,
        },

        
        [OpenRouterModelIds.AnthropicClaudeV2] = new ChatModelMetadata
        {
            Id = "anthropic/claude-2",
            ContextLength = 200000,
            PricePerInputTokenInUsd = 8E-12,
            PricePerOutputTokenInUsd = 2.4E-11,
        },

        
        [OpenRouterModelIds.AnthropicClaudeV21SelfModerated] = new ChatModelMetadata
        {
            Id = "anthropic/claude-2.1:beta",
            ContextLength = 200000,
            PricePerInputTokenInUsd = 8E-12,
            PricePerOutputTokenInUsd = 2.4E-11,
        },

        
        [OpenRouterModelIds.AnthropicClaudeV21] = new ChatModelMetadata
        {
            Id = "anthropic/claude-2.1",
            ContextLength = 200000,
            PricePerInputTokenInUsd = 8E-12,
            PricePerOutputTokenInUsd = 2.4E-11,
        },

        
        [OpenRouterModelIds.OpenHermes25Mistral7B] = new ChatModelMetadata
        {
            Id = "teknium/openhermes-2.5-mistral-7b",
            ContextLength = 4096,
            PricePerInputTokenInUsd = 1.6999999999999998E-13,
            PricePerOutputTokenInUsd = 1.6999999999999998E-13,
        },

        
        [OpenRouterModelIds.ToppyM7BFree] = new ChatModelMetadata
        {
            Id = "undi95/toppy-m-7b:free",
            ContextLength = 4096,
            PricePerInputTokenInUsd = 0,
            PricePerOutputTokenInUsd = 0,
        },

        
        [OpenRouterModelIds.ToppyM7B] = new ChatModelMetadata
        {
            Id = "undi95/toppy-m-7b",
            ContextLength = 4096,
            PricePerInputTokenInUsd = 7E-14,
            PricePerOutputTokenInUsd = 7E-14,
        },

        
        [OpenRouterModelIds.Goliath120B] = new ChatModelMetadata
        {
            Id = "alpindale/goliath-120b",
            ContextLength = 6144,
            PricePerInputTokenInUsd = 9.375E-12,
            PricePerOutputTokenInUsd = 9.375E-12,
        },

        
        [OpenRouterModelIds.AutoRouter] = new ChatModelMetadata
        {
            Id = "openrouter/auto",
            ContextLength = 2000000,
            PricePerInputTokenInUsd = -1E-06,
            PricePerOutputTokenInUsd = -1E-06,
        },

        
        [OpenRouterModelIds.OpenAiGpt35Turbo16KOlderV1106] = new ChatModelMetadata
        {
            Id = "openai/gpt-3.5-turbo-1106",
            ContextLength = 16385,
            PricePerInputTokenInUsd = 1E-12,
            PricePerOutputTokenInUsd = 2E-12,
        },

        
        [OpenRouterModelIds.OpenAiGpt4TurboOlderV1106] = new ChatModelMetadata
        {
            Id = "openai/gpt-4-1106-preview",
            ContextLength = 128000,
            PricePerInputTokenInUsd = 1.0000000000000001E-11,
            PricePerOutputTokenInUsd = 3E-11,
        },

        
        [OpenRouterModelIds.GooglePalm2Chat32K] = new ChatModelMetadata
        {
            Id = "google/palm-2-chat-bison-32k",
            ContextLength = 32768,
            PricePerInputTokenInUsd = 1E-12,
            PricePerOutputTokenInUsd = 2E-12,
        },

        
        [OpenRouterModelIds.GooglePalm2CodeChat32K] = new ChatModelMetadata
        {
            Id = "google/palm-2-codechat-bison-32k",
            ContextLength = 32768,
            PricePerInputTokenInUsd = 1E-12,
            PricePerOutputTokenInUsd = 2E-12,
        },

        
        [OpenRouterModelIds.Airoboros70B] = new ChatModelMetadata
        {
            Id = "jondurbin/airoboros-l2-70b",
            ContextLength = 4000,
            PricePerInputTokenInUsd = 5E-13,
            PricePerOutputTokenInUsd = 5E-13,
        },

        
        [OpenRouterModelIds.Xwin70B] = new ChatModelMetadata
        {
            Id = "xwin-lm/xwin-lm-70b",
            ContextLength = 8192,
            PricePerInputTokenInUsd = 3.75E-12,
            PricePerOutputTokenInUsd = 3.75E-12,
        },

        
        [OpenRouterModelIds.OpenAiGpt35TurboInstruct] = new ChatModelMetadata
        {
            Id = "openai/gpt-3.5-turbo-instruct",
            ContextLength = 4095,
            PricePerInputTokenInUsd = 1.5E-12,
            PricePerOutputTokenInUsd = 2E-12,
        },

        
        [OpenRouterModelIds.MistralMistral7BInstructV01] = new ChatModelMetadata
        {
            Id = "mistralai/mistral-7b-instruct-v0.1",
            ContextLength = 32768,
            PricePerInputTokenInUsd = 1.9999999999999998E-13,
            PricePerOutputTokenInUsd = 1.9999999999999998E-13,
        },

        
        [OpenRouterModelIds.PygmalionMythalion13B] = new ChatModelMetadata
        {
            Id = "pygmalionai/mythalion-13b",
            ContextLength = 4096,
            PricePerInputTokenInUsd = 7.999999999999999E-13,
            PricePerOutputTokenInUsd = 1.2E-12,
        },

        
        [OpenRouterModelIds.OpenAiGpt35Turbo16K] = new ChatModelMetadata
        {
            Id = "openai/gpt-3.5-turbo-16k",
            ContextLength = 16385,
            PricePerInputTokenInUsd = 3E-12,
            PricePerOutputTokenInUsd = 4E-12,
        },

        
        [OpenRouterModelIds.OpenAiGpt432K] = new ChatModelMetadata
        {
            Id = "openai/gpt-4-32k",
            ContextLength = 32767,
            PricePerInputTokenInUsd = 6E-11,
            PricePerOutputTokenInUsd = 1.2E-10,
        },

        
        [OpenRouterModelIds.OpenAiGpt432KOlderV0314] = new ChatModelMetadata
        {
            Id = "openai/gpt-4-32k-0314",
            ContextLength = 32767,
            PricePerInputTokenInUsd = 6E-11,
            PricePerOutputTokenInUsd = 1.2E-10,
        },

        
        [OpenRouterModelIds.NousHermes13B] = new ChatModelMetadata
        {
            Id = "nousresearch/nous-hermes-llama2-13b",
            ContextLength = 4096,
            PricePerInputTokenInUsd = 1.8E-13,
            PricePerOutputTokenInUsd = 1.8E-13,
        },

        
        [OpenRouterModelIds.MancerWeaverAlpha] = new ChatModelMetadata
        {
            Id = "mancer/weaver",
            ContextLength = 8000,
            PricePerInputTokenInUsd = 1.5E-12,
            PricePerOutputTokenInUsd = 2.25E-12,
        },

        
        [OpenRouterModelIds.HuggingFaceZephyr7BFree] = new ChatModelMetadata
        {
            Id = "huggingfaceh4/zephyr-7b-beta:free",
            ContextLength = 4096,
            PricePerInputTokenInUsd = 0,
            PricePerOutputTokenInUsd = 0,
        },

        
        [OpenRouterModelIds.AnthropicClaudeV20SelfModerated] = new ChatModelMetadata
        {
            Id = "anthropic/claude-2.0:beta",
            ContextLength = 100000,
            PricePerInputTokenInUsd = 8E-12,
            PricePerOutputTokenInUsd = 2.4E-11,
        },

        
        [OpenRouterModelIds.AnthropicClaudeV20] = new ChatModelMetadata
        {
            Id = "anthropic/claude-2.0",
            ContextLength = 100000,
            PricePerInputTokenInUsd = 8E-12,
            PricePerOutputTokenInUsd = 2.4E-11,
        },

        
        [OpenRouterModelIds.RemmSlerp13B] = new ChatModelMetadata
        {
            Id = "undi95/remm-slerp-l2-13b",
            ContextLength = 4096,
            PricePerInputTokenInUsd = 7.999999999999999E-13,
            PricePerOutputTokenInUsd = 1.2E-12,
        },

        
        [OpenRouterModelIds.GooglePalm2Chat] = new ChatModelMetadata
        {
            Id = "google/palm-2-chat-bison",
            ContextLength = 9216,
            PricePerInputTokenInUsd = 1E-12,
            PricePerOutputTokenInUsd = 2E-12,
        },

        
        [OpenRouterModelIds.GooglePalm2CodeChat] = new ChatModelMetadata
        {
            Id = "google/palm-2-codechat-bison",
            ContextLength = 7168,
            PricePerInputTokenInUsd = 1E-12,
            PricePerOutputTokenInUsd = 2E-12,
        },

        
        [OpenRouterModelIds.Mythomax13BFree] = new ChatModelMetadata
        {
            Id = "gryphe/mythomax-l2-13b:free",
            ContextLength = 4096,
            PricePerInputTokenInUsd = 0,
            PricePerOutputTokenInUsd = 0,
        },

        
        [OpenRouterModelIds.Mythomax13B] = new ChatModelMetadata
        {
            Id = "gryphe/mythomax-l2-13b",
            ContextLength = 4096,
            PricePerInputTokenInUsd = 6.5E-14,
            PricePerOutputTokenInUsd = 6.5E-14,
        },

        
        [OpenRouterModelIds.MetaLlama213BChat] = new ChatModelMetadata
        {
            Id = "meta-llama/llama-2-13b-chat",
            ContextLength = 4096,
            PricePerInputTokenInUsd = 2.2000000000000002E-13,
            PricePerOutputTokenInUsd = 2.2000000000000002E-13,
        },

        
        [OpenRouterModelIds.MetaLlama270BChat] = new ChatModelMetadata
        {
            Id = "meta-llama/llama-2-70b-chat",
            ContextLength = 4096,
            PricePerInputTokenInUsd = 9E-13,
            PricePerOutputTokenInUsd = 9E-13,
        },

        
        [OpenRouterModelIds.OpenAiGpt35Turbo] = new ChatModelMetadata
        {
            Id = "openai/gpt-3.5-turbo",
            ContextLength = 16385,
            PricePerInputTokenInUsd = 5E-13,
            PricePerOutputTokenInUsd = 1.5E-12,
        },

        
        [OpenRouterModelIds.OpenAiGpt35Turbo16K0125] = new ChatModelMetadata
        {
            Id = "openai/gpt-3.5-turbo-0125",
            ContextLength = 16385,
            PricePerInputTokenInUsd = 5E-13,
            PricePerOutputTokenInUsd = 1.5E-12,
        },

        
        [OpenRouterModelIds.OpenAiGpt4] = new ChatModelMetadata
        {
            Id = "openai/gpt-4",
            ContextLength = 8191,
            PricePerInputTokenInUsd = 3E-11,
            PricePerOutputTokenInUsd = 6E-11,
        },

        
        [OpenRouterModelIds.OpenAiGpt4OlderV0314] = new ChatModelMetadata
        {
            Id = "openai/gpt-4-0314",
            ContextLength = 8191,
            PricePerInputTokenInUsd = 3E-11,
            PricePerOutputTokenInUsd = 6E-11,
        },


    };

    [CLSCompliant(false)]
    public static ChatModelMetadata GetModelById(OpenRouterModelIds modelId)
    {
        if (Models.TryGetValue(modelId, out var id))
        {
            return id;
        }

        throw new ArgumentException($"Invalid Open Router Model {modelId}");
    }

    [CLSCompliant(false)]
    public static ChatModelMetadata GetModelById(string modelId)
    {
        return Models.Values.First(s => s.Id == modelId);
    }
}