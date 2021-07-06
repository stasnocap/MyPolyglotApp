using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using MyPolyglotCore.Words;
using MyPolyglotCore.Words.Pronouns;

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
            var words = Regex.Split(engPhrase.ToLower(), "\\W+")
                .Where(x => x.Length > 0); // remove words with "" value

            var checkedVocabularies = new List<Word>();
            checkedVocabularies.AddRange(_vocabulary.SubjectPronouns);

            var convertedWords = words.Select(word => checkedVocabularies
                    .Find(x => x.Text == word));

            return convertedWords;
        }
    }
}
