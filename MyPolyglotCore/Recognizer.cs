using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using MyPolyglotCore.Words;
using MyPolyglotCore.Words.Pronouns;

namespace MyPolyglotCore
{
    public class Recognizer
    {
        public string EngPhrase { get; }
        public IEnumerable<Word> RecognizedWords { get; private set; }
        public IEnumerable<Word> UnrecognizedWords { get; private set; }

        public Recognizer(string engPhrase)
        {
            EngPhrase = engPhrase;
        }

        public void Recognize()
        {
            var words = EngPhrase.SplitToWords();
            RecognizedWords = words.SelectMany(word => FindWordsInVocabulary(word));
            UnrecognizedWords = words.Where(x => !RecognizedWords.Contains(x));
        }

        private IEnumerable<Word> FindWordsInVocabulary(Word word)
        {
            var list = new List<Word>();
            foreach (var wordFromVocabulary in Vocabulary.RecognizableVocabularies)
            {
                if (wordFromVocabulary.Equals(word))
                {
                    var type = wordFromVocabulary.GetType();
                    list.Add(ConvertWord(wordFromVocabulary.GetType(), word.Text));
                }
            }
            return list;
        }

        private Word ConvertWord(Type type, string text)
        {

            return type switch
            {
                Type subjectPronoun when subjectPronoun == typeof(SubjectPronoun) => new SubjectPronoun(text),
                Type objectPronoun when objectPronoun == typeof(ObjectPronoun) => new ObjectPronoun(text),
                Type possessiveAdjective when possessiveAdjective == typeof(PossessiveAdjective) => new PossessiveAdjective(text),
                Type possessivePronoun when possessivePronoun == typeof(PossessivePronoun) => new PossessivePronoun(text),
                Type reflexivePronoun when reflexivePronoun == typeof(ReflexivePronoun) => new ReflexivePronoun(text),
                Type determiner when determiner == typeof(Determiner) => new Determiner(text),
                _ => throw new NotImplementedException(),
            };
        }
    }
}
