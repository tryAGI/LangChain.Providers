namespace LangChain.Providers.OpenRouter;

/// <summary>
/// List of all the Predefined OpenRouter Models
/// </summary>
public enum OpenRouterModelIds
{

    /// <summary>
    /// Moonlight-16B-A3B-Instruct is a 16B-parameter Mixture-of-Experts (MoE) language model developed by Moonshot AI. It is optimized for instruction-following tasks with 3B activated parameters per inference. The model advances the Pareto frontier in performance per FLOP across English, coding, math, and Chinese benchmarks. It outperforms comparable models like Llama3-3B and Deepseek-v2-Lite while maintaining efficient deployment capabilities through Hugging Face integration and compatibility with popular inference engines like vLLM12.  <br/>
    /// </summary>
    MoonshotAiMoonlight16BA3bInstructFree,

    /// <summary>
    /// DeepHermes 3 Preview is the latest version of our flagship Hermes series of LLMs by Nous Research, and one of the first models in the world to unify Reasoning (long chains of thought that improve answer accuracy) and normal LLM response modes into one model. We have also improved LLM annotation, judgement, and function calling.  <br/>
    /// DeepHermes 3 Preview is one of the first LLM models to unify both "intuitive", traditional mode responses and long chain of thought reasoning responses into a single model, toggled by a system prompt.  <br/>
    /// </summary>
    NousDeephermes3Llama38BPreviewFree,

    /// <summary>
    /// GPT-4.5 (Preview) is a research preview of OpenAI’s latest language model, designed to advance capabilities in reasoning, creativity, and multi-turn conversation. It builds on previous iterations with improvements in world knowledge, contextual coherence, and the ability to follow user intent more effectively.  <br/>
    /// The model demonstrates enhanced performance in tasks that require open-ended thinking, problem-solving, and communication. Early testing suggests it is better at generating nuanced responses, maintaining long-context coherence, and reducing hallucinations compared to earlier versions.  <br/>
    /// This research preview is intended to help evaluate GPT-4.5’s strengths and limitations in real-world use cases as OpenAI continues to refine and develop future models. Read more at the [blog post here.](https://openai.com/index/introducing-gpt-4-5/)  <br/>
    /// </summary>
    OpenAiGpt45Preview,

    /// <summary>
    /// Gemini 2.0 Flash Lite offers a significantly faster time to first token (TTFT) compared to [Gemini Flash 1.5](/google/gemini-flash-1.5), while maintaining quality on par with larger models like [Gemini Pro 1.5](/google/gemini-pro-1.5), all at extremely economical token prices.  <br/>
    /// </summary>
    GoogleGemini20FlashLite,

    /// <summary>
    /// Claude 3.7 Sonnet is an advanced large language model with improved reasoning, coding, and problem-solving capabilities. It introduces a hybrid reasoning approach, allowing users to choose between rapid responses and extended, step-by-step processing for complex tasks. The model demonstrates notable improvements in coding, particularly in front-end development and full-stack updates, and excels in agentic workflows, where it can autonomously navigate multi-step processes.   <br/>
    /// Claude 3.7 Sonnet maintains performance parity with its predecessor in standard mode while offering an extended reasoning mode for enhanced accuracy in math, coding, and instruction-following tasks.  <br/>
    /// Read more at the [blog post here](https://www.anthropic.com/news/claude-3-7-sonnet)  <br/>
    /// </summary>
    AnthropicClaude37SonnetSelfModerated,

    /// <summary>
    /// Claude 3.7 Sonnet is an advanced large language model with improved reasoning, coding, and problem-solving capabilities. It introduces a hybrid reasoning approach, allowing users to choose between rapid responses and extended, step-by-step processing for complex tasks. The model demonstrates notable improvements in coding, particularly in front-end development and full-stack updates, and excels in agentic workflows, where it can autonomously navigate multi-step processes.   <br/>
    /// Claude 3.7 Sonnet maintains performance parity with its predecessor in standard mode while offering an extended reasoning mode for enhanced accuracy in math, coding, and instruction-following tasks.  <br/>
    /// Read more at the [blog post here](https://www.anthropic.com/news/claude-3-7-sonnet)  <br/>
    /// </summary>
    AnthropicClaude37Sonnet,

    /// <summary>
    /// Claude 3.7 Sonnet is an advanced large language model with improved reasoning, coding, and problem-solving capabilities. It introduces a hybrid reasoning approach, allowing users to choose between rapid responses and extended, step-by-step processing for complex tasks. The model demonstrates notable improvements in coding, particularly in front-end development and full-stack updates, and excels in agentic workflows, where it can autonomously navigate multi-step processes.   <br/>
    /// Claude 3.7 Sonnet maintains performance parity with its predecessor in standard mode while offering an extended reasoning mode for enhanced accuracy in math, coding, and instruction-following tasks.  <br/>
    /// Read more at the [blog post here](https://www.anthropic.com/news/claude-3-7-sonnet)  <br/>
    /// </summary>
    AnthropicClaude37SonnetThinking,

    /// <summary>
    /// R1 1776 is a version of DeepSeek-R1 that has been post-trained to remove censorship constraints related to topics restricted by the Chinese government. The model retains its original reasoning capabilities while providing direct responses to a wider range of queries. R1 1776 is an offline chat model that does not use the perplexity search subsystem.  <br/>
    /// The model was tested on a multilingual dataset of over 1,000 examples covering sensitive topics to measure its likelihood of refusal or overly filtered responses. [Evaluation Results](https://cdn-uploads.huggingface.co/production/uploads/675c8332d01f593dc90817f5/GiN2VqC5hawUgAGJ6oHla.png) Its performance on math and reasoning benchmarks remains similar to the base R1 model. [Reasoning Performance](https://cdn-uploads.huggingface.co/production/uploads/675c8332d01f593dc90817f5/n4Z9Byqp2S7sKUvCvI40R.png)  <br/>
    /// Read more on the [Blog Post](https://perplexity.ai/hub/blog/open-sourcing-r1-1776)  <br/>
    /// </summary>
    PerplexityR11776,

    /// <summary>
    /// Mistral Saba is a 24B-parameter language model specifically designed for the Middle East and South Asia, delivering accurate and contextually relevant responses while maintaining efficient performance. Trained on curated regional datasets, it supports multiple Indian-origin languages—including Tamil and Malayalam—alongside Arabic. This makes it a versatile option for a range of regional and multilingual applications. Read more at the blog post [here](https://mistral.ai/en/news/mistral-saba)  <br/>
    /// </summary>
    MistralSaba,

    /// <summary>
    /// Dolphin 3.0 R1 is the next generation of the Dolphin series of instruct-tuned models.  Designed to be the ultimate general purpose local model, enabling coding, math, agentic, function calling, and general use cases.  <br/>
    /// The R1 version has been trained for 3 epochs to reason using 800k reasoning traces from the Dolphin-R1 dataset.  <br/>
    /// Dolphin aims to be a general purpose reasoning instruct model, similar to the models behind ChatGPT, Claude, Gemini.  <br/>
    /// Part of the [Dolphin 3.0 Collection](https://huggingface.co/collections/cognitivecomputations/dolphin-30-677ab47f73d7ff66743979a3) Curated and trained by [Eric Hartford](https://huggingface.co/ehartford), [Ben Gitter](https://huggingface.co/bigstorm), [BlouseJury](https://huggingface.co/BlouseJury) and [Cognitive Computations](https://huggingface.co/cognitivecomputations)  <br/>
    /// </summary>
    Dolphin30R1Mistral24BFree,

    /// <summary>
    /// Dolphin 3.0 is the next generation of the Dolphin series of instruct-tuned models.  Designed to be the ultimate general purpose local model, enabling coding, math, agentic, function calling, and general use cases.  <br/>
    /// Dolphin aims to be a general purpose instruct model, similar to the models behind ChatGPT, Claude, Gemini.   <br/>
    /// Part of the [Dolphin 3.0 Collection](https://huggingface.co/collections/cognitivecomputations/dolphin-30-677ab47f73d7ff66743979a3) Curated and trained by [Eric Hartford](https://huggingface.co/ehartford), [Ben Gitter](https://huggingface.co/bigstorm), [BlouseJury](https://huggingface.co/BlouseJury) and [Cognitive Computations](https://huggingface.co/cognitivecomputations)  <br/>
    /// </summary>
    Dolphin30Mistral24BFree,

    /// <summary>
    /// Llama Guard 3 is a Llama-3.1-8B pretrained model, fine-tuned for content safety classification. Similar to previous versions, it can be used to classify content in both LLM inputs (prompt classification) and in LLM responses (response classification). It acts as an LLM – it generates text in its output that indicates whether a given prompt or response is safe or unsafe, and if unsafe, it also lists the content categories violated.  <br/>
    /// Llama Guard 3 was aligned to safeguard against the MLCommons standardized hazards taxonomy and designed to support Llama 3.1 capabilities. Specifically, it provides content moderation in 8 languages, and was optimized to support safety and security for search and code interpreter tool calls.  <br/>
    /// </summary>
    LlamaGuard38B,

    /// <summary>
    /// OpenAI o3-mini-high is the same model as [o3-mini](/openai/o3-mini) with reasoning_effort set to high.   <br/>
    /// o3-mini is a cost-efficient language model optimized for STEM reasoning tasks, particularly excelling in science, mathematics, and coding. The model features three adjustable reasoning effort levels and supports key developer capabilities including function calling, structured outputs, and streaming, though it does not include vision processing capabilities.  <br/>
    /// The model demonstrates significant improvements over its predecessor, with expert testers preferring its responses 56% of the time and noting a 39% reduction in major errors on complex questions. With medium reasoning effort settings, o3-mini matches the performance of the larger o1 model on challenging reasoning evaluations like AIME and GPQA, while maintaining lower latency and cost.  <br/>
    /// </summary>
    OpenAiO3MiniHigh,

    /// <summary>
    /// Tülu 3 405B is the largest model in the Tülu 3 family, applying fully open post-training recipes at a 405B parameter scale. Built on the Llama 3.1 405B base, it leverages Reinforcement Learning with Verifiable Rewards (RLVR) to enhance instruction following, MATH, GSM8K, and IFEval performance. As part of Tülu 3’s fully open-source approach, it offers state-of-the-art capabilities while surpassing prior open-weight models like Llama 3.1 405B Instruct and Nous Hermes 3 405B on multiple benchmarks. To read more, [click here.](https://allenai.org/blog/tulu-3-405B)  <br/>
    /// </summary>
    Llama31Tulu3405B,

    /// <summary>
    /// DeepSeek R1 Distill Llama 8B is a distilled large language model based on [Llama-3.1-8B-Instruct](/meta-llama/llama-3.1-8b-instruct), using outputs from [DeepSeek R1](/deepseek/deepseek-r1). The model combines advanced distillation techniques to achieve high performance across multiple benchmarks, including:  <br/>
    /// - AIME 2024 pass@1: 50.4  <br/>
    /// - MATH-500 pass@1: 89.1  <br/>
    /// - CodeForces Rating: 1205  <br/>
    /// The model leverages fine-tuning from DeepSeek R1's outputs, enabling competitive performance comparable to larger frontier models.  <br/>
    /// Hugging Face:   <br/>
    /// - [Llama-3.1-8B](https://huggingface.co/meta-llama/Llama-3.1-8B)   <br/>
    /// - [DeepSeek-R1-Distill-Llama-8B](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Llama-8B)   |  <br/>
    /// </summary>
    DeepseekR1DistillLlama8B,

    /// <summary>
    /// Gemini Flash 2.0 offers a significantly faster time to first token (TTFT) compared to [Gemini Flash 1.5](/google/gemini-flash-1.5), while maintaining quality on par with larger models like [Gemini Pro 1.5](/google/gemini-pro-1.5). It introduces notable enhancements in multimodal understanding, coding capabilities, complex instruction following, and function calling. These advancements come together to deliver more seamless and robust agentic experiences.  <br/>
    /// </summary>
    GoogleGeminiFlash20,

    /// <summary>
    /// Gemini Flash Lite 2.0 offers a significantly faster time to first token (TTFT) compared to [Gemini Flash 1.5](/google/gemini-flash-1.5), while maintaining quality on par with larger models like [Gemini Pro 1.5](/google/gemini-pro-1.5). Because it's currently in preview, it will be **heavily rate-limited** by Google. This model will move from free to paid pending a general rollout on February 24th, at $0.075 / $0.30 per million input / ouput tokens respectively.  <br/>
    /// </summary>
    GoogleGeminiFlashLite20PreviewFree,

    /// <summary>
    /// Gemini 2.0 Pro Experimental is a bleeding-edge version of the Gemini 2.0 Pro model. Because it's currently experimental, it will be **heavily rate-limited** by Google.  <br/>
    /// Usage of Gemini is subject to Google's [Gemini Terms of Use](https://ai.google.dev/terms).  <br/>
    /// #multimodal  <br/>
    /// </summary>
    GoogleGeminiPro20ExperimentalFree,

    /// <summary>
    /// Qwen's Enhanced Large Visual Language Model. Significantly upgraded for detailed recognition capabilities and text recognition abilities, supporting ultra-high pixel resolutions up to millions of pixels and extreme aspect ratios for image input. It delivers significant performance across a broad range of visual tasks.  <br/>
    /// </summary>
    QwenQwenVlPlusFree,

    /// <summary>
    /// Aion-1.0 is a multi-model system designed for high performance across various tasks, including reasoning and coding. It is built on DeepSeek-R1, augmented with additional models and techniques such as Tree of Thoughts (ToT) and Mixture of Experts (MoE). It is Aion Lab's most powerful reasoning model.  <br/>
    /// </summary>
    AionlabsAion10,

    /// <summary>
    /// Aion-1.0-Mini 32B parameter model is a distilled version of the DeepSeek-R1 model, designed for strong performance in reasoning domains such as mathematics, coding, and logic. It is a modified variant of a FuseAI model that outperforms R1-Distill-Qwen-32B and R1-Distill-Llama-70B, with benchmark results available on its [Hugging Face page](https://huggingface.co/FuseAI/FuseO1-DeepSeekR1-QwQ-SkyT1-32B-Preview), independently replicated for verification.  <br/>
    /// </summary>
    AionlabsAion10Mini,

    /// <summary>
    /// Aion-RP-Llama-3.1-8B ranks the highest in the character evaluation portion of the RPBench-Auto benchmark, a roleplaying-specific variant of Arena-Hard-Auto, where LLMs evaluate each other’s responses. It is a fine-tuned base model rather than an instruct model, designed to produce more natural and varied writing.  <br/>
    /// </summary>
    AionlabsAionRp108B,

    /// <summary>
    /// Qwen-Turbo, based on Qwen2.5, is a 1M context model that provides fast speed and low cost, suitable for simple tasks.  <br/>
    /// </summary>
    QwenQwenTurbo,

    /// <summary>
    /// Qwen2.5-VL is proficient in recognizing common objects such as flowers, birds, fish, and insects. It is also highly capable of analyzing texts, charts, icons, graphics, and layouts within images.  <br/>
    /// </summary>
    QwenQwen25Vl72BInstructFree,

    /// <summary>
    /// Qwen2.5-VL is proficient in recognizing common objects such as flowers, birds, fish, and insects. It is also highly capable of analyzing texts, charts, icons, graphics, and layouts within images.  <br/>
    /// </summary>
    QwenQwen25Vl72BInstruct,

    /// <summary>
    /// Qwen-Plus, based on the Qwen2.5 foundation model, is a 131K context model with a balanced performance, speed, and cost combination.  <br/>
    /// </summary>
    QwenQwenPlus,

    /// <summary>
    /// Qwen-Max, based on Qwen2.5, provides the best inference performance among [Qwen models](/qwen), especially for complex multi-step tasks. It's a large-scale MoE model that has been pretrained on over 20 trillion tokens and further post-trained with curated Supervised Fine-Tuning (SFT) and Reinforcement Learning from Human Feedback (RLHF) methodologies. The parameter count is unknown.  <br/>
    /// </summary>
    QwenQwenMax,

    /// <summary>
    /// OpenAI o3-mini is a cost-efficient language model optimized for STEM reasoning tasks, particularly excelling in science, mathematics, and coding.  <br/>
    /// This model supports the `reasoning_effort` parameter, which can be set to "high", "medium", or "low" to control the thinking time of the model. The default is "medium". OpenRouter also offers the model slug `openai/o3-mini-high` to default the parameter to "high".  <br/>
    /// The model features three adjustable reasoning effort levels and supports key developer capabilities including function calling, structured outputs, and streaming, though it does not include vision processing capabilities.  <br/>
    /// The model demonstrates significant improvements over its predecessor, with expert testers preferring its responses 56% of the time and noting a 39% reduction in major errors on complex questions. With medium reasoning effort settings, o3-mini matches the performance of the larger o1 model on challenging reasoning evaluations like AIME and GPQA, while maintaining lower latency and cost.  <br/>
    /// </summary>
    OpenAiO3Mini,

