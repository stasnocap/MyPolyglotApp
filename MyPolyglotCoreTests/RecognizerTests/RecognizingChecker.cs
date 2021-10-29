using MyPolyglotCore;
using MyPolyglotCore.Interfaces;
using MyPolyglotCore.Words;
using System;
using System.Linq;
using Xunit;

namespace MyPolyglotCoreTests.RecognizerTests
{
    public class RecognizingChecker
    {
        protected Random _random = new Random();
        protected IRecognizer _recognizer = new Recognizer();

        protected void CheckIfWordWasRecognizedByText(Word word)
        {
            var engPhrase =
                $",,.1 s,t! tr , starst nsetnrsit!ta stra {word.Text}, 2 arstar";

            _recognizer.Recognize(engPhrase);

            Assert.Collection(_recognizer.RecognizedWords, x => Assert.Equal(x, word));
        }

        protected void CheckIfWordRememberFromWhatItWasRecognized(Type typeOfWord)
        {
            var randomWordFromVocabulary = typeOfWord.GetRandomWord();

            _recognizer.Recognize("rstrs " + randomWordFromVocabulary.Text + " rtst");

            Assert.Equal(randomWordFromVocabulary.Text, _recognizer.RecognizedWords.First().FromWhatItWasRecognized);
        }
    }
}
