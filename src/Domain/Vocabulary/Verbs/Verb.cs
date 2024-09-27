using Domain.Common;
using Domain.Common.ValueObjects;
using Domain.Vocabulary.Verbs.ValueObjects;

namespace Domain.Vocabulary.Verbs;

public sealed class Verb : BaseWord<VerbId>
{
    public PastForm PastForm { get; }
    public PastParticipleForm PastParticipleForm { get; }
    public PresentParticipleForm PresentParticipleForm { get; }
    public ThirdPersonForm ThirdPersonForm { get; }
    public StressOnFinalSyllable Stress { get; }
    public IsIrregularVerb IsIrregularVerb { get; }

    private Verb(VerbId id, Text text, PastForm pastForm, PastParticipleForm pastParticipleForm, PresentParticipleForm presentParticipleForm, ThirdPersonForm thirdPersonForm, StressOnFinalSyllable stress, IsIrregularVerb isIrregularVerb) : base(id, text)
    {
        PastForm = pastForm;
        PastParticipleForm = pastParticipleForm;
        PresentParticipleForm = presentParticipleForm;
        ThirdPersonForm = thirdPersonForm;
        Stress = stress;
        IsIrregularVerb = isIrregularVerb;
    }

    public static Verb Create(Text text, PastForm pastForm, PastParticipleForm pastParticipleForm, PresentParticipleForm presentParticipleForm, ThirdPersonForm thirdPersonForm, StressOnFinalSyllable stress, IsIrregularVerb isIrregularVerb)
    {
        return new Verb(VerbId.CreateUnique(), text, pastForm, pastParticipleForm, presentParticipleForm, thirdPersonForm, stress, isIrregularVerb);
    }
}