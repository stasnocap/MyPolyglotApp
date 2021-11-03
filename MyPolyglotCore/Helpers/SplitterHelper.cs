using MyPolyglotCore.Words;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MyPolyglotCore.Helpers
{
    public static class SplitterHelper
    {
        public static IEnumerable<Word> SplitToWords(this string engPhrase)
        {
            return SplitToStrings(engPhrase).Select(x => new Word(x));
        }

        public static IEnumerable<string> SplitToStrings(this string engPhrase)
        {
            return Regex.Matches(engPhrase.ToLower(), @"(more |most |\d )?[a-zA-Z0-9'-]+( not\b)?").Select(x => x.Value);
        }
    }
}
