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
            var randomWordFromVocabulary = RandomWordHelper.GetRandomSubjectPronoun();
            CheckIfWordWasRecognizedByText(randomWordFromVocabulary);
        }

        [Fact]
        public void RecognizeObjectPronounInPhrase()
        {
            var randomWordFromVocabulary = RandomWordHelper.GetRandomObjectPronoun();
            CheckIfWordWasRecognizedByText(randomWordFromVocabulary);
        }

        [Fact]
        public void RecognizePossessiveAdjectiveInPhrase()
        {
            var randomWordFromVocabulary = RandomWordHelper.GetRandomPossessiveAdjective();
            CheckIfWordWasRecognizedByText(randomWordFromVocabulary);
        }

        [Fact]
        public void RecognizePossessivePronounInPhrase()
        {
            var randomWordFromVocabulary = RandomWordHelper.GetRandomPossessivePronoun();
            CheckIfWordWasRecognizedByText(randomWordFromVocabulary);
        }

        [Fact]
        public void RecognizeDemonstrativePronounInPhrase()
        {
            var randomWordFromVocabulary = RandomWordHelper.GetRandomDemonstrativePronoun();
            CheckIfWordWasRecognizedByText(randomWordFromVocabulary);
        }

        [Fact]
        public void RecognizeReflexivePronounInPhrase()
        {
            var randomWordFromVocabulary = RandomWordHelper.GetRandomReflexivePronoun();
            CheckIfWordWasRecognizedByText(randomWordFromVocabulary);
        }

        [Fact]
        public void DoPronounRememberFromWhatItWasRecognized()
        {
            CheckIfWordRememberFromWhatItWasRecognized(typeof(Pronoun));
        }
    }
}