    /// <summary>
    /// DeepSeek R1 Distill Qwen 1.5B is a distilled large language model based on  [Qwen 2.5 Math 1.5B](https://huggingface.co/Qwen/Qwen2.5-Math-1.5B), using outputs from [DeepSeek R1](/deepseek/deepseek-r1). It's a very small and efficient model which outperforms [GPT 4o 0513](/openai/gpt-4o-2024-05-13) on Math Benchmarks.  <br/>
    /// Other benchmark results include:  <br/>
    /// - AIME 2024 pass@1: 28.9  <br/>
    /// - AIME 2024 cons@64: 52.7  <br/>
    /// - MATH-500 pass@1: 83.9  <br/>
    /// The model leverages fine-tuning from DeepSeek R1's outputs, enabling competitive performance comparable to larger frontier models.  <br/>
    /// </summary>
    DeepseekR1DistillQwen15B,

    /// <summary>
    /// Mistral Small 3 is a 24B-parameter language model optimized for low-latency performance across common AI tasks. Released under the Apache 2.0 license, it features both pre-trained and instruction-tuned versions designed for efficient local deployment.  <br/>
    /// The model achieves 81% accuracy on the MMLU benchmark and performs competitively with larger models like Llama 3.3 70B and Qwen 32B, while operating at three times the speed on equivalent hardware. [Read the blog post about the model here.](https://mistral.ai/news/mistral-small-3/)  <br/>
    /// </summary>
    MistralMistralSmall3Free,

    /// <summary>
    /// Mistral Small 3 is a 24B-parameter language model optimized for low-latency performance across common AI tasks. Released under the Apache 2.0 license, it features both pre-trained and instruction-tuned versions designed for efficient local deployment.  <br/>
    /// The model achieves 81% accuracy on the MMLU benchmark and performs competitively with larger models like Llama 3.3 70B and Qwen 32B, while operating at three times the speed on equivalent hardware. [Read the blog post about the model here.](https://mistral.ai/news/mistral-small-3/)  <br/>
    /// </summary>
    MistralMistralSmall3,

    /// <summary>
    /// DeepSeek R1 Distill Qwen 32B is a distilled large language model based on [Qwen 2.5 32B](https://huggingface.co/Qwen/Qwen2.5-32B), using outputs from [DeepSeek R1](/deepseek/deepseek-r1). It outperforms OpenAI's o1-mini across various benchmarks, achieving new state-of-the-art results for dense models.  <br/>
    /// Other benchmark results include:  <br/>
    /// - AIME 2024 pass@1: 72.6  <br/>
    /// - MATH-500 pass@1: 94.3  <br/>
    /// - CodeForces Rating: 1691  <br/>
    /// The model leverages fine-tuning from DeepSeek R1's outputs, enabling competitive performance comparable to larger frontier models.  <br/>
    /// </summary>
    DeepseekR1DistillQwen32B,

    /// <summary>
    /// DeepSeek R1 Distill Qwen 14B is a distilled large language model based on [Qwen 2.5 14B](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-14B), using outputs from [DeepSeek R1](/deepseek/deepseek-r1). It outperforms OpenAI's o1-mini across various benchmarks, achieving new state-of-the-art results for dense models.  <br/>
    /// Other benchmark results include:  <br/>
    /// - AIME 2024 pass@1: 69.7  <br/>
    /// - MATH-500 pass@1: 93.9  <br/>
    /// - CodeForces Rating: 1481  <br/>
    /// The model leverages fine-tuning from DeepSeek R1's outputs, enabling competitive performance comparable to larger frontier models.  <br/>
    /// </summary>
    DeepseekR1DistillQwen14B,

    /// <summary>
    /// Sonar Reasoning is a reasoning model provided by Perplexity based on [DeepSeek R1](/deepseek/deepseek-r1).  <br/>
    /// It allows developers to utilize long chain of thought with built-in web search. Sonar Reasoning is uncensored and hosted in US datacenters.   <br/>
    /// </summary>
    PerplexitySonarReasoning,

    /// <summary>
    /// Sonar is lightweight, affordable, fast, and simple to use — now featuring citations and the ability to customize sources. It is designed for companies seeking to integrate lightweight question-and-answer features optimized for speed.  <br/>
    /// </summary>
    PerplexitySonar,

    /// <summary>
    /// LFM-7B, a new best-in-class language model. LFM-7B is designed for exceptional chat capabilities, including languages like Arabic and Japanese. Powered by the Liquid Foundation Model (LFM) architecture, it exhibits unique features like low memory footprint and fast inference speed.   <br/>
    /// LFM-7B is the world’s best-in-class multilingual language model in English, Arabic, and Japanese.  <br/>
    /// See the [launch announcement](https://www.liquid.ai/lfm-7b) for benchmarks and more info.  <br/>
    /// </summary>
    LiquidLfm7B,

    /// <summary>
    /// Liquid's LFM 3B delivers incredible performance for its size. It positions itself as first place among 3B parameter transformers, hybrids, and RNN models It is also on par with Phi-3.5-mini on multiple benchmarks, while being 18.4% smaller.  <br/>
    /// LFM-3B is the ideal choice for mobile and other edge text-based applications.  <br/>
    /// See the [launch announcement](https://www.liquid.ai/liquid-foundation-models) for benchmarks and more info.  <br/>
    /// </summary>
    LiquidLfm3B,

    /// <summary>
    /// DeepSeek R1 Distill Llama 70B is a distilled large language model based on [Llama-3.3-70B-Instruct](/meta-llama/llama-3.3-70b-instruct), using outputs from [DeepSeek R1](/deepseek/deepseek-r1). The model combines advanced distillation techniques to achieve high performance across multiple benchmarks, including:  <br/>
    /// - AIME 2024 pass@1: 70.0  <br/>
    /// - MATH-500 pass@1: 94.5  <br/>
    /// - CodeForces Rating: 1633  <br/>
    /// The model leverages fine-tuning from DeepSeek R1's outputs, enabling competitive performance comparable to larger frontier models.  <br/>
    /// </summary>
    DeepseekR1DistillLlama70BFree,

    /// <summary>
    /// DeepSeek R1 Distill Llama 70B is a distilled large language model based on [Llama-3.3-70B-Instruct](/meta-llama/llama-3.3-70b-instruct), using outputs from [DeepSeek R1](/deepseek/deepseek-r1). The model combines advanced distillation techniques to achieve high performance across multiple benchmarks, including:  <br/>
    /// - AIME 2024 pass@1: 70.0  <br/>
    /// - MATH-500 pass@1: 94.5  <br/>
    /// - CodeForces Rating: 1633  <br/>
    /// The model leverages fine-tuning from DeepSeek R1's outputs, enabling competitive performance comparable to larger frontier models.  <br/>
    /// </summary>
    DeepseekR1DistillLlama70B,

    /// <summary>
    /// Gemini 2.0 Flash Thinking Experimental (01-21) is a snapshot of Gemini 2.0 Flash Thinking Experimental.  <br/>
    /// Gemini 2.0 Flash Thinking Mode is an experimental model that's trained to generate the "thinking process" the model goes through as part of its response. As a result, Thinking Mode is capable of stronger reasoning capabilities in its responses than the [base Gemini 2.0 Flash model](/google/gemini-2.0-flash-exp).  <br/>
    /// </summary>
    GoogleGemini20FlashThinkingExperimental0121Free,

    /// <summary>
    /// DeepSeek R1 is here: Performance on par with [OpenAI o1](/openai/o1), but open-sourced and with fully open reasoning tokens. It's 671B parameters in size, with 37B active in an inference pass.  <br/>
    /// Fully open-source model and [technical report](https://api-docs.deepseek.com/news/news250120).  <br/>
    /// MIT licensed: Distill and commercialize freely!  <br/>
    /// </summary>
    DeepseekR1Free,

    /// <summary>
    /// DeepSeek R1 is here: Performance on par with [OpenAI o1](/openai/o1), but open-sourced and with fully open reasoning tokens. It's 671B parameters in size, with 37B active in an inference pass.  <br/>
    /// Fully open-source model and [technical report](https://api-docs.deepseek.com/news/news250120).  <br/>
    /// MIT licensed: Distill and commercialize freely!  <br/>
    /// </summary>
    DeepseekR1,

    /// <summary>
    /// Rogue Rose demonstrates strong capabilities in roleplaying and storytelling applications, potentially surpassing other models in the 103-120B parameter range. While it occasionally exhibits inconsistencies with scene logic, the overall interaction quality represents an advancement in natural language processing for creative applications.  <br/>
    /// It is a 120-layer frankenmerge model combining two custom 70B architectures from November 2023, derived from the [xwin-stellarbright-erp-70b-v2](https://huggingface.co/sophosympatheia/xwin-stellarbright-erp-70b-v2) base.  <br/>
    /// </summary>
    RogueRose103Bv02Free,

    /// <summary>
    /// MiniMax-01 is a combines MiniMax-Text-01 for text generation and MiniMax-VL-01 for image understanding. It has 456 billion parameters, with 45.9 billion parameters activated per inference, and can handle a context of up to 4 million tokens.  <br/>
    /// The text model adopts a hybrid architecture that combines Lightning Attention, Softmax Attention, and Mixture-of-Experts (MoE). The image model adopts the “ViT-MLP-LLM” framework and is trained on top of the text model.  <br/>
    /// To read more about the release, see: https://www.minimaxi.com/en/news/minimax-01-series-2  <br/>
    /// </summary>
    MinimaxMinimax01,

    /// <summary>
    /// [Mistral](/mistralai)'s cutting-edge language model for coding. Codestral specializes in low-latency, high-frequency tasks such as fill-in-the-middle (FIM), code correction and test generation.   <br/>
    /// Learn more on their blog post: https://mistral.ai/news/codestral-2501/  <br/>
    /// </summary>
    MistralCodestral2501,

    /// <summary>
    /// [Microsoft Research](/microsoft) Phi-4 is designed to perform well in complex reasoning tasks and can operate efficiently in situations with limited memory or where quick responses are needed.   <br/>
    /// At 14 billion parameters, it was trained on a mix of high-quality synthetic datasets, data from curated websites, and academic materials. It has undergone careful improvement to follow instructions accurately and maintain strong safety standards. It works best with English language inputs.  <br/>
    /// For more information, please see [Phi-4 Technical Report](https://arxiv.org/pdf/2412.08905)  <br/>
    /// </summary>
    MicrosoftPhi4,

    /// <summary>
    /// This is [Sao10K](/sao10k)'s experiment over [Euryale v2.2](/sao10k/l3.1-euryale-70b).  <br/>
    /// </summary>
    Sao10kLlama3170BHanamiX1,

    /// <summary>
    /// DeepSeek-V3 is the latest model from the DeepSeek team, building upon the instruction following and coding abilities of the previous versions. Pre-trained on nearly 15 trillion tokens, the reported evaluations reveal that the model outperforms other open-source models and rivals leading closed-source models.  <br/>
    /// For model details, please visit [the DeepSeek-V3 repo](https://github.com/deepseek-ai/DeepSeek-V3) for more information, or see the [launch announcement](https://api-docs.deepseek.com/news/news1226).  <br/>
    /// </summary>
    DeepseekDeepseekV3Free,

    /// <summary>
    /// DeepSeek-V3 is the latest model from the DeepSeek team, building upon the instruction following and coding abilities of the previous versions. Pre-trained on nearly 15 trillion tokens, the reported evaluations reveal that the model outperforms other open-source models and rivals leading closed-source models.  <br/>
    /// For model details, please visit [the DeepSeek-V3 repo](https://github.com/deepseek-ai/DeepSeek-V3) for more information, or see the [launch announcement](https://api-docs.deepseek.com/news/news1226).  <br/>
    /// </summary>
    DeepseekDeepseekV3,

    /// <summary>
    /// QVQ-72B-Preview is an experimental research model developed by the [Qwen](/qwen) team, focusing on enhancing visual reasoning capabilities.  <br/>
    /// ## Performance  <br/>
    /// |                | **QVQ-72B-Preview** | o1-2024-12-17 | gpt-4o-2024-05-13 | Claude3.5 Sonnet-20241022 | Qwen2VL-72B |  <br/>
    /// |----------------|-----------------|---------------|-------------------|----------------------------|-------------|  <br/>
    /// | MMMU(val)      | 70.3            | 77.3          | 69.1              | 70.4                       | 64.5        |  <br/>
    /// | MathVista(mini) | 71.4            | 71.0          | 63.8              | 65.3                       | 70.5        |  <br/>
    /// | MathVision(full)   | 35.9            | –             | 30.4              | 35.6                       | 25.9        |  <br/>
    /// | OlympiadBench  | 20.4            | –             | 25.9              | –                          | 11.2        |  <br/>
    /// ## Limitations  <br/>
    /// 1. **Language Mixing and Code-Switching:** The model might occasionally mix different languages or unexpectedly switch between them, potentially affecting the clarity of its responses.  <br/>
    /// 2. **Recursive Reasoning Loops:**  There's a risk of the model getting caught in recursive reasoning loops, leading to lengthy responses that may not even arrive at a final answer.  <br/>
    /// 3. **Safety and Ethical Considerations:** Robust safety measures are needed to ensure reliable and safe performance. Users should exercise caution when deploying this model.  <br/>
    /// 4. **Performance and Benchmark Limitations:** Despite the improvements in visual reasoning, QVQ doesn’t entirely replace the capabilities of [Qwen2-VL-72B](/qwen/qwen-2-vl-72b-instruct). During multi-step visual reasoning, the model might gradually lose focus on the image content, leading to hallucinations. Moreover, QVQ doesn’t show significant improvement over [Qwen2-VL-72B](/qwen/qwen-2-vl-72b-instruct) in basic recognition tasks like identifying people, animals, or plants.  <br/>
    /// Note: Currently, the model only supports single-round dialogues and image outputs. It does not support video inputs.  <br/>
    /// </summary>
    QwenQvq72BPreview,

    /// <summary>
    /// Gemini 2.0 Flash Thinking Mode is an experimental model that's trained to generate the "thinking process" the model goes through as part of its response. As a result, Thinking Mode is capable of stronger reasoning capabilities in its responses than the [base Gemini 2.0 Flash model](/google/gemini-2.0-flash-exp).  <br/>
    /// </summary>
    GoogleGemini20FlashThinkingExperimentalFree,

    /// <summary>
    /// Euryale L3.3 70B is a model focused on creative roleplay from [Sao10k](https://ko-fi.com/sao10k). It is the successor of [Euryale L3 70B v2.2](/models/sao10k/l3-euryale-70b).  <br/>
    /// </summary>
    Sao10kLlama33Euryale70B,

    /// <summary>
    /// The latest and strongest model family from OpenAI, o1 is designed to spend more time thinking before responding. The o1 model series is trained with large-scale reinforcement learning to reason using chain of thought.   <br/>
    /// The o1 models are optimized for math, science, programming, and other STEM-related tasks. They consistently exhibit PhD-level accuracy on benchmarks in physics, chemistry, and biology. Learn more in the [launch announcement](https://openai.com/o1).  <br/>
    /// </summary>
    OpenAiO1,

    /// <summary>
    /// EVA Llama 3.33 70b is a roleplay and storywriting specialist model. It is a full-parameter finetune of [Llama-3.3-70B-Instruct](https://openrouter.ai/meta-llama/llama-3.3-70b-instruct) on mixture of synthetic and natural data.  <br/>
    /// It uses Celeste 70B 0.1 data mixture, greatly expanding it to improve versatility, creativity and "flavor" of the resulting model  <br/>
    /// This model was built with Llama by Meta.  <br/>
    /// </summary>
    EvaLlama33370B,

    /// <summary>
    /// Grok 2 Vision 1212 advances image-based AI with stronger visual comprehension, refined instruction-following, and multilingual support. From object recognition to style analysis, it empowers developers to build more intuitive, visually aware applications. Its enhanced steerability and reasoning establish a robust foundation for next-generation image solutions.  <br/>
    /// To read more about this model, check out [xAI's announcement](https://x.ai/blog/grok-1212).  <br/>
    /// </summary>
    XaiGrok2Vision1212,

    /// <summary>
    /// Grok 2 1212 introduces significant enhancements to accuracy, instruction adherence, and multilingual support, making it a powerful and flexible choice for developers seeking a highly steerable, intelligent model.  <br/>
    /// </summary>
    XaiGrok21212,

    /// <summary>
    /// Command R7B (12-2024) is a small, fast update of the Command R+ model, delivered in December 2024. It excels at RAG, tool use, agents, and similar tasks requiring complex reasoning and multiple steps.  <br/>
    /// Use of this model is subject to Cohere's [Usage Policy](https://docs.cohere.com/docs/usage-policy) and [SaaS Agreement](https://cohere.com/saas-agreement).  <br/>
    /// </summary>
    CohereCommandR7B122024,

