using System;
using System.Collections.Generic;
using System.Linq;

namespace MyPolyglotCore.Helpers
{
    public static class ShufflerHelper
    {
        private static readonly Random _random = new Random();

        public static IEnumerable<string> TakeSixShuffledStrings(this IEnumerable<string> collection, string rightWord)
        {
            var randomizedCollection = collection
                    .OrderBy(x => _random.Next())
                    .ToList();

            var fiveRandomWords = new List<string>();
            var i = 0;
            var countOfAddedWords = 0;
            while (countOfAddedWords != 5)
            {
                if (randomizedCollection[i] != rightWord)
                {
                    fiveRandomWords.Add(randomizedCollection[i]);
                    countOfAddedWords++;
                }
                i++;
            }

            fiveRandomWords.Add(rightWord);

            return fiveRandomWords.OrderBy(x => _random.Next());
        }

        public static IEnumerable<string> TakeFiveShuffledStrings(this IEnumerable<string> collection)
        {
            return collection
                .OrderBy(x => _random.Next())
                .Take(5);
        }

        public static IEnumerable<string> Shuffle(this IEnumerable<string> collection)
        {
            return collection.OrderBy(x => _random.Next());
        }
    }
}
