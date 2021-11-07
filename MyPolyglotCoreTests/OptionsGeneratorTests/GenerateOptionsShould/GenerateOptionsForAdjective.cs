using MyPolyglotCore;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace MyPolyglotCoreTests.OptionsGeneratorTests.GenerateOptionsShould
{
    public class GenerateOptionsForAdjective : OptionsChecker
    {
        [Fact]
        public void ReturnFiveRandomWordsFromAdjectiveVocabulary()
        {
            var randomAdjective = RandomWordHelper.GetRandomAdjective();
            CheckIfFiveWordsFromVocabularyWasReturned(randomAdjective);
        }

        [Fact]
        public void ReturnRightWord()
        {
            var randomAdjective = RandomWordHelper.GetRandomAdjective();
            CheckIfRightWordWasReturned(randomAdjective);
        }
    }
}
