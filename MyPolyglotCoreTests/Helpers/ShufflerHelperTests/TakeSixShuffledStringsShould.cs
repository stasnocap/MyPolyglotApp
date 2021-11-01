using MyPolyglotCore.Helpers;
using System.Collections.Generic;
using Xunit;

namespace MyPolyglotCoreTests.Helpers.ShufflerHelperTests
{
    public class TakeSixShuffledStringsShould
    {
        [Fact]
        public void ContainsRightWord()
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
        public void ContainsOtherWordsFromCollection()
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
    }
}
