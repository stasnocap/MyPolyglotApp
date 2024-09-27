using ErrorOr;

namespace Domain.Vocabulary.PrimaryVerbs.Errors;

public static class PrimaryVerbErrors
{
    public static readonly Error EmptyAdditionalForm = Error.Validation("ModalVerb.EmptyAdditionalForm", "Additional form can't be empty.");
}