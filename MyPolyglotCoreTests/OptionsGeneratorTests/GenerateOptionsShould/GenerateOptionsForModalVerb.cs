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
            var randomModalVerb = RandomWordHelper.GetRandomModalVerb();

            randomModalVerb.FromWhatItWasRecognized = randomModalVerb.Text;

            var options = _optionsGenerator.GetOptions(randomModalVerb);

            Assert.Contains(randomModalVerb.Text, options);
        }

        [Fact]
        public void GivenModalVerbRecognizedFromPositiveForm_ReturnCollectionThatContainsRandomModalVerbsPositiveForms()
        {
            var randomModalVerb = RandomWordHelper.GetRandomModalVerb();

            randomModalVerb.FromWhatItWasRecognized = randomModalVerb.Text;

            var options = _optionsGenerator.GetOptions(randomModalVerb);

            foreach (var option in options)
            {
                Assert.Contains(option, Vocabulary.ModalVerbs.Select(x => x.Text));
            }
        }

        [Fact]
        public void GivenModalVerbRecognizedFromFullNegativeForm_ReturnCollectionWithPassedFullNegativeForm()
        {
            var randomModalVerb = RandomWordHelper.GetRandomModalVerb();

            randomModalVerb.FromWhatItWasRecognized = randomModalVerb.FullNegativeForm;

            var options = _optionsGenerator.GetOptions(randomModalVerb);

            Assert.Contains(randomModalVerb.FullNegativeForm, options);
        }

        [Fact]
        public void GivenModalVerbRecognizedFromFullNegativeForm_ReturnCollectionThatContainsRandomModalVerbsFullNegativeForms()
        {
            var randomModalVerb = RandomWordHelper.GetRandomModalVerb();

            randomModalVerb.FromWhatItWasRecognized = randomModalVerb.FullNegativeForm;

            var options = _optionsGenerator.GetOptions(randomModalVerb);

            foreach (var option in options)
            {
                Assert.Contains(option, Vocabulary.ModalVerbs.Select(x => x.FullNegativeForm));
            }
        }

        [Fact]
        public void GivenModalVerbRecognizedFromwShortNegativeForm_ReturnCollectionWithPassedShortNegativeForm()
        {
            var randomModalVerb = RandomWordHelper.GetRandomModalVerb();

            randomModalVerb.FromWhatItWasRecognized = randomModalVerb.ShortNegativeForm;

            var options = _optionsGenerator.GetOptions(randomModalVerb);

            Assert.Contains(randomModalVerb.ShortNegativeForm, options);
        }

        [Fact]
        public void GivenModalVerbRecognizedFromShortNegativeForm_ReturnCollectionThatContainsRandomModalVerbsShortNegativeForms()
        {
            var randomModalVerb = RandomWordHelper.GetRandomModalVerb();

            randomModalVerb.FromWhatItWasRecognized = randomModalVerb.ShortNegativeForm;

            var options = _optionsGenerator.GetOptions(randomModalVerb);

            if (randomModalVerb.Text == "may")
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
