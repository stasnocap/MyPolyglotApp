using MyPolyglotCore;
using MyPolyglotCore.Words;
using System.Linq;
using Xunit;

namespace MyPolyglotCoreTests.RecognizerTests.RecognizeShould
{
    public class RecognizeCity : RecognizingChecker
    {
        [Fact]
        public void RecognizeCityByText()
        {
            var randomCity = default(City);
            do
            {
                randomCity = RandomWordHelper.GetRandomCity();
            } while (randomCity.Text.Split(' ').Length > 1);
            // because 2 and 3 city words non-recognizable, it is exist only for options generating

            CheckIfWordWasRecognizedByText(randomCity);
        }

        [Fact]
        public void DoCityRememberFromWhatItWasRecognized()
        {
            var randomCity = default(City);
            do
            {
                randomCity = RandomWordHelper.GetRandomCity();
            } while (randomCity.Text.Split(' ').Length > 1);
            // because 2 and 3 city words non-recognizable, it is exist only for options generating

            _recognizer.Recognize("rstrs " + randomCity.Text + " rtst");

            Assert.Equal(randomCity.Text, _recognizer.RecognizedWords.First().FromWhatItWasRecognized);
        }
    }
}
