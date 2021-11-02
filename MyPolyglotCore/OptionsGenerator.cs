using MyPolyglotCore.Helpers;
using MyPolyglotCore.Interfaces;
using MyPolyglotCore.Words;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MyPolyglotCore
{
    public class OptionsGenerator : IOptionsGenerator
    {
        public IEnumerable<string> GetOptions(Word word)
        {
            return word switch
            {
                QuestionWord questionWord => GenerateOptions(questionWord),
                Pronoun pronoun => GenerateOptions(pronoun),
                Adverb adverb => GenerateOptions(adverb),
                Compound compound => GenerateOptions(compound),
                Determiner determiner => GenerateOptions(determiner),
                Adjective adjective => GenerateOptions(adjective),
                Noun noun => GenerateOptions(noun),
                NumberWithNoun numberWithNoun => GenerateOptions(numberWithNoun),
                ModalVerb modalVerb => GenerateOptions(modalVerb),
                PrimaryVerb primaryVerb => GenerateOptions(primaryVerb),
                Verb verb => GenerateOptions(verb),
                Preposition preposition => GenerateOptions(preposition),
                ComparisonAdjective comparisonAdjective => GenerateOptions(comparisonAdjective),
                _ => throw new NotImplementedException(),
            };
        }

        private IEnumerable<string> GenerateOptions(NumberWithNoun numberWithNoun)
        {
            var fiveRandomNouns = Vocabulary.Nouns
                .Select(x => x.PluralForm)
                .TakeFiveShuffledStrings();

            var number = Regex.Match(numberWithNoun.Text, @"\d+").Value;

            return fiveRandomNouns.Select(x => $"{number} {x}");
        }

        private IEnumerable<string> GenerateOptions(Pronoun pronoun)
        {
            if (Vocabulary.SubjectPronouns.Contains(pronoun))
            {
                return Vocabulary.SubjectPronouns.Select(x => x.Text);
            }

            if (Vocabulary.ObjectPronouns.Contains(pronoun))
            {
                return Vocabulary.ObjectPronouns.Select(x => x.Text);
            }

            if (Vocabulary.PossessiveAdjectives.Contains(pronoun))
            {
                return Vocabulary.PossessiveAdjectives.Select(x => x.Text);
            }

            if (Vocabulary.PossessivePronouns.Contains(pronoun))
            {
                return Vocabulary.PossessivePronouns.Select(x => x.Text);
            }

            if (Vocabulary.ReflexivePronouns.Contains(pronoun))
            {
                return Vocabulary.ReflexivePronouns.Select(x => x.Text);
            }

            return Vocabulary.DemonstrativePronouns.Select(x => x.Text);
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
            if (Vocabulary.DayParts.Contains(noun))
            {
                if (noun.FromWhatItWasRecognized == noun.PluralForm)
                {
                    return Vocabulary.DayParts.Select(x => x.PluralForm);
                }

                return Vocabulary.DayParts.Select(x => x.Text);
            }

            if (Vocabulary.Occupations.Contains(noun))
            {
                if (noun.FromWhatItWasRecognized == noun.PluralForm)
                {
                    return Vocabulary.Occupations
                        .Select(x => x.PluralForm)
                        .TakeSixShuffledStrings(noun.PluralForm);
                }

                return Vocabulary.Occupations
                    .Select(x => x.Text)
                    .TakeSixShuffledStrings(noun.Text);
            }

            var nounVocabulary = Vocabulary.GetNounVocabulary();
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
