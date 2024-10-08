using Domain.Common.ValueObjects;
using Domain.Vocabulary.Determiners;
using Domain.Vocabulary.Determiners.ValueObjects;

namespace Infrastructure.Persistence.Seed.Vocabulary;

public static class DeterminerSeed
{
    public static IReadOnlyList<Determiner> GetDeterminers()
    {
        return
        [
            Determiner.Create(DeterminerId.Create(Guid.Parse("b95eb82b-9a9b-45e9-8c27-3653515fc072")), Text.Create("the").Value),
            Determiner.Create(DeterminerId.Create(Guid.Parse("586087f2-906f-4f2e-ac79-2b0f1f7c451a")), Text.Create("a").Value),
            Determiner.Create(DeterminerId.Create(Guid.Parse("cbc50098-c6f7-4b4d-b0fd-8b168caabaee")), Text.Create("an").Value),
        ];
    }
}