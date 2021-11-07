using MyPolyglotCore;
using MyPolyglotCore.Words;
using Xunit;

namespace MyPolyglotCoreTests.OptionsGeneratorTests.GenerateOptionsShould
{
    public class GenerateOptionsForPreposition : OptionsChecker
    {
        [Fact]
        public void ReturnFiveRandomWordsFormPrepositionVocabulary()
        {
            var randomPreposition = RandomWordHelper.GetRandomPreposition();
            CheckIfFiveWordsFromVocabularyWasReturned(randomPreposition);
        }

        [Fact]
        public void ReturnRightWord()
        {
            var randomPreposition = RandomWordHelper.GetRandomPreposition();
            CheckIfRightWordWasReturned(randomPreposition);
        }
    }
}
