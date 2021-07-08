using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using MyPolyglotCore.Words;

namespace MyPolyglotCore
{
    public class Recognizer
    {
        private Vocabulary _vocabulary;

        public Recognizer()
        {
            _vocabulary = new Vocabulary();
        }

        public IEnumerable<Word> Recognize(string engPhrase)
        {
            var wordTexts = Regex.Split(engPhrase.ToLower(), "\\W+");

            // vocabularies that will have been checked for the existence of word
            var checkedVocabularies = new List<Word>();
            checkedVocabularies.AddRange(_vocabulary.SubjectPronouns);
            checkedVocabularies.AddRange(_vocabulary.ObjectPronouns);
            checkedVocabularies.AddRange(_vocabulary.PossessiveAdjectives);
            checkedVocabularies.AddRange(_vocabulary.PossessivePronouns);
            checkedVocabularies.AddRange(_vocabulary.ReflexivePronouns);
            checkedVocabularies.AddRange(_vocabulary.Determiners);

            return wordTexts
                .Select(word => checkedVocabularies.FirstOrDefault(x => x.Text == word))
                .Where(x => x != null);
        }
    }
}
