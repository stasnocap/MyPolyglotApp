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

        public static Word GetRandomWordFromVocabulary(this Type typeOfWord)
        {
            var vocabulary = Vocabulary.GetVocabulary(typeOfWord).ToList();
            return vocabulary[_random.Next(vocabulary.Count)];
        }

        public static Verb GetRandomIrregularVerb()
        {
            return (Verb)typeof(Verb).GetRandomWordFromVocabulary();
        }

        public static PrimaryVerb GetRandomPrimaryVerb()
        {
            return (PrimaryVerb)typeof(PrimaryVerb).GetRandomWordFromVocabulary();
        }

        public static ModalVerb GetRandomModalVerb()
        {
            return (ModalVerb)typeof(ModalVerb).GetRandomWordFromVocabulary();
        }

        public static Determiner GetRandomDeterminer()
        {
            return (Determiner)typeof(Determiner).GetRandomWordFromVocabulary();
        }

        public static ReflexivePronoun GetRandomReflexivePronoun()
        {
            return (ReflexivePronoun)typeof(ReflexivePronoun).GetRandomWordFromVocabulary();
        }

        public static PossessivePronoun GetRandomPossessivePronoun()
        {
            return (PossessivePronoun)typeof(PossessivePronoun).GetRandomWordFromVocabulary();
        }

        public static PossessiveAdjective GetRandomPossessiveAdjective()
        {
            return (PossessiveAdjective)typeof(PossessiveAdjective).GetRandomWordFromVocabulary();
        }

        public static ObjectPronoun GetRandomObjectPronoun()
        {
            return (ObjectPronoun)typeof(ObjectPronoun).GetRandomWordFromVocabulary();
        }

        public static SubjectPronoun GetRandomSubjectPronoun()
        {
            return (SubjectPronoun)typeof(SubjectPronoun).GetRandomWordFromVocabulary();
        }

        public static DemonstrativePronoun GetRandomDemonstrativePronoun()
        {
            return (DemonstrativePronoun)typeof(DemonstrativePronoun).GetRandomWordFromVocabulary();
        }

        public static Preposition GetRandomPreposition()
        {
            return (Preposition)typeof(Preposition).GetRandomWordFromVocabulary();
        }

        public static ComparisonAdjective GetRandomComparisonAdjective()
        {
            return (ComparisonAdjective)typeof(ComparisonAdjective).GetRandomWordFromVocabulary();
        }

        public static FrequencyAdverb GetRandomFrequencyAdverb()
        {
            return (FrequencyAdverb)typeof(FrequencyAdverb).GetRandomWordFromVocabulary();
        }

        public static IntensifierAdverb GetRandomIntensifierAdverb()
        {
            return (IntensifierAdverb)typeof(IntensifierAdverb).GetRandomWordFromVocabulary();
        }

        public static MannerAdverb GetRandomMannerAdverb()
        {
            return (MannerAdverb)typeof(MannerAdverb).GetRandomWordFromVocabulary();
        }

        public static TellHowItHappenedAdverb GetRandomTellHowItHappendAdverb()
        {
            return (TellHowItHappenedAdverb)typeof(TellHowItHappenedAdverb).GetRandomWordFromVocabulary();
        }

        public static TellTheExtentOfTheActionAdverb GetRandomTellTheExtentOfTheActionAdverb()
        {
            return (TellTheExtentOfTheActionAdverb)typeof(TellTheExtentOfTheActionAdverb).GetRandomWordFromVocabulary();
        }

        public static TellWhenItHappenedAdverb GetRandomTellWhenItHappendAdverb()
        {
            return (TellWhenItHappenedAdverb)typeof(TellWhenItHappenedAdverb).GetRandomWordFromVocabulary();
        }

        public static TellWhereItHappenedAdverb GetRandomTellWhereItHappendAdverb()
        {
            return (TellWhereItHappenedAdverb)typeof(TellWhereItHappenedAdverb).GetRandomWordFromVocabulary();
        }

        public static Compound GetRandomCompound()
        {
            return (Compound)typeof(Compound).GetRandomWordFromVocabulary();
        }
    }
}
