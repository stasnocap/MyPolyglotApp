using MyPolyglotCore;
using MyPolyglotCore.Words;
using MyPolyglotCore.Words.Adverbs;
using MyPolyglotCore.Words.Pronouns;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace MyPolyglotCoreTests.OptionsGeneratorTests
{
    public class GenerateOptionsShould
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
        public void GivenDemonstrativePronoun_ReturnAllWordsFromDemonstrativePronounVocabulary()
        {
            var word = new DemonstrativePronoun("no matter");
            CheckIfAllWordsFromVocabularyHadRecieved(word);
        }

        [Fact]
        public void GivenFrequencyAdverb_ReturnFiveWordsFromNounVocabularyWithRightAnswer()
        {
            var word = new FrequencyAdverb("no matter");
            CheckIfFiveWordsFromVocabularyWithRightWordHadRecieved(word);
        }

        [Fact]
        public void GivenIntensifierAdverb_ReturnFiveWordsFromNounVocabularyWithRightAnswer()
        {
            var word = new IntensifierAdverb("no matter");
            CheckIfFiveWordsFromVocabularyWithRightWordHadRecieved(word);
        }

        [Fact]
        public void GivenMannerAdverb_ReturnFiveWordsFromNounVocabularyWithRightAnswer()
        {
            var word = new MannerAdverb("no matter");
            CheckIfFiveWordsFromVocabularyWithRightWordHadRecieved(word);
        }

        [Fact]
        public void GivenTellHowItHappenedAdverb_ReturnFiveWordsFromNounVocabularyWithRightAnswer()
        {
            var word = new TellHowItHappenedAdverb("no matter");
            CheckIfFiveWordsFromVocabularyWithRightWordHadRecieved(word);
        }

        [Fact]
        public void GivenTellTheExtentOfTheActionAdverb_ReturnFiveWordsFromNounVocabularyWithRightAnswer()
        {
            var word = new TellTheExtentOfTheActionAdverb("no matter");
            CheckIfFiveWordsFromVocabularyWithRightWordHadRecieved(word);
        }

        [Fact]
        public void GivenTellWhenItHappenedAdverb_ReturnFiveWordsFromNounVocabularyWithRightAnswer()
        {
            var word = new TellWhenItHappenedAdverb("no matter");
            CheckIfFiveWordsFromVocabularyWithRightWordHadRecieved(word);
        }

        [Fact]
        public void GivenTellWhereItHappenedAdverb_ReturnFiveWordsFromNounVocabularyWithRightAnswer()
        {
            var word = new TellWhereItHappenedAdverb("no matter");
            CheckIfFiveWordsFromVocabularyWithRightWordHadRecieved(word);
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

        [Fact]
        public void GivenPreposition_ReturnFiveWordsFormPrepositionVocabularyWithRightAnswer()
        {
            var word = new Preposition("no matter");
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
            var randomIrregularVerb = RandomWordHelper.GetRandomIrregularVerb();

            var irregularVerbForms = new string[]
            {
                randomIrregularVerb.Text,
                randomIrregularVerb.PastForm,
                randomIrregularVerb.PastParticipleForm,
                randomIrregularVerb.PresentParticipleForm,
                randomIrregularVerb.ThirdPersonForm,
            };

            var options = _optionsGenerator.GetOptions(randomIrregularVerb);

            foreach (var form in irregularVerbForms)
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
            var modalVerb = RandomWordHelper.GetRandomModalVerb();

            modalVerb.FromWhatItWasRecognized = modalVerb.Text;

            var options = _optionsGenerator.GetOptions(modalVerb);

            Assert.Contains(modalVerb.Text, options);
        }

        [Fact]
        public void GivenModalVerbRecognizedFromPositiveForm_ReturnCollectionThatContainsRandomModalVerbsPositiveForms()
        {
            var modalVerb = RandomWordHelper.GetRandomModalVerb();

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
            var modalVerb = RandomWordHelper.GetRandomModalVerb();

            modalVerb.FromWhatItWasRecognized = modalVerb.FullNegativeForm;

            var options = _optionsGenerator.GetOptions(modalVerb);

            Assert.Contains(modalVerb.FullNegativeForm, options);
        }

        [Fact]
        public void GivenModalVerbRecognizedFromFullNegativeForm_ReturnCollectionThatContainsRandomModalVerbsFullNegativeForms()
        {
            var modalVerb = RandomWordHelper.GetRandomModalVerb();

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
            var modalVerb = RandomWordHelper.GetRandomModalVerb();

            modalVerb.FromWhatItWasRecognized = modalVerb.ShortNegativeForm;

            var options = _optionsGenerator.GetOptions(modalVerb);

            Assert.Contains(modalVerb.ShortNegativeForm, options);
        }

        [Fact]
        public void GivenModalVerbRecognizedFromShortNegativeForm_ReturnCollectionThatContainsRandomModalVerbsShortNegativeForms()
        {
            var modalVerb = RandomWordHelper.GetRandomModalVerb();

            modalVerb.FromWhatItWasRecognized = modalVerb.ShortNegativeForm;

            var options = _optionsGenerator.GetOptions(modalVerb);

            if (modalVerb.Text == "may")
            {
                foreach (var option in options)
                {
                    Assert.Contains(option, Vocabulary.ModalVerbs.Select(x => x.FullNegativeForm));
                }
                return;
            }

            foreach (var option in options)
            {
                Assert.Contains(option, Vocabulary.ModalVerbs.Select(x => x.ShortNegativeForm));
            }
        }

        [Fact]
        public void GivenPrimaryVerbBeRecognizedFromPositiveForm_ReturnCollectionWithPositiveForm()
        {
            var primaryVerb = (PrimaryVerb)Vocabulary.GetVocabulary(typeof(PrimaryVerb)).First(x => x.Text == "be");

            var positiveForms = new List<string>
            {
                primaryVerb.Text,
                primaryVerb.PastForm,
                primaryVerb.PastParticipleForm,
                primaryVerb.PresentParticipleForm,
                primaryVerb.ThirdPersonForm
            };

            positiveForms.AddRange(primaryVerb.AdditionalForms);

            primaryVerb.FromWhatItWasRecognized = positiveForms[_random.Next(positiveForms.Count)];

            var options = _optionsGenerator.GetOptions(primaryVerb);

            Assert.Contains(primaryVerb.FromWhatItWasRecognized, options);
        }

        [Fact]
        public void GivenPrimaryVerbBeRecognizedFormPositiveForm_ReturnCollectionThatContainsPositiveFormsFromPrimaryVerbBe()
        {
            var primaryVerb = (PrimaryVerb)Vocabulary.GetVocabulary(typeof(PrimaryVerb)).First(x => x.Text == "be");

            var positiveForms = new List<string>
            {
                primaryVerb.Text,
                primaryVerb.PastForm,
                primaryVerb.PastParticipleForm,
                primaryVerb.PresentParticipleForm,
                primaryVerb.ThirdPersonForm,
            };

            positiveForms.AddRange(primaryVerb.AdditionalForms);

            primaryVerb.FromWhatItWasRecognized = primaryVerb.Text;

            var options = _optionsGenerator.GetOptions(primaryVerb);

            foreach (var option in options)
            {
                Assert.Contains(option, positiveForms);
            }
        }

        [Theory]
        [InlineData("do")]
        [InlineData("have")]
        public void GivenPrimaryVerbRecognizedFromPositiveForm_ReturnCollectionWithAllPositiveForms(string primaryVerbText)
        {
            var primaryVerb = (PrimaryVerb)Vocabulary.GetVocabulary(typeof(PrimaryVerb)).First(x => x.Text == primaryVerbText);

            var positiveForms = new List<string>
            {
                primaryVerb.Text,
                primaryVerb.PastForm,
                primaryVerb.PastParticipleForm,
                primaryVerb.PresentParticipleForm,
                primaryVerb.ThirdPersonForm,
            };

            primaryVerb.FromWhatItWasRecognized = primaryVerb.Text;

            var options = _optionsGenerator.GetOptions(primaryVerb);

            foreach (var positiveForm in positiveForms)
            {
                Assert.Contains(positiveForm, options);
            }
        }

        [Fact]
        public void GivenPrimaryVerbRecognizedFromFullNegativeForm_ReturnCollectionThatContainsPrimaryVerbAllFullNegativeForms()
        {
            var primaryVerb = RandomWordHelper.GetRandomPrimaryVerb();

            var fullNegativeForms = primaryVerb.FullNegativeForms.ToList();

            primaryVerb.FromWhatItWasRecognized = fullNegativeForms[_random.Next(fullNegativeForms.Count)];

            var options = _optionsGenerator.GetOptions(primaryVerb);

            foreach (var fullNegativeForm in fullNegativeForms)
            {
                Assert.Contains(fullNegativeForm, options);
            }
        }

        [Fact]
        public void GivenPrimaryVerbRecognizedFromShortNegativeForm_ReturnCollectionThatContainsPrimaryVerbAllShortNegativeForms()
        {
            var primaryVerb = RandomWordHelper.GetRandomPrimaryVerb();

            var shortNegativeForms = primaryVerb.ShortNegativeForms.ToList();

            primaryVerb.FromWhatItWasRecognized = shortNegativeForms[_random.Next(shortNegativeForms.Count)];

            var options = _optionsGenerator.GetOptions(primaryVerb);

            foreach (var shortNegativeForm in shortNegativeForms)
            {
                Assert.Contains(shortNegativeForm, options);
            }
        }

    }
}
