using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Linq;
using MyPolyglotCore;
using MyPolyglotCore.Words;
using MyPolyglotCore.Words.Pronouns;

namespace MyPolyglotCore
{
    public class Vocabulary
    {
        #region Pronouns

        public IReadOnlyCollection<SubjectPronoun> SubjectPronouns = new HashSet<SubjectPronoun>
        {
            new SubjectPronoun(){ Text = "i" },
            new SubjectPronoun(){ Text = "you" },
            new SubjectPronoun(){ Text = "he" },
            new SubjectPronoun(){ Text = "she" },
            new SubjectPronoun(){ Text = "it" },
            new SubjectPronoun(){ Text = "we" },
            new SubjectPronoun(){ Text = "they" }
        };

        public IReadOnlyCollection<ObjectPronoun> ObjectPronouns = new HashSet<ObjectPronoun>
        {
            new ObjectPronoun() { Text = "me" },
            new ObjectPronoun() { Text = "him" },
            new ObjectPronoun() { Text = "us" },
            new ObjectPronoun() { Text = "them" }
        };

        public IReadOnlyCollection<PossessiveAdjective> PossessiveAdjectives = new HashSet<PossessiveAdjective>
        {
            new PossessiveAdjective() { Text = "my" },
            new PossessiveAdjective() { Text = "your" },
            new PossessiveAdjective() { Text = "his" },
            new PossessiveAdjective() { Text = "her" },
            new PossessiveAdjective() { Text = "its" },
            new PossessiveAdjective() { Text = "our" },
            new PossessiveAdjective() { Text = "their" }
        };

        public IReadOnlyCollection<PossessivePronoun> PossessivePronouns = new HashSet<PossessivePronoun>
        {
            new PossessivePronoun() { Text = "mine" },
            new PossessivePronoun() { Text = "yours" },
            new PossessivePronoun() { Text = "hers" },
            new PossessivePronoun() { Text = "ours" },
            new PossessivePronoun() { Text = "theirs" }
        };

        public IReadOnlyCollection<ReflexivePronoun> ReflexivePronouns = new HashSet<ReflexivePronoun>
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

        public IReadOnlyCollection<Determiner> Determiners = new HashSet<Determiner>
        {
            new Determiner() { Text = "the" },
            new Determiner() { Text = "a" },
            new Determiner() { Text = "an" }
        };

        public IReadOnlyCollection<Adjective> Adjectives => new HashSet<Adjective>
        {
            new Adjective() { Text = "other" },
            new Adjective() { Text = "new" },
            new Adjective() { Text = "old" },
            new Adjective() { Text = "eat" },
            new Adjective() { Text = "big" },
            new Adjective() { Text = "large" }
        };

        public IReadOnlyCollection<Noun> Nouns = new HashSet<Noun>
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

        public IReadOnlyCollection<Verb> Verbs = new HashSet<Verb>
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

        public IReadOnlyCollection<Verb> IrregularVerbs = new HashSet<Verb>{
            new Verb() { Text = "abide", PastTense = "abode", PastParticle =  "abode" },
            new Verb() { Text = "arise", PastTense = "arose", PastParticle =  "arise" },
            new Verb() { Text = "awake", PastTense = "awoke", PastParticle =  "awoken" },


            new Verb() { Text = "beat", PastTense = "beat", PastParticle =  "beaten" },
            new Verb() { Text = "become", PastTense = "became", PastParticle =  "become" },
        };

        public IReadOnlyCollection<Word> RecognizableVocabularies => Enumerable.Empty<Word>()
            .Concat(SubjectPronouns)
            .Concat(ObjectPronouns)
            .Concat(PossessiveAdjectives)
            .Concat(PossessivePronouns)
            .Concat(ReflexivePronouns)
            .Concat(Determiners)
            .Concat(IrregularVerbs)
            .ToList();

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