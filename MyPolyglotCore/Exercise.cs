using System;
using System.Collections.Generic;
using System.Linq;
using MyPolyglotCore.Words;
using MyPolyglotCore.Words.Pronouns;

namespace MyPolyglotCore
{
    public class Exercise
    {
        public string RusPhrase { get; set; }
        public List<Word> EngPhrase { get; set; } = new List<Word>();

        private readonly Random _random = new Random();

        public IEnumerable<Word> GetOptions()
        {
            var options = new List<Word>();
            foreach (var word in EngPhrase)
            {
                switch (word)
                {
                    case SubjectPronoun s:
                        options.AddRange(Vocabulary.SubjectPronouns);
                        break;
                    case ObjectPronoun o:
                        options.AddRange(Vocabulary.ObjectPronouns);
                        break;
                    case PossessiveAdjective p:
                        options.AddRange(Vocabulary.PossessiveAdjectives);
                        break;
                    case PossessivePronoun p:
                        options.AddRange(Vocabulary.PossessivePronouns);
                        break;
                    case ReflexivePronoun r:
                        options.AddRange(Vocabulary.ReflexivePronouns);
                        break;
                    case Determiner d:
                        options.AddRange(Vocabulary.Determiners);
                        break;
                    case Adjective a:
                        options.AddRange(GetRandomWordsFromVocabularyWithRightWord(word));
                        break;
                    case Noun n:
                        options.AddRange(GetRandomWordsFromVocabularyWithRightWord(word));
                        break;
                    case Verb v:
                        options.AddRange(GetRandomWordsFromVocabularyWithRightWord(word));
                        break;
                    default:
                        throw new NotSupportedException();
                }
            }
            return options;
        }

        private IEnumerable<Word> GetRandomWordsFromVocabularyWithRightWord(Word word)
        {
            var vocabulary = Vocabulary.GetVocabulary(word.GetType());
            return vocabulary
                .OrderBy(x => _random.Next())
                .Take(5)
                .Append(word)
                .OrderBy(x => Guid.NewGuid());
        }
    }
}