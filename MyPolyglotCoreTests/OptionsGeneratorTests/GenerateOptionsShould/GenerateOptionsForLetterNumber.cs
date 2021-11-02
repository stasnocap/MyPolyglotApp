using MyPolyglotCore;
using Xunit;

namespace MyPolyglotCoreTests.OptionsGeneratorTests.GenerateOptionsShould
{
    public class GenerateOptionsForLetterNumber : OptionsChecker
    {
        [Fact]
        public void GivenLetterNumber_ReturnFiveWordsFormPrepositionVocabularyWithRightAnswer()
        {
            var randomLetterNumber = RandomWordHelper.GetRandomLetterNumber();
            CheckIfFiveWordsFromVocabularyWithRightWordWasReturned(randomLetterNumber);
        }
    }
}
