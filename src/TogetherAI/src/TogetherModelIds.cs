namespace LangChain.Providers.Together;

/// <summary>
/// List of all the Predefined Together Ai Models
/// </summary>
public enum TogetherModelIds
{

    /// <summary>
    /// Name: Code Llama Instruct (34B) <br/>
    /// Organization: Meta <br/>
    /// Context Length: 16384 <br/>
    /// Prompt Cost: $0.776/MTok <br/>
    /// Completion Cost: $0.776/MTok <br/>
    /// Description: Code Llama is a family of large language models for code based on Llama 2 providing infilling capabilities, support for large input contexts, and zero-shot instruction following ability for programming tasks. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/codellama/CodeLlama-34b-Instruct-hf">https://huggingface.co/codellama/CodeLlama-34b-Instruct-hf</a>
    /// </summary>
    CodeLlamaInstruct34B,

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
    /// Name: Nous Hermes-2 Yi (34B) <br/>
    /// Organization: NousResearch <br/>
    /// Context Length: 4096 <br/>
    /// Prompt Cost: $0.8/MTok <br/>
    /// Completion Cost: $0.8/MTok <br/>
    /// Description: Nous Hermes 2 - Yi-34B is a state of the art Yi Fine-tune <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/NousResearch/Nous-Hermes-2-Yi-34B">https://huggingface.co/NousResearch/Nous-Hermes-2-Yi-34B</a>
    /// </summary>
    NousHermes2Yi34B,

    /// <summary>
    /// Name: Llama3 8B Chat HF INT4 <br/>
    /// Organization: Meta <br/>
    /// Context Length: 8192 <br/>
    /// Prompt Cost: $0.2/MTok <br/>
    /// Completion Cost: $0.2/MTok <br/>
    /// Description: Llama 3 is an auto-regressive language model that uses an optimized transformer architecture. The tuned versions use supervised fine-tuning (SFT) and reinforcement learning with human feedback (RLHF) to align with human preferences for helpfulness and safety. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/togethercomputer/Llama-3-8b-chat-hf-int4">https://huggingface.co/togethercomputer/Llama-3-8b-chat-hf-int4</a>
    /// </summary>
    Llama38BChatHfInt4,

    /// <summary>
    /// Name: StripedHyena Nous (7B) <br/>
    /// Organization: Together <br/>
    /// Context Length: 32768 <br/>
    /// Prompt Cost: $0.2/MTok <br/>
    /// Completion Cost: $0.2/MTok <br/>
    /// Description: A hybrid architecture composed of multi-head, grouped-query attention and gated convolutions arranged in Hyena blocks, different from traditional decoder-only Transformers <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/togethercomputer/StripedHyena-Nous-7B">https://huggingface.co/togethercomputer/StripedHyena-Nous-7B</a>
    /// </summary>
    StripedhyenaNous7B,

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
    /// Name: Mistral (7B) Instruct <br/>
    /// Organization: mistralai <br/>
    /// Context Length: 4096 <br/>
    /// Prompt Cost: $0.2/MTok <br/>
    /// Completion Cost: $0.2/MTok <br/>
    /// Description: instruct fine-tuned version of Mistral-7B-v0.1 <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/mistralai/Mistral-7B-Instruct-v0.1">https://huggingface.co/mistralai/Mistral-7B-Instruct-v0.1</a>
    /// </summary>
    Mistral7BInstruct,

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
    /// Name: Qwen 1.5 Chat (72B) <br/>
    /// Organization: Qwen <br/>
    /// Context Length: 32768 <br/>
    /// Prompt Cost: $0.9/MTok <br/>
    /// Completion Cost: $0.9/MTok <br/>
    /// Description: Qwen1.5 is the beta version of Qwen2, a transformer-based decoder-only language model pretrained on a large amount of data. In comparison with the previous released Qwen. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/Qwen/Qwen1.5-72B-Chat">https://huggingface.co/Qwen/Qwen1.5-72B-Chat</a>
    /// </summary>
    Qwen15Chat72B,

    /// <summary>
    /// Name: DeepSeek LLM Chat (67B) <br/>
    /// Organization: DeepSeek <br/>
    /// Context Length: 4096 <br/>
    /// Prompt Cost: $0.9/MTok <br/>
    /// Completion Cost: $0.9/MTok <br/>
    /// Description: trained from scratch on a vast dataset of 2 trillion tokens in both English and Chinese <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/deepseek-ai/deepseek-llm-67b-chat">https://huggingface.co/deepseek-ai/deepseek-llm-67b-chat</a>
    /// </summary>
    DeepseekLlmChat67B,

