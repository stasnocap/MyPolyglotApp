using System;
using System.Collections.Generic;
using System.Linq;
using MyPolyglotCore.Words;
using MyPolyglotCore.Words.Pronouns;

namespace MyPolyglotCore
{
    public class Vocabulary
    {
        #region Letters
        private IReadOnlyCollection<char> _consonants = new HashSet<char>()
        {
            'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm',
            'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z'
        };
        private IReadOnlyCollection<char> _vowels = new HashSet<char>()
        {
            'a', 'e', 'i', 'o', 'u', 'y'
        };
        #endregion

        #region Pronouns

        public IReadOnlyCollection<SubjectPronoun> SubjectPronouns { get; } = new HashSet<SubjectPronoun>
        {
            new SubjectPronoun(){ Text = "i" },
            new SubjectPronoun(){ Text = "you" },
            new SubjectPronoun(){ Text = "he" },
            new SubjectPronoun(){ Text = "she" },
            new SubjectPronoun(){ Text = "it" },
            new SubjectPronoun(){ Text = "we" },
            new SubjectPronoun(){ Text = "they" }
        };

        public IReadOnlyCollection<ObjectPronoun> ObjectPronouns { get; } = new HashSet<ObjectPronoun>
        {
            new ObjectPronoun() { Text = "me" },
            new ObjectPronoun() { Text = "him" },
            new ObjectPronoun() { Text = "us" },
            new ObjectPronoun() { Text = "them" }
        };

        public IReadOnlyCollection<PossessiveAdjective> PossessiveAdjectives { get; } = new HashSet<PossessiveAdjective>
        {
            new PossessiveAdjective() { Text = "my" },
            new PossessiveAdjective() { Text = "your" },
            new PossessiveAdjective() { Text = "his" },
            new PossessiveAdjective() { Text = "her" },
            new PossessiveAdjective() { Text = "its" },
            new PossessiveAdjective() { Text = "our" },
            new PossessiveAdjective() { Text = "their" }
        };

        public IReadOnlyCollection<PossessivePronoun> PossessivePronouns { get; } = new HashSet<PossessivePronoun>
        {
            new PossessivePronoun() { Text = "mine" },
            new PossessivePronoun() { Text = "yours" },
            new PossessivePronoun() { Text = "hers" },
            new PossessivePronoun() { Text = "ours" },
            new PossessivePronoun() { Text = "theirs" }
        };

        public IReadOnlyCollection<ReflexivePronoun> ReflexivePronouns { get; } = new HashSet<ReflexivePronoun>
        {
            new ReflexivePronoun() { Text = "myself" },
            new ReflexivePronoun() { Text = "yourself" },
            new ReflexivePronoun() { Text = "himself" },
            new ReflexivePronoun() { Text = "herself" },
            new ReflexivePronoun() { Text = "itself" },
            new ReflexivePronoun() { Text = "ourselves" },
            new ReflexivePronoun() { Text = "yourselves" },
            new ReflexivePronoun() { Text = "themselves" },
        };

        #endregion

        public IReadOnlyCollection<Determiner> Determiners { get; } = new HashSet<Determiner>
        {
            new Determiner() { Text = "the" },
            new Determiner() { Text = "a" },
            new Determiner() { Text = "an" }
        };

        public IReadOnlyCollection<Adjective> Adjectives { get; } = new HashSet<Adjective>
        {
            new Adjective() { Text = "other" },
            new Adjective() { Text = "new" },
            new Adjective() { Text = "old" },
            new Adjective() { Text = "eat" },
            new Adjective() { Text = "big" },
            new Adjective() { Text = "large" }
        };

        public IReadOnlyCollection<Noun> Nouns { get; } = new HashSet<Noun>
        {
            new Noun() { Text = "man" },
            new Noun() { Text = "mountain" },
            new Noun() { Text = "state" },
            new Noun() { Text = "ocean" },
            new Noun() { Text = "country" },
            new Noun() { Text = "building" },
            new Noun() { Text = "cat" },
            new Noun() { Text = "airline" }
        };

        #region Verbs
        public IReadOnlyCollection<Verb> Verbs => new HashSet<Verb>
        {
            new Verb(_consonants, _vowels) { Text = "be" },
            new Verb(_consonants, _vowels) { Text = "have" },
            new Verb(_consonants, _vowels) { Text = "do" },
            new Verb(_consonants, _vowels) { Text = "say" },
            new Verb(_consonants, _vowels) { Text = "get" },
            new Verb(_consonants, _vowels) { Text = "make" },
            new Verb(_consonants, _vowels) { Text = "go" },
            new Verb(_consonants, _vowels) { Text = "know" },
            new Verb(_consonants, _vowels) { Text = "take" },
            new Verb(_consonants, _vowels) { Text = "see" },
        };

        public IReadOnlyCollection<Verb> IrregularVerbs => new HashSet<Verb>
        {
            new Verb(_consonants, _vowels) { Text = "abide", PastForm = "abode", PastParticipleForm =  "abode" },
            new Verb(_consonants, _vowels) { Text = "arise", PastForm = "arose", PastParticipleForm =  "arise" },
            new Verb(_consonants, _vowels) { Text = "awake", PastForm = "awoke", PastParticipleForm =  "awoken" },
            new Verb(_consonants, _vowels) { Text = "be", PastForm = "was", PastParticipleForm =  "been", 
                AdditionalForms = new HashSet<string>() { "were", "am", "is", "are" }
            },
            new Verb(_consonants, _vowels) { Text = "bear", PastForm = "bore", PastParticipleForm =  "born",
                AdditionalForms = new HashSet<string>() { "borne" },
            },
            new Verb(_consonants, _vowels) { Text = "beat", PastForm = "beat", PastParticipleForm =  "beaten" },
            new Verb(_consonants, _vowels) { Text = "become", PastForm = "became", PastParticipleForm =  "become" },
            new Verb(_consonants, _vowels) { Text = "beget", PastForm = "begot", PastParticipleForm =  "begotten",
                AdditionalForms = new HashSet<string>() { "begat" },
            },
        };
        #endregion

        public IReadOnlyCollection<Word> RecognizableVocabularies => Enumerable.Empty<Word>()
            .Concat(SubjectPronouns)
            .Concat(ObjectPronouns)
            .Concat(PossessiveAdjectives)
            .Concat(PossessivePronouns)
            .Concat(ReflexivePronouns)
            .Concat(Determiners)
            .Concat(IrregularVerbs)
            .ToHashSet();

        public IReadOnlyCollection<Word> GetVocabulary(Word word)
        {
            dynamic vocabulary = word switch
            {
                SubjectPronoun s => SubjectPronouns,
                ObjectPronoun o => ObjectPronouns,
                PossessiveAdjective p => PossessiveAdjectives,
                PossessivePronoun p => PossessivePronouns,
                ReflexivePronoun r => ReflexivePronouns,
                Determiner d => Determiners,
                Adjective a => Adjectives,
                Noun n => Nouns,
                Verb v => IrregularVerbs,
                _ => throw new NotSupportedException(),
            };
            return vocabulary;
        }
    }
}