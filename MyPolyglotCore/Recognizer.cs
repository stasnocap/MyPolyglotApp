using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using MyPolyglotCore.Words;

namespace MyPolyglotCore
{
    public class Recognizer
    {
        public string EngPhrase { get; set; }
        public IEnumerable<Word> RecognizedWords { get; set; }
        public IEnumerable<Word> UnrecognizedWords { get; set; }

        private Vocabulary _vocabulary;

        public Recognizer(string engPhrase, Vocabulary vocabulary)
        {
            EngPhrase = engPhrase;
            _vocabulary = vocabulary;
        }

        public void TryToRecognize()
        {
            var words = SplitToWords();

            RecognizedWords = words
                .Select(word => _vocabulary.RecognizableVocabularies.FirstOrDefault(x => x.Equals(word)))
                .Where(x => x != null);

            UnrecognizedWords = words.Except(RecognizedWords);
        }

        private IEnumerable<Word> SplitToWords()
        {
            return Regex.Split(EngPhrase.ToLower(), "\\W+")
                        .Where(x => !string.IsNullOrEmpty(x))
                        .Select(x => new Word() { Text = x });
        }
    }
}
