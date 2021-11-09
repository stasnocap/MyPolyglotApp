using MyPolyglotCore;
using MyPolyglotCore.Words;
using System.Linq;
using Xunit;

namespace MyPolyglotCoreTests.RecognizerTests.RecognizeShould
{
    public class RecognizeLanguage : RecognizingChecker
    {
        [Fact]
        public void RecognizeLanguageByText()
        {
            var randomLanguage = default(Language);
            do
            {
                randomLanguage = RandomWordHelper.GetRandomLanguage();
            } while (randomLanguage.Text.Split(' ').Length > 1);
            // because language words that consist of >1 words are non-recognizable, those words exist only for options generating

            CheckIfWordWasRecognizedByText(randomLanguage);
        }

        [Fact]
        public void DoLanguageRememberFromWhatItWasRecognized()
        {
            var randomLanguage = default(Language);
            do
            {
                randomLanguage = RandomWordHelper.GetRandomLanguage();
            } while (randomLanguage.Text.Split(' ').Length > 1);
            // because language words that consist of >1 words are non-recognizable, those words exist only for options generating

            _recognizer.Recognize("rstrs " + randomLanguage.Text + " rtst");

            Assert.Equal(randomLanguage.Text, _recognizer.RecognizedWords.First().FromWhatItWasRecognized);
        }
    }
}
