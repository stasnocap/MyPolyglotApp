using MyPolyglotCore;
using MyPolyglotCore.Words;
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
            CheckIfAllWordsFromVocabularyWasReturned(word);
        }

        [Fact]
        public void GivenObjectPronoun_ReturnAllWordsFromObjectPronounVocabulary()
        {
            var word = new ObjectPronoun("no matter");
            CheckIfAllWordsFromVocabularyWasReturned(word);
        }

        [Fact]
        public void GivenPossessiveAdjective_ReturnAllWordsFromPossessiveAdjectiveVocabulary()
        {
            var word = new PossessiveAdjective("no matter");
            CheckIfAllWordsFromVocabularyWasReturned(word);
        }

        [Fact]
        public void GivenPossessivePronoun_ReturnAllWordsFromPossessivePronounVocabulary()
        {
            var word = new PossessivePronoun("no matter");
            CheckIfAllWordsFromVocabularyWasReturned(word);
        }

        [Fact]
        public void GivenReflexivePronoun_ReturnAllWordsFromReflexivePronounVocabulary()
        {
            var word = new ReflexivePronoun("no matter");
            CheckIfAllWordsFromVocabularyWasReturned(word);
        }

        [Fact]
        public void GivenDemonstrativePronoun_ReturnAllWordsFromDemonstrativePronounVocabulary()
        {
            var word = new DemonstrativePronoun("no matter");
            CheckIfAllWordsFromVocabularyWasReturned(word);
        }

        [Fact]
        public void GivenFrequencyAdverb_ReturnFiveWordsFromFrequencyAdverbsVocabularyWithRightAnswer()
        {
            var frequencyAdverb = RandomWordHelper.GetRandomFrequencyAdverb();
            CheckIfFiveWordsFromVocabularyWithRightWordWasReturned(frequencyAdverb, Vocabulary.FrequencyAdverbs);
        }

        [Fact]
        public void GivenIntensifierAdverb_ReturnFiveWordsFromIntensifierAdverbsVocabularyWithRightAnswer()
        {
            var intesifierAdverb = RandomWordHelper.GetRandomIntensifierAdverb();
            CheckIfFiveWordsFromVocabularyWithRightWordWasReturned(intesifierAdverb, Vocabulary.IntensifierAdverbs);
        }

        [Fact]
        public void GivenMannerAdverb_ReturnFiveWordsFromMannerAdverbsVocabularyWithRightAnswer()
        {
            var mannerAdverb = RandomWordHelper.GetRandomIntensifierAdverb();
            CheckIfFiveWordsFromVocabularyWithRightWordWasReturned(mannerAdverb, Vocabulary.MannerAdverbs);
        }

        [Fact]
        public void GivenTellHowItHappenedAdverb_ReturnFiveWordsFromTellHowItHappendAdverbsVocabularyWithRightAnswer()
        {
            var tellHowItHappenedAdverb = RandomWordHelper.GetRandomTellHowItHappendAdverb();
            CheckIfFiveWordsFromVocabularyWithRightWordWasReturned(tellHowItHappenedAdverb, Vocabulary.TellHowItHappenedAdverbs);
        }

        [Fact]
        public void GivenTellTheExtentOfTheActionAdverb_ReturnFiveWordsFromTellTheExtentOfTheActionAdverbsVocabularyWithRightAnswer()
        {
            var tellTheExtentOfTheActionAdverb = RandomWordHelper.GetRandomTellTheExtentOfTheActionAdverb();
            CheckIfFiveWordsFromVocabularyWithRightWordWasReturned(tellTheExtentOfTheActionAdverb, Vocabulary.TellTheExtentOfTheActionAdverbs);
        }

        [Fact]
        public void GivenTellWhenItHappenedAdverb_ReturnFiveWordsFromTellWhenItHappenedAdverbsVocabularyWithRightAnswer()
        {
            var tellWhenItHappenedAdverb = RandomWordHelper.GetRandomTellWhenItHappendAdverb();
            CheckIfFiveWordsFromVocabularyWithRightWordWasReturned(tellWhenItHappenedAdverb, Vocabulary.TellWhenItHappenedAdverbs);
        }

        [Fact]
        public void GivenTellWhereItHappenedAdverb_ReturnFiveWordsFromTellWhereItHappenedAdverbsVocabularyWithRightAnswer()
        {
            var tellWhereItHappendAdverb = RandomWordHelper.GetRandomTellWhereItHappendAdverb();
            CheckIfFiveWordsFromVocabularyWithRightWordWasReturned(tellWhereItHappendAdverb, Vocabulary.TellWhereItHappenedAdverbs);
        }

        [Fact]
        public void GivenSomeCompound_ReturnAllWordsFromSomeCompoundsVocabulary()
        {
            CheckIfAllWordsFromVocabularyHadRecieved(RandomWordHelper.GetRandomSomeCompound(), Vocabulary.SomeCompounds);
        }

        [Fact]
        public void GivenAnyCompound_ReturnAllWordsFromAnyCompoundsVocabulary()
        {
            CheckIfAllWordsFromVocabularyHadRecieved(RandomWordHelper.GetRandomAnyCompound(), Vocabulary.AnyCompounds);
        }

        [Fact]
        public void GivenEveryCompound_ReturnAllWordsFromEveryCompoundsVocabulary()
        {
            CheckIfAllWordsFromVocabularyHadRecieved(RandomWordHelper.GetRandomEveryCompound(), Vocabulary.EveryCompounds);
        }

        [Fact]
        public void GivenNoCompound_ReturnAllWordsFromNoCompoundsVocabulary()
        {
            CheckIfAllWordsFromVocabularyHadRecieved(RandomWordHelper.GetRandomNoCompound(), Vocabulary.NoCompounds);
        }

        [Fact]
        public void GivenDeterminer_ReturnAllWordsFromDeterminerVocabulary()
        {
            var word = new Determiner("no matter");
            CheckIfAllWordsFromVocabularyWasReturned(word);
        }

        private void CheckIfAllWordsFromVocabularyWasReturned(Word word)
        {
            CheckIfAllWordsFromVocabularyHadRecieved(word, Vocabulary.GetVocabulary(word.GetType()));
        }

        private void CheckIfAllWordsFromVocabularyHadRecieved(Word word, IEnumerable<Word> vocabulary)
        {
            var options = _optionsGenerator.GetOptions(word);
            foreach (var wordFromVocabulary in vocabulary)
            {
                Assert.Contains(wordFromVocabulary.Text, options);
            }
        }


        [Fact]
        public void GivenNounRecognizedFromPluralForm_ReturnFiveWordsPluralFormsFromNounVocabularyWithRightAnswer()
        {
            var noun = new Noun("no matter")
            {
                WasRecognizedFromPluralForm = true
            };

            var options = _optionsGenerator.GetOptions(noun);

            foreach (var option in options)
            {
                if (noun.PluralForm == option)
                {
                    continue;
                }

                Assert.Contains(option, Vocabulary.Nouns.Concat(Vocabulary.IrregularNouns).Select(x => x.PluralForm));
            }

            Assert.Contains(noun.PluralForm, options);
        }

        [Fact]
        public void GivenNounRecognizedFromSingleForm_ReturnFiveWordsSingleFormsFromNounVocabularyWithRightAnswer()
        {
            var noun = new Noun("no matter")
            {
                WasRecognizedFromPluralForm = false
            };

            var options = _optionsGenerator.GetOptions(noun);

            foreach (var option in options)
            {
                if (noun.Text == option)
                {
                    continue;
                }

                Assert.Contains(option, Vocabulary.Nouns.Concat(Vocabulary.IrregularNouns).Select(x => x.Text));
            }

            Assert.Contains(noun.Text, options);
        }

        [Fact]
        public void GivenPluralNounRecognizedNotByUserButByVocabulary_ReturnFiveWordsPluralFormsFromNounVocabularyWithRightAnswer()
        {
            var noun = new Noun("cat")
            {
                FromWhatItWasRecognized = "cats"
            };

            var options = _optionsGenerator.GetOptions(noun);

            foreach (var option in options)
            {
                if (noun.PluralForm == option)
                {
                    continue;
                }

                Assert.Contains(option, Vocabulary.Nouns.Concat(Vocabulary.IrregularNouns).Select(x => x.PluralForm));
            }

            Assert.Contains(noun.PluralForm, options);
        }

        [Fact]
        public void GivenSingleNounRecognizedNotByUserButByVocabulary_ReturnFiveWordsSingleFormsFromNounVocabularyWithRightAnswer()
        {
            var noun = new Noun("cat")
            {
                FromWhatItWasRecognized = "cat"
            };

            var options = _optionsGenerator.GetOptions(noun);

            foreach (var option in options)
            {
                if (noun.Text == option)
                {
                    continue;
                }

                Assert.Contains(option, Vocabulary.Nouns.Concat(Vocabulary.IrregularNouns).Select(x => x.Text));
            }

            Assert.Contains(noun.Text, options);
        }

        [Fact]
        public void GivenAdjective_ReturnFiveWordsFromAdjectiveVocabularyWithRightAnswer()
        {
            var word = new Adjective("no matter");
            CheckIfFiveWordsFromVocabularyWithRightWordWasReturned(word);
        }

        [Fact]
        public void GivenPreposition_ReturnFiveWordsFormPrepositionVocabularyWithRightAnswer()
        {
            var word = new Preposition("no matter");
            CheckIfFiveWordsFromVocabularyWithRightWordWasReturned(word);
        }

        private void CheckIfFiveWordsFromVocabularyWithRightWordWasReturned(Word word)
        {
            var vocabulary = Vocabulary.GetVocabulary(word.GetType());
            CheckIfFiveWordsFromVocabularyWithRightWordWasReturned(word, vocabulary);
        }

        private void CheckIfFiveWordsFromVocabularyWithRightWordWasReturned(Word word, IEnumerable<Word> vocabulary)
        {
            var options = _optionsGenerator.GetOptions(word);

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

            foreach (var shortNegativeForm in shortNegativeForms)
            {
                primaryVerb.FromWhatItWasRecognized = shortNegativeForm;

                var options = _optionsGenerator.GetOptions(primaryVerb);

                if (shortNegativeForm == "am not")
                {
                    foreach (var fullNegativeForms in primaryVerb.FullNegativeForms)
                    {
                        Assert.Contains(fullNegativeForms, options);
                    }
                    return;
                }

                Assert.Contains(shortNegativeForm, options);
            }

        }

    }
}
