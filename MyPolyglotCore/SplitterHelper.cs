using MyPolyglotCore.Words;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MyPolyglotCore
{
    public static class SplitterHelper
    {
        public static IEnumerable<Word> SplitToWords(this string engPhrase)
        {
            return SplitToStrings(engPhrase).Select(x => new Word(x));
        }

        public static IEnumerable<string> SplitToStrings(this string engPhrase)
        {
            return Regex.Split(engPhrase.ToLower(), "[^a-zA-Z0-9']+")
                        .Where(x => !string.IsNullOrEmpty(x));
        }
    }
}
