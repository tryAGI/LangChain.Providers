namespace LangChain.Providers.DeepInfra;

/// <summary>
/// List of all the Predefined DeepInfra Models
/// </summary>
public enum DeepInfraModelIds
{

        /// <summary>
        /// Name: DeepSeek-R1-Turbo <br/>
        /// Organization: deepseek-ai <br/>
        /// Context Length: 32768 <br/>
        /// Prompt Cost: $2/MTok <br/>
        /// Completion Cost: $2/MTok <br/>
        /// Description: We introduce DeepSeek-R1, which incorporates cold-start data before RL. DeepSeek-R1 achieves performance comparable to OpenAI-o1 across math, code, and reasoning tasks.  <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/deepseek-ai/DeepSeek-R1-Turbo">https://huggingface.co/deepseek-ai/DeepSeek-R1-Turbo</a> 
        /// </summary>
        DeepseekR1Turbo,
        
        /// <summary>
        /// Name: DeepSeek-R1 <br/>
        /// Organization: deepseek-ai <br/>
        /// Context Length: 65536 <br/>
        /// Prompt Cost: $0.75/MTok <br/>
        /// Completion Cost: $0.75/MTok <br/>
        /// Description: We introduce DeepSeek-R1, which incorporates cold-start data before RL. DeepSeek-R1 achieves performance comparable to OpenAI-o1 across math, code, and reasoning tasks.  <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/deepseek-ai/DeepSeek-R1">https://huggingface.co/deepseek-ai/DeepSeek-R1</a> 
        /// </summary>
        DeepseekR1,
        
        /// <summary>
        /// Name: DeepSeek-R1-Distill-Llama-70B <br/>
        /// Organization: deepseek-ai <br/>
        /// Context Length: 131072 <br/>
        /// Prompt Cost: $0.23/MTok <br/>
        /// Completion Cost: $0.23/MTok <br/>
        /// Description: DeepSeek-R1-Distill-Llama-70B is a highly efficient language model that leverages knowledge distillation to achieve state-of-the-art performance. This model distills the reasoning patterns of larger models into a smaller, more agile architecture, resulting in exceptional results on benchmarks like AIME 2024, MATH-500, and LiveCodeBench. With 70 billion parameters, DeepSeek-R1-Distill-Llama-70B offers a unique balance of accuracy and efficiency, making it an ideal choice for a wide range of natural language processing tasks.  <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Llama-70B">https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Llama-70B</a> 
        /// </summary>
        DeepseekR1DistillLlama70B,
        
        /// <summary>
        /// Name: DeepSeek-V3 <br/>
        /// Organization: deepseek-ai <br/>
        /// Context Length: 65536 <br/>
        /// Prompt Cost: $0.49/MTok <br/>
        /// Completion Cost: $0.49/MTok <br/>
        /// Description: DeepSeek-V3, a strong Mixture-of-Experts (MoE) language model with 671B total parameters with 37B activated for each token. To achieve efficient inference and cost-effective training, DeepSeek-V3 adopts Multi-head Latent Attention (MLA) and DeepSeekMoE architectures, which were thoroughly validated in DeepSeek-V2.  <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/deepseek-ai/DeepSeek-V3">https://huggingface.co/deepseek-ai/DeepSeek-V3</a> 
        /// </summary>
        DeepseekV3,
        
        /// <summary>
        /// Name: Llama-3.3-70B-Instruct-Turbo <br/>
        /// Organization: meta-llama <br/>
        /// Context Length: 131072 <br/>
        /// Prompt Cost: $0.12/MTok <br/>
        /// Completion Cost: $0.12/MTok <br/>
        /// Description: Llama 3.3-70B Turbo is a highly optimized version of the Llama 3.3-70B model, utilizing FP8 quantization to deliver significantly faster inference speeds with a minor trade-off in accuracy. The model is designed to be helpful, safe, and flexible, with a focus on responsible deployment and mitigating potential risks such as bias, toxicity, and misinformation. It achieves state-of-the-art performance on various benchmarks, including conversational tasks, language translation, and text generation. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Llama-3.3-70B-Instruct-Turbo">https://huggingface.co/meta-llama/Llama-3.3-70B-Instruct-Turbo</a> 
        /// </summary>
        Llama3370BInstructTurbo,
        
        /// <summary>
        /// Name: Llama-3.3-70B-Instruct <br/>
        /// Organization: meta-llama <br/>
        /// Context Length: 131072 <br/>
        /// Prompt Cost: $0.23/MTok <br/>
        /// Completion Cost: $0.23/MTok <br/>
        /// Description: Llama 3.3-70B is a multilingual LLM trained on a massive dataset of 15 trillion tokens, fine-tuned for instruction-following and conversational dialogue. The model is designed to be helpful, safe, and flexible, with a focus on responsible deployment and mitigating potential risks such as bias, toxicity, and misinformation. It achieves state-of-the-art performance on various benchmarks, including conversational tasks, language translation, and text generation. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Llama-3.3-70B-Instruct">https://huggingface.co/meta-llama/Llama-3.3-70B-Instruct</a> 
        /// </summary>
        Llama3370BInstruct,
        
        /// <summary>
        /// Name: Mistral-Small-24B-Instruct-2501 <br/>
        /// Organization: mistralai <br/>
        /// Context Length: 32768 <br/>
        /// Prompt Cost: $0.07/MTok <br/>
        /// Completion Cost: $0.07/MTok <br/>
        /// Description: Mistral Small 3 is a 24B-parameter language model optimized for low-latency performance across common AI tasks. Released under the Apache 2.0 license, it features both pre-trained and instruction-tuned versions designed for efficient local deployment.  The model achieves 81% accuracy on the MMLU benchmark and performs competitively with larger models like Llama 3.3 70B and Qwen 32B, while operating at three times the speed on equivalent hardware. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/mistralai/Mistral-Small-24B-Instruct-2501">https://huggingface.co/mistralai/Mistral-Small-24B-Instruct-2501</a> 
        /// </summary>
        MistralSmall24BInstruct2501,
        
        /// <summary>
        /// Name: DeepSeek-R1-Distill-Qwen-32B <br/>
        /// Organization: deepseek-ai <br/>
        /// Context Length: 131072 <br/>
        /// Prompt Cost: $0.12/MTok <br/>
        /// Completion Cost: $0.12/MTok <br/>
        /// Description: DeepSeek R1 Distill Qwen 32B is a distilled large language model based on Qwen 2.5 32B, using outputs from DeepSeek R1. It outperforms OpenAI's o1-mini across various benchmarks, achieving new state-of-the-art results for dense models.  Other benchmark results include:  AIME 2024: 72.6 | MATH-500: 94.3 | CodeForces Rating: 1691. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-32B">https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-32B</a> 
        /// </summary>
        DeepseekR1DistillQwen32B,
        
        /// <summary>
        /// Name: phi-4 <br/>
        /// Organization: microsoft <br/>
        /// Context Length: 16384 <br/>
        /// Prompt Cost: $0.07/MTok <br/>
        /// Completion Cost: $0.07/MTok <br/>
        /// Description: Phi-4 is a model built upon a blend of synthetic datasets, data from filtered public domain websites, and acquired academic books and Q&amp;A datasets. The goal of this approach was to ensure that small capable models were trained with data focused on high quality and advanced reasoning. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/microsoft/phi-4">https://huggingface.co/microsoft/phi-4</a> 
        /// </summary>
        Phi4,
        
        /// <summary>
        /// Name: Meta-Llama-3.1-70B-Instruct <br/>
        /// Organization: meta-llama <br/>
        /// Context Length: 131072 <br/>
        /// Prompt Cost: $0.23/MTok <br/>
        /// Completion Cost: $0.23/MTok <br/>
        /// Description: Meta developed and released the Meta Llama 3.1 family of large language models (LLMs), a collection of pretrained and instruction tuned generative text models in 8B, 70B and 405B sizes <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Meta-Llama-3.1-70B-Instruct">https://huggingface.co/meta-llama/Meta-Llama-3.1-70B-Instruct</a> 
        /// </summary>
        MetaLlama3170BInstruct,
        
