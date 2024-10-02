using LangChain.Chains.LLM;
using LangChain.Prompts;
using LangChain.Providers;
using LangChain.Providers.Ollama;
using LangChain.Schema;

OllamaChatModel model = new OllamaChatModel(new OllamaProvider(), "llama3.1");
PromptTemplate template = new PromptTemplate(new PromptTemplateInput(
    "You are an AI model that creates poems in pirate speak , here is the subject of the poem:<content>{content}</content>",
    ["content"]));
Dictionary<string, object> chainValueDict = new();

ChainValues chainValues = new(chainValueDict);
LlmChain chain = new LlmChain(new LlmChainInput(model, template));

model.UseConsoleForDebug();

Console.WriteLine("type exit to exit");
Console.WriteLine("Enter the subject of the poem:");
        
chainValueDict["content"] = "";

while (chainValueDict["content"].ToString()?.Trim() != "exit")
{
    chainValueDict["content"] = Console.ReadLine() ?? "";
    var response = await chain.CallAsync(chainValues);
    Console.WriteLine(response.Value["text"].ToString());
}