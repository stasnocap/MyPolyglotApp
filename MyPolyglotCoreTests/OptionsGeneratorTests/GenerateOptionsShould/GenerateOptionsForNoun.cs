using MyPolyglotCore;
using System.Linq;
using Xunit;

namespace MyPolyglotCoreTests.OptionsGeneratorTests.GenerateOptionsShould
{
    public class GenerateOptionsForNoun : OptionsChecker
    {
        [Fact]
        public void GivenNounRecognizedFromPluralForm_ReturnFiveRandomPluralFormsFromNounVocabulary()
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
        }

        [Fact]
        public void GivenNounRecognizedFromPluralForm_ReturnRightPluralForm()
        {
            var randomNoun = RandomWordHelper.GetRandomNoun();
            randomNoun.WasRecognizedFromPluralForm = true;

            var options = _optionsGenerator.GetOptions(randomNoun);

            Assert.Contains(randomNoun.PluralForm, options);
        }

        [Fact]
        public void GivenNounRecognizedFromSingleForm_ReturnFiveRandomSingleFormsFromNounVocabulary()
        {
            var randomNoun = RandomWordHelper.GetRandomNoun();
            randomNoun.WasRecognizedFromPluralForm = false;

            var options = _optionsGenerator.GetOptions(randomNoun);

            foreach (var option in options)
            {
                if (randomNoun.Text == option)
                {
                    continue;
                }

                Assert.Contains(option, Vocabulary.GetNounVocabulary().Select(x => x.Text));
            }
        }

        [Fact]
        public void GivenNounRecognizedFromSingleForm_ReturnRightSingleForm()
        {
            var randomNoun = RandomWordHelper.GetRandomNoun();
            randomNoun.WasRecognizedFromPluralForm = false;

            var options = _optionsGenerator.GetOptions(randomNoun);

            Assert.Contains(randomNoun.Text, options);
        }

        [Fact]
        public void GivenOccupationRecognizedFromSingleForm_ReturnFiveRandomSingleFormsFromOccupationsVocabulary()
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
        public void GivenOccupationRecognizedFromSingleForm_ReturnRightSingleForm()
        {
            var randomOccupation = RandomWordHelper.GetRandomOccupation();
            randomOccupation.FromWhatItWasRecognized = randomOccupation.Text;

            var options = _optionsGenerator.GetOptions(randomOccupation);

            Assert.Contains(randomOccupation.Text, options);
        }

        [Fact]
        public void GivenOccupationRecognizedFromPluralForm_ReturnFiveRandomPluralFormsFromOccupationsVocabulary()
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
        }

        [Fact]
        public void GivenOccupationRecognizedFromPluralForm_ReturnRightPluralForm()
        {
            var randomOccupation = RandomWordHelper.GetRandomOccupation();
            randomOccupation.FromWhatItWasRecognized = randomOccupation.PluralForm;

            var options = _optionsGenerator.GetOptions(randomOccupation);

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

        [Fact]
        public void GivenwYearSeasonRecognizedFromSingleForm_ReturnAllWordsFroYearSeasonsVocabulary()
        {
            var randomYearSeason = RandomWordHelper.GetRandomYearSeason();
            randomYearSeason.FromWhatItWasRecognized = randomYearSeason.Text;

            var options = _optionsGenerator.GetOptions(randomYearSeason);

            foreach (var wordFromVocabulary in Vocabulary.YearSeasons)
            {
                Assert.Contains(wordFromVocabulary.Text, options);
            }
        }

        [Fact]
        public void GivenYearSeasonRecognizedFromPluralForm_ReturnAllWordsFromYearSeasonsVocabulary()
        {
            var randomYearSeason = RandomWordHelper.GetRandomYearSeason();
            randomYearSeason.FromWhatItWasRecognized = randomYearSeason.PluralForm;

            var options = _optionsGenerator.GetOptions(randomYearSeason);

            foreach (var wordFromVocabulary in Vocabulary.YearSeasons)
            {
                Assert.Contains(wordFromVocabulary.PluralForm, options);
            }
        }
    }
}
