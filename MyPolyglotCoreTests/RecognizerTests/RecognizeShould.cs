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
        private Random _random = new Random();

        [Fact]
        public void RecognizeSubjectPronounInPhrase()
        {
            var randomWordFromVocabulary = RandomWordHelper.GetRandomSubjectPronoun();
            CheckIfGivenWordHadRecognized(randomWordFromVocabulary);
        }

        [Fact]
        public void RecognizeObjectPronounInPhrase()
        {
            var randomWordFromVocabulary = RandomWordHelper.GetRandomObjectPronoun();
            CheckIfGivenWordHadRecognized(randomWordFromVocabulary);
        }

        [Fact]
        public void RecognizePossessiveAdjectiveInPhrase()
        {
            var randomWordFromVocabulary = RandomWordHelper.GetRandomPossessiveAdjective();
            CheckIfGivenWordHadRecognized(randomWordFromVocabulary);
        }

        [Fact]
        public void RecognizePossessivePronounInPhrase()
        {
            var randomWordFromVocabulary = RandomWordHelper.GetRandomPossessivePronoun();
            CheckIfGivenWordHadRecognized(randomWordFromVocabulary);
        }

        [Fact]
        public void RecognizeReflexivePronounInPhrase()
        {
            var randomWordFromVocabulary = RandomWordHelper.GetRandomReflexivePronoun();
            CheckIfGivenWordHadRecognized(randomWordFromVocabulary);
        }

        [Fact]
        public void RecognizeDeterminerInPhrase()
        {
            var randomWordFromVocabulary = RandomWordHelper.GetRandomDeterminer();
            CheckIfGivenWordHadRecognized(randomWordFromVocabulary);
        }

        [Fact]
        public void RecognizeIrregularVerbInPhrase()
        {
            var randomWordFromVocabulary = RandomWordHelper.GetRandomIrregularVerb();
            CheckIfGivenWordHadRecognized(randomWordFromVocabulary);
        }

        [Fact]
        public void RecognizeModalVerbByAffirmativeForm()
        {
            var randomWordFromVocabulary = RandomWordHelper.GetRandomModalVerb();
            CheckIfGivenWordHadRecognized(randomWordFromVocabulary);
        }

        [Fact]
        public void RecognizePrepositionByText()
        {
            var randomWordFromVocabulary = RandomWordHelper.GetRandomPreposition();
            CheckIfGivenWordHadRecognized(randomWordFromVocabulary);
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
                $"arst aarst ,{RandomWordHelper.GetRandomRecognizableWord()}, aaarst." +
                $"aaaarst {RandomWordHelper.GetRandomRecognizableWord()}, aaaaarst " +
                $"aaaaaarst!ta stra {RandomWordHelper.GetRandomRecognizableWord()}, ";

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

        [Fact]
        public void RecognizeIrregularVerbByPastForm()
        {
            var verb = RandomWordHelper.GetRandomIrregularVerb();

            var recognizer = new Recognizer("rastr " + verb.PastForm + " strs");

            recognizer.Recognize();

            Assert.Collection(recognizer.RecognizedWords, x => Assert.Equal(x, verb));
        }

        [Fact]
        public void RecognizeIrregularVerbByPastParticleForm()
        {
            var verb = RandomWordHelper.GetRandomIrregularVerb();

            var recognizer = new Recognizer("rastr " + verb.PastParticipleForm + " strs");

            recognizer.Recognize();

            Assert.Collection(recognizer.RecognizedWords, x => Assert.Equal(x, verb));
        }

        [Fact]
        public void RecognizeIrregularVerbByPresentParticipleForm()
        {
            var verb = RandomWordHelper.GetRandomIrregularVerb();

            var recognizer = new Recognizer("rastr " + verb.PresentParticipleForm + " strs");

            recognizer.Recognize();

            Assert.Collection(recognizer.RecognizedWords, x => Assert.Equal(x, verb));
        }

        [Fact]
        public void RecognizeIrregularVerbByThirdPersonForm()
        {
            var verb = RandomWordHelper.GetRandomIrregularVerb();

            var recognizer = new Recognizer("rastr " + verb.ThirdPersonForm + " strs");

            recognizer.Recognize();

            Assert.Collection(recognizer.RecognizedWords, x => Assert.Equal(x, verb));
        }

        [Fact]
        public void RecognizePrimaryVerbByShortNegativeForms()
        {
            var randomPrimaryVerb = RandomWordHelper.GetRandomPrimaryVerb();
            var shortNegativeForms = randomPrimaryVerb.ShortNegativeForms.ToList();

            var randomShortNegativeForm = shortNegativeForms[_random.Next(shortNegativeForms.Count)];
            var recognizer = new Recognizer("rastr " + randomShortNegativeForm + " strs");
            recognizer.Recognize();

            Assert.Collection(recognizer.RecognizedWords, x => Assert.Equal(x, randomPrimaryVerb));
        }

        [Fact]
        public void RecognizePrimaryVerbByFullNegativeForms()
        {
            var randomPrimaryVerb = RandomWordHelper.GetRandomPrimaryVerb();
            var fullNegativeForms = randomPrimaryVerb.FullNegativeForms.ToList();

            var randomFullNegativeForm = fullNegativeForms[_random.Next(fullNegativeForms.Count)];
            var recognizer = new Recognizer("rastr " + randomFullNegativeForm + " strs");
            recognizer.Recognize();

            Assert.Collection(recognizer.RecognizedWords, x => Assert.Equal(x, randomPrimaryVerb));
        }

        [Fact]
        public void RecognizePrimaryVerbByAdditionalForms()
        {
            var primaryVerbBe = Vocabulary.PrimaryVerbs.First(x => x.Text == "be");

            var randomWordFromAdditionalForms = primaryVerbBe.AdditionalForms.ElementAt(_random.Next(primaryVerbBe.AdditionalForms.Count()));
            var recognizer = new Recognizer("rastr " + randomWordFromAdditionalForms + " strs");
            recognizer.Recognize();

            Assert.Collection(recognizer.RecognizedWords, x => Assert.Equal(x, primaryVerbBe));
        }

        [Fact]
        public void RecognizeModalVerbByNegativeForm()
        {
            var modalVerb = RandomWordHelper.GetRandomModalVerb();
            var recognizer = new Recognizer("rstrs " + modalVerb.ShortNegativeForm + " rtst");
            recognizer.Recognize();

            Assert.Collection(recognizer.RecognizedWords, x => Assert.Equal(x, modalVerb));
        }

        [Fact]
        public void RecognizeComparativeAdjectiveByRootForm()
        {
            var comparisonAdjective = RandomWordHelper.GetRandomComparisonAdjective();
            var recognizer = new Recognizer("rstrs " + comparisonAdjective.Text + " rtst");
            recognizer.Recognize();

            Assert.Collection(recognizer.RecognizedWords, x => Assert.Equal(x, comparisonAdjective));
        }

        [Fact]
        public void RecognizeComparativeAdjectiveByComparativeForm()
        {
            var comparisonAdjective = RandomWordHelper.GetRandomComparisonAdjective();
            var recognizer = new Recognizer("rstrs " + comparisonAdjective.ComparativeForm + " rtst");
            recognizer.Recognize();

            Assert.Collection(recognizer.RecognizedWords, x => Assert.Equal(x, comparisonAdjective));
        }

        [Fact]
        public void RecognizeComparativeAdjectiveBySuperlativeForm()
        {
            var comparisonAdjective = RandomWordHelper.GetRandomComparisonAdjective();
            var recognizer = new Recognizer("rstrs " + comparisonAdjective.SuperlativeForm + " rtst");
            recognizer.Recognize();

            Assert.Collection(recognizer.RecognizedWords, x => Assert.Equal(x, comparisonAdjective));
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

        [Fact]
        public void MakePrepositionRememberFromWhatItWasRecognized()
        {
            AssertIfWordRememberFromWhatItWasRecognized(typeof(Preposition));
        }

        [Fact]
        public void MakeComparisonAdjectiveRememberFromWhatItWasRecognized()
        {
            AssertIfWordRememberFromWhatItWasRecognized(typeof(ComparisonAdjective));
        }

        private void AssertIfWordRememberFromWhatItWasRecognized(Type typeOfWord)
        {
            var randomWordFromVocabulary = typeOfWord.GetRandomWordFromVocabulary();

            var recognizer = new Recognizer("rstrs " + randomWordFromVocabulary.Text + " rtst");
            recognizer.Recognize();

            Assert.Equal(randomWordFromVocabulary.Text, recognizer.RecognizedWords.First().FromWhatItWasRecognized);
        }
    }
}
