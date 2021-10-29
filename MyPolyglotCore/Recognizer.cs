using System.Collections.Generic;
using System.Linq;
using MyPolyglotCore.Helpers;
using MyPolyglotCore.Interfaces;
using MyPolyglotCore.Words;

namespace MyPolyglotCore
{
    public class Recognizer : IRecognizer
    {
        public IEnumerable<Word> RecognizedWords { get; private set; }
        public IEnumerable<Word> UnrecognizedWords { get; private set; }

        public void Recognize(string engPhrase)
        {
            var words = engPhrase.SplitToWords();
            RecognizedWords = words.SelectMany(word => Vocabulary.RecognizableVocabularies.Where(x =>
                {
                    if (!x.Equals(word))
                    {
                        return false;
                    }
                    x.FromWhatItWasRecognized = word.Text;
                    return true;
                }));
            UnrecognizedWords = words.Where(x => !RecognizedWords.Contains(x));
        }
    }
}
