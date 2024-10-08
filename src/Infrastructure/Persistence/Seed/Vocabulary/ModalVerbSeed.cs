using Domain.Common.ValueObjects;
using Domain.Vocabulary.ModalVerbs;
using Domain.Vocabulary.ModalVerbs.ValueObjects;

namespace Infrastructure.Persistence.Seed.Vocabulary;

public static class ModalVerbSeed
{
    public static IReadOnlyList<ModalVerb> GetModalVerbs()
    {
        return
        [
            ModalVerb.Create(ModalVerbId.Create(Guid.Parse("f4297e70-5d11-4212-adfa-a46e66da77b8")), Text.Create("can").Value, FullNegativeForm.Create("can not").Value, ShortNegativeForm.Create("can't").Value),
            ModalVerb.Create(ModalVerbId.Create(Guid.Parse("07a979c4-4070-424f-9955-add7ec49d7c6")), Text.Create("could").Value, FullNegativeForm.Create("could not").Value, ShortNegativeForm.Create("couldn't").Value),
            ModalVerb.Create(ModalVerbId.Create(Guid.Parse("dd88989e-31bf-471e-931f-feb4033553b8")), Text.Create("may").Value, FullNegativeForm.Create("may not").Value, ShortNegativeForm.Create("may not").Value),
            ModalVerb.Create(ModalVerbId.Create(Guid.Parse("9e1402dd-db46-41b2-b142-d391b4b6af65")), Text.Create("might").Value, FullNegativeForm.Create("might not").Value, ShortNegativeForm.Create("mightn't").Value),
            ModalVerb.Create(ModalVerbId.Create(Guid.Parse("aa286b6f-7950-40c5-aa8b-64458a76f318")), Text.Create("will").Value, FullNegativeForm.Create("will not").Value, ShortNegativeForm.Create("won't").Value),
            ModalVerb.Create(ModalVerbId.Create(Guid.Parse("0865aeff-7a9f-463b-95f0-67f9cbf8135e")), Text.Create("shall").Value, FullNegativeForm.Create("shall not").Value, ShortNegativeForm.Create("shan't").Value),
            ModalVerb.Create(ModalVerbId.Create(Guid.Parse("58470a27-303f-41b5-8424-353ba5f82acb")), Text.Create("would").Value, FullNegativeForm.Create("would not").Value, ShortNegativeForm.Create("wouldn't").Value),
            ModalVerb.Create(ModalVerbId.Create(Guid.Parse("049459c0-d360-4e84-9499-f0156a12af0a")), Text.Create("should").Value, FullNegativeForm.Create("should not").Value, ShortNegativeForm.Create("shouldn't").Value),
            ModalVerb.Create(ModalVerbId.Create(Guid.Parse("1dc96fe8-384f-4d79-beac-bf986a7d53f6")), Text.Create("must").Value, FullNegativeForm.Create("must not").Value, ShortNegativeForm.Create("mustn't").Value),
        ];
    }
}