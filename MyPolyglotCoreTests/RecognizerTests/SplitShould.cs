using MyPolyglotCore;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MyPolyglotCoreTests.RecognizerTests
{
    public class SplitShould
    {
        [Theory]
        [InlineData("Hi guys, boys and girls.")]
        [InlineData(" !Hi guys, boys and girls.!")]
        public void ReturnWordsWithoutPunctuationSymbols(string engPhrase)
        {
            var recognizer = new Recognizer();
            var words = recognizer.Split(engPhrase);

            foreach (var word in words)
            {
                Assert.DoesNotMatch("\\W", word);
            }
        }
    }
}
