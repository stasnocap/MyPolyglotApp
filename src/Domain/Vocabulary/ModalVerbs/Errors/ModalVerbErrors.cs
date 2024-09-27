using Domain.Vocabulary.ModalVerbs.ValueObjects;
using ErrorOr;

namespace Domain.Vocabulary.ModalVerbs.Errors;

public static class ModalVerbErrors
{
    public static readonly Error EmptyFullNegativeForm = Error.Validation("ModalVerb.EmptyFullNegativeForm", "Full negative form can't be empty.");
    public static readonly Error EmptyShortNegativeForm = Error.Validation("ModalVerb.EmptyShortNegativeForm", "Short negative form can't be empty.");
}