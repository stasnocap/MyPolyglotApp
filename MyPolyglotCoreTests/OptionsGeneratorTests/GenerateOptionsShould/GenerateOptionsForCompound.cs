using MyPolyglotCore;
using Xunit;

namespace MyPolyglotCoreTests.OptionsGeneratorTests.GenerateOptionsShould
{
    public class GenerateOptionsForCompound : OptionsChecker
    {
        [Fact]
        public void GivenSomeCompound_ReturnAllWordsFromSomeCompoundsVocabulary()
        {
            var randomSomeCompound = RandomWordHelper.GetRandomSomeCompound();
            CheckIfAllWordsFromVocabularyWasReturned(randomSomeCompound, Vocabulary.SomeCompounds);
        }

        [Fact]
        public void GivenAnyCompound_ReturnAllWordsFromAnyCompoundsVocabulary()
        {
            var randomAnyCompound = RandomWordHelper.GetRandomAnyCompound();
            CheckIfAllWordsFromVocabularyWasReturned(randomAnyCompound, Vocabulary.AnyCompounds);
        }

        [Fact]
        public void GivenEveryCompound_ReturnAllWordsFromEveryCompoundsVocabulary()
        {
            var randomEveryCompound = RandomWordHelper.GetRandomEveryCompound();
            CheckIfAllWordsFromVocabularyWasReturned(randomEveryCompound, Vocabulary.EveryCompounds);
        }

        [Fact]
        public void GivenNoCompound_ReturnAllWordsFromNoCompoundsVocabulary()
        {
            var randomNoCompound = RandomWordHelper.GetRandomNoCompound();
            CheckIfAllWordsFromVocabularyWasReturned(randomNoCompound, Vocabulary.NoCompounds);
        }
    }
}
