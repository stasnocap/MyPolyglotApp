using System;
using System.Linq;
using MyPolyglotCore.Words;
using MyPolyglotCore.Words.Pronouns;
using Xunit;

namespace MyPolyglotCore.Tests.ExerciseTests
{
    public class GetOptionsShould
    {
        private Vocabulary _vocabulary;

        public GetOptionsShould()
        {
            _vocabulary = new Vocabulary();
        }

        [Theory]
        [InlineData(typeof(SubjectPronoun))]
        [InlineData(typeof(ObjectPronoun))]
        [InlineData(typeof(PossessiveAdjective))]
        [InlineData(typeof(PossessivePronoun))]
        [InlineData(typeof(ReflexivePronoun))]
        [InlineData(typeof(Determiner))]
        public void AddWordsToOptions(Type type)
        {
            var exercise = new Exercise(_vocabulary);

            dynamic word = type.Name switch
            {
                "SubjectPronoun" => (SubjectPronoun)Activator.CreateInstance(type),
                "ObjectPronoun" => (ObjectPronoun)Activator.CreateInstance(type),
                "PossessiveAdjective" => (PossessiveAdjective)Activator.CreateInstance(type),
                "PossessivePronoun" => (PossessivePronoun)Activator.CreateInstance(type),
                "ReflexivePronoun" => (ReflexivePronoun)Activator.CreateInstance(type),
                "Determiner" => (Determiner)Activator.CreateInstance(type),
                _ => throw new NotSupportedException()
            };

            exercise.EngPhrase.Add(word);

            var options = exercise.GetOptions();

            var vocabulary = _vocabulary.GetVocabulary(word);
            foreach (var pronoun in vocabulary)
            {
                Assert.Contains(pronoun, options);
            }
        }

        [Theory]
        [InlineData(typeof(Noun))]
        [InlineData(typeof(Verb))]
        [InlineData(typeof(Adjective))]
        public void AddRandomFiveWordsWithRightAnswer(Type type)
        {
            var exercise = new Exercise(new Vocabulary());
            var textOfWord = "no matter";
            dynamic word = type.Name switch
            {
                "Noun" => (Noun)Activator.CreateInstance(type),
                "Verb" => (Verb)Activator.CreateInstance(type),
                "Adjective" => (Adjective)Activator.CreateInstance(type),
                _ => throw new NotSupportedException()
            };
            word.Text = textOfWord;
            exercise.EngPhrase.Add(word);

            var options = exercise.GetOptions();

            Assert.Contains(textOfWord, options.Select(x => x.Text));
            Assert.True(options.Count() == 6);
        }
    }
}