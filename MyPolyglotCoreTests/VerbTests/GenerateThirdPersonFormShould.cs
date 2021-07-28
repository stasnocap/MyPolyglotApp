using MyPolyglotCore.Words;
using Xunit;

namespace MyPolyglotCoreTests.VerbTests
{
    public class GenerateThirdPersonFormShould
    {
        [Theory]
        [InlineData("watch", "watches")]
        [InlineData("miss", "misses")]
        [InlineData("rush", "rushes")]
        [InlineData("relax", "relaxes")]
        [InlineData("buzz", "buzzes")]
        public void AddESToCertainEndings(string text, string expectedText)
        {
            CheckCorrectGeneration(text, expectedText);
        }

        [Theory]
        [InlineData("try", "tries")]
        [InlineData("apply", "applies")]
        public void TransformYtoES(string text, string expectedText)
        {
            CheckCorrectGeneration(text, expectedText);
        }

        [Theory]
        [InlineData("sing", "sings")]
        [InlineData("give", "gives")]
        [InlineData("require", "requires")]
        public void JustAddS(string text, string expectedText)
        {
            CheckCorrectGeneration(text, expectedText);
        }

        private void CheckCorrectGeneration(string text, string expectedText)
        {
            var verb = new Verb(text);
            Assert.Equal(expectedText, verb.ThirdPersonForm);
        }
    }
}
