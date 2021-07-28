using MyPolyglotCore.Words;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MyPolyglotCoreTests.VerbTests
{
    public class GeneratePastFormShould
    {
        [Theory]
        [InlineData("stop", "stopped")]
        [InlineData("plan", "planned")]
        public void DoubleLastCharPlusEDIfTextEndsWithVowelAndConsonant(string text, string expectedText)
        {
            CheckCorrectGeneration(text, expectedText);
        }

        [Theory]
        [InlineData("try", "tried")]
        [InlineData("carry", "carried")]
        public void RemoveYAndAddIEDIfTextEndsWithVowelPlusY(string text, string expectedText)
        {
            CheckCorrectGeneration(text, expectedText);
        }

        [Theory]
        [InlineData("play", "played")]
        [InlineData("enjoy", "enjoyed")]
        public void AddEDIfTextEndsWithVowelPlusY(string text, string expectedText)
        {
            CheckCorrectGeneration(text, expectedText);
        }

        [Theory]
        [InlineData("agree", "agreed")]
        [InlineData("like", "liked")]
        [InlineData("escape", "escaped")]
        public void AddDIfTextEndsWithE(string text, string expectedText)
        {
            CheckCorrectGeneration(text, expectedText);
        }
        
        private void CheckCorrectGeneration(string text, string expectedText)
        {
            var verb = new Verb(text);
            Assert.Equal(expectedText, verb.PastForm);
        }
    }
}
