using Domain.Common.ValueObjects;
using Domain.Vocabulary.Adjectives;
using Domain.Vocabulary.Adjectives.ValueObjects;

namespace Infrastructure.Persistence.Seed.Vocabulary;

public static class AdjectiveSeed
{
    public static IReadOnlyList<Adjective> GetAdjectives()
    {
        return
        [
            Adjective.Create(AdjectiveId.Create(Guid.Parse("6cd412b7-34e5-439e-95d8-55b61db1cfa9")), Text.Create("able").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("8d50e8e9-c3b4-491e-ad36-1452e7fb0590")), Text.Create("big").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("09d933a8-b8e8-4127-97d1-3b194a3a45fb")), Text.Create("black").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("49d9e76c-7eb9-4f74-94d2-8d7dbf63ebfb")), Text.Create("certain").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("f0ad9463-7127-48d3-a731-0102fd1f7756")), Text.Create("clear").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("bcef7759-b7d8-4933-82ad-47edb5826296")), Text.Create("different").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("75b94ead-b444-4f1e-8bec-33e0d48141eb")), Text.Create("easy").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("4b431829-1a43-4494-89bb-ce500ca1eb61")), Text.Create("economic").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("95172ed1-a690-4e59-a2d5-b969f711cf7b")), Text.Create("federal").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("8c0c10db-9f9b-4dec-8f11-72951152f6cf")), Text.Create("free").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("b3e9a613-bb8e-43a0-80b0-50f74552e2e9")), Text.Create("full").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("592a18a7-f26f-43af-92c9-6bb16b33ac33")), Text.Create("great").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("61f2f73e-bfb2-435f-ac09-697b6bf5ed76")), Text.Create("hard").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("eaff4bab-3c7c-4050-9f89-0707b328f1dc")), Text.Create("high").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("001ea687-2f01-4707-9777-d643ebb7b3e8")), Text.Create("human").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("0f3734e6-0a3e-488e-860d-63adc8c1b54a")), Text.Create("important").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("c616a9b0-e5a1-4e84-82b5-f8706a1c97f0")), Text.Create("international").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("96028aa6-1dc7-4d38-b079-be0fc9b51d89")), Text.Create("large").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("86c28a12-8fa6-450f-84e8-fad454383431")), Text.Create("late").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("62adbba2-6052-4c06-90b3-87977b1aaa40")), Text.Create("local").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("12a4278f-cdbb-45d3-94f1-8f0c60baacc5")), Text.Create("long").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("cec6a73d-7aad-4cc0-a1d4-c502b7315c79")), Text.Create("low").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("fa6cc476-482f-4c12-8a38-e98b847e4a45")), Text.Create("major").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("ed995c14-bf43-4457-9a7d-a7a3564ee5f6")), Text.Create("military").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("e1c01e50-ec4c-4a89-822b-013ef61c04c2")), Text.Create("national").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("7a63d507-b061-42c1-b5f8-e386b5230724")), Text.Create("new").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("f773e2ba-0ab9-49ea-8a3f-cf90d13b0092")), Text.Create("old").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("8c42d1f8-d954-4f3e-ad59-69ec2728916e")), Text.Create("other").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("7d0e593f-15fc-4c8b-bc48-72af46277bdf")), Text.Create("political").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("cb511321-ac54-4017-b4ea-8b53ea4d45de")), Text.Create("possible").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("26d25d94-60a0-4180-bc40-e2ae17a0d32f")), Text.Create("public").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("8f7a4db3-1bae-4a67-9fe8-e0901444b592")), Text.Create("real").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("4d60b419-3040-4b89-a633-c628129d9374")), Text.Create("recent").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("c23d8e73-e9cc-4be1-aef7-f5b3e4e92c50")), Text.Create("right").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("33b401e3-28e8-4ce8-952f-8ed0c124d062")), Text.Create("small").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("9fff9195-bb56-4c0f-85d6-9f7ee47142c6")), Text.Create("social").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("3ac69980-9dfb-46b5-8805-a4ed17f28dd3")), Text.Create("special").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("2d43b70f-6a8a-4787-8c0a-8a3e1f14b7bf")), Text.Create("strong").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("53e66e87-89fd-4813-b111-c672d5af5b45")), Text.Create("true").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("fca7cc2a-34f1-4c02-8528-52892dc0630e")), Text.Create("white").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("ce5944fa-27e6-4d6f-8a08-59681108a44f")), Text.Create("whole").Value),
            Adjective.Create(AdjectiveId.Create(Guid.Parse("74df4727-1d71-466a-8dab-b1b552113f34")), Text.Create("young").Value),
        ];
    }
}