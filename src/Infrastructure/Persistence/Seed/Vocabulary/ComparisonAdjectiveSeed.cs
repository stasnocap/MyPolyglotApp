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
            ..GetIrregularComparisonAdjectives(),
            ..GetRegularComparisonAdjectives(),
        ];
    }

    private static IReadOnlyList<ComparisonAdjective> GetIrregularComparisonAdjectives()
    {
        return
        [
            ComparisonAdjective.Create(ComparisonAdjectiveId.Create(Guid.Parse("683eccbc-8eb0-4caf-8ea2-4b1d14d1dbf3")), Text.Create("good").Value, ComparativeForm.Create("good").Value, SuperlativeForm.Create("better").Value),
            ComparisonAdjective.Create(ComparisonAdjectiveId.Create(Guid.Parse("86eef14e-c54d-4199-8cef-667bc5020581")), Text.Create("bad").Value, ComparativeForm.Create("bad").Value, SuperlativeForm.Create("worse").Value),
            ComparisonAdjective.Create(ComparisonAdjectiveId.Create(Guid.Parse("f8fa872b-1342-4768-ac8d-df3b0f2d4458")), Text.Create("far").Value, ComparativeForm.Create("far").Value, SuperlativeForm.Create("farther").Value),
            ComparisonAdjective.Create(ComparisonAdjectiveId.Create(Guid.Parse("f4b23d49-a74b-4c92-a6f5-17f62ef05196")), Text.Create("little").Value, ComparativeForm.Create("little").Value, SuperlativeForm.Create("less").Value),
        ];
    }

    private static IReadOnlyList<ComparisonAdjective> GetRegularComparisonAdjectives()
    {
        return
        [
            ComparisonAdjective.Create(ComparisonAdjectiveId.Create(Guid.Parse("4b0c784e-f29d-49aa-9c8d-36ed4e54adf9")), Text.Create("old").Value, SyllablesCount.Create(1).Value).Value,
            ComparisonAdjective.Create(ComparisonAdjectiveId.Create(Guid.Parse("2d76caf4-8636-4c12-987f-07feae8fd132")), Text.Create("long").Value, SyllablesCount.Create(1).Value).Value,
            ComparisonAdjective.Create(ComparisonAdjectiveId.Create(Guid.Parse("e3d68928-1a39-449f-b285-92fee63f0d98")), Text.Create("nice").Value, SyllablesCount.Create(1).Value).Value,
            ComparisonAdjective.Create(ComparisonAdjectiveId.Create(Guid.Parse("41744192-d34c-45a7-94e3-08685846f217")), Text.Create("large").Value, SyllablesCount.Create(1).Value).Value,
            ComparisonAdjective.Create(ComparisonAdjectiveId.Create(Guid.Parse("624a2190-1a68-46e4-be85-b9fff1198db5")), Text.Create("big").Value, SyllablesCount.Create(1).Value).Value,
            ComparisonAdjective.Create(ComparisonAdjectiveId.Create(Guid.Parse("c3df608b-c2cf-446d-9678-f426e523bc16")), Text.Create("fat").Value, SyllablesCount.Create(1).Value).Value,
            ComparisonAdjective.Create(ComparisonAdjectiveId.Create(Guid.Parse("5132409c-4c9f-4f6c-8ebe-200087832496")), Text.Create("happy").Value, SyllablesCount.Create(2).Value).Value,
            ComparisonAdjective.Create(ComparisonAdjectiveId.Create(Guid.Parse("5b0c5468-ba63-469b-9512-ca826287401a")), Text.Create("silly").Value, SyllablesCount.Create(2).Value).Value,
        ];
    }
}