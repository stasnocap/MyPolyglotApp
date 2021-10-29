using MyPolyglotCore;
using Xunit;

namespace MyPolyglotCoreTests.OptionsGeneratorTests.GenerateOptionsShould
{
    public class GenerateOptionsForComparisonAdjective : OptionsChecker
    {
        [Fact]
        public void ReturnAllComparisonAdjectiveForms()
        {
            var randomComparisonAdjective = RandomWordHelper.GetRandomComparisonAdjective();

            var comparisonAdjectiveForms = new string[]
            {
                randomComparisonAdjective.Text,
                randomComparisonAdjective.ComparativeForm,
                randomComparisonAdjective.SuperlativeForm,
            };

            var options = _optionsGenerator.GetOptions(randomComparisonAdjective);

            foreach (var comparisonAdjectiveForm in comparisonAdjectiveForms)
            {
                Assert.Contains(comparisonAdjectiveForm, options);
            }
        }
    }
}
