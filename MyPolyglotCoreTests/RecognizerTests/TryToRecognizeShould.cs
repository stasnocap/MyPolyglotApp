using System;
using MyPolyglotCore;
using MyPolyglotCore.Words;
using MyPolyglotCore.Words.Pronouns;
using Xunit;

namespace MyPolyglotCoreTests.RecognizerTests
{
    public class TryToRecognizeShould
    {
        [Theory]
        [InlineData(typeof(SubjectPronoun))]
        [InlineData(typeof(ObjectPronoun))]
        [InlineData(typeof(PossessiveAdjective))]
        [InlineData(typeof(PossessivePronoun))]
        [InlineData(typeof(ReflexivePronoun))]
        [InlineData(typeof(Determiner))]
        public void ReturnWordFromVocabulary_GivenPhraseWithWordFromVocabulary(Type type)
        {
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

            var vocabulary = new Vocabulary().GetVocabulary(word);

            var randomWordFromVocabulary = vocabulary[new Random().Next(vocabulary.Count)];

            var engPhrase =
                $",,.1 s,t! tr , starst nsetnrsit!ta stra {randomWordFromVocabulary}, 2 arstar";

            var recognizer = new Recognizer(engPhrase);

            recognizer.TryToRecognize();

            Assert.Contains(randomWordFromVocabulary, recognizer.RecognizedWords);
        }

    }
}
