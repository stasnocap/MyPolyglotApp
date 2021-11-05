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
            var randomFrequencyAdverb = RandomWordHelper.GetRandomFrequencyAdverb();
            CheckIfWordWasRecognizedByText(randomFrequencyAdverb);
        }

        [Fact]
        public void RecognizeIntensifierAdverbByText()
        {
            var randomIntensifierAdverb = RandomWordHelper.GetRandomIntensifierAdverb();
            CheckIfWordWasRecognizedByText(randomIntensifierAdverb);
        }

        [Fact]
        public void RecognizeMannerAdverbByText()
        {
            var randomMannerAdverb = RandomWordHelper.GetRandomMannerAdverb();
            CheckIfWordWasRecognizedByText(randomMannerAdverb);
        }

        [Fact]
        public void RecognizeTellHowItHappenedAdverbByText()
        {
            var randomTellHowItHappendAdverb = RandomWordHelper.GetRandomTellHowItHappendAdverb();
            CheckIfWordWasRecognizedByText(randomTellHowItHappendAdverb);
        }

        [Fact]
        public void RecognizeTellTheExtentOfTheActionAdverbByText()
        {
            var randomTellTheExtentOfTheActionAdverb = RandomWordHelper.GetRandomTellTheExtentOfTheActionAdverb();
            CheckIfWordWasRecognizedByText(randomTellTheExtentOfTheActionAdverb);
        }

        [Fact]
        public void RecognizeTellWhenItHappenedAdverbByText()
        {
            var randomTellWhenItHappendAdverb = RandomWordHelper.GetRandomTellWhenItHappendAdverb();
            CheckIfWordWasRecognizedByText(randomTellWhenItHappendAdverb);
        }

        [Fact]
        public void RecognizeTellWhereItHappenedAdverbByText()
        {
            var randomTellWhereItHappendAdverb = RandomWordHelper.GetRandomTellWhereItHappendAdverb();
            CheckIfWordWasRecognizedByText(randomTellWhereItHappendAdverb);
        }

        [Fact]
        public void DoAdverbRememberFromWhatItWasRecognized()
        {
            CheckIfWordRememberFromWhatItWasRecognized(typeof(Adverb));
        }
    }
}