    /// <summary>
    /// Name: Togethercomputer Llama3 8B Instruct Int8 <br/>
    /// Organization: Meta <br/>
    /// Context Length: 8192 <br/>
    /// Prompt Cost: $0.2/MTok <br/>
    /// Completion Cost: $0.2/MTok <br/>
    /// Description: Llama 3 is an auto-regressive language model that uses an optimized transformer architecture. The tuned versions use supervised fine-tuning (SFT) and reinforcement learning with human feedback (RLHF) to align with human preferences for helpfulness and safety. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/togethercomputer/Llama-3-8b-chat-hf-int8">https://huggingface.co/togethercomputer/Llama-3-8b-chat-hf-int8</a>
    /// </summary>
    TogethercomputerLlama38BInstructInt8,

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
    /// Name: Qwen 1.5 Chat (110B) <br/>
    /// Organization: Qwen <br/>
    /// Context Length: 32768 <br/>
    /// Prompt Cost: $1.8/MTok <br/>
    /// Completion Cost: $1.8/MTok <br/>
    /// Description: Qwen1.5 is the beta version of Qwen2, a transformer-based decoder-only language model pretrained on a large amount of data. In comparison with the previous released Qwen. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/Qwen/Qwen1.5-110B-Chat">https://huggingface.co/Qwen/Qwen1.5-110B-Chat</a>
    /// </summary>
    Qwen15Chat110B,

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
    /// Name: Meta Llama 3.1 70B Instruct Turbo <br/>
    /// Organization: Meta <br/>
    /// Context Length: 32768 <br/>
    /// Prompt Cost: $0.88/MTok <br/>
    /// Completion Cost: $0.88/MTok <br/>
    /// Description: Llama 3.1 is an auto-regressive language model that uses an optimized transformer architecture. The tuned versions use supervised fine-tuning (SFT) and reinforcement learning with human feedback (RLHF) to align with human preferences for helpfulness and safety. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Meta-Llama-3.1-70B-Instruct-Turbo">https://huggingface.co/meta-llama/Meta-Llama-3.1-70B-Instruct-Turbo</a>
    /// </summary>
    MetaLlama3170BInstructTurbo,

    /// <summary>
    /// Name: Meta Llama 3.1 8B Instruct Turbo <br/>
    /// Organization: Meta <br/>
    /// Context Length: 32768 <br/>
    /// Prompt Cost: $0.18/MTok <br/>
    /// Completion Cost: $0.18/MTok <br/>
    /// Description: Llama 3.1 is an auto-regressive language model that uses an optimized transformer architecture. The tuned versions use supervised fine-tuning (SFT) and reinforcement learning with human feedback (RLHF) to align with human preferences for helpfulness and safety. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Meta-Llama-3.1-8B-Instruct-Turbo">https://huggingface.co/meta-llama/Meta-Llama-3.1-8B-Instruct-Turbo</a>
    /// </summary>
    MetaLlama318BInstructTurbo,

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
    /// Name: Meta Llama 3.1 405B Instruct Turbo <br/>
    /// Organization: Meta <br/>
    /// Context Length: 4096 <br/>
    /// Prompt Cost: $5/MTok <br/>
    /// Completion Cost: $5/MTok <br/>
    /// Description: Llama 3.1 is an auto-regressive language model that uses an optimized transformer architecture. The tuned versions use supervised fine-tuning (SFT) and reinforcement learning with human feedback (RLHF) to align with human preferences for helpfulness and safety. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Meta-Llama-3.1-405B-Instruct-Turbo">https://huggingface.co/meta-llama/Meta-Llama-3.1-405B-Instruct-Turbo</a>
    /// </summary>
    MetaLlama31405BInstructTurbo,

    /// <summary>
    /// Name: Meta Llama 3 70B Instruct Reference <br/>
    /// Organization: Meta <br/>
    /// Context Length: 8192 <br/>
    /// Prompt Cost: $0.9/MTok <br/>
    /// Completion Cost: $0.9/MTok <br/>
    /// Description: Llama 3 is an auto-regressive language model that uses an optimized transformer architecture. The tuned versions use supervised fine-tuning (SFT) and reinforcement learning with human feedback (RLHF) to align with human preferences for helpfulness and safety. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Llama-3-70b-chat-hf">https://huggingface.co/meta-llama/Llama-3-70b-chat-hf</a>
    /// </summary>
    MetaLlama370BInstructReference,

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
    /// Name: Meta Llama 3.1 8B Instruct <br/>
    /// Organization: Meta <br/>
    /// Context Length: 16384 <br/>
    /// Prompt Cost: $0.2/MTok <br/>
    /// Completion Cost: $0.2/MTok <br/>
    /// Description: Llama 3.1 is an auto-regressive language model that uses an optimized transformer architecture. The tuned versions use supervised fine-tuning (SFT) and reinforcement learning with human feedback (RLHF) to align with human preferences for helpfulness and safety. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Meta-Llama-3.1-8B-Instruct-Reference">https://huggingface.co/meta-llama/Meta-Llama-3.1-8B-Instruct-Reference</a>
    /// </summary>
    MetaLlama318BInstruct,

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
    /// Name: Gryphe MythoMax L2 Lite (13B) <br/>
    /// Organization: Gryphe <br/>
    /// Context Length: 4096 <br/>
    /// Prompt Cost: $0.2/MTok <br/>
    /// Completion Cost: $0.2/MTok <br/>
    /// Description: MythoLogic-L2 and Huginn merge using a highly experimental tensor type merge technique. The main difference with MythoMix is that I allowed more of Huginn to intermingle with the single tensors located at the front and end of a model <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/Gryphe/MythoMax-L2-13b-Lite">https://huggingface.co/Gryphe/MythoMax-L2-13b-Lite</a>
    /// </summary>
    GrypheMythomaxL2Lite13B,

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
    /// Name: LLaVa-Next (Mistral-7B) <br/>
    /// Organization: Haotian Liu <br/>
    /// Context Length: 4096 <br/>
    /// Prompt Cost: $0.18/MTok <br/>
    /// Completion Cost: $0.18/MTok <br/>
    /// Description: LLaVa combines a pre-trained large language model with a pre-trained vision encoder for multimodal chatbot use cases. LLaVA 1.6 improves on LLaVA 1.5 <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/llava-hf/llava-v1.6-mistral-7b-hf">https://huggingface.co/llava-hf/llava-v1.6-mistral-7b-hf</a>
    /// </summary>
    LlavaNextMistral7B,

