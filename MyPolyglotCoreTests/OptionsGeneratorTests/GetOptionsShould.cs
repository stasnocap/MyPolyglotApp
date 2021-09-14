using System;
using System.Linq;
using MyPolyglotCore.Words;
using MyPolyglotCore.Words.Pronouns;
using MyPolyglotCoreTests;
using Xunit;

namespace MyPolyglotCore.Tests.OptionsGeneratorTests
{
    public class GetOptionsShould
    {
        private readonly Random _random = new Random();
        private readonly OptionsGenerator _optionsGenerator = new OptionsGenerator();

        [Fact]
        public void GivenSubjectPronoun_ReturnAllWordsFromSubjectPronounVocabulary()
        {
            var word = new SubjectPronoun("no matter");
            CheckIfAllWordsFromVocabularyHadRecieved(word);
        }

        [Fact]
        public void GivenObjectPronoun_ReturnAllWordsFromObjectPronounVocabulary()
        {
            var word = new ObjectPronoun("no matter");
            CheckIfAllWordsFromVocabularyHadRecieved(word);
        }

        [Fact]
        public void GivenPossessiveAdjective_ReturnAllWordsFromPossessiveAdjectiveVocabulary()
        {
            var word = new PossessiveAdjective("no matter");
            CheckIfAllWordsFromVocabularyHadRecieved(word);
        }

        [Fact]
        public void GivenPossessivePronoun_ReturnAllWordsFromPossessivePronounVocabulary()
        {
            var word = new PossessivePronoun("no matter");
            CheckIfAllWordsFromVocabularyHadRecieved(word);
        }

        [Fact]
        public void GivenReflexivePronoun_ReturnAllWordsFromReflexivePronounVocabulary()
        {
            var word = new ReflexivePronoun("no matter");
            CheckIfAllWordsFromVocabularyHadRecieved(word);
        }

        [Fact]
        public void GivenDeterminer_ReturnAllWordsFromDeterminerVocabulary()
        {
            var word = new Determiner("no matter");
            CheckIfAllWordsFromVocabularyHadRecieved(word);
        }

        private void CheckIfAllWordsFromVocabularyHadRecieved(Word word)
        {
            var options = _optionsGenerator.GetOptions(word);
            var vocabulary = Vocabulary.GetVocabulary(word.GetType());
            foreach (var wordFromVocabulary in vocabulary)
            {
                Assert.Contains(wordFromVocabulary.Text, options);
            }
        }

        [Fact]
        public void GivenNoun_ReturnFiveWordsFromNounVocabularyWithRightAnswer()
        {
            var word = new Noun("no matter");
            CheckIfFiveWordsFromVocabularyWithRightWordHadRecieved(word);
        }

        [Fact]
        public void GivenAdjective_ReturnFiveWordsFromAdjectiveVocabularyWithRightAnswer()
        {
            var word = new Adjective("no matter");
            CheckIfFiveWordsFromVocabularyWithRightWordHadRecieved(word);
        }

        private void CheckIfFiveWordsFromVocabularyWithRightWordHadRecieved(Word word)
        {
            var options = _optionsGenerator.GetOptions(word);
            var vocabulary = Vocabulary.GetVocabulary(word.GetType());


            foreach (var option in options)
            {
                if (option == word.Text)
                {
                    continue;
                }

                Assert.Contains(option, vocabulary.Select(x => x.Text));
            }

            Assert.Contains(word.Text, options);
        }

        [Fact]
        public void GivenIrregularVerb_ReturnCollectionThatContainsTextPastFormPastParticipleFormPresentParticipleFormAndThirdPersonForm()
        {
            var irregularVerbVocabulary = Vocabulary.IrregularVerbs.ToList();
            var randomVerb = irregularVerbVocabulary[_random.Next(irregularVerbVocabulary.Count)];

            var verbForms = new string[]
            {
                randomVerb.Text,
                randomVerb.PastForm,
                randomVerb.PastParticipleForm,
                randomVerb.PresentParticipleForm,
                randomVerb.ThirdPersonForm,
            };

            var options = _optionsGenerator.GetOptions(randomVerb);

            foreach (var form in verbForms)
            {
                Assert.Contains(form, options);
            }
        }

