using Domain.Common;
using Domain.Common.ValueObjects;
using Domain.Vocabulary.ModalVerbs.ValueObjects;

namespace Domain.Vocabulary.ModalVerbs;

public sealed class ModalVerb : BaseWord<ModalVerbId>
{
    public FullNegativeForm FullNegativeForm { get; }
    public ShortNegativeForm ShortNegativeForm { get; }

    private ModalVerb(ModalVerbId id, Text text, FullNegativeForm fullNegativeForm, ShortNegativeForm shortNegativeForm) : base(id, text)
    {
        FullNegativeForm = fullNegativeForm;
        ShortNegativeForm = shortNegativeForm;
    }

    public static ModalVerb Create(Text text, FullNegativeForm fullNegativeForm, ShortNegativeForm shortNegativeForm)
    {
        return new ModalVerb(ModalVerbId.CreateUnique(), text, fullNegativeForm, shortNegativeForm);
    }
}