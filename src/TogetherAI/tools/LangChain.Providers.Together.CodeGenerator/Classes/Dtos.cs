namespace LangChain.Providers.Together.CodeGenerator.Classes;

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

public class ModelData
{
    [JsonPropertyName("modelInstanceConfig")]
    public ModelInstanceConfig? ModelInstanceConfig { get; set; }

    [JsonPropertyName("_id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }

    [JsonPropertyName("display_name")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("display_type")]
    public string? DisplayType { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("license")]
    public string? License { get; set; }

    [JsonPropertyName("link")]
    public string? Link { get; set; }

    [JsonPropertyName("creator_organization")]
    public string? CreatorOrganization { get; set; }

    [JsonPropertyName("pricing_tier")]
    public string? PricingTier { get; set; }

    [JsonPropertyName("access")]
    public string? Access { get; set; }

    [JsonPropertyName("num_parameters")]
    public long? NumParameters { get; set; }

    [JsonPropertyName("show_in_playground")]
    public bool? ShowInPlayground { get; set; }

    [JsonPropertyName("isFeaturedModel")]
    public bool? IsFeaturedModel { get; set; }

    [JsonPropertyName("pricing")]
    public Pricing? Pricing { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    [JsonPropertyName("update_at")]
    public DateTime? UpdateAt { get; set; }

    [JsonPropertyName("instances")]
    public List<Instance>? Instances { get; set; }

    [JsonPropertyName("lago_tag")]
    public string? LagoTag { get; set; }

    [JsonPropertyName("depth")]
    public Depth? Depth { get; set; }

    // Additional properties for specific models (Gemma, Meta Llama, etc.)
    [JsonPropertyName("finetuning_supported")]
    public bool? FinetuningSupported { get; set; }

    [JsonPropertyName("context_length")]
    public int? ContextLength { get; set; }

    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    [JsonPropertyName("base")]
    public string? Base { get; set; }

    [JsonPropertyName("config")]
    public Config? Config { get; set; }

    [JsonPropertyName("slo")]
    public Slo? Slo { get; set; }

    [JsonPropertyName("has_wandb_telemetry")]
    public bool? HasWandbTelemetry { get; set; }

    [JsonPropertyName("isPrivate")]
    public bool? IsPrivate { get; set; }

    [JsonPropertyName("access_control")]
    public List<AccessControl>? AccessControl { get; set; }

    [JsonPropertyName("isDedicatedInstance")]
    public bool? IsDedicatedInstance { get; set; }

    [JsonPropertyName("isByom")]
    public bool? IsByom { get; set; }

    [JsonPropertyName("isSelfServeDedicatedInstance")]
    public bool? IsSelfServeDedicatedInstance { get; set; }

    [JsonPropertyName("isFinetuned")]
    public bool? IsFinetuned { get; set; }

    [JsonPropertyName("fairness")]
    public Fairness? Fairness { get; set; }

    [JsonPropertyName("regulator")]
    public Regulator? Regulator { get; set; }

    [JsonPropertyName("proxy")]
    public Proxy? Proxy { get; set; }

    [JsonPropertyName("isServerlessPreview")]
    public bool? IsServerlessPreview { get; set; }

    [JsonPropertyName("lora_config")]
    public LoraConfig? LoraConfig { get; set; }

    [JsonPropertyName("image_config")]
    public ImageConfig? ImageConfig { get; set; }

    [JsonPropertyName("isDeleted")]
    public bool? IsDeleted { get; set; }

    [JsonPropertyName("maxQpsAuthenticated")]
    public double? MaxQpsAuthenticated { get; set; }

    [JsonPropertyName("maxQpsUnauthenticated")]
    public double? MaxQpsUnauthenticated { get; set; }

    [JsonPropertyName("maxQpsUserOverrides")]
    public List<MaxQpsUserOverride>? MaxQpsUserOverrides { get; set; }

    [JsonPropertyName("tierOverride")]
    public List<object>? TierOverride { get; set; }

    [JsonPropertyName("audio_config")]
    public AudioConfig? AudioConfig { get; set; }

    [JsonPropertyName("external_instances")]
    public ExternalInstances? ExternalInstances { get; set; }

    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    [JsonPropertyName("owner_address")]
    public string? OwnerAddress { get; set; }

    [JsonPropertyName("owner_userid")]
    public string? OwnerUserid { get; set; }

    [JsonPropertyName("descriptionLink")]
    public string? DescriptionLink { get; set; }

    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    [JsonPropertyName("external_pricing_url")]
    public string? ExternalPricingUrl { get; set; }

    [JsonPropertyName("release_date")]
    public DateTime? ReleaseDate { get; set; }

    [JsonPropertyName("isTestingModel")]
    public bool? IsTestingModel { get; set; }

    [JsonPropertyName("autopilot_pool")]
    public string? AutopilotPool { get; set; }
}

public class ModelInstanceConfig
{
    [JsonPropertyName("appearsIn")]
    public List<object>? AppearsIn { get; set; }

    [JsonPropertyName("order")]
    public int? Order { get; set; }
}

public class Pricing
{
    [JsonPropertyName("hourly")]
    public int? Hourly { get; set; }

    [JsonPropertyName("input")]
    public double? Input { get; set; }

    [JsonPropertyName("output")]
    public double? Output { get; set; }

    [JsonPropertyName("finetune")]
    public int? Finetune { get; set; }

    [JsonPropertyName("base")]
    public int? Base { get; set; }

    [JsonPropertyName("pixelPricing")]
    public PixelPricing? PixelPricing { get; set; }

    [JsonPropertyName("reserved")]
    public Reserved? Reserved { get; set; }
}

public class PixelPricing
{
    [JsonPropertyName("pricePerPixelDollar")]
    public double? PricePerPixelDollar { get; set; }

    [JsonPropertyName("defaultMinSteps")]
    public int? DefaultMinSteps { get; set; }
}

public class Reserved
{
    [JsonPropertyName("pricePerHourDollar")]
    public double? PricePerHourDollar { get; set; }

    [JsonPropertyName("autoscalePricePerHourDollar")]
    public double? AutoscalePricePerHourDollar { get; set; }

    [JsonPropertyName("startDateUTC")]
    public DateTime? StartDateUTC { get; set; }

    [JsonPropertyName("endDateUTC")]
    public DateTime? EndDateUTC { get; set; }

    [JsonPropertyName("minReplicas")]
    public object? MinReplicas { get; set; }

    [JsonPropertyName("maxReplicas")]
    public object? MaxReplicas { get; set; }

    [JsonPropertyName("auditLogs")]
    public List<AuditLog>? AuditLogs { get; set; }
}

public class AuditLog
{
    [JsonPropertyName("timestamp")]
    public DateTime? Timestamp { get; set; }

    [JsonPropertyName("user")]
    public string? User { get; set; }

    [JsonPropertyName("updates")]
    public Updates? Updates { get; set; }
}

public class Updates
{
    [JsonPropertyName("dollarPrice")]
    public string? DollarPrice { get; set; }

    [JsonPropertyName("autoscalePricePerHourDollar")]
    public string? AutoscalePricePerHourDollar { get; set; }
}

public class Instance
{
    [JsonPropertyName("avzone")]
    public string? Avzone { get; set; }

    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    [JsonPropertyName("config")]
    public InstanceConfig? Config { get; set; }
}

public class InstanceConfig
{
    [JsonPropertyName("routing")]
    public string? Routing { get; set; }
}

public class Depth
{
    [JsonPropertyName("num_asks")]
    public int? NumAsks { get; set; }

    [JsonPropertyName("num_bids")]
    public int? NumBids { get; set; }

    [JsonPropertyName("num_running")]
    public int? NumRunning { get; set; }

    [JsonPropertyName("qps")]
    public double? Qps { get; set; }

    [JsonPropertyName("throughput_in")]
    public double? ThroughputIn { get; set; }

    [JsonPropertyName("throughput_out")]
    public double? ThroughputOut { get; set; }

    [JsonPropertyName("stats")]
    public List<Stat>? Stats { get; set; }

    [JsonPropertyName("error_rate")]
    public double? ErrorRate { get; set; }

    [JsonPropertyName("retry_rate")]
    public double? RetryRate { get; set; }
}

public class Stat
{
    [JsonPropertyName("avzone")]
    public string? Avzone { get; set; }

    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    [JsonPropertyName("qps")]
    public double? Qps { get; set; }

    [JsonPropertyName("throughput_in")]
    public double? ThroughputIn { get; set; }

    [JsonPropertyName("throughput_out")]
    public double? ThroughputOut { get; set; }

    [JsonPropertyName("error_rate")]
    public double? ErrorRate { get; set; }

    [JsonPropertyName("retry_rate")]
    public double? RetryRate { get; set; }
}

public class Config
{
    [JsonPropertyName("stop")]
    public List<string>? Stop { get; set; }

    [JsonPropertyName("add_generation_prompt")]
    public bool? AddGenerationPrompt { get; set; }

    [JsonPropertyName("max_tokens")]
    public int? MaxTokens { get; set; }

    [JsonPropertyName("chat_template")]
    public string? ChatTemplate { get; set; }

    [JsonPropertyName("bos_token")]
    public string? BosToken { get; set; }

    [JsonPropertyName("eos_token")]
    public string? EosToken { get; set; }

    [JsonPropertyName("routing")]
    public string? Routing { get; set; }

    [JsonPropertyName("prompt_format")]
    public string? PromptFormat { get; set; }

    [JsonPropertyName("chat_template_name")]
    public string? ChatTemplateName { get; set; }

    [JsonPropertyName("force_template")]
    public bool? ForceTemplate { get; set; }

    [JsonPropertyName("tool_type")]
    public string? ToolType { get; set; }

    [JsonPropertyName("constraintVariants")]
    public List<ConstraintVariant>? ConstraintVariants { get; set; }

    [JsonPropertyName("contextLengthVariants")]
    public List<ContextLengthVariant>? ContextLengthVariants { get; set; }

    [JsonPropertyName("reroute")]
    public Reroute? Reroute { get; set; }

    [JsonPropertyName("tokenCapacity")]
    public int? TokenCapacity { get; set; }

    [JsonPropertyName("max_tokens_hard_limit_streaming")]
    public int? MaxTokensHardLimitStreaming { get; set; }

    [JsonPropertyName("max_tokens_hard_limit_non_streaming")]
    public int? MaxTokensHardLimitNonStreaming { get; set; }

    [JsonPropertyName("height")]
    public int? Height { get; set; }

    [JsonPropertyName("width")]
    public int? Width { get; set; }

    [JsonPropertyName("number_of_images")]
    public int? NumberOfImages { get; set; }

    [JsonPropertyName("steps")]
    public int? Steps { get; set; }

    [JsonPropertyName("seed")]
    public int? Seed { get; set; }

    [JsonPropertyName("response_format")]
    public string? ResponseFormat { get; set; }

    [JsonPropertyName("optimized")]
    public Optimized? Optimized { get; set; }

    [JsonPropertyName("track_qps")]
    public bool? TrackQps { get; set; }

    [JsonPropertyName("max_n")]
    public int? MaxN { get; set; }

    [JsonPropertyName("safety_label")]
    public string? SafetyLabel { get; set; }

    [JsonPropertyName("safe_response")]
    public bool? SafeResponse { get; set; }

    [JsonPropertyName("safety_config")]
    public SafetyConfig? SafetyConfig { get; set; }

    [JsonPropertyName("safety_categories")]
    public Dictionary<string, string>? SafetyCategories { get; set; }

    [JsonPropertyName("session_cache")]
    public bool? SessionCache { get; set; }
}

public class ConstraintVariant
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("model_name")]
    public string? ModelName { get; set; }
}

public class ContextLengthVariant
{
    [JsonPropertyName("min_context")]
    public int? MinContext { get; set; }

