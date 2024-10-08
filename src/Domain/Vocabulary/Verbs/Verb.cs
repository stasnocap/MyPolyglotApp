using Domain.Common;
using Domain.Common.Extensions;
using Domain.Common.ValueObjects;
using Domain.Vocabulary.Verbs.ValueObjects;
using ErrorOr;

namespace Domain.Vocabulary.Verbs;

public sealed class Verb : BaseWord<VerbId>
{
    public PastForm PastForm { get; }
    public PastParticipleForm PastParticipleForm { get; }
    public PresentParticipleForm PresentParticipleForm { get; }
    public ThirdPersonForm ThirdPersonForm { get; }
    public IsIrregularVerb IsIrregularVerb { get; }

    private Verb(VerbId id, Text text, PastForm pastForm, PastParticipleForm pastParticipleForm, PresentParticipleForm presentParticipleForm, ThirdPersonForm thirdPersonForm, IsIrregularVerb isIrregularVerb) : base(id, text)
    {
        PastForm = pastForm;
        PastParticipleForm = pastParticipleForm;
        PresentParticipleForm = presentParticipleForm;
        ThirdPersonForm = thirdPersonForm;
        IsIrregularVerb = isIrregularVerb;
    }

    public static Verb Create(Text text, PastForm pastForm, PastParticipleForm pastParticipleForm, PresentParticipleForm presentParticipleForm, ThirdPersonForm thirdPersonForm, IsIrregularVerb isIrregularVerb)
    {
        return new Verb(VerbId.CreateUnique(), text, pastForm, pastParticipleForm, presentParticipleForm, thirdPersonForm, isIrregularVerb);
    }

    public static ErrorOr<Verb> CreateIrregularVerb(VerbId verbId, Text text, PastForm pastForm, PastParticipleForm pastParticipleForm)
    {
        var errors = new List<Error>();
        
        var errorOrPresentParticipleForm = PresentParticipleForm.From(text, true).ElseAccumulate(errors);
        var errorOrThirdPersonForm = ThirdPersonForm.From(text).ElseAccumulate(errors);

        if (errors.Count > 0)
        {
            return errors;
        }
        
        return new Verb(verbId, text, pastForm, pastParticipleForm, errorOrPresentParticipleForm.Value, errorOrThirdPersonForm.Value, IsIrregularVerb.Create(true));
    }
}