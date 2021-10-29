using MyPolyglotCore;
using Xunit;

namespace MyPolyglotCoreTests.OptionsGeneratorTests.GenerateOptionsShould
{
    public class GenerateOptionsForPronoun : OptionsChecker
    {
        [Fact]
        public void GivenSubjectPronoun_ReturnAllWordsFromSubjectPronounVocabulary()
        {
            var randomSubjectPronoun = RandomWordHelper.GetRandomSubjectPronoun();
            CheckIfAllWordsFromVocabularyWasReturned(randomSubjectPronoun, Vocabulary.SubjectPronouns);
        }

        [Fact]
        public void GivenObjectPronoun_ReturnAllWordsFromObjectPronounVocabulary()
        {
            var randomObjectPronoun = RandomWordHelper.GetRandomObjectPronoun();
            CheckIfAllWordsFromVocabularyWasReturned(randomObjectPronoun, Vocabulary.ObjectPronouns);
        }

        [Fact]
        public void GivenPossessiveAdjective_ReturnAllWordsFromPossessiveAdjectiveVocabulary()
        {
            var randomPossessiveAdjective = RandomWordHelper.GetRandomPossessiveAdjective();
            CheckIfAllWordsFromVocabularyWasReturned(randomPossessiveAdjective, Vocabulary.PossessiveAdjectives);
        }

        [Fact]
        public void GivenPossessivePronoun_ReturnAllWordsFromPossessivePronounVocabulary()
        {
            var randomPossessivePronoun = RandomWordHelper.GetRandomPossessivePronoun();
            CheckIfAllWordsFromVocabularyWasReturned(randomPossessivePronoun, Vocabulary.PossessivePronouns);
        }

        [Fact]
        public void GivenReflexivePronoun_ReturnAllWordsFromReflexivePronounVocabulary()
        {
            var randomReflexivePronoun = RandomWordHelper.GetRandomReflexivePronoun();
            CheckIfAllWordsFromVocabularyWasReturned(randomReflexivePronoun, Vocabulary.ReflexivePronouns);
        }

        [Fact]
        public void GivenDemonstrativePronoun_ReturnAllWordsFromDemonstrativePronounVocabulary()
        {
            var randomDemonstrativePronoun = RandomWordHelper.GetRandomDemonstrativePronoun();
            CheckIfAllWordsFromVocabularyWasReturned(randomDemonstrativePronoun, Vocabulary.DemonstrativePronouns);
        }
    }
}
