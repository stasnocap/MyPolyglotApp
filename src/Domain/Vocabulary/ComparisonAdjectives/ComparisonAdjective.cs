using Domain.Common;
using Domain.Common.Extensions;
using Domain.Common.ValueObjects;
using Domain.Vocabulary.ComparisonAdjectives.ValueObjects;
using ErrorOr;

namespace Domain.Vocabulary.ComparisonAdjectives;

public sealed class ComparisonAdjective : BaseWord<ComparisonAdjectiveId>
{
    public ComparativeForm ComparativeForm { get; }
    public SuperlativeForm SuperlativeForm { get; }

    private ComparisonAdjective(ComparisonAdjectiveId id, Text text, ComparativeForm comparativeForm, SuperlativeForm superlativeForm) : base(id, text)
    {
        ComparativeForm = comparativeForm;
        SuperlativeForm = superlativeForm;
    }

    public static ComparisonAdjective Create(Text text, ComparativeForm comparativeForm, SuperlativeForm superlativeForm)
    {
        return new ComparisonAdjective(ComparisonAdjectiveId.CreateUnique(), text, comparativeForm, superlativeForm);
    }

    public static ComparisonAdjective Create(ComparisonAdjectiveId comparisonAdjectiveId, Text text, ComparativeForm comparativeForm, SuperlativeForm superlativeForm)
    {
        return new ComparisonAdjective(comparisonAdjectiveId, text, comparativeForm, superlativeForm);
    }

    public static ErrorOr<ComparisonAdjective> Create(ComparisonAdjectiveId comparisonAdjectiveId, Text text, SyllablesCount syllablesCount)
    {
        var errors = new List<Error>();
        
        var errorOrComparativeForm = ComparativeForm.From(text, syllablesCount).ElseAccumulate(errors);
        var errorOrSuperlativeForm = SuperlativeForm.From(text, syllablesCount).ElseAccumulate(errors);

        if (errors.Count > 0)
        {
            return errors;
        }

        return new ComparisonAdjective(comparisonAdjectiveId, text, errorOrComparativeForm.Value, errorOrSuperlativeForm.Value);
    }
}