        [Fact]
        public void GivenRegularVerb_ReturnCollectionThatContainsTextPastFormPastParticipleFormAndThirdPersonForm()
        {
            var verb = new Verb("play");

            var verbForms = new string[]
            {
                verb.Text,
                verb.PastForm,
                verb.PastParticipleForm,
                verb.ThirdPersonForm,
            };

            var options = _optionsGenerator.GetOptions(verb);

            foreach (var form in verbForms)
            {
                Assert.Contains(form, options);
            }
        }

        [Fact]
        public void GivenModalVerbRecognizedFromPositiveForm_ReturnCollectionWithPassedPositiveForm()
        {
            var modalVerb = (ModalVerb)typeof(ModalVerb).GetRandomWordFromVocabulary();

            modalVerb.FromWhatItWasRecognized = modalVerb.Text;

            var options = _optionsGenerator.GetOptions(modalVerb);

            Assert.Contains(modalVerb.Text, options);
        }

        [Fact]
        public void GivenModalVerbRecognizedFromPositiveForm_ReturnCollectionThatContainsRandomModalVerbsPositiveForms()
        {
            var modalVerb = (ModalVerb)typeof(ModalVerb).GetRandomWordFromVocabulary();

            modalVerb.FromWhatItWasRecognized = modalVerb.Text;

            var options = _optionsGenerator.GetOptions(modalVerb);

            foreach (var option in options)
            {
                Assert.Contains(option, Vocabulary.ModalVerbs.Select(x => x.Text));
            }
        }

        [Fact]
        public void GivenModalVerbRecognizedFromFullNegativeForm_ReturnCollectionWithPassedFullNegativeForm()
        {
            var modalVerb = (ModalVerb)typeof(ModalVerb).GetRandomWordFromVocabulary();

            modalVerb.FromWhatItWasRecognized = modalVerb.FullNegativeForm;

            var options = _optionsGenerator.GetOptions(modalVerb);

            Assert.Contains(modalVerb.FullNegativeForm, options);
        }

        [Fact]
        public void GivenModalVerbRecognizedFromFullNegativeForm_ReturnCollectionThatContainsRandomModalVerbsFullNegativeForms()
        {
            var modalVerb = (ModalVerb)typeof(ModalVerb).GetRandomWordFromVocabulary();

            modalVerb.FromWhatItWasRecognized = modalVerb.FullNegativeForm;

            var options = _optionsGenerator.GetOptions(modalVerb);

            foreach (var option in options)
            {
                Assert.Contains(option, Vocabulary.ModalVerbs.Select(x => x.FullNegativeForm));
            }
        }

        [Fact]
        public void GivenModalVerbRecognizedFromwShortNegativeForm_ReturnCollectionWithPassedShortNegativeForm()
        {
            var modalVerb = (ModalVerb)typeof(ModalVerb).GetRandomWordFromVocabulary();

            modalVerb.FromWhatItWasRecognized = modalVerb.ShortNegativeForm;

            var options = _optionsGenerator.GetOptions(modalVerb);

            Assert.Contains(modalVerb.ShortNegativeForm, options);
        }

        [Fact]
        public void GivenModalVerbRecognizedFromShortNegativeForm_ReturnCollectionThatContainsRandomModalVerbsShortNegativeForms()
        {
            var modalVerb = (ModalVerb)typeof(ModalVerb).GetRandomWordFromVocabulary();

            modalVerb.FromWhatItWasRecognized = modalVerb.ShortNegativeForm;

            var options = _optionsGenerator.GetOptions(modalVerb);

            foreach (var option in options)
            {
                Assert.Contains(option, Vocabulary.ModalVerbs.Select(x => x.ShortNegativeForm));
            }
        }
    }
}