using LangChain.Providers;
using LangChain.Providers.Google;
using LangChain.Providers.Google.Predefined;

namespace LangChain.Provider.Google.Tests
{
    public class Tests
    {
        [Test]
        public async Task Chat()
        {
            var config = new GoogleConfiguration()
            {
                ApiKey = "{api-key}",
            };

            var provider = new GoogleProvider(config, new());
            var model = new Gemini15FlashModel(provider);
            string answer = await model.GenerateAsync("Generate some random name:");

            answer.Should().NotBeNull();
            Console.WriteLine(answer);
        }
    }
}