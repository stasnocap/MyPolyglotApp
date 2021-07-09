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

        public Recognizer(string engPhrase)
        {
            EngPhrase = engPhrase;
            _vocabulary = new Vocabulary();
        }

        public void TryToRecognize()
        {
            var words = SplitToWords();

            // vocabularies that will have been checked for the existence of word
            var checkedVocabularies = new List<Word>();
            checkedVocabularies.AddRange(_vocabulary.SubjectPronouns);
            checkedVocabularies.AddRange(_vocabulary.ObjectPronouns);
            checkedVocabularies.AddRange(_vocabulary.PossessiveAdjectives);
            checkedVocabularies.AddRange(_vocabulary.PossessivePronouns);
            checkedVocabularies.AddRange(_vocabulary.ReflexivePronouns);
            checkedVocabularies.AddRange(_vocabulary.Determiners);

            RecognizedWords = words
                .Select(word => checkedVocabularies.FirstOrDefault(x => x == word))
                .Where(x => x != null);

            UnrecognizedWords = words.Except(RecognizedWords);
        }

        private IEnumerable<Word> SplitToWords()
        {
            return Regex.Split(EngPhrase.ToLower(), "\\W+")
                        .Select(x => new Word() { Text = x });
        }
    }
}
