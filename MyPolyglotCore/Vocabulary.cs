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

        public static IReadOnlyCollection<string> ThirdPersonESEndings { get; } = new HashSet<string>() { "ch", "s", "sh", "x", "z" };
        public const string IngEnding = "ing";
        public const string EdEnding = "ed";

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

        public static IReadOnlyCollection<Verb> IrregularVerbs = new HashSet<Verb>
        {
            new Verb("abide", "abode", "abode"),
            new Verb("arise", "arose", "arise"),
            new Verb("awake", "awoke", "awoken"),
            new Verb("bear", "bore", "born"),
            new Verb("beat", "beat", "beaten"),
            new Verb("become", "became", "become"),
            new Verb("beget", "begot", "begotten"),
        };

        public static IReadOnlyCollection<PrimaryVerb> PrimaryVerbs = new HashSet<PrimaryVerb>
        {
            new PrimaryVerb("do", "did", "done", "doing", "does", new HashSet<string> { "don't", "didn't", "doesn't"}),
            new PrimaryVerb("have", "had", "had", "having", "has", new HashSet<string> { "haven't", "hadn't", "hasn't"}),
            new PrimaryVerb("be", "was", "been", "being", "is", new HashSet<string> { "wasn't", "weren't", "am not", "isn't", "aren't"},
                new HashSet<string> { "were", "am", "is", "are" })
        };

        public static IReadOnlyCollection<PrimaryVerb> PrimaryVerbs = new HashSet<PrimaryVerb>
        {
            //new PrimaryVerb("do", "did", "done")
        };

        public static IReadOnlyCollection<Word> RecognizableVocabularies => Enumerable.Empty<Word>()
            .Concat(SubjectPronouns)
            .Concat(ObjectPronouns)
            .Concat(PossessiveAdjectives)
            .Concat(PossessivePronouns)
            .Concat(ReflexivePronouns)
            .Concat(Determiners)
            .Concat(IrregularVerbs)
            .Concat(PrimaryVerbs)
            .ToHashSet();

        public static IReadOnlyCollection<Word> GetVocabulary(Type type)
        {
            dynamic vocabulary = type.Name switch
            {
                nameof(SubjectPronoun) => SubjectPronouns,
                nameof(ObjectPronoun) => ObjectPronouns,
                nameof(PossessiveAdjective) => PossessiveAdjectives,
                nameof(PossessivePronoun) => PossessivePronouns,
                nameof(ReflexivePronoun) => ReflexivePronouns,
                nameof(Determiner) => Determiners,
                nameof(Verb) => IrregularVerbs,
                nameof(Noun) => Nouns,
                nameof(Adjective) => Adjectives,
                _ => throw new NotImplementedException(),
            };
            return vocabulary;
        }
    }
}