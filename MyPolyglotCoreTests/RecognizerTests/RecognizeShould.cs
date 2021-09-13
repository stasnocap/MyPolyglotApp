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
        private List<Verb> _irregularVerbs;
        private List<Word> _recognizableWords;
        private List<PrimaryVerb> _primaryVerbs;

        public RecognizeShould()
        {
            _random = new Random();
            _irregularVerbs = Vocabulary.IrregularVerbs.ToList();
            _recognizableWords = Vocabulary.RecognizableVocabularies.ToList();
            _primaryVerbs = Vocabulary.PrimaryVerbs.ToList();
        }

        [Fact]
        public void RecognizeSubjectPronounInPhrase()
        {
            var randomWordFromVocabulary = GetRandomWordFromVocabulary(typeof(SubjectPronoun));
            CheckIfGivenWordHadRecognized(randomWordFromVocabulary);
        }

        [Fact]
        public void RecognizeObjectPronounInPhrase()
        {
            var randomWordFromVocabulary = GetRandomWordFromVocabulary(typeof(ObjectPronoun));
            CheckIfGivenWordHadRecognized(randomWordFromVocabulary);
        }

        [Fact]
        public void RecognizePossessiveAdjectiveInPhrase()
        {
            var randomWordFromVocabulary = GetRandomWordFromVocabulary(typeof(PossessiveAdjective));
            CheckIfGivenWordHadRecognized(randomWordFromVocabulary);
        }

        [Fact]
        public void RecognizePossessivePronounInPhrase()
        {
            var randomWordFromVocabulary = GetRandomWordFromVocabulary(typeof(PossessivePronoun));
            CheckIfGivenWordHadRecognized(randomWordFromVocabulary);
        }

        [Fact]
        public void RecognizeReflexivePronounInPhrase()
        {
            var randomWordFromVocabulary = GetRandomWordFromVocabulary(typeof(ReflexivePronoun));
            CheckIfGivenWordHadRecognized(randomWordFromVocabulary);
        }

        [Fact]
        public void RecognizeDeterminerInPhrase()
        {
            var randomWordFromVocabulary = GetRandomWordFromVocabulary(typeof(Determiner));
            CheckIfGivenWordHadRecognized(randomWordFromVocabulary);
        }

        [Fact]
        public void RecognizeVerbInPhrase()
        {
            var randomWordFromVocabulary = GetRandomWordFromVocabulary(typeof(Verb));
            CheckIfGivenWordHadRecognized(randomWordFromVocabulary);
        }

        [Fact]
        public void RecognizeModalVerbByAffirmativeForm()
        {
            var randomWordFromVocabulary = GetRandomWordFromVocabulary(typeof(ModalVerb));
            CheckIfGivenWordHadRecognized(randomWordFromVocabulary);
        }

        private Word GetRandomWordFromVocabulary(Type typeOfWord)
        {
            var vocabulary = Vocabulary.GetVocabulary(typeOfWord);
            return vocabulary.ToList()[_random.Next(vocabulary.Count)];
        }

        private void CheckIfGivenWordHadRecognized(Word word)
        {
            var engPhrase =
                $",,.1 s,t! tr , starst nsetnrsit!ta stra {word.Text}, 2 arstar";

            var recognizer = new Recognizer(engPhrase);
            recognizer.Recognize();

            Assert.Collection(recognizer.RecognizedWords, x => Assert.Equal(x, word));
        }

        [Fact]
        public void StoreUnrecognizedWords()
        {
            var engPhrase =
                $"arst aarst ,{GetRandomRecognizableWord()}, aaarst." +
                $"aaaarst {GetRandomRecognizableWord()}, aaaaarst " +
                $"aaaaaarst!ta stra {GetRandomRecognizableWord()}, ";

            var unrecognizedWords = new List<Word>()
            {
                new Word("arst"),
                new Word("aarst"),
                new Word("aaarst"),
                new Word("aaaarst"),
                new Word("aaaaarst"),
                new Word("aaaaaarst"),
                new Word("ta"),
                new Word("stra"),
            };

            var recognizer = new Recognizer(engPhrase);
            recognizer.Recognize();

            foreach (var unrecognizedWord in unrecognizedWords)
            {
                Assert.Contains(unrecognizedWord, recognizer.UnrecognizedWords);
            }
        }

        private string GetRandomRecognizableWord()
        {
            return _recognizableWords[_random.Next(_recognizableWords.Count)].Text;
        }

        [Fact]
        public void RecognizeIrregularVerbByPastForm()
        {
            var verb = GetRandomIrregularVerb();

            var recognizer = new Recognizer("rastr " + verb.PastForm + " strs");

            recognizer.Recognize();

            Assert.Collection(recognizer.RecognizedWords, x => Assert.Equal(x, verb));
        }

        [Fact]
        public void RecognizeIrregularVerbByPastParticleForm()
        {
            var verb = GetRandomIrregularVerb();

            var recognizer = new Recognizer("rastr " + verb.PastParticipleForm + " strs");

            recognizer.Recognize();

            Assert.Collection(recognizer.RecognizedWords, x => Assert.Equal(x, verb));
        }

        [Fact]
        public void RecognizeIrregularVerbByPresentParticipleForm()
        {
            var verb = GetRandomIrregularVerb();

            var recognizer = new Recognizer("rastr " + verb.PresentParticipleForm + " strs");

            recognizer.Recognize();

            Assert.Collection(recognizer.RecognizedWords, x => Assert.Equal(x, verb));
        }

        [Fact]
        public void RecognizeIrregularVerbByThirdPersonForm()
        {
            var verb = GetRandomIrregularVerb();

            var recognizer = new Recognizer("rastr " + verb.ThirdPersonForm + " strs");

            recognizer.Recognize();

            Assert.Collection(recognizer.RecognizedWords, x => Assert.Equal(x, verb));
        }

        private Verb GetRandomIrregularVerb()
        {
            return _irregularVerbs[_random.Next(_irregularVerbs.Count)];
        }

        [Fact]
        public void RecognizePrimaryVerbByNegativeForms()
        {
            var randomPrimaryVerb = _primaryVerbs[_random.Next(_primaryVerbs.Count)];

            var randomWordFromNegativeForms = randomPrimaryVerb.ShortNegativeForms.ElementAt(_random.Next(randomPrimaryVerb.ShortNegativeForms.Count()));
            var recognizer = new Recognizer("rastr " + randomWordFromNegativeForms + " strs");
            recognizer.Recognize();

            Assert.Collection(recognizer.RecognizedWords, x => Assert.Equal(x, randomPrimaryVerb));
        }

        [Fact]
        public void RecognizePrimaryVerbByAdditionalForms()
        {
            var primaryVerb = _primaryVerbs.Find(x => x.Text == "be");

            var randomWordFromAdditionalForms = primaryVerb.AdditionalForms.ElementAt(_random.Next(primaryVerb.AdditionalForms.Count()));
            var recognizer = new Recognizer("rastr " + randomWordFromAdditionalForms + " strs");
            recognizer.Recognize();

            Assert.Collection(recognizer.RecognizedWords, x => Assert.Equal(x, primaryVerb));
        }

        [Fact]
        public void RecognizeModalVerbByNegativeForm()
        {
            var modalVerb = GetRandomWordFromVocabulary(typeof(ModalVerb)) as ModalVerb;

            var recognizer = new Recognizer("rstrs " + modalVerb.ShortNegativeForm + " rtst");
            recognizer.Recognize();

            Assert.Collection(recognizer.RecognizedWords, x => Assert.Equal(x, modalVerb));
        }

        [Fact]
        public void MakeSubjectPronounRememberFromWhatItWasRecognized()
        {
            AssertIfWordRememberFromWhatItWasRecognized(typeof(SubjectPronoun));
        }

        [Fact]
        public void MakeObjectPronounRememberFromWhatItWasRecognized()
        {
            AssertIfWordRememberFromWhatItWasRecognized(typeof(ObjectPronoun));
        }

        [Fact]
        public void MakePossessiveAdjectiveRememberFromWhatItWasRecognized()
        {
            AssertIfWordRememberFromWhatItWasRecognized(typeof(PossessiveAdjective));
        }

        [Fact]
        public void MakePossessivePronounRememberFromWhatItWasRecognized()
        {
            AssertIfWordRememberFromWhatItWasRecognized(typeof(PossessivePronoun));
        }

        [Fact]
        public void MakeReflexivePronounRememberFromWhatItWasRecognized()
        {
            AssertIfWordRememberFromWhatItWasRecognized(typeof(ReflexivePronoun));
        }

        [Fact]
        public void MakeDeterminerRememberFromWhatItWasRecognized()
        {
            AssertIfWordRememberFromWhatItWasRecognized(typeof(Determiner));
        }

        [Fact]
        public void MakeIrregularVerbRememberFromWhatItWasRecognized()
        {
            AssertIfWordRememberFromWhatItWasRecognized(typeof(Verb));
        }

        [Fact]
        public void MakePrimaryVerbRememberFromWhatItWasRecognized()
        {
            AssertIfWordRememberFromWhatItWasRecognized(typeof(PrimaryVerb));
        }

        [Fact]
        public void MakeModalVerbRememberFromWhatItWasRecognized()
        {
            AssertIfWordRememberFromWhatItWasRecognized(typeof(ModalVerb));
        }

        private void AssertIfWordRememberFromWhatItWasRecognized(Type typeOfWord)
        {
            var randomWordFromVocabulary = GetRandomWordFromVocabulary(typeOfWord);

            var recognizer = new Recognizer("rstrs " + randomWordFromVocabulary.Text + " rtst");
            recognizer.Recognize();

            Assert.Equal(randomWordFromVocabulary.Text, recognizer.RecognizedWords.First().FromWhatItWasRecognized);
        }
    }
}
