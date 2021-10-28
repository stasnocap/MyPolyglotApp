using MyPolyglotCore;
using MyPolyglotCore.Words;
using Xunit;

namespace MyPolyglotCoreTests.RecognizerTests.RecognizeShould
{
    public class RecognizeAdjective : RecognizingChecker
    {
        [Fact]
        public void RecognizeAdjectiveByText()
        {
            var randomWordFromVocabulary = RandomWordHelper.GetRandomAdjective();
            CheckIfWordWasRecognizedByText(randomWordFromVocabulary);
        }

        [Fact]
        public void DoAdjectiveRememberFromWhatItWasRecognized()
        {
            CheckIfWordRememberFromWhatItWasRecognized(typeof(Adjective));
        }
    }
}