    /// <summary>
    /// Gemini Flash 2.0 offers a significantly faster time to first token (TTFT) compared to [Gemini Flash 1.5](/google/gemini-flash-1.5), while maintaining quality on par with larger models like [Gemini Pro 1.5](/google/gemini-pro-1.5). It introduces notable enhancements in multimodal understanding, coding capabilities, complex instruction following, and function calling. These advancements come together to deliver more seamless and robust agentic experiences.  <br/>
    /// </summary>
    GoogleGeminiFlash20ExperimentalFree,

    /// <summary>
    /// Experimental release (December 6, 2024) of Gemini.  <br/>
    /// </summary>
    GoogleGeminiExperimental1206Free,

    /// <summary>
    /// The Meta Llama 3.3 multilingual large language model (LLM) is a pretrained and instruction tuned generative model in 70B (text in/text out). The Llama 3.3 instruction tuned text only model is optimized for multilingual dialogue use cases and outperforms many of the available open source and closed chat models on common industry benchmarks.  <br/>
    /// Supported languages: English, German, French, Italian, Portuguese, Hindi, Spanish, and Thai.  <br/>
    /// [Model Card](https://github.com/meta-llama/llama-models/blob/main/models/llama3_3/MODEL_CARD.md)  <br/>
    /// </summary>
    MetaLlama3370BInstructFree,

    /// <summary>
    /// The Meta Llama 3.3 multilingual large language model (LLM) is a pretrained and instruction tuned generative model in 70B (text in/text out). The Llama 3.3 instruction tuned text only model is optimized for multilingual dialogue use cases and outperforms many of the available open source and closed chat models on common industry benchmarks.  <br/>
    /// Supported languages: English, German, French, Italian, Portuguese, Hindi, Spanish, and Thai.  <br/>
    /// [Model Card](https://github.com/meta-llama/llama-models/blob/main/models/llama3_3/MODEL_CARD.md)  <br/>
    /// </summary>
    MetaLlama3370BInstruct,

    /// <summary>
    /// Amazon Nova Lite 1.0 is a very low-cost multimodal model from Amazon that focused on fast processing of image, video, and text inputs to generate text output. Amazon Nova Lite can handle real-time customer interactions, document analysis, and visual question-answering tasks with high accuracy.  <br/>
    /// With an input context of 300K tokens, it can analyze multiple images or up to 30 minutes of video in a single input.  <br/>
    /// </summary>
    AmazonNovaLite10,

    /// <summary>
    /// Amazon Nova Micro 1.0 is a text-only model that delivers the lowest latency responses in the Amazon Nova family of models at a very low cost. With a context length of 128K tokens and optimized for speed and cost, Amazon Nova Micro excels at tasks such as text summarization, translation, content classification, interactive chat, and brainstorming. It has  simple mathematical reasoning and coding abilities.  <br/>
    /// </summary>
    AmazonNovaMicro10,

    /// <summary>
    /// Amazon Nova Pro 1.0 is a capable multimodal model from Amazon focused on providing a combination of accuracy, speed, and cost for a wide range of tasks. As of December 2024, it achieves state-of-the-art performance on key benchmarks including visual question answering (TextVQA) and video understanding (VATEX).  <br/>
    /// Amazon Nova Pro demonstrates strong capabilities in processing both visual and textual information and at analyzing financial documents.  <br/>
    /// **NOTE**: Video input is not supported at this time.  <br/>
    /// </summary>
    AmazonNovaPro10,

    /// <summary>
    /// QwQ-32B-Preview is an experimental research model focused on AI reasoning capabilities developed by the Qwen Team. As a preview release, it demonstrates promising analytical abilities while having several important limitations:  <br/>
    /// 1. **Language Mixing and Code-Switching**: The model may mix languages or switch between them unexpectedly, affecting response clarity.  <br/>
    /// 2. **Recursive Reasoning Loops**: The model may enter circular reasoning patterns, leading to lengthy responses without a conclusive answer.  <br/>
    /// 3. **Safety and Ethical Considerations**: The model requires enhanced safety measures to ensure reliable and secure performance, and users should exercise caution when deploying it.  <br/>
    /// 4. **Performance and Benchmark Limitations**: The model excels in math and coding but has room for improvement in other areas, such as common sense reasoning and nuanced language understanding.  <br/>
    /// </summary>
    QwenQwq32BPreview,

    /// <summary>
    /// An experimental version of [Gemini 1.5 Pro](/google/gemini-pro-1.5) from Google.  <br/>
    /// </summary>
    GoogleLearnlm15ProExperimentalFree,

    /// <summary>
    /// EVA Qwen2.5 72B is a roleplay and storywriting specialist model. It's a full-parameter finetune of Qwen2.5-72B on mixture of synthetic and natural data.  <br/>
    /// It uses Celeste 70B 0.1 data mixture, greatly expanding it to improve versatility, creativity and "flavor" of the resulting model.  <br/>
    /// </summary>
    EvaQwen2572B,

    /// <summary>
    /// The 2024-11-20 version of GPT-4o offers a leveled-up creative writing ability with more natural, engaging, and tailored writing to improve relevance and readability. It’s also better at working with uploaded files, providing deeper insights and more thorough responses.  <br/>
    /// GPT-4o ("o" for "omni") is OpenAI's latest AI model, supporting both text and image inputs with text outputs. It maintains the intelligence level of [GPT-4 Turbo](/models/openai/gpt-4-turbo) while being twice as fast and 50% more cost-effective. GPT-4o also offers improved performance in processing non-English languages and enhanced visual capabilities.  <br/>
    /// </summary>
    OpenAiGpt4O20241120,

    /// <summary>
    /// Mistral Large 2 2411 is an update of [Mistral Large 2](/mistralai/mistral-large) released together with [Pixtral Large 2411](/mistralai/pixtral-large-2411)  <br/>
    /// It provides a significant upgrade on the previous [Mistral Large 24.07](/mistralai/mistral-large-2407), with notable improvements in long context understanding, a new system prompt, and more accurate function calling.  <br/>
    /// </summary>
    MistralLarge2411,

    /// <summary>
    /// This is Mistral AI's flagship model, Mistral Large 2 (version mistral-large-2407). It's a proprietary weights-available model and excels at reasoning, code, JSON, chat, and more. Read the launch announcement [here](https://mistral.ai/news/mistral-large-2407/).  <br/>
    /// It supports dozens of languages including French, German, Spanish, Italian, Portuguese, Arabic, Hindi, Russian, Chinese, Japanese, and Korean, along with 80+ coding languages including Python, Java, C, C++, JavaScript, and Bash. Its long context window allows precise information recall from large documents.  <br/>
    /// </summary>
    MistralLarge2407,

    /// <summary>
    /// Pixtral Large is a 124B parameter, open-weight, multimodal model built on top of [Mistral Large 2](/mistralai/mistral-large-2411). The model is able to understand documents, charts and natural images.  <br/>
    /// The model is available under the Mistral Research License (MRL) for research and educational use, and the Mistral Commercial License for experimentation, testing, and production for commercial purposes.  <br/>
    /// </summary>
    MistralPixtralLarge2411,

    /// <summary>
    /// Grok Vision Beta is xAI's experimental language model with vision capability.  <br/>
    /// </summary>
    XaiGrokVisionBeta,

    /// <summary>
    /// Inferor 12B is a merge of top roleplay models, expert on immersive narratives and storytelling.  <br/>
    /// This model was merged using the [Model Stock](https://arxiv.org/abs/2403.19522) merge method using [anthracite-org/magnum-v4-12b](https://openrouter.ai/anthracite-org/magnum-v4-72b) as a base.  <br/>
    /// </summary>
    InfermaticMistralNemoInferor12B,

    /// <summary>
    /// Qwen2.5-Coder is the latest series of Code-Specific Qwen large language models (formerly known as CodeQwen). Qwen2.5-Coder brings the following improvements upon CodeQwen1.5:  <br/>
    /// - Significantly improvements in **code generation**, **code reasoning** and **code fixing**.   <br/>
    /// - A more comprehensive foundation for real-world applications such as **Code Agents**. Not only enhancing coding capabilities but also maintaining its strengths in mathematics and general competencies.  <br/>
    /// To read more about its evaluation results, check out [Qwen 2.5 Coder's blog](https://qwenlm.github.io/blog/qwen2.5-coder-family/).  <br/>
    /// </summary>
    Qwen25Coder32BInstructFree,

    /// <summary>
    /// Qwen2.5-Coder is the latest series of Code-Specific Qwen large language models (formerly known as CodeQwen). Qwen2.5-Coder brings the following improvements upon CodeQwen1.5:  <br/>
    /// - Significantly improvements in **code generation**, **code reasoning** and **code fixing**.   <br/>
    /// - A more comprehensive foundation for real-world applications such as **Code Agents**. Not only enhancing coding capabilities but also maintaining its strengths in mathematics and general competencies.  <br/>
    /// To read more about its evaluation results, check out [Qwen 2.5 Coder's blog](https://qwenlm.github.io/blog/qwen2.5-coder-family/).  <br/>
    /// </summary>
    Qwen25Coder32BInstruct,

    /// <summary>
    /// SorcererLM is an advanced RP and storytelling model, built as a Low-rank 16-bit LoRA fine-tuned on [WizardLM-2 8x22B](/microsoft/wizardlm-2-8x22b).  <br/>
    /// - Advanced reasoning and emotional intelligence for engaging and immersive interactions  <br/>
    /// - Vivid writing capabilities enriched with spatial and contextual awareness  <br/>
    /// - Enhanced narrative depth, promoting creative and dynamic storytelling  <br/>
    /// </summary>
    Sorcererlm8X22b,

    /// <summary>
    /// EVA Qwen2.5 32B is a roleplaying/storywriting specialist model. It's a full-parameter finetune of Qwen2.5-32B on mixture of synthetic and natural data.  <br/>
    /// It uses Celeste 70B 0.1 data mixture, greatly expanding it to improve versatility, creativity and "flavor" of the resulting model.  <br/>
    /// </summary>
    EvaQwen2532B,

    /// <summary>
    /// UnslopNemo v4.1 is the latest addition from the creator of Rocinante, designed for adventure writing and role-play scenarios.  <br/>
    /// </summary>
    Unslopnemo12B,

    /// <summary>
    /// Claude 3.5 Haiku features enhancements across all skill sets including coding, tool use, and reasoning. As the fastest model in the Anthropic lineup, it offers rapid response times suitable for applications that require high interactivity and low latency, such as user-facing chatbots and on-the-fly code completions. It also excels in specialized tasks like data extraction and real-time content moderation, making it a versatile tool for a broad range of industries.  <br/>
    /// It does not support image inputs.  <br/>
    /// See the launch announcement and benchmark results [here](https://www.anthropic.com/news/3-5-models-and-computer-use)  <br/>
    /// </summary>
    AnthropicClaude35Haiku20241022SelfModerated,

    /// <summary>
    /// Claude 3.5 Haiku features enhancements across all skill sets including coding, tool use, and reasoning. As the fastest model in the Anthropic lineup, it offers rapid response times suitable for applications that require high interactivity and low latency, such as user-facing chatbots and on-the-fly code completions. It also excels in specialized tasks like data extraction and real-time content moderation, making it a versatile tool for a broad range of industries.  <br/>
    /// It does not support image inputs.  <br/>
    /// See the launch announcement and benchmark results [here](https://www.anthropic.com/news/3-5-models-and-computer-use)  <br/>
    /// </summary>
    AnthropicClaude35Haiku20241022,

    /// <summary>
    /// Claude 3.5 Haiku features offers enhanced capabilities in speed, coding accuracy, and tool use. Engineered to excel in real-time applications, it delivers quick response times that are essential for dynamic tasks such as chat interactions and immediate coding suggestions.  <br/>
    /// This makes it highly suitable for environments that demand both speed and precision, such as software development, customer service bots, and data management systems.  <br/>
    /// This model is currently pointing to [Claude 3.5 Haiku (2024-10-22)](/anthropic/claude-3-5-haiku-20241022).  <br/>
    /// </summary>
    AnthropicClaude35HaikuSelfModerated,

    /// <summary>
    /// Claude 3.5 Haiku features offers enhanced capabilities in speed, coding accuracy, and tool use. Engineered to excel in real-time applications, it delivers quick response times that are essential for dynamic tasks such as chat interactions and immediate coding suggestions.  <br/>
    /// This makes it highly suitable for environments that demand both speed and precision, such as software development, customer service bots, and data management systems.  <br/>
    /// This model is currently pointing to [Claude 3.5 Haiku (2024-10-22)](/anthropic/claude-3-5-haiku-20241022).  <br/>
    /// </summary>
    AnthropicClaude35Haiku,

    /// <summary>
    /// Lumimaid v0.2 70B is a finetune of [Llama 3.1 70B](/meta-llama/llama-3.1-70b-instruct) with a "HUGE step up dataset wise" compared to Lumimaid v0.1. Sloppy chats output were purged.  <br/>
    /// Usage of this model is subject to [Meta's Acceptable Use Policy](https://llama.meta.com/llama3/use-policy/).  <br/>
    /// </summary>
    NeversleepLumimaidV0270B,

    /// <summary>
    /// This is a series of models designed to replicate the prose quality of the Claude 3 models, specifically Sonnet(https://openrouter.ai/anthropic/claude-3.5-sonnet) and Opus(https://openrouter.ai/anthropic/claude-3-opus).  <br/>
    /// The model is fine-tuned on top of [Qwen2.5 72B](https://openrouter.ai/qwen/qwen-2.5-72b-instruct).  <br/>
    /// </summary>
    MagnumV472B,

    /// <summary>
    /// New Claude 3.5 Sonnet delivers better-than-Opus capabilities, faster-than-Sonnet speeds, at the same Sonnet prices. Sonnet is particularly good at:  <br/>
    /// - Coding: Scores ~49% on SWE-Bench Verified, higher than the last best score, and without any fancy prompt scaffolding  <br/>
    /// - Data science: Augments human data science expertise; navigates unstructured data while using multiple tools for insights  <br/>
    /// - Visual processing: excelling at interpreting charts, graphs, and images, accurately transcribing text to derive insights beyond just the text alone  <br/>
    /// - Agentic tasks: exceptional tool use, making it great at agentic tasks (i.e. complex, multi-step problem solving tasks that require engaging with other systems)  <br/>
    /// #multimodal  <br/>
    /// </summary>
    AnthropicClaude35SonnetSelfModerated,

    /// <summary>
    /// New Claude 3.5 Sonnet delivers better-than-Opus capabilities, faster-than-Sonnet speeds, at the same Sonnet prices. Sonnet is particularly good at:  <br/>
    /// - Coding: Scores ~49% on SWE-Bench Verified, higher than the last best score, and without any fancy prompt scaffolding  <br/>
    /// - Data science: Augments human data science expertise; navigates unstructured data while using multiple tools for insights  <br/>
    /// - Visual processing: excelling at interpreting charts, graphs, and images, accurately transcribing text to derive insights beyond just the text alone  <br/>
    /// - Agentic tasks: exceptional tool use, making it great at agentic tasks (i.e. complex, multi-step problem solving tasks that require engaging with other systems)  <br/>
    /// #multimodal  <br/>
    /// </summary>
    AnthropicClaude35Sonnet,

    /// <summary>
    /// Grok Beta is xAI's experimental language model with state-of-the-art reasoning capabilities, best for complex and multi-step use cases.  <br/>
    /// It is the successor of [Grok 2](https://x.ai/blog/grok-2) with enhanced context length.  <br/>
    /// </summary>
    XaiGrokBeta,

    /// <summary>
    /// Ministral 8B is an 8B parameter model featuring a unique interleaved sliding-window attention pattern for faster, memory-efficient inference. Designed for edge use cases, it supports up to 128k context length and excels in knowledge and reasoning tasks. It outperforms peers in the sub-10B category, making it perfect for low-latency, privacy-first applications.  <br/>
    /// </summary>
    MistralMinistral8B,

    /// <summary>
    /// Ministral 3B is a 3B parameter model optimized for on-device and edge computing. It excels in knowledge, commonsense reasoning, and function-calling, outperforming larger models like Mistral 7B on most benchmarks. Supporting up to 128k context length, it’s ideal for orchestrating agentic workflows and specialist tasks with efficient inference.  <br/>
    /// </summary>
    MistralMinistral3B,

    /// <summary>
    /// Qwen2.5 7B is the latest series of Qwen large language models. Qwen2.5 brings the following improvements upon Qwen2:  <br/>
    /// - Significantly more knowledge and has greatly improved capabilities in coding and mathematics, thanks to our specialized expert models in these domains.  <br/>
    /// - Significant improvements in instruction following, generating long texts (over 8K tokens), understanding structured data (e.g, tables), and generating structured outputs especially JSON. More resilient to the diversity of system prompts, enhancing role-play implementation and condition-setting for chatbots.  <br/>
    /// - Long-context Support up to 128K tokens and can generate up to 8K tokens.  <br/>
    /// - Multilingual support for over 29 languages, including Chinese, English, French, Spanish, Portuguese, German, Italian, Russian, Japanese, Korean, Vietnamese, Thai, Arabic, and more.  <br/>
    /// Usage of this model is subject to [Tongyi Qianwen LICENSE AGREEMENT](https://huggingface.co/Qwen/Qwen1.5-110B-Chat/blob/main/LICENSE).  <br/>
    /// </summary>
    Qwen257BInstruct,

