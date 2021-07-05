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

        private Vocabulary _vocabulary { get; }
        private readonly Random _random = new Random();

        public Exercise(Vocabulary vocabulary)
        {
            _vocabulary = vocabulary;
        }

        public IEnumerable<string> GetOptions()
        {
            var options = new List<string>();
            foreach (var word in EngPhrase)
            {
                switch (word)
                {
                    case SubjectPronoun s:
                        options.AddRange(_vocabulary.SubjectPronouns);
                        break;
                    case ObjectPronoun o:
                        options.AddRange(_vocabulary.ObjectPronouns);
                        break;
                    case PossessiveAdjective p:
                        options.AddRange(_vocabulary.PossessiveAdjectives);
                        break;
                    case PossessivePronoun p:
                        options.AddRange(_vocabulary.PossessivePronouns);
                        break;
                    case ReflexivePronoun r:
                        options.AddRange(_vocabulary.ReflexivePronouns);
                        break;
                    case Determiner d:
                        options.AddRange(_vocabulary.Determiners);
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

        private IEnumerable<string> GetRandomWordsFromVocabularyWithRightWord(Word word)
        {
            var vocabulary = _vocabulary.GetVocabulary(word);
            return vocabulary
                .OrderBy(x => _random.Next())
                .Take(5)
                .Concat(new[] { word.Text })
                .OrderBy(x => Guid.NewGuid());
        }
    }
}