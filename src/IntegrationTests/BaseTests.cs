using System.Diagnostics;
using LangChain.Chains.LLM;
using LangChain.Prompts;
using LangChain.Providers;
using LangChain.Schema;

namespace LangChain.IntegrationTests;

[TestFixture]
public class BaseTests
{
    [TestCase(ProviderType.OpenAi)]
    [TestCase(ProviderType.Together)]
    [TestCase(ProviderType.OpenRouter)]
    [TestCase(ProviderType.Fireworks)]
    //[TestCase(ProviderType.Google)]
    //[TestCase(ProviderType.Anthropic)]
    [TestCase(ProviderType.DeepInfra)]
    [TestCase(ProviderType.DeepSeek)]
    //[TestCase(ProviderType.Ollama)]
    public async Task FiveRandomWords(ProviderType providerType)
    {
        var requests = new List<ChatRequest>();
        var deltas = new List<ChatResponseDelta>();
        var responses = new List<ChatResponse>();

        var (llm, _, provider) = Helpers.GetModels(providerType);
        llm.RequestSent += (_, request) =>
        {
            Console.WriteLine($"RequestSent: {request.Messages.AsHistory()}");
            requests.Add(request);
        };
        llm.DeltaReceived += (_, delta) =>
        {
            Console.WriteLine($"DeltaReceived: {delta.Content}");
            deltas.Add(delta);
        };
        llm.ResponseReceived += (_, response) =>
        {
            Console.WriteLine($"ResponseReceived: {response}");
            responses.Add(response);
        };

        var response = await llm.GenerateAsync(
            request: "Answer me five random words",
            cancellationToken: CancellationToken.None);

        Console.WriteLine($"LLM response: {response}"); // The cloaked figure.
        Console.WriteLine($"Usage: {response.Usage}"); // Print usage and price

        requests.Should().HaveCount(1);
        deltas.Should().HaveCount(1);
        responses.Should().HaveCount(1);

        response.LastMessageContent.Should().NotBeNull();

        response.Usage.Messages.Should().Be(1);
        response.Usage.Time.Should().BeGreaterThan(TimeSpan.Zero);
        if (providerType != ProviderType.OpenRouter)
        {
            response.Usage.InputTokens.Should().BeGreaterThan(0);
            response.Usage.OutputTokens.Should().BeGreaterThan(0);
            response.Usage.TotalTokens.Should().BeGreaterThan(0);
        }
        if (providerType == ProviderType.OpenAi)
        {
            response.Usage.PriceInUsd.Should().HaveValue().And.BeGreaterThan(0);
        }

        llm.Usage.Should().BeEquivalentTo(response.Usage);
        provider.Usage.Should().BeEquivalentTo(response.Usage);

        response.Messages.Should().HaveCount(2);
        response.Messages[0].Role.Should().Be(MessageRole.Human);
        response.Messages[0].Content.Should().NotBeNullOrEmpty();
        response.Messages[1].Role.Should().Be(MessageRole.Ai);
        response.Messages[1].Content.Should().NotBeNullOrEmpty();
        response.Messages[1].Content.Should().NotBe(response.Messages[0].Content);
        response.Messages[1].Content.Should().Be(response.LastMessageContent);
        response.Delta.Should().BeNull();
        response.FinishReason.Should().Be(ChatResponseFinishReason.Stop);
        response.LastMessage.Should().NotBeNull().And.Be(response.Messages[1]);
        response.ToolCalls.Should().BeEmpty();
        response.UsedSettings.Should().NotBeNull();
    }

