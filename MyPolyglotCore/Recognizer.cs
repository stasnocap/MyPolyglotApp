using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using MyPolyglotCore.Words;

namespace MyPolyglotCore
{
    public class Recognizer
    {
        public string EngPhrase { get; }
        public IEnumerable<Word> RecognizedWords { get; private set; }
        public IEnumerable<Word> UnrecognizedWords { get; private set; }

        public Recognizer(string engPhrase)
        {
            EngPhrase = engPhrase;
        }

        public void Recognize()
        {
            var words = SplitToWords();
            RecognizedWords = words.SelectMany(word => Vocabulary.RecognizableVocabularies.Where(x => x.Equals(word)));
            UnrecognizedWords = words.Where(x => !RecognizedWords.Contains(x));
        }

        private IEnumerable<Word> SplitToWords()
        {
            return Regex.Split(EngPhrase.ToLower(), "[^a-zA-Z0-9']+")
                        .Where(x => !string.IsNullOrEmpty(x))
                        .Select(x => new Word(x));
        }
    }
}
