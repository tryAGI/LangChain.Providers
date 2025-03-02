namespace LangChain.Providers.Together;

/// <summary>
/// List of all the Predefined Together Ai Models
/// </summary>
public enum TogetherModelIds
{

        /// <summary>
        /// Name: Gemma-2 Instruct (27B) <br/>
        /// Organization: Google <br/>
        /// Context Length: 8192 <br/>
        /// Prompt Cost: $0.8/MTok <br/>
        /// Completion Cost: $0.8/MTok <br/>
        /// Description: Gemma is a family of lightweight, state-of-the-art open models from Google, built from the same research and technology used to create the Gemini models. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/google/gemma-2-27b-it">https://huggingface.co/google/gemma-2-27b-it</a>
        /// </summary>
        Gemma2Instruct27B,
        
        /// <summary>
        /// Name: Meta Llama 3 70B Instruct Turbo <br/>
        /// Organization: Meta <br/>
        /// Context Length: 8192 <br/>
        /// Prompt Cost: $0.88/MTok <br/>
        /// Completion Cost: $0.88/MTok <br/>
        /// Description: Llama 3 is an auto-regressive language model that uses an optimized transformer architecture. The tuned versions use supervised fine-tuning (SFT) and reinforcement learning with human feedback (RLHF) to align with human preferences for helpfulness and safety. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Meta-Llama-3-70B-Instruct-Turbo">https://huggingface.co/meta-llama/Meta-Llama-3-70B-Instruct-Turbo</a>
        /// </summary>
        MetaLlama370BInstructTurbo,
        
        /// <summary>
        /// Name: Qwen2-VL (72B) Instruct <br/>
        /// Organization: Qwen <br/>
        /// Context Length: 32768 <br/>
        /// Prompt Cost: $1.2/MTok <br/>
        /// Completion Cost: $1.2/MTok <br/>
        /// Description: Qwen2-VL is the latest version of the vision language models based on Qwen2 in the Qwen model family. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/Qwen/Qwen2-VL-72B-Instruct">https://huggingface.co/Qwen/Qwen2-VL-72B-Instruct</a>
        /// </summary>
        Qwen2Vl72BInstruct,
        
        /// <summary>
        /// Name: Meta Llama Vision Free <br/>
        /// Organization: Meta <br/>
        /// Context Length: 131072 <br/>
        /// Prompt Cost: $0/MTok <br/>
        /// Completion Cost: $0/MTok <br/>
        /// Description: Llama 3.2 is an auto-regressive language model that uses an optimized transformer architecture. The tuned versions use supervised fine-tuning (SFT) and reinforcement learning with human feedback (RLHF) to align with human preferences for helpfulness and safety. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Llama-Vision-Free">https://huggingface.co/meta-llama/Llama-Vision-Free</a>
        /// </summary>
        MetaLlamaVisionFree,
        
        /// <summary>
        /// Name: MythoMax-L2 (13B) <br/>
        /// Organization: Gryphe <br/>
        /// Context Length: 4096 <br/>
        /// Prompt Cost: $0.3/MTok <br/>
        /// Completion Cost: $0.3/MTok <br/>
        /// Description: MythoLogic-L2 and Huginn merge using a highly experimental tensor type merge technique. The main difference with MythoMix is that I allowed more of Huginn to intermingle with the single tensors located at the front and end of a model <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/Gryphe/MythoMax-L2-13b">https://huggingface.co/Gryphe/MythoMax-L2-13b</a>
        /// </summary>
        MythomaxL213B,
        
        /// <summary>
        /// Name: Qwen2.5 72B Instruct Turbo <br/>
        /// Organization: Qwen <br/>
        /// Context Length: 131072 <br/>
        /// Prompt Cost: $1.2/MTok <br/>
        /// Completion Cost: $1.2/MTok <br/>
        /// Description: Qwen2.5 is the latest series of Qwen large language models. For Qwen2.5, we release a number of base language models and instruction-tuned language models ranging from 0.5 to 72 billion parameters. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/Qwen/Qwen2.5-72B-Instruct-Turbo">https://huggingface.co/Qwen/Qwen2.5-72B-Instruct-Turbo</a>
        /// </summary>
        Qwen2572BInstructTurbo,
        
