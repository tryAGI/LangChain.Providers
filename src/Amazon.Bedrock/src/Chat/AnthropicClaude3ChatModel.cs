using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using Amazon.BedrockRuntime.Model;
using LangChain.Providers.Amazon.Bedrock.Internal;

// ReSharper disable once CheckNamespace
namespace LangChain.Providers.Amazon.Bedrock;

public class AnthropicClaude3ChatModel(
    BedrockProvider provider,
    string id)
    : ChatModel(id)
{
    /// <summary>
    /// Generates a chat response based on the provided `ChatRequest`.
    /// </summary>
    /// <param name="request">The `ChatRequest` containing the input messages and other parameters.</param>
    /// <param name="settings">Optional `ChatSettings` to override the model's default settings.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation.</param>
    /// <returns>A `ChatResponse` containing the generated messages and usage information.</returns>
    public override async IAsyncEnumerable<ChatResponse> GenerateAsync(
        ChatRequest request,
        ChatSettings? settings = null,
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        request = request ?? throw new ArgumentNullException(nameof(request));

        var watch = Stopwatch.StartNew();
        var prompt = request.Messages.ToRolePrompt();
        var messages = request.Messages.ToList();

        var stringBuilder = new StringBuilder();

        var usedSettings = AnthropicChatSettings.Calculate(
            requestSettings: settings,
            modelSettings: Settings,
            providerSettings: provider.ChatSettings);

        Usage? usage = null;

        var bodyJson = CreateBodyJson(prompt, usedSettings, request.Image);

        if (usedSettings.UseStreaming == true)
        {
            var streamRequest = BedrockModelRequest.CreateStreamRequest(Id, bodyJson);
            var response = await provider.Api.InvokeModelWithResponseStreamAsync(streamRequest, cancellationToken).ConfigureAwait(false);

            foreach (var payloadPart in response.Body)
            {
                var streamEvent = (PayloadPart)payloadPart;
                var chunk = await JsonSerializer.DeserializeAsync<JsonObject>(streamEvent.Bytes, cancellationToken: cancellationToken)
                    .ConfigureAwait(false);

                usage ??= GetUsage(chunk?["message"]?["usage"]);
                var type = chunk?["type"]!.GetValue<string>().ToUpperInvariant();

                if (type == "MESSAGE_DELTA")
                {
                    usage += GetUsage(chunk?["usage"]);
                }

                if (type == "CONTENT_BLOCK_DELTA")
                {
                    var delta = chunk?["delta"]?["text"]!.GetValue<string>();

                    OnDeltaReceived(new ChatResponseDelta
                    {
                        Content = delta ?? string.Empty,
                    });
                    stringBuilder.Append(delta);
                }
            }

            OnDeltaReceived(new ChatResponseDelta
            {
                Content = Environment.NewLine,
            });
            stringBuilder.Append(Environment.NewLine);

            var newMessage = new Message(
                Content: stringBuilder.ToString(),
                Role: MessageRole.Ai);
            messages.Add(newMessage);
        }
        else
        {
            var response = await provider.Api.InvokeModelAsync(Id, bodyJson, cancellationToken).ConfigureAwait(false);
            usage = GetUsage(response?["usage"]);

            var generatedText = response?["content"]?[0]?["text"]?.GetValue<string>() ?? "";

            messages.Add(generatedText.AsAiMessage());
        }

        usage ??= Usage.Empty;
        usage = usage.Value with
        {
            Time = watch.Elapsed,
            Messages = messages.Count,
        };
        AddUsage(usage.Value);
        provider.AddUsage(usage.Value);

        var chatResponse = new ChatResponse
        {
            Messages = messages,
            UsedSettings = usedSettings,
            Usage = usage.Value,
        };
        OnResponseReceived(chatResponse);

        yield return chatResponse;
    }

    /// <summary>
    /// Creates the request body JSON for the Anthropic model based on the provided prompt and settings.
    /// </summary>
    /// <param name="prompt">The input prompt for the model.</param>
    /// <param name="usedSettings">The settings to use for the request.</param>
    /// <param name="image">Binary image to use for the request.</param>
    /// <returns>A `JsonObject` representing the request body.</returns>
    private static JsonObject CreateBodyJson(
        string? prompt,
        AnthropicChatSettings usedSettings,
        BinaryData? image = null)
    {
        usedSettings = usedSettings ?? throw new ArgumentNullException(nameof(usedSettings));

        var bodyJson = new JsonObject
        {
            ["anthropic_version"] = "bedrock-2023-05-31",
            ["max_tokens"] = usedSettings.MaxTokens!.Value,
            ["messages"] = new JsonArray
            {
               new JsonObject
               {
                   ["role"] = "user",
                   ["content"] = new JsonArray
                   {
                       new JsonObject
                       {
                           ["type"] = "text",
                           ["text"] = prompt,
                       }
                   }
               }
            }
        };

        if (image != null)
        {
            var binaryData = BinaryData.FromBytes(image);
            var base64 = Convert.ToBase64String(binaryData.ToArray());
            var jsonImage = new JsonObject
            {
                ["type"] = "image",
                ["source"] = new JsonObject
                {
                    ["type"] = "base64",
                    ["media_type"] = image.MediaType,
                    ["data"] = base64
                }
            };

            var content = ((JsonArray)bodyJson["messages"]?[0]?["content"]!);
            content.Add(jsonImage);
        }

        return bodyJson;
    }

    /// <summary>
    /// Extracts usage information from the provided JSON node.
    /// </summary>
    /// <param name="usageNode">The JSON node containing usage information.</param>
    /// <returns>A <see cref="Usage"/> object with the extracted usage data.</returns>
    private Usage GetUsage(JsonNode? usageNode)
    {
        var inputTokens = usageNode?["input_tokens"]?.GetValue<int>() ?? 0;
        var outputTokens = usageNode?["output_tokens"]?.GetValue<int>() ?? 0;
        var priceInUsd = 0.0;

        return Usage.Empty with
        {
            InputTokens = inputTokens,
            OutputTokens = outputTokens,
            Messages = 0,
            PriceInUsd = priceInUsd,
        };
    }
}