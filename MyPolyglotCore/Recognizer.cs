using System;
using System.Collections.Generic;
using System.Linq;
using MyPolyglotCore.Words;

namespace MyPolyglotCore
{
    public class Recognizer
    {
        public string EngPhrase { get; }
        public IEnumerable<RecognizedWord> RecognizedWords { get; private set; }
        public IEnumerable<Word> UnrecognizedWords { get; private set; }

        public Recognizer(string engPhrase)
        {
            EngPhrase = engPhrase;
        }

        public void Recognize()
        {
            var words = EngPhrase.SplitToWords();
            RecognizedWords = words.SelectMany(word => Vocabulary.RecognizableVocabularies
                .Where(x => x.Equals(word))
                .Select(y => new RecognizedWord() { RootWordFormVocabulary = y, FromWhatItWasRecognized = word }));
            UnrecognizedWords = words.Where(x => !RecognizedWords.Select(x => x.RootWordFormVocabulary).Contains(x));
        }
    }
}
