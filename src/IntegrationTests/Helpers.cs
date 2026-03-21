using LangChain.Providers;
using LangChain.Providers.Azure;

namespace LangChain.IntegrationTests;

public static class Helpers
{
    public static (IChatModel ChatModel, IEmbeddingModel EmbeddingModel, IProvider Provider) GetModels(ProviderType providerType)
    {
        switch (providerType)
        {
            // case ProviderType.Azure:
            //     {
            //         var apiKey =
            //             Environment.GetEnvironmentVariable("AZURE_OPENAI_API_KEY") ??
            //             throw new InconclusiveException("AZURE_OPENAI_API_KEY is not set");
            //         var apiEndpoint =
            //             Environment.GetEnvironmentVariable("AZURE_OPENAI_API_ENDPOINT") ??
            //             throw new InconclusiveException("AZURE_OPENAI_API_ENDPOINT is not set");
            //         var deploymentName =
            //             Environment.GetEnvironmentVariable("AZURE_OPENAI_DEPLOYMENT_NAME") ??
            //             throw new InconclusiveException("AZURE_OPENAI_DEPLOYMENT_NAME is not set");
            //
            //         var configuration = new AzureOpenAiConfiguration
            //         {
            //             Id = deploymentName,
            //             ApiKey = apiKey,
            //             Endpoint = apiEndpoint,
            //         };
            //         var provider = new AzureOpenAiProvider(configuration);
            //         var llm = new AzureOpenAiChatModel(provider, deploymentName);
            //
            //         var embeddings = new AzureOpenAiEmbeddingModel(provider, deploymentName);
            //
            //         return (llm, embeddings, provider);
            //     }

            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
