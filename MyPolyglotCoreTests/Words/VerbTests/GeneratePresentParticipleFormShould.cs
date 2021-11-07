using MyPolyglotCore.Words;
using Xunit;

namespace MyPolyglotCoreTests.Words.VerbTests
{
    public class GeneratePresentParticipleFormShould
    {
        [Theory]
        [InlineData("hit", "hitting", true)]
        [InlineData("begin", "beginning", true)]
        [InlineData("listen", "listening", false)]
        [InlineData("follow", "following", false)]
        public void TransformVowelPlusConsonantToDoubleConsonantPlusIng(string text, string expectedText, bool stressOnTheFinalSyllable)
        {
            CheckCorrectGeneration(text, expectedText, stressOnTheFinalSyllable);
        }

        [Theory]
        [InlineData("bake", "baking")]
        [InlineData("eliminate", "eliminating")]
        public void TransformEToRemoveEPlusIng(string text, string expectedText)
        {
            CheckCorrectGeneration(text, expectedText);
        }

        [Theory]
        [InlineData("die", "dying")]
        [InlineData("lie", "lying")]
        public void TransformIEtoYING(string text, string expectedText)
        {
            CheckCorrectGeneration(text, expectedText);
        }

        [Theory]
        [InlineData("watch", "watching")]
        [InlineData("discover", "discovering")]
        public void JustAddIng(string text, string expectedText)
        {
            CheckCorrectGeneration(text, expectedText);
        }

        private void CheckCorrectGeneration(string text, string expectedText, bool stressOnTheFinalSyllable = false)
        {
            var verb = new Verb(text, stressOnTheFinalSyllable);
            Assert.Equal(expectedText, verb.PresentParticipleForm);
        }

    }
}