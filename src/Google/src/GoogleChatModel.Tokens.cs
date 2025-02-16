using GenerativeAI.Types;

namespace LangChain.Providers.Google
{
    public partial class GoogleChatModel
    {
        public async Task<int> CountTokens(string text)
        {
            return await CountTokens(new Message[] { new Message(text, MessageRole.Human) }).ConfigureAwait(false);
        }

        public async Task<int> CountTokens(IEnumerable<Message> messages)
        {
            var response = await this.Api.CountTokensAsync(new CountTokensRequest() { Contents = messages.Select(ToRequestMessage).ToList() }).ConfigureAwait(false);

            return response.TotalTokens;
        }
    }
}
