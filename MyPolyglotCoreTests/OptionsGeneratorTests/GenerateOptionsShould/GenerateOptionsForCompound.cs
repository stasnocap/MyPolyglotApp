using MyPolyglotCore;
using Xunit;

namespace MyPolyglotCoreTests.OptionsGeneratorTests.GenerateOptionsShould
{
    public class GenerateOptionsForCompound : OptionsChecker
    {
        [Fact]
        public void GivenSomeCompound_ReturnAllWordsFromSomeCompoundsVocabulary()
        {
            CheckIfAllWordsFromVocabularyWasReturned(RandomWordHelper.GetRandomSomeCompound(), Vocabulary.SomeCompounds);
        }

        [Fact]
        public void GivenAnyCompound_ReturnAllWordsFromAnyCompoundsVocabulary()
        {
            CheckIfAllWordsFromVocabularyWasReturned(RandomWordHelper.GetRandomAnyCompound(), Vocabulary.AnyCompounds);
        }

        [Fact]
        public void GivenEveryCompound_ReturnAllWordsFromEveryCompoundsVocabulary()
        {
            CheckIfAllWordsFromVocabularyWasReturned(RandomWordHelper.GetRandomEveryCompound(), Vocabulary.EveryCompounds);
        }

        [Fact]
        public void GivenNoCompound_ReturnAllWordsFromNoCompoundsVocabulary()
        {
            CheckIfAllWordsFromVocabularyWasReturned(RandomWordHelper.GetRandomNoCompound(), Vocabulary.NoCompounds);
        }
    }
}
