using MyPolyglotCore;
using MyPolyglotCore.Words;
using System.Linq;
using Xunit;

namespace MyPolyglotCoreTests.RecognizerTests.RecognizeShould
{
    public class RecognizeVerb : RecognizingChecker
    {
        [Fact]
        public void RecognizeIrregularVerbByText()
        {
            var randomWordFromVocabulary = RandomWordHelper.GetRandomIrregularVerb();
            CheckIfWordWasRecognizedByText(randomWordFromVocabulary);
        }

        [Fact]
        public void RecognizeIrregularVerbByPastForm()
        {
            var verb = RandomWordHelper.GetRandomIrregularVerb();

            _recognizer.Recognize("rastr " + verb.PastForm + " strs");

            Assert.Collection(_recognizer.RecognizedWords, x => Assert.Equal(x, verb));
        }

        [Fact]
        public void RecognizeIrregularVerbByPastParticleForm()
        {
            var verb = RandomWordHelper.GetRandomIrregularVerb();

            _recognizer.Recognize("rastr " + verb.PastParticipleForm + " strs");

            Assert.Collection(_recognizer.RecognizedWords, x => Assert.Equal(x, verb));
        }

        [Fact]
        public void RecognizeIrregularVerbByPresentParticipleForm()
        {
            var verb = RandomWordHelper.GetRandomIrregularVerb();

            _recognizer.Recognize("rastr " + verb.PresentParticipleForm + " strs");

            Assert.Collection(_recognizer.RecognizedWords, x => Assert.Equal(x, verb));
        }

        [Fact]
        public void RecognizeIrregularVerbByThirdPersonForm()
        {
            var verb = RandomWordHelper.GetRandomIrregularVerb();

            _recognizer.Recognize("rastr " + verb.ThirdPersonForm + " strs");

            Assert.Collection(_recognizer.RecognizedWords, x => Assert.Equal(x, verb));
        }

        [Fact]
        public void RecognizePrimaryVerbByShortNegativeForms()
        {
            var randomPrimaryVerb = RandomWordHelper.GetRandomPrimaryVerb();
            var shortNegativeForms = randomPrimaryVerb.ShortNegativeForms.ToList();

            var randomShortNegativeForm = shortNegativeForms[_random.Next(shortNegativeForms.Count)];
            _recognizer.Recognize("rastr " + randomShortNegativeForm + " strs");

            Assert.Collection(_recognizer.RecognizedWords, x => Assert.Equal(x, randomPrimaryVerb));
        }

        [Fact]
        public void RecognizePrimaryVerbByFullNegativeForms()
        {
            var randomPrimaryVerb = RandomWordHelper.GetRandomPrimaryVerb();
            var fullNegativeForms = randomPrimaryVerb.FullNegativeForms.ToList();

            var randomFullNegativeForm = fullNegativeForms[_random.Next(fullNegativeForms.Count)];
            _recognizer.Recognize("rastr " + randomFullNegativeForm + " strs");

            Assert.Collection(_recognizer.RecognizedWords, x => Assert.Equal(x, randomPrimaryVerb));
        }

        [Fact]
        public void RecognizePrimaryVerbByAdditionalForms()
        {
            var primaryVerbBe = Vocabulary.PrimaryVerbs.First(x => x.Text == "be");

            var randomWordFromAdditionalForms = primaryVerbBe.AdditionalForms.ElementAt(_random.Next(primaryVerbBe.AdditionalForms.Count()));
            _recognizer.Recognize("rastr " + randomWordFromAdditionalForms + " strs");

            Assert.Collection(_recognizer.RecognizedWords, x => Assert.Equal(x, primaryVerbBe));
        }

        [Fact]
        public void DoIrregularVerbRememberFromWhatItWasRecognized()
        {
            CheckIfWordRememberFromWhatItWasRecognized(typeof(Verb));
        }

        [Fact]
        public void DoPrimaryVerbRememberFromWhatItWasRecognized()
        {
            CheckIfWordRememberFromWhatItWasRecognized(typeof(PrimaryVerb));
        }
    }
}