    [TestCase(ProviderType.OpenAi)]
    [TestCase(ProviderType.Together)]
    //[TestCase(ProviderType.OpenRouter)]
    //[TestCase(ProviderType.Fireworks)]
    //[TestCase(ProviderType.Google)]
    //[TestCase(ProviderType.Anthropic)]
    [TestCase(ProviderType.DeepInfra)]
    [TestCase(ProviderType.DeepSeek)]
    //[TestCase(ProviderType.Ollama)]
    public async Task FiveRandomWords_Streaming(ProviderType providerType)
    {
        var stopwatch = Stopwatch.StartNew();

        var requestsFromEvent = new List<ChatRequest>();
        var deltasFromEvent = new List<ChatResponseDelta>();
        var responsesFromEvent = new List<ChatResponse>();
        var responsesFromAsyncEnumerable = new List<ChatResponse>();

        var (llm, _, provider) = Helpers.GetModels(providerType);
        llm.RequestSent += (_, request) =>
        {
            Console.WriteLine($"{stopwatch.Elapsed}. RequestSent: {request.Messages.AsHistory()}");
            requestsFromEvent.Add(request);
        };
        llm.DeltaReceived += (_, delta) =>
        {
            Console.WriteLine($"{stopwatch.Elapsed}. DeltaReceived: {delta.Content}");
            deltasFromEvent.Add(delta);
        };
        llm.ResponseReceived += (_, response) =>
        {
            Console.WriteLine($"{stopwatch.Elapsed}. ResponseReceived: {response}");
            responsesFromEvent.Add(response);
        };

        var enumerable = llm.GenerateAsync(
            request: "Answer me five random words",
            new ChatSettings
            {
                UseStreaming = true,
            },
            cancellationToken: CancellationToken.None);

        await foreach (var response in enumerable)
        {
            Console.WriteLine($"{stopwatch.Elapsed}. LLM partial response: {response}"); // The cloaked figure.

            responsesFromAsyncEnumerable.Add(response);
        }

        var lastResponse = responsesFromAsyncEnumerable.Last();
        lastResponse.Should().NotBeNull();

        Console.WriteLine($"{stopwatch.Elapsed}. Last LLM response: {lastResponse}"); // The cloaked figure.
        Console.WriteLine($"{stopwatch.Elapsed}. Usage: {lastResponse.Usage}"); // Print usage and price

        requestsFromEvent.Should().HaveCount(1);
        deltasFromEvent.Should().HaveCountGreaterThanOrEqualTo(5);
        //deltasFromEvent.Should().BeEquivalentTo(responsesFromAsyncEnumerable.Select(x => x.Delta));
        responsesFromEvent.Should().HaveCount(1);
        responsesFromEvent.Should().BeEquivalentTo([responsesFromAsyncEnumerable.Last()]);

        lastResponse.LastMessageContent.Should().NotBeNull();

        lastResponse.Usage.Messages.Should().Be(1);
        lastResponse.Usage.Time.Should().BeGreaterThan(TimeSpan.Zero);
        if (providerType != ProviderType.OpenRouter)
        {
            lastResponse.Usage.InputTokens.Should().BeGreaterThan(0);
            lastResponse.Usage.OutputTokens.Should().BeGreaterThan(0);
            lastResponse.Usage.TotalTokens.Should().BeGreaterThan(0);
        }
        if (providerType == ProviderType.OpenAi)
        {
            lastResponse.Usage.PriceInUsd.Should().HaveValue().And.BeGreaterThan(0);
        }

        llm.Usage.Should().BeEquivalentTo(lastResponse.Usage);
        provider.Usage.Should().BeEquivalentTo(lastResponse.Usage);

        lastResponse.Messages.Should().HaveCount(2);
        lastResponse.Messages[0].Role.Should().Be(MessageRole.Human);
        lastResponse.Messages[0].Content.Should().NotBeNullOrEmpty();
        lastResponse.Messages[1].Role.Should().Be(MessageRole.Ai);
        lastResponse.Messages[1].Content.Should().NotBeNullOrEmpty();
        lastResponse.Messages[1].Content.Should().NotBe(lastResponse.Messages[0].Content);
        lastResponse.Messages[1].Content.Should().Be(lastResponse.LastMessageContent);
        lastResponse.Delta.Should().BeNull();
        lastResponse.FinishReason.Should().Be(ChatResponseFinishReason.Stop);
        lastResponse.LastMessage.Should().NotBeNull().And.Be(lastResponse.Messages[1]);
        lastResponse.ToolCalls.Should().BeEmpty();
        lastResponse.UsedSettings.Should().NotBeNull();
    }

    [TestCase(ProviderType.OpenAi)]
    [TestCase(ProviderType.Together)]
    [TestCase(ProviderType.OpenRouter)]
    [TestCase(ProviderType.Fireworks)]
    //[TestCase(ProviderType.Google)]
    //[TestCase(ProviderType.Anthropic)]
    //[TestCase(ProviderType.DeepInfra)]
    [TestCase(ProviderType.DeepSeek)]
    public async Task SimpleChain(ProviderType providerType)
    {
        var (llm, _, _) = Helpers.GetModels(providerType);

        const string template = "What is a good name for a company that makes {product}?";
        var prompt = new PromptTemplate(new PromptTemplateInput(template, ["product"]));

        var chain = new LlmChain(new LlmChainInput(llm, prompt));

        var result = await chain.CallAsync(new ChainValues(new Dictionary<string, object>(1)
        {
            ["product"] = "colourful socks",
        }));

        Console.WriteLine(result.Value["text"]);

        // The result is an object with a `text` property.
        result.Value["text"].ToString().Should().NotBeEmpty();
    }

    [TestCase(ProviderType.OpenAi)]
    // [TestCase(ProviderType.Together)]
    // [TestCase(ProviderType.OpenRouter)]
    // [TestCase(ProviderType.Fireworks)]
    [TestCase(ProviderType.Google)]
    // [TestCase(ProviderType.Anthropic)]
    // [TestCase(ProviderType.DeepInfra)]
    // [TestCase(ProviderType.DeepSeek)]
    public async Task Tools_Weather(ProviderType providerType)
    {
        var (llm, _, _) = Helpers.GetModels(providerType);

        var service = new WeatherService();
        llm.AddGlobalTools(service.AsTools(), service.AsCalls());

        var response = await llm.GenerateAsync(
            new[]
            {
                 "You are a helpful weather assistant.".AsSystemMessage(),
                 "What is the current temperature in Dubai, UAE in Celsius?".AsHumanMessage(),
            });
        response.Usage.InputTokens.Should().BeGreaterThan(0);
        response.Usage.OutputTokens.Should().BeGreaterThan(0);
        response.Usage.PriceInUsd.Should().BeGreaterThan(0);

        Console.WriteLine(response.Messages.AsHistory());
    }

    [TestCase(ProviderType.OpenAi)]
    //[TestCase(ProviderType.Anyscale)]
    //[TestCase(ProviderType.Together)]
    //[TestCase(ProviderType.OpenRouter)]
    //[TestCase(ProviderType.Fireworks)]
    //[TestCase(ProviderType.OpenRouter)]
    //[TestCase(ProviderType.DeepInfra)]
    //[TestCase(ProviderType.Google)]
    //[TestCase(ProviderType.Anthropic)]
    public async Task Tools_Books(ProviderType providerType)
    {
        var (llm, _, _) = Helpers.GetModels(providerType);

        var service = new BookStoreService();
        llm.AddGlobalTools(service.AsTools(), service.AsCalls());

        var response = await llm.GenerateAsync(
            new[]
            {
                "what is written on page 35 in the book 'abracadabra'?".AsHumanMessage(),
            });
        response.Usage.InputTokens.Should().BeGreaterThan(0);
        response.Usage.OutputTokens.Should().BeGreaterThan(0);
        response.Usage.PriceInUsd.Should().BeGreaterThan(0);

        Console.WriteLine(response.Messages.AsHistory());
    }


}