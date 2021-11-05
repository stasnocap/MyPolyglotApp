using MyPolyglotCore;
using MyPolyglotCore.Words;
using Xunit;

namespace MyPolyglotCoreTests.RecognizerTests.RecognizeShould
{
    public class RecognizePronoun : RecognizingChecker
    {
        [Fact]
        public void RecognizeSubjectPronounInPhrase()
        {
            var randomSubjectPronoun = RandomWordHelper.GetRandomSubjectPronoun();
            CheckIfWordWasRecognizedByText(randomSubjectPronoun);
        }

        [Fact]
        public void RecognizeObjectPronounInPhrase()
        {
            var randomObjectPronoun = RandomWordHelper.GetRandomObjectPronoun();
            CheckIfWordWasRecognizedByText(randomObjectPronoun);
        }

        [Fact]
        public void RecognizePossessiveAdjectiveInPhrase()
        {
            var randomPossessiveAdjective = RandomWordHelper.GetRandomPossessiveAdjective();
            CheckIfWordWasRecognizedByText(randomPossessiveAdjective);
        }

        [Fact]
        public void RecognizePossessivePronounInPhrase()
        {
            var randomPossessivePronoun = RandomWordHelper.GetRandomPossessivePronoun();
            CheckIfWordWasRecognizedByText(randomPossessivePronoun);
        }

        [Fact]
        public void RecognizeDemonstrativePronounInPhrase()
        {
            var randomDemonstrativePronoun = RandomWordHelper.GetRandomDemonstrativePronoun();
            CheckIfWordWasRecognizedByText(randomDemonstrativePronoun);
        }

        [Fact]
        public void RecognizeReflexivePronounInPhrase()
        {
            var randomReflexivePronoun = RandomWordHelper.GetRandomReflexivePronoun();
            CheckIfWordWasRecognizedByText(randomReflexivePronoun);
        }

        [Fact]
        public void DoPronounRememberFromWhatItWasRecognized()
        {
            CheckIfWordRememberFromWhatItWasRecognized(typeof(Pronoun));
        }
    }
}
