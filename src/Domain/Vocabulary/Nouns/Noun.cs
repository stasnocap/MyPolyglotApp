using Domain.Common;
using Domain.Common.ValueObjects;
using Domain.Vocabulary.Nouns.ValueObjects;

namespace Domain.Vocabulary.Nouns;

public sealed class Noun : BaseWord<NounId>
{
    public PluralForm PluralForm { get; }
    public NounType Type { get; }

    private Noun(NounId id, Text text, PluralForm pluralForm, NounType type) : base(id, text)
    {
        PluralForm = pluralForm;
        Type = type;
    }

    public static Noun Create(Text text, PluralForm pluralForm, NounType type)
    {
        return new Noun(NounId.CreateUnique(), text, pluralForm, type);
    }

    public static Noun Create(NounId nounId, Text text, PluralForm pluralForm, NounType type)
    {
        return new Noun(nounId, text, pluralForm, type);
    }

    public static Noun Create(NounId nounId, Text text, NounType type)
    {
        var pluralForm = PluralForm.Create(text);
        return new Noun(nounId, text, pluralForm, type);
    }
}