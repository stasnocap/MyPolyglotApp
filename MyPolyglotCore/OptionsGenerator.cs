using MyPolyglotCore.Interfaces;
using MyPolyglotCore.Words;
using MyPolyglotCore.Words.Pronouns;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyPolyglotCore
{
    public class OptionsGenerator : IOptionsGenerator
    {
        public IEnumerable<string> GetOptions(Word word)
        {
            return word switch
            {
                QuestionWord questionWord => GenerateOptions(questionWord),
                SubjectPronoun subjectPronoun => GenerateOptions(subjectPronoun),
                ObjectPronoun objectPronoun => GenerateOptions(objectPronoun),
                PossessiveAdjective possessiveAdjective => GenerateOptions(possessiveAdjective),
                PossessivePronoun possessivePronoun => GenerateOptions(possessivePronoun),
                ReflexivePronoun reflexivePronoun => GenerateOptions(reflexivePronoun),
                Adverb adverb => GenerateOptions(adverb),
                Compound compound => GenerateOptions(compound),
                Determiner determiner => GenerateOptions(determiner),
                Adjective adjective => GenerateOptions(adjective),
                Noun noun => GenerateOptions(noun),
                ModalVerb modalVerb => GenerateOptions(modalVerb),
                PrimaryVerb primaryVerb => GenerateOptions(primaryVerb),
                Verb verb => GenerateOptions(verb),
                Preposition preposition => GenerateOptions(preposition),
                ComparisonAdjective comparisonAdjective => GenerateOptions(comparisonAdjective),
                DemonstrativePronoun demonstrativePronoun => GenerateOptions(demonstrativePronoun),
                _ => throw new NotImplementedException(),
            };
        }

        private IEnumerable<string> GenerateOptions(Adverb adverb)
        {
            if (Vocabulary.FrequencyAdverbs.Contains(adverb))
            {
                return GetRandomWordsFromVocabularyWithRightWord(adverb, Vocabulary.FrequencyAdverbs);
            }

            if (Vocabulary.IntensifierAdverbs.Contains(adverb))
            {
                return GetRandomWordsFromVocabularyWithRightWord(adverb, Vocabulary.IntensifierAdverbs);
            }

            if (Vocabulary.MannerAdverbs.Contains(adverb))
            {
                return GetRandomWordsFromVocabularyWithRightWord(adverb, Vocabulary.MannerAdverbs);
            }

            if (Vocabulary.TellHowItHappenedAdverbs.Contains(adverb))
            {
                return GetRandomWordsFromVocabularyWithRightWord(adverb, Vocabulary.TellHowItHappenedAdverbs);
            }

            if (Vocabulary.TellTheExtentOfTheActionAdverbs.Contains(adverb))
            {
                return GetRandomWordsFromVocabularyWithRightWord(adverb, Vocabulary.TellTheExtentOfTheActionAdverbs);
            }

            if (Vocabulary.TellWhenItHappenedAdverbs.Contains(adverb))
            {
                return GetRandomWordsFromVocabularyWithRightWord(adverb, Vocabulary.TellWhenItHappenedAdverbs);
            }

            return GetRandomWordsFromVocabularyWithRightWord(adverb, Vocabulary.TellWhereItHappenedAdverbs);
        }

        private IEnumerable<string> GenerateOptions(Compound compound)
        {
            if (Vocabulary.SomeCompounds.Contains(compound))
            {
                return Vocabulary.SomeCompounds.Select(x => x.Text);
            }

            if (Vocabulary.AnyCompounds.Contains(compound))
            {
                return Vocabulary.AnyCompounds.Select(x => x.Text);
            }

            if (Vocabulary.EveryCompounds.Contains(compound))
            {
                return Vocabulary.EveryCompounds.Select(x => x.Text);
            }

            return Vocabulary.NoCompounds.Select(x => x.Text);
        }
        private IEnumerable<string> GenerateOptions(QuestionWord questionWord)
        {
            return Vocabulary.QuestionWords.Select(x => x.Text);
        }

        private IEnumerable<string> GenerateOptions(SubjectPronoun subjectPronoun)
        {
            return Vocabulary.SubjectPronouns.Select(x => x.Text);
        }

        private IEnumerable<string> GenerateOptions(ObjectPronoun objectPronoun)
        {
            return Vocabulary.ObjectPronouns.Select(x => x.Text);
        }

        private IEnumerable<string> GenerateOptions(PossessiveAdjective possessiveAdjective)
        {
            return Vocabulary.PossessiveAdjectives.Select(x => x.Text);
        }

        private IEnumerable<string> GenerateOptions(PossessivePronoun possessivePronoun)
        {
            return Vocabulary.PossessivePronouns.Select(x => x.Text);
        }

        private IEnumerable<string> GenerateOptions(ReflexivePronoun reflexivePronoun)
        {
            return Vocabulary.ReflexivePronouns.Select(x => x.Text);
        }

        private IEnumerable<string> GenerateOptions(DemonstrativePronoun demonstrativePronoun)
        {
            return Vocabulary.DemonstrativePronouns.Select(x => x.Text);
        }

        private IEnumerable<string> GenerateOptions(Determiner determiner)
        {
            return Vocabulary.Determiners.Select(x => x.Text);
        }

        private IEnumerable<string> GenerateOptions(Adjective adjective)
        {
            return GetRandomWordsFromVocabularyWithRightWord(adjective);
        }

        private IEnumerable<string> GenerateOptions(Noun noun)
        {
            var nounVocabulary = Vocabulary.GetVocabulary(typeof(Noun)).Cast<Noun>();
            if (noun.WasRecognizedFromPluralForm
                || noun.PluralForm != null && noun.FromWhatItWasRecognized == noun.PluralForm)
            {

                return nounVocabulary
                    .Select(x => x.PluralForm)
                    .TakeSixShuffledStrings(noun.PluralForm);
            }

            return nounVocabulary
                    .Select(x => x.Text)
                    .TakeSixShuffledStrings(noun.Text);
        }

        private IEnumerable<string> GenerateOptions(Preposition preposition)
        {
            return GetRandomWordsFromVocabularyWithRightWord(preposition);
        }

        private IEnumerable<string> GenerateOptions(ComparisonAdjective comparisonAdjective)
        {
            return new string[] { comparisonAdjective.Text, comparisonAdjective.ComparativeForm, comparisonAdjective.SuperlativeForm };
        }

        private IEnumerable<string> GetRandomWordsFromVocabularyWithRightWord(Word word)
        {
            var vocabulary = Vocabulary.GetVocabulary(word.GetType());
            return GetRandomWordsFromVocabularyWithRightWord(word, vocabulary);
        }

        private IEnumerable<string> GetRandomWordsFromVocabularyWithRightWord(Word word, IEnumerable<Word> vocabulary)
        {
            return vocabulary
                .Select(x => x.Text)
                .TakeSixShuffledStrings(word.Text);
        }

        private IEnumerable<string> GenerateOptions(ModalVerb modalVerb)
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

        private IEnumerable<string> GenerateOptions(PrimaryVerb primaryVerb)
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

        private IEnumerable<string> GenerateOptions(Verb verb)
        {
            return verb.IsIrregularVerb
                ? new string[] { verb.Text, verb.PastForm, verb.PastParticipleForm, verb.PresentParticipleForm, verb.ThirdPersonForm }
                : new string[] { verb.Text, verb.PastForm, verb.ThirdPersonForm };
        }
    }
}
