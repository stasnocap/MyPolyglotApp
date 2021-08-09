using System;
using System.Collections.Generic;
using System.Linq;
using MyPolyglotCore;
using MyPolyglotCore.Words;
using MyPolyglotCore.Words.Pronouns;
using Xunit;

namespace MyPolyglotCoreTests.RecognizerTests
{

    public class RecognizeShould
    {
        private Random _random;

        public RecognizeShould()
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
            recognizer.Recognize();

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
            recognizer.Recognize();

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
            recognizer.Recognize();

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


        [Theory]
        [InlineData(nameof(Verb.PastForm))]
        [InlineData(nameof(Verb.PastParticipleForm))]
        [InlineData(nameof(Verb.PresentParticipleForm))]
        [InlineData(nameof(Verb.ThirdPersonForm))]
        public void RecognizeVerbNotOnlyByTextButByAllOthersProperties(string propertyName)
        {
            foreach (var verb in Vocabulary.IrregularVerbs)
            {
                var formOfVerb = verb.GetType().GetProperty(propertyName).GetValue(verb);

                var recognizer = new Recognizer("rastr " + formOfVerb + " strs");
                recognizer.Recognize();

                Assert.Contains(recognizer.RecognizedWords, x => x.Text == verb.Text);
            }
        }

        [Fact]
        public void RecognizePrimaryVerbByNegativeForms()
        {
            foreach (var primaryVerb in Vocabulary.PrimaryVerbs)
            {
                var randomWordFromNegativeForms = primaryVerb.NegativeForms.ElementAt(_random.Next(primaryVerb.NegativeForms.Count));
                var recognizer = new Recognizer("rastr " + randomWordFromNegativeForms + " strs");
                recognizer.Recognize();

                Assert.Contains(recognizer.RecognizedWords, x => x == primaryVerb);
            }
        }

        [Fact]
        public void RecognizePrimaryVerbByAdditionalForms()
        {
            foreach (var primaryVerb in Vocabulary.PrimaryVerbs)
            {
                if (primaryVerb.AdditionalForms.Any())
                {
                    var randomWordFromAdditionalForms = primaryVerb.AdditionalForms.ElementAt(_random.Next(primaryVerb.AdditionalForms.Count));
                    var recognizer = new Recognizer("rastr " + randomWordFromAdditionalForms + " strs");
                    recognizer.Recognize();

                    Assert.Contains(recognizer.RecognizedWords, x => x == primaryVerb);
                }
            }
        }
    }
}
