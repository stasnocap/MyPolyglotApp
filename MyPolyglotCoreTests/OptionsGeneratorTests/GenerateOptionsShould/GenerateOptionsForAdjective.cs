using MyPolyglotCore.Words;
using Xunit;

namespace MyPolyglotCoreTests.OptionsGeneratorTests.GenerateOptionsShould
{
    public class GenerateOptionsForAdjective : OptionsChecker
    {
        [Fact]
        public void GivenAdjective_ReturnFiveWordsFromAdjectiveVocabularyWithRightAnswer()
        {
            var word = new Adjective("no matter");
            CheckIfFiveWordsFromVocabularyWithRightWordWasReturned(word);
        }
    }
}