        /// <summary>
        /// Name: Meta Llama 3.3 70B Instruct Turbo Free <br/>
        /// Organization: Meta <br/>
        /// Context Length: 131072 <br/>
        /// Prompt Cost: $0/MTok <br/>
        /// Completion Cost: $0/MTok <br/>
        /// Description: The Meta Llama 3.3 multilingual large language model (LLM) is a pretrained and instruction tuned generative model in 70B (text in/text out). The Llama 3.3 instruction tuned text only model is optimized for multilingual dialogue use cases and outperform many of the available open source and closed chat models on common industry benchmarks. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Llama-3.3-70B-Instruct-Turbo-Free">https://huggingface.co/meta-llama/Llama-3.3-70B-Instruct-Turbo-Free</a>
        /// </summary>
        MetaLlama3370BInstructTurboFree,
        
        /// <summary>
        /// Name: Meta Llama 3.2 11B Vision Instruct Turbo <br/>
        /// Organization: Meta <br/>
        /// Context Length: 131072 <br/>
        /// Prompt Cost: $0.18/MTok <br/>
        /// Completion Cost: $0.18/MTok <br/>
        /// Description: Llama 3.2 is an auto-regressive language model that uses an optimized transformer architecture. The tuned versions use supervised fine-tuning (SFT) and reinforcement learning with human feedback (RLHF) to align with human preferences for helpfulness and safety. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Llama-3.2-11B-Vision-Instruct-Turbo">https://huggingface.co/meta-llama/Llama-3.2-11B-Vision-Instruct-Turbo</a>
        /// </summary>
        MetaLlama3211BVisionInstructTurbo,
        
        /// <summary>
        /// Name: Mistral Small (24B) Instruct 25.01 <br/>
        /// Organization: mistralai <br/>
        /// Context Length: 32768 <br/>
        /// Prompt Cost: $0.8/MTok <br/>
        /// Completion Cost: $0.8/MTok <br/>
        /// Description: Mistral Small 3 ( 2501 ) sets a new benchmark in the "small" Large Language Models category below 70B, boasting 24B parameters and achieving state-of-the-art capabilities comparable to larger models! <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/mistralai/Mistral-Small-24B-Instruct-2501">https://huggingface.co/mistralai/Mistral-Small-24B-Instruct-2501</a>
        /// </summary>
        MistralSmall24BInstruct2501,
        
        /// <summary>
        /// Name: Mixtral-8x22B Instruct v0.1 <br/>
        /// Organization: mistralai <br/>
        /// Context Length: 65536 <br/>
        /// Prompt Cost: $1.2/MTok <br/>
        /// Completion Cost: $1.2/MTok <br/>
        /// Description: The Mixtral-8x22B-Instruct-v0.1 Large Language Model (LLM) is an instruct fine-tuned version of the Mixtral-8x22B-v0.1. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/mistralai/Mixtral-8x22B-Instruct-v0.1">https://huggingface.co/mistralai/Mixtral-8x22B-Instruct-v0.1</a>
        /// </summary>
        Mixtral8X22bInstructV01,
        
        /// <summary>
        /// Name: Meta Llama 3 8B Instruct Turbo <br/>
        /// Organization: Meta <br/>
        /// Context Length: 8192 <br/>
        /// Prompt Cost: $0.18/MTok <br/>
        /// Completion Cost: $0.18/MTok <br/>
        /// Description: Llama 3 is an auto-regressive language model that uses an optimized transformer architecture. The tuned versions use supervised fine-tuning (SFT) and reinforcement learning with human feedback (RLHF) to align with human preferences for helpfulness and safety. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Meta-Llama-3-8B-Instruct-Turbo">https://huggingface.co/meta-llama/Meta-Llama-3-8B-Instruct-Turbo</a>
        /// </summary>
        MetaLlama38BInstructTurbo,
        
        /// <summary>
        /// Name: Nous Hermes 2 - Mixtral 8x7B-DPO  <br/>
        /// Organization: NousResearch <br/>
        /// Context Length: 32768 <br/>
        /// Prompt Cost: $0.6/MTok <br/>
        /// Completion Cost: $0.6/MTok <br/>
        /// Description: Nous Hermes 2 Mixtral 7bx8 DPO is the new flagship Nous Research model trained over the Mixtral 7bx8 MoE LLM. The model was trained on over 1,000,000 entries of primarily GPT-4 generated data, as well as other high quality data from open datasets across the AI landscape, achieving state of the art performance on a variety of tasks. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/NousResearch/Nous-Hermes-2-Mixtral-8x7B-DPO">https://huggingface.co/NousResearch/Nous-Hermes-2-Mixtral-8x7B-DPO</a>
        /// </summary>
        NousHermes2Mixtral8X7BDpo,
        
