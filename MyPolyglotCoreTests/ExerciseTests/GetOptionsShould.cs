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

            var exercise = new Exercise("no matter", Enumerable.Empty<Word>().Concat(new[] { word as Word }));

            var options = exercise.GetOptions();

            var vocabulary = Vocabulary.GetVocabulary(word.GetType()) as IReadOnlyCollection<Word>;
            foreach (var wordFromVocabulary in vocabulary)
            {
                Assert.Contains(wordFromVocabulary.Text, options);
            }
        }

        [Theory]
        [InlineData(typeof(Noun))]
        [InlineData(typeof(Adjective))]
        public void AddRandomFiveWordsWithRightAnswer(Type type)
        {
            var textOfWord = "no matter";

            dynamic word = type.Name switch
            {
                "Noun" => (Noun)Activator.CreateInstance(type, textOfWord),
                "Adjective" => (Adjective)Activator.CreateInstance(type, textOfWord),
                _ => throw new NotSupportedException()
            };

            var exercise = new Exercise("no matter", Enumerable.Empty<Word>().Concat(new[] { word as Word }));

            var options = exercise.GetOptions();

            Assert.Contains(textOfWord, options);
            Assert.True(options.Count() == 6);
        }

        [Fact]
        public void OptionsForVerbConsistsFromAllFormsOfVerb()
        {
            var verb = new Verb("play");
            var exercise = new Exercise("no matter", new List<Word> { verb });

            var verbForms = new List<string>()
            {
                verb.Text,
                verb.PastForm,
                verb.PastParticipleForm,
                verb.PresentParticipleForm,
                verb.ThirdPersonForm,
            };

            var options = exercise.GetOptions();

            foreach (var form in verbForms)
            {
                Assert.Contains(form, options);
            }
        }
    }
}