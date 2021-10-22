using MyPolyglotCore.Words;
using MyPolyglotCore.Words.Adverbs;
using MyPolyglotCore.Words.Pronouns;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyPolyglotCore
{
    public static class RandomWordHelper
    {
        private static readonly Random _random = new Random();
        private static readonly List<Word> _recognizableWords = Vocabulary.RecognizableVocabularies.ToList();

        public static Word GetRandomRecognizableWord()
        {
            return _recognizableWords[_random.Next(_recognizableWords.Count)];
        }

        public static Word GetRandomWord(this Type typeOfWord)
        {
            return GetRandomWord(Vocabulary.GetVocabulary(typeOfWord));
        }

        private static Word GetRandomWord(IEnumerable<Word> vocabulary)
        {
            var list = vocabulary.ToArray();
            return list[_random.Next(list.Length)];
        }

        public static Verb GetRandomIrregularVerb()
        {
            return (Verb)typeof(Verb).GetRandomWord();
        }

        public static PrimaryVerb GetRandomPrimaryVerb()
        {
            return (PrimaryVerb)typeof(PrimaryVerb).GetRandomWord();
        }

        public static ModalVerb GetRandomModalVerb()
        {
            return (ModalVerb)typeof(ModalVerb).GetRandomWord();
        }

        public static Determiner GetRandomDeterminer()
        {
            return (Determiner)typeof(Determiner).GetRandomWord();
        }

        public static ReflexivePronoun GetRandomReflexivePronoun()
        {
            return (ReflexivePronoun)typeof(ReflexivePronoun).GetRandomWord();
        }

        public static PossessivePronoun GetRandomPossessivePronoun()
        {
            return (PossessivePronoun)typeof(PossessivePronoun).GetRandomWord();
        }

        public static PossessiveAdjective GetRandomPossessiveAdjective()
        {
            return (PossessiveAdjective)typeof(PossessiveAdjective).GetRandomWord();
        }

        public static ObjectPronoun GetRandomObjectPronoun()
        {
            return (ObjectPronoun)typeof(ObjectPronoun).GetRandomWord();
        }

        public static SubjectPronoun GetRandomSubjectPronoun()
        {
            return (SubjectPronoun)typeof(SubjectPronoun).GetRandomWord();
        }

        public static DemonstrativePronoun GetRandomDemonstrativePronoun()
        {
            return (DemonstrativePronoun)typeof(DemonstrativePronoun).GetRandomWord();
        }

        public static Preposition GetRandomPreposition()
        {
            return (Preposition)typeof(Preposition).GetRandomWord();
        }

        public static ComparisonAdjective GetRandomComparisonAdjective()
        {
            return (ComparisonAdjective)typeof(ComparisonAdjective).GetRandomWord();
        }

        public static FrequencyAdverb GetRandomFrequencyAdverb()
        {
            return (FrequencyAdverb)typeof(FrequencyAdverb).GetRandomWord();
        }

        public static IntensifierAdverb GetRandomIntensifierAdverb()
        {
            return (IntensifierAdverb)typeof(IntensifierAdverb).GetRandomWord();
        }

        public static MannerAdverb GetRandomMannerAdverb()
        {
            return (MannerAdverb)typeof(MannerAdverb).GetRandomWord();
        }

        public static TellHowItHappenedAdverb GetRandomTellHowItHappendAdverb()
        {
            return (TellHowItHappenedAdverb)typeof(TellHowItHappenedAdverb).GetRandomWord();
        }

        public static TellTheExtentOfTheActionAdverb GetRandomTellTheExtentOfTheActionAdverb()
        {
            return (TellTheExtentOfTheActionAdverb)typeof(TellTheExtentOfTheActionAdverb).GetRandomWord();
        }

        public static TellWhenItHappenedAdverb GetRandomTellWhenItHappendAdverb()
        {
            return (TellWhenItHappenedAdverb)typeof(TellWhenItHappenedAdverb).GetRandomWord();
        }

        public static TellWhereItHappenedAdverb GetRandomTellWhereItHappendAdverb()
        {
            return (TellWhereItHappenedAdverb)typeof(TellWhereItHappenedAdverb).GetRandomWord();
        }

        public static Compound GetRandomCompound()
        {
            return (Compound)typeof(Compound).GetRandomWord();
        }

        public static Compound GetRandomSomeCompound()
        {
            return (Compound)GetRandomWord(Vocabulary.SomeCompounds);
        }

        public static Compound GetRandomAnyCompound()
        {
            return (Compound)GetRandomWord(Vocabulary.AnyCompounds);
        }

        public static Compound GetRandomEveryCompound()
        {
            return (Compound)GetRandomWord(Vocabulary.EveryCompounds);
        }

        public static Compound GetRandomNoCompound()
        {
            return (Compound)GetRandomWord(Vocabulary.NoCompounds);
        }
    }
}
