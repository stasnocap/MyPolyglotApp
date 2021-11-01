using MyPolyglotCore.Helpers;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace MyPolyglotCoreTests.Helpers.ShufflerHelperTests
{
    public class TakeSixShuffledStringsShould
    {
        [Fact]
        public void ReturnCollectionThatContainsRightWord()
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

            var rightWord = "eleven";

            var shuffled = collection.TakeSixShuffledStrings(rightWord);

            Assert.Contains(rightWord, shuffled);
        }

        [Fact]
        public void ReturnCollectionThatContainsOtherWordsFromCollection()
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

            var rightWordStr = "eleven";

            var shuffled = collection.TakeSixShuffledStrings(rightWordStr);

            foreach (var wordStr in shuffled)
            {
                if (wordStr == rightWordStr)
                {
                    continue;
                }

                Assert.Contains(wordStr, collection);
            }
        }
        
        [Fact]
        public void ReturnSixElements()
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

            var rightWordStr = "eleven";

            var shuffled = collection.TakeSixShuffledStrings(rightWordStr);

            Assert.Equal(6, shuffled.Count());
        }
    }
}
