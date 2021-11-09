using MyPolyglotCore;
using Xunit;

namespace MyPolyglotCoreTests.OptionsGeneratorTests.GenerateOptionsShould
{
    public class GenerateOptionsForLanguage : OptionsChecker
    {
        [Fact]
        public void ReturnFiveRandomWordsFromCityVocabulary()
        {
            var randomCity = RandomWordHelper.GetRandomCity();
            CheckIfFiveWordsFromVocabularyWasReturned(randomCity);
        }

        [Fact]
        public void ReturnRightWord()
        {
            var randomCity = RandomWordHelper.GetRandomCity();
            CheckIfRightWordWasReturned(randomCity);
        }
    }
}
