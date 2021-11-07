using MyPolyglotCore;
using Xunit;

namespace MyPolyglotCoreTests.OptionsGeneratorTests.GenerateOptionsShould
{
    public class GenerateOptionsForCity : OptionsChecker
    {
        [Fact]
        public void ReturnFiveRandomWordsFromCityVocabulary()
        {
            var randomCity = RandomWordHelper.GetRandomCity();
            CheckIfFiveWordsFromVocabularyWasReturned(randomCity);
        }

        [Fact]
        public void CapitalizeFirstLetter()
        {
            var randomCity = RandomWordHelper.GetRandomCity();
            var options = _optionsGenerator.GetOptions(randomCity);

            foreach (var option in options)
            {
                Assert.True(char.IsUpper(option[0]));
            }
        }

        [Fact]
        public void ReturnRightWord()
        {
            var randomCity = RandomWordHelper.GetRandomCity();
            CheckIfRightWordWasReturned(randomCity);
        }
    }
}
