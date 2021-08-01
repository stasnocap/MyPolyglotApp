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
        public static IReadOnlyCollection<char> Consonants { get; } = new HashSet<char>()
        {
            'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm',
            'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z'
        };
        public static IReadOnlyCollection<char> Vowels { get; } = new HashSet<char>()
        {
            'a', 'e', 'i', 'o', 'u', 'y'
        };
        #endregion

        #region Pronouns

        public static IReadOnlyCollection<SubjectPronoun> SubjectPronouns { get; } = new HashSet<SubjectPronoun>
        {
            new SubjectPronoun("i"),
            new SubjectPronoun("you"),
            new SubjectPronoun("he"),
            new SubjectPronoun("she"),
            new SubjectPronoun("it"),
            new SubjectPronoun("we"),
            new SubjectPronoun("they"),
        };

        public static IReadOnlyCollection<ObjectPronoun> ObjectPronouns { get; } = new HashSet<ObjectPronoun>
        {
            new ObjectPronoun("me"),
            new ObjectPronoun("him"),
            new ObjectPronoun("us"),
            new ObjectPronoun("them"),
        };

        public static IReadOnlyCollection<PossessiveAdjective> PossessiveAdjectives { get; } = new HashSet<PossessiveAdjective>
        {
            new PossessiveAdjective("my"),
            new PossessiveAdjective("your"),
            new PossessiveAdjective("his"),
            new PossessiveAdjective("her"),
            new PossessiveAdjective("its"),
            new PossessiveAdjective("our"),
            new PossessiveAdjective("their"),
        };

        public static IReadOnlyCollection<PossessivePronoun> PossessivePronouns { get; } = new HashSet<PossessivePronoun>
        {
            new PossessivePronoun("mine"),
            new PossessivePronoun("hers"),
            new PossessivePronoun("ours"),
            new PossessivePronoun("theirs"),
        };

        public static IReadOnlyCollection<ReflexivePronoun> ReflexivePronouns { get; } = new HashSet<ReflexivePronoun>
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

        public static IReadOnlyCollection<Determiner> Determiners { get; } = new HashSet<Determiner>
        {
            new Determiner("the"),
            new Determiner("a"),
            new Determiner("an"),
        };

        public static IReadOnlyCollection<Adjective> Adjectives { get; } = new HashSet<Adjective>
        {
            new Adjective("other"),
            new Adjective("new"),
            new Adjective("old"),
            new Adjective("big"),
            new Adjective("large"),
        };

        public static IReadOnlyCollection<Noun> Nouns { get; } = new HashSet<Noun>
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

        #region Verbs
        public static IReadOnlyCollection<Verb> Verbs { get; } = new HashSet<Verb>
        {
        };

        public static IReadOnlyCollection<Verb> IrregularVerbs => new HashSet<Verb>
        {
            new Verb("abide", "abode", "abode"),
            new Verb("arise", "arose", "arise"),
            new Verb("awake", "awoke", "awoken"),
            new Verb("be", "was", "been", new HashSet<string>() { "were", "am", "is", "are" }),
            new Verb("bear", "bore", "born", new HashSet<string>() { "borne" }),
            new Verb("beat", "beat", "beaten"),
            new Verb("beat", "beat", "beaten"),
            new Verb("become", "became", "become"),
            new Verb("beget", "begot", "begotten", new HashSet<string>() { "begat" }),
        };
        #endregion

        public static IReadOnlyCollection<Word> RecognizableVocabularies => Enumerable.Empty<Word>()
            .Concat(SubjectPronouns)
            .Concat(ObjectPronouns)
            .Concat(PossessiveAdjectives)
            .Concat(PossessivePronouns)
            .Concat(ReflexivePronouns)
            .Concat(Determiners)
            .Concat(IrregularVerbs)
            .ToHashSet();

        public static IReadOnlyCollection<Word> GetVocabulary(Type type)
        {
            dynamic vocabulary = type.Name switch
            {
                "SubjectPronoun" => SubjectPronouns,
                "ObjectPronoun" => ObjectPronouns,
                "PossessiveAdjective" => PossessiveAdjectives,
                "PossessivePronoun" => PossessivePronouns,
                "ReflexivePronoun" => ReflexivePronouns,
                "Determiner" => Determiners,
                "Verb" => IrregularVerbs,
                "Noun" => Nouns,
                "Adjective" => Adjectives,
                _ => throw new NotSupportedException(),
            };
            return vocabulary;
        }

        public const string IngEnding = "ing";
        public const string EdEnding = "ed";
        public static IReadOnlyCollection<string> ThirdPersonESEndings { get; } = new HashSet<string>() { "ch", "s", "sh", "x", "z" };
    }
}