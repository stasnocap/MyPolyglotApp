using System.Collections.Generic;
using System.IO.IsolatedStorage;
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
            var unorderedWords = _recognizer.RecognizedWords.Concat(unrecognizedWords);
            var words = engPhrase.SplitToWords();

            var orderedWords = words.SelectMany(word => unorderedWords.Where(unorderedWord => unorderedWord.Equals(word))).ToList();

            return RemoveDuplicate(orderedWords);
        }

        private IEnumerable<Word> RemoveDuplicate(IList<Word> orderedWords)
        {
            for (int i = 0; i < orderedWords.Count - 1; i++)
            {
                if (orderedWords[i].Equals(orderedWords[i + 1]))
                {
                    orderedWords.RemoveAt(i + 1);
                }
            }

            return orderedWords;
        }
    }
}