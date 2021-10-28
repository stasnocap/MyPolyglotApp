using MyPolyglotCore;
using MyPolyglotCore.Words;
using Xunit;

namespace MyPolyglotCoreTests.RecognizerTests.RecognizeShould
{
    public class RecognizeAdverb : RecognizingChecker
    {
        [Fact]
        public void RecognizeFrequencyAdverbByText()
        {
            var randomWordFromVocabulary = RandomWordHelper.GetRandomFrequencyAdverb();
            CheckIfWordWasRecognizedByText(randomWordFromVocabulary);
        }

        [Fact]
        public void RecognizeIntensifierAdverbByText()
        {
            var randomWordFromVocabulary = RandomWordHelper.GetRandomIntensifierAdverb();
            CheckIfWordWasRecognizedByText(randomWordFromVocabulary);
        }

        [Fact]
        public void RecognizeMannerAdverbByText()
        {
            var randomWordFromVocabulary = RandomWordHelper.GetRandomMannerAdverb();
            CheckIfWordWasRecognizedByText(randomWordFromVocabulary);
        }

        [Fact]
        public void RecognizeTellHowItHappenedAdverbByText()
        {
            var randomWordFromVocabulary = RandomWordHelper.GetRandomTellHowItHappendAdverb();
            CheckIfWordWasRecognizedByText(randomWordFromVocabulary);
        }

        [Fact]
        public void RecognizeTellTheExtentOfTheActionAdverbByText()
        {
            var randomWordFromVocabulary = RandomWordHelper.GetRandomTellTheExtentOfTheActionAdverb();
            CheckIfWordWasRecognizedByText(randomWordFromVocabulary);
        }

        [Fact]
        public void RecognizeTellWhenItHappenedAdverbByText()
        {
            var randomWordFromVocabulary = RandomWordHelper.GetRandomTellWhenItHappendAdverb();
            CheckIfWordWasRecognizedByText(randomWordFromVocabulary);
        }

        [Fact]
        public void RecognizeTellWhereItHappenedAdverbByText()
        {
            var randomWordFromVocabulary = RandomWordHelper.GetRandomTellWhereItHappendAdverb();
            CheckIfWordWasRecognizedByText(randomWordFromVocabulary);
        }

        [Fact]
        public void DoAdverbRememberFromWhatItWasRecognized()
        {
            CheckIfWordRememberFromWhatItWasRecognized(typeof(Adverb));
        }
    }
}
