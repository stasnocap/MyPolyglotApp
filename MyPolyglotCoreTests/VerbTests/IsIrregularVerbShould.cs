using System.Collections.Generic;
using System.Reflection;
using MyPolyglotCore.Words;
using Xunit;

namespace MyPolyglotCore.Tests.VerbTests
{
    public class IsIrregularVerbShould
    {
        private Vocabulary _vocabulary;
        private HashSet<char> _consonants;
        private HashSet<char> _vowels;

        public IsIrregularVerbShould()
        {
            _vocabulary = new Vocabulary();
            _consonants = typeof(Vocabulary).GetField("_consonants", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(_vocabulary) as HashSet<char>;
            _vowels = typeof(Vocabulary).GetField("_vowels", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(_vocabulary) as HashSet<char>;
        }

        [Fact]
        public void ReturnTrueIfIrregularVerbExistInVocabulary()
        {
            var verb = new Verb("abide", _consonants, _vowels) { Text = "abide" };

            var vocabulary = new List<Verb>();
            vocabulary.Add(verb);

            Assert.True(verb.IsIrregularVerb(vocabulary));
        }

        [Fact]
        public void ReturnFalseIfIrregularVerbDoesNotExistInVocabulary()
        {
            var verb = new Verb("abide", _consonants, _vowels) { Text = "abide" };

            var vocabulary = new List<Verb>();

            Assert.False(verb.IsIrregularVerb(vocabulary));
        }
    }
}