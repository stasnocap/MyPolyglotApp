using System;
using System.Collections.Generic;
using System.Linq;
using MyPolyglotCore.Words;
using MyPolyglotCore.Words.Pronouns;

namespace MyPolyglotCore
{
    public class Exercise
    {
        public string RusPhrase { get; }
        public IEnumerable<Word> EngPhrase { get; }

        private readonly Random _random; 

        public Exercise(string rusPhrase, IEnumerable<Word> engPhrase)
        {
            RusPhrase = rusPhrase;
            EngPhrase = engPhrase;
            _random = new Random();
        }

        public IEnumerable<string> GetOptions()
        {
            var options = new List<string>();
            foreach (var word in EngPhrase)
            {
                switch (word)
                {
                    case SubjectPronoun s:
                        options.AddRange(Vocabulary.SubjectPronouns.Select(x => x.Text));
                        break;
                    case ObjectPronoun o:
                        options.AddRange(Vocabulary.ObjectPronouns.Select(x => x.Text));
                        break;
                    case PossessiveAdjective p:
                        options.AddRange(Vocabulary.PossessiveAdjectives.Select(x => x.Text));
                        break;
                    case PossessivePronoun p:
                        options.AddRange(Vocabulary.PossessivePronouns.Select(x => x.Text));
                        break;
                    case ReflexivePronoun r:
                        options.AddRange(Vocabulary.ReflexivePronouns.Select(x => x.Text));
                        break;
                    case Determiner d:
                        options.AddRange(Vocabulary.Determiners.Select(x => x.Text));
                        break;
                    case Adjective a:
                        options.AddRange(GetRandomWordsFromVocabularyWithRightWord(word));
                        break;
                    case Noun n:
                        options.AddRange(GetRandomWordsFromVocabularyWithRightWord(word));
                        break;
                    case PrimaryVerb p:
                        options.AddRange(GenerateNegativeOptionsForPrimaryVerb(word));
                        break;
                    case Verb v:
                        options.AddRange(GenerateOptionsForVerb(word));
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
            return options;
        }

        private IEnumerable<string> GenerateNegativeOptionsForPrimaryVerb(Word word)
        {
            var primaryVerb = word as PrimaryVerb;

            return primaryVerb.NegativeForms.OrderBy(x => Guid.NewGuid());
        }

        private IEnumerable<string> GetRandomWordsFromVocabularyWithRightWord(Word word)
        {
            var vocabulary = Vocabulary.GetVocabulary(word.GetType());
            return vocabulary
                .OrderBy(x => _random.Next())
                .Take(5)
                .Append(word)
                .Select(x => x.Text)
                .OrderBy(x => Guid.NewGuid());
        }

        private IEnumerable<string> GenerateOptionsForVerb(Word word)
        {
            var verb = word as Verb;

            var verbForms = new List<string>()
            {
                verb.Text,
                verb.PastForm,
                verb.PastParticipleForm,
                verb.PresentParticipleForm,
                verb.ThirdPersonForm,
            };

            return verbForms.OrderBy(x => Guid.NewGuid());
        }
    }
}