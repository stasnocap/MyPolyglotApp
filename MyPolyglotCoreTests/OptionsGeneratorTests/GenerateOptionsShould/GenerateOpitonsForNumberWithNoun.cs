using MyPolyglotCore;
using MyPolyglotCore.Words;
using System.Linq;
using System.Text.RegularExpressions;
using Xunit;

namespace MyPolyglotCoreTests.OptionsGeneratorTests.GenerateOptionsShould
{
    public class GenerateOpitonsForNumberWithNoun : OptionsChecker
    {
        [Fact]
        public void ReturnOptionsThatContainsNumberFromNumberWithNounWord()
        {
            var numberWithNoun = new NumberWithNoun("3 hours");

            var options = _optionsGenerator.GetOptions(numberWithNoun);

            foreach (var option in options)
            {
                Assert.Contains("3", option);
            }
        }

        [Fact]
        public void ReturnOptionsThatContainsInPluralFormsInNounVocabulary()
        {
            var numberWithNoun = new NumberWithNoun("3 hours");

            var options = _optionsGenerator.GetOptions(numberWithNoun);

            var nounsPluralForms = Vocabulary.Nouns.Select(x => x.PluralForm);

            foreach (var option in options)
            {
                var word = Regex.Match(option, @"\w+$").Value;
                Assert.Contains(word, nounsPluralForms);
            }
        }

        [Fact]
        public void ReturnOptionsThatContainsRightWord()
        {
            var numberWithNoun = new NumberWithNoun("3 hours");

            CheckIfRightWordWasReturned(numberWithNoun);
        }
    }
}
