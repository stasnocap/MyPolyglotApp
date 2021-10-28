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
            var comparisonAdjective = RandomWordHelper.GetRandomComparisonAdjective();
            _recognizer.Recognize("rstrs " + comparisonAdjective.Text + " rtst");

            Assert.Collection(_recognizer.RecognizedWords, x => Assert.Equal(x, comparisonAdjective));
        }

        [Fact]
        public void RecognizeComparisonAdjectiveByComparativeForm()
        {
            var comparisonAdjective = RandomWordHelper.GetRandomComparisonAdjective();
            _recognizer.Recognize("rstrs " + comparisonAdjective.ComparativeForm + " rtst");

            Assert.Collection(_recognizer.RecognizedWords, x => Assert.Equal(x, comparisonAdjective));
        }

        [Fact]
        public void RecognizeComparisonAdjectiveBySuperlativeForm()
        {
            var comparisonAdjective = RandomWordHelper.GetRandomComparisonAdjective();
            _recognizer.Recognize("rstrs " + comparisonAdjective.SuperlativeForm + " rtst");

            Assert.Collection(_recognizer.RecognizedWords, x => Assert.Equal(x, comparisonAdjective));
        }

        [Fact]
        public void DoComparisonAdjectiveRememberFromWhatItWasRecognized()
        {
            CheckIfWordRememberFromWhatItWasRecognized(typeof(ComparisonAdjective));
        }
    }
}
