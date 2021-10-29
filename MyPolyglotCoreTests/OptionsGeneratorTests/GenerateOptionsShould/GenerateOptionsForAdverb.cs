using MyPolyglotCore;
using Xunit;

namespace MyPolyglotCoreTests.OptionsGeneratorTests.GenerateOptionsShould
{
    public class GenerateOptionsForAdverb : OptionsChecker
    {
        [Fact]
        public void GivenFrequencyAdverb_ReturnFiveWordsFromFrequencyAdverbVocabularyWithRightAnswer()
        {
            var randomFrequencyAdverb = RandomWordHelper.GetRandomFrequencyAdverb();
            CheckIfFiveWordsFromVocabularyWithRightWordWasReturned(randomFrequencyAdverb, Vocabulary.FrequencyAdverbs);
        }

        [Fact]
        public void GivenIntensifierAdverb_ReturnFiveWordsFromIntensifierAdverbVocabularyWithRightAnswer()
        {
            var randomIntesifierAdverb = RandomWordHelper.GetRandomIntensifierAdverb();
            CheckIfFiveWordsFromVocabularyWithRightWordWasReturned(randomIntesifierAdverb, Vocabulary.IntensifierAdverbs);
        }

        [Fact]
        public void GivenMannerAdverb_ReturnFiveWordsFromMannerAdverbVocabularyWithRightAnswer()
        {
            var randomMannerAdverb = RandomWordHelper.GetRandomMannerAdverb();
            CheckIfFiveWordsFromVocabularyWithRightWordWasReturned(randomMannerAdverb, Vocabulary.MannerAdverbs);
        }

        [Fact]
        public void GivenTellHowItHappenedAdverb_ReturnFiveWordsFromTellHowItHappendAdverbVocabularyWithRightAnswer()
        {
            var randomTellHowItHappenedAdverb = RandomWordHelper.GetRandomTellHowItHappendAdverb();
            CheckIfFiveWordsFromVocabularyWithRightWordWasReturned(randomTellHowItHappenedAdverb, Vocabulary.TellHowItHappenedAdverbs);
        }

        [Fact]
        public void GivenTellTheExtentOfTheActionAdverb_ReturnFiveWordsFromTellTheExtentOfTheActionAdverbVocabularyWithRightAnswer()
        {
            var randomTellTheExtentOfTheActionAdverb = RandomWordHelper.GetRandomTellTheExtentOfTheActionAdverb();
            CheckIfFiveWordsFromVocabularyWithRightWordWasReturned(randomTellTheExtentOfTheActionAdverb, Vocabulary.TellTheExtentOfTheActionAdverbs);
        }

        [Fact]
        public void GivenTellWhenItHappenedAdverb_ReturnFiveWordsFromTellWhenItHappenedAdverbVocabularyWithRightAnswer()
        {
            var randomTellWhenItHappenedAdverb = RandomWordHelper.GetRandomTellWhenItHappendAdverb();
            CheckIfFiveWordsFromVocabularyWithRightWordWasReturned(randomTellWhenItHappenedAdverb, Vocabulary.TellWhenItHappenedAdverbs);
        }

        [Fact]
        public void GivenTellWhereItHappenedAdverb_ReturnFiveWordsFromTellWhereItHappenedAdverbVocabularyWithRightAnswer()
        {
            var randomTellWhereItHappendAdverb = RandomWordHelper.GetRandomTellWhereItHappendAdverb();
            CheckIfFiveWordsFromVocabularyWithRightWordWasReturned(randomTellWhereItHappendAdverb, Vocabulary.TellWhereItHappenedAdverbs);
        }
    }
}
