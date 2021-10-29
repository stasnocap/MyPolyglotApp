using MyPolyglotCore;
using MyPolyglotCore.Words;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace MyPolyglotCoreTests.OptionsGeneratorTests.GenerateOptionsShould
{
    public class GenerateOptionsForVerb : OptionsChecker
    {
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