    /// <summary>
    /// Name: WizardLM v1.2 (13B) <br/>
    /// Organization: WizardLM <br/>
    /// Context Length: 4096 <br/>
    /// Prompt Cost: $0.2/MTok <br/>
    /// Completion Cost: $0.2/MTok <br/>
    /// Description: This model achieves a substantial and comprehensive improvement on coding, mathematical reasoning and open-domain conversation capacities <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/WizardLM/WizardLM-13B-V1.2">https://huggingface.co/WizardLM/WizardLM-13B-V1.2</a>
    /// </summary>
    WizardlmV1213B,

    /// <summary>
    /// Name: Qwen 2 Instruct (1.5B) <br/>
    /// Organization: Qwen <br/>
    /// Context Length: 32768 <br/>
    /// Prompt Cost: $0.02/MTok <br/>
    /// Completion Cost: $0.02/MTok <br/>
    /// Description: Qwen2 is the new series of Qwen large language models. For Qwen2, we release a number of base language models and instruction-tuned language models ranging from 0.5 to 72 billion parameters, including a Mixture-of-Experts model. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/Qwen/Qwen2-1.5B-Instruct">https://huggingface.co/Qwen/Qwen2-1.5B-Instruct</a>
    /// </summary>
    Qwen2Instruct15B,

    /// <summary>
    /// Name: OpenHermes-2-Mistral (7B) <br/>
    /// Organization: teknium <br/>
    /// Context Length: 8192 <br/>
    /// Prompt Cost: $0.2/MTok <br/>
    /// Completion Cost: $0.2/MTok <br/>
    /// Description: State of the art Mistral Fine-tuned on extensive public datasets <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/teknium/OpenHermes-2-Mistral-7B">https://huggingface.co/teknium/OpenHermes-2-Mistral-7B</a>
    /// </summary>
    OpenHermes2Mistral7B,

    /// <summary>
    /// Name: Qwen 2 Instruct (7B) <br/>
    /// Organization: Qwen <br/>
    /// Context Length: 32768 <br/>
    /// Prompt Cost: $0.9/MTok <br/>
    /// Completion Cost: $0.9/MTok <br/>
    /// Description: Qwen2 is the new series of Qwen large language models. For Qwen2, we release a number of base language models and instruction-tuned language models ranging from 0.5 to 72 billion parameters, including a Mixture-of-Experts model. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/Qwen/Qwen2-7B-Instruct">https://huggingface.co/Qwen/Qwen2-7B-Instruct</a>
    /// </summary>
    Qwen2Instruct7B,

    /// <summary>
    /// Name: ReMM SLERP L2 (13B) <br/>
    /// Organization: Undi95 <br/>
    /// Context Length: 4096 <br/>
    /// Prompt Cost: $0.3/MTok <br/>
    /// Completion Cost: $0.3/MTok <br/>
    /// Description: Re:MythoMax (ReMM) is a recreation trial of the original MythoMax-L2-B13 with updated models. This merge use SLERP [TESTING] to merge ReML and Huginn v1.2. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/Undi95/ReMM-SLERP-L2-13B">https://huggingface.co/Undi95/ReMM-SLERP-L2-13B</a>
    /// </summary>
    RemmSlerpL213B,

    /// <summary>
    /// Name: Toppy M (7B) <br/>
    /// Organization: Undi95 <br/>
    /// Context Length: 4096 <br/>
    /// Prompt Cost: $0.2/MTok <br/>
    /// Completion Cost: $0.2/MTok <br/>
    /// Description: A merge of models built by Undi95 with the new task_arithmetic merge method from mergekit. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/Undi95/Toppy-M-7B">https://huggingface.co/Undi95/Toppy-M-7B</a>
    /// </summary>
    ToppyM7B,

    /// <summary>
    /// Name: Phind Code LLaMA v2 (34B) <br/>
    /// Organization: Phind <br/>
    /// Context Length: 16384 <br/>
    /// Prompt Cost: $0.8/MTok <br/>
    /// Completion Cost: $0.8/MTok <br/>
    /// Description: Phind-CodeLlama-34B-v1 trained on additional 1.5B tokens high-quality programming-related data proficient in Python, C/C++, TypeScript, Java, and more. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/Phind/Phind-CodeLlama-34B-v2">https://huggingface.co/Phind/Phind-CodeLlama-34B-v2</a>
    /// </summary>
    PhindCodeLlamaV234B,

    /// <summary>
    /// Name: OpenChat 3.5 <br/>
    /// Organization: OpenChat <br/>
    /// Context Length: 8192 <br/>
    /// Prompt Cost: $0.2/MTok <br/>
    /// Completion Cost: $0.2/MTok <br/>
    /// Description: A merge of OpenChat 3.5 was trained with C-RLFT on a collection of publicly available high-quality instruction data, with a custom processing pipeline. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/openchat/openchat-3.5-1210">https://huggingface.co/openchat/openchat-3.5-1210</a>
    /// </summary>
    OpenChat35,

