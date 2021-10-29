using MyPolyglotCore.Helpers;
using System.Collections.Generic;
using Xunit;

namespace MyPolyglotCoreTests.SplitterHelperTests
{
    public class SplitToStringsShould
    {
        private readonly string _engPhrase = "I am cool.";
        private readonly List<string> _splittedEngPhrase = new List<string>() { "i", "am", "cool" };

        [Fact]
        public void SplitToExactLowerCaseStrings()
        {
            var words = _engPhrase.SplitToStrings();

            foreach (var word in words)
            {
                Assert.Contains(word, _splittedEngPhrase);
            }
        }

        [Fact]
        public void NotContainsNullOrEmpty()
        {
            var words = _engPhrase.SplitToStrings();

            foreach (var word in words)
            {
                Assert.False(string.IsNullOrEmpty(word));
            }
        }

        [Fact]
        public void SplitNegativeFormWithPreviousWordAsSingularWord()
        {
            var engPhrase = "I am not cool.";
            var splittedEngPhrase = new List<string>()
            {
                "i", "am not", "cool"
            };

            var words = engPhrase.SplitToStrings();

            foreach (var word in words)
            {
                Assert.Contains(word, splittedEngPhrase);
            }
        }
    }
}
