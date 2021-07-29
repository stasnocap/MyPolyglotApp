using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using MyPolyglotCore.Words;

namespace MyPolyglotCore
{
    public class Recognizer
    {
        public string EngPhrase { get; }
        public IEnumerable<Word> RecognizedWords { get; }
        public IEnumerable<Word> UnrecognizedWords { get; }

        public Recognizer(string engPhrase)
        {
            EngPhrase = engPhrase;

            var words = SplitToWords();
            //RecognizedWords = words
            //    .SelectMany(word => Vocabulary.RecognizableVocabularies.Where(x => x.Equals(word)));

            var list = new List<Word>();
            foreach (var word in words)
            {
                if (Vocabulary.RecognizableVocabularies.Contains(word))
                {
                    list.Add(word);
                }
            }
            RecognizedWords = list;

            UnrecognizedWords = words.Except(RecognizedWords);
        }

        private IEnumerable<Word> SplitToWords()
        {
            return Regex.Split(EngPhrase.ToLower(), "\\W+")
                        .Where(x => !string.IsNullOrEmpty(x))
                        .Select(x => new Word(x));
        }
    }
}