    /// <summary>
    /// NVIDIA's Llama 3.1 Nemotron 70B is a language model designed for generating precise and useful responses. Leveraging [Llama 3.1 70B](/models/meta-llama/llama-3.1-70b-instruct) architecture and Reinforcement Learning from Human Feedback (RLHF), it excels in automatic alignment benchmarks. This model is tailored for applications requiring high accuracy in helpfulness and response generation, suitable for diverse user queries across multiple domains.  <br/>
    /// Usage of this model is subject to [Meta's Acceptable Use Policy](https://www.llama.com/llama3/use-policy/).  <br/>
    /// </summary>
    NvidiaLlama31Nemotron70BInstructFree,

    /// <summary>
    /// NVIDIA's Llama 3.1 Nemotron 70B is a language model designed for generating precise and useful responses. Leveraging [Llama 3.1 70B](/models/meta-llama/llama-3.1-70b-instruct) architecture and Reinforcement Learning from Human Feedback (RLHF), it excels in automatic alignment benchmarks. This model is tailored for applications requiring high accuracy in helpfulness and response generation, suitable for diverse user queries across multiple domains.  <br/>
    /// Usage of this model is subject to [Meta's Acceptable Use Policy](https://www.llama.com/llama3/use-policy/).  <br/>
    /// </summary>
    NvidiaLlama31Nemotron70BInstruct,

    /// <summary>
    /// Inflection 3 Pi powers Inflection's [Pi](https://pi.ai) chatbot, including backstory, emotional intelligence, productivity, and safety. It has access to recent news, and excels in scenarios like customer support and roleplay.  <br/>
    /// Pi has been trained to mirror your tone and style, if you use more emojis, so will Pi! Try experimenting with various prompts and conversation styles.  <br/>
    /// </summary>
    InflectionInflection3Pi,

    /// <summary>
    /// Inflection 3 Productivity is optimized for following instructions. It is better for tasks requiring JSON output or precise adherence to provided guidelines. It has access to recent news.  <br/>
    /// For emotional intelligence similar to Pi, see [Inflect 3 Pi](/inflection/inflection-3-pi)  <br/>
    /// See [Inflection's announcement](https://inflection.ai/blog/enterprise) for more details.  <br/>
    /// </summary>
    InflectionInflection3Productivity,

    /// <summary>
    /// Gemini Flash 1.5 8B is optimized for speed and efficiency, offering enhanced performance in small prompt tasks like chat, transcription, and translation. With reduced latency, it is highly effective for real-time and large-scale operations. This model focuses on cost-effective solutions while maintaining high-quality results.  <br/>
    /// [Click here to learn more about this model](https://developers.googleblog.com/en/gemini-15-flash-8b-is-now-generally-available-for-use/).  <br/>
    /// Usage of Gemini is subject to Google's [Gemini Terms of Use](https://ai.google.dev/terms).  <br/>
    /// </summary>
    GoogleGeminiFlash158B,

    /// <summary>
    /// From the maker of [Goliath](https://openrouter.ai/models/alpindale/goliath-120b), Magnum 72B is the seventh in a family of models designed to achieve the prose quality of the Claude 3 models, notably Opus and Sonnet.  <br/>
    /// The model is based on [Qwen2 72B](https://openrouter.ai/models/qwen/qwen-2-72b-instruct) and trained with 55 million tokens of highly curated roleplay (RP) data.  <br/>
    /// </summary>
    MagnumV272B,

    /// <summary>
    /// Liquid's 40.3B Mixture of Experts (MoE) model. Liquid Foundation Models (LFMs) are large neural networks built with computational units rooted in dynamic systems.  <br/>
    /// LFMs are general-purpose AI models that can be used to model any kind of sequential data, including video, audio, text, time series, and signals.  <br/>
    /// See the [launch announcement](https://www.liquid.ai/liquid-foundation-models) for benchmarks and more info.  <br/>
    /// </summary>
    LiquidLfm40BMoe,

    /// <summary>
    /// Rocinante 12B is designed for engaging storytelling and rich prose.  <br/>
    /// Early testers have reported:  <br/>
    /// - Expanded vocabulary with unique and expressive word choices  <br/>
    /// - Enhanced creativity for vivid narratives  <br/>
    /// - Adventure-filled and captivating stories  <br/>
    /// </summary>
    Rocinante12B,

    /// <summary>
    /// Llama 3.2 3B is a 3-billion-parameter multilingual large language model, optimized for advanced natural language processing tasks like dialogue generation, reasoning, and summarization. Designed with the latest transformer architecture, it supports eight languages, including English, Spanish, and Hindi, and is adaptable for additional languages.  <br/>
    /// Trained on 9 trillion tokens, the Llama 3.2 3B model excels in instruction-following, complex reasoning, and tool use. Its balanced performance makes it ideal for applications needing accuracy and efficiency in text generation across multilingual settings.  <br/>
    /// Click here for the [original model card](https://github.com/meta-llama/llama-models/blob/main/models/llama3_2/MODEL_CARD.md).  <br/>
    /// Usage of this model is subject to [Meta's Acceptable Use Policy](https://www.llama.com/llama3/use-policy/).  <br/>
    /// </summary>
    MetaLlama323BInstruct,

    /// <summary>
    /// Llama 3.2 1B is a 1-billion-parameter language model focused on efficiently performing natural language tasks, such as summarization, dialogue, and multilingual text analysis. Its smaller size allows it to operate efficiently in low-resource environments while maintaining strong task performance.  <br/>
    /// Supporting eight core languages and fine-tunable for more, Llama 1.3B is ideal for businesses or developers seeking lightweight yet powerful AI solutions that can operate in diverse multilingual settings without the high computational demand of larger models.  <br/>
    /// Click here for the [original model card](https://github.com/meta-llama/llama-models/blob/main/models/llama3_2/MODEL_CARD.md).  <br/>
    /// Usage of this model is subject to [Meta's Acceptable Use Policy](https://www.llama.com/llama3/use-policy/).  <br/>
    /// </summary>
    MetaLlama321BInstructFree,

    /// <summary>
    /// Llama 3.2 1B is a 1-billion-parameter language model focused on efficiently performing natural language tasks, such as summarization, dialogue, and multilingual text analysis. Its smaller size allows it to operate efficiently in low-resource environments while maintaining strong task performance.  <br/>
    /// Supporting eight core languages and fine-tunable for more, Llama 1.3B is ideal for businesses or developers seeking lightweight yet powerful AI solutions that can operate in diverse multilingual settings without the high computational demand of larger models.  <br/>
    /// Click here for the [original model card](https://github.com/meta-llama/llama-models/blob/main/models/llama3_2/MODEL_CARD.md).  <br/>
    /// Usage of this model is subject to [Meta's Acceptable Use Policy](https://www.llama.com/llama3/use-policy/).  <br/>
    /// </summary>
    MetaLlama321BInstruct,

    /// <summary>
    /// The Llama 90B Vision model is a top-tier, 90-billion-parameter multimodal model designed for the most challenging visual reasoning and language tasks. It offers unparalleled accuracy in image captioning, visual question answering, and advanced image-text comprehension. Pre-trained on vast multimodal datasets and fine-tuned with human feedback, the Llama 90B Vision is engineered to handle the most demanding image-based AI tasks.  <br/>
    /// This model is perfect for industries requiring cutting-edge multimodal AI capabilities, particularly those dealing with complex, real-time visual and textual analysis.  <br/>
    /// Click here for the [original model card](https://github.com/meta-llama/llama-models/blob/main/models/llama3_2/MODEL_CARD_VISION.md).  <br/>
    /// Usage of this model is subject to [Meta's Acceptable Use Policy](https://www.llama.com/llama3/use-policy/).  <br/>
    /// </summary>
    MetaLlama3290BVisionInstruct,

    /// <summary>
    /// Llama 3.2 11B Vision is a multimodal model with 11 billion parameters, designed to handle tasks combining visual and textual data. It excels in tasks such as image captioning and visual question answering, bridging the gap between language generation and visual reasoning. Pre-trained on a massive dataset of image-text pairs, it performs well in complex, high-accuracy image analysis.  <br/>
    /// Its ability to integrate visual understanding with language processing makes it an ideal solution for industries requiring comprehensive visual-linguistic AI applications, such as content creation, AI-driven customer service, and research.  <br/>
    /// Click here for the [original model card](https://github.com/meta-llama/llama-models/blob/main/models/llama3_2/MODEL_CARD_VISION.md).  <br/>
    /// Usage of this model is subject to [Meta's Acceptable Use Policy](https://www.llama.com/llama3/use-policy/).  <br/>
    /// </summary>
    MetaLlama3211BVisionInstructFree,

    /// <summary>
    /// Llama 3.2 11B Vision is a multimodal model with 11 billion parameters, designed to handle tasks combining visual and textual data. It excels in tasks such as image captioning and visual question answering, bridging the gap between language generation and visual reasoning. Pre-trained on a massive dataset of image-text pairs, it performs well in complex, high-accuracy image analysis.  <br/>
    /// Its ability to integrate visual understanding with language processing makes it an ideal solution for industries requiring comprehensive visual-linguistic AI applications, such as content creation, AI-driven customer service, and research.  <br/>
    /// Click here for the [original model card](https://github.com/meta-llama/llama-models/blob/main/models/llama3_2/MODEL_CARD_VISION.md).  <br/>
    /// Usage of this model is subject to [Meta's Acceptable Use Policy](https://www.llama.com/llama3/use-policy/).  <br/>
    /// </summary>
    MetaLlama3211BVisionInstruct,

    /// <summary>
    /// Qwen2.5 72B is the latest series of Qwen large language models. Qwen2.5 brings the following improvements upon Qwen2:  <br/>
    /// - Significantly more knowledge and has greatly improved capabilities in coding and mathematics, thanks to our specialized expert models in these domains.  <br/>
    /// - Significant improvements in instruction following, generating long texts (over 8K tokens), understanding structured data (e.g, tables), and generating structured outputs especially JSON. More resilient to the diversity of system prompts, enhancing role-play implementation and condition-setting for chatbots.  <br/>
    /// - Long-context Support up to 128K tokens and can generate up to 8K tokens.  <br/>
    /// - Multilingual support for over 29 languages, including Chinese, English, French, Spanish, Portuguese, German, Italian, Russian, Japanese, Korean, Vietnamese, Thai, Arabic, and more.  <br/>
    /// Usage of this model is subject to [Tongyi Qianwen LICENSE AGREEMENT](https://huggingface.co/Qwen/Qwen1.5-110B-Chat/blob/main/LICENSE).  <br/>
    /// </summary>
    Qwen2572BInstruct,

    /// <summary>
    /// Qwen2 VL 72B is a multimodal LLM from the Qwen Team with the following key enhancements:  <br/>
    /// - SoTA understanding of images of various resolution and ratio: Qwen2-VL achieves state-of-the-art performance on visual understanding benchmarks, including MathVista, DocVQA, RealWorldQA, MTVQA, etc.  <br/>
    /// - Understanding videos of 20min+: Qwen2-VL can understand videos over 20 minutes for high-quality video-based question answering, dialog, content creation, etc.  <br/>
    /// - Agent that can operate your mobiles, robots, etc.: with the abilities of complex reasoning and decision making, Qwen2-VL can be integrated with devices like mobile phones, robots, etc., for automatic operation based on visual environment and text instructions.  <br/>
    /// - Multilingual Support: to serve global users, besides English and Chinese, Qwen2-VL now supports the understanding of texts in different languages inside images, including most European languages, Japanese, Korean, Arabic, Vietnamese, etc.  <br/>
    /// For more details, see this [blog post](https://qwenlm.github.io/blog/qwen2-vl/) and [GitHub repo](https://github.com/QwenLM/Qwen2-VL).  <br/>
    /// Usage of this model is subject to [Tongyi Qianwen LICENSE AGREEMENT](https://huggingface.co/Qwen/Qwen1.5-110B-Chat/blob/main/LICENSE).  <br/>
    /// </summary>
    Qwen2Vl72BInstruct,

    /// <summary>
    /// Lumimaid v0.2 8B is a finetune of [Llama 3.1 8B](/models/meta-llama/llama-3.1-8b-instruct) with a "HUGE step up dataset wise" compared to Lumimaid v0.1. Sloppy chats output were purged.  <br/>
    /// Usage of this model is subject to [Meta's Acceptable Use Policy](https://llama.meta.com/llama3/use-policy/).  <br/>
    /// </summary>
    NeversleepLumimaidV028B,

    /// <summary>
    /// The latest and strongest model family from OpenAI, o1 is designed to spend more time thinking before responding.  <br/>
    /// The o1 models are optimized for math, science, programming, and other STEM-related tasks. They consistently exhibit PhD-level accuracy on benchmarks in physics, chemistry, and biology. Learn more in the [launch announcement](https://openai.com/o1).  <br/>
    /// Note: This model is currently experimental and not suitable for production use-cases, and may be heavily rate-limited.  <br/>
    /// </summary>
    OpenAiO1Mini20240912,

    /// <summary>
    /// The latest and strongest model family from OpenAI, o1 is designed to spend more time thinking before responding.  <br/>
    /// The o1 models are optimized for math, science, programming, and other STEM-related tasks. They consistently exhibit PhD-level accuracy on benchmarks in physics, chemistry, and biology. Learn more in the [launch announcement](https://openai.com/o1).  <br/>
    /// Note: This model is currently experimental and not suitable for production use-cases, and may be heavily rate-limited.  <br/>
    /// </summary>
    OpenAiO1Preview,

    /// <summary>
    /// The latest and strongest model family from OpenAI, o1 is designed to spend more time thinking before responding.  <br/>
    /// The o1 models are optimized for math, science, programming, and other STEM-related tasks. They consistently exhibit PhD-level accuracy on benchmarks in physics, chemistry, and biology. Learn more in the [launch announcement](https://openai.com/o1).  <br/>
    /// Note: This model is currently experimental and not suitable for production use-cases, and may be heavily rate-limited.  <br/>
    /// </summary>
    OpenAiO1Preview20240912,

    /// <summary>
    /// The latest and strongest model family from OpenAI, o1 is designed to spend more time thinking before responding.  <br/>
    /// The o1 models are optimized for math, science, programming, and other STEM-related tasks. They consistently exhibit PhD-level accuracy on benchmarks in physics, chemistry, and biology. Learn more in the [launch announcement](https://openai.com/o1).  <br/>
    /// Note: This model is currently experimental and not suitable for production use-cases, and may be heavily rate-limited.  <br/>
    /// </summary>
    OpenAiO1Mini,

    /// <summary>
    /// The first multi-modal, text+image-to-text model from Mistral AI. Its weights were launched via torrent: https://x.com/mistralai/status/1833758285167722836.  <br/>
    /// </summary>
    MistralPixtral12B,

    /// <summary>
    /// command-r-08-2024 is an update of the [Command R](/models/cohere/command-r) with improved performance for multilingual retrieval-augmented generation (RAG) and tool use. More broadly, it is better at math, code and reasoning and is competitive with the previous version of the larger Command R+ model.  <br/>
    /// Read the launch post [here](https://docs.cohere.com/changelog/command-gets-refreshed).  <br/>
    /// Use of this model is subject to Cohere's [Usage Policy](https://docs.cohere.com/docs/usage-policy) and [SaaS Agreement](https://cohere.com/saas-agreement).  <br/>
    /// </summary>
    CohereCommandR082024,

    /// <summary>
    /// command-r-plus-08-2024 is an update of the [Command R+](/models/cohere/command-r-plus) with roughly 50% higher throughput and 25% lower latencies as compared to the previous Command R+ version, while keeping the hardware footprint the same.  <br/>
    /// Read the launch post [here](https://docs.cohere.com/changelog/command-gets-refreshed).  <br/>
    /// Use of this model is subject to Cohere's [Usage Policy](https://docs.cohere.com/docs/usage-policy) and [SaaS Agreement](https://cohere.com/saas-agreement).  <br/>
    /// </summary>
    CohereCommandRPlus082024,

