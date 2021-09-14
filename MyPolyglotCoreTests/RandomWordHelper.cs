using MyPolyglotCore;
using MyPolyglotCore.Words;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyPolyglotCoreTests
{
    public static class RandomWordHelper
    {
        private static readonly Random _random = new Random();
        private static readonly List<Word> _recognizableWords = Vocabulary.RecognizableVocabularies.ToList();
        private static readonly List<Verb> _irregularVerbs = Vocabulary.IrregularVerbs.ToList();
        private static readonly List<PrimaryVerb> _primaryVerbs = Vocabulary.PrimaryVerbs.ToList();

        public static Word GetRandomRecognizableWord()
        {
            return _recognizableWords[_random.Next(_recognizableWords.Count)];
        }

        public static Word GetRandomWordFromVocabulary(this Type typeOfWord)
        {
            var vocabulary = Vocabulary.GetVocabulary(typeOfWord).ToList();
            return vocabulary[_random.Next(vocabulary.Count)];
        }

        public static Verb GetRandomIrregularVerb()
        {
            return _irregularVerbs[_random.Next(_irregularVerbs.Count)];
        }

        public static PrimaryVerb GetRandomPrimaryVerb()
        {
            return _primaryVerbs[_random.Next(_primaryVerbs.Count)];
        }
    }
}
