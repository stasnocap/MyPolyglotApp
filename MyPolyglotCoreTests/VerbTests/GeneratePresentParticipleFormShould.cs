using MyPolyglotCore;
using MyPolyglotCore.Words;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xunit;

namespace MyPolyglotCoreTests.VerbTests
{
    public class GeneratePresentParticipleFormShould
    {
        [Fact]
        public void Test()
        {
            var vocabulary = new Vocabulary();
            var consonants = typeof(Vocabulary).GetField("_consonants", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(vocabulary) as HashSet<char>;
            var vowels = typeof(Vocabulary).GetField("_vowels", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(vocabulary) as HashSet<char>;
            var verb = new Verb(consonants, vowels);

        }
    }
}
