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
                SubjectPronoun subjectPronoun => Vocabulary.SubjectPronouns.Select(x => x.Text),
                ObjectPronoun objectPronoun => Vocabulary.ObjectPronouns.Select(x => x.Text),
                PossessiveAdjective possessiveAdjective => Vocabulary.PossessiveAdjectives.Select(x => x.Text),
                PossessivePronoun possessivePronoun => Vocabulary.PossessivePronouns.Select(x => x.Text),
                ReflexivePronoun reflexivePronoun => Vocabulary.ReflexivePronouns.Select(x => x.Text),
                Determiner determiner => Vocabulary.Determiners.Select(x => x.Text),
                Adjective adjective => GetRandomWordsFromVocabularyWithRightWord(word),
                Noun noun => GetRandomWordsFromVocabularyWithRightWord(word),
                ModalVerb modalVerb => GetRandomModalVerbs(modalVerb),
                PrimaryVerb primaryVerb => GenerateOpitonsForPrimaryVerb(primaryVerb),
                Verb verb => GenerateOptionsForVerb(verb),
                _ => throw new NotImplementedException(),
            };
        }

        private IEnumerable<string> GetRandomModalVerbs(ModalVerb modalVerb)
        {
            var vocabulary = Vocabulary.GetVocabulary(typeof(ModalVerb)) as IEnumerable<ModalVerb>;

            var modalVerbs = vocabulary
                .OrderBy(x => _random.Next())
                .Take(3);

            if (!modalVerbs.Contains(modalVerb))
            {
                modalVerbs.ToList().Remove(modalVerbs.First());
                modalVerbs.Append(modalVerb);
            }

            return modalVerbs
                .Select(x => x.Text)
                .Concat(modalVerbs.Select(x => x.NegativeForm))
                .OrderBy(x => _random.Next());
        }

        private IEnumerable<string> GenerateOpitonsForPrimaryVerb(PrimaryVerb primaryVerb)
        {
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

        private IEnumerable<string> GenerateOptionsForVerb(Verb verb)
        {
            return verb.IsIrregularVerb
                ? new List<string>() { verb.Text, verb.PastForm, verb.PastParticipleForm, verb.PresentParticipleForm, verb.ThirdPersonForm }
                : new List<string>() { verb.Text, verb.PastForm, verb.PastParticipleForm, verb.ThirdPersonForm };
        }
    }
}
