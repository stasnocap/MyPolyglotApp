using MyPolyglotCore;
using MyPolyglotCore.Words;
using Xunit;

namespace MyPolyglotCoreTests.RecognizerTests.RecognizeShould
{
    public class RecognizeCompound : RecognizingChecker
    {
        [Fact]
        public void RecognizeCompoundByText()
        {
            var randomWordFromVocabulary = RandomWordHelper.GetRandomCompound();
            CheckIfWordWasRecognizedByText(randomWordFromVocabulary);
        }

        [Fact]
        public void DoCompoundRememberFromWhatItWasRecognized()
        {
            CheckIfWordRememberFromWhatItWasRecognized(typeof(Compound));
        }
    }
}
