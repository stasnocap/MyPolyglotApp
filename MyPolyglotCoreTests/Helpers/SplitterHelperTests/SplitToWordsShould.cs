using MyPolyglotCore.Helpers;
using Xunit;

namespace MyPolyglotCoreTests.Helpers.SplitterHelperTests
{
    public class SplitToWordsShould
    {
        [Fact]
        public void NotContainsNull()
        {
            var words = "I am cool.".SplitToWords();

            foreach (var word in words)
            {
                Assert.NotNull(word);
            }
        }
    }
}
