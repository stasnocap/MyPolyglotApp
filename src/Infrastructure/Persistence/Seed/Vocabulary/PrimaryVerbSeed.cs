using Domain.Common.ValueObjects;
using Domain.Vocabulary.PrimaryVerbs;
using Domain.Vocabulary.PrimaryVerbs.ValueObjects;
using Domain.Vocabulary.Verbs.ValueObjects;

namespace Infrastructure.Persistence.Seed.Vocabulary;

public static class PrimaryVerbSeed
{
    private static readonly PrimaryVerbId PrimaryVerbId1 = PrimaryVerbId.Create(Guid.Parse("928e8efd-1a11-4df9-9703-0631fa073ca3"));
    private static readonly PrimaryVerbId PrimaryVerbId2 = PrimaryVerbId.Create(Guid.Parse("aedf0d06-70b2-4270-8c69-6a5b7ce26d1c"));
    private static readonly PrimaryVerbId PrimaryVerbId3 = PrimaryVerbId.Create(Guid.Parse("f286ad7c-e394-42b6-ad07-4be4a8bb137c"));

    public static IReadOnlyList<PrimaryVerb> GetPrimaryVerbs()
    {
        return
        [
            PrimaryVerb.Create(PrimaryVerbId1, Text.Create("do").Value, PastForm.Create("did").Value, PastParticipleForm.Create("done").Value, PresentParticipleForm.Create("doing").Value, ThirdPersonForm.Create("does").Value),
            PrimaryVerb.Create(PrimaryVerbId2, Text.Create("have").Value, PastForm.Create("had").Value, PastParticipleForm.Create("had").Value, PresentParticipleForm.Create("having").Value, ThirdPersonForm.Create("has").Value),
            PrimaryVerb.Create(PrimaryVerbId3, Text.Create("be").Value, PastForm.Create("was").Value, PastParticipleForm.Create("been").Value, PresentParticipleForm.Create("being").Value, ThirdPersonForm.Create("is").Value),
        ];
    }

    public static IReadOnlyList<object> GetAdditionalForms()
    {
        return
        [
            new
            {
                Id = 1,
                Value = "were",
                PrimaryVerbId = PrimaryVerbId3,
            },
            new
            {
                Id = 2,
                Value = "am",
                PrimaryVerbId = PrimaryVerbId3,
            },
            new
            {
                Id = 3,
                Value = "are",
                PrimaryVerbId = PrimaryVerbId3,
            },
        ];
    }

    public static IReadOnlyList<object> GetShortNegativeForms()
    {
        return
        [
            new
            {
                Id = 1,
                Value = "don't",
                PrimaryVerbId = PrimaryVerbId1,
            },
            new
            {
                Id = 2,
                Value = "didn't",
                PrimaryVerbId = PrimaryVerbId1,
            },
            new
            {
                Id = 3,
                Value = "doesn't",
                PrimaryVerbId = PrimaryVerbId1,
            },


            new
            {
                Id = 4,
                Value = "haven't",
                PrimaryVerbId = PrimaryVerbId2,
            },
            new
            {
                Id = 5,
                Value = "hadn't",
                PrimaryVerbId = PrimaryVerbId2,
            },
            new
            {
                Id = 6,
                Value = "hasn't",
                PrimaryVerbId = PrimaryVerbId2,
            },


            new
            {
                Id = 7,
                Value = "wasn't",
                PrimaryVerbId = PrimaryVerbId3,
            },
            new
            {
                Id = 8,
                Value = "weren't",
                PrimaryVerbId = PrimaryVerbId3,
            },
            new
            {
                Id = 9,
                Value = "am not",
                PrimaryVerbId = PrimaryVerbId3,
            },
            new
            {
                Id = 10,
                Value = "isn't",
                PrimaryVerbId = PrimaryVerbId3,
            },
            new
            {
                Id = 11,
                Value = "aren't",
                PrimaryVerbId = PrimaryVerbId3,
            },
        ];
    }

    public static IReadOnlyList<object> GetFullNegativeForms()
    {
        return
        [
            new
            {
                Id = 1,
                Value = "do not",
                PrimaryVerbId = PrimaryVerbId1,
            },
            new
            {
                Id = 2,
                Value = "did not",
                PrimaryVerbId = PrimaryVerbId1,
            },
            new
            {
                Id = 3,
                Value = "does not",
                PrimaryVerbId = PrimaryVerbId1,
            },


            new
            {
                Id = 4,
                Value = "have not",
                PrimaryVerbId = PrimaryVerbId2,
            },
            new
            {
                Id = 5,
                Value = "had not",
                PrimaryVerbId = PrimaryVerbId2,
            },
            new
            {
                Id = 6,
                Value = "has not",
                PrimaryVerbId = PrimaryVerbId1,
            },


            new
            {
                Id = 7,
                Value = "was not",
                PrimaryVerbId = PrimaryVerbId3,
            },
            new
            {
                Id = 8,
                Value = "were not",
                PrimaryVerbId = PrimaryVerbId3,
            },
            new
            {
                Id = 9,
                Value = "am not",
                PrimaryVerbId = PrimaryVerbId3,
            },
            new
            {
                Id = 10,
                Value = "is not",
                PrimaryVerbId = PrimaryVerbId3,
            },
            new
            {
                Id = 11,
                Value = "are not",
                PrimaryVerbId = PrimaryVerbId3,
            },
        ];
    }
}