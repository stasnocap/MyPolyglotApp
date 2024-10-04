using Domain.Common.ValueObjects;
using Domain.Vocabulary.Adverbs;
using Domain.Vocabulary.Adverbs.ValueObjects;

namespace Infrastructure.Persistence.Seed.Vocabulary;

public static class AdverbSeed
{
    public static IReadOnlyList<Adverb> GetAdverbs()
    {
        return
        [
            ..GetFrequencyAdverbs(),
            ..GetIntensifierAdverbs(),
            ..GetMannerAdverbs(),
            ..GetTellHowItHappenedAdverbs(),
            ..GetTellWhereItHappenedAdverbs(),
            ..GetTellWhenItHappenedAdverbs(),
            ..GetTellTheExtentOfTheActionAdverbs(),
        ];
    }

    private static IReadOnlyList<Adverb> GetFrequencyAdverbs()
    {
        return
        [
            Adverb.Create(AdverbId.Create(Guid.Parse("f3118375-021a-4c5b-b982-8c110861e56b")), Text.Create("again").Value, AdverbType.Frequency),
            Adverb.Create(AdverbId.Create(Guid.Parse("952d6138-1e4b-4c2a-b501-c148951ec6ff")), Text.Create("always").Value, AdverbType.Frequency),
            Adverb.Create(AdverbId.Create(Guid.Parse("fe6f939d-2a3a-4ddc-af91-3352759f278e")), Text.Create("every").Value, AdverbType.Frequency),
            Adverb.Create(AdverbId.Create(Guid.Parse("f63c6bf3-e505-41e7-a506-59aa2ef5cde0")), Text.Create("never").Value, AdverbType.Frequency),
            Adverb.Create(AdverbId.Create(Guid.Parse("b1753526-2137-4f69-a477-d14177461043")), Text.Create("normally").Value, AdverbType.Frequency),
            Adverb.Create(AdverbId.Create(Guid.Parse("ecbd054c-2179-45cd-9246-dda528c03808")), Text.Create("rarely").Value, AdverbType.Frequency),
            Adverb.Create(AdverbId.Create(Guid.Parse("84f6104b-22dd-4c7e-80ec-41e4d00fe22a")), Text.Create("seldom").Value, AdverbType.Frequency),
            Adverb.Create(AdverbId.Create(Guid.Parse("ccec5fd1-67c3-4a74-b975-7df7b2894297")), Text.Create("usually").Value, AdverbType.Frequency),
        ];
    }

    private static IReadOnlyList<Adverb> GetIntensifierAdverbs()
    {
        return
        [
            Adverb.Create(AdverbId.Create(Guid.Parse("7a6db825-b1bd-4b62-a38a-3f2d8bbeaec2")), Text.Create("literally").Value, AdverbType.Intensifier),
            Adverb.Create(AdverbId.Create(Guid.Parse("6e6bfa3e-b872-4d40-a2ee-bca8b38df735")), Text.Create("simply").Value, AdverbType.Intensifier),
            Adverb.Create(AdverbId.Create(Guid.Parse("73558002-dae1-4454-81e1-0ac91efd8543")), Text.Create("really").Value, AdverbType.Intensifier),
            Adverb.Create(AdverbId.Create(Guid.Parse("a1939cfc-1e06-45a7-9cde-8e8cf4615dc7")), Text.Create("sure").Value, AdverbType.Intensifier),
            Adverb.Create(AdverbId.Create(Guid.Parse("27d9a98b-acbf-4495-ab35-53951c9a0b4b")), Text.Create("completely").Value, AdverbType.Intensifier),
            Adverb.Create(AdverbId.Create(Guid.Parse("8a9e842b-c20e-45b4-be2d-a58e42af182e")), Text.Create("heartily").Value, AdverbType.Intensifier),
            Adverb.Create(AdverbId.Create(Guid.Parse("1d2b9ee7-cfe2-40d1-bd95-848b278c9473")), Text.Create("totally").Value, AdverbType.Intensifier),
            Adverb.Create(AdverbId.Create(Guid.Parse("2a7fc2c7-0538-4574-b9c8-bc34908d5362")), Text.Create("absolutely").Value, AdverbType.Intensifier),
            Adverb.Create(AdverbId.Create(Guid.Parse("46055f33-27eb-4a2e-a0c1-9e88a2342af6")), Text.Create("somewhat").Value, AdverbType.Intensifier),
            Adverb.Create(AdverbId.Create(Guid.Parse("421d81cd-f9ad-4b20-b5f6-246462868462")), Text.Create("mildly").Value, AdverbType.Intensifier),
        ];
    }

