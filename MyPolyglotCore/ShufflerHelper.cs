using System;
using System.Collections.Generic;
using System.Linq;

namespace MyPolyglotCore
{
    public static class ShufflerHelper
    {
        private static readonly Random _random = new Random(); 

        public static IEnumerable<string> TakeSixShuffledStrings(this IEnumerable<string> collection, string stringThatWillHaveHadRandomIndex)
        { 
            return collection
                    .OrderBy(x => _random.Next())
                    .Take(5)
                    .Append(stringThatWillHaveHadRandomIndex)
                    .OrderBy(x => _random.Next());
        }
    }
}