    /// <summary>
    /// Qwen2 VL 7B is a multimodal LLM from the Qwen Team with the following key enhancements:  <br/>
    /// - SoTA understanding of images of various resolution and ratio: Qwen2-VL achieves state-of-the-art performance on visual understanding benchmarks, including MathVista, DocVQA, RealWorldQA, MTVQA, etc.  <br/>
    /// - Understanding videos of 20min+: Qwen2-VL can understand videos over 20 minutes for high-quality video-based question answering, dialog, content creation, etc.  <br/>
    /// - Agent that can operate your mobiles, robots, etc.: with the abilities of complex reasoning and decision making, Qwen2-VL can be integrated with devices like mobile phones, robots, etc., for automatic operation based on visual environment and text instructions.  <br/>
    /// - Multilingual Support: to serve global users, besides English and Chinese, Qwen2-VL now supports the understanding of texts in different languages inside images, including most European languages, Japanese, Korean, Arabic, Vietnamese, etc.  <br/>
    /// For more details, see this [blog post](https://qwenlm.github.io/blog/qwen2-vl/) and [GitHub repo](https://github.com/QwenLM/Qwen2-VL).  <br/>
    /// Usage of this model is subject to [Tongyi Qianwen LICENSE AGREEMENT](https://huggingface.co/Qwen/Qwen1.5-110B-Chat/blob/main/LICENSE).  <br/>
    /// </summary>
    Qwen2Vl7BInstruct,

    /// <summary>
    /// Euryale L3.1 70B v2.2 is a model focused on creative roleplay from [Sao10k](https://ko-fi.com/sao10k). It is the successor of [Euryale L3 70B v2.1](/models/sao10k/l3-euryale-70b).  <br/>
    /// </summary>
    Sao10kLlama31Euryale70BV22,

    /// <summary>
    /// Gemini Flash 1.5 8B Experimental is an experimental, 8B parameter version of the [Gemini Flash 1.5](/models/google/gemini-flash-1.5) model.  <br/>
    /// Usage of Gemini is subject to Google's [Gemini Terms of Use](https://ai.google.dev/terms).  <br/>
    /// #multimodal  <br/>
    /// Note: This model is currently experimental and not suitable for production use-cases, and may be heavily rate-limited.  <br/>
    /// </summary>
    GoogleGeminiFlash158BExperimental,

    /// <summary>
    /// Jamba 1.5 Large is part of AI21's new family of open models, offering superior speed, efficiency, and quality.  <br/>
    /// It features a 256K effective context window, the longest among open models, enabling improved performance on tasks like document summarization and analysis.  <br/>
    /// Built on a novel SSM-Transformer architecture, it outperforms larger models like Llama 3.1 70B on benchmarks while maintaining resource efficiency.  <br/>
    /// Read their [announcement](https://www.ai21.com/blog/announcing-jamba-model-family) to learn more.  <br/>
    /// </summary>
    Ai21Jamba15Large,

    /// <summary>
    /// Jamba 1.5 Mini is the world's first production-grade Mamba-based model, combining SSM and Transformer architectures for a 256K context window and high efficiency.  <br/>
    /// It works with 9 languages and can handle various writing and analysis tasks as well as or better than similar small models.  <br/>
    /// This model uses less computer memory and works faster with longer texts than previous designs.  <br/>
    /// Read their [announcement](https://www.ai21.com/blog/announcing-jamba-model-family) to learn more.  <br/>
    /// </summary>
    Ai21Jamba15Mini,

    /// <summary>
    /// Phi-3.5 models are lightweight, state-of-the-art open models. These models were trained with Phi-3 datasets that include both synthetic data and the filtered, publicly available websites data, with a focus on high quality and reasoning-dense properties. Phi-3.5 Mini uses 3.8B parameters, and is a dense decoder-only transformer model using the same tokenizer as [Phi-3 Mini](/models/microsoft/phi-3-mini-128k-instruct).  <br/>
    /// The models underwent a rigorous enhancement process, incorporating both supervised fine-tuning, proximal policy optimization, and direct preference optimization to ensure precise instruction adherence and robust safety measures. When assessed against benchmarks that test common sense, language understanding, math, code, long context and logical reasoning, Phi-3.5 models showcased robust and state-of-the-art performance among models with less than 13 billion parameters.  <br/>
    /// </summary>
    MicrosoftPhi35Mini128KInstruct,

    /// <summary>
    /// Hermes 3 is a generalist language model with many improvements over [Hermes 2](/models/nousresearch/nous-hermes-2-mistral-7b-dpo), including advanced agentic capabilities, much better roleplaying, reasoning, multi-turn conversation, long context coherence, and improvements across the board.  <br/>
    /// Hermes 3 70B is a competitive, if not superior finetune of the [Llama-3.1 70B foundation model](/models/meta-llama/llama-3.1-70b-instruct), focused on aligning LLMs to the user, with powerful steering capabilities and control given to the end user.  <br/>
    /// The Hermes 3 series builds and expands on the Hermes 2 set of capabilities, including more powerful and reliable function calling and structured output capabilities, generalist assistant capabilities, and improved code generation skills.  <br/>
    /// </summary>
    NousHermes370BInstruct,

    /// <summary>
    /// Hermes 3 is a generalist language model with many improvements over Hermes 2, including advanced agentic capabilities, much better roleplaying, reasoning, multi-turn conversation, long context coherence, and improvements across the board.  <br/>
    /// Hermes 3 405B is a frontier-level, full-parameter finetune of the Llama-3.1 405B foundation model, focused on aligning LLMs to the user, with powerful steering capabilities and control given to the end user.  <br/>
    /// The Hermes 3 series builds and expands on the Hermes 2 set of capabilities, including more powerful and reliable function calling and structured output capabilities, generalist assistant capabilities, and improved code generation skills.  <br/>
    /// Hermes 3 is competitive, if not superior, to Llama-3.1 Instruct models at general capabilities, with varying strengths and weaknesses attributable between the two.  <br/>
    /// </summary>
    NousHermes3405BInstruct,

    /// <summary>
    /// OpenAI ChatGPT 4o is continually updated by OpenAI to point to the current version of GPT-4o used by ChatGPT. It therefore differs slightly from the API version of [GPT-4o](/models/openai/gpt-4o) in that it has additional RLHF. It is intended for research and evaluation.  <br/>
    /// OpenAI notes that this model is not suited for production use-cases as it may be removed or redirected to another model in the future.  <br/>
    /// </summary>
    OpenAiChatgpt4O,

    /// <summary>
    /// Lunaris 8B is a versatile generalist and roleplaying model based on Llama 3. It's a strategic merge of multiple models, designed to balance creativity with improved logic and general knowledge.  <br/>
    /// Created by [Sao10k](https://huggingface.co/Sao10k), this model aims to offer an improved experience over Stheno v3.2, with enhanced creativity and logical reasoning.  <br/>
    /// For best results, use with Llama 3 Instruct context template, temperature 1.4, and min_p 0.1.  <br/>
    /// </summary>
    Sao10kLlama38BLunaris,

    /// <summary>
    /// Starcannon 12B v2 is a creative roleplay and story writing model, based on Mistral Nemo, using [nothingiisreal/mn-celeste-12b](/nothingiisreal/mn-celeste-12b) as a base, with [intervitens/mini-magnum-12b-v1.1](https://huggingface.co/intervitens/mini-magnum-12b-v1.1) merged in using the [TIES](https://arxiv.org/abs/2306.01708) method.  <br/>
    /// Although more similar to Magnum overall, the model remains very creative, with a pleasant writing style. It is recommended for people wanting more variety than Magnum, and yet more verbose prose than Celeste.  <br/>
    /// </summary>
    AetherwiingStarcannon12B,

    /// <summary>
    /// The 2024-08-06 version of GPT-4o offers improved performance in structured outputs, with the ability to supply a JSON schema in the respone_format. Read more [here](https://openai.com/index/introducing-structured-outputs-in-the-api/).  <br/>
    /// GPT-4o ("o" for "omni") is OpenAI's latest AI model, supporting both text and image inputs with text outputs. It maintains the intelligence level of [GPT-4 Turbo](/models/openai/gpt-4-turbo) while being twice as fast and 50% more cost-effective. GPT-4o also offers improved performance in processing non-English languages and enhanced visual capabilities.  <br/>
    /// For benchmarking against other models, it was briefly called ["im-also-a-good-gpt2-chatbot"](https://twitter.com/LiamFedus/status/1790064963966370209)  <br/>
    /// </summary>
    OpenAiGpt4O20240806,

    /// <summary>
    /// Meta's latest class of model (Llama 3.1) launched with a variety of sizes and flavors. This is the base 405B pre-trained version.  <br/>
    /// It has demonstrated strong performance compared to leading closed-source models in human evaluations.  <br/>
    /// To read more about the model release, [click here](https://ai.meta.com/blog/meta-llama-3/). Usage of this model is subject to [Meta's Acceptable Use Policy](https://llama.meta.com/llama3/use-policy/).  <br/>
    /// </summary>
    MetaLlama31405BBase,

    /// <summary>
    /// A specialized story writing and roleplaying model based on Mistral's NeMo 12B Instruct. Fine-tuned on curated datasets including Reddit Writing Prompts and Opus Instruct 25K.  <br/>
    /// This model excels at creative writing, offering improved NSFW capabilities, with smarter and more active narration. It demonstrates remarkable versatility in both SFW and NSFW scenarios, with strong Out of Character (OOC) steering capabilities, allowing fine-tuned control over narrative direction and character behavior.  <br/>
    /// Check out the model's [HuggingFace page](https://huggingface.co/nothingiisreal/MN-12B-Celeste-V1.9) for details on what parameters and prompts work best!  <br/>
    /// </summary>
    MistralNemo12BCeleste,

    /// <summary>
    /// Llama 3.1 Sonar is Perplexity's latest model family. It surpasses their earlier Sonar models in cost-efficiency, speed, and performance.  <br/>
    /// This is a normal offline LLM, but the [online version](/models/perplexity/llama-3.1-sonar-small-128k-online) of this model has Internet access.  <br/>
    /// </summary>
    PerplexityLlama31Sonar8B,

    /// <summary>
    /// Llama 3.1 Sonar is Perplexity's latest model family. It surpasses their earlier Sonar models in cost-efficiency, speed, and performance.  <br/>
    /// This is a normal offline LLM, but the [online version](/models/perplexity/llama-3.1-sonar-large-128k-online) of this model has Internet access.  <br/>
    /// </summary>
    PerplexityLlama31Sonar70B,

    /// <summary>
    /// Llama 3.1 Sonar is Perplexity's latest model family. It surpasses their earlier Sonar models in cost-efficiency, speed, and performance.  <br/>
    /// This is the online version of the [offline chat model](/models/perplexity/llama-3.1-sonar-large-128k-chat). It is focused on delivering helpful, up-to-date, and factual responses. #online  <br/>
    /// </summary>
    PerplexityLlama31Sonar70BOnline,

    /// <summary>
    /// Llama 3.1 Sonar is Perplexity's latest model family. It surpasses their earlier Sonar models in cost-efficiency, speed, and performance.  <br/>
    /// This is the online version of the [offline chat model](/models/perplexity/llama-3.1-sonar-small-128k-chat). It is focused on delivering helpful, up-to-date, and factual responses. #online  <br/>
    /// </summary>
    PerplexityLlama31Sonar8BOnline,

    /// <summary>
    /// The highly anticipated 400B class of Llama3 is here! Clocking in at 128k context with impressive eval scores, the Meta AI team continues to push the frontier of open-source LLMs.  <br/>
    /// Meta's latest class of model (Llama 3.1) launched with a variety of sizes and flavors. This 405B instruct-tuned version is optimized for high quality dialogue usecases.  <br/>
    /// It has demonstrated strong performance compared to leading closed-source models including GPT-4o and Claude 3.5 Sonnet in evaluations.  <br/>
    /// To read more about the model release, [click here](https://ai.meta.com/blog/meta-llama-3-1/). Usage of this model is subject to [Meta's Acceptable Use Policy](https://llama.meta.com/llama3/use-policy/).  <br/>
    /// </summary>
    MetaLlama31405BInstruct,

    /// <summary>
    /// Meta's latest class of model (Llama 3.1) launched with a variety of sizes and flavors. This 8B instruct-tuned version is fast and efficient.  <br/>
    /// It has demonstrated strong performance compared to leading closed-source models in human evaluations.  <br/>
    /// To read more about the model release, [click here](https://ai.meta.com/blog/meta-llama-3-1/). Usage of this model is subject to [Meta's Acceptable Use Policy](https://llama.meta.com/llama3/use-policy/).  <br/>
    /// </summary>
    MetaLlama318BInstructFree,

    /// <summary>
    /// Meta's latest class of model (Llama 3.1) launched with a variety of sizes and flavors. This 8B instruct-tuned version is fast and efficient.  <br/>
    /// It has demonstrated strong performance compared to leading closed-source models in human evaluations.  <br/>
    /// To read more about the model release, [click here](https://ai.meta.com/blog/meta-llama-3-1/). Usage of this model is subject to [Meta's Acceptable Use Policy](https://llama.meta.com/llama3/use-policy/).  <br/>
    /// </summary>
    MetaLlama318BInstruct,

    /// <summary>
    /// Meta's latest class of model (Llama 3.1) launched with a variety of sizes and flavors. This 70B instruct-tuned version is optimized for high quality dialogue usecases.  <br/>
    /// It has demonstrated strong performance compared to leading closed-source models in human evaluations.  <br/>
    /// To read more about the model release, [click here](https://ai.meta.com/blog/meta-llama-3-1/). Usage of this model is subject to [Meta's Acceptable Use Policy](https://llama.meta.com/llama3/use-policy/).  <br/>
    /// </summary>
    MetaLlama3170BInstruct,

    /// <summary>
    /// A 12B parameter model with a 128k token context length built by Mistral in collaboration with NVIDIA.  <br/>
    /// The model is multilingual, supporting English, French, German, Spanish, Italian, Portuguese, Chinese, Japanese, Korean, Arabic, and Hindi.  <br/>
    /// It supports function calling and is released under the Apache 2.0 license.  <br/>
    /// </summary>
    MistralMistralNemoFree,

    /// <summary>
    /// A 12B parameter model with a 128k token context length built by Mistral in collaboration with NVIDIA.  <br/>
    /// The model is multilingual, supporting English, French, German, Spanish, Italian, Portuguese, Chinese, Japanese, Korean, Arabic, and Hindi.  <br/>
    /// It supports function calling and is released under the Apache 2.0 license.  <br/>
    /// </summary>
    MistralMistralNemo,

    /// <summary>
    /// A 7.3B parameter Mamba-based model designed for code and reasoning tasks.  <br/>
    /// - Linear time inference, allowing for theoretically infinite sequence lengths  <br/>
    /// - 256k token context window  <br/>
    /// - Optimized for quick responses, especially beneficial for code productivity  <br/>
    /// - Performs comparably to state-of-the-art transformer models in code and reasoning tasks  <br/>
    /// - Available under the Apache 2.0 license for free use, modification, and distribution  <br/>
    /// </summary>
    MistralCodestralMamba,

    /// <summary>
    /// GPT-4o mini is OpenAI's newest model after [GPT-4 Omni](/models/openai/gpt-4o), supporting both text and image inputs with text outputs.  <br/>
    /// As their most advanced small model, it is many multiples more affordable than other recent frontier models, and more than 60% cheaper than [GPT-3.5 Turbo](/models/openai/gpt-3.5-turbo). It maintains SOTA intelligence, while being significantly more cost-effective.  <br/>
    /// GPT-4o mini achieves an 82% score on MMLU and presently ranks higher than GPT-4 on chat preferences [common leaderboards](https://arena.lmsys.org/).  <br/>
    /// Check out the [launch announcement](https://openai.com/index/gpt-4o-mini-advancing-cost-efficient-intelligence/) to learn more.  <br/>
    /// #multimodal  <br/>
    /// </summary>
    OpenAiGpt4OMini,

    /// <summary>
    /// GPT-4o mini is OpenAI's newest model after [GPT-4 Omni](/models/openai/gpt-4o), supporting both text and image inputs with text outputs.  <br/>
    /// As their most advanced small model, it is many multiples more affordable than other recent frontier models, and more than 60% cheaper than [GPT-3.5 Turbo](/models/openai/gpt-3.5-turbo). It maintains SOTA intelligence, while being significantly more cost-effective.  <br/>
    /// GPT-4o mini achieves an 82% score on MMLU and presently ranks higher than GPT-4 on chat preferences [common leaderboards](https://arena.lmsys.org/).  <br/>
    /// Check out the [launch announcement](https://openai.com/index/gpt-4o-mini-advancing-cost-efficient-intelligence/) to learn more.  <br/>
    /// #multimodal  <br/>
    /// </summary>
    OpenAiGpt4OMini20240718,

    /// <summary>
    /// Qwen2 7B is a transformer-based model that excels in language understanding, multilingual capabilities, coding, mathematics, and reasoning.  <br/>
    /// It features SwiGLU activation, attention QKV bias, and group query attention. It is pretrained on extensive data with supervised finetuning and direct preference optimization.  <br/>
    /// For more details, see this [blog post](https://qwenlm.github.io/blog/qwen2/) and [GitHub repo](https://github.com/QwenLM/Qwen2).  <br/>
    /// Usage of this model is subject to [Tongyi Qianwen LICENSE AGREEMENT](https://huggingface.co/Qwen/Qwen1.5-110B-Chat/blob/main/LICENSE).  <br/>
    /// </summary>
    Qwen27BInstructFree,