        /// <summary>
        /// Name: Meta-Llama-3.1-8B-Instruct <br/>
        /// Organization: meta-llama <br/>
        /// Context Length: 131072 <br/>
        /// Prompt Cost: $0.03/MTok <br/>
        /// Completion Cost: $0.03/MTok <br/>
        /// Description: Meta developed and released the Meta Llama 3.1 family of large language models (LLMs), a collection of pretrained and instruction tuned generative text models in 8B, 70B and 405B sizes <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Meta-Llama-3.1-8B-Instruct">https://huggingface.co/meta-llama/Meta-Llama-3.1-8B-Instruct</a> 
        /// </summary>
        MetaLlama318BInstruct,
        
        /// <summary>
        /// Name: Meta-Llama-3.1-405B-Instruct <br/>
        /// Organization: meta-llama <br/>
        /// Context Length: 32768 <br/>
        /// Prompt Cost: $0.8/MTok <br/>
        /// Completion Cost: $0.8/MTok <br/>
        /// Description: Meta developed and released the Meta Llama 3.1 family of large language models (LLMs), a collection of pretrained and instruction tuned generative text models in 8B, 70B and 405B sizes <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Meta-Llama-3.1-405B-Instruct">https://huggingface.co/meta-llama/Meta-Llama-3.1-405B-Instruct</a> 
        /// </summary>
        MetaLlama31405BInstruct,
        
        /// <summary>
        /// Name: Meta-Llama-3.1-8B-Instruct-Turbo <br/>
        /// Organization: meta-llama <br/>
        /// Context Length: 131072 <br/>
        /// Prompt Cost: $0.02/MTok <br/>
        /// Completion Cost: $0.02/MTok <br/>
        /// Description: Meta developed and released the Meta Llama 3.1 family of large language models (LLMs), a collection of pretrained and instruction tuned generative text models in 8B, 70B and 405B sizes <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Meta-Llama-3.1-8B-Instruct-Turbo">https://huggingface.co/meta-llama/Meta-Llama-3.1-8B-Instruct-Turbo</a> 
        /// </summary>
        MetaLlama318BInstructTurbo,
        
        /// <summary>
        /// Name: Meta-Llama-3.1-70B-Instruct-Turbo <br/>
        /// Organization: meta-llama <br/>
        /// Context Length: 131072 <br/>
        /// Prompt Cost: $0.12/MTok <br/>
        /// Completion Cost: $0.12/MTok <br/>
        /// Description: Meta developed and released the Meta Llama 3.1 family of large language models (LLMs), a collection of pretrained and instruction tuned generative text models in 8B, 70B and 405B sizes <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Meta-Llama-3.1-70B-Instruct-Turbo">https://huggingface.co/meta-llama/Meta-Llama-3.1-70B-Instruct-Turbo</a> 
        /// </summary>
        MetaLlama3170BInstructTurbo,
        
        /// <summary>
        /// Name: Qwen2.5-Coder-32B-Instruct <br/>
        /// Organization: Qwen <br/>
        /// Context Length: 32768 <br/>
        /// Prompt Cost: $0.07/MTok <br/>
        /// Completion Cost: $0.07/MTok <br/>
        /// Description: Qwen2.5-Coder is the latest series of Code-Specific Qwen large language models (formerly known as CodeQwen). It has significant improvements in code generation, code reasoning and code fixing. A more comprehensive foundation for real-world applications such as Code Agents. Not only enhancing coding capabilities but also maintaining its strengths in mathematics and general competencies. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/Qwen/Qwen2.5-Coder-32B-Instruct">https://huggingface.co/Qwen/Qwen2.5-Coder-32B-Instruct</a> 
        /// </summary>
        Qwen25Coder32BInstruct,
        
        /// <summary>
        /// Name: Llama-3.1-Nemotron-70B-Instruct <br/>
        /// Organization: nvidia <br/>
        /// Context Length: 131072 <br/>
        /// Prompt Cost: $0.12/MTok <br/>
        /// Completion Cost: $0.12/MTok <br/>
        /// Description: Llama-3.1-Nemotron-70B-Instruct is a large language model customized by NVIDIA to improve the helpfulness of LLM generated responses to user queries. This model reaches Arena Hard of 85.0, AlpacaEval 2 LC of 57.6 and GPT-4-Turbo MT-Bench of 8.98, which are known to be predictive of LMSys Chatbot Arena Elo.  As of 16th Oct 2024, this model is #1 on all three automatic alignment benchmarks (verified tab for AlpacaEval 2 LC), edging out strong frontier models such as GPT-4o and Claude 3.5 Sonnet. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/nvidia/Llama-3.1-Nemotron-70B-Instruct">https://huggingface.co/nvidia/Llama-3.1-Nemotron-70B-Instruct</a> 
        /// </summary>
        Llama31Nemotron70BInstruct,
        
        /// <summary>
        /// Name: Qwen2.5-72B-Instruct <br/>
        /// Organization: Qwen <br/>
        /// Context Length: 32768 <br/>
        /// Prompt Cost: $0.13/MTok <br/>
        /// Completion Cost: $0.13/MTok <br/>
        /// Description: Qwen2.5 is a model pretrained on a large-scale dataset of up to 18 trillion tokens, offering significant improvements in knowledge, coding, mathematics, and instruction following compared to its predecessor Qwen2. The model also features enhanced capabilities in generating long texts, understanding structured data, and generating structured outputs, while supporting multilingual capabilities for over 29 languages. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/Qwen/Qwen2.5-72B-Instruct">https://huggingface.co/Qwen/Qwen2.5-72B-Instruct</a> 
        /// </summary>
        Qwen2572BInstruct,
        
        /// <summary>
        /// Name: Llama-3.2-90B-Vision-Instruct <br/>
        /// Organization: meta-llama <br/>
        /// Context Length: 32768 <br/>
        /// Prompt Cost: $0.35/MTok <br/>
        /// Completion Cost: $0.35/MTok <br/>
        /// Description: The Llama 90B Vision model is a top-tier, 90-billion-parameter multimodal model designed for the most challenging visual reasoning and language tasks. It offers unparalleled accuracy in image captioning, visual question answering, and advanced image-text comprehension. Pre-trained on vast multimodal datasets and fine-tuned with human feedback, the Llama 90B Vision is engineered to handle the most demanding image-based AI tasks.  This model is perfect for industries requiring cutting-edge multimodal AI capabilities, particularly those dealing with complex, real-time visual and textual analysis. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Llama-3.2-90B-Vision-Instruct">https://huggingface.co/meta-llama/Llama-3.2-90B-Vision-Instruct</a> 
        /// </summary>
        Llama3290BVisionInstruct,
        
        /// <summary>
        /// Name: Llama-3.2-11B-Vision-Instruct <br/>
        /// Organization: meta-llama <br/>
        /// Context Length: 131072 <br/>
        /// Prompt Cost: $0.06/MTok <br/>
        /// Completion Cost: $0.06/MTok <br/>
        /// Description: Llama 3.2 11B Vision is a multimodal model with 11 billion parameters, designed to handle tasks combining visual and textual data. It excels in tasks such as image captioning and visual question answering, bridging the gap between language generation and visual reasoning. Pre-trained on a massive dataset of image-text pairs, it performs well in complex, high-accuracy image analysis.  Its ability to integrate visual understanding with language processing makes it an ideal solution for industries requiring comprehensive visual-linguistic AI applications, such as content creation, AI-driven customer service, and research. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Llama-3.2-11B-Vision-Instruct">https://huggingface.co/meta-llama/Llama-3.2-11B-Vision-Instruct</a> 
        /// </summary>
        Llama3211BVisionInstruct,
        
        /// <summary>
        /// Name: WizardLM-2-8x22B <br/>
        /// Organization: microsoft <br/>
        /// Context Length: 65536 <br/>
        /// Prompt Cost: $0.5/MTok <br/>
        /// Completion Cost: $0.5/MTok <br/>
        /// Description: WizardLM-2 8x22B is Microsoft AI's most advanced Wizard model. It demonstrates highly competitive performance compared to those leading proprietary models. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/microsoft/WizardLM-2-8x22B">https://huggingface.co/microsoft/WizardLM-2-8x22B</a> 
        /// </summary>
        Wizardlm28X22b,
        
