using System.Collections.Generic;
using MyPolyglotCore.Words;
using Xunit;

namespace MyPolyglotCore.Tests.VerbTests
{
    public class IsIrregularVerbShould
    {
        [Fact]
        public void ReturnTrueIfIrregularVerbExistInVocabulary()
        {
            var verb = new Verb() { Text = "abide" };

            var vocabulary = new List<Verb>();
            vocabulary.Add(verb);

            Assert.True(verb.IsIrregularVerb(vocabulary));
        }

        [Fact]
        public void ReturnFalseIfIrregularVerbDoesNotExistInVocabulary()
        {
            var verb = new Verb() { Text = "abide" };

            var vocabulary = new List<Verb>();

            Assert.False(verb.IsIrregularVerb(vocabulary));
        }
    }
}