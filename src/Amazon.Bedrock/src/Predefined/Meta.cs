// ReSharper disable once CheckNamespace
namespace LangChain.Providers.Amazon.Bedrock.Predefined.Meta;


/// <inheritdoc />
public class Llama2With13BModel(BedrockProvider provider)
    : MetaLlamaChatModel(provider, id: "meta.llama2-13b-v1");

/// <inheritdoc />
public class Llama2With70BModel(BedrockProvider provider)
    : MetaLlamaChatModel(provider, id: "meta.llama2-70b-v1");

/// <inheritdoc />
public class Llama2WithChat13BModel(BedrockProvider provider)
    : MetaLlamaChatModel(provider, id: "meta.llama2-13b-chat-v1");

/// <inheritdoc />
public class Llama2WithChat70BModel(BedrockProvider provider)
    : MetaLlamaChatModel(provider, id: "meta.llama2-70b-chat-v1");

/// <inheritdoc />
public class Llama3With8BInstructBModel(BedrockProvider provider)
    : MetaLlamaChatModel(provider, id: "meta.llama3-8b-instruct-v1:0");

/// <inheritdoc />
public class Llama3With70BInstructBModel(BedrockProvider provider)
    : MetaLlamaChatModel(provider, id: "meta.llama3-70b-instruct-v1:0");

/// <inheritdoc />
public class Llama31With70BInstructBModel(BedrockProvider provider)
    : MetaLlamaChatModel(provider, id: "meta.llama3-1-70b-instruct-v1:0");

/// <inheritdoc />
public class Llama31With8BInstructBModel(BedrockProvider provider)
    : MetaLlamaChatModel(provider, id: "meta.llama3-1-8b-instruct-v1:0");

/// <inheritdoc />
public class Llama31With405BInstructBModel(BedrockProvider provider)
    : MetaLlamaChatModel(provider, id: "meta.llama3-1-405b-instruct-v1:0");

/// <inheritdoc />
public class Llama32With1BInstructModel(BedrockProvider provider)
    : MetaLlama32ChatModel(provider, id: "us.meta.llama3-2-1b-instruct-v1:0");

/// <inheritdoc />
public class Llama32With3BInstructModel(BedrockProvider provider)
    : MetaLlama32ChatModel(provider, id: "us.meta.llama3-2-3b-instruct-v1:0");

/// <inheritdoc />
public class Llama32With11BInstructModel(BedrockProvider provider)
    : MetaLlama32ChatModel(provider, id: "us.meta.llama3-2-11b-instruct-v1:0");

/// <inheritdoc />
public class Llama32With90BInstructModel(BedrockProvider provider)
    : MetaLlama32ChatModel(provider, id: "us.meta.llama3-2-90b-instruct-v1:0");