        /// <summary>
        /// Name: Meta Llama 3.1 8B Instruct Turbo <br/>
        /// Organization: Meta <br/>
        /// Context Length: 131072 <br/>
        /// Prompt Cost: $0.18/MTok <br/>
        /// Completion Cost: $0.18/MTok <br/>
        /// Description: Llama 3.1 is an auto-regressive language model that uses an optimized transformer architecture. The tuned versions use supervised fine-tuning (SFT) and reinforcement learning with human feedback (RLHF) to align with human preferences for helpfulness and safety. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Meta-Llama-3.1-8B-Instruct-Turbo-classifier">https://huggingface.co/meta-llama/Meta-Llama-3.1-8B-Instruct-Turbo-classifier</a>
        /// </summary>
        MetaLlama318BInstructTurbo,
        
        /// <summary>
        /// Name: DeepSeek V3 <br/>
        /// Organization: DeepSeek <br/>
        /// Context Length: 131072 <br/>
        /// Prompt Cost: $1.25/MTok <br/>
        /// Completion Cost: $1.25/MTok <br/>
        /// Description: DeepSeek V3 <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/deepseek-ai/DeepSeek-V3">https://huggingface.co/deepseek-ai/DeepSeek-V3</a>
        /// </summary>
        DeepseekV3,
        
        /// <summary>
        /// Name: DeepSeek R1 <br/>
        /// Organization: DeepSeek <br/>
        /// Context Length: 163840 <br/>
        /// Prompt Cost: $3/MTok <br/>
        /// Completion Cost: $3/MTok <br/>
        /// Description: DeepSeek R1 <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/deepseek-ai/DeepSeek-R1">https://huggingface.co/deepseek-ai/DeepSeek-R1</a>
        /// </summary>
        DeepseekR1,
        
        /// <summary>
        /// Name: Qwen 2 Instruct (72B) <br/>
        /// Organization: Qwen <br/>
        /// Context Length: 32768 <br/>
        /// Prompt Cost: $0.9/MTok <br/>
        /// Completion Cost: $0.9/MTok <br/>
        /// Description: Qwen2 is the new series of Qwen large language models. For Qwen2, we release a number of base language models and instruction-tuned language models ranging from 0.5 to 72 billion parameters, including a Mixture-of-Experts model. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/Qwen/Qwen2-72B-Instruct">https://huggingface.co/Qwen/Qwen2-72B-Instruct</a>
        /// </summary>
        Qwen2Instruct72B,
        
        /// <summary>
        /// Name: Meta Llama 3 8B Instruct Lite <br/>
        /// Organization: Meta <br/>
        /// Context Length: 8192 <br/>
        /// Prompt Cost: $0.1/MTok <br/>
        /// Completion Cost: $0.1/MTok <br/>
        /// Description: Llama 3 is an auto-regressive language model that uses an optimized transformer architecture. The tuned versions use supervised fine-tuning (SFT) and reinforcement learning with human feedback (RLHF) to align with human preferences for helpfulness and safety. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Meta-Llama-3-8B-Instruct-Lite">https://huggingface.co/meta-llama/Meta-Llama-3-8B-Instruct-Lite</a>
        /// </summary>
        MetaLlama38BInstructLite,
        
        /// <summary>
        /// Name: Upstage SOLAR Instruct v1 (11B) <br/>
        /// Organization: upstage <br/>
        /// Context Length: 4096 <br/>
        /// Prompt Cost: $0.3/MTok <br/>
        /// Completion Cost: $0.3/MTok <br/>
        /// Description: Built on the Llama2 architecture, SOLAR-10.7B incorporates the innovative Upstage Depth Up-Scaling <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/upstage/SOLAR-10.7B-Instruct-v1.0">https://huggingface.co/upstage/SOLAR-10.7B-Instruct-v1.0</a>
        /// </summary>
        UpstageSolarInstructV111B,
        
