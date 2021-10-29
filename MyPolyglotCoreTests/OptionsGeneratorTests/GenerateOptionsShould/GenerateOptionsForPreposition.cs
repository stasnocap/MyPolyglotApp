using MyPolyglotCore.Words;
using Xunit;

namespace MyPolyglotCoreTests.OptionsGeneratorTests.GenerateOptionsShould
{
    public class GenerateOptionsForPreposition : OptionsChecker
    {
        [Fact]
        public void GivenPreposition_ReturnFiveWordsFormPrepositionVocabularyWithRightAnswer()
        {
            var randomPreposition = new Preposition("no matter");
            CheckIfFiveWordsFromVocabularyWithRightWordWasReturned(randomPreposition);
        }
    }
}
