using System;
using System.Collections.Generic;
using System.Linq;
using MyPolyglotCore;
using MyPolyglotCore.Words;
using MyPolyglotCore.Words.Pronouns;
using Xunit;

namespace MyPolyglotCoreTests.RecognizerTests
{

    public class RecognizerShould
    {
        private Random _random;

        public RecognizerShould()
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
        [InlineData("PastForm")]
        [InlineData("PastParticipleForm")]
        [InlineData("PresentParticipleForm")]
        [InlineData("ThirdPersonForm")]
        [InlineData("AdditionalForms")]
        public void RecognizeVerbNotOnlyByTextButByAllOthersProperties(string propertyName)
        {
            foreach (var verb in Vocabulary.IrregularVerbs)
            {
                var text = verb.Text;
                var formOfVerb = verb.GetType().GetProperty(propertyName).GetValue(verb);

                var recognizer = new Recognizer("rastr " + formOfVerb + " strs");

                if (formOfVerb == null)
                {
                    return;
                }

                if (formOfVerb is IEnumerable<string>)
                {
                    foreach (var form in formOfVerb as IEnumerable<string>)
                    {
                        Assert.Contains(form, recognizer.RecognizedWords.Select(x => x.Text));
                    }
                }
                else
                {
                    Assert.Contains(recognizer.RecognizedWords, x => x.Text == text);
                }
            }
        }
    }
}
