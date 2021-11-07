using MyPolyglotCore;
using MyPolyglotCore.Words;
using Xunit;

namespace MyPolyglotCoreTests.RecognizerTests.RecognizeShould
{
    public class RecognizePreposition : RecognizingChecker
    {
        [Fact]
        public void RecognizePrepositionByText()
        {
            var randomPreposition = RandomWordHelper.GetRandomPreposition();
            CheckIfWordWasRecognizedByText(randomPreposition);
        }

        [Fact]
        public void DoPrepositionRememberFromWhatItWasRecognized()
        {
            CheckIfWordRememberFromWhatItWasRecognized(typeof(Preposition));
        }
    }
}
