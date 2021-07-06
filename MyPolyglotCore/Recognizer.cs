using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using MyPolyglotCore.Words;

namespace MyPolyglotCore
{
    public class Recognizer
    {
        private Vocabulary _vocabulary;
        private List<string[]> _checkedVocabularies;

        public Recognizer()
        {
            _vocabulary = new Vocabulary();

            _checkedVocabularies = new List<string[]>()
            {
                _vocabulary.SubjectPronouns.Select(x=>x.Text).ToArray()
            };
        }

        public IEnumerable<string> Split(string engPhrase)
        {
            return Regex.Split(engPhrase.ToLower(), "\\W+")
                .Where(x => x.Length > 0); // remove words with "" value
        }

        public void Recognize(string[] words)
        {
            var convertedWords = new List<Word>();
            foreach (var word in words)
            {
                foreach (var vocabulary in _checkedVocabularies)
                {
                    if (Array.Exists(vocabulary, x => x == word))
                    {
                    }
                }
            }
        }
    }
}