    /// <summary>
    /// Qwen2 7B is a transformer-based model that excels in language understanding, multilingual capabilities, coding, mathematics, and reasoning.  <br/>
    /// It features SwiGLU activation, attention QKV bias, and group query attention. It is pretrained on extensive data with supervised finetuning and direct preference optimization.  <br/>
    /// For more details, see this [blog post](https://qwenlm.github.io/blog/qwen2/) and [GitHub repo](https://github.com/QwenLM/Qwen2).  <br/>
    /// Usage of this model is subject to [Tongyi Qianwen LICENSE AGREEMENT](https://huggingface.co/Qwen/Qwen1.5-110B-Chat/blob/main/LICENSE).  <br/>
    /// </summary>
    Qwen27BInstruct,

    /// <summary>
    /// Gemma 2 27B by Google is an open model built from the same research and technology used to create the [Gemini models](/models?q=gemini).  <br/>
    /// Gemma models are well-suited for a variety of text generation tasks, including question answering, summarization, and reasoning.  <br/>
    /// See the [launch announcement](https://blog.google/technology/developers/google-gemma-2/) for more details. Usage of Gemma is subject to Google's [Gemma Terms of Use](https://ai.google.dev/gemma/terms).  <br/>
    /// </summary>
    GoogleGemma227B,

    /// <summary>
    /// From the maker of [Goliath](https://openrouter.ai/models/alpindale/goliath-120b), Magnum 72B is the first in a new family of models designed to achieve the prose quality of the Claude 3 models, notably Opus and Sonnet.  <br/>
    /// The model is based on [Qwen2 72B](https://openrouter.ai/models/qwen/qwen-2-72b-instruct) and trained with 55 million tokens of highly curated roleplay (RP) data.  <br/>
    /// </summary>
    Magnum72B,

    /// <summary>
    /// Gemma 2 9B by Google is an advanced, open-source language model that sets a new standard for efficiency and performance in its size class.  <br/>
    /// Designed for a wide variety of tasks, it empowers developers and researchers to build innovative applications, while maintaining accessibility, safety, and cost-effectiveness.  <br/>
    /// See the [launch announcement](https://blog.google/technology/developers/google-gemma-2/) for more details. Usage of Gemma is subject to Google's [Gemma Terms of Use](https://ai.google.dev/gemma/terms).  <br/>
    /// </summary>
    GoogleGemma29BFree,

    /// <summary>
    /// Gemma 2 9B by Google is an advanced, open-source language model that sets a new standard for efficiency and performance in its size class.  <br/>
    /// Designed for a wide variety of tasks, it empowers developers and researchers to build innovative applications, while maintaining accessibility, safety, and cost-effectiveness.  <br/>
    /// See the [launch announcement](https://blog.google/technology/developers/google-gemma-2/) for more details. Usage of Gemma is subject to Google's [Gemma Terms of Use](https://ai.google.dev/gemma/terms).  <br/>
    /// </summary>
    GoogleGemma29B,

    /// <summary>
    /// The Yi Large model was designed by 01.AI with the following usecases in mind: knowledge search, data classification, human-like chat bots, and customer service.  <br/>
    /// It stands out for its multilingual proficiency, particularly in Spanish, Chinese, Japanese, German, and French.  <br/>
    /// Check out the [launch announcement](https://01-ai.github.io/blog/01.ai-yi-large-llm-launch) to learn more.  <br/>
    /// </summary>
    _01AiYiLarge,

    /// <summary>
    /// The Jamba-Instruct model, introduced by AI21 Labs, is an instruction-tuned variant of their hybrid SSM-Transformer Jamba model, specifically optimized for enterprise applications.  <br/>
    /// - 256K Context Window: It can process extensive information, equivalent to a 400-page novel, which is beneficial for tasks involving large documents such as financial reports or legal documents  <br/>
    /// - Safety and Accuracy: Jamba-Instruct is designed with enhanced safety features to ensure secure deployment in enterprise environments, reducing the risk and cost of implementation  <br/>
    /// Read their [announcement](https://www.ai21.com/blog/announcing-jamba) to learn more.  <br/>
    /// Jamba has a knowledge cutoff of February 2024.  <br/>
    /// </summary>
    Ai21JambaInstruct,

    /// <summary>
    /// Claude 3.5 Sonnet delivers better-than-Opus capabilities, faster-than-Sonnet speeds, at the same Sonnet prices. Sonnet is particularly good at:  <br/>
    /// - Coding: Autonomously writes, edits, and runs code with reasoning and troubleshooting  <br/>
    /// - Data science: Augments human data science expertise; navigates unstructured data while using multiple tools for insights  <br/>
    /// - Visual processing: excelling at interpreting charts, graphs, and images, accurately transcribing text to derive insights beyond just the text alone  <br/>
    /// - Agentic tasks: exceptional tool use, making it great at agentic tasks (i.e. complex, multi-step problem solving tasks that require engaging with other systems)  <br/>
    /// For the latest version (2024-10-23), check out [Claude 3.5 Sonnet](/anthropic/claude-3.5-sonnet).  <br/>
    /// #multimodal  <br/>
    /// </summary>
    AnthropicClaude35Sonnet20240620SelfModerated,

    /// <summary>
    /// Claude 3.5 Sonnet delivers better-than-Opus capabilities, faster-than-Sonnet speeds, at the same Sonnet prices. Sonnet is particularly good at:  <br/>
    /// - Coding: Autonomously writes, edits, and runs code with reasoning and troubleshooting  <br/>
    /// - Data science: Augments human data science expertise; navigates unstructured data while using multiple tools for insights  <br/>
    /// - Visual processing: excelling at interpreting charts, graphs, and images, accurately transcribing text to derive insights beyond just the text alone  <br/>
    /// - Agentic tasks: exceptional tool use, making it great at agentic tasks (i.e. complex, multi-step problem solving tasks that require engaging with other systems)  <br/>
    /// For the latest version (2024-10-23), check out [Claude 3.5 Sonnet](/anthropic/claude-3.5-sonnet).  <br/>
    /// #multimodal  <br/>
    /// </summary>
    AnthropicClaude35Sonnet20240620,

    /// <summary>
    /// Euryale 70B v2.1 is a model focused on creative roleplay from [Sao10k](https://ko-fi.com/sao10k).  <br/>
    /// - Better prompt adherence.  <br/>
    /// - Better anatomy / spatial awareness.  <br/>
    /// - Adapts much better to unique and custom formatting / reply formats.  <br/>
    /// - Very creative, lots of unique swipes.  <br/>
    /// - Is not restrictive during roleplays.  <br/>
    /// </summary>
    Sao10kLlama3Euryale70BV21,

    /// <summary>
    /// Dolphin 2.9 is designed for instruction following, conversational, and coding. This model is a finetune of [Mixtral 8x22B Instruct](/models/mistralai/mixtral-8x22b-instruct). It features a 64k context length and was fine-tuned with a 16k sequence length using ChatML templates.  <br/>
    /// This model is a successor to [Dolphin Mixtral 8x7B](/models/cognitivecomputations/dolphin-mixtral-8x7b).  <br/>
    /// The model is uncensored and is stripped of alignment and bias. It requires an external alignment layer for ethical use. Users are cautioned to use this highly compliant model responsibly, as detailed in a blog post about uncensored models at [erichartford.com/uncensored-models](https://erichartford.com/uncensored-models).  <br/>
    /// #moe #uncensored  <br/>
    /// </summary>
    Dolphin292Mixtral8X22b,

    /// <summary>
    /// Qwen2 72B is a transformer-based model that excels in language understanding, multilingual capabilities, coding, mathematics, and reasoning.  <br/>
    /// It features SwiGLU activation, attention QKV bias, and group query attention. It is pretrained on extensive data with supervised finetuning and direct preference optimization.  <br/>
    /// For more details, see this [blog post](https://qwenlm.github.io/blog/qwen2/) and [GitHub repo](https://github.com/QwenLM/Qwen2).  <br/>
    /// Usage of this model is subject to [Tongyi Qianwen LICENSE AGREEMENT](https://huggingface.co/Qwen/Qwen1.5-110B-Chat/blob/main/LICENSE).  <br/>
    /// </summary>
    Qwen272BInstruct,

    /// <summary>
    /// A high-performing, industry-standard 7.3B parameter model, with optimizations for speed and context length.  <br/>
    /// *Mistral 7B Instruct has multiple version variants, and this is intended to be the latest version.*  <br/>
    /// </summary>
    MistralMistral7BInstructFree,

    /// <summary>
    /// A high-performing, industry-standard 7.3B parameter model, with optimizations for speed and context length.  <br/>
    /// *Mistral 7B Instruct has multiple version variants, and this is intended to be the latest version.*  <br/>
    /// </summary>
    MistralMistral7BInstruct,

    /// <summary>
    /// A high-performing, industry-standard 7.3B parameter model, with optimizations for speed and context length.  <br/>
    /// An improved version of [Mistral 7B Instruct v0.2](/models/mistralai/mistral-7b-instruct-v0.2), with the following changes:  <br/>
    /// - Extended vocabulary to 32768  <br/>
    /// - Supports v3 Tokenizer  <br/>
    /// - Supports function calling  <br/>
    /// NOTE: Support for function calling depends on the provider.  <br/>
    /// </summary>
    MistralMistral7BInstructV03,

    /// <summary>
    /// Hermes 2 Pro is an upgraded, retrained version of Nous Hermes 2, consisting of an updated and cleaned version of the OpenHermes 2.5 Dataset, as well as a newly introduced Function Calling and JSON Mode dataset developed in-house.  <br/>
    /// </summary>
    NousresearchHermes2ProLlama38B,

    /// <summary>
    /// Phi-3 Mini is a powerful 3.8B parameter model designed for advanced language understanding, reasoning, and instruction following. Optimized through supervised fine-tuning and preference adjustments, it excels in tasks involving common sense, mathematics, logical reasoning, and code processing.  <br/>
    /// At time of release, Phi-3 Medium demonstrated state-of-the-art performance among lightweight models. This model is static, trained on an offline dataset with an October 2023 cutoff date.  <br/>
    /// </summary>
    MicrosoftPhi3Mini128KInstructFree,

    /// <summary>
    /// Phi-3 Mini is a powerful 3.8B parameter model designed for advanced language understanding, reasoning, and instruction following. Optimized through supervised fine-tuning and preference adjustments, it excels in tasks involving common sense, mathematics, logical reasoning, and code processing.  <br/>
    /// At time of release, Phi-3 Medium demonstrated state-of-the-art performance among lightweight models. This model is static, trained on an offline dataset with an October 2023 cutoff date.  <br/>
    /// </summary>
    MicrosoftPhi3Mini128KInstruct,

    /// <summary>
    /// Phi-3 128K Medium is a powerful 14-billion parameter model designed for advanced language understanding, reasoning, and instruction following. Optimized through supervised fine-tuning and preference adjustments, it excels in tasks involving common sense, mathematics, logical reasoning, and code processing.  <br/>
    /// At time of release, Phi-3 Medium demonstrated state-of-the-art performance among lightweight models. In the MMLU-Pro eval, the model even comes close to a Llama3 70B level of performance.  <br/>
    /// For 4k context length, try [Phi-3 Medium 4K](/models/microsoft/phi-3-medium-4k-instruct).  <br/>
    /// </summary>
    MicrosoftPhi3Medium128KInstructFree,

    /// <summary>
    /// Phi-3 128K Medium is a powerful 14-billion parameter model designed for advanced language understanding, reasoning, and instruction following. Optimized through supervised fine-tuning and preference adjustments, it excels in tasks involving common sense, mathematics, logical reasoning, and code processing.  <br/>
    /// At time of release, Phi-3 Medium demonstrated state-of-the-art performance among lightweight models. In the MMLU-Pro eval, the model even comes close to a Llama3 70B level of performance.  <br/>
    /// For 4k context length, try [Phi-3 Medium 4K](/models/microsoft/phi-3-medium-4k-instruct).  <br/>
    /// </summary>
    MicrosoftPhi3Medium128KInstruct,

    /// <summary>
    /// The NeverSleep team is back, with a Llama 3 70B finetune trained on their curated roleplay data. Striking a balance between eRP and RP, Lumimaid was designed to be serious, yet uncensored when necessary.  <br/>
    /// To enhance it's overall intelligence and chat capability, roughly 40% of the training data was not roleplay. This provides a breadth of knowledge to access, while still keeping roleplay as the primary strength.  <br/>
    /// Usage of this model is subject to [Meta's Acceptable Use Policy](https://llama.meta.com/llama3/use-policy/).  <br/>
    /// </summary>
    NeversleepLlama3Lumimaid70B,

    /// <summary>
    /// Gemini 1.5 Flash is a foundation model that performs well at a variety of multimodal tasks such as visual understanding, classification, summarization, and creating content from image, audio and video. It's adept at processing visual and text inputs such as photographs, documents, infographics, and screenshots.  <br/>
    /// Gemini 1.5 Flash is designed for high-volume, high-frequency tasks where cost and latency matter. On most common tasks, Flash achieves comparable quality to other Gemini Pro models at a significantly reduced cost. Flash is well-suited for applications like chat assistants and on-demand content generation where speed and scale matter.  <br/>
    /// Usage of Gemini is subject to Google's [Gemini Terms of Use](https://ai.google.dev/terms).  <br/>
    /// #multimodal  <br/>
    /// </summary>
    GoogleGeminiFlash15,

    /// <summary>
    /// DeepSeek-V2.5 is an upgraded version that combines DeepSeek-V2-Chat and DeepSeek-Coder-V2-Instruct. The new model integrates the general and coding abilities of the two previous versions. For model details, please visit [DeepSeek-V2 page](https://github.com/deepseek-ai/DeepSeek-V2) for more information.  <br/>
    /// </summary>
    DeepseekV25,

    /// <summary>
    /// GPT-4o ("o" for "omni") is OpenAI's latest AI model, supporting both text and image inputs with text outputs. It maintains the intelligence level of [GPT-4 Turbo](/models/openai/gpt-4-turbo) while being twice as fast and 50% more cost-effective. GPT-4o also offers improved performance in processing non-English languages and enhanced visual capabilities.  <br/>
    /// For benchmarking against other models, it was briefly called ["im-also-a-good-gpt2-chatbot"](https://twitter.com/LiamFedus/status/1790064963966370209)  <br/>
    /// #multimodal  <br/>
    /// </summary>
    OpenAiGpt4O20240513,

    /// <summary>
    /// Meta's latest class of model (Llama 3) launched with a variety of sizes and flavors. This is the base 8B pre-trained version.  <br/>
    /// It has demonstrated strong performance compared to leading closed-source models in human evaluations.  <br/>
    /// To read more about the model release, [click here](https://ai.meta.com/blog/meta-llama-3/). Usage of this model is subject to [Meta's Acceptable Use Policy](https://llama.meta.com/llama3/use-policy/).  <br/>
    /// </summary>
    MetaLlama38BBase,

    /// <summary>
    /// Meta's latest class of model (Llama 3) launched with a variety of sizes and flavors. This is the base 70B pre-trained version.  <br/>
    /// It has demonstrated strong performance compared to leading closed-source models in human evaluations.  <br/>
    /// To read more about the model release, [click here](https://ai.meta.com/blog/meta-llama-3/). Usage of this model is subject to [Meta's Acceptable Use Policy](https://llama.meta.com/llama3/use-policy/).  <br/>
    /// </summary>
    MetaLlama370BBase,

    /// <summary>
    /// This safeguard model has 8B parameters and is based on the Llama 3 family. Just like is predecessor, [LlamaGuard 1](https://huggingface.co/meta-llama/LlamaGuard-7b), it can do both prompt and response classification.  <br/>
    /// LlamaGuard 2 acts as a normal LLM would, generating text that indicates whether the given input/output is safe/unsafe. If deemed unsafe, it will also share the content categories violated.  <br/>
    /// For best results, please use raw prompt input or the `/completions` endpoint, instead of the chat API.  <br/>
    /// It has demonstrated strong performance compared to leading closed-source models in human evaluations.  <br/>
    /// To read more about the model release, [click here](https://ai.meta.com/blog/meta-llama-3/). Usage of this model is subject to [Meta's Acceptable Use Policy](https://llama.meta.com/llama3/use-policy/).  <br/>
    /// </summary>
    MetaLlamaguard28B,

    /// <summary>
    /// GPT-4o ("o" for "omni") is OpenAI's latest AI model, supporting both text and image inputs with text outputs. It maintains the intelligence level of [GPT-4 Turbo](/models/openai/gpt-4-turbo) while being twice as fast and 50% more cost-effective. GPT-4o also offers improved performance in processing non-English languages and enhanced visual capabilities.  <br/>
    /// For benchmarking against other models, it was briefly called ["im-also-a-good-gpt2-chatbot"](https://twitter.com/LiamFedus/status/1790064963966370209)  <br/>
    /// #multimodal  <br/>
    /// </summary>
    OpenAiGpt4O,