        /// <summary>
        /// Name: Yi-34B-Chat <br/>
        /// Organization: 01-ai <br/>
        /// Context Length: 4096 <br/>
        /// Prompt Cost: $0.6/MTok <br/>
        /// Completion Cost: $0.6/MTok <br/>
        /// Description:  <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/01-ai/Yi-34B-Chat">https://huggingface.co/01-ai/Yi-34B-Chat</a> 
        /// </summary>
        Yi34BChat,
        
        /// <summary>
        /// Name: chronos-hermes-13b-v2 <br/>
        /// Organization: Austism <br/>
        /// Context Length: 4096 <br/>
        /// Prompt Cost: $0.13/MTok <br/>
        /// Completion Cost: $0.13/MTok <br/>
        /// Description: This offers the imaginative writing style of chronos while still retaining coherency and being capable. Outputs are long and utilize exceptional prose. Supports a maxium context length of 4096. The model follows the Alpaca prompt format. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/Austism/chronos-hermes-13b-v2">https://huggingface.co/Austism/chronos-hermes-13b-v2</a> 
        /// </summary>
        ChronosHermes13BV2,
        
        /// <summary>
        /// Name: MythoMax-L2-13b <br/>
        /// Organization: Gryphe <br/>
        /// Context Length: 4096 <br/>
        /// Prompt Cost: $0.06/MTok <br/>
        /// Completion Cost: $0.06/MTok <br/>
        /// Description:  <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/Gryphe/MythoMax-L2-13b">https://huggingface.co/Gryphe/MythoMax-L2-13b</a> 
        /// </summary>
        MythomaxL213B,
        
        /// <summary>
        /// Name: MythoMax-L2-13b-turbo <br/>
        /// Organization: Gryphe <br/>
        /// Context Length: 4096 <br/>
        /// Prompt Cost: $0.13/MTok <br/>
        /// Completion Cost: $0.13/MTok <br/>
        /// Description: Faster version of Gryphe/MythoMax-L2-13b running on multiple H100 cards in fp8 precision. Up to 160 tps.  <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/Gryphe/MythoMax-L2-13b-turbo">https://huggingface.co/Gryphe/MythoMax-L2-13b-turbo</a> 
        /// </summary>
        MythomaxL213BTurbo,
        
        /// <summary>
        /// Name: zephyr-orpo-141b-A35b-v0.1 <br/>
        /// Organization: HuggingFaceH4 <br/>
        /// Context Length: 65536 <br/>
        /// Prompt Cost: $0.65/MTok <br/>
        /// Completion Cost: $0.65/MTok <br/>
        /// Description: Zephyr 141B-A35B is an instruction-tuned (assistant) version of Mixtral-8x22B. It was fine-tuned on a mix of publicly available, synthetic datasets. It achieves strong performance on chat benchmarks. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/HuggingFaceH4/zephyr-orpo-141b-A35b-v0.1">https://huggingface.co/HuggingFaceH4/zephyr-orpo-141b-A35b-v0.1</a> 
        /// </summary>
        ZephyrOrpo141BA35bV01,
        
        /// <summary>
        /// Name: LLaMA2-13B-Tiefighter <br/>
        /// Organization: KoboldAI <br/>
        /// Context Length: 4096 <br/>
        /// Prompt Cost: $0.1/MTok <br/>
        /// Completion Cost: $0.1/MTok <br/>
        /// Description: LLaMA2-13B-Tiefighter is a highly creative and versatile language model, fine-tuned for storytelling, adventure, and conversational dialogue. It combines the strengths of multiple models and datasets, including retro-rodeo and choose-your-own-adventure, to generate engaging and imaginative content. With its ability to improvise and adapt to different styles and formats, Tiefighter is perfect for writers, creators, and anyone looking to spark their imagination. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/KoboldAI/LLaMA2-13B-Tiefighter">https://huggingface.co/KoboldAI/LLaMA2-13B-Tiefighter</a> 
        /// </summary>
        Llama213BTiefighter,
        
        /// <summary>
        /// Name: Hermes-3-Llama-3.1-405B <br/>
        /// Organization: NousResearch <br/>
        /// Context Length: 131072 <br/>
        /// Prompt Cost: $0.8/MTok <br/>
        /// Completion Cost: $0.8/MTok <br/>
        /// Description: Hermes 3 is a cutting-edge language model that offers advanced capabilities in roleplaying, reasoning, and conversation. It's a fine-tuned version of the Llama-3.1 405B foundation model, designed to align with user needs and provide powerful control. Key features include reliable function calling, structured output, generalist assistant capabilities, and improved code generation. Hermes 3 is competitive with Llama-3.1 Instruct models, with its own strengths and weaknesses. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/NousResearch/Hermes-3-Llama-3.1-405B">https://huggingface.co/NousResearch/Hermes-3-Llama-3.1-405B</a> 
        /// </summary>
        Hermes3Llama31405B,
        
        /// <summary>
        /// Name: Sky-T1-32B-Preview <br/>
        /// Organization: NovaSky-AI <br/>
        /// Context Length: 32768 <br/>
        /// Prompt Cost: $0.12/MTok <br/>
        /// Completion Cost: $0.12/MTok <br/>
        /// Description: This is a 32B reasoning model trained from Qwen2.5-32B-Instruct with 17K data. The performance is on par with o1-preview model on both math and coding. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/NovaSky-AI/Sky-T1-32B-Preview">https://huggingface.co/NovaSky-AI/Sky-T1-32B-Preview</a> 
        /// </summary>
        SkyT132BPreview,
        
        /// <summary>
        /// Name: Phind-CodeLlama-34B-v2 <br/>
        /// Organization: Phind <br/>
        /// Context Length: 4096 <br/>
        /// Prompt Cost: $0.6/MTok <br/>
        /// Completion Cost: $0.6/MTok <br/>
        /// Description: Phind-CodeLlama-34B-v2 is an open-source language model that has been fine-tuned on 1.5B tokens of high-quality programming-related data and achieved a pass@1 rate of 73.8% on HumanEval. It is multi-lingual and proficient in Python, C/C++, TypeScript, Java, and more. It has been trained on a proprietary dataset of instruction-answer pairs instead of code completion examples.  The model is instruction-tuned on the Alpaca/Vicuna format to be steerable and easy-to-use. It accepts the Alpaca/Vicuna instruction format and can generate one completion for each prompt. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/Phind/Phind-CodeLlama-34B-v2">https://huggingface.co/Phind/Phind-CodeLlama-34B-v2</a> 
        /// </summary>
        PhindCodellama34BV2,
        
        /// <summary>
        /// Name: QVQ-72B-Preview <br/>
        /// Organization: Qwen <br/>
        /// Context Length: 32000 <br/>
        /// Prompt Cost: $0.25/MTok <br/>
        /// Completion Cost: $0.25/MTok <br/>
        /// Description: QVQ-72B-Preview is an experimental research model developed by the Qwen team, focusing on enhancing visual reasoning capabilities. QVQ-72B-Preview has achieved remarkable performance on various benchmarks. It scored a remarkable 70.3% on the Multimodal Massive Multi-task Understanding (MMMU) benchmark <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/Qwen/QVQ-72B-Preview">https://huggingface.co/Qwen/QVQ-72B-Preview</a> 
        /// </summary>
        Qvq72BPreview,
        
        /// <summary>
        /// Name: QwQ-32B-Preview <br/>
        /// Organization: Qwen <br/>
        /// Context Length: 32768 <br/>
        /// Prompt Cost: $0.12/MTok <br/>
        /// Completion Cost: $0.12/MTok <br/>
        /// Description: QwQ is an experimental research model developed by the Qwen Team, designed to advance AI reasoning capabilities. This model embodies the spirit of philosophical inquiry, approaching problems with genuine wonder and doubt. QwQ demonstrates impressive analytical abilities, achieving scores of 65.2% on GPQA, 50.0% on AIME, 90.6% on MATH-500, and 50.0% on LiveCodeBench. With its contemplative approach and exceptional performance on complex problems. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/Qwen/QwQ-32B-Preview">https://huggingface.co/Qwen/QwQ-32B-Preview</a> 
        /// </summary>
        Qwq32BPreview,
        