    [JsonPropertyName("model_name")]
    public string? ModelName { get; set; }
}

public class Reroute
{
    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }

    [JsonPropertyName("rules")]
    public List<Rule>? Rules { get; set; }
}

public class Rule
{
    [JsonPropertyName("match")]
    public string? Match { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

public class Optimized
{
    [JsonPropertyName("512x512")]
    public string? _512x512 { get; set; }

    [JsonPropertyName("1024x1024")]
    public string? _1024x1024 { get; set; }

    [JsonPropertyName("1024x576")]
    public string? _1024x576 { get; set; }

    [JsonPropertyName("576x1024")]
    public string? _576x1024 { get; set; }

    [JsonPropertyName("1024x768")]
    public string? _1024x768 { get; set; }

    [JsonPropertyName("768x1024")]
    public string? _768x1024 { get; set; }

    [JsonPropertyName("1792x1024")]
    public string? _1792x1024 { get; set; }

    [JsonPropertyName("1024x1792")]
    public string? _1024x1792 { get; set; }

    [JsonPropertyName("1792x1792")]
    public string? _1792x1792 { get; set; }
}

public class SafetyConfig
{
    [JsonPropertyName("max_tokens")]
    public int? MaxTokens { get; set; }
}

public class Slo
{
    [JsonPropertyName("ttft")]
    public int? Ttft { get; set; }

    [JsonPropertyName("decoding_speed_tps")]
    public int? DecodingSpeedTps { get; set; }

    [JsonPropertyName("total_capacity_tps")]
    public int? TotalCapacityTps { get; set; }
}

public class AccessControl
{
    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }

    [JsonPropertyName("role")]
    public string? Role { get; set; }
}

public class Fairness
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("enforced")]
    public bool? Enforced { get; set; }

    [JsonPropertyName("utilization_threshold")]
    public double? UtilizationThreshold { get; set; }

    [JsonPropertyName("epoch")]
    public string? Epoch { get; set; }
}

