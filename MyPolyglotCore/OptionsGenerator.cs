using MyPolyglotCore.Words;
using MyPolyglotCore.Words.Pronouns;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyPolyglotCore
{
    public class OptionsGenerator
    {
        public IEnumerable<string> GetOptions(Word word)
        {
            return word switch
            {
                QuestionWord questionWord => Vocabulary.QuestionWords.Select(x => x.Text),
                SubjectPronoun subjectPronoun => Vocabulary.SubjectPronouns.Select(x => x.Text),
                ObjectPronoun objectPronoun => Vocabulary.ObjectPronouns.Select(x => x.Text),
                PossessiveAdjective possessiveAdjective => Vocabulary.PossessiveAdjectives.Select(x => x.Text),
                PossessivePronoun possessivePronoun => Vocabulary.PossessivePronouns.Select(x => x.Text),
                ReflexivePronoun reflexivePronoun => Vocabulary.ReflexivePronouns.Select(x => x.Text),
                Determiner determiner => Vocabulary.Determiners.Select(x => x.Text),
                Adjective adjective => GetRandomWordsFromVocabularyWithRightWord(adjective),
                Noun noun => GetRandomWordsFromVocabularyWithRightWord(noun),
                ModalVerb modalVerb => GenerateOptionsForModalVerb(modalVerb),
                PrimaryVerb primaryVerb => GenerateOptionsForPrimaryVerb(primaryVerb),
                Verb verb => GenerateOptionsForVerb(verb),
                Preposition preposition => GetRandomWordsFromVocabularyWithRightWord(preposition),
                _ => throw new NotImplementedException(),
            };
        }

        private IEnumerable<string> GetRandomWordsFromVocabularyWithRightWord(Word word)
        {
            var vocabulary = Vocabulary.GetVocabulary(word.GetType());
            return vocabulary
                .Select(x => x.Text)
                .TakeSixShuffledStrings(word.Text);
        }

        private IEnumerable<string> GenerateOptionsForModalVerb(ModalVerb modalVerb)
        {
            var modalVerbVocabularyWithoutRightWord = Vocabulary
                .GetVocabulary(typeof(ModalVerb))
                .Cast<ModalVerb>()
                .Where(x => !modalVerb.Equals(x));

            if (modalVerb.FromWhatItWasRecognized == modalVerb.FullNegativeForm)
            {
                return modalVerbVocabularyWithoutRightWord
                    .Select(x => x.FullNegativeForm)
                    .TakeSixShuffledStrings(modalVerb.FullNegativeForm);
            }

            if (modalVerb.FromWhatItWasRecognized == modalVerb.ShortNegativeForm)
            {
                return modalVerbVocabularyWithoutRightWord
                    .Select(x => x.ShortNegativeForm)
                    .TakeSixShuffledStrings(modalVerb.ShortNegativeForm);
            }

            return modalVerbVocabularyWithoutRightWord
                .Select(x => x.Text)
                .TakeSixShuffledStrings(modalVerb.Text);
        }

        private IEnumerable<string> GenerateOptionsForPrimaryVerb(PrimaryVerb primaryVerb)
        {
            var positiveForms = new List<string>
            {
                primaryVerb.Text,
                primaryVerb.PastForm,
                primaryVerb.PastParticipleForm,
                primaryVerb.PresentParticipleForm,
                primaryVerb.ThirdPersonForm
            };

            if (primaryVerb.AdditionalForms != null)
            {
                positiveForms.AddRange(primaryVerb.AdditionalForms);
            }

            if (positiveForms.Contains(primaryVerb.FromWhatItWasRecognized))
            {
                if (primaryVerb.AdditionalForms == null)
                {
                    return positiveForms;
                }

                positiveForms.Remove(primaryVerb.FromWhatItWasRecognized);

                return positiveForms.TakeSixShuffledStrings(primaryVerb.FromWhatItWasRecognized);
            }

            if (primaryVerb.FullNegativeForms.Contains(primaryVerb.FromWhatItWasRecognized))
            {
                return primaryVerb.FullNegativeForms;
            }

            return primaryVerb.ShortNegativeForms;
        }

        private IEnumerable<string> GenerateOptionsForVerb(Verb verb)
        {
            return verb.IsIrregularVerb
                ? new List<string>() { verb.Text, verb.PastForm, verb.PastParticipleForm, verb.PresentParticipleForm, verb.ThirdPersonForm }
                : new List<string>() { verb.Text, verb.PastForm, verb.ThirdPersonForm };
        }
    }
}
