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
            var randomWordFromVocabulary = RandomWordHelper.GetRandomDeterminer();
            CheckIfWordWasRecognizedByText(randomWordFromVocabulary);
        }

        [Fact]
        public void DoDeterminerRememberFromWhatItWasRecognized()
        {
            CheckIfWordRememberFromWhatItWasRecognized(typeof(Determiner));
        }
    }
}