        /// <summary>
        /// Name: Qwen2-72B-Instruct <br/>
        /// Organization: Qwen <br/>
        /// Context Length: 32768 <br/>
        /// Prompt Cost: $0.35/MTok <br/>
        /// Completion Cost: $0.35/MTok <br/>
        /// Description: The 72 billion parameter Qwen2 excels in language understanding, multilingual capabilities, coding, mathematics, and reasoning. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/Qwen/Qwen2-72B-Instruct">https://huggingface.co/Qwen/Qwen2-72B-Instruct</a> 
        /// </summary>
        Qwen272BInstruct,
        
        /// <summary>
        /// Name: Qwen2-7B-Instruct <br/>
        /// Organization: Qwen <br/>
        /// Context Length: 32768 <br/>
        /// Prompt Cost: $0.06/MTok <br/>
        /// Completion Cost: $0.06/MTok <br/>
        /// Description: The 7 billion parameter Qwen2 excels in language understanding, multilingual capabilities, coding, mathematics, and reasoning. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/Qwen/Qwen2-7B-Instruct">https://huggingface.co/Qwen/Qwen2-7B-Instruct</a> 
        /// </summary>
        Qwen27BInstruct,
        
        /// <summary>
        /// Name: Qwen2.5-7B-Instruct <br/>
        /// Organization: Qwen <br/>
        /// Context Length: 32768 <br/>
        /// Prompt Cost: $0.02/MTok <br/>
        /// Completion Cost: $0.02/MTok <br/>
        /// Description: The 7 billion parameter Qwen2.5 excels in language understanding, multilingual capabilities, coding, mathematics, and reasoning <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/Qwen/Qwen2.5-7B-Instruct">https://huggingface.co/Qwen/Qwen2.5-7B-Instruct</a> 
        /// </summary>
        Qwen257BInstruct,
        
        /// <summary>
        /// Name: Qwen2.5-Coder-7B <br/>
        /// Organization: Qwen <br/>
        /// Context Length: 32768 <br/>
        /// Prompt Cost: $0.02/MTok <br/>
        /// Completion Cost: $0.02/MTok <br/>
        /// Description: Qwen2.5-Coder-7B is a powerful code-specific large language model with 7.61 billion parameters. It's designed for code generation, reasoning, and fixing tasks. The model covers 92 programming languages and has been trained on 5.5 trillion tokens of data, including source code, text-code grounding, and synthetic data. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/Qwen/Qwen2.5-Coder-7B">https://huggingface.co/Qwen/Qwen2.5-Coder-7B</a> 
        /// </summary>
        Qwen25Coder7B,
        
        /// <summary>
        /// Name: L3-70B-Euryale-v2.1 <br/>
        /// Organization: Sao10K <br/>
        /// Context Length: 8192 <br/>
        /// Prompt Cost: $0.7/MTok <br/>
        /// Completion Cost: $0.7/MTok <br/>
        /// Description: Euryale 70B v2.1 is a model focused on creative roleplay from Sao10k <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/Sao10K/L3-70B-Euryale-v2.1">https://huggingface.co/Sao10K/L3-70B-Euryale-v2.1</a> 
        /// </summary>
        L370BEuryaleV21,
        
        /// <summary>
        /// Name: L3-8B-Lunaris-v1 <br/>
        /// Organization: Sao10K <br/>
        /// Context Length: 8192 <br/>
        /// Prompt Cost: $0.03/MTok <br/>
        /// Completion Cost: $0.03/MTok <br/>
        /// Description: A generalist / roleplaying model merge based on Llama 3. Sao10K has carefully selected the values based on extensive personal experimentation and has fine-tuned them to create a customized recipe. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/Sao10K/L3-8B-Lunaris-v1">https://huggingface.co/Sao10K/L3-8B-Lunaris-v1</a> 
        /// </summary>
        L38BLunarisV1,
        
        /// <summary>
        /// Name: L3.1-70B-Euryale-v2.2 <br/>
        /// Organization: Sao10K <br/>
        /// Context Length: 131072 <br/>
        /// Prompt Cost: $0.7/MTok <br/>
        /// Completion Cost: $0.7/MTok <br/>
        /// Description: Euryale 3.1 - 70B v2.2 is a model focused on creative roleplay from Sao10k <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/Sao10K/L3.1-70B-Euryale-v2.2">https://huggingface.co/Sao10K/L3.1-70B-Euryale-v2.2</a> 
        /// </summary>
        L3170BEuryaleV22,
        
        /// <summary>
        /// Name: L3.3-70B-Euryale-v2.3 <br/>
        /// Organization: Sao10K <br/>
        /// Context Length: 131072 <br/>
        /// Prompt Cost: $0.7/MTok <br/>
        /// Completion Cost: $0.7/MTok <br/>
        /// Description: L3.3-70B-Euryale-v2.3 is a model focused on creative roleplay from Sao10k <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/Sao10K/L3.3-70B-Euryale-v2.3">https://huggingface.co/Sao10K/L3.3-70B-Euryale-v2.3</a> 
        /// </summary>
        L3370BEuryaleV23,
        
        /// <summary>
        /// Name: starcoder2-15b <br/>
        /// Organization: bigcode <br/>
        /// Context Length: 16384 <br/>
        /// Prompt Cost: $0.4/MTok <br/>
        /// Completion Cost: $0.4/MTok <br/>
        /// Description: StarCoder2-15B model is a 15B parameter model trained on 600+ programming languages. It specializes in code completion. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/bigcode/starcoder2-15b">https://huggingface.co/bigcode/starcoder2-15b</a> 
        /// </summary>
        Starcoder215B,
        
        /// <summary>
        /// Name: starcoder2-15b-instruct-v0.1 <br/>
        /// Organization: bigcode <br/>
        /// Context Length:  <br/>
        /// Prompt Cost: $0.15/MTok <br/>
        /// Completion Cost: $0.15/MTok <br/>
        /// Description: We introduce StarCoder2-15B-Instruct-v0.1, the very first entirely self-aligned code Large Language Model (LLM) trained with a fully permissive and transparent pipeline. Our open-source pipeline uses StarCoder2-15B to generate thousands of instruction-response pairs, which are then used to fine-tune StarCoder-15B itself without any human annotations or distilled data from huge and proprietary LLMs. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/bigcode/starcoder2-15b-instruct-v0.1">https://huggingface.co/bigcode/starcoder2-15b-instruct-v0.1</a> 
        /// </summary>
        Starcoder215BInstructV01,
        
        /// <summary>
        /// Name: CodeLlama-34b-Instruct-hf <br/>
        /// Organization: codellama <br/>
        /// Context Length: 4096 <br/>
        /// Prompt Cost: $0.6/MTok <br/>
        /// Completion Cost: $0.6/MTok <br/>
        /// Description: Code Llama is a state-of-the-art LLM capable of generating code, and natural language about code, from both code and natural language prompts. This particular instance is the 34b instruct variant <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/codellama/CodeLlama-34b-Instruct-hf">https://huggingface.co/codellama/CodeLlama-34b-Instruct-hf</a> 
        /// </summary>
        Codellama34BInstructHf,
        
        /// <summary>
        /// Name: CodeLlama-70b-Instruct-hf <br/>
        /// Organization: codellama <br/>
        /// Context Length: 4096 <br/>
        /// Prompt Cost: $0.7/MTok <br/>
        /// Completion Cost: $0.7/MTok <br/>
        /// Description: CodeLlama-70b is the largest and latest code generation from the Code Llama collection.  <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/codellama/CodeLlama-70b-Instruct-hf">https://huggingface.co/codellama/CodeLlama-70b-Instruct-hf</a> 
        /// </summary>
        Codellama70BInstructHf,
        
        /// <summary>
        /// Name: dolphin-2.6-mixtral-8x7b <br/>
        /// Organization: cognitivecomputations <br/>
        /// Context Length: 32768 <br/>
        /// Prompt Cost: $0.24/MTok <br/>
        /// Completion Cost: $0.24/MTok <br/>
        /// Description: The Dolphin 2.6 Mixtral 8x7b model is a finetuned version of the Mixtral-8x7b model, trained on a variety of data including coding data, for 3 days on 4 A100 GPUs. It is uncensored and requires trust_remote_code. The model is very obedient and good at coding, but not DPO tuned. The dataset has been filtered for alignment and bias. The model is compliant with user requests and can be used for various purposes such as generating code or engaging in general chat. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/cognitivecomputations/dolphin-2.6-mixtral-8x7b">https://huggingface.co/cognitivecomputations/dolphin-2.6-mixtral-8x7b</a> 
        /// </summary>
        Dolphin26Mixtral8X7B,
        
