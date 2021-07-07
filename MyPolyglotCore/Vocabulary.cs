using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using MyPolyglotCore;
using MyPolyglotCore.Words;
using MyPolyglotCore.Words.Pronouns;

namespace MyPolyglotCore
{
    public class Vocabulary
    {
        #region Pronouns

        public IReadOnlyList<SubjectPronoun> SubjectPronouns = new List<SubjectPronoun>
        {
            new SubjectPronoun(){ Text = "i" },
            new SubjectPronoun(){ Text = "you" },
            new SubjectPronoun(){ Text = "he" },
            new SubjectPronoun(){ Text = "she" },
            new SubjectPronoun(){ Text = "it" },
            new SubjectPronoun(){ Text = "we" },
            new SubjectPronoun(){ Text = "they" }
        };

        public IReadOnlyList<ObjectPronoun> ObjectPronouns = new List<ObjectPronoun>
        {
            new ObjectPronoun() { Text = "me" },
            new ObjectPronoun() { Text = "you" },
            new ObjectPronoun() { Text = "him" },
            new ObjectPronoun() { Text = "her" },
            new ObjectPronoun() { Text = "it" },
            new ObjectPronoun() { Text = "us" },
            new ObjectPronoun() { Text = "you" },
            new ObjectPronoun() { Text = "them" }
        };

        public IReadOnlyList<PossessiveAdjective> PossessiveAdjectives = new List<PossessiveAdjective>
        {
            new PossessiveAdjective() { Text = "my" },
            new PossessiveAdjective() { Text = "your" },
            new PossessiveAdjective() { Text = "his" },
            new PossessiveAdjective() { Text = "her" },
            new PossessiveAdjective() { Text = "its" },
            new PossessiveAdjective() { Text = "our" },
            new PossessiveAdjective() { Text = "their" }
        };

        public IReadOnlyList<PossessivePronoun> PossessivePronouns = new List<PossessivePronoun>
        {
            new PossessivePronoun() { Text = "mine" },
            new PossessivePronoun() { Text = "yours" },
            new PossessivePronoun() { Text = "his" },
            new PossessivePronoun() { Text = "hers" },
            new PossessivePronoun() { Text = "ours" },
            new PossessivePronoun() { Text = "theirs" }
        };

        public IReadOnlyList<ReflexivePronoun> ReflexivePronouns = new List<ReflexivePronoun>
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

        public IReadOnlyList<Determiner> Determiners = new List<Determiner>
        {
            new Determiner() { Text = "the" },
            new Determiner() { Text = "a" },
            new Determiner() { Text = "an" }
        };

        public IReadOnlyList<Adjective> Adjectives => new List<Adjective>
        {
            new Adjective() { Text = "other" },
            new Adjective() { Text = "new" },
            new Adjective() { Text = "old" },
            new Adjective() { Text = "eat" },
            new Adjective() { Text = "big" },
            new Adjective() { Text = "large" }
        };

        public IReadOnlyList<Noun> Nouns = new List<Noun>
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

        public IReadOnlyList<Verb> Verbs = new List<Verb>
        {
            new Verb() { Text = "be" },
            new Verb() { Text = "have" },
            new Verb() { Text = "do" },
            new Verb() { Text = "say" },
            new Verb() { Text = "get" },
            new Verb() { Text = "make" },
            new Verb() { Text = "go" },
            new Verb() { Text = "know" },
            new Verb() { Text = "take" },
            new Verb() { Text = "see" },
        };

        public IReadOnlyList<Verb> IrregularVerbs => new List<Verb>{
            new Verb() { Text = "abide", PastTense = "abode", PastParticle =  "abode" },
            new Verb() { Text = "arise", PastTense = "arose", PastParticle =  "arise" },
            new Verb() { Text = "awake", PastTense = "awoke", PastParticle =  "awoken" },
        };

        public IReadOnlyList<Word> GetVocabulary(Word word)
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
                Verb v => Verbs,
                _ => throw new NotSupportedException(),
            };
            return vocabulary;
        }
    }
}