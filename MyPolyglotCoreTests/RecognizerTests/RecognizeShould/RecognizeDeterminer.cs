using MyPolyglotCore;
using MyPolyglotCore.Words;
using Xunit;

namespace MyPolyglotCoreTests.RecognizerTests.RecognizeShould
{
    public class RecognizeDeterminer : RecognizingChecker
    {
        [Fact]
        public void RecognizeDeterminerInPhrase()
        {
            var randomDeterminer = RandomWordHelper.GetRandomDeterminer();
            CheckIfWordWasRecognizedByText(randomDeterminer);
        }

        [Fact]
        public void DoDeterminerRememberFromWhatItWasRecognized()
        {
            CheckIfWordRememberFromWhatItWasRecognized(typeof(Determiner));
        }
    }
}