public class Regulator
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("max_concurrency")]
    public int? MaxConcurrency { get; set; }

    [JsonPropertyName("rejection_threshold_for_model")]
    public int? RejectionThresholdForModel { get; set; }

    [JsonPropertyName("rejection_threshold_for_model_user")]
    public int? RejectionThresholdForModelUser { get; set; }

    [JsonPropertyName("in_queue_ttl")]
    public int? InQueueTtl { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public class Proxy
{
    [JsonPropertyName("circuit_breaker_mode_enabled")]
    public bool? CircuitBreakerModeEnabled { get; set; }

    [JsonPropertyName("max_retries")]
    public int? MaxRetries { get; set; }
}

public class LoraConfig
{
    [JsonPropertyName("lora_support")]
    public bool? LoraSupport { get; set; }

    [JsonPropertyName("max_lora")]
    public int? MaxLora { get; set; }
}

public class ImageConfig
{
}

public class MaxQpsUserOverride
{
    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }

    [JsonPropertyName("max_qps")]
    public int? MaxQps { get; set; }
}

public class AudioConfig
{
    [JsonPropertyName("voices")]
    public Dictionary<string, string>? Voices { get; set; }

    [JsonPropertyName("default_voice")]
    public string? DefaultVoice { get; set; }
}

public class ExternalInstances
{
    [JsonPropertyName("bfl")]
    public Bfl? Bfl { get; set; }
}

public class Bfl
{
    [JsonPropertyName("model_name")]
    public string? ModelName { get; set; }
}