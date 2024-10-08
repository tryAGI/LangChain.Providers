﻿using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using Amazon.BedrockRuntime;
using Amazon.BedrockRuntime.Model;
using Amazon.Util;
using LangChain.Splitters.Text;

// ReSharper disable once CheckNamespace
namespace LangChain.Providers.Amazon.Bedrock.Internal;

internal static class BedrockExtensions
{
    public static IReadOnlyList<string> Split(
        this IList<string> strings,
        int chunkSize)
    {
        var inputText = string.Join(" ", strings);
        var textSplitter = new RecursiveCharacterTextSplitter(chunkSize: chunkSize);

        return textSplitter.SplitText(inputText);
    }

    internal static async Task<JsonNode?> InvokeModelAsync(
        this AmazonBedrockRuntimeClient client,
        string id,
        MemoryStream memoryStream,
        CancellationToken cancellationToken = default)
    {
        memoryStream = memoryStream ?? throw new ArgumentNullException(nameof(memoryStream));

        var response = await client.InvokeModelAsync(new InvokeModelRequest
        {
            ModelId = id,
            Body = memoryStream,
            ContentType = "application/json",
            Accept = "application/json"
        }, cancellationToken).ConfigureAwait(false);

        if (response.HttpStatusCode != System.Net.HttpStatusCode.OK)
        {
            throw new InvalidOperationException(
                $"InvokeModelAsync failed with status code: {response.HttpStatusCode}");
        }

        return await JsonNode.ParseAsync(
            utf8Json: response.Body,
            cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public static async Task<JsonNode?> InvokeModelAsync(
        this AmazonBedrockRuntimeClient client,
        string id,
        byte[] bytes,
        CancellationToken cancellationToken = default)
    {
        using var stream = new MemoryStream(bytes);

        return await client.InvokeModelAsync(
            id: id,
            memoryStream: stream,
            cancellationToken).ConfigureAwait(false);
    }

    public static async Task<JsonNode?> InvokeModelAsync(
        this AmazonBedrockRuntimeClient client,
        string id,
        JsonObject jsonObject,
        CancellationToken cancellationToken = default)
    {
        using var stream = AWSSDKUtils.GenerateMemoryStreamFromString(jsonObject.ToJsonString());

        return await client.InvokeModelAsync(
            id: id,
            memoryStream: stream,
            cancellationToken).ConfigureAwait(false);
    }

    public static async Task<T?> InvokeModelAsync<T>(
        this AmazonBedrockRuntimeClient client,
        string id,
        JsonObject jsonObject,
        CancellationToken cancellationToken = default)
    {
        using var stream = AWSSDKUtils.GenerateMemoryStreamFromString(jsonObject.ToJsonString());

        var request = new InvokeModelRequest()
        {
            ContentType = "application/json",
            Accept = "application/json",
            ModelId = id,
            Body = stream
        };

        var response = await client.InvokeModelAsync(request, cancellationToken).ConfigureAwait(false);

        if (response.HttpStatusCode != System.Net.HttpStatusCode.OK)
        {
            throw new InvalidOperationException(
                $"InvokeModelAsync failed with status code: {response.HttpStatusCode}");
        }

        return await JsonSerializer.DeserializeAsync<T>(response.Body, cancellationToken: cancellationToken)
            .ConfigureAwait(false);
    }

    public static string ToSimplePrompt(this IReadOnlyCollection<Message> messages)
    {
        messages = messages ?? throw new ArgumentNullException(nameof(messages));

        var sb = new StringBuilder();

        foreach (var item in messages)
        {
            sb.Append(item.Content);
        }
        return sb.ToString();
    }

    public static string ToRolePrompt(this IReadOnlyCollection<Message> messages)
    {
        messages = messages ?? throw new ArgumentNullException(nameof(messages));

        var sb = new StringBuilder();

        foreach (var item in messages)
        {
            switch (item.Role)
            {
                case MessageRole.Human:
                case MessageRole.System:
                case MessageRole.Chat:
                case MessageRole.ToolCall:
                case MessageRole.ToolResult:
                    sb.Append("Human: " + item.Content);
                    break;

                case MessageRole.Ai:
                    sb.Append("Assistant: " + item.Content);
                    break;

                default:
                    sb.Append("\n\nAssistant: ");
                    break;
            }
        }
        sb.Append("\n\nAssistant: ");
        return sb.ToString();
    }
}