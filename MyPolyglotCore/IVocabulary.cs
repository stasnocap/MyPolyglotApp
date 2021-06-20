using MyPolyglotCore.Words;

namespace MyPolyglotCore
{
    public interface IVocabulary
    {
        string[] SubjectPronouns { get; }
        string[] ObjectPronouns { get; }
        string[] PossessiveAdjectives { get; }
        string[] PossessivePronouns { get; }
        string[] ReflexivePronouns { get; }
        string[] Determiners { get; }
        string[] Adjectives { get; }
        string[] Nouns { get; }
        string[] Verbs { get; }
        Verb[] IrregularVerbs { get; }

        string[] GetVocabulary(Word word);
    }
}