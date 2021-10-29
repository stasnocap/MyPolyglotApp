using MyPolyglotCore;
using Xunit;

namespace MyPolyglotCoreTests.OptionsGeneratorTests.GenerateOptionsShould
{
    public class GenerateOptionsForAdverb : OptionsChecker
    {
        [Fact]
        public void GivenFrequencyAdverb_ReturnFiveWordsFromFrequencyAdverbVocabularyWithRightAnswer()
        {
            var frequencyAdverb = RandomWordHelper.GetRandomFrequencyAdverb();
            CheckIfFiveWordsFromVocabularyWithRightWordWasReturned(frequencyAdverb, Vocabulary.FrequencyAdverbs);
        }

        [Fact]
        public void GivenIntensifierAdverb_ReturnFiveWordsFromIntensifierAdverbVocabularyWithRightAnswer()
        {
            var intesifierAdverb = RandomWordHelper.GetRandomIntensifierAdverb();
            CheckIfFiveWordsFromVocabularyWithRightWordWasReturned(intesifierAdverb, Vocabulary.IntensifierAdverbs);
        }

        [Fact]
        public void GivenMannerAdverb_ReturnFiveWordsFromMannerAdverbVocabularyWithRightAnswer()
        {
            var mannerAdverb = RandomWordHelper.GetRandomMannerAdverb();
            CheckIfFiveWordsFromVocabularyWithRightWordWasReturned(mannerAdverb, Vocabulary.MannerAdverbs);
        }

        [Fact]
        public void GivenTellHowItHappenedAdverb_ReturnFiveWordsFromTellHowItHappendAdverbVocabularyWithRightAnswer()
        {
            var tellHowItHappenedAdverb = RandomWordHelper.GetRandomTellHowItHappendAdverb();
            CheckIfFiveWordsFromVocabularyWithRightWordWasReturned(tellHowItHappenedAdverb, Vocabulary.TellHowItHappenedAdverbs);
        }

        [Fact]
        public void GivenTellTheExtentOfTheActionAdverb_ReturnFiveWordsFromTellTheExtentOfTheActionAdverbVocabularyWithRightAnswer()
        {
            var tellTheExtentOfTheActionAdverb = RandomWordHelper.GetRandomTellTheExtentOfTheActionAdverb();
            CheckIfFiveWordsFromVocabularyWithRightWordWasReturned(tellTheExtentOfTheActionAdverb, Vocabulary.TellTheExtentOfTheActionAdverbs);
        }

        [Fact]
        public void GivenTellWhenItHappenedAdverb_ReturnFiveWordsFromTellWhenItHappenedAdverbVocabularyWithRightAnswer()
        {
            var tellWhenItHappenedAdverb = RandomWordHelper.GetRandomTellWhenItHappendAdverb();
            CheckIfFiveWordsFromVocabularyWithRightWordWasReturned(tellWhenItHappenedAdverb, Vocabulary.TellWhenItHappenedAdverbs);
        }

        [Fact]
        public void GivenTellWhereItHappenedAdverb_ReturnFiveWordsFromTellWhereItHappenedAdverbVocabularyWithRightAnswer()
        {
            var tellWhereItHappendAdverb = RandomWordHelper.GetRandomTellWhereItHappendAdverb();
            CheckIfFiveWordsFromVocabularyWithRightWordWasReturned(tellWhereItHappendAdverb, Vocabulary.TellWhereItHappenedAdverbs);
        }
    }
}
