using Domain.Common;
using Domain.Common.ValueObjects;
using Domain.Vocabulary.Adverbs.ValueObjects;

namespace Domain.Vocabulary.Adverbs;

public sealed class Adverb : BaseWord<AdverbId>
{
    private Adverb(AdverbId id, Text text) : base(id, text)
    {
    }

    public static Adverb Create(Text text)
    {
        return new Adverb(AdverbId.CreateUnique(), text);
    }
}