        /// <summary>
        /// Name: dolphin-2.9.1-llama-3-70b <br/>
        /// Organization: cognitivecomputations <br/>
        /// Context Length: 8192 <br/>
        /// Prompt Cost: $0.35/MTok <br/>
        /// Completion Cost: $0.35/MTok <br/>
        /// Description: Dolphin 2.9.1, a fine-tuned Llama-3-70b model. The new model, trained on filtered data, is more compliant but uncensored. It demonstrates improvements in instruction, conversation, coding, and function calling abilities. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/cognitivecomputations/dolphin-2.9.1-llama-3-70b">https://huggingface.co/cognitivecomputations/dolphin-2.9.1-llama-3-70b</a> 
        /// </summary>
        Dolphin291Llama370B,
        
        /// <summary>
        /// Name: dbrx-instruct <br/>
        /// Organization: databricks <br/>
        /// Context Length: 32768 <br/>
        /// Prompt Cost: $0.6/MTok <br/>
        /// Completion Cost: $0.6/MTok <br/>
        /// Description: DBRX is an open source LLM created by Databricks. It uses mixture-of-experts (MoE) architecture with 132B total parameters of which 36B parameters are active on any input. It outperforms existing open source LLMs like Llama 2 70B and Mixtral-8x7B on standard industry benchmarks for language understanding, programming, math, and logic. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/databricks/dbrx-instruct">https://huggingface.co/databricks/dbrx-instruct</a> 
        /// </summary>
        DbrxInstruct,
        
        /// <summary>
        /// Name: airoboros-70b <br/>
        /// Organization: deepinfra <br/>
        /// Context Length: 4096 <br/>
        /// Prompt Cost: $0.7/MTok <br/>
        /// Completion Cost: $0.7/MTok <br/>
        /// Description: Latest version of the Airoboros model fine-tunned version of llama-2-70b using the Airoboros dataset. This model is currently running jondurbin/airoboros-l2-70b-2.2.1  <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/deepinfra/airoboros-70b">https://huggingface.co/deepinfra/airoboros-70b</a> 
        /// </summary>
        Airoboros70B,
        
        /// <summary>
        /// Name: codegemma-7b-it <br/>
        /// Organization: google <br/>
        /// Context Length: 8192 <br/>
        /// Prompt Cost: $0.07/MTok <br/>
        /// Completion Cost: $0.07/MTok <br/>
        /// Description: CodeGemma is a collection of lightweight open code models built on top of Gemma. CodeGemma models are text-to-text and text-to-code decoder-only models and are available as a 7 billion pretrained variant that specializes in code completion and code generation tasks, a 7 billion parameter instruction-tuned variant for code chat and instruction following and a 2 billion parameter pretrained variant for fast code completion. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/google/codegemma-7b-it">https://huggingface.co/google/codegemma-7b-it</a> 
        /// </summary>
        Codegemma7BIt,
        
        /// <summary>
        /// Name: gemma-1.1-7b-it <br/>
        /// Organization: google <br/>
        /// Context Length: 8192 <br/>
        /// Prompt Cost: $0.07/MTok <br/>
        /// Completion Cost: $0.07/MTok <br/>
        /// Description: Gemma is an open-source model designed by Google. This is Gemma 1.1 7B (IT), an update over the original instruction-tuned Gemma release. Gemma 1.1 was trained using a novel RLHF method, leading to substantial gains on quality, coding capabilities, factuality, instruction following and multi-turn conversation quality. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/google/gemma-1.1-7b-it">https://huggingface.co/google/gemma-1.1-7b-it</a> 
        /// </summary>
        Gemma117BIt,
        
        /// <summary>
        /// Name: gemma-2-27b-it <br/>
        /// Organization: google <br/>
        /// Context Length: 8192 <br/>
        /// Prompt Cost: $0.27/MTok <br/>
        /// Completion Cost: $0.27/MTok <br/>
        /// Description: Gemma is a family of lightweight, state-of-the-art open models from Google. Gemma-2-27B delivers the best performance for its size class, and even offers competitive alternatives to models more than twice its size.  <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/google/gemma-2-27b-it">https://huggingface.co/google/gemma-2-27b-it</a> 
        /// </summary>
        Gemma227BIt,
        
        /// <summary>
        /// Name: gemma-2-9b-it <br/>
        /// Organization: google <br/>
        /// Context Length: 8192 <br/>
        /// Prompt Cost: $0.03/MTok <br/>
        /// Completion Cost: $0.03/MTok <br/>
        /// Description: Gemma is a family of lightweight, state-of-the-art open models from Google. The 9B Gemma 2 model delivers class-leading performance, outperforming Llama 3 8B and other open models in its size category. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/google/gemma-2-9b-it">https://huggingface.co/google/gemma-2-9b-it</a> 
        /// </summary>
        Gemma29BIt,
        
        /// <summary>
        /// Name: lzlv_70b_fp16_hf <br/>
        /// Organization: lizpreciatior <br/>
        /// Context Length: 4096 <br/>
        /// Prompt Cost: $0.35/MTok <br/>
        /// Completion Cost: $0.35/MTok <br/>
        /// Description: A Mythomax/MLewd_13B-style merge of selected 70B models  A multi-model merge of several  LLaMA2 70B finetunes for roleplaying and creative work. The goal was to create a model that combines creativity with intelligence for an enhanced experience. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/lizpreciatior/lzlv_70b_fp16_hf">https://huggingface.co/lizpreciatior/lzlv_70b_fp16_hf</a> 
        /// </summary>
        Lzlv70BFp16Hf,
        
        /// <summary>
        /// Name: Reflection-Llama-3.1-70B <br/>
        /// Organization: mattshumer <br/>
        /// Context Length: 8192 <br/>
        /// Prompt Cost: $0.35/MTok <br/>
        /// Completion Cost: $0.35/MTok <br/>
        /// Description: Reflection Llama-3.1 70B is trained with a new technique called Reflection-Tuning that teaches a LLM to detect mistakes in its reasoning and correct course.  The model was trained on synthetic data. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/mattshumer/Reflection-Llama-3.1-70B">https://huggingface.co/mattshumer/Reflection-Llama-3.1-70B</a> 
        /// </summary>
        ReflectionLlama3170B,
        
        /// <summary>
        /// Name: Llama-2-13b-chat-hf <br/>
        /// Organization: meta-llama <br/>
        /// Context Length: 4096 <br/>
        /// Prompt Cost: $0.13/MTok <br/>
        /// Completion Cost: $0.13/MTok <br/>
        /// Description: Llama 2 is a collection of pretrained and fine-tuned generative text models ranging in scale from 7 billion to 70 billion parameters. This is the repository for the 7B fine-tuned model, optimized for dialogue use cases and converted for the Hugging Face Transformers format.  <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Llama-2-13b-chat-hf">https://huggingface.co/meta-llama/Llama-2-13b-chat-hf</a> 
        /// </summary>
        Llama213BChatHf,
        
        /// <summary>
        /// Name: Llama-2-70b-chat-hf <br/>
        /// Organization: meta-llama <br/>
        /// Context Length: 4096 <br/>
        /// Prompt Cost: $0.64/MTok <br/>
        /// Completion Cost: $0.64/MTok <br/>
        /// Description: LLaMa 2 is a collections of LLMs trained by Meta. This is the 70B chat optimized version. This endpoint has per token pricing. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Llama-2-70b-chat-hf">https://huggingface.co/meta-llama/Llama-2-70b-chat-hf</a> 
        /// </summary>
        Llama270BChatHf,
        
        /// <summary>
        /// Name: Llama-2-7b-chat-hf <br/>
        /// Organization: meta-llama <br/>
        /// Context Length: 4096 <br/>
        /// Prompt Cost: $0.07/MTok <br/>
        /// Completion Cost: $0.07/MTok <br/>
        /// Description: Llama 2 is a collection of pretrained and fine-tuned generative text models ranging in scale from 7 billion to 70 billion parameters. This is the repository for the 7B fine-tuned model, optimized for dialogue use cases and converted for the Hugging Face Transformers format.  <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Llama-2-7b-chat-hf">https://huggingface.co/meta-llama/Llama-2-7b-chat-hf</a> 
        /// </summary>
        Llama27BChatHf,
        
