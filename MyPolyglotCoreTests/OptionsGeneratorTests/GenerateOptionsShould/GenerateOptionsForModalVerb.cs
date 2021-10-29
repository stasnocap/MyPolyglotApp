using MyPolyglotCore;
using System.Linq;
using Xunit;

namespace MyPolyglotCoreTests.OptionsGeneratorTests.GenerateOptionsShould
{
    public class GenerateOptionsForModalVerb : OptionsChecker
    {
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
    }
}
