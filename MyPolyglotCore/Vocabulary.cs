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

        public IReadOnlyList<Determiner> Determiners => new List<string> { "the", "a", "an" };
        public List<string> Adjectives => new List<string> { "other", "new", "ood", "igh", "old", "eat", "big", "can", "all", "large", "national", "young", "different", "black", "long", "little", "important", "political", "bad", "white", "real", "best", "right", "social", "only", "public", "sure", "low", "early", "able", "human", "local", "late", "hard", "major", "better", "economic", "strong", "possible", "whole", "free", "military", "true", "federal", "international", "full", "special", "easy", "clear", "recent", "certain", "personal", "open", "red", "difficult", "available", "likely", "short", "single", "medical", "current", "wrong", "private", "past", "foreign", "fine", "common", "poor", "natural", "significant", "similar", "hot", "dead", "central", "happy", "serious", "ready", "simple", "left", "physical", "general", "environmental", "financial", "blue", "democratic", "dark", "various", "entire", "close", "legal", "religious", "cold", "final", "main", "green", "nice", "huge", "popular", "traditional", "cultural" };
        public List<string> Nouns => new List<string> { "man", "mountain", "state", "ocean", "country", "building", "cat", "airline" };
        public List<string> Verbs => new List<string> { "be", "have", "do", "say", "get", "make", "go", "know", "take", "see", "come", "think", "look", "want", "give", "use", "find", "tell", "ask", "work", "seem", "feel", "try", "leave", "call", };
        public Verb[] IrregularVerbs => new Verb[]{
            new Verb() { Text = "abide", PastTense = "abode", PastParticle =  "abode" },
            new Verb() { Text = "arise", PastTense = "arose", PastParticle =  "arise" },
            new Verb() { Text = "awake", PastTense = "awoke", PastParticle =  "awoken" },
        };

        public List<string> GetVocabulary(Word word)
        {
            var vocabulary = word switch
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