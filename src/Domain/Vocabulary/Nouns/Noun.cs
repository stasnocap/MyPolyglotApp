using Domain.Common;
using Domain.Common.ValueObjects;
using Domain.Vocabulary.Nouns.ValueObjects;

namespace Domain.Vocabulary.Nouns;

public sealed class Noun : BaseWord<NounId>
{
    public PluralForm PluralForm { get; }

    private Noun(NounId id, Text text, PluralForm pluralForm) : base(id, text)
    {
        PluralForm = pluralForm;
    }

    public static Noun Create(Text text, PluralForm pluralForm)
    {
        return new Noun(NounId.CreateUnique(), text, pluralForm);
    }
}