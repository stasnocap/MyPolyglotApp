using MyPolyglotCore;
using Xunit;

namespace MyPolyglotCoreTests.OptionsGeneratorTests.GenerateOptionsShould
{
    public class GenerateOptionsForPronoun : OptionsChecker
    {
        [Fact]
        public void GivenSubjectPronoun_ReturnAllWordsFromSubjectPronounVocabulary()
        {
            var subjectPronoun = RandomWordHelper.GetRandomSubjectPronoun();
            CheckIfAllWordsFromVocabularyWasReturned(subjectPronoun, Vocabulary.SubjectPronouns);
        }

        [Fact]
        public void GivenObjectPronoun_ReturnAllWordsFromObjectPronounVocabulary()
        {
            var objectPronoun = RandomWordHelper.GetRandomObjectPronoun();
            CheckIfAllWordsFromVocabularyWasReturned(objectPronoun, Vocabulary.ObjectPronouns);
        }

        [Fact]
        public void GivenPossessiveAdjective_ReturnAllWordsFromPossessiveAdjectiveVocabulary()
        {
            var possessiveAdjective = RandomWordHelper.GetRandomPossessiveAdjective();
            CheckIfAllWordsFromVocabularyWasReturned(possessiveAdjective, Vocabulary.PossessiveAdjectives);
        }

        [Fact]
        public void GivenPossessivePronoun_ReturnAllWordsFromPossessivePronounVocabulary()
        {
            var possessivePronoun = RandomWordHelper.GetRandomPossessivePronoun();
            CheckIfAllWordsFromVocabularyWasReturned(possessivePronoun, Vocabulary.PossessivePronouns);
        }

        [Fact]
        public void GivenReflexivePronoun_ReturnAllWordsFromReflexivePronounVocabulary()
        {
            var reflexivePronoun = RandomWordHelper.GetRandomReflexivePronoun();
            CheckIfAllWordsFromVocabularyWasReturned(reflexivePronoun, Vocabulary.ReflexivePronouns);
        }

        [Fact]
        public void GivenDemonstrativePronoun_ReturnAllWordsFromDemonstrativePronounVocabulary()
        {
            var demonstrativePronoun = RandomWordHelper.GetRandomDemonstrativePronoun();
            CheckIfAllWordsFromVocabularyWasReturned(demonstrativePronoun, Vocabulary.DemonstrativePronouns);
        }
    }
}
