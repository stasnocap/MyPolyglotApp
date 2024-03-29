﻿using MyPolyglotCore;
using MyPolyglotCore.Words;
using Xunit;

namespace MyPolyglotCoreTests.RecognizerTests.RecognizeShould
{
    public class RecognizeLetterNumber : RecognizingChecker
    {
        [Fact]
        public void RecognizeLetterNumberInPhrase()
        {
            var randomLetterNumber = RandomWordHelper.GetRandomLetterNumber();
            CheckIfWordWasRecognizedByText(randomLetterNumber);
        }

        [Fact]
        public void DoLetterNumberRememberFromWhatItWasRecognized()
        {
            CheckIfWordRememberFromWhatItWasRecognized(typeof(LetterNumber));
        }
    }
}
