using MyPolyglotCore;
using MyPolyglotCore.Words;
using Xunit;

namespace MyPolyglotCoreTests.RecognizerTests.RecognizeShould
{
    public class RecognizeCity : RecognizingChecker
    {
        [Fact]
        public void RecognizeCityByText()
        {
            var randomCity = RandomWordHelper.GetRandomCity();
            CheckIfWordWasRecognizedByText(randomCity);
        }

        [Fact]
        public void DoCityRememberFromWhatItWasRecognized()
        {
            CheckIfWordRememberFromWhatItWasRecognized(typeof(City));
        }
    }
}
