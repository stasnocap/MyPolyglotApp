using MyPolyglotCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
