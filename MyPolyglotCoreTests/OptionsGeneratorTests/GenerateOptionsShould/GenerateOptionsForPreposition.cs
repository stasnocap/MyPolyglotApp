using MyPolyglotCore.Words;
using Xunit;

namespace MyPolyglotCoreTests.OptionsGeneratorTests.GenerateOptionsShould
{
    public class GenerateOptionsForPreposition : OptionsChecker
    {
        [Fact]
        public void GivenPreposition_ReturnFiveWordsFormPrepositionVocabularyWithRightAnswer()
        {
            var word = new Preposition("no matter");
            CheckIfFiveWordsFromVocabularyWithRightWordWasReturned(word);
        }
    }
}
