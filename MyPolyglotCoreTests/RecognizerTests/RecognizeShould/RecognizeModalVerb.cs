using MyPolyglotCore;
using MyPolyglotCore.Words;
using Xunit;

namespace MyPolyglotCoreTests.RecognizerTests.RecognizeShould
{
    public class RecognizeModalVerb : RecognizingChecker
    {
        [Fact]
        public void RecognizeModalVerbByAffirmativeForm()
        {
            var randomModalVerb = RandomWordHelper.GetRandomModalVerb();
            CheckIfWordWasRecognizedByText(randomModalVerb);
        }

        [Fact]
        public void RecognizeModalVerbByNegativeForm()
        {
            var randomModalVerb = RandomWordHelper.GetRandomModalVerb();
            _recognizer.Recognize("rstrs " + randomModalVerb.ShortNegativeForm + " rtst");

            Assert.Collection(_recognizer.RecognizedWords, x => Assert.Equal(x, randomModalVerb));
        }

        [Fact]
        public void DoModalVerbRememberFromWhatItWasRecognized()
        {
            CheckIfWordRememberFromWhatItWasRecognized(typeof(ModalVerb));
        }
    }
}
