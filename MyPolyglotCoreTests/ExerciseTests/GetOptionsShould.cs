using System;
using System.Collections.Generic;
using System.Linq;
using MyPolyglotCore.Words;
using MyPolyglotCore.Words.Pronouns;
using Xunit;

namespace MyPolyglotCore.Tests.ExerciseTests
{
    public class GetOptionsShould
    {
        [Theory]
        [InlineData(typeof(SubjectPronoun))]
        [InlineData(typeof(ObjectPronoun))]
        [InlineData(typeof(PossessiveAdjective))]
        [InlineData(typeof(PossessivePronoun))]
        [InlineData(typeof(ReflexivePronoun))]
        [InlineData(typeof(Determiner))]
        public void AddWordsToOptions(Type type)
        {
            var exercise = new Exercise("no matter", new List<Word>());
            var wordText = "no matter";

            dynamic word = type.Name switch
            {
                "SubjectPronoun" => (SubjectPronoun)Activator.CreateInstance(type, wordText),
                "ObjectPronoun" => (ObjectPronoun)Activator.CreateInstance(type, wordText),
                "PossessiveAdjective" => (PossessiveAdjective)Activator.CreateInstance(type, wordText),
                "PossessivePronoun" => (PossessivePronoun)Activator.CreateInstance(type, wordText),
                "ReflexivePronoun" => (ReflexivePronoun)Activator.CreateInstance(type, wordText),
                "Determiner" => (Determiner)Activator.CreateInstance(type, wordText),
                _ => throw new NotSupportedException()
            };

            exercise.EngPhrase.ToList().Add(word);

            var options = exercise.GetOptions();

            var vocabulary = Vocabulary.GetVocabulary(word.GetType());
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
            var exercise = new Exercise("no matter", new List<Word>());
            var textOfWord = "no matter";
            dynamic word = type.Name switch
            {
                "Noun" => (Noun)Activator.CreateInstance(type, textOfWord),
                "Verb" => (Verb)Activator.CreateInstance(type, textOfWord, false),
                "Adjective" => (Adjective)Activator.CreateInstance(type, textOfWord),
                _ => throw new NotSupportedException()
            };
            exercise.EngPhrase.ToList().Add(word);

            var options = exercise.GetOptions();

            Assert.Contains(textOfWord, options);
            Assert.True(options.Count() == 6);
        }
    }
}