using MyPolyglotCore;
using Xunit;

namespace MyPolyglotCoreTests.OptionsGeneratorTests.GenerateOptionsShould
{
    public class GenerateOptionsForAdverb : OptionsChecker
    {
        [Fact]
        public void GivenFrequencyAdverb_ReturnFiveRandomWordsFromFrequencyAdverbVocabulary()
        {
            var randomFrequencyAdverb = RandomWordHelper.GetRandomFrequencyAdverb();
            CheckIfFiveWordsFromVocabularyWasReturned(randomFrequencyAdverb, Vocabulary.FrequencyAdverbs);
        }

        [Fact]
        public void GivenFrequencyAdverb_ReturnRightWord()
        {
            var randomFrequencyAdverb = RandomWordHelper.GetRandomFrequencyAdverb();
            CheckIfRightWordWasReturned(randomFrequencyAdverb);
        }

        [Fact]
        public void GivenIntensifierAdverb_ReturnFiveRandomWordsFromIntensifierAdverbVocabulary()
        {
            var randomIntesifierAdverb = RandomWordHelper.GetRandomIntensifierAdverb();
            CheckIfFiveWordsFromVocabularyWasReturned(randomIntesifierAdverb, Vocabulary.IntensifierAdverbs);
        }

        [Fact]
        public void GivenIntensifierAdverb_ReturnRightWord()
        {
            var randomIntesifierAdverb = RandomWordHelper.GetRandomIntensifierAdverb();
            CheckIfRightWordWasReturned(randomIntesifierAdverb);
        }

        [Fact]
        public void GivenMannerAdverb_ReturnFiveRandomWordsFromMannerAdverbVocabulary()
        {
            var randomMannerAdverb = RandomWordHelper.GetRandomMannerAdverb();
            CheckIfFiveWordsFromVocabularyWasReturned(randomMannerAdverb, Vocabulary.MannerAdverbs);
        }

        [Fact]
        public void GivenMannerAdverb_ReturnRightWord()
        {
            var randomMannerAdverb = RandomWordHelper.GetRandomMannerAdverb();
            CheckIfRightWordWasReturned(randomMannerAdverb);
        }

        [Fact]
        public void GivenTellHowItHappenedAdverb_ReturnFiveRandomWordsFromTellHowItHappendAdverbVocabulary()
        {
            var randomTellHowItHappenedAdverb = RandomWordHelper.GetRandomTellHowItHappendAdverb();
            CheckIfFiveWordsFromVocabularyWasReturned(randomTellHowItHappenedAdverb, Vocabulary.TellHowItHappenedAdverbs);
        }

        [Fact]
        public void GivenTellHowItHappenedAdverb_ReturnRightWord()
        {
            var randomTellHowItHappenedAdverb = RandomWordHelper.GetRandomTellHowItHappendAdverb();
            CheckIfRightWordWasReturned(randomTellHowItHappenedAdverb);
        }

        [Fact]
        public void GivenTellTheExtentOfTheActionAdverb_ReturnFiveRandomWordsFromTellTheExtentOfTheActionAdverbVocabulary()
        {
            var randomTellTheExtentOfTheActionAdverb = RandomWordHelper.GetRandomTellTheExtentOfTheActionAdverb();
            CheckIfFiveWordsFromVocabularyWasReturned(randomTellTheExtentOfTheActionAdverb, Vocabulary.TellTheExtentOfTheActionAdverbs);
        }

        [Fact]
        public void GivenTellTheExtentOfTheActionAdverb_ReturnRightWord()
        {
            var randomTellTheExtentOfTheActionAdverb = RandomWordHelper.GetRandomTellTheExtentOfTheActionAdverb();
            CheckIfRightWordWasReturned(randomTellTheExtentOfTheActionAdverb);
        }

        [Fact]
        public void GivenTellWhenItHappenedAdverb_ReturnFiveRandomWordsFromTellWhenItHappenedAdverbVocabulary()
        {
            var randomTellWhenItHappenedAdverb = RandomWordHelper.GetRandomTellWhenItHappendAdverb();
            CheckIfFiveWordsFromVocabularyWasReturned(randomTellWhenItHappenedAdverb, Vocabulary.TellWhenItHappenedAdverbs);
        }

        [Fact]
        public void GivenTellWhenItHappenedAdverb_ReturnRightWord()
        {
            var randomTellWhenItHappenedAdverb = RandomWordHelper.GetRandomTellWhenItHappendAdverb();
            CheckIfRightWordWasReturned(randomTellWhenItHappenedAdverb);
        }

        [Fact]
        public void GivenTellWhereItHappenedAdverb_ReturnFiveRandomWordsFromTellWhereItHappenedAdverbVocabulary()
        {
            var randomTellWhereItHappendAdverb = RandomWordHelper.GetRandomTellWhereItHappendAdverb();
            CheckIfFiveWordsFromVocabularyWasReturned(randomTellWhereItHappendAdverb, Vocabulary.TellWhereItHappenedAdverbs);
        }

        [Fact]
        public void GivenTellWhereItHappenedAdverb_ReturnRightWord()
        {
            var randomTellWhereItHappendAdverb = RandomWordHelper.GetRandomTellWhereItHappendAdverb();
            CheckIfRightWordWasReturned(randomTellWhereItHappendAdverb);
        }
    }
}
