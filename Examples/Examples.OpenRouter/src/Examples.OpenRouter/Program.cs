// See https://aka.ms/new-console-template for more information

using LangChain.Providers.OpenRouter;

OpenRouterConfiguration configuration = new();
string apiKey = Environment.GetEnvironmentVariable("OPENROUTER_APIKEY")?? throw new ArgumentNullException("no ApiKey is present");
OpenRouterProvider provider = new(apiKey);
OpenRouterModel model = new OpenRouterModel(provider,OpenRouterModelIds.Phi3MediumInstructFree);


Console.WriteLine("Phi:");
await foreach (var response in model.GenerateAsync("What is the meaning of life"))
{
    Console.Write(response);
}