        /// <summary>
        /// Name: Together AI MoA-1 <br/>
        /// Organization: Together AI <br/>
        /// Context Length: 32768 <br/>
        /// Prompt Cost: $0/MTok <br/>
        /// Completion Cost: $0/MTok <br/>
        /// Description: Mixture of Agents (MoA) is a novel approach that leverages the collective strengths of multiple LLMs to enhance performance, achieving state-of-the-art results <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/togethercomputer/MoA-1">https://huggingface.co/togethercomputer/MoA-1</a>
        /// </summary>
        TogetherAiMoa1,
        
        /// <summary>
        /// Name: Qwen QwQ-32B-Preview <br/>
        /// Organization: Qwen <br/>
        /// Context Length: 32768 <br/>
        /// Prompt Cost: $1.2/MTok <br/>
        /// Completion Cost: $1.2/MTok <br/>
        /// Description: QwQ-32B-Preview is an experimental research model developed by the Qwen Team, focused on advancing AI reasoning capabilities. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/Qwen/QwQ-32B-Preview">https://huggingface.co/Qwen/QwQ-32B-Preview</a>
        /// </summary>
        QwenQwq32BPreview,
        
        /// <summary>
        /// Name: Meta Llama 3.1 405B Instruct Turbo <br/>
        /// Organization: Meta <br/>
        /// Context Length: 130815 <br/>
        /// Prompt Cost: $3.5/MTok <br/>
        /// Completion Cost: $3.5/MTok <br/>
        /// Description: Llama 3.1 is an auto-regressive language model that uses an optimized transformer architecture. The tuned versions use supervised fine-tuning (SFT) and reinforcement learning with human feedback (RLHF) to align with human preferences for helpfulness and safety. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Meta-Llama-3.1-405B-Instruct-Turbo">https://huggingface.co/meta-llama/Meta-Llama-3.1-405B-Instruct-Turbo</a>
        /// </summary>
        MetaLlama31405BInstructTurbo,
        
        /// <summary>
        /// Name: Meta Llama 3.1 70B Instruct Turbo <br/>
        /// Organization: Meta <br/>
        /// Context Length: 131072 <br/>
        /// Prompt Cost: $0.88/MTok <br/>
        /// Completion Cost: $0.88/MTok <br/>
        /// Description: Llama 3.1 is an auto-regressive language model that uses an optimized transformer architecture. The tuned versions use supervised fine-tuning (SFT) and reinforcement learning with human feedback (RLHF) to align with human preferences for helpfulness and safety. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Meta-Llama-3.1-70B-Instruct-Turbo">https://huggingface.co/meta-llama/Meta-Llama-3.1-70B-Instruct-Turbo</a>
        /// </summary>
        MetaLlama3170BInstructTurbo,
        
        /// <summary>
        /// Name: Mistral (7B) Instruct v0.2 <br/>
        /// Organization: mistralai <br/>
        /// Context Length: 32768 <br/>
        /// Prompt Cost: $0.2/MTok <br/>
        /// Completion Cost: $0.2/MTok <br/>
        /// Description: The Mistral-7B-Instruct-v0.2 Large Language Model (LLM) is an improved instruct fine-tuned version of Mistral-7B-Instruct-v0.1. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/mistralai/Mistral-7B-Instruct-v0.2">https://huggingface.co/mistralai/Mistral-7B-Instruct-v0.2</a>
        /// </summary>
        Mistral7BInstructV02,
        
        /// <summary>
        /// Name: DBRX Instruct <br/>
        /// Organization: Databricks <br/>
        /// Context Length: 32768 <br/>
        /// Prompt Cost: $1.2/MTok <br/>
        /// Completion Cost: $1.2/MTok <br/>
        /// Description: DBRX Instruct is a mixture-of-experts (MoE) large language model trained from scratch by Databricks. DBRX Instruct specializes in few-turn interactions. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/databricks/dbrx-instruct">https://huggingface.co/databricks/dbrx-instruct</a>
        /// </summary>
        DbrxInstruct,
        
        /// <summary>
        /// Name: Meta Llama 3 8B Instruct Reference <br/>
        /// Organization: Meta <br/>
        /// Context Length: 8192 <br/>
        /// Prompt Cost: $0.2/MTok <br/>
        /// Completion Cost: $0.2/MTok <br/>
        /// Description: Llama 3 is an auto-regressive language model that uses an optimized transformer architecture. The tuned versions use supervised fine-tuning (SFT) and reinforcement learning with human feedback (RLHF) to align with human preferences for helpfulness and safety. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Llama-3-8b-chat-hf">https://huggingface.co/meta-llama/Llama-3-8b-chat-hf</a>
        /// </summary>
        MetaLlama38BInstructReference,
        
