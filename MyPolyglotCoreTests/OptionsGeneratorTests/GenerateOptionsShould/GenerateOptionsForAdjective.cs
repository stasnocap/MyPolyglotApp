using MyPolyglotCore;
using Xunit;

namespace MyPolyglotCoreTests.OptionsGeneratorTests.GenerateOptionsShould
{
    public class GenerateOptionsForAdjective : OptionsChecker
    {
        [Fact]
        public void GivenAdjective_ReturnFiveWordsFromAdjectiveVocabularyWithRightAnswer()
        {
            var randomAdjective = RandomWordHelper.GetRandomAdjective();
            CheckIfFiveWordsFromVocabularyWithRightWordWasReturned(randomAdjective);
        }
    }
}
