using Domain.Common;
using Domain.Common.ValueObjects;
using Domain.Vocabulary.ModalVerbs.ValueObjects;
using Domain.Vocabulary.PrimaryVerbs.ValueObjects;
using Domain.Vocabulary.Verbs.ValueObjects;

namespace Domain.Vocabulary.PrimaryVerbs;

public sealed class PrimaryVerb : BaseWord<PrimaryVerbId>
{
    private readonly List<FullNegativeForm> _fullNegativeForms = new();
    private readonly List<ShortNegativeForm> _shortNegativeForms = new();
    private readonly List<AdditionalForm> _additionalForms = new();

    public PastForm PastForm { get; }
    public PastParticipleForm PastParticipleForm { get; }
    public PresentParticipleForm PresentParticipleForm { get; }
    public ThirdPersonForm ThirdPersonForm { get; }
    public IReadOnlyList<FullNegativeForm> FullNegativeForms => _fullNegativeForms.AsReadOnly();
    public IReadOnlyList<ShortNegativeForm> ShortNegativeForms => _shortNegativeForms.AsReadOnly();
    public IReadOnlyList<AdditionalForm> AdditionalForms => _additionalForms.AsReadOnly();

    private PrimaryVerb(PrimaryVerbId id,
        Text text,
        PastForm pastForm,
        PastParticipleForm pastParticipleForm,
        PresentParticipleForm presentParticipleForm,
        ThirdPersonForm thirdPersonForm) : base(id, text)
    {
        PastForm = pastForm;
        PastParticipleForm = pastParticipleForm;
        PresentParticipleForm = presentParticipleForm;
        ThirdPersonForm = thirdPersonForm;
    }

    public static PrimaryVerb Create(Text text,
        PastForm pastForm,
        PastParticipleForm pastParticipleForm,
        PresentParticipleForm presentParticipleForm,
        ThirdPersonForm thirdPersonForm)
    {
        return new PrimaryVerb(PrimaryVerbId.CreateUnique(),
            text,
            pastForm,
            pastParticipleForm,
            presentParticipleForm,
            thirdPersonForm);
    }

    public static PrimaryVerb Create(PrimaryVerbId primaryVerbId,
        Text text,
        PastForm pastForm,
        PastParticipleForm pastParticipleForm,
        PresentParticipleForm presentParticipleForm,
        ThirdPersonForm thirdPersonForm)
    {
        return new PrimaryVerb(primaryVerbId,
            text,
            pastForm,
            pastParticipleForm,
            presentParticipleForm,
            thirdPersonForm);
    }

    public void AddFullNegativeForms(IReadOnlyList<FullNegativeForm> fullNegativeForms)
    {
        _fullNegativeForms.AddRange(fullNegativeForms);
    }

    public void AddShortNegativeForms(IReadOnlyList<ShortNegativeForm> shortNegativeForms)
    {
        _shortNegativeForms.AddRange(shortNegativeForms);
    }

    public void AddAdditionalForms(IReadOnlyList<AdditionalForm> additionalForms)
    {
        _additionalForms.AddRange(additionalForms);
    }
}