        /// <summary>
        /// Name: Llama-3.2-1B-Instruct <br/>
        /// Organization: meta-llama <br/>
        /// Context Length: 131072 <br/>
        /// Prompt Cost: $0.01/MTok <br/>
        /// Completion Cost: $0.01/MTok <br/>
        /// Description: The Meta Llama 3.2 collection of multilingual large language models (LLMs) is a collection of pretrained and instruction-tuned generative models in 1B and 3B sizes (text in/text out). <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Llama-3.2-1B-Instruct">https://huggingface.co/meta-llama/Llama-3.2-1B-Instruct</a> 
        /// </summary>
        Llama321BInstruct,
        
        /// <summary>
        /// Name: Llama-3.2-3B-Instruct <br/>
        /// Organization: meta-llama <br/>
        /// Context Length: 131072 <br/>
        /// Prompt Cost: $0.02/MTok <br/>
        /// Completion Cost: $0.02/MTok <br/>
        /// Description: The Meta Llama 3.2 collection of multilingual large language models (LLMs) is a collection of pretrained and instruction-tuned generative models in 1B and 3B sizes (text in/text out) <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Llama-3.2-3B-Instruct">https://huggingface.co/meta-llama/Llama-3.2-3B-Instruct</a> 
        /// </summary>
        Llama323BInstruct,
        
        /// <summary>
        /// Name: Meta-Llama-3-70B-Instruct <br/>
        /// Organization: meta-llama <br/>
        /// Context Length: 8192 <br/>
        /// Prompt Cost: $0.23/MTok <br/>
        /// Completion Cost: $0.23/MTok <br/>
        /// Description: Model Details Meta developed and released the Meta Llama 3 family of large language models (LLMs), a collection of pretrained and instruction tuned generative text models in 8 and 70B sizes. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Meta-Llama-3-70B-Instruct">https://huggingface.co/meta-llama/Meta-Llama-3-70B-Instruct</a> 
        /// </summary>
        MetaLlama370BInstruct,
        
        /// <summary>
        /// Name: Meta-Llama-3-8B-Instruct <br/>
        /// Organization: meta-llama <br/>
        /// Context Length: 8192 <br/>
        /// Prompt Cost: $0.03/MTok <br/>
        /// Completion Cost: $0.03/MTok <br/>
        /// Description: Meta developed and released the Meta Llama 3 family of large language models (LLMs), a collection of pretrained and instruction tuned generative text models in 8 and 70B sizes. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/meta-llama/Meta-Llama-3-8B-Instruct">https://huggingface.co/meta-llama/Meta-Llama-3-8B-Instruct</a> 
        /// </summary>
        MetaLlama38BInstruct,
        
        /// <summary>
        /// Name: Phi-3-medium-4k-instruct <br/>
        /// Organization: microsoft <br/>
        /// Context Length: 4096 <br/>
        /// Prompt Cost: $0.14/MTok <br/>
        /// Completion Cost: $0.14/MTok <br/>
        /// Description: The Phi-3-Medium-4K-Instruct is a powerful and lightweight language model with 14 billion parameters, trained on high-quality data to excel in instruction following and safety measures. It demonstrates exceptional performance across benchmarks, including common sense, language understanding, and logical reasoning, outperforming models of similar size. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/microsoft/Phi-3-medium-4k-instruct">https://huggingface.co/microsoft/Phi-3-medium-4k-instruct</a> 
        /// </summary>
        Phi3Medium4KInstruct,
        
        /// <summary>
        /// Name: WizardLM-2-7B <br/>
        /// Organization: microsoft <br/>
        /// Context Length: 32768 <br/>
        /// Prompt Cost: $0.06/MTok <br/>
        /// Completion Cost: $0.06/MTok <br/>
        /// Description: WizardLM-2 7B is the smaller variant of Microsoft AI's latest Wizard model. It is the fastest and achieves comparable performance with existing 10x larger open-source leading models <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/microsoft/WizardLM-2-7B">https://huggingface.co/microsoft/WizardLM-2-7B</a> 
        /// </summary>
        Wizardlm27B,
        
        /// <summary>
        /// Name: Mistral-7B-Instruct-v0.1 <br/>
        /// Organization: mistralai <br/>
        /// Context Length: 32768 <br/>
        /// Prompt Cost: $0.06/MTok <br/>
        /// Completion Cost: $0.06/MTok <br/>
        /// Description: The Mistral-7B-Instruct-v0.1 Large Language Model (LLM) is a instruct fine-tuned version of the Mistral-7B-v0.1 generative text model using a variety of publicly available conversation datasets. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/mistralai/Mistral-7B-Instruct-v0.1">https://huggingface.co/mistralai/Mistral-7B-Instruct-v0.1</a> 
        /// </summary>
        Mistral7BInstructV01,
        
        /// <summary>
        /// Name: Mistral-7B-Instruct-v0.2 <br/>
        /// Organization: mistralai <br/>
        /// Context Length: 32768 <br/>
        /// Prompt Cost: $0.06/MTok <br/>
        /// Completion Cost: $0.06/MTok <br/>
        /// Description: The Mistral-7B-Instruct-v0.2 Large Language Model (LLM) is a instruct fine-tuned version of the Mistral-7B-v0.2 generative text model using a variety of publicly available conversation datasets. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/mistralai/Mistral-7B-Instruct-v0.2">https://huggingface.co/mistralai/Mistral-7B-Instruct-v0.2</a> 
        /// </summary>
        Mistral7BInstructV02,
        
        /// <summary>
        /// Name: Mistral-7B-Instruct-v0.3 <br/>
        /// Organization: mistralai <br/>
        /// Context Length: 32768 <br/>
        /// Prompt Cost: $0.03/MTok <br/>
        /// Completion Cost: $0.03/MTok <br/>
        /// Description: Mistral-7B-Instruct-v0.3 is an instruction-tuned model, next iteration of of Mistral 7B that has larger vocabulary, newer tokenizer and supports function calling. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/mistralai/Mistral-7B-Instruct-v0.3">https://huggingface.co/mistralai/Mistral-7B-Instruct-v0.3</a> 
        /// </summary>
        Mistral7BInstructV03,
        
        /// <summary>
        /// Name: Mistral-Nemo-Instruct-2407 <br/>
        /// Organization: mistralai <br/>
        /// Context Length: 131072 <br/>
        /// Prompt Cost: $0.03/MTok <br/>
        /// Completion Cost: $0.03/MTok <br/>
        /// Description: 12B model trained jointly by Mistral AI and NVIDIA, it significantly outperforms existing models smaller or similar in size. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/mistralai/Mistral-Nemo-Instruct-2407">https://huggingface.co/mistralai/Mistral-Nemo-Instruct-2407</a> 
        /// </summary>
        MistralNemoInstruct2407,
        
        /// <summary>
        /// Name: Mixtral-8x22B-Instruct-v0.1 <br/>
        /// Organization: mistralai <br/>
        /// Context Length: 65536 <br/>
        /// Prompt Cost: $0.65/MTok <br/>
        /// Completion Cost: $0.65/MTok <br/>
        /// Description: This is the instruction fine-tuned version of Mixtral-8x22B - the latest and largest mixture of experts large language model (LLM) from Mistral AI. This state of the art machine learning model uses a mixture 8 of experts (MoE) 22b models. During inference 2 experts are selected. This architecture allows large models to be fast and cheap at inference. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/mistralai/Mixtral-8x22B-Instruct-v0.1">https://huggingface.co/mistralai/Mixtral-8x22B-Instruct-v0.1</a> 
        /// </summary>
        Mixtral8X22bInstructV01,
        
        /// <summary>
        /// Name: Mixtral-8x22B-v0.1 <br/>
        /// Organization: mistralai <br/>
        /// Context Length: 65536 <br/>
        /// Prompt Cost: $0.65/MTok <br/>
        /// Completion Cost: $0.65/MTok <br/>
        /// Description: Mixtral-8x22B is the latest and largest mixture of expert large language model (LLM) from Mistral AI. This is state of the art machine learning model using a mixture 8 of experts (MoE) 22b models. During inference 2 expers are selected. This architecture allows large models to be fast and cheap at inference.  This model is not instruction tuned.  <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/mistralai/Mixtral-8x22B-v0.1">https://huggingface.co/mistralai/Mixtral-8x22B-v0.1</a> 
        /// </summary>
        Mixtral8X22bV01,
        
