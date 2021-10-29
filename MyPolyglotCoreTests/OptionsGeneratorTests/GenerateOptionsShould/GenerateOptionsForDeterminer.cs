using MyPolyglotCore;
using Xunit;

namespace MyPolyglotCoreTests.OptionsGeneratorTests.GenerateOptionsShould
{
    public class GenerateOptionsForDeterminer : OptionsChecker
    {
        [Fact]
        public void GivenDeterminer_ReturnAllWordsFromDeterminerVocabulary()
        {
            var randomDeterminer = RandomWordHelper.GetRandomDeterminer();
            CheckIfAllWordsFromVocabularyWasReturned(randomDeterminer);
        }
    }
}