    private static IReadOnlyList<Adverb> GetMannerAdverbs()
    {
        return
        [
            Adverb.Create(AdverbId.Create(Guid.Parse("6785ecf8-6e16-4077-b65d-f030e25ec0f7")), Text.Create("beautifully").Value, AdverbType.Manner),
            Adverb.Create(AdverbId.Create(Guid.Parse("a9cd5877-b24c-4461-a249-ba138b7a865a")), Text.Create("generously").Value, AdverbType.Manner),
            Adverb.Create(AdverbId.Create(Guid.Parse("0d154711-11f1-45ce-baa7-9e5199ec7bb1")), Text.Create("happily").Value, AdverbType.Manner),
            Adverb.Create(AdverbId.Create(Guid.Parse("497c17e2-cc84-4264-b899-90165b8272e0")), Text.Create("neatly").Value, AdverbType.Manner),
            Adverb.Create(AdverbId.Create(Guid.Parse("5e925101-d482-4747-9604-3faf6a90a40d")), Text.Create("patiently").Value, AdverbType.Manner),
            Adverb.Create(AdverbId.Create(Guid.Parse("2f5e80a3-7744-4124-8d39-46e5b1fe04b9")), Text.Create("softly").Value, AdverbType.Manner),
            Adverb.Create(AdverbId.Create(Guid.Parse("1f297c5b-a8e7-44e4-b1a1-405c6d92509d")), Text.Create("quickly").Value, AdverbType.Manner),
            Adverb.Create(AdverbId.Create(Guid.Parse("e1d1c0d9-c2a0-46e5-86f5-1ad64584f7fd")), Text.Create("well").Value, AdverbType.Manner),
            Adverb.Create(AdverbId.Create(Guid.Parse("6980e458-ba5c-4b84-95b4-13d88a6d963e")), Text.Create("finally").Value, AdverbType.Manner),
        ];
    }

    private static IReadOnlyList<Adverb> GetTellHowItHappenedAdverbs()
    {
        return
        [
            Adverb.Create(AdverbId.Create(Guid.Parse("bc4f6294-b052-4e2e-8af0-76c09b7c8269")), Text.Create("briskly").Value, AdverbType.TellHowItHappened),
            Adverb.Create(AdverbId.Create(Guid.Parse("5f93a2d5-a9cc-4503-9d1b-ea80f67a8840")), Text.Create("brutally").Value, AdverbType.TellHowItHappened),
            Adverb.Create(AdverbId.Create(Guid.Parse("06b63f96-d867-4089-a444-afdad6f686a1")), Text.Create("cheerfully").Value, AdverbType.TellHowItHappened),
            Adverb.Create(AdverbId.Create(Guid.Parse("b2608bc3-b018-463c-a991-eab9905e9a3c")), Text.Create("expertly").Value, AdverbType.TellHowItHappened),
            Adverb.Create(AdverbId.Create(Guid.Parse("138d4000-8884-444f-bee3-6b6216470deb")), Text.Create("randomly").Value, AdverbType.TellHowItHappened),
            Adverb.Create(AdverbId.Create(Guid.Parse("251b0b09-d512-4ab7-9c91-8a96aab9146c")), Text.Create("sloppily").Value, AdverbType.TellHowItHappened),
            Adverb.Create(AdverbId.Create(Guid.Parse("cbafdc35-f148-42e4-91b8-c83942ff57f7")), Text.Create("uneasily").Value, AdverbType.TellHowItHappened),
            Adverb.Create(AdverbId.Create(Guid.Parse("7ba93fa2-407b-4994-bccb-864ee3a3bacb")), Text.Create("weirdly").Value, AdverbType.TellHowItHappened),
            Adverb.Create(AdverbId.Create(Guid.Parse("08da3304-edd0-4b51-afac-df4d9df6aadc")), Text.Create("wholeheartedly").Value, AdverbType.TellHowItHappened),
            Adverb.Create(AdverbId.Create(Guid.Parse("afc31295-9ca9-4e89-8c60-2a3b2386fb81")), Text.Create("wickedly").Value, AdverbType.TellHowItHappened),
        ];
    }

