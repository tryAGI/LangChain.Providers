using Amazon;
using Amazon.BedrockAgentRuntime;
using Amazon.BedrockRuntime;

namespace LangChain.Providers.Amazon.Bedrock;

/// <summary>
/// Represents a provider for Amazon Bedrock.
/// </summary>
public class BedrockProvider : Provider
{
    private const string DefaultProviderId = "Bedrock";

    /// <summary>
    /// Initializes a new instance of the <see cref="BedrockProvider"/> class with the default region.
    /// </summary>
    public BedrockProvider() : this(RegionEndpoint.USEast1)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BedrockProvider"/> class with the specified region.
    /// </summary>
    /// <param name="region">The region endpoint for the Amazon Bedrock service.</param>
    [CLSCompliant(false)]
    public BedrockProvider(RegionEndpoint region) : base(DefaultProviderId)
    {
        Api = new AmazonBedrockRuntimeClient(region);
        AgentApi = new AmazonBedrockAgentRuntimeClient(region);
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BedrockProvider"/> class with the specified access key, secret key, and region.
    /// </summary>
    /// <param name="accessKeyId">The access key ID for the Amazon Bedrock service.</param>
    /// <param name="secretAccessKey">The secret access key for the Amazon Bedrock service.</param>
    /// <param name="region">The region endpoint for the Amazon Bedrock service. Defaults to US East 1.</param>
    [CLSCompliant(false)]
    public BedrockProvider(string accessKeyId, string secretAccessKey, RegionEndpoint? region = null)
        : base(DefaultProviderId)
    {
        Api = new AmazonBedrockRuntimeClient(accessKeyId, secretAccessKey, region ?? RegionEndpoint.USEast1);
        AgentApi = new AmazonBedrockAgentRuntimeClient(accessKeyId, secretAccessKey, region ?? RegionEndpoint.USEast1);
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BedrockProvider"/> class with the specified configuration.
    /// </summary>
    /// <param name="runtimeConfig">The configuration for the Amazon Bedrock Runtime service.</param>
    /// <param name="agentRuntimeConfig">The configuration for the Amazon Bedrock Agent Runtime service.</param>
    [CLSCompliant(false)]
    public BedrockProvider(AmazonBedrockRuntimeConfig runtimeConfig, AmazonBedrockAgentRuntimeConfig agentRuntimeConfig)
        : base(DefaultProviderId)
    {
        Api = new AmazonBedrockRuntimeClient(runtimeConfig);
        AgentApi = new AmazonBedrockAgentRuntimeClient(agentRuntimeConfig);
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BedrockProvider"/> class with the given clients.
    /// </summary>
    /// <param name="runtimeClient">The Amazon Bedrock Runtime client.</param>
    /// <param name="agentRuntimeClient">The Amazon Bedrock Agent Runtime client.</param>
    [CLSCompliant(false)]
    public BedrockProvider(AmazonBedrockRuntimeClient runtimeClient, AmazonBedrockAgentRuntimeClient agentRuntimeClient)
        : base(DefaultProviderId)
    {
        Api = runtimeClient;
        AgentApi = agentRuntimeClient;
    }

    #region Properties

    [CLSCompliant(false)]
    public AmazonBedrockRuntimeClient Api { get; }

    [CLSCompliant(false)]
    public AmazonBedrockAgentRuntimeClient AgentApi { get; }

    #endregion
}