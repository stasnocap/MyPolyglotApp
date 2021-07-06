using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

        public IEnumerable<string> Split(string engPhrase)
        {
            return Regex.Split(engPhrase.ToLower(), "\\W+")
                .Where(x => x.Length > 0); // remove words with "" value
        }

        public void Recognize(string[] words)
        {
            var convertedWords = new List<Word>();
            var checkedVocabularies = new List<string[]>()
            {
                _vocabulary.SubjectPronouns.Select(x=>x.Text).ToArray()
            };

            foreach (var word in words)
            {
                foreach (var vocabulary in checkedVocabularies)
                {
                    if (Array.Exists(vocabulary, x => x == word))
                    {
                        
                    }
                }
            }
        }
    }
}
