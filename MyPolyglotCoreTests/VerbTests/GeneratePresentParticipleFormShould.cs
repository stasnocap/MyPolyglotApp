using MyPolyglotCore;
using MyPolyglotCore.Words;
using System.Collections.Generic;
using System.Reflection;
using Xunit;

namespace MyPolyglotCoreTests.VerbTests
{
    public class GeneratePresentParticipleFormShould
    {
        private Vocabulary _vocabulary;
        private HashSet<char> _consonants;
        private HashSet<char> _vowels;

        public GeneratePresentParticipleFormShould()
        {
            _vocabulary = new Vocabulary();
            _consonants = typeof(Vocabulary).GetField("_consonants", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(_vocabulary) as HashSet<char>;
            _vowels = typeof(Vocabulary).GetField("_vowels", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(_vocabulary) as HashSet<char>;
        }

        [Theory]
        [InlineData("hit", "hitting", true)]
        [InlineData("begin", "beginning", true)]
        [InlineData("listen", "listening", false)]
        [InlineData("follow", "following", false)]
        public void TransformVowelPlusConsonantToDoubleConsonantPlusIng(string text, string expectedText, bool stressOnTheFinalSyllable)
        {
            CheckIfVerbGeneratesWithRightWord(text, expectedText, stressOnTheFinalSyllable);
        }

        [Theory]
        [InlineData("bake", "baking")]
        [InlineData("eliminate", "eliminating")]
        public void TransformEToRemoveEPlusIng(string text, string expectedText)
        {
            CheckIfVerbGeneratesWithRightWord(text, expectedText);
        }

        [Theory]
        [InlineData("die", "dying")]
        [InlineData("lie", "lying")]
        public void TransformIEtoYING(string text, string expectedText)
        {
            CheckIfVerbGeneratesWithRightWord(text, expectedText);
        }

        [Theory]
        [InlineData("watch", "watching")]
        [InlineData("discover", "discovering")]
        public void JustAddIng(string text, string expectedText)
        {
            CheckIfVerbGeneratesWithRightWord(text, expectedText);
        }

        private void CheckIfVerbGeneratesWithRightWord(string text, string expectedText, bool stressOnTheFinalSyllable = false)
        {
            var verb = new Verb(text, _consonants, _vowels, stressOnTheFinalSyllable);
            Assert.Equal(expectedText, verb.PresentParticipleForm);
        }
    }
}
