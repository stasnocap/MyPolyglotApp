using Domain.Practice.Exercises.ValueObjects;
using Domain.Vocabulary.Adjectives;
using Domain.Vocabulary.Adverbs;
using Domain.Vocabulary.Cities;
using Domain.Vocabulary.ComparisonAdjectives;
using Domain.Vocabulary.Compounds;
using Domain.Vocabulary.Determiners;
using Domain.Vocabulary.Languages;
using Domain.Vocabulary.LetterNumbers;
using Domain.Vocabulary.ModalVerbs;
using Domain.Vocabulary.Nouns;
using Domain.Vocabulary.NumberWithNouns;
using Domain.Vocabulary.Prepositions;
using Domain.Vocabulary.PrimaryVerbs;
using Domain.Vocabulary.Pronouns;
using Domain.Vocabulary.QuestionWords;
using Domain.Vocabulary.Verbs;

namespace Domain.Common;

public static class WordTypes
{
    public static Type GetWordType(WordType type) => type switch
    {
        WordType.Adjective => typeof(Adjective),
        WordType.Adverb => typeof(Adverb),
        WordType.City => typeof(City),
        WordType.ComparisonAdjective => typeof(ComparisonAdjective),
        WordType.Compound => typeof(Compound),
        WordType.Determiner => typeof(Determiner),
        WordType.Language => typeof(Language),
        WordType.LetterNumber => typeof(LetterNumber),
        WordType.ModalVerb => typeof(ModalVerb),
        WordType.Noun => typeof(Noun),
        WordType.NumberWithNoun => typeof(NumberWithNoun),
        WordType.Preposition => typeof(Preposition),
        WordType.PrimaryVerb => typeof(PrimaryVerb),
        WordType.Pronoun => typeof(Pronoun),
        WordType.QuestionWord => typeof(QuestionWord),
        WordType.Verb => typeof(Verb),
        WordType.None => throw new ArgumentOutOfRangeException(nameof(type), type, null),
        _ => throw new ArgumentOutOfRangeException(nameof(type), type, null),
    };
}