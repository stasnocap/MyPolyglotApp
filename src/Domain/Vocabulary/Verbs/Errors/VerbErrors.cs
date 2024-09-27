using ErrorOr;

namespace Domain.Vocabulary.Verbs.Errors;

public static class VerbErrors
{
    public static readonly Error EmptyVerbText = Error.Validation("Verb.EmptyText", "Verb text can't be empty.");
    public static readonly Error EmptyPastForm = Error.Validation("Verb.EmptyPastForm", "Past form can't be empty.");
    public static readonly Error EmptyPastParticipleForm = Error.Validation("Verb.EmptyPastParticipleForm", "Past participle form can't be empty.");
    public static readonly Error EmptyPresentParticipleForm = Error.Validation("Verb.EmptyPresentParticipleForm", "Present participle form can't be empty.");
    public static readonly Error EmptyThirdPersonForm = Error.Validation("Verb.EmptyThirdPersonForm", "Third person form can't be empty.");
}