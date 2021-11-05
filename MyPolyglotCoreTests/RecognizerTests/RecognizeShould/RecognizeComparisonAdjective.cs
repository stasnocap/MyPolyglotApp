using MyPolyglotCore;
using MyPolyglotCore.Words;
using Xunit;

namespace MyPolyglotCoreTests.RecognizerTests.RecognizeShould
{
    public class RecognizeComparisonAdjective : RecognizingChecker
    {
        [Fact]
        public void RecognizeComparisonAdjectiveByRootForm()
        {
            var randomComparisonAdjective = RandomWordHelper.GetRandomComparisonAdjective();
            _recognizer.Recognize("rstrs " + randomComparisonAdjective.Text + " rtst");

            Assert.Collection(_recognizer.RecognizedWords, x => Assert.Equal(x, randomComparisonAdjective));
        }

        [Fact]
        public void RecognizeComparisonAdjectiveByComparativeForm()
        {
            var randomComparisonAdjective = RandomWordHelper.GetRandomComparisonAdjective();
            _recognizer.Recognize("rstrs " + randomComparisonAdjective.ComparativeForm + " rtst");

            Assert.Collection(_recognizer.RecognizedWords, x => Assert.Equal(x, randomComparisonAdjective));
        }

        [Fact]
        public void RecognizeComparisonAdjectiveBySuperlativeForm()
        {
            var randomComparisonAdjective = RandomWordHelper.GetRandomComparisonAdjective();
            _recognizer.Recognize("rstrs " + randomComparisonAdjective.SuperlativeForm + " rtst");

            Assert.Collection(_recognizer.RecognizedWords, x => Assert.Equal(x, randomComparisonAdjective));
        }

        [Fact]
        public void DoComparisonAdjectiveRememberFromWhatItWasRecognized()
        {
            CheckIfWordRememberFromWhatItWasRecognized(typeof(ComparisonAdjective));
        }
    }
}
