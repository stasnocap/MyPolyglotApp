using MyPolyglotCore.Words;
using MyPolyglotCore.Words.Pronouns;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyPolyglotCore
{
    public class OptionsGenerator
    {
        private Random _random;

        public OptionsGenerator()
        {
            _random = new Random();
        }

        public IEnumerable<string> GetOptions(Word word)
        {
            return word switch
            {
                SubjectPronoun s => Vocabulary.SubjectPronouns.Select(x => x.Text),
                ObjectPronoun o => Vocabulary.ObjectPronouns.Select(x => x.Text),
                PossessiveAdjective pa => Vocabulary.PossessiveAdjectives.Select(x => x.Text),
                PossessivePronoun pp => Vocabulary.PossessivePronouns.Select(x => x.Text),
                ReflexivePronoun r => Vocabulary.ReflexivePronouns.Select(x => x.Text),
                Determiner d => Vocabulary.Determiners.Select(x => x.Text),
                Adjective a => GetRandomWordsFromVocabularyWithRightWord(word),
                Noun n => GetRandomWordsFromVocabularyWithRightWord(word),
                ModalVerb m => GetRandomModalVerbs(word),
                PrimaryVerb pv => GenerateOpitonsForPrimaryVerb(word),
                Verb v => GenerateOptionsForVerb(word),
                _ => throw new NotImplementedException(),
            };
        }

        private IEnumerable<string> GetRandomModalVerbs(Word word)
        {
            var modalVerb = word as ModalVerb;
            var vocabulary = Vocabulary.GetVocabulary(typeof(ModalVerb));

            var modalVerbs = vocabulary
                .OrderBy(x => _random.Next())
                .Take(3)
                .Append(modalVerb) 
                as IEnumerable<ModalVerb>;

            return modalVerbs
                .Select(x => x.Text)
                .Concat(modalVerbs.Select(x => x.NegativeForm))
                .OrderBy(x => _random.Next());
        }

        private IEnumerable<string> GenerateOpitonsForPrimaryVerb(Word word)
        {
            var primaryVerb = word as PrimaryVerb;
            return primaryVerb.NegativeForms
                    .Concat(primaryVerb.AdditionalForms)
                    .Concat(new string[]
                    {
                        primaryVerb.Text, primaryVerb.PastForm, primaryVerb.PastParticipleForm,
                        primaryVerb.PresentParticipleForm, primaryVerb.ThirdPersonForm
                    });
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

            return verb.IsIrregularVerb
                ? new List<string>() { verb.Text, verb.PastForm, verb.PastParticipleForm, verb.PresentParticipleForm, verb.ThirdPersonForm }
                : new List<string>() { verb.Text, verb.PastForm, verb.PastParticipleForm, verb.ThirdPersonForm };
        }
    }
}
