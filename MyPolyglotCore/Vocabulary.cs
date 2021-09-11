using System;
using System.Collections.Generic;
using System.Linq;
using MyPolyglotCore.Words;
using MyPolyglotCore.Words.Pronouns;

namespace MyPolyglotCore
{
    public static class Vocabulary
    {
        #region Letters
        public static readonly IEnumerable<char> Consonants = new char[]
        {
            'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm',
            'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z'
        };
        public static readonly IEnumerable<char> Vowels = new char[]
        {
            'a', 'e', 'i', 'o', 'u', 'y'
        };
        #endregion

        public static readonly IEnumerable<string> ThirdPersonESEndings = new string[] { "ch", "s", "sh", "x", "z" };
        public const string IngEnding = "ing";
        public const string EdEnding = "ed";

        #region Pronouns

        public static readonly IEnumerable<SubjectPronoun> SubjectPronouns = new SubjectPronoun[]
        {
            new SubjectPronoun("i"),
            new SubjectPronoun("you"),
            new SubjectPronoun("he"),
            new SubjectPronoun("she"),
            new SubjectPronoun("it"),
            new SubjectPronoun("we"),
            new SubjectPronoun("they"),
        };

        public static readonly IEnumerable<ObjectPronoun> ObjectPronouns = new ObjectPronoun[]
        {
            new ObjectPronoun("me"),
            new ObjectPronoun("him"),
            new ObjectPronoun("us"),
            new ObjectPronoun("them"),
        };

        public static readonly IEnumerable<PossessiveAdjective> PossessiveAdjectives = new PossessiveAdjective[]
        {
            new PossessiveAdjective("my"),
            new PossessiveAdjective("your"),
            new PossessiveAdjective("his"),
            new PossessiveAdjective("her"),
            new PossessiveAdjective("its"),
            new PossessiveAdjective("our"),
            new PossessiveAdjective("their"),
        };

        public static readonly IEnumerable<PossessivePronoun> PossessivePronouns = new PossessivePronoun[]
        {
            new PossessivePronoun("mine"),
            new PossessivePronoun("hers"),
            new PossessivePronoun("ours"),
            new PossessivePronoun("theirs"),
        };

        public static readonly IEnumerable<ReflexivePronoun> ReflexivePronouns = new ReflexivePronoun[]
        {
            new ReflexivePronoun("myself"),
            new ReflexivePronoun("yourself"),
            new ReflexivePronoun("himself"),
            new ReflexivePronoun("herself"),
            new ReflexivePronoun("itself"),
            new ReflexivePronoun("ourselves"),
            new ReflexivePronoun("yourselves"),
            new ReflexivePronoun("themselves"),
        };

        #endregion

        public static readonly IEnumerable<Determiner> Determiners = new Determiner[]
        {
            new Determiner("the"),
            new Determiner("a"),
            new Determiner("an"),
        };

        public static readonly IEnumerable<Adjective> Adjectives = new Adjective[]
        {
            new Adjective("other"),
            new Adjective("new"),
            new Adjective("old"),
            new Adjective("big"),
            new Adjective("large"),
        };

        public static readonly IEnumerable<Noun> Nouns = new Noun[]
        {
            new Noun("man"),
            new Noun("mountain"),
            new Noun("state"),
            new Noun("ocean"),
            new Noun("country"),
            new Noun("building"),
            new Noun("cat"),
            new Noun("airline"),
        };

        public static readonly IEnumerable<Verb> IrregularVerbs = new Verb[]
        {
            new Verb("abide", "abode", "abode"),
            new Verb("arise", "arose", "arise"),
            new Verb("awake", "awoke", "awoken"),
            new Verb("bear", "bore", "born"),
            new Verb("beat", "beat", "beaten"),
            new Verb("become", "became", "become"),
            new Verb("beget", "begot", "begotten"),
        };

        public static readonly IEnumerable<PrimaryVerb> PrimaryVerbs = new PrimaryVerb[]
        {
            new PrimaryVerb("do", "did", "done", "doing", "does",
                new HashSet<string> { "don't", "didn't", "doesn't"},
                new HashSet<string> { "do not", "did not", "does not"}),
            new PrimaryVerb("have", "had", "had", "having", "has",
                new HashSet<string> { "haven't", "hadn't", "hasn't"},
                new HashSet<string>{ "have not", "had not", "has not"}),
            new PrimaryVerb("be", "was", "been", "being", "is",
                new HashSet<string> { "wasn't", "weren't", "am not", "isn't", "aren't"},
                new HashSet<string> { "was not", "were not", "am not", "is not", "are not" },
                new HashSet<string> { "were", "am", "is", "are" })
        };

        public static readonly IEnumerable<ModalVerb> ModalVerbs = new ModalVerb[]
        {
            new ModalVerb("can"),
            new ModalVerb("could"),
            new ModalVerb("may"),
            new ModalVerb("might"),
            new ModalVerb("will"),
            new ModalVerb("shall"),
            new ModalVerb("would"),
            new ModalVerb("should"),
            new ModalVerb("must"),
        };

        public static readonly IEnumerable<Word> RecognizableVocabularies = Enumerable.Empty<Word>()
            .Concat(SubjectPronouns)
            .Concat(ObjectPronouns)
            .Concat(PossessiveAdjectives)
            .Concat(PossessivePronouns)
            .Concat(ReflexivePronouns)
            .Concat(Determiners)
            .Concat(IrregularVerbs)
            .Concat(PrimaryVerbs)
            .Concat(ModalVerbs);

        public static IEnumerable<Word> GetVocabulary(Type typeOfWord)
        {
            dynamic vocabulary = typeOfWord switch
            {
                Type subjectPronoun when subjectPronoun == typeof(SubjectPronoun) => SubjectPronouns,
                Type objectPronoun when objectPronoun == typeof(ObjectPronoun) => ObjectPronouns,
                Type possessiveAdjective when possessiveAdjective == typeof(PossessiveAdjective) => PossessiveAdjectives,
                Type possessivePronoun when possessivePronoun == typeof(PossessivePronoun) => PossessivePronouns,
                Type reflexivePronoun when reflexivePronoun == typeof(ReflexivePronoun) => ReflexivePronouns,
                Type determiner when determiner == typeof(Determiner) => Determiners,
                Type verb when verb == typeof(Verb) => IrregularVerbs,
                Type noun when noun == typeof(Noun) => Nouns,
                Type adjective when adjective == typeof(Adjective) => Adjectives,
                Type modalVerb when modalVerb == typeof(ModalVerb) => ModalVerbs,
                _ => throw new NotImplementedException(),
            };
            return vocabulary;
        }
    }
}