    /// <summary>
    /// Name: Chronos Hermes (13B) <br/>
    /// Organization: Austism <br/>
    /// Context Length: 2048 <br/>
    /// Prompt Cost: $0.3/MTok <br/>
    /// Completion Cost: $0.3/MTok <br/>
    /// Description: This model is a 75/25 merge of Chronos (13B) and Nous Hermes (13B) models resulting in having a great ability to produce evocative storywriting and follow a narrative. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/Austism/chronos-hermes-13b">https://huggingface.co/Austism/chronos-hermes-13b</a>
    /// </summary>
    ChronosHermes13B,

    /// <summary>
    /// Name: Snorkel Mistral PairRM DPO (7B) <br/>
    /// Organization: Snorkel AI <br/>
    /// Context Length: 32768 <br/>
    /// Prompt Cost: $0.2/MTok <br/>
    /// Completion Cost: $0.2/MTok <br/>
    /// Description: A state-of-the-art model by Snorkel AI, DPO fine-tuned on Mistral-7B <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/snorkelai/Snorkel-Mistral-PairRM-DPO">https://huggingface.co/snorkelai/Snorkel-Mistral-PairRM-DPO</a>
    /// </summary>
    SnorkelMistralPairrmDpo7B,

    /// <summary>
    /// Name: Qwen 1.5 Chat (14B) <br/>
    /// Organization: Qwen <br/>
    /// Context Length: 32768 <br/>
    /// Prompt Cost: $0.3/MTok <br/>
    /// Completion Cost: $0.3/MTok <br/>
    /// Description: Qwen1.5 is the beta version of Qwen2, a transformer-based decoder-only language model pretrained on a large amount of data. In comparison with the previous released Qwen. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/Qwen/Qwen1.5-14B-Chat">https://huggingface.co/Qwen/Qwen1.5-14B-Chat</a>
    /// </summary>
    Qwen15Chat14B,

    /// <summary>
    /// Name: Qwen 1.5 Chat (1.8B) <br/>
    /// Organization: Qwen <br/>
    /// Context Length: 32768 <br/>
    /// Prompt Cost: $0.1/MTok <br/>
    /// Completion Cost: $0.1/MTok <br/>
    /// Description: Qwen1.5 is the beta version of Qwen2, a transformer-based decoder-only language model pretrained on a large amount of data. In comparison with the previous released Qwen. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/Qwen/Qwen1.5-1.8B-Chat">https://huggingface.co/Qwen/Qwen1.5-1.8B-Chat</a>
    /// </summary>
    Qwen15Chat18B,

    /// <summary>
    /// Name: Snowflake Arctic Instruct <br/>
    /// Organization: Snowflake <br/>
    /// Context Length: 4096 <br/>
    /// Prompt Cost: $2.4/MTok <br/>
    /// Completion Cost: $2.4/MTok <br/>
    /// Description: Arctic is a dense-MoE Hybrid transformer architecture pre-trained from scratch by the Snowflake AI Research Team. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/Snowflake/snowflake-arctic-instruct">https://huggingface.co/Snowflake/snowflake-arctic-instruct</a>
    /// </summary>
    SnowflakeArcticInstruct,

    /// <summary>
    /// Name: Nous Hermes 2 - Mixtral 8x7B-SFT <br/>
    /// Organization: NousResearch <br/>
    /// Context Length: 32768 <br/>
    /// Prompt Cost: $0.6/MTok <br/>
    /// Completion Cost: $0.6/MTok <br/>
    /// Description: Nous Hermes 2 Mixtral 7bx8 SFT is the new flagship Nous Research model trained over the Mixtral 7bx8 MoE LLM. The model was trained on over 1,000,000 entries of primarily GPT-4 generated data, as well as other high quality data from open datasets across the AI landscape, achieving state of the art performance on a variety of tasks. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/NousResearch/Nous-Hermes-2-Mixtral-8x7B-SFT">https://huggingface.co/NousResearch/Nous-Hermes-2-Mixtral-8x7B-SFT</a>
    /// </summary>
    NousHermes2Mixtral8X7BSft,

    /// <summary>
    /// Name: Deepseek Coder Instruct (33B) <br/>
    /// Organization: DeepSeek <br/>
    /// Context Length: 16384 <br/>
    /// Prompt Cost: $0.8/MTok <br/>
    /// Completion Cost: $0.8/MTok <br/>
    /// Description: Deepseek Coder is composed of a series of code language models, each trained from scratch on 2T tokens, with a composition of 87% code and 13% natural language in both English and Chinese. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/deepseek-ai/deepseek-coder-33b-instruct">https://huggingface.co/deepseek-ai/deepseek-coder-33b-instruct</a>
    /// </summary>
    DeepseekCoderInstruct33B,

    /// <summary>
    /// Name: Code Llama Python (34B) <br/>
    /// Organization: Meta <br/>
    /// Context Length: 16384 <br/>
    /// Prompt Cost: $0.776/MTok <br/>
    /// Completion Cost: $0.776/MTok <br/>
    /// Description: Code Llama is a family of large language models for code based on Llama 2 providing infilling capabilities, support for large input contexts, and zero-shot instruction following ability for programming tasks. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/codellama/CodeLlama-34b-Python-hf">https://huggingface.co/codellama/CodeLlama-34b-Python-hf</a>
    /// </summary>
    CodeLlamaPython34B,

