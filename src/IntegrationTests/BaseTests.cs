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
    [TestCase(ProviderType.Anthropic)]
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
    [TestCase(ProviderType.Anthropic)]
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

    [Explicit]
    public async Task GoogleEmbeddingTest()
    {
        var (llm, embeddingModel, _) = Helpers.GetModels(ProviderType.Google);

        var embeddings = await embeddingModel.CreateEmbeddingsAsync(new EmbeddingRequest()
        {
            Strings = new List<string>
            {
                "The quick brown fox jumps over the lazy dog.",
                "She sells seashells by the seashore.",
                "How much wood would a woodchuck chuck if a woodchuck could chuck wood?",
                "A journey of a thousand miles begins with a single step.",
                "To be or not to be, that is the question.",
                "All that glitters is not gold.",
                "A picture is worth a thousand words.",
                "Actions speak louder than words.",
                "Better late than never.",
                "The early bird catches the worm.",
                "Fortune favors the bold.",
                "Ignorance is bliss.",
                "Look before you leap.",
                "Barking up the wrong tree.",
                "Birds of a feather flock together.",
                "Don't bite the hand that feeds you.",
                "Every cloud has a silver lining.",
                "Haste makes waste.",
                "Strike while the iron is hot.",
                "Time and tide wait for no man.",
                "When in Rome, do as the Romans do.",
                "Where there's smoke, there's fire.",
                "You can't judge a book by its cover.",
                "Practice makes perfect.",
                "Rome wasn't built in a day.",
                "Two heads are better than one.",
                "A rolling stone gathers no moss.",
                "Absence makes the heart grow fonder.",
                "Beauty is in the eye of the beholder.",
                "Cleanliness is next to godliness.",
                "Curiosity killed the cat.",
                "Don't count your chickens before they hatch.",
                "Honesty is the best policy.",
                "Necessity is the mother of invention.",
                "No man is an island.",
                "The pen is mightier than the sword.",
                "The squeaky wheel gets the grease.",
                "There's no place like home.",
                "Too many cooks spoil the broth.",
                "You can't have your cake and eat it too.",
                "A fool and his money are soon parted.",
                "Actions have consequences.",
                "An apple a day keeps the doctor away.",
                "As you sow, so shall you reap.",
                "Don't bite off more than you can chew.",
                "Don't put all your eggs in one basket.",
                "Early to bed and early to rise makes a man healthy, wealthy, and wise.",
                "Give credit where credit is due.",
                "Good things come to those who wait.",
                "If it ain't broke, don't fix it.",
                "If you can't beat 'em, join 'em.",
                "It's always darkest before the dawn.",
                "Keep your friends close and your enemies closer.",
                "Knowledge is power.",
                "Laughter is the best medicine.",
                "Let sleeping dogs lie.",
                "Out of sight, out of mind.",
                "The grass is always greener on the other side of the fence.",
                "The road to hell is paved with good intentions.",
                "Variety is the spice of life.",
                "What goes around comes around.",
                "You reap what you sow.",
                "Every rose has its thorn.",
                "Don't judge a person until you've walked a mile in their shoes.",
                "A watched pot never boils.",
                "Better safe than sorry.",
                "Beggars can't be choosers.",
                "Cut your coat according to your cloth.",
                "Don't make a mountain out of a molehill.",
                "Every dog has its day.",
                "Great minds think alike.",
                "If it sounds too good to be true, it probably is.",
                "Lend your money and lose your friend.",
                "Keep your chin up.",
                "Actions create reactions.",
                "Don't throw the baby out with the bathwater.",
                "A stitch in time saves nine.",
                "Out of the frying pan and into the fire.",
                "The customer is always right.",
                "The proof of the pudding is in the eating.",
                "There's no such thing as a free lunch.",
                "This too shall pass.",
                "To err is human; to forgive, divine.",
                "You can't please everyone.",
                "What doesn't kill you makes you stronger.",
                "Don't cry over spilled milk.",
                "Good fences make good neighbors.",
                "Hope for the best but prepare for the worst.",
                "It's no use crying over spilt milk.",
                "Life is what you make it.",
                "Live and let live.",
                "Never look a gift horse in the mouth.",
                "When the going gets tough, the tough get going.",
                "You can't have it both ways.",
                "You can't make an omelette without breaking eggs.",
                "Necessity knows no law.",
                "Failing to prepare is preparing to fail."
            }
        });
        embeddings.Values.Should().HaveCountGreaterThan(0);
        embeddings.Values.First().Should().HaveCountGreaterThan(0);
    }
}