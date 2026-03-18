# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

AI provider abstractions and implementations for the LangChain .NET ecosystem. Defines unified interfaces for chat, embeddings, text-to-image, text-to-speech, speech-to-text, image-to-text, text-to-music, and moderation models. Designed as a standalone library with no dependency on LangChain.Core -- can be used independently. Distributed as individual NuGet packages per provider (e.g., `LangChain.Providers.OpenAI`, `LangChain.Providers.Anthropic`).

## Build and Test Commands

```bash
# Build the entire solution
dotnet build LangChain.Providers.slnx

# Run integration tests (requires API keys for most providers)
dotnet test src/IntegrationTests/LangChain.IntegrationTests.csproj

# Run provider-specific tests
dotnet test src/Ollama/test/LangChain.Providers.Ollama.Tests.csproj
dotnet test src/Amazon.Bedrock/test/LangChain.Providers.Amazon.Bedrock.Tests.csproj

# Run a specific test
dotnet test src/IntegrationTests/LangChain.IntegrationTests.csproj --filter "FullyQualifiedName~OpenAI"

# Validate trimming/NativeAOT compatibility (requires: dotnet tool install -g autosdk.cli --prerelease)
autosdk trim src/libs/*//*.csproj
```

Tests require provider-specific API keys via environment variables. Tests skip (not fail) if keys are unset.

## Architecture

### Project Structure

```
src/
├── Abstractions/src/          # LangChain.Providers.Abstractions — core interfaces
├── OpenAI/src/                # OpenAI (GPT, DALL-E, Whisper, TTS, embeddings)
├── Anthropic/src/             # Anthropic (Claude models)
├── Google/src/                # Google AI (Gemini)
├── Google.VertexAI/src/       # Google Vertex AI
├── Ollama/src/                # Ollama (local models)
├── Azure/src/                 # Azure OpenAI
├── Amazon.Bedrock/src/        # AWS Bedrock
├── Amazon.Sagemaker/src/      # AWS SageMaker
├── DeepInfra/src/             # DeepInfra
├── DeepSeek/src/              # DeepSeek
├── Fireworks/src/             # Fireworks AI
├── Groq/src/                  # Groq
├── HuggingFace/src/           # Hugging Face Inference API
├── OpenRouter/src/            # OpenRouter (multi-provider gateway)
├── TogetherAI/src/            # Together AI
├── Anyscale/src/              # Anyscale
├── LLamaSharp/src/            # LLamaSharp (local GGUF models)
├── LeonardoAI/src/            # Leonardo AI (image generation)
├── Automatic1111/src/         # Automatic1111 / Stable Diffusion WebUI
├── WhisperNet/src/            # Whisper.net (local speech-to-text)
├── Reka/src/                  # Reka AI
├── Suno/src/                  # Suno (music generation)
├── Pollinations/src/          # Pollinations AI
├── IntegrationTests/          # Cross-provider integration tests
└── Helpers/
    ├── GenerateDocs/          # Documentation generation
Examples/                      # Example projects (Ollama, OpenRouter, Pollinations)
```

### Core Abstractions (src/Abstractions/src/)

**Common** (`Common/`):
- `IProvider` — top-level provider interface with default settings for all model types
- `IModel` / `IModel<TSettings>` — base model with ID and usage tracking
- `Provider` / `Model<TSettings>` — abstract base implementations
- `Usage` — tracks input/output tokens, time, and cost with arithmetic operators

**Chat** (`Chat/`):
- `IChatModel` — main chat model interface with `GenerateAsync()` returning `IAsyncEnumerable<ChatResponse>`
- `ChatModel` — abstract base class with `DeltaReceived`, `ResponseReceived`, `RequestSent` events
- `ChatRequest` / `ChatResponse` / `ChatResponseDelta` — request/response DTOs
- `Message` — chat message with `Content`, `Role`, and tool call support
- `MessageRole` — Human, Ai, System, FunctionCall, FunctionResult, Chat, ToolCall, ToolResult
- `ChatSettings` — temperature, max tokens, stop sequences, tool configuration
- `ChatToolCall` — function/tool call representation
- Built-in tool calling support via `AddGlobalTools()` / `ClearGlobalTools()` with `CallToolsAutomatically` / `ReplyToToolCallsAutomatically` flags

**Embedding** (`Embedding/`):
- `IEmbeddingModel` — `CreateEmbeddingsAsync()` for text-to-vector conversion

**Text-to-Image** (`TextToImage/`):
- `ITextToImageModel` — image generation from text prompts

**Text-to-Speech** (`TextToSpeech/`):
- `ITextToSpeechModel` — speech synthesis

**Speech-to-Text** (`SpeechToText/`):
- `ISpeechToTextModel` — transcription

**Image-to-Text** (`ImageToText/`):
- `IImageToTextModel` — image captioning / visual understanding

**Text-to-Music** (`TextToMusic/`):
- `ITextToMusicModel` — music generation from text

**Moderation** (`Moderation/`):
- `IModerationModel` — content moderation

### Provider Implementation Pattern

Each provider follows this structure:
1. `<Provider>Provider` class extending `Provider` — handles authentication and client setup
2. Model classes extending `ChatModel`, `EmbeddingModel`, etc.
3. `Predefined/` directory with convenience classes for popular models (e.g., `Gpt4OmniModel`, `TextEmbeddingV3SmallModel`)
4. Configuration class for settings

The OpenAI provider additionally supports custom endpoints for compatible APIs:
```csharp
OpenAiProvider.ToGroqProvider(apiKey)
OpenAiProvider.ToDeepInfraProvider(apiKey)
OpenAiProvider.ToOllamaProvider(baseUri)
// etc.
```

### Tools Integration

Uses `CSharpToJsonSchema` for function/tool calling:
1. Define C# interface with `[GenerateJsonSchema]` attribute
2. Add `[Description]` attributes for function/parameter docs
3. Register via `model.AddGlobalTools(tools, calls)`
4. Set `model.CallToolsAutomatically = true` for automatic execution

## Key Conventions

- **Target frameworks:** `net4.6.2`, `netstandard2.0`, `net8.0`, `net9.0` (abstractions); provider-specific targets vary
- **Language:** C# preview, nullable reference types enabled, implicit usings
- **Strong naming:** All assemblies signed with `src/key.snk`
- **Versioning:** MinVer with `v` tag prefix
- **Testing:** MSTest framework
- **Public API tracking:** `PublicAPI.Shipped.txt` / `PublicAPI.Unshipped.txt` via Microsoft.CodeAnalysis.PublicApiAnalyzers (abstractions only)
- Cross-project dependencies between LangChain ecosystem repos are via NuGet packages, not project references
- The abstractions package has a runtime dependency on `CSharpToJsonSchema` and `System.Text.Json`