        /// <summary>
        /// Name: Gemma Instruct (2B) <br/>
        /// Organization: Google <br/>
        /// Context Length: 8192 <br/>
        /// Prompt Cost: $0.1/MTok <br/>
        /// Completion Cost: $0.1/MTok <br/>
        /// Description: Gemma is a family of lightweight, state-of-the-art open models from Google, built from the same research and technology used to create the Gemini models. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/google/gemma-2b-it">https://huggingface.co/google/gemma-2b-it</a>
        /// </summary>
        GemmaInstruct2B,
        
        /// <summary>
        /// Name: Meta Llama 3 70B Instruct Lite <br/>
        /// Organization: Meta <br/>
        /// Context Length: 8192 <br/>
        /// Prompt Cost: $0.54/MTok <br/>
        /// Completion Cost: $0.54/MTok <br/>
        /// Description: Llama 3 is an auto-regressive language model that uses an optimized transformer architecture. The tuned versions use supervised fine-tuning (SFT) and reinforcement learning with human feedback (RLHF) to align with human preferences for helpfulness and safety. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Meta-Llama-3-70B-Instruct-Lite">https://huggingface.co/meta-llama/Meta-Llama-3-70B-Instruct-Lite</a>
        /// </summary>
        MetaLlama370BInstructLite,
        
        /// <summary>
        /// Name: Gemma-2 Instruct (9B) <br/>
        /// Organization: google <br/>
        /// Context Length: 8192 <br/>
        /// Prompt Cost: $0.3/MTok <br/>
        /// Completion Cost: $0.3/MTok <br/>
        /// Description: Gemma is a family of lightweight, state-of-the-art open models from Google, built from the same research and technology used to create the Gemini models. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/google/gemma-2-9b-it">https://huggingface.co/google/gemma-2-9b-it</a>
        /// </summary>
        Gemma2Instruct9B,
        
        /// <summary>
        /// Name: Meta Llama 3.3 70B Instruct Turbo <br/>
        /// Organization: Meta <br/>
        /// Context Length: 131072 <br/>
        /// Prompt Cost: $0.88/MTok <br/>
        /// Completion Cost: $0.88/MTok <br/>
        /// Description: The Meta Llama 3.3 multilingual large language model (LLM) is a pretrained and instruction tuned generative model in 70B (text in/text out). The Llama 3.3 instruction tuned text only model is optimized for multilingual dialogue use cases and outperform many of the available open source and closed chat models on common industry benchmarks. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Llama-3.3-70B-Instruct-Turbo">https://huggingface.co/meta-llama/Llama-3.3-70B-Instruct-Turbo</a>
        /// </summary>
        MetaLlama3370BInstructTurbo,
        
        /// <summary>
        /// Name: Gryphe MythoMax L2 Lite (13B) <br/>
        /// Organization: Gryphe <br/>
        /// Context Length: 4096 <br/>
        /// Prompt Cost: $0.1/MTok <br/>
        /// Completion Cost: $0.1/MTok <br/>
        /// Description: MythoLogic-L2 and Huginn merge using a highly experimental tensor type merge technique. The main difference with MythoMix is that I allowed more of Huginn to intermingle with the single tensors located at the front and end of a model <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/Gryphe/MythoMax-L2-13b-Lite">https://huggingface.co/Gryphe/MythoMax-L2-13b-Lite</a>
        /// </summary>
        GrypheMythomaxL2Lite13B,
        
        /// <summary>
        /// Name: Meta Llama 3.2 90B Vision Instruct Turbo <br/>
        /// Organization: Meta <br/>
        /// Context Length: 131072 <br/>
        /// Prompt Cost: $1.2/MTok <br/>
        /// Completion Cost: $1.2/MTok <br/>
        /// Description: Llama 3.2 is an auto-regressive language model that uses an optimized transformer architecture. The tuned versions use supervised fine-tuning (SFT) and reinforcement learning with human feedback (RLHF) to align with human preferences for helpfulness and safety. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Llama-3.2-90B-Vision-Instruct-Turbo">https://huggingface.co/meta-llama/Llama-3.2-90B-Vision-Instruct-Turbo</a>
        /// </summary>
        MetaLlama3290BVisionInstructTurbo,
        
