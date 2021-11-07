using MyPolyglotCore.Helpers;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace MyPolyglotCoreTests.Helpers.ShufflerHelperTests
{
    public class TakeFiveShuffledStrings
    {
        [Fact]
        public void ReturnCollectionThatContainsAllWordsFromCollection()
        {
            var collection = new List<string>()
            {
                "one",
                "two",
                "three",
                "four",
                "five",
                "six",
                "seven",
                "eight",
                "nine",
                "ten",
            };

            var shuffled = collection.TakeFiveShuffledStrings();

            foreach (var wordStr in shuffled)
            {
                Assert.Contains(wordStr, collection);
            }
        }

        [Fact]
        public void ReturnFiveElements()
        {
            var collection = new List<string>()
            {
                "one",
                "two",
                "three",
                "four",
                "five",
                "six",
                "seven",
                "eight",
                "nine",
                "ten",
            };

            var shuffled = collection.TakeFiveShuffledStrings();

            Assert.Equal(5, shuffled.Count());
        }
    }
}
