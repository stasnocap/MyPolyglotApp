﻿using System;
using System.Collections.Generic;
using System.Linq;
using MyPolyglotCore;
using MyPolyglotCore.Interfaces;
using MyPolyglotCore.Words;
using Xunit;

namespace MyPolyglotCoreTests._recognizerTests
{

    public class RecognizeShould
    {
        private Random _random = new Random();
        private IRecognizer _recognizer = new Recognizer();

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
        public void RecognizeDemonstrativePronounInPhrase()
        {
            var randomWordFromVocabulary = RandomWordHelper.GetRandomDemonstrativePronoun();
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

        [Fact]
        public void RecognizeFrequencyAdverbByText()
        {
            var randomWordFromVocabulary = RandomWordHelper.GetRandomFrequencyAdverb();
            CheckIfGivenWordHadRecognized(randomWordFromVocabulary);
        }

        [Fact]
        public void RecognizeIntensifierAdverbByText()
        {
            var randomWordFromVocabulary = RandomWordHelper.GetRandomIntensifierAdverb();
            CheckIfGivenWordHadRecognized(randomWordFromVocabulary);
        }

        [Fact]
        public void RecognizeMannerAdverbByText()
        {
            var randomWordFromVocabulary = RandomWordHelper.GetRandomMannerAdverb();
            CheckIfGivenWordHadRecognized(randomWordFromVocabulary);
        }

        [Fact]
        public void RecognizeTellHowItHappenedAdverbByText()
        {
            var randomWordFromVocabulary = RandomWordHelper.GetRandomTellHowItHappendAdverb();
            CheckIfGivenWordHadRecognized(randomWordFromVocabulary);
        }

        [Fact]
        public void RecognizeTellTheExtentOfTheActionAdverbByText()
        {
            var randomWordFromVocabulary = RandomWordHelper.GetRandomTellTheExtentOfTheActionAdverb();
            CheckIfGivenWordHadRecognized(randomWordFromVocabulary);
        }

        [Fact]
        public void RecognizeTellWhenItHappenedAdverbByText()
        {
            var randomWordFromVocabulary = RandomWordHelper.GetRandomTellWhenItHappendAdverb();
            CheckIfGivenWordHadRecognized(randomWordFromVocabulary);
        }

        [Fact]
        public void RecognizeTellWhereItHappenedAdverbByText()
        {
            var randomWordFromVocabulary = RandomWordHelper.GetRandomTellWhereItHappendAdverb();
            CheckIfGivenWordHadRecognized(randomWordFromVocabulary);
        }

        [Fact]
        public void RecognizeNounByText()
        {
            var randomWordFromVocabulary = RandomWordHelper.GetRandomNoun();
            CheckIfGivenWordHadRecognized(randomWordFromVocabulary);
        }

        [Fact]
        public void RecognizeAdjectiveByText()
        {
            var randomWordFromVocabulary = RandomWordHelper.GetRandomAdjective();
            CheckIfGivenWordHadRecognized(randomWordFromVocabulary);
        }

        [Fact]
        public void RecognizeCompoundByText()
        {
            var randomWordFromVocabulary = RandomWordHelper.GetRandomCompound();
            CheckIfGivenWordHadRecognized(randomWordFromVocabulary);
        }

        private void CheckIfGivenWordHadRecognized(Word word)
        {
            var engPhrase =
                $",,.1 s,t! tr , starst nsetnrsit!ta stra {word.Text}, 2 arstar";

            _recognizer.Recognize(engPhrase);

            Assert.Collection(_recognizer.RecognizedWords, x => Assert.Equal(x, word));
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

            _recognizer.Recognize(engPhrase);

            foreach (var unrecognizedWord in unrecognizedWords)
            {
                Assert.Contains(unrecognizedWord, _recognizer.UnrecognizedWords);
            }
        }

        [Fact]
        public void RecognizeIrregularVerbByPastForm()
        {
            var verb = RandomWordHelper.GetRandomIrregularVerb();

            _recognizer.Recognize("rastr " + verb.PastForm + " strs");

            Assert.Collection(_recognizer.RecognizedWords, x => Assert.Equal(x, verb));
        }

        [Fact]
        public void RecognizeIrregularVerbByPastParticleForm()
        {
            var verb = RandomWordHelper.GetRandomIrregularVerb();

            _recognizer.Recognize("rastr " + verb.PastParticipleForm + " strs");

            Assert.Collection(_recognizer.RecognizedWords, x => Assert.Equal(x, verb));
        }

        [Fact]
        public void RecognizeIrregularVerbByPresentParticipleForm()
        {
            var verb = RandomWordHelper.GetRandomIrregularVerb();

            _recognizer.Recognize("rastr " + verb.PresentParticipleForm + " strs");

            Assert.Collection(_recognizer.RecognizedWords, x => Assert.Equal(x, verb));
        }

        [Fact]
        public void RecognizeIrregularVerbByThirdPersonForm()
        {
            var verb = RandomWordHelper.GetRandomIrregularVerb();

            _recognizer.Recognize("rastr " + verb.ThirdPersonForm + " strs");

            Assert.Collection(_recognizer.RecognizedWords, x => Assert.Equal(x, verb));
        }

        [Fact]
        public void RecognizePrimaryVerbByShortNegativeForms()
        {
            var randomPrimaryVerb = RandomWordHelper.GetRandomPrimaryVerb();
            var shortNegativeForms = randomPrimaryVerb.ShortNegativeForms.ToList();

            var randomShortNegativeForm = shortNegativeForms[_random.Next(shortNegativeForms.Count)];
            _recognizer.Recognize("rastr " + randomShortNegativeForm + " strs");

            Assert.Collection(_recognizer.RecognizedWords, x => Assert.Equal(x, randomPrimaryVerb));
        }

        [Fact]
        public void RecognizePrimaryVerbByFullNegativeForms()
        {
            var randomPrimaryVerb = RandomWordHelper.GetRandomPrimaryVerb();
            var fullNegativeForms = randomPrimaryVerb.FullNegativeForms.ToList();

            var randomFullNegativeForm = fullNegativeForms[_random.Next(fullNegativeForms.Count)];
            _recognizer.Recognize("rastr " + randomFullNegativeForm + " strs");

            Assert.Collection(_recognizer.RecognizedWords, x => Assert.Equal(x, randomPrimaryVerb));
        }

        [Fact]
        public void RecognizePrimaryVerbByAdditionalForms()
        {
            var primaryVerbBe = Vocabulary.PrimaryVerbs.First(x => x.Text == "be");

            var randomWordFromAdditionalForms = primaryVerbBe.AdditionalForms.ElementAt(_random.Next(primaryVerbBe.AdditionalForms.Count()));
            _recognizer.Recognize("rastr " + randomWordFromAdditionalForms + " strs");

            Assert.Collection(_recognizer.RecognizedWords, x => Assert.Equal(x, primaryVerbBe));
        }

        [Fact]
        public void RecognizeModalVerbByNegativeForm()
        {
            var modalVerb = RandomWordHelper.GetRandomModalVerb();
            _recognizer.Recognize("rstrs " + modalVerb.ShortNegativeForm + " rtst");

            Assert.Collection(_recognizer.RecognizedWords, x => Assert.Equal(x, modalVerb));
        }

        [Fact]
        public void RecognizeComparativeAdjectiveByRootForm()
        {
            var comparisonAdjective = RandomWordHelper.GetRandomComparisonAdjective();
            _recognizer.Recognize("rstrs " + comparisonAdjective.Text + " rtst");

            Assert.Collection(_recognizer.RecognizedWords, x => Assert.Equal(x, comparisonAdjective));
        }

        [Fact]
        public void RecognizeComparativeAdjectiveByComparativeForm()
        {
            var comparisonAdjective = RandomWordHelper.GetRandomComparisonAdjective();
            _recognizer.Recognize("rstrs " + comparisonAdjective.ComparativeForm + " rtst");

            Assert.Collection(_recognizer.RecognizedWords, x => Assert.Equal(x, comparisonAdjective));
        }

        [Fact]
        public void RecognizeComparativeAdjectiveBySuperlativeForm()
        {
            var comparisonAdjective = RandomWordHelper.GetRandomComparisonAdjective();
            _recognizer.Recognize("rstrs " + comparisonAdjective.SuperlativeForm + " rtst");

            Assert.Collection(_recognizer.RecognizedWords, x => Assert.Equal(x, comparisonAdjective));
        }

        [Fact]
        public void MakePronounRememberFromWhatItWasRecognized()
        {
            AssertIfWordRememberFromWhatItWasRecognized(typeof(Pronoun));
        }

        [Fact]
        public void MakeAdverbRememberFromWhatItWasRecognized()
        {
            AssertIfWordRememberFromWhatItWasRecognized(typeof(Adverb));
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

        [Fact]
        public void MakeCompoundRememberFromWhatItWasRecognized()
        {
            AssertIfWordRememberFromWhatItWasRecognized(typeof(Compound));
        }

        private void AssertIfWordRememberFromWhatItWasRecognized(Type typeOfWord)
        {
            var randomWordFromVocabulary = typeOfWord.GetRandomWord();

            _recognizer.Recognize("rstrs " + randomWordFromVocabulary.Text + " rtst");

            Assert.Equal(randomWordFromVocabulary.Text, _recognizer.RecognizedWords.First().FromWhatItWasRecognized);
        }
    }
}
