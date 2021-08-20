using MyPolyglotCore;
using MyPolyglotCore.Words;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MyPolyglotCoreTests.RecognizerTests
{
    public class SplitWordsShould
    {
        private Random _random;
        private List<Word> _recognizableWords;

        public SplitWordsShould()
        {
            _random = new Random();
            _recognizableWords = Vocabulary.RecognizableVocabularies.ToList();
        }

        [Fact]
        public void NotContainsNullOrEmptyStrings()
        {
            var engPhrase =
                $"arst aarst ,{GetRandomRecognizableWord()}, aaarst." +
                $"aaaarst {GetRandomRecognizableWord()}, aaaaarst " +
                $"aaaaaarst!ta stra {GetRandomRecognizableWord()}, ";

            var recognizer = new Recognizer(engPhrase);
            recognizer.Recognize();

            var words = recognizer.RecognizedWords.Concat(recognizer.UnrecognizedWords);

            foreach (var word in words)
            {
                Assert.False(string.IsNullOrEmpty(word.Text));
            }
        }

        private string GetRandomRecognizableWord()
        {
            return _recognizableWords[_random.Next(_recognizableWords.Count)].Text;
        }
    }
}
