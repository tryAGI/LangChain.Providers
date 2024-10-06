// See https://aka.ms/new-console-template for more information

using LangChain.Providers;
using LangChain.Providers.Pollinations;


PollinationsConfiguration config = new()
{
    ApiKey = "None"
};
PollinationsProvider provider = new(config);

PollinationsModel  model = new(provider,"mistral");

var response = await model.GenerateAsync("What is your name");

Console.WriteLine($"Response from mistral was : {response.LastMessageContent}\n");