    /// <summary>
    /// GPT-4o ("o" for "omni") is OpenAI's latest AI model, supporting both text and image inputs with text outputs. It maintains the intelligence level of [GPT-4 Turbo](/models/openai/gpt-4-turbo) while being twice as fast and 50% more cost-effective. GPT-4o also offers improved performance in processing non-English languages and enhanced visual capabilities.  <br/>
    /// For benchmarking against other models, it was briefly called ["im-also-a-good-gpt2-chatbot"](https://twitter.com/LiamFedus/status/1790064963966370209)  <br/>
    /// #multimodal  <br/>
    /// </summary>
    OpenAiGpt4OExtended,

    /// <summary>
    /// The NeverSleep team is back, with a Llama 3 8B finetune trained on their curated roleplay data. Striking a balance between eRP and RP, Lumimaid was designed to be serious, yet uncensored when necessary.  <br/>
    /// To enhance it's overall intelligence and chat capability, roughly 40% of the training data was not roleplay. This provides a breadth of knowledge to access, while still keeping roleplay as the primary strength.  <br/>
    /// Usage of this model is subject to [Meta's Acceptable Use Policy](https://llama.meta.com/llama3/use-policy/).  <br/>
    /// </summary>
    NeversleepLlama3Lumimaid8BExtended,

    /// <summary>
    /// The NeverSleep team is back, with a Llama 3 8B finetune trained on their curated roleplay data. Striking a balance between eRP and RP, Lumimaid was designed to be serious, yet uncensored when necessary.  <br/>
    /// To enhance it's overall intelligence and chat capability, roughly 40% of the training data was not roleplay. This provides a breadth of knowledge to access, while still keeping roleplay as the primary strength.  <br/>
    /// Usage of this model is subject to [Meta's Acceptable Use Policy](https://llama.meta.com/llama3/use-policy/).  <br/>
    /// </summary>
    NeversleepLlama3Lumimaid8B,

    /// <summary>
    /// Creative writing model, routed with permission. It's fast, it keeps the conversation going, and it stays in character.  <br/>
    /// If you submit a raw prompt, you can use Alpaca or Vicuna formats.  <br/>
    /// </summary>
    Fimbulvetr11BV2,

    /// <summary>
    /// Meta's latest class of model (Llama 3) launched with a variety of sizes and flavors. This 8B instruct-tuned version was optimized for high quality dialogue usecases.  <br/>
    /// It has demonstrated strong performance compared to leading closed-source models in human evaluations.  <br/>
    /// To read more about the model release, [click here](https://ai.meta.com/blog/meta-llama-3/). Usage of this model is subject to [Meta's Acceptable Use Policy](https://llama.meta.com/llama3/use-policy/).  <br/>
    /// </summary>
    MetaLlama38BInstructFree,

    /// <summary>
    /// Meta's latest class of model (Llama 3) launched with a variety of sizes and flavors. This 8B instruct-tuned version was optimized for high quality dialogue usecases.  <br/>
    /// It has demonstrated strong performance compared to leading closed-source models in human evaluations.  <br/>
    /// To read more about the model release, [click here](https://ai.meta.com/blog/meta-llama-3/). Usage of this model is subject to [Meta's Acceptable Use Policy](https://llama.meta.com/llama3/use-policy/).  <br/>
    /// </summary>
    MetaLlama38BInstruct,

    /// <summary>
    /// Meta's latest class of model (Llama 3) launched with a variety of sizes and flavors. This 70B instruct-tuned version was optimized for high quality dialogue usecases.  <br/>
    /// It has demonstrated strong performance compared to leading closed-source models in human evaluations.  <br/>
    /// To read more about the model release, [click here](https://ai.meta.com/blog/meta-llama-3/). Usage of this model is subject to [Meta's Acceptable Use Policy](https://llama.meta.com/llama3/use-policy/).  <br/>
    /// </summary>
    MetaLlama370BInstruct,

    /// <summary>
    /// Mistral's official instruct fine-tuned version of [Mixtral 8x22B](/models/mistralai/mixtral-8x22b). It uses 39B active parameters out of 141B, offering unparalleled cost efficiency for its size. Its strengths include:  <br/>
    /// - strong math, coding, and reasoning  <br/>
    /// - large context length (64k)  <br/>
    /// - fluency in English, French, Italian, German, and Spanish  <br/>
    /// See benchmarks on the launch announcement [here](https://mistral.ai/news/mixtral-8x22b/).  <br/>
    /// #moe  <br/>
    /// </summary>
    MistralMixtral8X22bInstruct,

    /// <summary>
    /// WizardLM-2 8x22B is Microsoft AI's most advanced Wizard model. It demonstrates highly competitive performance compared to leading proprietary models, and it consistently outperforms all existing state-of-the-art opensource models.  <br/>
    /// It is an instruct finetune of [Mixtral 8x22B](/models/mistralai/mixtral-8x22b).  <br/>
    /// To read more about the model release, [click here](https://wizardlm.github.io/WizardLM2/).  <br/>
    /// #moe  <br/>
    /// </summary>
    Wizardlm28X22b,

    /// <summary>
    /// WizardLM-2 7B is the smaller variant of Microsoft AI's latest Wizard model. It is the fastest and achieves comparable performance with existing 10x larger opensource leading models  <br/>
    /// It is a finetune of [Mistral 7B Instruct](/models/mistralai/mistral-7b-instruct), using the same technique as [WizardLM-2 8x22B](/models/microsoft/wizardlm-2-8x22b).  <br/>
    /// To read more about the model release, [click here](https://wizardlm.github.io/WizardLM2/).  <br/>
    /// #moe  <br/>
    /// </summary>
    Wizardlm27B,

    /// <summary>
    /// Google's latest multimodal model, supports image and video[0] in text or chat prompts.  <br/>
    /// Optimized for language tasks including:  <br/>
    /// - Code generation  <br/>
    /// - Text generation  <br/>
    /// - Text editing  <br/>
    /// - Problem solving  <br/>
    /// - Recommendations  <br/>
    /// - Information extraction  <br/>
    /// - Data extraction or generation  <br/>
    /// - AI agents  <br/>
    /// Usage of Gemini is subject to Google's [Gemini Terms of Use](https://ai.google.dev/terms).  <br/>
    /// * [0]: Video input is not available through OpenRouter at this time.  <br/>
    /// </summary>
    GoogleGeminiPro15,

    /// <summary>
    /// The latest GPT-4 Turbo model with vision capabilities. Vision requests can now use JSON mode and function calling.  <br/>
    /// Training data: up to December 2023.  <br/>
    /// </summary>
    OpenAiGpt4Turbo,

    /// <summary>
    /// Command R+ is a new, 104B-parameter LLM from Cohere. It's useful for roleplay, general consumer usecases, and Retrieval Augmented Generation (RAG).  <br/>
    /// It offers multilingual support for ten key languages to facilitate global business operations. See benchmarks and the launch post [here](https://txt.cohere.com/command-r-plus-microsoft-azure/).  <br/>
    /// Use of this model is subject to Cohere's [Usage Policy](https://docs.cohere.com/docs/usage-policy) and [SaaS Agreement](https://cohere.com/saas-agreement).  <br/>
    /// </summary>
    CohereCommandRPlus,

    /// <summary>
    /// Command R+ is a new, 104B-parameter LLM from Cohere. It's useful for roleplay, general consumer usecases, and Retrieval Augmented Generation (RAG).  <br/>
    /// It offers multilingual support for ten key languages to facilitate global business operations. See benchmarks and the launch post [here](https://txt.cohere.com/command-r-plus-microsoft-azure/).  <br/>
    /// Use of this model is subject to Cohere's [Usage Policy](https://docs.cohere.com/docs/usage-policy) and [SaaS Agreement](https://cohere.com/saas-agreement).  <br/>
    /// </summary>
    CohereCommandRPlus042024,

    /// <summary>
    /// DBRX is a new open source large language model developed by Databricks. At 132B, it outperforms existing open source LLMs like Llama 2 70B and [Mixtral-8x7b](/models/mistralai/mixtral-8x7b) on standard industry benchmarks for language understanding, programming, math, and logic.  <br/>
    /// It uses a fine-grained mixture-of-experts (MoE) architecture. 36B parameters are active on any input. It was pre-trained on 12T tokens of text and code data. Compared to other open MoE models like Mixtral-8x7B and Grok-1, DBRX is fine-grained, meaning it uses a larger number of smaller experts.  <br/>
    /// See the launch announcement and benchmark results [here](https://www.databricks.com/blog/introducing-dbrx-new-state-art-open-llm).  <br/>
    /// #moe  <br/>
    /// </summary>
    DatabricksDbrx132BInstruct,

    /// <summary>
    /// A merge with a complex family tree, this model was crafted for roleplaying and storytelling. Midnight Rose is a successor to Rogue Rose and Aurora Nights and improves upon them both. It wants to produce lengthy output by default and is the best creative writing merge produced so far by sophosympatheia.  <br/>
    /// Descending from earlier versions of Midnight Rose and [Wizard Tulu Dolphin 70B](https://huggingface.co/sophosympatheia/Wizard-Tulu-Dolphin-70B-v1.0), it inherits the best qualities of each.  <br/>
    /// </summary>
    MidnightRose70B,

    /// <summary>
    /// Command is an instruction-following conversational model that performs language tasks with high quality, more reliably and with a longer context than our base generative models.  <br/>
    /// Use of this model is subject to Cohere's [Usage Policy](https://docs.cohere.com/docs/usage-policy) and [SaaS Agreement](https://cohere.com/saas-agreement).  <br/>
    /// </summary>
    CohereCommand,

    /// <summary>
    /// Command-R is a 35B parameter model that performs conversational language tasks at a higher quality, more reliably, and with a longer context than previous models. It can be used for complex workflows like code generation, retrieval augmented generation (RAG), tool use, and agents.  <br/>
    /// Read the launch post [here](https://txt.cohere.com/command-r/).  <br/>
    /// Use of this model is subject to Cohere's [Usage Policy](https://docs.cohere.com/docs/usage-policy) and [SaaS Agreement](https://cohere.com/saas-agreement).  <br/>
    /// </summary>
    CohereCommandR,

    /// <summary>
    /// Claude 3 Haiku is Anthropic's fastest and most compact model for  <br/>
    /// near-instant responsiveness. Quick and accurate targeted performance.  <br/>
    /// See the launch announcement and benchmark results [here](https://www.anthropic.com/news/claude-3-haiku)  <br/>
    /// #multimodal  <br/>
    /// </summary>
    AnthropicClaude3HaikuSelfModerated,

    /// <summary>
    /// Claude 3 Haiku is Anthropic's fastest and most compact model for  <br/>
    /// near-instant responsiveness. Quick and accurate targeted performance.  <br/>
    /// See the launch announcement and benchmark results [here](https://www.anthropic.com/news/claude-3-haiku)  <br/>
    /// #multimodal  <br/>
    /// </summary>
    AnthropicClaude3Haiku,

    /// <summary>
    /// Claude 3 Opus is Anthropic's most powerful model for highly complex tasks. It boasts top-level performance, intelligence, fluency, and understanding.  <br/>
    /// See the launch announcement and benchmark results [here](https://www.anthropic.com/news/claude-3-family)  <br/>
    /// #multimodal  <br/>
    /// </summary>
    AnthropicClaude3OpusSelfModerated,

    /// <summary>
    /// Claude 3 Opus is Anthropic's most powerful model for highly complex tasks. It boasts top-level performance, intelligence, fluency, and understanding.  <br/>
    /// See the launch announcement and benchmark results [here](https://www.anthropic.com/news/claude-3-family)  <br/>
    /// #multimodal  <br/>
    /// </summary>
    AnthropicClaude3Opus,

    /// <summary>
    /// Claude 3 Sonnet is an ideal balance of intelligence and speed for enterprise workloads. Maximum utility at a lower price, dependable, balanced for scaled deployments.  <br/>
    /// See the launch announcement and benchmark results [here](https://www.anthropic.com/news/claude-3-family)  <br/>
    /// #multimodal  <br/>
    /// </summary>
    AnthropicClaude3SonnetSelfModerated,

    /// <summary>
    /// Claude 3 Sonnet is an ideal balance of intelligence and speed for enterprise workloads. Maximum utility at a lower price, dependable, balanced for scaled deployments.  <br/>
    /// See the launch announcement and benchmark results [here](https://www.anthropic.com/news/claude-3-family)  <br/>
    /// #multimodal  <br/>
    /// </summary>
    AnthropicClaude3Sonnet,

    /// <summary>
    /// Command-R is a 35B parameter model that performs conversational language tasks at a higher quality, more reliably, and with a longer context than previous models. It can be used for complex workflows like code generation, retrieval augmented generation (RAG), tool use, and agents.  <br/>
    /// Read the launch post [here](https://txt.cohere.com/command-r/).  <br/>
    /// Use of this model is subject to Cohere's [Usage Policy](https://docs.cohere.com/docs/usage-policy) and [SaaS Agreement](https://cohere.com/saas-agreement).  <br/>
    /// </summary>
    CohereCommandR032024,

    /// <summary>
    /// This is Mistral AI's flagship model, Mistral Large 2 (version `mistral-large-2407`). It's a proprietary weights-available model and excels at reasoning, code, JSON, chat, and more. Read the launch announcement [here](https://mistral.ai/news/mistral-large-2407/).  <br/>
    /// It supports dozens of languages including French, German, Spanish, Italian, Portuguese, Arabic, Hindi, Russian, Chinese, Japanese, and Korean, along with 80+ coding languages including Python, Java, C, C++, JavaScript, and Bash. Its long context window allows precise information recall from large documents.  <br/>
    /// </summary>
    MistralLarge,

    /// <summary>
    /// Gemma by Google is an advanced, open-source language model family, leveraging the latest in decoder-only, text-to-text technology. It offers English language capabilities across text generation tasks like question answering, summarization, and reasoning. The Gemma 7B variant is comparable in performance to leading open source models.  <br/>
    /// Usage of Gemma is subject to Google's [Gemma Terms of Use](https://ai.google.dev/gemma/terms).  <br/>
    /// </summary>
    GoogleGemma7B,

    /// <summary>
    /// GPT-3.5 Turbo is OpenAI's fastest model. It can understand and generate natural language or code, and is optimized for chat and traditional completion tasks.  <br/>
    /// Training data up to Sep 2021.  <br/>
    /// </summary>
    OpenAiGpt35TurboOlderV0613,

    /// <summary>
    /// The preview GPT-4 model with improved instruction following, JSON mode, reproducible outputs, parallel function calling, and more. Training data: up to Dec 2023.  <br/>
    /// **Note:** heavily rate limited by OpenAI while in preview.  <br/>
    /// </summary>
    OpenAiGpt4TurboPreview,

    /// <summary>
    /// Nous Hermes 2 Mixtral 8x7B DPO is the new flagship Nous Research model trained over the [Mixtral 8x7B MoE LLM](/models/mistralai/mixtral-8x7b).  <br/>
    /// The model was trained on over 1,000,000 entries of primarily [GPT-4](/models/openai/gpt-4) generated data, as well as other high quality data from open datasets across the AI landscape, achieving state of the art performance on a variety of tasks.  <br/>
    /// #moe  <br/>
    /// </summary>
    NousHermes2Mixtral8X7BDpo,

    /// <summary>
    /// With 22 billion parameters, Mistral Small v24.09 offers a convenient mid-point between (Mistral NeMo 12B)[/mistralai/mistral-nemo] and (Mistral Large 2)[/mistralai/mistral-large], providing a cost-effective solution that can be deployed across various platforms and environments. It has better reasoning, exhibits more capabilities, can produce and reason about code, and is multiligual, supporting English, French, German, Italian, and Spanish.  <br/>
    /// </summary>
    MistralSmall,

    /// <summary>
    /// This model is currently powered by Mistral-7B-v0.2, and incorporates a "better" fine-tuning than [Mistral 7B](/models/mistralai/mistral-7b-instruct-v0.1), inspired by community work. It's best used for large batch processing tasks where cost is a significant factor but reasoning capabilities are not crucial.  <br/>
    /// </summary>
    MistralTiny,

    /// <summary>
    /// This is Mistral AI's closed-source, medium-sided model. It's powered by a closed-source prototype and excels at reasoning, code, JSON, chat, and more. In benchmarks, it compares with many of the flagship models of other companies.  <br/>
    /// </summary>
    MistralMedium,