    private static IReadOnlyList<Adverb> GetTellWhereItHappenedAdverbs()
    {
        return
        [
            Adverb.Create(AdverbId.Create(Guid.Parse("c0553b92-071e-40ff-a2b0-151130618165")), Text.Create("here").Value, AdverbType.TellWhereItHappened),
            Adverb.Create(AdverbId.Create(Guid.Parse("ca4baf2b-f932-4341-bec7-6424620c2267")), Text.Create("there").Value, AdverbType.TellWhereItHappened),
            Adverb.Create(AdverbId.Create(Guid.Parse("ff0c21ee-0c28-4267-aa0a-afac141db998")), Text.Create("downstairs").Value, AdverbType.TellWhereItHappened),
            Adverb.Create(AdverbId.Create(Guid.Parse("99a909cb-3009-4db8-9784-799eff895f79")), Text.Create("upstairs").Value, AdverbType.TellWhereItHappened),
            Adverb.Create(AdverbId.Create(Guid.Parse("57a34429-a06b-425e-9baf-f926908f06c3")), Text.Create("inside").Value, AdverbType.TellWhereItHappened),
            Adverb.Create(AdverbId.Create(Guid.Parse("a4898e30-5cee-47af-8a82-930ca3ce6876")), Text.Create("outside").Value, AdverbType.TellWhereItHappened),
            Adverb.Create(AdverbId.Create(Guid.Parse("e7e0ea1f-839f-4410-9194-372f9dbeb5ec")), Text.Create("underground").Value, AdverbType.TellWhereItHappened),
            Adverb.Create(AdverbId.Create(Guid.Parse("caa4f524-5ab2-4513-b481-ebc398a02949")), Text.Create("above").Value, AdverbType.TellWhereItHappened),
            Adverb.Create(AdverbId.Create(Guid.Parse("b7e195e5-e48f-4316-bfd5-937ce78018d5")), Text.Create("back").Value, AdverbType.TellWhereItHappened),
            Adverb.Create(AdverbId.Create(Guid.Parse("27db08cb-be2e-4280-9596-9f52d45875a4")), Text.Create("below").Value, AdverbType.TellWhereItHappened),
            Adverb.Create(AdverbId.Create(Guid.Parse("6c5732d1-b30f-4376-b455-d3a8837b6adb")), Text.Create("out").Value, AdverbType.TellWhereItHappened),
        ];
    }

    private static IReadOnlyList<Adverb> GetTellWhenItHappenedAdverbs()
    {
        return
        [
            Adverb.Create(AdverbId.Create(Guid.Parse("47b31618-2e23-4294-8607-ad3f0fea8075")), Text.Create("early").Value, AdverbType.TellWhenItHappened),
            Adverb.Create(AdverbId.Create(Guid.Parse("ad9f2bf6-c4fa-41e5-8ec4-67a99b368acc")), Text.Create("first").Value, AdverbType.TellWhenItHappened),
            Adverb.Create(AdverbId.Create(Guid.Parse("42c179af-b28c-4ca5-9301-9cd84f00bb79")), Text.Create("last").Value, AdverbType.TellWhenItHappened),
            Adverb.Create(AdverbId.Create(Guid.Parse("3dfd6253-296a-49ab-804a-241f0aeab532")), Text.Create("later").Value, AdverbType.TellWhenItHappened),
            Adverb.Create(AdverbId.Create(Guid.Parse("07315eee-23d9-4eef-81aa-e1d83e2185a6")), Text.Create("now").Value, AdverbType.TellWhenItHappened),
            Adverb.Create(AdverbId.Create(Guid.Parse("146ba32f-dfdf-4d6d-bfb1-fab8e3ff6b18")), Text.Create("regularly").Value, AdverbType.TellWhenItHappened),
            Adverb.Create(AdverbId.Create(Guid.Parse("57dbb0ea-e426-4697-8d72-3db14f08def7")), Text.Create("today").Value, AdverbType.TellWhenItHappened),
            Adverb.Create(AdverbId.Create(Guid.Parse("3959a763-5335-46a9-bae0-a32481172ecd")), Text.Create("tonight").Value, AdverbType.TellWhenItHappened),
            Adverb.Create(AdverbId.Create(Guid.Parse("708edf03-6d6d-405e-a0c7-1137c6b322c9")), Text.Create("noon").Value, AdverbType.TellWhenItHappened),
            Adverb.Create(AdverbId.Create(Guid.Parse("943847f3-1b60-4408-b426-e199c63feb9e")), Text.Create("tomorrow").Value, AdverbType.TellWhenItHappened),
            Adverb.Create(AdverbId.Create(Guid.Parse("4613d83e-7a11-4429-a1e6-936b6ff7328d")), Text.Create("yesterday").Value, AdverbType.TellWhenItHappened),
            Adverb.Create(AdverbId.Create(Guid.Parse("2d1aa07e-5472-44b7-a9ba-994f5b54dc5c")), Text.Create("already").Value, AdverbType.TellWhenItHappened),
            Adverb.Create(AdverbId.Create(Guid.Parse("67b2f05a-a95c-4eb0-9b6d-3b03dd16e567")), Text.Create("yet").Value, AdverbType.TellWhenItHappened),
            Adverb.Create(AdverbId.Create(Guid.Parse("792bec50-bec4-43c2-8cd9-616357017b48")), Text.Create("immediately").Value, AdverbType.TellWhenItHappened),
            Adverb.Create(AdverbId.Create(Guid.Parse("38ea8366-d332-4576-83d1-afdc67703961")), Text.Create("lately").Value, AdverbType.TellWhenItHappened),
            Adverb.Create(AdverbId.Create(Guid.Parse("3c740b58-f15f-4dc2-8e8f-b51c56b97e36")), Text.Create("recently").Value, AdverbType.TellWhenItHappened),
            Adverb.Create(AdverbId.Create(Guid.Parse("96c1eab2-3c6e-4c61-ad14-c843169d7a99")), Text.Create("soon").Value, AdverbType.TellWhenItHappened),
        ];
    }