    /// <summary>
    /// Name: Nous Hermes Llama-2 (13B) <br/>
    /// Organization: NousResearch <br/>
    /// Context Length: 4096 <br/>
    /// Prompt Cost: $0.3/MTok <br/>
    /// Completion Cost: $0.3/MTok <br/>
    /// Description: Nous-Hermes-Llama2-13b is a state-of-the-art language model fine-tuned on over 300,000 instructions. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/NousResearch/Nous-Hermes-Llama2-13b">https://huggingface.co/NousResearch/Nous-Hermes-Llama2-13b</a>
    /// </summary>
    NousHermesLlama213B,

    /// <summary>
    /// Name: Vicuna v1.5 (13B) <br/>
    /// Organization: LM Sys <br/>
    /// Context Length: 4096 <br/>
    /// Prompt Cost: $0.3/MTok <br/>
    /// Completion Cost: $0.3/MTok <br/>
    /// Description: Vicuna is a chat assistant trained by fine-tuning Llama 2 on user-shared conversations collected from ShareGPT. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/lmsys/vicuna-13b-v1.5">https://huggingface.co/lmsys/vicuna-13b-v1.5</a>
    /// </summary>
    VicunaV1513B,

    /// <summary>
    /// Name: Code Llama Python (70B) <br/>
    /// Organization: Meta <br/>
    /// Context Length: 4096 <br/>
    /// Prompt Cost: $0.9/MTok <br/>
    /// Completion Cost: $0.9/MTok <br/>
    /// Description: Code Llama is a family of large language models for code based on Llama 2 providing infilling capabilities, support for large input contexts, and zero-shot instruction following ability for programming tasks. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/codellama/CodeLlama-70b-Python-hf">https://huggingface.co/codellama/CodeLlama-70b-Python-hf</a>
    /// </summary>
    CodeLlamaPython70B,

    /// <summary>
    /// Name: Code Llama Instruct (13B) <br/>
    /// Organization: Meta <br/>
    /// Context Length: 16384 <br/>
    /// Prompt Cost: $0.22/MTok <br/>
    /// Completion Cost: $0.22/MTok <br/>
    /// Description: Code Llama is a family of large language models for code based on Llama 2 providing infilling capabilities, support for large input contexts, and zero-shot instruction following ability for programming tasks. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/codellama/CodeLlama-13b-Instruct-hf">https://huggingface.co/codellama/CodeLlama-13b-Instruct-hf</a>
    /// </summary>
    CodeLlamaInstruct13B,

    /// <summary>
    /// Name: WizardCoder Python v1.0 (34B) <br/>
    /// Organization: WizardLM <br/>
    /// Context Length: 8192 <br/>
    /// Prompt Cost: $0.8/MTok <br/>
    /// Completion Cost: $0.8/MTok <br/>
    /// Description: This model empowers Code LLMs with complex instruction fine-tuning, by adapting the Evol-Instruct method to the domain of code. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/WizardLM/WizardCoder-Python-34B-V1.0">https://huggingface.co/WizardLM/WizardCoder-Python-34B-V1.0</a>
    /// </summary>
    WizardcoderPythonV1034B,

    /// <summary>
    /// Name: Nous Hermes 2 - Mistral DPO (7B) <br/>
    /// Organization: NousResearch <br/>
    /// Context Length: 32768 <br/>
    /// Prompt Cost: $0.2/MTok <br/>
    /// Completion Cost: $0.2/MTok <br/>
    /// Description: Nous Hermes 2 on Mistral 7B DPO is the new flagship 7B Hermes! This model was DPO'd from Teknium/OpenHermes-2.5-Mistral-7B and has improved across the board on all benchmarks tested - AGIEval, BigBench Reasoning, GPT4All, and TruthfulQA. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/NousResearch/Nous-Hermes-2-Mistral-7B-DPO">https://huggingface.co/NousResearch/Nous-Hermes-2-Mistral-7B-DPO</a>
    /// </summary>
    NousHermes2MistralDpo7B,

    /// <summary>
    /// Name: Alpaca (7B) <br/>
    /// Organization: Stanford <br/>
    /// Context Length: 2048 <br/>
    /// Prompt Cost: $0.2/MTok <br/>
    /// Completion Cost: $0.2/MTok <br/>
    /// Description: Fine-tuned from the LLaMA 7B model on 52K instruction-following demonstrations.  <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/togethercomputer/alpaca-7b">https://huggingface.co/togethercomputer/alpaca-7b</a>
    /// </summary>
    Alpaca7B,

    /// <summary>
    /// Name: Platypus2 Instruct (70B) <br/>
    /// Organization: garage-bAInd <br/>
    /// Context Length: 4096 <br/>
    /// Prompt Cost: $0.9/MTok <br/>
    /// Completion Cost: $0.9/MTok <br/>
    /// Description: An instruction fine-tuned LLaMA-2 (70B) model by merging Platypus2 (70B) by garage-bAInd and LLaMA-2 Instruct v2 (70B) by upstage. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/garage-bAInd/Platypus2-70B-instruct">https://huggingface.co/garage-bAInd/Platypus2-70B-instruct</a>
    /// </summary>
    Platypus2Instruct70B,

