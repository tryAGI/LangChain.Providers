using System.Diagnostics;
using Amazon;
using LangChain.Chains.LLM;
using LangChain.Chains.Sequentials;
using LangChain.Databases;
using LangChain.Databases.InMemory;
using LangChain.Databases.Sqlite;
using LangChain.DocumentLoaders;
using LangChain.Extensions;
using LangChain.Prompts;
using LangChain.Providers.Amazon.Bedrock.Predefined.Ai21Labs;
using LangChain.Providers.Amazon.Bedrock.Predefined.Amazon;
using LangChain.Providers.Amazon.Bedrock.Predefined.Anthropic;
using LangChain.Providers.Amazon.Bedrock.Predefined.Cohere;
using LangChain.Providers.Amazon.Bedrock.Predefined.Meta;
using LangChain.Providers.Amazon.Bedrock.Predefined.Mistral;
using LangChain.Providers.Amazon.Bedrock.Predefined.Stability;
using LangChain.Schema;
using LangChain.Splitters.Text;
using static LangChain.Chains.Chain;

namespace LangChain.Providers.Amazon.Bedrock.Tests;

[TestFixture, Explicit]
public class BedrockTests
{
    [Test]
    public async Task Chains()
    {
        var provider = new BedrockProvider(RegionEndpoint.USWest2);
        //var llm = new Jurassic2MidModel(provider);
        //var llm = new Claude35SonnetModel(provider);
        //var llm = new Mistral7BInstruct(provider);
        //var llm = new JambaInstructModel(provider);
        var llm = new Llama32With3BInstructModel(provider);

        var template = "What is a good name for a company that makes {product}?";
        var prompt = new PromptTemplate(new PromptTemplateInput(template, new List<string>(1) { "product" }));

        var chain = new LlmChain(new LlmChainInput(llm, prompt));

        var result = await chain.CallAsync(new ChainValues(new Dictionary<string, object>(1)
        {
            { "product", "fast cars" }
        }));

        Console.WriteLine("text: " + result.Value["text"]);
    }

    [Test]
    public async Task SequenceChainTests()
    {
        var provider = new BedrockProvider();
        var llm = new Jurassic2MidModel(provider);
        //var llm = new ClaudeV21Model(provider);
        //var llm = new Llama2With13BModel(provider);

        var firstTemplate = "What is a good name for a company that makes {product}?";
        var firstPrompt = new PromptTemplate(new PromptTemplateInput(firstTemplate, new List<string>(1) { "product" }));

        var chainOne = new LlmChain(new LlmChainInput(llm, firstPrompt)
        {
            Verbose = true,
            OutputKey = "company_name"
        });

        var secondTemplate = "Write a 20 words description for the following company:{company_name}";
        var secondPrompt =
            new PromptTemplate(new PromptTemplateInput(secondTemplate, new List<string>(1) { "company_name" }));

        var chainTwo = new LlmChain(new LlmChainInput(llm, secondPrompt));

        var overallChain = new SequentialChain(new SequentialChainInput(
            [
                chainOne,
                chainTwo
            ],
            ["product"],
            ["company_name", "text"]
        ));

        var result = await overallChain.CallAsync(new ChainValues(new Dictionary<string, object>(1)
        {
            { "product", "colourful socks" }
        }));

        Console.WriteLine(result.Value["text"]);
    }

    [Test]
    public async Task LlmChainTest()
    {
        var provider = new BedrockProvider();
        var llm = new Jurassic2MidModel(provider);
        //var llm = new ClaudeV21Model(provider);
        //var llm = new Llama2With13BModel(provider);

        var promptText =
            @"You will be provided with information about pet. Your goal is to extract the pet name.

Information:
{information}

The pet name is 
";

        var chain =
            Set("My dog name is Bob", outputKey: "information")
            | Template(promptText, outputKey: "prompt")
            | LLM(llm, inputKey: "prompt", outputKey: "text");

        var res = await chain.RunAsync(resultKey: "text");
        Console.WriteLine(res);
    }


