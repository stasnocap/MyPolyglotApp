using Domain.Common;
using Domain.Common.ValueObjects;
using Domain.Vocabulary.ComparisonAdjectives.ValueObjects;

namespace Domain.Vocabulary.ComparisonAdjectives;

public sealed class ComparisonAdjective : BaseWord<ComparisonAdjectiveId>
{
    public ComparativeForm ComparativeForm { get; }
    public SuperlativeForm SuperlativeForm { get; }
    public SyllablesCount SyllablesCount { get; }

    private ComparisonAdjective(ComparisonAdjectiveId id, Text text, ComparativeForm comparativeForm, SuperlativeForm superlativeForm, SyllablesCount syllablesCount) : base(id, text)
    {
        ComparativeForm = comparativeForm;
        SuperlativeForm = superlativeForm;
        SyllablesCount = syllablesCount;
    }

    public static ComparisonAdjective Create(Text text, ComparativeForm comparativeForm, SuperlativeForm superlativeForm, SyllablesCount syllablesCount)
    {
        return new ComparisonAdjective(ComparisonAdjectiveId.CreateUnique(), text, comparativeForm, superlativeForm, syllablesCount);
    }
}