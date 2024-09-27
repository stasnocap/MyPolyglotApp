using ErrorOr;

namespace Domain.Vocabulary.ComparisonAdjectives.Errors;

public static class ComparisonAdjectiveErrors
{
    public static readonly Error EmptyComparisionAdjectiveText = Error.Validation("ComparisonAdjective.EmptyComparisionAdjectiveText", "Comparative adjective text can't be empty.");
    public static readonly Error EmptyComparativeForm = Error.Validation("ComparisonAdjective.EmptyComparativeForm", "Comparative form can't be empty.");
    public static readonly Error EmptySuperlativeForm = Error.Validation("ComparisonAdjective.EmptySuperlativeForm", "Superlative form can't be empty.");
    public static readonly Error SyllablesCountNegative = Error.Validation("ComparisonAdjective.CountOfSyllablesNegative", "Count of syllables can't be negative or zero.");
}