    [Test]
    public async Task RetrievalChainTest()
    {
        var provider = new BedrockProvider();
        //var llm = new Jurassic2MidModel();
        //var llm = new ClaudeV21Model();
        var llm = new Claude3HaikuModel(provider);
        var embeddings = new TitanEmbedImageV1Model(provider);
        var vectorCollection = new InMemoryVectorCollection();
        await vectorCollection
            .AddDocumentsAsync(embeddings, new[]
            {
                "I spent entire day watching TV",
                "My dog's name is Bob",
                "This icecream is delicious",
                "It is cold in space"
            }.ToDocuments());

        string prompt1Text =
            @"Use the following pieces of context to answer the question at the end. If you don't know the answer, just say that you don't know, don't try to make up an answer.

{context}

Question: {question}
Helpful Answer:";

        var prompt2Text =
            @"Human will provide you with sentence about pet. You need to answer with pet name.

Human: My dog name is Jack
Answer: Jack
Human: I think the best name for a pet is ""Jerry""
Answer: Jerry
Human: {pet_sentence}
Answer: ";

        var chainQuestion =
            Set("What is the good name for a pet?", outputKey: "question")
            | RetrieveDocuments(vectorCollection, embeddings, inputKey: "question", outputKey: "documents")
            | StuffDocuments(inputKey: "documents", outputKey: "context")
            | Template(prompt1Text, outputKey: "prompt")
            | LLM(llm, inputKey: "prompt", outputKey: "pet_sentence");

        //  var chainQuestionRes = await chainQuestion.RunAsync(resultKey: "pet_sentence");

        var chainFilter =
            // do not move the entire dictionary from the other chain
            chainQuestion.AsIsolated(outputKey: "pet_sentence")
            | Template(prompt2Text, outputKey: "prompt")
            | LLM(llm, inputKey: "prompt", outputKey: "text");

        var res = await chainFilter.RunAsync(resultKey: "text");
        Console.WriteLine(res);
    }

    [Test]
    public async Task SimpleRag()
    {
        var provider = new BedrockProvider();
        //var llm = new Jurassic2MidModel();
        //var llm = new ClaudeV21Model();
        var llm = new Claude3HaikuModel(provider);
        var embeddings = new TitanEmbedImageV1Model(provider);

        var loader = new PdfPigPdfLoader();
        var documents = await loader.LoadAsync(DataSource.FromPath("x:\\Harry-Potter-Book-1.pdf"));

        ITextSplitter textSplitter = new RecursiveCharacterTextSplitter(chunkSize: 200, chunkOverlap: 50);

        if (File.Exists("vectors.db"))
            File.Delete("vectors.db");

        var vectorDatabase = new SqLiteVectorDatabase("vectors.db");
        var vectorCollection = await vectorDatabase.GetOrCreateCollectionAsync(VectorCollection.DefaultName, dimensions: 1536);
        if (!File.Exists("vectors.db"))
            await vectorCollection.AddSplitDocumentsAsync(embeddings, documents, textSplitter: textSplitter);

        string promptText =
            @"Use the following pieces of context to answer the question at the end. If the answer is not in context then just say that you don't know, don't try to make up an answer. Keep the answer as short as possible.

{context}

Question: {question}
Helpful Answer:";


        var chain =
            Set("what color is the car?", outputKey: "question")                     // set the question
                                                                                     //Set("Hagrid was looking for the golden key.  Where was it?", outputKey: "question")                     // set the question
                                                                                     // Set("Who was on the Dursleys front step?", outputKey: "question")                     // set the question
                                                                                     // Set("Who was drinking a unicorn blood?", outputKey: "question")                     // set the question
            | RetrieveDocuments(vectorCollection, embeddings, inputKey: "question", outputKey: "documents", amount: 5) // take 5 most similar documents
            | StuffDocuments(inputKey: "documents", outputKey: "context")                       // combine documents together and put them into context
            | Template(promptText)                                                              // replace context and question in the prompt with their values
            | LLM(llm);                                                                       // send the result to the language model

        var res = await chain.RunAsync("text");
        Console.WriteLine(res);
    }