        /// <summary>
        /// Name: Mixtral-8x7B-Instruct-v0.1 <br/>
        /// Organization: mistralai <br/>
        /// Context Length: 32768 <br/>
        /// Prompt Cost: $0.24/MTok <br/>
        /// Completion Cost: $0.24/MTok <br/>
        /// Description: Mixtral is mixture of expert large language model (LLM) from Mistral AI. This is state of the art machine learning model using a mixture 8 of experts (MoE) 7b models. During inference 2 expers are selected. This architecture allows large models to be fast and cheap at inference. The Mixtral-8x7B outperforms Llama 2 70B on most benchmarks. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/mistralai/Mixtral-8x7B-Instruct-v0.1">https://huggingface.co/mistralai/Mixtral-8x7B-Instruct-v0.1</a> 
        /// </summary>
        Mixtral8X7BInstructV01,
        
        /// <summary>
        /// Name: Nemotron-4-340B-Instruct <br/>
        /// Organization: nvidia <br/>
        /// Context Length: 4096 <br/>
        /// Prompt Cost: $4.2/MTok <br/>
        /// Completion Cost: $4.2/MTok <br/>
        /// Description: Nemotron-4-340B-Instruct is a chat model intended for use for the English language, designed for Synthetic Data Generation <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/nvidia/Nemotron-4-340B-Instruct">https://huggingface.co/nvidia/Nemotron-4-340B-Instruct</a> 
        /// </summary>
        Nemotron4340BInstruct,
        
        /// <summary>
        /// Name: MiniCPM-Llama3-V-2_5 <br/>
        /// Organization: openbmb <br/>
        /// Context Length: 8192 <br/>
        /// Prompt Cost: $0.34/MTok <br/>
        /// Completion Cost: $0.34/MTok <br/>
        /// Description:  <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/openbmb/MiniCPM-Llama3-V-2_5">https://huggingface.co/openbmb/MiniCPM-Llama3-V-2_5</a> 
        /// </summary>
        MinicpmLlama3V25,
        
        /// <summary>
        /// Name: openchat-3.6-8b <br/>
        /// Organization: openchat <br/>
        /// Context Length: 8192 <br/>
        /// Prompt Cost: $0.06/MTok <br/>
        /// Completion Cost: $0.06/MTok <br/>
        /// Description: Openchat 3.6 is a LLama-3-8b fine tune that outperforms it on multiple benchmarks. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/openchat/openchat-3.6-8b">https://huggingface.co/openchat/openchat-3.6-8b</a> 
        /// </summary>
        OpenChat368B,
        
        /// <summary>
        /// Name: openchat_3.5 <br/>
        /// Organization: openchat <br/>
        /// Context Length: 8192 <br/>
        /// Prompt Cost: $0.06/MTok <br/>
        /// Completion Cost: $0.06/MTok <br/>
        /// Description: OpenChat is a library of open-source language models that have been fine-tuned with C-RLFT, a strategy inspired by offline reinforcement learning. These models can learn from mixed-quality data without preference labels and have achieved exceptional performance comparable to ChatGPT. The developers of OpenChat are dedicated to creating a high-performance, commercially viable, open-source large language model and are continuously making progress towards this goal. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/openchat/openchat_3.5">https://huggingface.co/openchat/openchat_3.5</a> 
        /// </summary>
        OpenChat35,
        
        /// <summary>
        /// Name: bge-base-en-v1.5 <br/>
        /// Organization: BAAI <br/>
        /// Context Length: 512 <br/>
        /// Prompt Cost: $0/MTok <br/>
        /// Completion Cost: $0/MTok <br/>
        /// Description: BGE embedding is a general Embedding Model. It is pre-trained using retromae and trained on large-scale pair data using contrastive learning. Note that the goal of pre-training is to reconstruct the text, and the pre-trained model cannot be used for similarity calculation directly, it needs to be fine-tuned <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/BAAI/bge-base-en-v1.5">https://huggingface.co/BAAI/bge-base-en-v1.5</a> 
        /// </summary>
        BgeBaseEnV15,
        
        /// <summary>
        /// Name: bge-en-icl <br/>
        /// Organization: BAAI <br/>
        /// Context Length: 8192 <br/>
        /// Prompt Cost: $0.01/MTok <br/>
        /// Completion Cost: $0.01/MTok <br/>
        /// Description: A LLM-based embedding model with in-context learning capabilities that achieves SOTA performance on BEIR and AIR-Bench. It leverages few-shot examples to enhance task performance. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/BAAI/bge-en-icl">https://huggingface.co/BAAI/bge-en-icl</a> 
        /// </summary>
        BgeEnIcl,
        
        /// <summary>
        /// Name: bge-large-en-v1.5 <br/>
        /// Organization: BAAI <br/>
        /// Context Length: 512 <br/>
        /// Prompt Cost: $0.01/MTok <br/>
        /// Completion Cost: $0.01/MTok <br/>
        /// Description: BGE embedding is a general Embedding Model. It is pre-trained using retromae and trained on large-scale pair data using contrastive learning. Note that the goal of pre-training is to reconstruct the text, and the pre-trained model cannot be used for similarity calculation directly, it needs to be fine-tuned <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/BAAI/bge-large-en-v1.5">https://huggingface.co/BAAI/bge-large-en-v1.5</a> 
        /// </summary>
        BgeLargeEnV15,
        
        /// <summary>
        /// Name: bge-m3 <br/>
        /// Organization: BAAI <br/>
        /// Context Length: 8192 <br/>
        /// Prompt Cost: $0.01/MTok <br/>
        /// Completion Cost: $0.01/MTok <br/>
        /// Description: BGE-M3 is a versatile text embedding model that supports multi-functionality, multi-linguality, and multi-granularity, allowing it to perform dense retrieval, multi-vector retrieval, and sparse retrieval in over 100 languages and with input sizes up to 8192 tokens. The model can be used in a retrieval pipeline with hybrid retrieval and re-ranking to achieve higher accuracy and stronger generalization capabilities. BGE-M3 has shown state-of-the-art performance on several benchmarks, including MKQA, MLDR, and NarritiveQA, and can be used as a drop-in replacement for other embedding models like DPR and BGE-v1.5. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/BAAI/bge-m3">https://huggingface.co/BAAI/bge-m3</a> 
        /// </summary>
        BgeM3,
        
        /// <summary>
        /// Name: e5-base-v2 <br/>
        /// Organization: intfloat <br/>
        /// Context Length: 512 <br/>
        /// Prompt Cost: $0/MTok <br/>
        /// Completion Cost: $0/MTok <br/>
        /// Description: Text Embeddings by Weakly-Supervised Contrastive Pre-training. Model has 24 layers and 1024 out dim.  <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/intfloat/e5-base-v2">https://huggingface.co/intfloat/e5-base-v2</a> 
        /// </summary>
        E5BaseV2,
        
        /// <summary>
        /// Name: e5-large-v2 <br/>
        /// Organization: intfloat <br/>
        /// Context Length: 512 <br/>
        /// Prompt Cost: $0.01/MTok <br/>
        /// Completion Cost: $0.01/MTok <br/>
        /// Description: Text Embeddings by Weakly-Supervised Contrastive Pre-training. Model has 24 layers and 1024 out dim.  <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/intfloat/e5-large-v2">https://huggingface.co/intfloat/e5-large-v2</a> 
        /// </summary>
        E5LargeV2,
        
        /// <summary>
        /// Name: multilingual-e5-large <br/>
        /// Organization: intfloat <br/>
        /// Context Length: 512 <br/>
        /// Prompt Cost: $0.01/MTok <br/>
        /// Completion Cost: $0.01/MTok <br/>
        /// Description: The Multilingual-E5-large model is a 24-layer text embedding model with an embedding size of 1024, trained on a mixture of multilingual datasets and supporting 100 languages. The model achieves state-of-the-art results on the Mr. TyDi benchmark, outperforming other models such as BM25 and mDPR. The model is intended for use in text retrieval and semantic similarity tasks, and should be used with the "query: " and "passage: " prefixes for input texts to achieve optimal performance. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/intfloat/multilingual-e5-large">https://huggingface.co/intfloat/multilingual-e5-large</a> 
        /// </summary>
        MultilingualE5Large,
        
