using System;
using System.Collections.Generic;
using System.Linq;
using MyPolyglotCore;
using MyPolyglotCore.Words;
using MyPolyglotCore.Words.Pronouns;
using Xunit;

namespace MyPolyglotCoreTests.RecognizerTests
{
    public class TryToRecognizeShould
    {
        private Random _random;

        public TryToRecognizeShould()
        {
            _random = new Random();
        }

        [Theory]
        [InlineData(typeof(SubjectPronoun))]
        [InlineData(typeof(ObjectPronoun))]
        [InlineData(typeof(PossessiveAdjective))]
        [InlineData(typeof(PossessivePronoun))]
        [InlineData(typeof(ReflexivePronoun))]
        [InlineData(typeof(Determiner))]
        [InlineData(typeof(Verb))]
        public void FindWordFromVocabularyInPhraseAndAddToRecognizedWords(Type type)
        {
            var randomWordFromVocabulary = GetRandomWordFromVocabulary(type);

            var engPhrase =
                $",,.1 s,t! tr , starst nsetnrsit!ta stra {randomWordFromVocabulary.Text}, 2 arstar";

            var recognizer = new Recognizer(engPhrase);

            recognizer.TryToRecognize();

            Assert.Contains(randomWordFromVocabulary, recognizer.RecognizedWords);

            foreach (var unrecognizedWord in recognizer.UnrecognizedWords)
            {
                Assert.DoesNotContain(unrecognizedWord, recognizer.RecognizedWords);
            }
        }

        [Theory]
        [InlineData(typeof(SubjectPronoun))]
        [InlineData(typeof(ObjectPronoun))]
        [InlineData(typeof(PossessiveAdjective))]
        [InlineData(typeof(PossessivePronoun))]
        [InlineData(typeof(ReflexivePronoun))]
        [InlineData(typeof(Determiner))]
        [InlineData(typeof(Verb))]
        public void FindWordsNotFromVocabularyInPhraseAndAddToUnRecognizedWords(Type type)
        {
            var randomWordFromVocabulary = GetRandomWordFromVocabulary(type);

            var engPhrase =
                $",,.1 s,t! tr , starst nsetnrsit!ta stra {randomWordFromVocabulary.Text}, 2 arstar";

            var recognizer = new Recognizer(engPhrase);

            recognizer.TryToRecognize();

            foreach (var unrecognizedWord in recognizer.UnrecognizedWords)
            {
                Assert.Contains(unrecognizedWord, recognizer.UnrecognizedWords);
            }

            Assert.DoesNotContain(randomWordFromVocabulary, recognizer.UnrecognizedWords);
        }

        [Theory]
        [InlineData(typeof(SubjectPronoun))]
        [InlineData(typeof(ObjectPronoun))]
        [InlineData(typeof(PossessiveAdjective))]
        [InlineData(typeof(PossessivePronoun))]
        [InlineData(typeof(ReflexivePronoun))]
        [InlineData(typeof(Determiner))]
        [InlineData(typeof(Verb))]
        public void DoesNotContainNullOrEmptyStrings(Type type)
        {
            var randomWordFromVocabulary = GetRandomWordFromVocabulary(type);

            var engPhrase =
                $",,.1 s,t! tr , starst nsetnrsit!ta stra {randomWordFromVocabulary.Text}, 2 arstar";

            var recognizer = new Recognizer(engPhrase);

            recognizer.TryToRecognize();

            var words = recognizer.RecognizedWords.Concat(recognizer.UnrecognizedWords);

            foreach (var word in words)
            {
                Assert.NotNull(word);
                Assert.False(string.IsNullOrEmpty(word.Text));
            }
        }

        private Word GetRandomWordFromVocabulary(Type typeOfVocabulary)
        {
            var vocabulary = Vocabulary.GetVocabulary(typeOfVocabulary);

            return vocabulary.ToList()[_random.Next(vocabulary.Count)];
        }
    }
}
