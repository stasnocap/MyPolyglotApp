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
                    .Shuffle()
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

            return fiveRandomWords.Shuffle();
        }

        public static IEnumerable<string> TakeFiveShuffledStrings(this IEnumerable<string> collection)
        {
            return collection
                .Shuffle()
                .Take(5);
        }

        public static IEnumerable<string> Shuffle(this IEnumerable<string> collection)
        {
            return collection.OrderBy(x => _random.Next());
        }
    }
}