        /// <summary>
        /// Name: LLaMA-2 Chat (7B) <br/>
        /// Organization: Meta <br/>
        /// Context Length: 4096 <br/>
        /// Prompt Cost: $0.2/MTok <br/>
        /// Completion Cost: $0.2/MTok <br/>
        /// Description: Llama 2-chat leverages publicly available instruction datasets and over 1 million human annotations. Available in three sizes: 7B, 13B and 70B parameters <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Llama-2-7b-chat-hf">https://huggingface.co/meta-llama/Llama-2-7b-chat-hf</a>
        /// </summary>
        Llama2Chat7B,
        
        /// <summary>
        /// Name: DeepSeek R1 Distill Llama 70B <br/>
        /// Organization: DeepSeek <br/>
        /// Context Length: 131072 <br/>
        /// Prompt Cost: $2/MTok <br/>
        /// Completion Cost: $2/MTok <br/>
        /// Description: DeepSeek R1 Distill Llama 70B <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Llama-70B">https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Llama-70B</a>
        /// </summary>
        DeepseekR1DistillLlama70B,
        
        /// <summary>
        /// Name: DeepSeek R1 Distill Qwen 1.5B <br/>
        /// Organization: DeepSeek <br/>
        /// Context Length: 131072 <br/>
        /// Prompt Cost: $0.18/MTok <br/>
        /// Completion Cost: $0.18/MTok <br/>
        /// Description:  <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-1.5B">https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-1.5B</a>
        /// </summary>
        DeepseekR1DistillQwen15B,
        
        /// <summary>
        /// Name: LLaMA-2 Chat (13B) <br/>
        /// Organization: Meta <br/>
        /// Context Length: 4096 <br/>
        /// Prompt Cost: $0.22/MTok <br/>
        /// Completion Cost: $0.22/MTok <br/>
        /// Description: Llama 2-chat leverages publicly available instruction datasets and over 1 million human annotations. Available in three sizes: 7B, 13B and 70B parameters <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Llama-2-13b-chat-hf">https://huggingface.co/meta-llama/Llama-2-13b-chat-hf</a>
        /// </summary>
        Llama2Chat13B,
        
        /// <summary>
        /// Name: Typhoon 1.5 8B Instruct <br/>
        /// Organization: SCB10X <br/>
        /// Context Length: 8192 <br/>
        /// Prompt Cost: $0.18/MTok <br/>
        /// Completion Cost: $0.18/MTok <br/>
        /// Description: Llama-3-Typhoon-v1.5-8B-Instruct is an instruct Thai 🇹🇭 large language model with 8 billion parameters, and it is based on Llama3-8B. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/scb10x/scb10x-llama3-typhoon-v1-5-8b-instruct">https://huggingface.co/scb10x/scb10x-llama3-typhoon-v1-5-8b-instruct</a>
        /// </summary>
        Typhoon158BInstruct,
        
        /// <summary>
        /// Name: Typhoon 1.5X 70B-awq <br/>
        /// Organization: SCB10X <br/>
        /// Context Length: 8192 <br/>
        /// Prompt Cost: $0.88/MTok <br/>
        /// Completion Cost: $0.88/MTok <br/>
        /// Description: Llama-3-Typhoon-v1.5X-70B-instruct is a 70 billion parameter instruct  model designed for the Thai 🇹🇭 language. It demonstrates  competitive performance with GPT-4-0612, and is optimized for application use cases,  Retrieval-Augmented Generation (RAG), constrained generation, and reasoning tasks. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/scb10x/scb10x-llama3-typhoon-v1-5x-4f316">https://huggingface.co/scb10x/scb10x-llama3-typhoon-v1-5x-4f316</a>
        /// </summary>
        Typhoon15X70BAwq,
        
        /// <summary>
        /// Name: Llama 3.1 Nemotron 70B Instruct HF <br/>
        /// Organization: nvidia <br/>
        /// Context Length: 32768 <br/>
        /// Prompt Cost: $0.88/MTok <br/>
        /// Completion Cost: $0.88/MTok <br/>
        /// Description: Llama-3.1-Nemotron-70B-Instruct is a large language model customized by NVIDIA to improve the helpfulness of LLM generated responses to user queries. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/nvidia/Llama-3.1-Nemotron-70B-Instruct-HF">https://huggingface.co/nvidia/Llama-3.1-Nemotron-70B-Instruct-HF</a>
        /// </summary>
        Llama31Nemotron70BInstructHf,
        
