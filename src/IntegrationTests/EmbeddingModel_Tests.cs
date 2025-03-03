using LangChain.Providers;

namespace LangChain.IntegrationTests;

[TestFixture]
public class EmbeddingModel_Tests
{
    private List<string> Strings = new List<string>
    {
        "The quick brown fox jumps over the lazy dog.",
        "She sells seashells by the seashore.",
        "How much wood would a woodchuck chuck if a woodchuck could chuck wood?",
        "A journey of a thousand miles begins with a single step.",
        "To be or not to be, that is the question.",
        "All that glitters is not gold.",
        "A picture is worth a thousand words.",
        "Actions speak louder than words.",
        "Better late than never.",
        "The early bird catches the worm.",
        "Fortune favors the bold.",
        "Ignorance is bliss.",
        "Look before you leap.",
        "Barking up the wrong tree.",
        "Birds of a feather flock together.",
        "Don't bite the hand that feeds you.",
        "Every cloud has a silver lining.",
        "Haste makes waste.",
        "Strike while the iron is hot.",
        "Time and tide wait for no man.",
        "When in Rome, do as the Romans do.",
        "Where there's smoke, there's fire.",
        "You can't judge a book by its cover.",
        "Practice makes perfect.",
        "Rome wasn't built in a day.",
        "Two heads are better than one.",
        "A rolling stone gathers no moss.",
        "Absence makes the heart grow fonder.",
        "Beauty is in the eye of the beholder.",
        "Cleanliness is next to godliness.",
        "Curiosity killed the cat.",
        "Don't count your chickens before they hatch.",
        "Honesty is the best policy.",
        "Necessity is the mother of invention.",
        "No man is an island.",
        "The pen is mightier than the sword.",
        "The squeaky wheel gets the grease.",
        "There's no place like home.",
        "Too many cooks spoil the broth.",
        "You can't have your cake and eat it too.",
        "A fool and his money are soon parted.",
        "Actions have consequences.",
        "An apple a day keeps the doctor away.",
        "As you sow, so shall you reap.",
        "Don't bite off more than you can chew.",
        "Don't put all your eggs in one basket.",
        "Early to bed and early to rise makes a man healthy, wealthy, and wise.",
        "Give credit where credit is due.",
        "Good things come to those who wait.",
        "If it ain't broke, don't fix it.",
        "If you can't beat 'em, join 'em.",
        "It's always darkest before the dawn.",
        "Keep your friends close and your enemies closer.",
        "Knowledge is power.",
        "Laughter is the best medicine.",
        "Let sleeping dogs lie.",
        "Out of sight, out of mind.",
        "The grass is always greener on the other side of the fence.",
        "The road to hell is paved with good intentions.",
        "Variety is the spice of life.",
        "What goes around comes around.",
        "You reap what you sow.",
        "Every rose has its thorn.",
        "Don't judge a person until you've walked a mile in their shoes.",
        "A watched pot never boils.",
        "Better safe than sorry.",
        "Beggars can't be choosers.",
        "Cut your coat according to your cloth.",
        "Don't make a mountain out of a molehill.",
        "Every dog has its day.",
        "Great minds think alike.",
        "If it sounds too good to be true, it probably is.",
        "Lend your money and lose your friend.",
        "Keep your chin up.",
        "Actions create reactions.",
        "Don't throw the baby out with the bathwater.",
        "A stitch in time saves nine.",
        "Out of the frying pan and into the fire.",
        "The customer is always right.",
        "The proof of the pudding is in the eating.",
        "There's no such thing as a free lunch.",
        "This too shall pass.",
        "To err is human; to forgive, divine.",
        "You can't please everyone.",
        "What doesn't kill you makes you stronger.",
        "Don't cry over spilled milk.",
        "Good fences make good neighbors.",
        "Hope for the best but prepare for the worst.",
        "It's no use crying over spilt milk.",
        "Life is what you make it.",
        "Live and let live.",
        "Never look a gift horse in the mouth.",
        "When the going gets tough, the tough get going.",
        "You can't have it both ways.",
        "You can't make an omelette without breaking eggs.",
        "Necessity knows no law.",
        "Failing to prepare is preparing to fail."
    };
    [Explicit]
    public async Task GoogleEmbeddingTest()
    {
        var (llm, embeddingModel, _) = Helpers.GetModels(ProviderType.Google);

        var embeddings = await embeddingModel.CreateEmbeddingsAsync(new EmbeddingRequest()
        {
            Strings = this.Strings
        });
        embeddings.Values.Should().HaveCountGreaterThan(0);
        embeddings.Values.First().Should().HaveCountGreaterThan(0);
    }

    [TestCase]
    public async Task TogetherEmbeddingTest()
    {
        var (llm, embeddingModel, _) = Helpers.GetModels(ProviderType.Together);

        var embeddings = await embeddingModel.CreateEmbeddingsAsync(new EmbeddingRequest()
        {
            Strings = this.Strings
        });
        embeddings.Values.Should().HaveCountGreaterThan(0);
        embeddings.Values.First().Should().HaveCountGreaterThan(0);
    }

    [TestCase]
    public async Task DeepInfraEmbeddingTest()
    {
        var (llm, embeddingModel, _) = Helpers.GetModels(ProviderType.DeepInfra);

        var embeddings = await embeddingModel.CreateEmbeddingsAsync(new EmbeddingRequest()
        {
            Strings = this.Strings
        });
        embeddings.Values.Should().HaveCountGreaterThan(0);
        embeddings.Values.First().Should().HaveCountGreaterThan(0);
    }
}