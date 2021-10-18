using MyPolyglotCore.Words;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using Xunit;

namespace MyPolyglotCoreTests.NounTests
{
    public class GeneratePluralForm
    {
        private void CheckCorrectGeneration(string text, string expectedText)
        {
            var noun = new Noun(text);
            Assert.Equal(expectedText, noun.PluralForm);
        }

        [Theory]
        [InlineData("bus", "buses")]
        [InlineData("truss", "trusses")]
        [InlineData("marsh", "marshes")]
        [InlineData("lunch", "lunches")]
        [InlineData("tax", "taxes")]
        [InlineData("blitz", "blitzes")]
        [InlineData("tomato", "tomatoes")]
        [InlineData("potato", "potatoes")]
        public void AddEs_IfWordEndsWithSorSSorSHorCHorXorZorESorO(string text, string expectedText)
        {
            CheckCorrectGeneration(text, expectedText);
        }

        [Theory]
        [InlineData("photo", "photos")]
        [InlineData("piano", "pianos")]
        [InlineData("halo", "halos")]
        public void DontAddEsButS_IfWordEndsWithOExceptions(string text, string expectedText)
        {
            CheckCorrectGeneration(text, expectedText);
        }

        [Theory]
        [InlineData("wolf", "wolves")]
        [InlineData("calf", "calves")]
        [InlineData("leaf", "leaves")]
        public void RepalceFWithVES_IfWordEndsWithF(string text, string expectedText)
        {
            CheckCorrectGeneration(text, expectedText);
        }

        [Theory]
        [InlineData("wife", "wives")]
        [InlineData("knife", "knives")]
        [InlineData("life", "lives")]
        public void ReplaceFEWithVES_IfWordEndsWithFe(string text, string expectedText)
        {
            CheckCorrectGeneration(text, expectedText);
        }

        [Theory]
        [InlineData("city", "cities")]
        [InlineData("puppy", "puppies")]
        public void ReplaceYwithIES_IfWordEndsWithConsonantAndY(string text, string expectedText)
        {
            CheckCorrectGeneration(text, expectedText);
        }

        [Theory]
        [InlineData("roof", "roofs")]
        [InlineData("belief", "beliefs")]
        [InlineData("chef", "chefs")]
        [InlineData("chief", "chiefs")]
        public void DontReplaceFWithVES_Exceptions(string text, string expectedText)
        {
            CheckCorrectGeneration(text, expectedText);
        }

        [Theory]
        [InlineData("analysis", "analyses")]
        [InlineData("ellipsis", "ellipses")]
        public void ReplaceIsWithEs_IfTextEndsWithEs(string text, string expectedText)
        {
            CheckCorrectGeneration(text, expectedText);
        }

        [Theory]
        [InlineData("phenomenon", "phenomena")]
        [InlineData("criterion", "criteria")]
        public void AddA_IfTextEndsWithOn(string text, string expectedText)
        {
            CheckCorrectGeneration(text, expectedText);
        }
    }
}