        /// <summary>
        /// Name: Qwen 2.5 Coder 32B Instruct <br/>
        /// Organization: Qwen <br/>
        /// Context Length: 16384 <br/>
        /// Prompt Cost: $0.8/MTok <br/>
        /// Completion Cost: $0.8/MTok <br/>
        /// Description: Qwen2.5 is the latest series of Qwen large language models. For Qwen2.5, we release a number of base language models and instruction-tuned language models ranging from 0.5 to 72 billion parameters. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/Qwen/Qwen2.5-Coder-32B-Instruct">https://huggingface.co/Qwen/Qwen2.5-Coder-32B-Instruct</a>
        /// </summary>
        Qwen25Coder32BInstruct,
        
        /// <summary>
        /// Name: WizardLM-2 (8x22B) <br/>
        /// Organization: microsoft <br/>
        /// Context Length: 65536 <br/>
        /// Prompt Cost: $1.2/MTok <br/>
        /// Completion Cost: $1.2/MTok <br/>
        /// Description: WizardLM-2 8x22B is Wizard's most advanced model, demonstrates highly competitive performance compared to those leading proprietary works and consistently outperforms all the existing state-of-the-art opensource models. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/microsoft/WizardLM-2-8x22B">https://huggingface.co/microsoft/WizardLM-2-8x22B</a>
        /// </summary>
        Wizardlm28X22b,
        
        /// <summary>
        /// Name: Mistral (7B) Instruct v0.3 <br/>
        /// Organization: mistralai <br/>
        /// Context Length: 32768 <br/>
        /// Prompt Cost: $0.2/MTok <br/>
        /// Completion Cost: $0.2/MTok <br/>
        /// Description: The Mistral-7B-Instruct-v0.3 Large Language Model (LLM) is an instruct fine-tuned version of the Mistral-7B-v0.3. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/mistralai/Mistral-7B-Instruct-v0.3">https://huggingface.co/mistralai/Mistral-7B-Instruct-v0.3</a>
        /// </summary>
        Mistral7BInstructV03,
        
        /// <summary>
        /// Name: Typhoon 2 70B Instruct <br/>
        /// Organization:  <br/>
        /// Context Length: 8192 <br/>
        /// Prompt Cost: $0.88/MTok <br/>
        /// Completion Cost: $0.88/MTok <br/>
        /// Description: Llama3.1-Typhoon2-70B-instruct is a instruct Thai 🇹🇭   large language model with 70 billion parameters, and it is based on Llama3.1-70B. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/scb10x/scb10x-llama3-1-typhoon2-60256">https://huggingface.co/scb10x/scb10x-llama3-1-typhoon2-60256</a>
        /// </summary>
        Typhoon270BInstruct,
        
        /// <summary>
        /// Name: Qwen2.5 7B Instruct Turbo <br/>
        /// Organization: Qwen <br/>
        /// Context Length: 32768 <br/>
        /// Prompt Cost: $0.3/MTok <br/>
        /// Completion Cost: $0.3/MTok <br/>
        /// Description: Qwen2.5 is the latest series of Qwen large language models. For Qwen2.5, we release a number of base language models and instruction-tuned language models ranging from 0.5 to 72 billion parameters. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/Qwen/Qwen2.5-7B-Instruct-Turbo">https://huggingface.co/Qwen/Qwen2.5-7B-Instruct-Turbo</a>
        /// </summary>
        Qwen257BInstructTurbo,
        
        /// <summary>
        /// Name: Typhoon 2 8B Instruct <br/>
        /// Organization: SCB10X <br/>
        /// Context Length: 8192 <br/>
        /// Prompt Cost: $0.18/MTok <br/>
        /// Completion Cost: $0.18/MTok <br/>
        /// Description: Llama3.1-Typhoon2-8B-instruct is a instruct Thai 🇹🇭   large language model with 8 billion parameters, and it is based on Llama3.1-8B. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/scb10x/scb10x-llama3-1-typhoon-18370">https://huggingface.co/scb10x/scb10x-llama3-1-typhoon-18370</a>
        /// </summary>
        Typhoon28BInstruct,
        
