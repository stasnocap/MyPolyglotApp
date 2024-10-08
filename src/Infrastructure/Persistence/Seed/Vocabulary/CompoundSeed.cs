using Domain.Common.ValueObjects;
using Domain.Vocabulary.Compounds;
using Domain.Vocabulary.Compounds.ValueObjects;

namespace Infrastructure.Persistence.Seed.Vocabulary;

public static class CompoundSeed
{
    public static IReadOnlyList<Compound> GetCompounds()
    {
        return
        [
            Compound.Create(CompoundId.Create(Guid.Parse("1f912eca-38ee-4e38-b4eb-3f6de281ab06")), Text.Create("something").Value, CompoundType.Some),
            Compound.Create(CompoundId.Create(Guid.Parse("1284f5ca-4e8c-4905-b7dd-bf66ee432a6f")), Text.Create("somebody").Value, CompoundType.Some),
            Compound.Create(CompoundId.Create(Guid.Parse("7002f039-8a85-48f2-a37d-e50a9d560c38")), Text.Create("someone").Value, CompoundType.Some),
            Compound.Create(CompoundId.Create(Guid.Parse("c1be99b7-3d00-447e-92be-a78679082e82")), Text.Create("somewhere").Value, CompoundType.Some),
            Compound.Create(CompoundId.Create(Guid.Parse("1e80b3b8-445a-428b-aac0-4077621f648d")), Text.Create("sometimes").Value, CompoundType.Some),

            Compound.Create(CompoundId.Create(Guid.Parse("9d266ce8-561b-4121-9172-2f3d196813ba")), Text.Create("anything").Value, CompoundType.Any),
            Compound.Create(CompoundId.Create(Guid.Parse("14937d44-2b42-4fcc-b1ad-9f98ac8e744d")), Text.Create("anybody").Value, CompoundType.Any),
            Compound.Create(CompoundId.Create(Guid.Parse("9811f3cf-b01d-48d8-9b9f-3d04fdd173d7")), Text.Create("anyone").Value, CompoundType.Any),
            Compound.Create(CompoundId.Create(Guid.Parse("7dafbc0e-13dd-4964-87de-8f260d32a335")), Text.Create("anywhere").Value, CompoundType.Any),

            Compound.Create(CompoundId.Create(Guid.Parse("dc8b90e3-5d5b-497d-ace9-46181b4cc5ec")), Text.Create("everything").Value, CompoundType.Every),
            Compound.Create(CompoundId.Create(Guid.Parse("57ac0ad6-ae94-4123-b2d3-240f358fb949")), Text.Create("everybody").Value, CompoundType.Every),
            Compound.Create(CompoundId.Create(Guid.Parse("d7b7eb2a-8001-48e5-985c-ca2ae236e86a")), Text.Create("everyone").Value, CompoundType.Every),
            Compound.Create(CompoundId.Create(Guid.Parse("0a5d0c3c-9901-41aa-957d-e01d3c785690")), Text.Create("everywhere").Value, CompoundType.Every),

            Compound.Create(CompoundId.Create(Guid.Parse("5f0d509b-9473-4fac-b8c7-8ddbe77e6d05")), Text.Create("nothing").Value, CompoundType.No),
            Compound.Create(CompoundId.Create(Guid.Parse("fae6f4fa-886e-437d-ad3b-a3463e988216")), Text.Create("nobody").Value, CompoundType.No),
            Compound.Create(CompoundId.Create(Guid.Parse("fe8150a2-b26f-499f-ae9b-57abb851cc00")), Text.Create("nowhere").Value, CompoundType.No),
        ];
    }
}