    /// <summary>
    /// Name: Gemma Instruct (7B) <br/>
    /// Organization: Google <br/>
    /// Context Length: 8192 <br/>
    /// Prompt Cost: $0.2/MTok <br/>
    /// Completion Cost: $0.2/MTok <br/>
    /// Description: Gemma is a family of lightweight, state-of-the-art open models from Google, built from the same research and technology used to create the Gemini models. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/google/gemma-7b-it">https://huggingface.co/google/gemma-7b-it</a>
    /// </summary>
    GemmaInstruct7B,

    /// <summary>
    /// Name: OLMo Instruct (7B) <br/>
    /// Organization: AllenAI <br/>
    /// Context Length: 2048 <br/>
    /// Prompt Cost: $0.2/MTok <br/>
    /// Completion Cost: $0.2/MTok <br/>
    /// Description: The OLMo models are trained on the Dolma dataset <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/allenai/OLMo-7B-Instruct">https://huggingface.co/allenai/OLMo-7B-Instruct</a>
    /// </summary>
    OlmoInstruct7B,

    /// <summary>
    /// Name: Upstage SOLAR Instruct v1 (11B)-Int4 <br/>
    /// Organization: upstage <br/>
    /// Context Length: 4096 <br/>
    /// Prompt Cost: $0.3/MTok <br/>
    /// Completion Cost: $0.3/MTok <br/>
    /// Description: Built on the Llama2 architecture, SOLAR-10.7B incorporates the innovative Upstage Depth Up-Scaling <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/togethercomputer/SOLAR-10.7B-Instruct-v1.0-int4">https://huggingface.co/togethercomputer/SOLAR-10.7B-Instruct-v1.0-int4</a>
    /// </summary>
    UpstageSolarInstructV111BInt4,

    /// <summary>
    /// Name: OpenOrca Mistral (7B) 8K <br/>
    /// Organization: OpenOrca <br/>
    /// Context Length: 8192 <br/>
    /// Prompt Cost: $0.2/MTok <br/>
    /// Completion Cost: $0.2/MTok <br/>
    /// Description: An OpenOrca dataset fine-tune on top of Mistral 7B by the OpenOrca team. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/Open-Orca/Mistral-7B-OpenOrca">https://huggingface.co/Open-Orca/Mistral-7B-OpenOrca</a>
    /// </summary>
    OpenOrcaMistral7B8K,

    /// <summary>
    /// Name: Nous Hermes LLaMA-2 (7B) <br/>
    /// Organization: NousResearch <br/>
    /// Context Length: 4096 <br/>
    /// Prompt Cost: $0.2/MTok <br/>
    /// Completion Cost: $0.2/MTok <br/>
    /// Description: Nous-Hermes-Llama2-7b is a state-of-the-art language model fine-tuned on over 300,000 instructions. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/NousResearch/Nous-Hermes-llama-2-7b">https://huggingface.co/NousResearch/Nous-Hermes-llama-2-7b</a>
    /// </summary>
    NousHermesLlama27B,

    /// <summary>
    /// Name: Qwen 1.5 Chat (32B) <br/>
    /// Organization: Qwen <br/>
    /// Context Length: 32768 <br/>
    /// Prompt Cost: $0.8/MTok <br/>
    /// Completion Cost: $0.8/MTok <br/>
    /// Description: Qwen1.5 is the beta version of Qwen2, a transformer-based decoder-only language model pretrained on a large amount of data. In comparison with the previous released Qwen. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/Qwen/Qwen1.5-32B-Chat">https://huggingface.co/Qwen/Qwen1.5-32B-Chat</a>
    /// </summary>
    Qwen15Chat32B,

    /// <summary>
    /// Name: Nous Capybara v1.9 (7B) <br/>
    /// Organization: NousResearch <br/>
    /// Context Length: 8192 <br/>
    /// Prompt Cost: $0.2/MTok <br/>
    /// Completion Cost: $0.2/MTok <br/>
    /// Description: first Nous collection of dataset and models made by fine-tuning mostly on data created by Nous in-house <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/NousResearch/Nous-Capybara-7B-V1p9">https://huggingface.co/NousResearch/Nous-Capybara-7B-V1p9</a>
    /// </summary>
    NousCapybaraV197B,

    /// <summary>
    /// Name: Meta Llama 3 8B Instruct <br/>
    /// Organization: Meta <br/>
    /// Context Length: 8192 <br/>
    /// Prompt Cost: $0.2/MTok <br/>
    /// Completion Cost: $0.2/MTok <br/>
    /// Description: Llama 3 is an auto-regressive language model that uses an optimized transformer architecture. The tuned versions use supervised fine-tuning (SFT) and reinforcement learning with human feedback (RLHF) to align with human preferences for helpfulness and safety. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Meta-Llama-3-8B-Instruct">https://huggingface.co/meta-llama/Meta-Llama-3-8B-Instruct</a>
    /// </summary>
    MetaLlama38BInstruct,

    /// <summary>
    /// Name: Vicuna v1.5 (7B) <br/>
    /// Organization: LM Sys <br/>
    /// Context Length: 4096 <br/>
    /// Prompt Cost: $0.2/MTok <br/>
    /// Completion Cost: $0.2/MTok <br/>
    /// Description: Vicuna is a chat assistant trained by fine-tuning Llama 2 on user-shared conversations collected from ShareGPT. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/lmsys/vicuna-7b-v1.5">https://huggingface.co/lmsys/vicuna-7b-v1.5</a>
    /// </summary>
    VicunaV157B,

