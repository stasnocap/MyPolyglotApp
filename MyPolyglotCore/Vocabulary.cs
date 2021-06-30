using System;
using MyPolyglotCore;
using MyPolyglotCore.Words;
using MyPolyglotCore.Words.Pronouns;

namespace MyPolyglotCore
{
    public class Vocabulary
    {
        #region Pronouns
        public string[] SubjectPronouns => new string[] { "i", "you", "he", "she", "it", "we", "they" };
        public string[] ObjectPronouns => new string[] { "me", "you", "him", "her", "it", "us", "you", "them" };
        public string[] PossessiveAdjectives => new string[] { "my", "your", "his", "her", "its", "our", "their" };
        public string[] PossessivePronouns => new string[] { "mine", "yours", "his", "hers", "ours", "theirs" };
        public string[] ReflexivePronouns => new string[] { "myself", "yourself", "himself", "herself", "itself", "ourselves", "yourselves", "themselves" };
        #endregion

        public string[] Determiners => new string[] { "the", "a", "an" };
        public string[] Adjectives => new string[] { "other", "new", "ood", "igh", "old", "eat", "big", "can", "all", "large", "national", "young", "different", "black", "long", "little", "important", "political", "bad", "white", "real", "best", "right", "social", "only", "public", "sure", "low", "early", "able", "human", "local", "late", "hard", "major", "better", "economic", "strong", "possible", "whole", "free", "military", "true", "federal", "international", "full", "special", "easy", "clear", "recent", "certain", "personal", "open", "red", "difficult", "available", "likely", "short", "single", "medical", "current", "wrong", "private", "past", "foreign", "fine", "common", "poor", "natural", "significant", "similar", "hot", "dead", "central", "happy", "serious", "ready", "simple", "left", "physical", "general", "environmental", "financial", "blue", "democratic", "dark", "various", "entire", "close", "legal", "religious", "cold", "final", "main", "green", "nice", "huge", "popular", "traditional", "cultural" };
        public string[] Nouns => new string[] { "man", "mountain", "state", "ocean", "country", "building", "cat", "airline" };
        public string[] Verbs => new string[] { "be", "have", "do", "say", "get", "make", "go", "know", "take", "see", "come", "think", "look", "want", "give", "use", "find", "tell", "ask", "work", "seem", "feel", "try", "leave", "call", };
        public Verb[] IrregularVerbs => new Verb[]{
            new Verb() { Text = "abide", PastTense = "abode", PastParticle =  "abode" },
            new Verb() { Text = "arise", PastTense = "arose", PastParticle =  "arise" },
            new Verb() { Text = "awake", PastTense = "awoke", PastParticle =  "awoken" },
        };

        public string[] GetVocabulary(Word word)
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