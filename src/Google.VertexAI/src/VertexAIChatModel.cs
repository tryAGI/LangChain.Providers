using Google.Apis.Auth.OAuth2;
using Google.Cloud.AIPlatform.V1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace LangChain.Providers.Google.VertexAI
{
    public class VertexAIChatModel(
        VertexAIProvider provider,
        string id
        ) : ChatModel(id), IChatModel
    {
        private VertexAIProvider Provider { get; } = provider ?? throw new ArgumentNullException(nameof(provider));

        public override async IAsyncEnumerable<ChatResponse> GenerateAsync(
        ChatRequest request,
        ChatSettings? settings = null,
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            request = request ?? throw new ArgumentNullException(nameof(request));

            var prompt = ToPrompt(request.Messages);
            var watch = Stopwatch.StartNew();

            if (settings?.UseStreaming == true)
            {
                var responseStream = Provider.Api.StreamGenerateContent(prompt).GetResponseStream();
                await foreach (var response in responseStream.WithCancellation(cancellationToken))
                {
                    yield return BuildChatResponse(response, request, settings, watch);
                }
            }
            else
            {
                var response = await Provider.Api.GenerateContentAsync(prompt).ConfigureAwait(false);
                yield return BuildChatResponse(response, request, settings, watch);
            }
        }

        private static ChatResponse BuildChatResponse
            (GenerateContentResponse response, ChatRequest request, ChatSettings? settings, Stopwatch watch)
        {
            var functionCall = response.Candidates[0].Content.Parts[0].FunctionCall;
            var result = request.Messages.Concat([response.Candidates[0].Content.Parts[0].Text.AsAiMessage()]).ToList();
            var usage = CalculateUsage(watch, response);
            var chatResponse = new ChatResponse
            {
                Messages = result,
                Usage = usage,
                UsedSettings = settings ?? ChatSettings.Default
            };
            if (functionCall != null)
                chatResponse.ToolCalls = ToToolCalls(functionCall);

            return chatResponse;
        }

        private static Usage CalculateUsage(Stopwatch watch, GenerateContentResponse response)
        {
            var usageMetadata = response?.UsageMetadata;

            return Usage.Empty with
            {
                Time = watch.Elapsed,
                InputTokens = usageMetadata?.PromptTokenCount ?? 0,
                OutputTokens = usageMetadata?.CandidatesTokenCount ?? 0
            };
        }

        private static IReadOnlyList<ChatToolCall> ToToolCalls(FunctionCall functionCall)
        {
            return [
                new ChatToolCall
                {
                    ToolName = functionCall.Name,
                    ToolArguments = JsonFormatter.Default.Format(functionCall.Args),
                    Id = functionCall.Name
                }];
        }

        private GenerateContentRequest ToPrompt(IEnumerable<Message> messages)
        {
            var serviceAccountCredential = Provider.Configuration.GoogleCredential?.UnderlyingCredential as ServiceAccountCredential;
            var request = new GenerateContentRequest
            {
                Model = $"projects/{serviceAccountCredential?.ProjectId}/locations/{Provider.Configuration.Location}/publishers/{Provider.Configuration.Publisher}/models/{Id}",
                Contents = { messages.Select(ConvertMessage) },
                GenerationConfig = Provider.Configuration.GenerationConfig,
            };

            var tools = InitTool(Provider.Configuration.FunctionDeclaration);
            if (tools.Count > 0)
                request.Tools.AddRange(tools);

            return request;
        }

        private static RepeatedField<Tool> InitTool(FunctionDeclaration? functionDeclaration)
        {
            var tools = new RepeatedField<Tool>();
            if (functionDeclaration != null)
            {
                tools.Add(new Tool
                {
                    FunctionDeclarations = { functionDeclaration }
                });
            }
            return tools;
        }

        private static Content ConvertMessage(Message message)
        {
            return new Content
            {
                Role = ConvertRole(message.Role),
                Parts = { new Part { Text = message.Content } }
            };
        }

        private static string ConvertRole(MessageRole role)
        {
            return role switch
            {
                MessageRole.Human => "USER",
                MessageRole.Ai => "MODEL",
                MessageRole.System => "MODEL",
                _ => throw new NotSupportedException($"the role {role} is not supported")
            };
        }
    }
}