        /// <summary>
        /// Name: Meta Llama 3.2 3B Instruct Turbo <br/>
        /// Organization: Meta <br/>
        /// Context Length: 131072 <br/>
        /// Prompt Cost: $0.06/MTok <br/>
        /// Completion Cost: $0.06/MTok <br/>
        /// Description: Llama 3.2 is an auto-regressive language model that uses an optimized transformer architecture. The tuned versions use supervised fine-tuning (SFT) and reinforcement learning with human feedback (RLHF) to align with human preferences for helpfulness and safety. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Llama-3.2-3B-Instruct-Turbo">https://huggingface.co/meta-llama/Llama-3.2-3B-Instruct-Turbo</a>
        /// </summary>
        MetaLlama323BInstructTurbo,
        
        /// <summary>
        /// Name: Meta Llama 3 70B Instruct Reference <br/>
        /// Organization: Meta <br/>
        /// Context Length: 8192 <br/>
        /// Prompt Cost: $0.88/MTok <br/>
        /// Completion Cost: $0.88/MTok <br/>
        /// Description: Llama 3 is an auto-regressive language model that uses an optimized transformer architecture. The tuned versions use supervised fine-tuning (SFT) and reinforcement learning with human feedback (RLHF) to align with human preferences for helpfulness and safety. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Llama-3-70b-chat-hf">https://huggingface.co/meta-llama/Llama-3-70b-chat-hf</a>
        /// </summary>
        MetaLlama370BInstructReference,
        
        /// <summary>
        /// Name: Mixtral-8x7B Instruct v0.1 <br/>
        /// Organization: mistralai <br/>
        /// Context Length: 32768 <br/>
        /// Prompt Cost: $0.6/MTok <br/>
        /// Completion Cost: $0.6/MTok <br/>
        /// Description: The Mixtral-8x7B Large Language Model (LLM) is a pretrained generative Sparse Mixture of Experts. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/mistralai/Mixtral-8x7B-Instruct-v0.1">https://huggingface.co/mistralai/Mixtral-8x7B-Instruct-v0.1</a>
        /// </summary>
        Mixtral8X7BInstructV01,
        
        /// <summary>
        /// Name: Together AI MoA-1-Turbo <br/>
        /// Organization: Together AI <br/>
        /// Context Length: 32768 <br/>
        /// Prompt Cost: $0/MTok <br/>
        /// Completion Cost: $0/MTok <br/>
        /// Description: Mixture of Agents (MoA) is a novel approach that leverages the collective strengths of multiple LLMs to enhance performance, achieving state-of-the-art results <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/togethercomputer/MoA-1-Turbo">https://huggingface.co/togethercomputer/MoA-1-Turbo</a>
        /// </summary>
        TogetherAiMoa1Turbo,
        
        /// <summary>
        /// Name: DeepSeek R1 Distill Llama 70B Free <br/>
        /// Organization: DeepSeek <br/>
        /// Context Length: 8192 <br/>
        /// Prompt Cost: $0/MTok <br/>
        /// Completion Cost: $0/MTok <br/>
        /// Description: DeepSeek R1 Distill Llama 70B <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Llama-70B-free">https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Llama-70B-free</a>
        /// </summary>
        DeepseekR1DistillLlama70BFree,
        
        /// <summary>
        /// Name: DeepSeek R1 Distill Qwen 14B <br/>
        /// Organization: DeepSeek <br/>
        /// Context Length: 131072 <br/>
        /// Prompt Cost: $1.6/MTok <br/>
        /// Completion Cost: $1.6/MTok <br/>
        /// Description:  <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-14B">https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-14B</a>
        /// </summary>
        DeepseekR1DistillQwen14B,
        
        /// <summary>
        /// Name: Mistral (7B) Instruct <br/>
        /// Organization: mistralai <br/>
        /// Context Length: 32768 <br/>
        /// Prompt Cost: $0.2/MTok <br/>
        /// Completion Cost: $0.2/MTok <br/>
        /// Description: instruct fine-tuned version of Mistral-7B-v0.1 <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/mistralai/Mistral-7B-Instruct-v0.1">https://huggingface.co/mistralai/Mistral-7B-Instruct-v0.1</a>
        /// </summary>
        Mistral7BInstruct,
        
}