        /// <summary>
        /// Name: all-MiniLM-L12-v2 <br/>
        /// Organization: sentence-transformers <br/>
        /// Context Length: 512 <br/>
        /// Prompt Cost: $0/MTok <br/>
        /// Completion Cost: $0/MTok <br/>
        /// Description: We present a sentence transformation model that generates semantically similar sentences. Our model is based on the Sentence-Transformers architecture and was trained on a large dataset of sentence pairs. We evaluate the effectiveness of our model by measuring its ability to generate similar sentences that are close to the original sentence in meaning. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/sentence-transformers/all-MiniLM-L12-v2">https://huggingface.co/sentence-transformers/all-MiniLM-L12-v2</a> 
        /// </summary>
        AllMinilmL12V2,
        
        /// <summary>
        /// Name: all-MiniLM-L6-v2 <br/>
        /// Organization: sentence-transformers <br/>
        /// Context Length: 512 <br/>
        /// Prompt Cost: $0/MTok <br/>
        /// Completion Cost: $0/MTok <br/>
        /// Description: We present a sentence transformation model that achieves state-of-the-art results on various NLP tasks without requiring task-specific architectures or fine-tuning. Our approach leverages contrastive learning and utilizes a variety of datasets to learn robust sentence representations. We evaluate our model on several benchmarks and demonstrate its effectiveness in various applications such as text classification, sentiment analysis, named entity recognition, and question answering. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/sentence-transformers/all-MiniLM-L6-v2">https://huggingface.co/sentence-transformers/all-MiniLM-L6-v2</a> 
        /// </summary>
        AllMinilmL6V2,
        
        /// <summary>
        /// Name: all-mpnet-base-v2 <br/>
        /// Organization: sentence-transformers <br/>
        /// Context Length: 512 <br/>
        /// Prompt Cost: $0/MTok <br/>
        /// Completion Cost: $0/MTok <br/>
        /// Description: A sentence transformation model that has been trained on a wide range of datasets, including but not limited to S2ORC, WikiAnwers, PAQ, Stack Exchange, and Yahoo! Answers. Our model can be used for various NLP tasks such as clustering, sentiment analysis, and question answering. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/sentence-transformers/all-mpnet-base-v2">https://huggingface.co/sentence-transformers/all-mpnet-base-v2</a> 
        /// </summary>
        AllMpnetBaseV2,
        
        /// <summary>
        /// Name: clip-ViT-B-32 <br/>
        /// Organization: sentence-transformers <br/>
        /// Context Length: 77 <br/>
        /// Prompt Cost: $0/MTok <br/>
        /// Completion Cost: $0/MTok <br/>
        /// Description: The CLIP model maps text and images to a shared vector space, enabling various applications such as image search, zero-shot image classification, and image clustering. The model can be used easily after installation, and its performance is demonstrated through zero-shot ImageNet validation set accuracy scores. Multilingual versions of the model are also available for 50+ languages. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/sentence-transformers/clip-ViT-B-32">https://huggingface.co/sentence-transformers/clip-ViT-B-32</a> 
        /// </summary>
        ClipVitB32,
        
        /// <summary>
        /// Name: clip-ViT-B-32-multilingual-v1 <br/>
        /// Organization: sentence-transformers <br/>
        /// Context Length: 512 <br/>
        /// Prompt Cost: $0/MTok <br/>
        /// Completion Cost: $0/MTok <br/>
        /// Description: This model is a multilingual version of the OpenAI CLIP-ViT-B32 model, which maps text and images to a common dense vector space. It includes a text embedding model that works for 50+ languages and an image encoder from CLIP. The model was trained using Multilingual Knowledge Distillation, where a multilingual DistilBERT model was trained as a student model to align the vector space of the original CLIP image encoder across many languages. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/sentence-transformers/clip-ViT-B-32-multilingual-v1">https://huggingface.co/sentence-transformers/clip-ViT-B-32-multilingual-v1</a> 
        /// </summary>
        ClipVitB32MultilingualV1,
        
        /// <summary>
        /// Name: multi-qa-mpnet-base-dot-v1 <br/>
        /// Organization: sentence-transformers <br/>
        /// Context Length: 512 <br/>
        /// Prompt Cost: $0/MTok <br/>
        /// Completion Cost: $0/MTok <br/>
        /// Description: We present a sentence transformation model that maps sentences and paragraphs to a 768-dimensional dense vector space, suitable for semantic search tasks. The model is trained on 215 million question-answer pairs from various sources, including WikiAnswers, PAQ, Stack Exchange, MS MARCO, GOOAQ, Amazon QA, Yahoo Answers, Search QA, ELI5, and Natural Questions. Our model uses a contrastive learning objective. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/sentence-transformers/multi-qa-mpnet-base-dot-v1">https://huggingface.co/sentence-transformers/multi-qa-mpnet-base-dot-v1</a> 
        /// </summary>
        MultiQaMpnetBaseDotV1,
        
        /// <summary>
        /// Name: paraphrase-MiniLM-L6-v2 <br/>
        /// Organization: sentence-transformers <br/>
        /// Context Length: 512 <br/>
        /// Prompt Cost: $0/MTok <br/>
        /// Completion Cost: $0/MTok <br/>
        /// Description: We present a sentence similarity model based on the Sentence Transformers architecture, which maps sentences to a 384-dimensional dense vector space. The model uses a pre-trained BERT encoder and applies mean pooling on top of the contextualized word embeddings to obtain sentence embeddings. We evaluate the model on the Sentence Embeddings Benchmark. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/sentence-transformers/paraphrase-MiniLM-L6-v2">https://huggingface.co/sentence-transformers/paraphrase-MiniLM-L6-v2</a> 
        /// </summary>
        ParaphraseMinilmL6V2,
        
        /// <summary>
        /// Name: text2vec-base-chinese <br/>
        /// Organization: shibing624 <br/>
        /// Context Length: 512 <br/>
        /// Prompt Cost: $0/MTok <br/>
        /// Completion Cost: $0/MTok <br/>
        /// Description: A sentence similarity model that can be used for various NLP tasks such as text classification, sentiment analysis, named entity recognition, question answering, and more. It utilizes the CoSENT architecture, which consists of a transformer encoder and a pooling module, to encode input texts into vectors that capture their semantic meaning. The model was trained on the nli_zh dataset and achieved high performance on various benchmark datasets. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/shibing624/text2vec-base-chinese">https://huggingface.co/shibing624/text2vec-base-chinese</a> 
        /// </summary>
        Text2vecBaseChinese,
        
        /// <summary>
        /// Name: gte-base <br/>
        /// Organization: thenlper <br/>
        /// Context Length: 512 <br/>
        /// Prompt Cost: $0/MTok <br/>
        /// Completion Cost: $0/MTok <br/>
        /// Description: The GTE models are trained by Alibaba DAMO Academy. They are mainly based on the BERT framework and currently offer three different sizes of models, including GTE-large, GTE-base, and GTE-small. The GTE models are trained on a large-scale corpus of relevance text pairs, covering a wide range of domains and scenarios. This enables the GTE models to be applied to various downstream tasks of text embeddings, including information retrieval, semantic textual similarity, text reranking, etc. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/thenlper/gte-base">https://huggingface.co/thenlper/gte-base</a> 
        /// </summary>
        GteBase,
        
        /// <summary>
        /// Name: gte-large <br/>
        /// Organization: thenlper <br/>
        /// Context Length: 512 <br/>
        /// Prompt Cost: $0.01/MTok <br/>
        /// Completion Cost: $0.01/MTok <br/>
        /// Description: The GTE models are trained by Alibaba DAMO Academy. They are mainly based on the BERT framework and currently offer three different sizes of models, including GTE-large, GTE-base, and GTE-small. The GTE models are trained on a large-scale corpus of relevance text pairs, covering a wide range of domains and scenarios. This enables the GTE models to be applied to various downstream tasks of text embeddings, including information retrieval, semantic textual similarity, text reranking, etc. <br/>
        /// HuggingFace Url: <a href="https://huggingface.co/thenlper/gte-large">https://huggingface.co/thenlper/gte-large</a> 
        /// </summary>
        GteLarge,
        
}