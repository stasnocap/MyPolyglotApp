using System.Collections.Generic;
using System.Linq;
using MyPolyglotCore.Helpers;
using MyPolyglotCore.Interfaces;
using MyPolyglotCore.Words;

namespace MyPolyglotCore
{
    public class Exercise
    {
        public IEnumerable<Word> Words { get; }

        private readonly IRecognizer _recognizer;
        private readonly IOptionsGenerator _optionsGenerator;
        private int _wordCounter;

        public Exercise(string engPhrase, IEnumerable<Word> unrecognizedWords)
        {
            _optionsGenerator = new OptionsGenerator();
            _wordCounter = 0;

            _recognizer = new Recognizer();
            _recognizer.Recognize(engPhrase);

            Words = OrderWords(unrecognizedWords, engPhrase);
        }

        public IEnumerable<string> NextOptions()
        {
            return _wordCounter < Words.Count()
                ? _optionsGenerator.GetOptions(Words.ElementAt(_wordCounter++))
                : Enumerable.Empty<string>();
        }

        private IEnumerable<Word> OrderWords(IEnumerable<Word> unrecognizedWords, string engPhrase)
        {
            var unOrderedWords = _recognizer.RecognizedWords.Concat(unrecognizedWords);
            var words = engPhrase.SplitToWords();

            return words.SelectMany(x => unOrderedWords.Select(y => y.Equals(x) ? y : null)).Where(x => x != null);
        }
    }
}