    [Test]
    public async Task CanGetImage()
    {
        var provider = new BedrockProvider();
        var model = new TitanImageGeneratorV1Model(provider);
        var response = await model.GenerateImageAsync("create a picture of the solar system");

        var path = Path.Combine(Path.GetTempPath(), "solar_system.png");
        Data image = response.Images[0];
        var images = response.Images.Select(x => x.ToByteArray()).ToList();

        await File.WriteAllBytesAsync(path, response.Images[0].ToByteArray());

        Process.Start(path);
    }

    [Test]
    public async Task CanGetImage2()
    {
        var provider = new BedrockProvider();
        var model = new StableDiffusionSDXLModel(provider);
        var response = await model.GenerateImageAsync(
            "i'm going to prepare a recipe.  show me an image of realistic food ingredients");

        var path = Path.Combine(Path.GetTempPath(), "food2.png");

        await File.WriteAllBytesAsync(path, response.Images[0].ToByteArray());
    }

    [Test]
    public async Task CanGetStableDiffusionSD3Image()
    {
        var provider = new BedrockProvider(RegionEndpoint.USWest2);
        var model = new StableDiffusionSD3LargeModel(provider);
        // var model = new StableDiffusionImageCoreModel(provider);
        //var model = new StableDiffusionImageUltraModel(provider);
        var response = await model.GenerateImageAsync(
            "i'm going to prepare a recipe.  show me an image of realistic food ingredients");

        var path = Path.Combine(Path.GetTempPath(), "food1.png");

        await File.WriteAllBytesAsync(path, response.Images[0].ToByteArray());
    }


    [Test]
    public async Task ClaudeImageToText()
    {
        var provider = new BedrockProvider();
        var model = new Claude3HaikuModel(provider);

        var path = Path.Combine(Path.GetTempPath(), "solar_system.png");
        var imageData = await File.ReadAllBytesAsync(path);
        var binaryData = new BinaryData(imageData, "image/png");

        var message = new Message(" \"what's this a picture of and describe details?\"", MessageRole.Human);

        var chatRequest = ChatRequest.ToChatRequest(message);
        chatRequest.Image = binaryData;

        var response = await model.GenerateAsync(chatRequest, new ChatSettings { UseStreaming = true });

        Console.WriteLine(response);
    }

    [TestCase(true, false)]
    [TestCase(false, false)]
    [TestCase(true, true)]
    [TestCase(false, true)]
    public async Task SimpleTest(bool useStreaming, bool useChatSettings)
    {
        var provider = new BedrockProvider();
        var llm = new CommandRModel(provider);

        llm.RequestSent += (_, request) => Console.WriteLine($"Prompt: {request.Messages.AsHistory()}");
        llm.DeltaReceived += (_, delta) => Console.Write(delta.Content);
        llm.ResponseReceived += (_, response) => Console.WriteLine($"Completed response: {response}");

        var prompt = @"
you are a comic book writer.  you will be given a question and you will answer it. 
question: who are 10 of the most popular superheros and what are their powers?";

        if (useChatSettings)
        {
            var response = await llm.GenerateAsync(prompt, new BedrockChatSettings { UseStreaming = useStreaming });
            response.LastMessageContent.Should().NotBeNull();
        }
        else
        {
            var response = await llm.GenerateAsync(prompt);
            response.LastMessageContent.Should().NotBeNull();
            Console.WriteLine(response.LastMessageContent);
        }
    }

    [Test]
    public async Task TestEmbedding()
    {
        var provider = new BedrockProvider();
        var embeddings = new EmbedEnglishV3Model(provider);

        var prompt = @"
you are a comic book writer.  you will be given a question and you will answer it. 
question: who are 10 of the most popular superheros and what are their powers?";

        var embedding = await embeddings.CreateEmbeddingsAsync(prompt)
            .ConfigureAwait(false);
    }
}