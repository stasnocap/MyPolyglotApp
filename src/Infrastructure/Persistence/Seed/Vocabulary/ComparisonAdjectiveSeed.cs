using Domain.Common.ValueObjects;
using Domain.Vocabulary.ComparisonAdjectives;
using Domain.Vocabulary.ComparisonAdjectives.ValueObjects;

namespace Infrastructure.Persistence.Seed.Vocabulary;

public static class ComparisonAdjectiveSeed
{
    public static IReadOnlyList<ComparisonAdjective> GetComparisonAdjectives()
    {
        return
        [
            ComparisonAdjective.Create(ComparisonAdjectiveId.Create(Guid.Parse("683eccbc-8eb0-4caf-8ea2-4b1d14d1dbf3")), Text.Create("good").Value, ComparativeForm.Create("good").Value, SuperlativeForm.Create("better").Value, SyllablesCount.Create(1).Value),
            ComparisonAdjective.Create(ComparisonAdjectiveId.Create(Guid.Parse("86eef14e-c54d-4199-8cef-667bc5020581")), Text.Create("bad").Value, ComparativeForm.Create("bad").Value, SuperlativeForm.Create("worse").Value, SyllablesCount.Create(1).Value),
            ComparisonAdjective.Create(ComparisonAdjectiveId.Create(Guid.Parse("f8fa872b-1342-4768-ac8d-df3b0f2d4458")), Text.Create("far").Value, ComparativeForm.Create("far").Value, SuperlativeForm.Create("farther").Value, SyllablesCount.Create(1).Value),
            ComparisonAdjective.Create(ComparisonAdjectiveId.Create(Guid.Parse("f4b23d49-a74b-4c92-a6f5-17f62ef05196")), Text.Create("little").Value, ComparativeForm.Create("little").Value, SuperlativeForm.Create("less").Value, SyllablesCount.Create(1).Value),
        ];
    }
}