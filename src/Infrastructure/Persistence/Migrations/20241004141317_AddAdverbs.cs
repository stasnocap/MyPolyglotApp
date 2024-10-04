using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddAdverbs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adverbs",
                schema: "practice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adverbs", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "practice",
                table: "Adverbs",
                columns: new[] { "Id", "Text", "Type" },
                values: new object[,]
                {
                    { new Guid("06b63f96-d867-4089-a444-afdad6f686a1"), "cheerfully", 4 },
                    { new Guid("07315eee-23d9-4eef-81aa-e1d83e2185a6"), "now", 6 },
                    { new Guid("073df645-a63a-46e7-a527-ef018cdd9a09"), "just", 5 },
                    { new Guid("08da3304-edd0-4b51-afac-df4d9df6aadc"), "wholeheartedly", 4 },
                    { new Guid("08eeb1ba-1d56-4c87-ab23-f026508cd2f9"), "hardly", 5 },
                    { new Guid("09b7f46c-4213-409c-92e4-92a3b54b8a74"), "more", 5 },
                    { new Guid("0d154711-11f1-45ce-baa7-9e5199ec7bb1"), "happily", 3 },
                    { new Guid("138d4000-8884-444f-bee3-6b6216470deb"), "randomly", 4 },
                    { new Guid("146ba32f-dfdf-4d6d-bfb1-fab8e3ff6b18"), "regularly", 6 },
                    { new Guid("1d2b9ee7-cfe2-40d1-bd95-848b278c9473"), "totally", 2 },
                    { new Guid("1dcf9d91-267d-4ca4-b7f5-f1d80311d097"), "anymore", 5 },
                    { new Guid("1f297c5b-a8e7-44e4-b1a1-405c6d92509d"), "quickly", 3 },
                    { new Guid("251b0b09-d512-4ab7-9c91-8a96aab9146c"), "sloppily", 4 },
                    { new Guid("27d9a98b-acbf-4495-ab35-53951c9a0b4b"), "completely", 2 },
                    { new Guid("27db08cb-be2e-4280-9596-9f52d45875a4"), "below", 7 },
                    { new Guid("2a7fc2c7-0538-4574-b9c8-bc34908d5362"), "absolutely", 2 },
                    { new Guid("2d1aa07e-5472-44b7-a9ba-994f5b54dc5c"), "already", 6 },
                    { new Guid("2f032241-0194-4311-b015-a4c4f7f9aa86"), "only", 5 },
                    { new Guid("2f5e80a3-7744-4124-8d39-46e5b1fe04b9"), "softly", 3 },
                    { new Guid("38ea8366-d332-4576-83d1-afdc67703961"), "lately", 6 },
                    { new Guid("3959a763-5335-46a9-bae0-a32481172ecd"), "tonight", 6 },
                    { new Guid("3c740b58-f15f-4dc2-8e8f-b51c56b97e36"), "recently", 6 },
                    { new Guid("3dfd6253-296a-49ab-804a-241f0aeab532"), "later", 6 },
                    { new Guid("421d81cd-f9ad-4b20-b5f6-246462868462"), "mildly", 2 },
                    { new Guid("42c179af-b28c-4ca5-9301-9cd84f00bb79"), "last", 6 },
                    { new Guid("46055f33-27eb-4a2e-a0c1-9e88a2342af6"), "somewhat", 2 },
                    { new Guid("4613d83e-7a11-4429-a1e6-936b6ff7328d"), "yesterday", 6 },
                    { new Guid("47b31618-2e23-4294-8607-ad3f0fea8075"), "early", 6 },
                    { new Guid("497c17e2-cc84-4264-b899-90165b8272e0"), "neatly", 3 },
                    { new Guid("57a34429-a06b-425e-9baf-f926908f06c3"), "inside", 7 },
                    { new Guid("57dbb0ea-e426-4697-8d72-3db14f08def7"), "today", 6 },
                    { new Guid("5d0249b7-3a78-4d4d-b50c-7b359955a73e"), "lot", 5 },
                    { new Guid("5e925101-d482-4747-9604-3faf6a90a40d"), "patiently", 3 },
                    { new Guid("5f93a2d5-a9cc-4503-9d1b-ea80f67a8840"), "brutally", 4 },
                    { new Guid("60e819ce-1567-4133-b355-298dee29e9f5"), "quite", 5 },
                    { new Guid("627af486-ea38-44bd-8905-a4169104134d"), "so", 5 },
                    { new Guid("6785ecf8-6e16-4077-b65d-f030e25ec0f7"), "beautifully", 3 },
                    { new Guid("67b2f05a-a95c-4eb0-9b6d-3b03dd16e567"), "yet", 6 },
                    { new Guid("6980e458-ba5c-4b84-95b4-13d88a6d963e"), "finally", 3 },
                    { new Guid("6c5732d1-b30f-4376-b455-d3a8837b6adb"), "out", 7 },
                    { new Guid("6e6bfa3e-b872-4d40-a2ee-bca8b38df735"), "simply", 2 },
                    { new Guid("708edf03-6d6d-405e-a0c7-1137c6b322c9"), "noon", 6 },
                    { new Guid("73558002-dae1-4454-81e1-0ac91efd8543"), "really", 2 },
                    { new Guid("792bec50-bec4-43c2-8cd9-616357017b48"), "immediately", 6 },
                    { new Guid("7a6db825-b1bd-4b62-a38a-3f2d8bbeaec2"), "literally", 2 },
                    { new Guid("7ba93fa2-407b-4994-bccb-864ee3a3bacb"), "weirdly", 4 },
                    { new Guid("84bfcd78-65f7-462e-b14d-e968b60953e9"), "too", 5 },
                    { new Guid("84f6104b-22dd-4c7e-80ec-41e4d00fe22a"), "seldom", 1 },
                    { new Guid("8a9e842b-c20e-45b4-be2d-a58e42af182e"), "heartily", 2 },
                    { new Guid("8b4bca03-4b4f-4248-b965-2622a89a060c"), "some", 5 },
                    { new Guid("943847f3-1b60-4408-b426-e199c63feb9e"), "tomorrow", 6 },
                    { new Guid("952d6138-1e4b-4c2a-b501-c148951ec6ff"), "always", 1 },
                    { new Guid("96c1eab2-3c6e-4c61-ad14-c843169d7a99"), "soon", 6 },
                    { new Guid("99a909cb-3009-4db8-9784-799eff895f79"), "upstairs", 7 },
                    { new Guid("a1939cfc-1e06-45a7-9cde-8e8cf4615dc7"), "sure", 2 },
                    { new Guid("a4898e30-5cee-47af-8a82-930ca3ce6876"), "outside", 7 },
                    { new Guid("a9cd5877-b24c-4461-a249-ba138b7a865a"), "generously", 3 },
                    { new Guid("abb47450-ac60-4f2e-977e-669994062522"), "enough", 5 },
                    { new Guid("ad9f2bf6-c4fa-41e5-8ec4-67a99b368acc"), "first", 6 },
                    { new Guid("afc31295-9ca9-4e89-8c60-2a3b2386fb81"), "wickedly", 4 },
                    { new Guid("b1753526-2137-4f69-a477-d14177461043"), "normally", 1 },
                    { new Guid("b2608bc3-b018-463c-a991-eab9905e9a3c"), "expertly", 4 },
                    { new Guid("b4b603f7-325d-43c2-a46f-66c819ab46c4"), "no", 5 },
                    { new Guid("b7e195e5-e48f-4316-bfd5-937ce78018d5"), "back", 7 },
                    { new Guid("bc4f6294-b052-4e2e-8af0-76c09b7c8269"), "briskly", 4 },
                    { new Guid("bdd55547-2594-47ac-b133-dc65acd18caa"), "nearly", 5 },
                    { new Guid("c0553b92-071e-40ff-a2b0-151130618165"), "here", 7 },
                    { new Guid("c53aa959-925f-4d15-af41-e7d164d39e44"), "much", 5 },
                    { new Guid("c7b98dc0-9ee8-478a-8fbb-b65ddf996f05"), "very", 5 },
                    { new Guid("c9c178f6-425e-40ba-aa56-2e9df2189b21"), "almost", 5 },
                    { new Guid("ca4baf2b-f932-4341-bec7-6424620c2267"), "there", 7 },
                    { new Guid("caa4f524-5ab2-4513-b481-ebc398a02949"), "above", 7 },
                    { new Guid("cbafdc35-f148-42e4-91b8-c83942ff57f7"), "uneasily", 4 },
                    { new Guid("ccec5fd1-67c3-4a74-b975-7df7b2894297"), "usually", 1 },
                    { new Guid("e1d1c0d9-c2a0-46e5-86f5-1ad64584f7fd"), "well", 3 },
                    { new Guid("e3b0d5ef-dbbc-4a7e-b85c-dab9f7e49b83"), "also", 5 },
                    { new Guid("e7e0ea1f-839f-4410-9194-372f9dbeb5ec"), "underground", 7 },
                    { new Guid("ecbd054c-2179-45cd-9246-dda528c03808"), "rarely", 1 },
                    { new Guid("f3118375-021a-4c5b-b982-8c110861e56b"), "again", 1 },
                    { new Guid("f63c6bf3-e505-41e7-a506-59aa2ef5cde0"), "never", 1 },
                    { new Guid("f9e765ea-191e-4557-b871-c409f4da39ed"), "rather", 5 },
                    { new Guid("fe6f939d-2a3a-4ddc-af91-3352759f278e"), "every", 1 },
                    { new Guid("ff0c21ee-0c28-4267-aa0a-afac141db998"), "downstairs", 7 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adverbs",
                schema: "practice");
        }
    }
}
