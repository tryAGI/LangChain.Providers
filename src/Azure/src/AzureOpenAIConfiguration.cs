using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangChain.Providers.Azure
{
    public class AzureOpenAiConfiguration
    {
        /// <summary>
        /// Context size
        /// How much tokens model will remember.
        /// Most models have 2048
        /// </summary>
        public int ContextSize { get; set; } = 2048;

        /// <summary>
        /// 
        /// </summary>
        public const string SectionName = "AzureOpenAI";

        /// <summary>
        /// 
        /// </summary>
        public string? ApiKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string? Endpoint { get; set; }

        public string? DeploymentID { get; set; }

        public AzureOpenAiChatSettings ChatSettings { get; set; } = new();

        public EmbeddingSettings EmbeddingSettings { get; init; } = new();

        public TextToImageSettings TextToImageSettings { get; init; } = new();

        public ModerationSettings ModerationSettings { get; init; } = new();

        public SpeechToTextSettings SpeechToTextSettings { get; init; } = new();

        public TextToSpeechSettings TextToSpeechSettings { get; init; } = new();

        public ImageToTextSettings ImageToTextSettings { get; init; } = new();
    }
}
