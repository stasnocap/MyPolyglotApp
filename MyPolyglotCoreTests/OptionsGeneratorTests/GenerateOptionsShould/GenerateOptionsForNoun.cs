using MyPolyglotCore;
using MyPolyglotCore.Words;
using System.Linq;
using Xunit;

namespace MyPolyglotCoreTests.OptionsGeneratorTests.GenerateOptionsShould
{
    public class GenerateOptionsForNoun : OptionsChecker
    {
        [Fact]
        public void GivenNounRecognizedFromPluralForm_ReturnFivePluralFormsFromNounVocabularyWithRightAnswer()
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

                Assert.Contains(option, Vocabulary.GetNounVocabulary().Select(x => x.PluralForm));
            }

            Assert.Contains(noun.PluralForm, options);
        }

        [Fact]
        public void GivenNounRecognizedFromSingleForm_ReturnFiveSingleFormsFromNounVocabularyWithRightAnswer()
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

                Assert.Contains(option, Vocabulary.GetNounVocabulary().Select(x => x.Text));
            }

            Assert.Contains(noun.Text, options);
        }

        [Fact]
        public void GivenNounRecognizedByPluralForm_ReturnFivePluralFormsFromNounVocabularyWithRightAnswer()
        {
            var noun = RandomWordHelper.GetRandomNoun();
            noun.FromWhatItWasRecognized = noun.PluralForm;

            var options = _optionsGenerator.GetOptions(noun);

            foreach (var option in options)
            {
                if (noun.PluralForm == option)
                {
                    continue;
                }

                Assert.Contains(option, Vocabulary.GetNounVocabulary().Select(x => x.PluralForm));
            }

            Assert.Contains(noun.PluralForm, options);
        }

        [Fact]
        public void GivenNounRecognizedBySingleFrom_ReturnFiveSingleFormsFromNounVocabularyWithRightAnswer()
        {
            var noun = RandomWordHelper.GetRandomNoun();
            noun.FromWhatItWasRecognized = noun.Text;

            var options = _optionsGenerator.GetOptions(noun);

            foreach (var option in options)
            {
                if (noun.Text == option)
                {
                    continue;
                }

                Assert.Contains(option, Vocabulary.GetNounVocabulary().Select(x => x.Text));
            }

            Assert.Contains(noun.Text, options);
        }

        [Fact]
        public void GivenOccupationRecognizedFromSingleForm_ReturnFiveSingleFormsFromOccupationsVocabularyWithRightAnswer()
        {
            var occupation = RandomWordHelper.GetRandomOccupation();
            occupation.FromWhatItWasRecognized = occupation.Text;

            var options = _optionsGenerator.GetOptions(occupation);

            foreach (var option in options)
            {
                if (option == occupation.Text)
                {
                    continue;
                }

                Assert.Contains(option, Vocabulary.Occupations.Select(x => x.Text));
            }

            Assert.Contains(occupation.Text, options);
        }

        [Fact]
        public void GivenOccupationRecognizedFromPluralForm_ReturnFivePluralFormsFromOccupationsVocabularyWithRightAnswer()
        {
            var occupation = RandomWordHelper.GetRandomOccupation();
            occupation.FromWhatItWasRecognized = occupation.PluralForm;

            var options = _optionsGenerator.GetOptions(occupation);

            foreach (var option in options)
            {
                if (option == occupation.PluralForm)
                {
                    continue;
                }

                Assert.Contains(option, Vocabulary.Occupations.Select(x => x.PluralForm));
            }

            Assert.Contains(occupation.PluralForm, options);
        }

        [Fact]
        public void GivenDayPartRecognizedFromSingleForm_ReturnAllWordsFromDayPartsVocabulary()
        {
            var dayPart = RandomWordHelper.GetRandomDayPart();
            dayPart.FromWhatItWasRecognized = dayPart.Text;

            var options = _optionsGenerator.GetOptions(dayPart);

            foreach (var wordFromVocabulary in Vocabulary.DayParts)
            {
                Assert.Contains(wordFromVocabulary.Text, options);
            }
        }

        [Fact]
        public void GivenDayPartRecognizedFromPluralForm_ReturnAllWordsFromDayPartsVocabulary()
        {
            var dayPart = RandomWordHelper.GetRandomDayPart();
            dayPart.FromWhatItWasRecognized = dayPart.PluralForm;

            var options = _optionsGenerator.GetOptions(dayPart);

            foreach (var wordFromVocabulary in Vocabulary.DayParts)
            {
                Assert.Contains(wordFromVocabulary.PluralForm, options);
            }
        }
    }
}