    /// <summary>
    /// Name: 01-ai Yi Chat (34B) <br/>
    /// Organization: 01.AI <br/>
    /// Context Length: 4096 <br/>
    /// Prompt Cost: $0.8/MTok <br/>
    /// Completion Cost: $0.8/MTok <br/>
    /// Description: The Yi series models are large language models trained from scratch by developers at 01.AI <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/zero-one-ai/Yi-34B-Chat">https://huggingface.co/zero-one-ai/Yi-34B-Chat</a>
    /// </summary>
    _01AiYiChat34B,

    /// <summary>
    /// Name: Meta Llama 3 70B Instruct <br/>
    /// Organization: Meta <br/>
    /// Context Length: 8192 <br/>
    /// Prompt Cost: $0.9/MTok <br/>
    /// Completion Cost: $0.9/MTok <br/>
    /// Description: Llama 3 is an auto-regressive language model that uses an optimized transformer architecture. The tuned versions use supervised fine-tuning (SFT) and reinforcement learning with human feedback (RLHF) to align with human preferences for helpfulness and safety. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Meta-Llama-3-70B-Instruct">https://huggingface.co/meta-llama/Meta-Llama-3-70B-Instruct</a>
    /// </summary>
    MetaLlama370BInstruct,

    /// <summary>
    /// Name: Code Llama (70B) <br/>
    /// Organization: Meta <br/>
    /// Context Length: 16384 <br/>
    /// Prompt Cost: $0.9/MTok <br/>
    /// Completion Cost: $0.9/MTok <br/>
    /// Description: Code Llama is a family of large language models for code based on Llama 2 providing infilling capabilities, support for large input contexts, and zero-shot instruction following ability for programming tasks. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/codellama/CodeLlama-70b-hf">https://huggingface.co/codellama/CodeLlama-70b-hf</a>
    /// </summary>
    CodeLlama70B,

    /// <summary>
    /// Name: Code Llama Instruct (70B) <br/>
    /// Organization: Meta <br/>
    /// Context Length: 4096 <br/>
    /// Prompt Cost: $0.9/MTok <br/>
    /// Completion Cost: $0.9/MTok <br/>
    /// Description: Code Llama is a family of large language models for code based on Llama 2 providing infilling capabilities, support for large input contexts, and zero-shot instruction following ability for programming tasks. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/codellama/CodeLlama-70b-Instruct-hf">https://huggingface.co/codellama/CodeLlama-70b-Instruct-hf</a>
    /// </summary>
    CodeLlamaInstruct70B,

    /// <summary>
    /// Name: Hermes 2 Theta Llama-3 70B <br/>
    /// Organization: NousResearch <br/>
    /// Context Length: 8192 <br/>
    /// Prompt Cost: $0/MTok <br/>
    /// Completion Cost: $0/MTok <br/>
    /// Description: Hermes-2 Θ (Theta) 70B is the continuation of our experimental merged model released by Nous Research, in collaboration with Charles Goddard and Arcee AI, the team behind MergeKit. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/NousResearch/Hermes-2-Theta-Llama-3-70B">https://huggingface.co/NousResearch/Hermes-2-Theta-Llama-3-70B</a>
    /// </summary>
    Hermes2ThetaLlama370B,

    /// <summary>
    /// Name: Qwen 1.5 Chat (7B) <br/>
    /// Organization: Qwen <br/>
    /// Context Length: 32768 <br/>
    /// Prompt Cost: $0.2/MTok <br/>
    /// Completion Cost: $0.2/MTok <br/>
    /// Description: Qwen1.5 is the beta version of Qwen2, a transformer-based decoder-only language model pretrained on a large amount of data. In comparison with the previous released Qwen. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/Qwen/Qwen1.5-7B-Chat">https://huggingface.co/Qwen/Qwen1.5-7B-Chat</a>
    /// </summary>
    Qwen15Chat7B,

    /// <summary>
    /// Name: Dolphin 2.5 Mixtral 8x7b <br/>
    /// Organization: cognitivecomputations <br/>
    /// Context Length: 32768 <br/>
    /// Prompt Cost: $0.6/MTok <br/>
    /// Completion Cost: $0.6/MTok <br/>
    /// Description: This Dolphin is really good at coding, I trained with a lot of coding data. It is very obedient but it is not DPO tuned - so you still might need to encourage it in the system prompt as I show in the below examples. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/cognitivecomputations/dolphin-2.5-mixtral-8x7b">https://huggingface.co/cognitivecomputations/dolphin-2.5-mixtral-8x7b</a>
    /// </summary>
    Dolphin25Mixtral8X7B,

    /// <summary>
    /// Name: Code Llama Python (13B) <br/>
    /// Organization: Meta <br/>
    /// Context Length: 16384 <br/>
    /// Prompt Cost: $0.22/MTok <br/>
    /// Completion Cost: $0.22/MTok <br/>
    /// Description: Code Llama is a family of large language models for code based on Llama 2 providing infilling capabilities, support for large input contexts, and zero-shot instruction following ability for programming tasks. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/codellama/CodeLlama-13b-Python-hf">https://huggingface.co/codellama/CodeLlama-13b-Python-hf</a>
    /// </summary>
    CodeLlamaPython13B,

