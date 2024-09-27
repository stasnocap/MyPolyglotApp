using Domain.Vocabulary.Nouns.ValueObjects;
using ErrorOr;

namespace Domain.Vocabulary.Nouns.Errors;

public static class NounErrors
{
    public static readonly Error EmptyPluralFormForm = Error.Validation("Noun.EmptyPluralForm", "Plural form can't be empty.");
}