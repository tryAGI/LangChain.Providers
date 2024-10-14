// See https://aka.ms/new-console-template for more information

using LangChain.Providers;
using LangChain.Providers.Pollinations;


PollinationsConfiguration config = new()
{
    ApiKey = "None"
};
PollinationsProvider provider = new(config);

PollinationsModel model = new(provider, "mistral");

Console.WriteLine("Mistral:");

await foreach (var response in model.GenerateAsync("What is the meaning of life"))
{
    Console.Write(response);
}