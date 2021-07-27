using MyPolyglotCore.Words;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MyPolyglotCoreTests.VerbTests
{
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

        private void CheckCorrectGeneration(string text, string expectedText)
        {
            var verb = new Verb(text);
            Assert.Equal(expectedText, verb.ThirdPersonForm);
        }
    }
}
