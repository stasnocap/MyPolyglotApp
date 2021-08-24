using System.Collections.Generic;
using System.Linq;
using MyPolyglotCore.Words;

namespace MyPolyglotCore
{
    public class Exercise
    {
        public IEnumerable<Word> Words { get; }

        private readonly Recognizer _recognizer;
        private readonly OptionsGenerator _optionsGenerator;
        private int wordCounter;

        public Exercise(string engPhrase, IEnumerable<Word> unrecognizedWords)
        {
            _optionsGenerator = new OptionsGenerator();
            wordCounter = 0;

            _recognizer = new Recognizer(engPhrase);
            _recognizer.Recognize();

            Words = OrderWords(unrecognizedWords);
        }

        public IEnumerable<string> NextOptions()
        {
            return wordCounter < Words.Count()
                ? _optionsGenerator.GetOptions(Words.ElementAt(wordCounter++))
                : Enumerable.Empty<string>();
        }

        private IEnumerable<Word> OrderWords(IEnumerable<Word> unrecognizedWords)
        {
            var unOrderedWords = _recognizer.RecognizedWords.Concat(unrecognizedWords);
            var words = _recognizer.SplitToWords();

            return words.SelectMany(x => unOrderedWords.Select(y => y.Equals(x) ? y : null)).Where(x => x != null);
        }
    }
}