    private static IReadOnlyList<Adverb> GetTellTheExtentOfTheActionAdverbs()
    {
        return
        [
            Adverb.Create(AdverbId.Create(Guid.Parse("c9c178f6-425e-40ba-aa56-2e9df2189b21")), Text.Create("almost").Value, AdverbType.TellTheExtentOfTheAction),
            Adverb.Create(AdverbId.Create(Guid.Parse("e3b0d5ef-dbbc-4a7e-b85c-dab9f7e49b83")), Text.Create("also").Value, AdverbType.TellTheExtentOfTheAction),
            Adverb.Create(AdverbId.Create(Guid.Parse("abb47450-ac60-4f2e-977e-669994062522")), Text.Create("enough").Value, AdverbType.TellTheExtentOfTheAction),
            Adverb.Create(AdverbId.Create(Guid.Parse("2f032241-0194-4311-b015-a4c4f7f9aa86")), Text.Create("only").Value, AdverbType.TellTheExtentOfTheAction),
            Adverb.Create(AdverbId.Create(Guid.Parse("60e819ce-1567-4133-b355-298dee29e9f5")), Text.Create("quite").Value, AdverbType.TellTheExtentOfTheAction),
            Adverb.Create(AdverbId.Create(Guid.Parse("f9e765ea-191e-4557-b871-c409f4da39ed")), Text.Create("rather").Value, AdverbType.TellTheExtentOfTheAction),
            Adverb.Create(AdverbId.Create(Guid.Parse("627af486-ea38-44bd-8905-a4169104134d")), Text.Create("so").Value, AdverbType.TellTheExtentOfTheAction),
            Adverb.Create(AdverbId.Create(Guid.Parse("84bfcd78-65f7-462e-b14d-e968b60953e9")), Text.Create("too").Value, AdverbType.TellTheExtentOfTheAction),
            Adverb.Create(AdverbId.Create(Guid.Parse("c7b98dc0-9ee8-478a-8fbb-b65ddf996f05")), Text.Create("very").Value, AdverbType.TellTheExtentOfTheAction),
            Adverb.Create(AdverbId.Create(Guid.Parse("08eeb1ba-1d56-4c87-ab23-f026508cd2f9")), Text.Create("hardly").Value, AdverbType.TellTheExtentOfTheAction),
            Adverb.Create(AdverbId.Create(Guid.Parse("073df645-a63a-46e7-a527-ef018cdd9a09")), Text.Create("just").Value, AdverbType.TellTheExtentOfTheAction),
            Adverb.Create(AdverbId.Create(Guid.Parse("bdd55547-2594-47ac-b133-dc65acd18caa")), Text.Create("nearly").Value, AdverbType.TellTheExtentOfTheAction),
            Adverb.Create(AdverbId.Create(Guid.Parse("09b7f46c-4213-409c-92e4-92a3b54b8a74")), Text.Create("more").Value, AdverbType.TellTheExtentOfTheAction),
            Adverb.Create(AdverbId.Create(Guid.Parse("1dcf9d91-267d-4ca4-b7f5-f1d80311d097")), Text.Create("anymore").Value, AdverbType.TellTheExtentOfTheAction),
            Adverb.Create(AdverbId.Create(Guid.Parse("c53aa959-925f-4d15-af41-e7d164d39e44")), Text.Create("much").Value, AdverbType.TellTheExtentOfTheAction),
            Adverb.Create(AdverbId.Create(Guid.Parse("8b4bca03-4b4f-4248-b965-2622a89a060c")), Text.Create("some").Value, AdverbType.TellTheExtentOfTheAction),
            Adverb.Create(AdverbId.Create(Guid.Parse("5d0249b7-3a78-4d4d-b50c-7b359955a73e")), Text.Create("lot").Value, AdverbType.TellTheExtentOfTheAction),
            Adverb.Create(AdverbId.Create(Guid.Parse("b4b603f7-325d-43c2-a46f-66c819ab46c4")), Text.Create("no").Value, AdverbType.TellTheExtentOfTheAction),
        ];
    }
}