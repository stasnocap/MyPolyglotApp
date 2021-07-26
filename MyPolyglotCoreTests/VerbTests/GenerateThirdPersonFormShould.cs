using MyPolyglotCore.Words;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MyPolyglotCoreTests.VerbTests
{
    public class GenerateThirdPersonFormShould : VerbChecker
    {
        [Theory]
        [InlineData("watch", "watches")]
        [InlineData("miss", "misses")]
        [InlineData("rush", "rushes")]
        public void Test(string text, string expectedText)
        {
            var verb = new Verb(text);

        }
    }
}
