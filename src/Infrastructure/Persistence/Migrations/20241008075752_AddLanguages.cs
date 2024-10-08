using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddLanguages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Languages",
                schema: "practice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "practice",
                table: "Languages",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { new Guid("05fe75f9-6796-4c72-8a89-489c8d52f75d"), "south levantine arabic" },
                    { new Guid("0c6fb9bd-d798-4999-81e2-802b0a92d7d5"), "portuguese" },
                    { new Guid("0ec5d630-52e2-47e2-bd3c-aa5d558245c5"), "sudanese arabic" },
                    { new Guid("127f0d9f-ffb2-464e-acb5-fb56138d1bc2"), "cebuano" },
                    { new Guid("12df8673-0312-442d-8fd4-2a859b2cc684"), "bengali" },
                    { new Guid("1394dd73-1a4f-4d4a-879e-76f941fd1c5f"), "deccan" },
                    { new Guid("15d6f62b-8de9-4128-84e7-7935de4f73c5"), "korean" },
                    { new Guid("16914e1e-78c3-402d-a7be-2263fc6949f8"), "kazakh" },
                    { new Guid("1b286aad-c6c5-4fb4-ab1b-d14abadacbf6"), "gujarati" },
                    { new Guid("1c8d22a0-77f7-487d-9ce1-c495c60dadff"), "southern pashto" },
                    { new Guid("1ce69f17-8e7b-4b85-bff6-9fe41e697f4f"), "urdu" },
                    { new Guid("22ca4647-b89c-48a2-9bbb-4d9f14895887"), "assamese" },
                    { new Guid("2398731a-9c7b-4783-b666-77d340f6fcda"), "zulu" },
                    { new Guid("2661a965-a510-43c2-9f0b-3e992ea95ea1"), "moroccan arabic" },
                    { new Guid("2a42e510-4d68-4c95-aaf2-1e21d46dcd2b"), "burmese" },
                    { new Guid("31a6b8c2-f157-4e41-b2c0-336ca50c9507"), "chhattisgarhi" },
                    { new Guid("3288e392-6d22-4a8b-9106-94b70baba22f"), "eastern punjabi" },
                    { new Guid("36354dac-9c60-411d-816c-3e252de2df81"), "ta?izzi-adeni arabic" },
                    { new Guid("37bd1f60-8836-40dc-8088-552154d7bdd5"), "kinyarwanda" },
                    { new Guid("3b8a9bef-fcd5-4d66-9bb8-9d1b2f884781"), "jin chinese" },
                    { new Guid("3be86fab-c7d5-4efd-9346-f605fe823383"), "southern min" },
                    { new Guid("3d2e2737-03e7-4ede-92a3-924c5074e26c"), "tagalog" },
                    { new Guid("3e3d20f3-f7f7-4afe-8717-1fb96d3264be"), "western punjabi" },
                    { new Guid("4457ce47-bd82-41d1-87ac-7fdba55e2483"), "northern pashto" },
                    { new Guid("4696be38-54c4-411a-ba12-1ba4dae9feb8"), "odia" },
                    { new Guid("4a4eec31-fedd-45ea-9135-0a20e9cb264c"), "gan chinese" },
                    { new Guid("507ffed0-a57b-4f32-a8a3-137ff2264ae9"), "bavarian" },
                    { new Guid("58c26460-99cc-4f77-9977-af6d92ad49ba"), "south azerbaijani" },
                    { new Guid("5b0ced9e-6cc6-40d3-a89d-b3913d603700"), "javanese" },
                    { new Guid("5b59631d-dedd-41f6-8324-24200a1697d0"), "turkish" },
                    { new Guid("5ca70bdb-188e-4238-b312-1eb634c6a1a6"), "tunisian arabic" },
                    { new Guid("5d71e38e-110c-4da0-aab4-99dff6d649e5"), "xiang chinese" },
                    { new Guid("6368bc2e-4f36-497e-9a55-818e183149e9"), "wu chinese" },
                    { new Guid("6393822a-625f-4054-b8ae-5872dc246889"), "sanaani spoken arabic" },
                    { new Guid("673361d6-7d32-4944-98ee-4a7a354655b2"), "tamil" },
                    { new Guid("6a833428-0ac5-4f5a-a115-b9225514fa44"), "nigerian fulfulde" },
                    { new Guid("6c546a84-186a-4681-88a4-de913fbe4331"), "vietnamese" },
                    { new Guid("6cef15b5-fb9a-4992-9c7a-c37836c707cf"), "northern min" },
                    { new Guid("70ba1044-a598-4a1a-a451-4dba9cd3d549"), "malaysian" },
                    { new Guid("71704395-6919-4ddc-97ab-3222c3b06833"), "egyptian arabic" },
                    { new Guid("7558116a-387e-4b36-b8e0-8d1175cc8149"), "chittagonian" },
                    { new Guid("7cf32237-ea01-4d0c-9a23-89ed7edeb88d"), "yoruba" },
                    { new Guid("81cf3dcd-39da-4b39-8deb-7935a12be238"), "indonesian" },
                    { new Guid("834aeb5d-cc64-4f28-8ed3-5866c00b8bfd"), "czech" },
                    { new Guid("85b755ae-595e-4205-8a80-130a085d6707"), "romanian" },
                    { new Guid("89b8772b-6169-4fab-b305-65ccd46b6867"), "mesopotamian arabic" },
                    { new Guid("8c387e4d-812e-4699-acc2-d83817dd9cf5"), "marathi" },
                    { new Guid("90cac461-3cd8-4b1a-87dc-8965eb4109ea"), "nepali" },
                    { new Guid("913295ed-d47e-494f-807a-c8d18d866038"), "telugu" },
                    { new Guid("91b5ca59-9c4e-4c33-be2c-6b53dcb2d563"), "eastern min" },
                    { new Guid("95ede413-1620-48ea-90e5-415d32d3136f"), "hindi" },
                    { new Guid("96373b8c-3a10-430f-a0e8-487d7cd0a61f"), "sunda" },
                    { new Guid("968b9167-9ca8-4721-9ec2-9b8689671d3e"), "amharic" },
                    { new Guid("97719b21-50bc-4545-bbac-d3259c477c22"), "khmer" },
                    { new Guid("97b6e62a-8f05-48fc-971f-308572ffbfb3"), "japanese" },
                    { new Guid("9a03a8ec-8353-408c-b651-03ab17615f1e"), "uyghur" },
                    { new Guid("9b34f793-e999-4129-8b02-84e0ddea5ed7"), "mandarin chinese" },
                    { new Guid("9b5579a2-47d0-4096-9a2f-5d419e9bd7c9"), "northern uzbek" },
                    { new Guid("9c9b8a57-f2bc-45e7-860a-bd347ab45463"), "dutch" },
                    { new Guid("9d025102-c785-4c1e-9d66-6fa50edfd5c4"), "hakka" },
                    { new Guid("a1766dc0-2e54-42d5-a6b4-f81827903762"), "sinhalese" },
                    { new Guid("a40ae7ca-9561-4adc-aa70-45fe9f35a182"), "maithili" },
                    { new Guid("a4932f62-6a1e-4a21-a90a-55f615175328"), "north levantine arabic" },
                    { new Guid("a6ccc444-5e36-4126-9287-18944c3efe43"), "yue chinese" },
                    { new Guid("a7c1d64a-5994-4e7a-b9dc-b136d1c194a7"), "somali" },
                    { new Guid("a9ad5bb1-a485-4651-a1ba-fa6a3c464611"), "thai" },
                    { new Guid("b0dcf460-c418-4e0d-a29b-d9e4ab5e743f"), "sindhi" },
                    { new Guid("b6457d47-e469-44f6-9b02-836ca0ea268e"), "algerian arabic" },
                    { new Guid("b678be2e-9b78-4815-99e9-11ff110b8a00"), "rundi" },
                    { new Guid("bb4e540a-3058-4fe5-a999-fe6788fa354e"), "bhojpuri" },
                    { new Guid("bbd2c377-ef0e-4fa2-826b-64399b09c844"), "italian" },
                    { new Guid("c0d613e2-9fc4-4db9-b1c0-3f25b432e19a"), "saraiki" },
                    { new Guid("c10c047e-a8e8-4b8e-9bc2-0bb8a4c15814"), "ukrainian" },
                    { new Guid("cb5aa02e-6c20-47a9-ae60-38bae2796a90"), "english" },
                    { new Guid("cee97e98-3e18-4a44-859a-19bf4a9d94f7"), "hejazi arabic" },
                    { new Guid("d376604d-187b-44de-9bbf-3f8afd799120"), "northern kurdish" },
                    { new Guid("d8c23f83-1d83-4ff9-a6ce-0dc6e633fc36"), "polish" },
                    { new Guid("d9710773-5393-4ad7-8750-2b919fe1f182"), "iranian persian" },
                    { new Guid("dbc15f01-8b9f-414b-9289-16ba38ce025c"), "spanish" },
                    { new Guid("ddb8c1c2-e641-46e4-aeb5-063221d778b2"), "sa?idi arabic" },
                    { new Guid("e285a34d-ad4a-456c-a828-cb2b27108add"), "hausa" },
                    { new Guid("e7068004-70af-487e-9ea1-db94dc876c71"), "malayalam" },
                    { new Guid("e70ebfb6-30e8-4b2c-9d61-78d7c3a8fa71"), "french" },
                    { new Guid("eaad2199-ab5c-4a71-9118-2bfbebcff6fe"), "igbo" },
                    { new Guid("eaf19085-2520-4407-a24d-54a648e94867"), "kannada" },
                    { new Guid("eb367b00-bd5b-410c-a03d-7d6e21f2f702"), "sylheti" },
                    { new Guid("ecef3e89-4eb9-4ca3-83e0-df6a49b5011e"), "greek" },
                    { new Guid("ef5ef238-125e-40bd-bd5a-c4854011a8a9"), "hungarian" },
                    { new Guid("f3bef354-8344-4b02-8ed0-6f1bed89790c"), "german" },
                    { new Guid("f4c1939d-a5d8-4d82-9900-e10076eb635c"), "magahi" },
                    { new Guid("f78be4bd-e17d-4c70-8a41-2e16f4da061f"), "russian" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Languages",
                schema: "practice");
        }
    }
}
