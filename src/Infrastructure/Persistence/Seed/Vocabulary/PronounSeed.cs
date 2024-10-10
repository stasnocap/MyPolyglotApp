using Domain.Common.ValueObjects;
using Domain.Vocabulary.Pronouns;
using Domain.Vocabulary.Pronouns.ValueObjects;

namespace Infrastructure.Persistence.Seed.Vocabulary;

public static class PronounSeed
{
    public static IReadOnlyList<Pronoun> GetPronouns()
    {
        return
        [
            Pronoun.Create(PronounId.Create(Guid.Parse("c5e9499f-6682-4de2-bb4c-f6cf2c3e5e7f")), Text.Create("i").Value, PronounType.Subject),
            Pronoun.Create(PronounId.Create(Guid.Parse("95280413-d92d-4907-827e-1bd3fadd5f20")), Text.Create("you").Value, PronounType.Subject),
            Pronoun.Create(PronounId.Create(Guid.Parse("004a6a6b-bb91-4d03-bec1-ba2529fab0c0")), Text.Create("he").Value, PronounType.Subject),
            Pronoun.Create(PronounId.Create(Guid.Parse("1a412290-7271-4385-8fc9-f08be3b0452c")), Text.Create("she").Value, PronounType.Subject),
            Pronoun.Create(PronounId.Create(Guid.Parse("575963a0-80f7-4024-9c82-90e52aea846a")), Text.Create("it").Value, PronounType.Subject),
            Pronoun.Create(PronounId.Create(Guid.Parse("60a86ad4-6d5f-4874-819a-61f9c200b7b1")), Text.Create("we").Value, PronounType.Subject),
            Pronoun.Create(PronounId.Create(Guid.Parse("0bb651d1-cc92-41a5-9b24-2934db01ed07")), Text.Create("they").Value, PronounType.Subject),
            
            Pronoun.Create(PronounId.Create(Guid.Parse("228e5431-fa5b-474b-bff1-f91431f08ba1")), Text.Create("me").Value, PronounType.Object),
            Pronoun.Create(PronounId.Create(Guid.Parse("4574e7fe-0563-415e-9b18-982918d7e632")), Text.Create("him").Value, PronounType.Object),
            Pronoun.Create(PronounId.Create(Guid.Parse("b0118050-1f65-44f5-99aa-f4af33665c51")), Text.Create("us").Value, PronounType.Object),
            Pronoun.Create(PronounId.Create(Guid.Parse("975f6fa2-8822-433c-a05f-32b97741b648")), Text.Create("them").Value, PronounType.Object),
            
            Pronoun.Create(PronounId.Create(Guid.Parse("37d4d557-1584-48ce-88e0-700d83e673a9")), Text.Create("my").Value, PronounType.PossessiveAdjective),
            Pronoun.Create(PronounId.Create(Guid.Parse("3d4d59db-0f70-4705-adf1-99301046f8f8")), Text.Create("your").Value, PronounType.PossessiveAdjective),
            Pronoun.Create(PronounId.Create(Guid.Parse("3d4024e5-6111-4228-a0a1-f5afd3d5c73b")), Text.Create("his").Value, PronounType.PossessiveAdjective),
            Pronoun.Create(PronounId.Create(Guid.Parse("bfb1e919-377d-45b8-b9b7-9a3d15dae126")), Text.Create("her").Value, PronounType.PossessiveAdjective),
            Pronoun.Create(PronounId.Create(Guid.Parse("a2c14ea9-87a6-4a3d-9f1c-751431e7ef9e")), Text.Create("its").Value, PronounType.PossessiveAdjective),
            Pronoun.Create(PronounId.Create(Guid.Parse("03186e19-aab4-4442-8fb3-e178e9fb4677")), Text.Create("our").Value, PronounType.PossessiveAdjective),
            Pronoun.Create(PronounId.Create(Guid.Parse("95dd9857-02a2-4549-bfb7-28d7468edc8a")), Text.Create("their").Value, PronounType.PossessiveAdjective),
            
            Pronoun.Create(PronounId.Create(Guid.Parse("d9fd3895-0795-41d4-93c0-9dc36f589a9d")), Text.Create("mine").Value, PronounType.Possessive),
            Pronoun.Create(PronounId.Create(Guid.Parse("a34ed880-662b-47b2-9688-f21dc2a5fc04")), Text.Create("hers").Value, PronounType.Possessive),
            Pronoun.Create(PronounId.Create(Guid.Parse("1b868392-10c9-4b9f-92d7-bb085fcd1c6c")), Text.Create("ours").Value, PronounType.Possessive),
            Pronoun.Create(PronounId.Create(Guid.Parse("0e33bc11-5692-4d61-b989-0b7d143a809d")), Text.Create("theirs").Value, PronounType.Possessive),
            
            Pronoun.Create(PronounId.Create(Guid.Parse("3a17671e-a6f1-4370-af2a-ce6f43f5312e")), Text.Create("myself").Value, PronounType.Reflexive),
            Pronoun.Create(PronounId.Create(Guid.Parse("4760d1a2-ed1c-4f5e-94b6-0c71248ebb89")), Text.Create("yourself").Value, PronounType.Reflexive),
            Pronoun.Create(PronounId.Create(Guid.Parse("0d48da8a-6d21-4049-a26b-b4f37f170b4e")), Text.Create("himself").Value, PronounType.Reflexive),
            Pronoun.Create(PronounId.Create(Guid.Parse("788528a7-d7c4-4818-ae8e-8a41cf9f694e")), Text.Create("herself").Value, PronounType.Reflexive),
            Pronoun.Create(PronounId.Create(Guid.Parse("997eb939-e004-4a5b-be05-3cd2a641bd59")), Text.Create("itself").Value, PronounType.Reflexive),
            Pronoun.Create(PronounId.Create(Guid.Parse("de86911d-4934-4415-a3cf-48332c3ef873")), Text.Create("ourselves").Value, PronounType.Reflexive),
            Pronoun.Create(PronounId.Create(Guid.Parse("f9c20a04-e3c2-45a0-b994-245699ca0727")), Text.Create("yourselves").Value, PronounType.Reflexive),
            Pronoun.Create(PronounId.Create(Guid.Parse("dc37db89-eda0-4a30-9284-b3b1712d87c9")), Text.Create("themselves").Value, PronounType.Reflexive),
            
            Pronoun.Create(PronounId.Create(Guid.Parse("d06a468e-4330-42ac-ab1b-a89b4b89abaa")), Text.Create("this").Value, PronounType.Demonstrative),
            Pronoun.Create(PronounId.Create(Guid.Parse("453d730c-7540-4f26-bc99-688ca2317bdd")), Text.Create("that").Value, PronounType.Demonstrative),
            Pronoun.Create(PronounId.Create(Guid.Parse("d3a118c2-e428-4fd6-a728-19fd4888f838")), Text.Create("these").Value, PronounType.Demonstrative),
            Pronoun.Create(PronounId.Create(Guid.Parse("0bb8b56e-3c71-44e0-bc1b-55ed5d41aeb4")), Text.Create("those").Value, PronounType.Demonstrative),
        ];
    }
}