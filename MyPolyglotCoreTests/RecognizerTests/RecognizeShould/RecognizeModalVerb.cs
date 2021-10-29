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
            var randomWordFromVocabulary = RandomWordHelper.GetRandomModalVerb();
            CheckIfWordWasRecognizedByText(randomWordFromVocabulary);
        }

        [Fact]
        public void RecognizeModalVerbByNegativeForm()
        {
            var modalVerb = RandomWordHelper.GetRandomModalVerb();
            _recognizer.Recognize("rstrs " + modalVerb.ShortNegativeForm + " rtst");

            Assert.Collection(_recognizer.RecognizedWords, x => Assert.Equal(x, modalVerb));
        }

        [Fact]
        public void DoModalVerbRememberFromWhatItWasRecognized()
        {
            CheckIfWordRememberFromWhatItWasRecognized(typeof(ModalVerb));
        }
    }
}
