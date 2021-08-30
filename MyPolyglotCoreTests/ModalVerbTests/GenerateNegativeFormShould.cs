using MyPolyglotCore.Words;
using Xunit;

namespace MyPolyglotCoreTests.ModalVerbTests
{
    public class GenerateNegativeFormShould
    {
        [Theory]
        [InlineData("can", "can't")]
        [InlineData("could", "couldn't")]
        [InlineData("may", "may not")]
        [InlineData("might", "mightn't")]
        [InlineData("will", "won't")]
        [InlineData("shall", "shall not")]
        [InlineData("would", "wouldn't")]
        [InlineData("should", "shouldn't")]
        [InlineData("must", "mustn't")]
        public void GenerateCorrectly(string affirmativeForm, string negativeForm)
        {
            var modalVerb = new ModalVerb(affirmativeForm);

            Assert.Equal(negativeForm, modalVerb.NegativeForm);
        }
    }
}
