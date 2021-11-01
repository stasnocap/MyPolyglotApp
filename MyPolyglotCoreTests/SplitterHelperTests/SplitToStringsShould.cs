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

        [Fact]
        public void SplitMoreWithNextWordAsSingularWord()
        {
            var engPhrase = "The weather is more beautiful today than yeasterday.";

            var words = engPhrase.SplitToStrings();

            Assert.Contains("more beautiful", words);
        }

        [Fact]
        public void SplitMostWithNextWordAsSingularWord()
        {
            var engPhrase = "Today's weather is the most beautiful weather i have ever seen.";

            var words = engPhrase.SplitToStrings();

            Assert.Contains("most beautiful", words);
        }

        [Fact]
        public void SplitNumberWithNextWordAsSingularWord()
        {
            var engPhrase = "We were here 3 hours ago.";

            var words = engPhrase.SplitToStrings();

            Assert.Contains("3 hours", words);
        }
    }
}