    /// <summary>
    /// This is a 16k context fine-tune of [Mixtral-8x7b](/models/mistralai/mixtral-8x7b). It excels in coding tasks due to extensive training with coding data and is known for its obedience, although it lacks DPO tuning.  <br/>
    /// The model is uncensored and is stripped of alignment and bias. It requires an external alignment layer for ethical use. Users are cautioned to use this highly compliant model responsibly, as detailed in a blog post about uncensored models at [erichartford.com/uncensored-models](https://erichartford.com/uncensored-models).  <br/>
    /// #moe #uncensored  <br/>
    /// </summary>
    Dolphin26Mixtral8X7B,

    /// <summary>
    /// Google's flagship multimodal model, supporting image and video in text or chat prompts for a text or code response.  <br/>
    /// See the benchmarks and prompting guidelines from [Deepmind](https://deepmind.google/technologies/gemini/).  <br/>
    /// Usage of Gemini is subject to Google's [Gemini Terms of Use](https://ai.google.dev/terms).  <br/>
    /// #multimodal  <br/>
    /// </summary>
    GoogleGeminiProVision10,

    /// <summary>
    /// Google's flagship text generation model. Designed to handle natural language tasks, multiturn text and code chat, and code generation.  <br/>
    /// See the benchmarks and prompting guidelines from [Deepmind](https://deepmind.google/technologies/gemini/).  <br/>
    /// Usage of Gemini is subject to Google's [Gemini Terms of Use](https://ai.google.dev/terms).  <br/>
    /// </summary>
    GoogleGeminiPro10,

    /// <summary>
    /// Mixtral 8x7B is a pretrained generative Sparse Mixture of Experts, by Mistral AI. Incorporates 8 experts (feed-forward networks) for a total of 47B parameters. Base model (not fine-tuned for instructions) - see [Mixtral 8x7B Instruct](/models/mistralai/mixtral-8x7b-instruct) for an instruct-tuned model.  <br/>
    /// #moe  <br/>
    /// </summary>
    MistralMixtral8X7BBase,

    /// <summary>
    /// Mixtral 8x7B Instruct is a pretrained generative Sparse Mixture of Experts, by Mistral AI, for chat and instruction use. Incorporates 8 experts (feed-forward networks) for a total of 47 billion parameters.  <br/>
    /// Instruct model fine-tuned by Mistral. #moe  <br/>
    /// </summary>
    MistralMixtral8X7BInstruct,

    /// <summary>
    /// OpenChat 7B is a library of open-source language models, fine-tuned with "C-RLFT (Conditioned Reinforcement Learning Fine-Tuning)" - a strategy inspired by offline reinforcement learning. It has been trained on mixed-quality data without preference labels.  <br/>
    /// - For OpenChat fine-tuned on Mistral 7B, check out [OpenChat 7B](/models/openchat/openchat-7b).  <br/>
    /// - For OpenChat fine-tuned on Llama 8B, check out [OpenChat 8B](/models/openchat/openchat-8b).  <br/>
    /// #open-source  <br/>
    /// </summary>
    OpenChat357BFree,

    /// <summary>
    /// OpenChat 7B is a library of open-source language models, fine-tuned with "C-RLFT (Conditioned Reinforcement Learning Fine-Tuning)" - a strategy inspired by offline reinforcement learning. It has been trained on mixed-quality data without preference labels.  <br/>
    /// - For OpenChat fine-tuned on Mistral 7B, check out [OpenChat 7B](/models/openchat/openchat-7b).  <br/>
    /// - For OpenChat fine-tuned on Llama 8B, check out [OpenChat 8B](/models/openchat/openchat-8b).  <br/>
    /// #open-source  <br/>
    /// </summary>
    OpenChat357B,

    /// <summary>
    /// A collab between IkariDev and Undi. This merge is suitable for RP, ERP, and general knowledge.  <br/>
    /// #merge #uncensored  <br/>
    /// </summary>
    Noromaid20B,

    /// <summary>
    /// Claude 2 delivers advancements in key capabilities for enterprises—including an industry-leading 200K token context window, significant reductions in rates of model hallucination, system prompts and a new beta feature: tool use.  <br/>
    /// </summary>
    AnthropicClaudeV2SelfModerated,

    /// <summary>
    /// Claude 2 delivers advancements in key capabilities for enterprises—including an industry-leading 200K token context window, significant reductions in rates of model hallucination, system prompts and a new beta feature: tool use.  <br/>
    /// </summary>
    AnthropicClaudeV2,

    /// <summary>
    /// Claude 2 delivers advancements in key capabilities for enterprises—including an industry-leading 200K token context window, significant reductions in rates of model hallucination, system prompts and a new beta feature: tool use.  <br/>
    /// </summary>
    AnthropicClaudeV21SelfModerated,

    /// <summary>
    /// Claude 2 delivers advancements in key capabilities for enterprises—including an industry-leading 200K token context window, significant reductions in rates of model hallucination, system prompts and a new beta feature: tool use.  <br/>
    /// </summary>
    AnthropicClaudeV21,

    /// <summary>
    /// A continuation of [OpenHermes 2 model](/models/teknium/openhermes-2-mistral-7b), trained on additional code datasets.  <br/>
    /// Potentially the most interesting finding from training on a good ratio (est. of around 7-14% of the total dataset) of code instruction was that it has boosted several non-code benchmarks, including TruthfulQA, AGIEval, and GPT4All suite. It did however reduce BigBench benchmark score, but the net gain overall is significant.  <br/>
    /// </summary>
    OpenHermes25Mistral7B,

    /// <summary>
    /// A wild 7B parameter model that merges several models using the new task_arithmetic merge method from mergekit.  <br/>
    /// List of merged models:  <br/>
    /// - NousResearch/Nous-Capybara-7B-V1.9  <br/>
    /// - [HuggingFaceH4/zephyr-7b-beta](/models/huggingfaceh4/zephyr-7b-beta)  <br/>
    /// - lemonilia/AshhLimaRP-Mistral-7B  <br/>
    /// - Vulkane/120-Days-of-Sodom-LoRA-Mistral-7b  <br/>
    /// - Undi95/Mistral-pippa-sharegpt-7b-qlora  <br/>
    /// #merge #uncensored  <br/>
    /// </summary>
    ToppyM7BFree,

    /// <summary>
    /// A wild 7B parameter model that merges several models using the new task_arithmetic merge method from mergekit.  <br/>
    /// List of merged models:  <br/>
    /// - NousResearch/Nous-Capybara-7B-V1.9  <br/>
    /// - [HuggingFaceH4/zephyr-7b-beta](/models/huggingfaceh4/zephyr-7b-beta)  <br/>
    /// - lemonilia/AshhLimaRP-Mistral-7B  <br/>
    /// - Vulkane/120-Days-of-Sodom-LoRA-Mistral-7b  <br/>
    /// - Undi95/Mistral-pippa-sharegpt-7b-qlora  <br/>
    /// #merge #uncensored  <br/>
    /// </summary>
    ToppyM7B,

    /// <summary>
    /// A large LLM created by combining two fine-tuned Llama 70B models into one 120B model. Combines Xwin and Euryale.  <br/>
    /// Credits to  <br/>
    /// - [@chargoddard](https://huggingface.co/chargoddard) for developing the framework used to merge the model - [mergekit](https://github.com/cg123/mergekit).  <br/>
    /// - [@Undi95](https://huggingface.co/Undi95) for helping with the merge ratios.  <br/>
    /// #merge  <br/>
    /// </summary>
    Goliath120B,

    /// <summary>
    /// Your prompt will be processed by a meta-model and routed to one of dozens of models (see below), optimizing for the best possible output.  <br/>
    /// To see which model was used, visit [Activity](/activity), or read the `model` attribute of the response. Your response will be priced at the same rate as the routed model.  <br/>
    /// The meta-model is powered by [Not Diamond](https://docs.notdiamond.ai/docs/how-not-diamond-works). Learn more in our [docs](/docs/model-routing).  <br/>
    /// Requests will be routed to the following models:  <br/>
    /// - [openai/gpt-4o-2024-08-06](/openai/gpt-4o-2024-08-06)  <br/>
    /// - [openai/gpt-4o-2024-05-13](/openai/gpt-4o-2024-05-13)  <br/>
    /// - [openai/gpt-4o-mini-2024-07-18](/openai/gpt-4o-mini-2024-07-18)  <br/>
    /// - [openai/chatgpt-4o-latest](/openai/chatgpt-4o-latest)  <br/>
    /// - [openai/o1-preview-2024-09-12](/openai/o1-preview-2024-09-12)  <br/>
    /// - [openai/o1-mini-2024-09-12](/openai/o1-mini-2024-09-12)  <br/>
    /// - [anthropic/claude-3.5-sonnet](/anthropic/claude-3.5-sonnet)  <br/>
    /// - [anthropic/claude-3.5-haiku](/anthropic/claude-3.5-haiku)  <br/>
    /// - [anthropic/claude-3-opus](/anthropic/claude-3-opus)  <br/>
    /// - [anthropic/claude-2.1](/anthropic/claude-2.1)  <br/>
    /// - [google/gemini-pro-1.5](/google/gemini-pro-1.5)  <br/>
    /// - [google/gemini-flash-1.5](/google/gemini-flash-1.5)  <br/>
    /// - [mistralai/mistral-large-2407](/mistralai/mistral-large-2407)  <br/>
    /// - [mistralai/mistral-nemo](/mistralai/mistral-nemo)  <br/>
    /// - [deepseek/deepseek-r1](/deepseek/deepseek-r1)  <br/>
    /// - [meta-llama/llama-3.1-70b-instruct](/meta-llama/llama-3.1-70b-instruct)  <br/>
    /// - [meta-llama/llama-3.1-405b-instruct](/meta-llama/llama-3.1-405b-instruct)  <br/>
    /// - [mistralai/mixtral-8x22b-instruct](/mistralai/mixtral-8x22b-instruct)  <br/>
    /// - [cohere/command-r-plus](/cohere/command-r-plus)  <br/>
    /// - [cohere/command-r](/cohere/command-r)  <br/>
    /// </summary>
    AutoRouter,

    /// <summary>
    /// An older GPT-3.5 Turbo model with improved instruction following, JSON mode, reproducible outputs, parallel function calling, and more. Training data: up to Sep 2021.  <br/>
    /// </summary>
    OpenAiGpt35Turbo16KOlderV1106,

    /// <summary>
    /// The latest GPT-4 Turbo model with vision capabilities. Vision requests can now use JSON mode and function calling.  <br/>
    /// Training data: up to April 2023.  <br/>
    /// </summary>
    OpenAiGpt4TurboOlderV1106,

    /// <summary>
    /// PaLM 2 is a language model by Google with improved multilingual, reasoning and coding capabilities.  <br/>
    /// </summary>
    GooglePalm2Chat32K,

    /// <summary>
    /// PaLM 2 fine-tuned for chatbot conversations that help with code-related questions.  <br/>
    /// </summary>
    GooglePalm2CodeChat32K,

    /// <summary>
    /// A Llama 2 70B fine-tune using synthetic data (the Airoboros dataset).  <br/>
    /// Currently based on [jondurbin/airoboros-l2-70b](https://huggingface.co/jondurbin/airoboros-l2-70b-2.2.1), but might get updated in the future.  <br/>
    /// </summary>
    Airoboros70B,

    /// <summary>
    /// Xwin-LM aims to develop and open-source alignment tech for LLMs. Our first release, built-upon on the [Llama2](/models/${Model.Llama_2_13B_Chat}) base models, ranked TOP-1 on AlpacaEval. Notably, it's the first to surpass [GPT-4](/models/${Model.GPT_4}) on this benchmark. The project will be continuously updated.  <br/>
    /// </summary>
    Xwin70B,

    /// <summary>
    /// This model is a variant of GPT-3.5 Turbo tuned for instructional prompts and omitting chat-related optimizations. Training data: up to Sep 2021.  <br/>
    /// </summary>
    OpenAiGpt35TurboInstruct,

    /// <summary>
    /// A 7.3B parameter model that outperforms Llama 2 13B on all benchmarks, with optimizations for speed and context length.  <br/>
    /// </summary>
    MistralMistral7BInstructV01,

    /// <summary>
    /// A blend of the new Pygmalion-13b and MythoMax. #merge  <br/>
    /// </summary>
    PygmalionMythalion13B,

    /// <summary>
    /// This model offers four times the context length of gpt-3.5-turbo, allowing it to support approximately 20 pages of text in a single request at a higher cost. Training data: up to Sep 2021.  <br/>
    /// </summary>
    OpenAiGpt35Turbo16K,

    /// <summary>
    /// GPT-4-32k is an extended version of GPT-4, with the same capabilities but quadrupled context length, allowing for processing up to 40 pages of text in a single pass. This is particularly beneficial for handling longer content like interacting with PDFs without an external vector database. Training data: up to Sep 2021.  <br/>
    /// </summary>
    OpenAiGpt432K,

    /// <summary>
    /// GPT-4-32k is an extended version of GPT-4, with the same capabilities but quadrupled context length, allowing for processing up to 40 pages of text in a single pass. This is particularly beneficial for handling longer content like interacting with PDFs without an external vector database. Training data: up to Sep 2021.  <br/>
    /// </summary>
    OpenAiGpt432KOlderV0314,

    /// <summary>
    /// A state-of-the-art language model fine-tuned on over 300k instructions by Nous Research, with Teknium and Emozilla leading the fine tuning process.  <br/>
    /// </summary>
    NousHermes13B,

    /// <summary>
    /// An attempt to recreate Claude-style verbosity, but don't expect the same level of coherence or memory. Meant for use in roleplay/narrative situations.  <br/>
    /// </summary>
    MancerWeaverAlpha,

    /// <summary>
    /// Zephyr is a series of language models that are trained to act as helpful assistants. Zephyr-7B-β is the second model in the series, and is a fine-tuned version of [mistralai/Mistral-7B-v0.1](/models/mistralai/mistral-7b-instruct-v0.1) that was trained on a mix of publicly available, synthetic datasets using Direct Preference Optimization (DPO).  <br/>
    /// </summary>
    HuggingFaceZephyr7BFree,

    /// <summary>
    /// Anthropic's flagship model. Superior performance on tasks that require complex reasoning. Supports hundreds of pages of text.  <br/>
    /// </summary>
    AnthropicClaudeV20SelfModerated,

    /// <summary>
    /// Anthropic's flagship model. Superior performance on tasks that require complex reasoning. Supports hundreds of pages of text.  <br/>
    /// </summary>
    AnthropicClaudeV20,

    /// <summary>
    /// A recreation trial of the original MythoMax-L2-B13 but with updated models. #merge  <br/>
    /// </summary>
    RemmSlerp13B,

    /// <summary>
    /// PaLM 2 is a language model by Google with improved multilingual, reasoning and coding capabilities.  <br/>
    /// </summary>
    GooglePalm2Chat,

    /// <summary>
    /// PaLM 2 fine-tuned for chatbot conversations that help with code-related questions.  <br/>
    /// </summary>
    GooglePalm2CodeChat,

    /// <summary>
    /// One of the highest performing and most popular fine-tunes of Llama 2 13B, with rich descriptions and roleplay. #merge  <br/>
    /// </summary>
    Mythomax13BFree,

    /// <summary>
    /// One of the highest performing and most popular fine-tunes of Llama 2 13B, with rich descriptions and roleplay. #merge  <br/>
    /// </summary>
    Mythomax13B,

    /// <summary>
    /// A 13 billion parameter language model from Meta, fine tuned for chat completions  <br/>
    /// </summary>
    MetaLlama213BChat,

    /// <summary>
    /// The flagship, 70 billion parameter language model from Meta, fine tuned for chat completions. Llama 2 is an auto-regressive language model that uses an optimized transformer architecture. The tuned versions use supervised fine-tuning (SFT) and reinforcement learning with human feedback (RLHF) to align to human preferences for helpfulness and safety.  <br/>
    /// </summary>
    MetaLlama270BChat,

    /// <summary>
    /// GPT-3.5 Turbo is OpenAI's fastest model. It can understand and generate natural language or code, and is optimized for chat and traditional completion tasks.  <br/>
    /// Training data up to Sep 2021.  <br/>
    /// </summary>
    OpenAiGpt35Turbo,

    /// <summary>
    /// The latest GPT-3.5 Turbo model with improved instruction following, JSON mode, reproducible outputs, parallel function calling, and more. Training data: up to Sep 2021.  <br/>
    /// This version has a higher accuracy at responding in requested formats and a fix for a bug which caused a text encoding issue for non-English language function calls.  <br/>
    /// </summary>
    OpenAiGpt35Turbo16K0125,

    /// <summary>
    /// OpenAI's flagship model, GPT-4 is a large-scale multimodal language model capable of solving difficult problems with greater accuracy than previous models due to its broader general knowledge and advanced reasoning capabilities. Training data: up to Sep 2021.  <br/>
    /// </summary>
    OpenAiGpt4,

    /// <summary>
    /// GPT-4-0314 is the first version of GPT-4 released, with a context length of 8,192 tokens, and was supported until June 14. Training data: up to Sep 2021.  <br/>
    /// </summary>
    OpenAiGpt4OlderV0314,

}