    /// <summary>
    /// Name: Qwen 1.5 Chat (0.5B) <br/>
    /// Organization: Qwen <br/>
    /// Context Length: 32768 <br/>
    /// Prompt Cost: $0.1/MTok <br/>
    /// Completion Cost: $0.1/MTok <br/>
    /// Description: Qwen1.5 is the beta version of Qwen2, a transformer-based decoder-only language model pretrained on a large amount of data. In comparison with the previous released Qwen. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/Qwen/Qwen1.5-0.5B-Chat">https://huggingface.co/Qwen/Qwen1.5-0.5B-Chat</a>
    /// </summary>
    Qwen15Chat05B,

    /// <summary>
    /// Name: Code Llama Instruct (7B) <br/>
    /// Organization: Meta <br/>
    /// Context Length: 16384 <br/>
    /// Prompt Cost: $0.2/MTok <br/>
    /// Completion Cost: $0.2/MTok <br/>
    /// Description: Code Llama is a family of large language models for code based on Llama 2 providing infilling capabilities, support for large input contexts, and zero-shot instruction following ability for programming tasks. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/codellama/CodeLlama-7b-Instruct-hf">https://huggingface.co/codellama/CodeLlama-7b-Instruct-hf</a>
    /// </summary>
    CodeLlamaInstruct7B,

    /// <summary>
    /// Name: OpenHermes-2.5-Mistral (7B) <br/>
    /// Organization: teknium <br/>
    /// Context Length: 8192 <br/>
    /// Prompt Cost: $0.2/MTok <br/>
    /// Completion Cost: $0.2/MTok <br/>
    /// Description: Continuation of OpenHermes 2 Mistral model trained on additional code datasets <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/teknium/OpenHermes-2p5-Mistral-7B">https://huggingface.co/teknium/OpenHermes-2p5-Mistral-7B</a>
    /// </summary>
    OpenHermes25Mistral7B,

    /// <summary>
    /// Name: Qwen 1.5 Chat (4B) <br/>
    /// Organization: Qwen <br/>
    /// Context Length: 32768 <br/>
    /// Prompt Cost: $0.1/MTok <br/>
    /// Completion Cost: $0.1/MTok <br/>
    /// Description: Qwen1.5 is the beta version of Qwen2, a transformer-based decoder-only language model pretrained on a large amount of data. In comparison with the previous released Qwen. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/Qwen/Qwen1.5-4B-Chat">https://huggingface.co/Qwen/Qwen1.5-4B-Chat</a>
    /// </summary>
    Qwen15Chat4B,

    /// <summary>
    /// Name: LLaMA-2 Chat (70B) <br/>
    /// Organization: Meta <br/>
    /// Context Length: 4096 <br/>
    /// Prompt Cost: $0.9/MTok <br/>
    /// Completion Cost: $0.9/MTok <br/>
    /// Description: Llama 2-chat leverages publicly available instruction datasets and over 1 million human annotations. Available in three sizes: 7B, 13B and 70B parameters <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Llama-2-70b-chat-hf">https://huggingface.co/meta-llama/Llama-2-70b-chat-hf</a>
    /// </summary>
    Llama2Chat70B,

    /// <summary>
    /// Name: Code Llama Python (7B) <br/>
    /// Organization: Meta <br/>
    /// Context Length: 16384 <br/>
    /// Prompt Cost: $0.2/MTok <br/>
    /// Completion Cost: $0.2/MTok <br/>
    /// Description: Code Llama is a family of large language models for code based on Llama 2 providing infilling capabilities, support for large input contexts, and zero-shot instruction following ability for programming tasks. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/codellama/CodeLlama-7b-Python-hf">https://huggingface.co/codellama/CodeLlama-7b-Python-hf</a>
    /// </summary>
    CodeLlamaPython7B,

    /// <summary>
    /// Name: carson ml318br <br/>
    /// Organization: carson <br/>
    /// Context Length: 8192 <br/>
    /// Prompt Cost: $0.2/MTok <br/>
    /// Completion Cost: $0.2/MTok <br/>
    /// Description: carson <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/carson/ml318br">https://huggingface.co/carson/ml318br</a>
    /// </summary>
    CarsonMl318br,

    /// <summary>
    /// Name: Llama-3 70B Instruct Gradient 1048K <br/>
    /// Organization: gradientai <br/>
    /// Context Length: 1048576 <br/>
    /// Prompt Cost: $0/MTok <br/>
    /// Completion Cost: $0/MTok <br/>
    /// Description: This model extends LLama-3 70B's context length from 8k to > 1048K <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/gradientai/Llama-3-70B-Instruct-Gradient-1048k">https://huggingface.co/gradientai/Llama-3-70B-Instruct-Gradient-1048k</a>
    /// </summary>
    Llama370BInstructGradient1048K,

    /// <summary>
    /// Name: Meta Llama 3.1 70B Instruct <br/>
    /// Organization: Meta <br/>
    /// Context Length: 8192 <br/>
    /// Prompt Cost: $0.9/MTok <br/>
    /// Completion Cost: $0.9/MTok <br/>
    /// Description: Llama 3.1 is an auto-regressive language model that uses an optimized transformer architecture. The tuned versions use supervised fine-tuning (SFT) and reinforcement learning with human feedback (RLHF) to align with human preferences for helpfulness and safety. <br/>
    /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Meta-Llama-3.1-70B-Instruct-Reference">https://huggingface.co/meta-llama/Meta-Llama-3.1-70B-Instruct-Reference</a>
    /// </summary>
    MetaLlama3170BInstruct,

}