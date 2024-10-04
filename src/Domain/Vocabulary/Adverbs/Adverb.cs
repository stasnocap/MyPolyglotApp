using Domain.Common;
using Domain.Common.ValueObjects;
using Domain.Vocabulary.Adverbs.ValueObjects;

namespace Domain.Vocabulary.Adverbs;

public sealed class Adverb : BaseWord<AdverbId>
{
    public AdverbType Type { get; }

    private Adverb(AdverbId id, Text text, AdverbType type) : base(id, text)
    {
        Type = type;
    }

    public static Adverb Create(Text text, AdverbType type)
    {
        return new Adverb(AdverbId.CreateUnique(), text, type);
    }

    public static Adverb Create(AdverbId adverbId, Text text, AdverbType type)
    {
        return new Adverb(adverbId, text, type);
    }
}