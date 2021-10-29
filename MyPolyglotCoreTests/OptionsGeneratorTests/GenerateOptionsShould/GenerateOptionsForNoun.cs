using MyPolyglotCore;
using System.Linq;
using Xunit;

namespace MyPolyglotCoreTests.OptionsGeneratorTests.GenerateOptionsShould
{
    public class GenerateOptionsForNoun : OptionsChecker
    {
        [Fact]
        public void GivenNounRecognizedFromPluralForm_ReturnFivePluralFormsFromNounVocabularyWithRightAnswer()
        {
            var randomNoun = RandomWordHelper.GetRandomNoun();
            randomNoun.WasRecognizedFromPluralForm = true;

            var options = _optionsGenerator.GetOptions(randomNoun);

            foreach (var option in options)
            {
                if (randomNoun.PluralForm == option)
                {
                    continue;
                }

                Assert.Contains(option, Vocabulary.GetNounVocabulary().Select(x => x.PluralForm));
            }

            Assert.Contains(randomNoun.PluralForm, options);
        }

        [Fact]
        public void GivenNounRecognizedFromSingleForm_ReturnFiveSingleFormsFromNounVocabularyWithRightAnswer()
        {
            var randomNoun = RandomWordHelper.GetRandomNoun();
            randomNoun.WasRecognizedFromPluralForm = true;

            var options = _optionsGenerator.GetOptions(randomNoun);

            foreach (var option in options)
            {
                if (randomNoun.Text == option)
                {
                    continue;
                }

                Assert.Contains(option, Vocabulary.GetNounVocabulary().Select(x => x.Text));
            }

            Assert.Contains(randomNoun.Text, options);
        }

        [Fact]
        public void GivenNounRecognizedByPluralForm_ReturnFivePluralFormsFromNounVocabularyWithRightAnswer()
        {
            var randomNoun = RandomWordHelper.GetRandomNoun();
            randomNoun.FromWhatItWasRecognized = randomNoun.PluralForm;

            var options = _optionsGenerator.GetOptions(randomNoun);

            foreach (var option in options)
            {
                if (randomNoun.PluralForm == option)
                {
                    continue;
                }

                Assert.Contains(option, Vocabulary.GetNounVocabulary().Select(x => x.PluralForm));
            }

            Assert.Contains(randomNoun.PluralForm, options);
        }

        [Fact]
        public void GivenNounRecognizedBySingleFrom_ReturnFiveSingleFormsFromNounVocabularyWithRightAnswer()
        {
            var randomNoun = RandomWordHelper.GetRandomNoun();
            randomNoun.FromWhatItWasRecognized = randomNoun.Text;

            var options = _optionsGenerator.GetOptions(randomNoun);

            foreach (var option in options)
            {
                if (randomNoun.Text == option)
                {
                    continue;
                }

                Assert.Contains(option, Vocabulary.GetNounVocabulary().Select(x => x.Text));
            }

            Assert.Contains(randomNoun.Text, options);
        }

        [Fact]
        public void GivenOccupationRecognizedFromSingleForm_ReturnFiveSingleFormsFromOccupationsVocabularyWithRightAnswer()
        {
            var randomOccupation = RandomWordHelper.GetRandomOccupation();
            randomOccupation.FromWhatItWasRecognized = randomOccupation.Text;

            var options = _optionsGenerator.GetOptions(randomOccupation);

            foreach (var option in options)
            {
                if (option == randomOccupation.Text)
                {
                    continue;
                }

                Assert.Contains(option, Vocabulary.Occupations.Select(x => x.Text));
            }

            Assert.Contains(randomOccupation.Text, options);
        }

        [Fact]
        public void GivenOccupationRecognizedFromPluralForm_ReturnFivePluralFormsFromOccupationsVocabularyWithRightAnswer()
        {
            var randomOccupation = RandomWordHelper.GetRandomOccupation();
            randomOccupation.FromWhatItWasRecognized = randomOccupation.PluralForm;

            var options = _optionsGenerator.GetOptions(randomOccupation);

            foreach (var option in options)
            {
                if (option == randomOccupation.PluralForm)
                {
                    continue;
                }

                Assert.Contains(option, Vocabulary.Occupations.Select(x => x.PluralForm));
            }

            Assert.Contains(randomOccupation.PluralForm, options);
        }

        [Fact]
        public void GivenDayPartRecognizedFromSingleForm_ReturnAllWordsFromDayPartsVocabulary()
        {
            var randomDayPart = RandomWordHelper.GetRandomDayPart();
            randomDayPart.FromWhatItWasRecognized = randomDayPart.Text;

            var options = _optionsGenerator.GetOptions(randomDayPart);

            foreach (var wordFromVocabulary in Vocabulary.DayParts)
            {
                Assert.Contains(wordFromVocabulary.Text, options);
            }
        }

        [Fact]
        public void GivenDayPartRecognizedFromPluralForm_ReturnAllWordsFromDayPartsVocabulary()
        {
            var randomDayPart = RandomWordHelper.GetRandomDayPart();
            randomDayPart.FromWhatItWasRecognized = randomDayPart.PluralForm;

            var options = _optionsGenerator.GetOptions(randomDayPart);

            foreach (var wordFromVocabulary in Vocabulary.DayParts)
            {
                Assert.Contains(wordFromVocabulary.PluralForm, options);
            }
        }
    }
}
