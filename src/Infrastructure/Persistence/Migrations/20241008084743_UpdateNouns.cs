using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateNouns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Type",
                schema: "practice",
                table: "Nouns",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("02410ac9-865a-4ef4-bf35-a97c572c775d"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("055014c0-4580-4f66-8a26-909c81ada9ab"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("0a5a1b84-4e5f-4491-a81b-1023baa21587"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("0a97d081-940f-4ac2-be45-5415f901bfd3"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("0af3f8c9-04b7-4826-98f3-2eee9f18bf54"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("0bb3c129-831b-4360-9405-c86ba88b2bd1"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("0f1d1568-8748-434e-b393-13f3e76a890b"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("1031bfa3-afaa-4f8d-ba5c-67c4bd76e090"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("10a584ce-08d0-45a3-a2c1-60c0ed418ba5"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("12bd1acd-141f-4248-8db5-e4a598317e88"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("14879bb3-f4f6-49eb-868c-756ec9b5eb75"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("1a7c848f-23df-4a78-9922-5600755ac939"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("1ec16fa1-e22e-460f-992f-ed1a5f6e6cdf"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("1f9d67de-d6b1-430a-91f5-ca59f2fefef0"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("23a9befc-3bcb-4ba2-b10c-9d01815df55f"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("23b223ea-134a-4d78-8cd0-375fe647016a"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("2788328f-fd07-4825-826b-dd5b84989b9e"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("29fb9af0-59cd-45ef-b294-d6ef961d5f4d"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("2b64ff6f-e4fa-4cf7-8dc4-b58532d79dec"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("2c2b0889-79f3-4f76-87db-3a5cc02011fd"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("3212ad08-807e-4c7d-9a38-65d76b3b8dc7"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("35926da0-252d-4b68-ba64-7e8a271e72a9"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("37e39b47-4899-4716-8ac8-484c2137d2b9"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("3a40539b-f6f7-4af5-97b9-797130ab9e3e"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("3e84413f-4522-4cdd-8e01-d868a1d1495e"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("3f3ed318-2891-4c78-924b-70ba61c288d6"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("40ac69ca-7f16-4830-a6b1-d3f50ab7ca6a"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("4476956e-2d7e-47ae-8ec9-73d1a091c0c8"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("472ae0b3-27d9-4488-998d-af50d84fde9d"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("4869c0cb-2bcd-4b69-b0ef-4821a4c5f8c2"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("488678df-1b0c-4049-99b4-2e6b77b64b56"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("4be04cba-73f9-4ca9-ae4e-a20074556716"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("532cc556-74b3-445a-8032-5d931a579c6f"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("5c17986c-b2e5-48fe-9ba2-1429d1f9d4f8"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("61ae4477-73f5-49e4-a7f4-68a3279b709c"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("67907bc9-6be9-4e8a-a017-b1a1411e3d10"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("69d77d54-8dc5-43c6-b4cc-a1fc81790ee4"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("6c68af73-e165-42c1-8712-fc6321b85b3a"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("6c7ed5f2-cc74-4b98-b44b-9c987fc57baa"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("6cac2ba2-42c6-452e-8851-2e91113c08a2"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("6d3db140-c060-49c0-aa80-83269a7c1f92"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("6eea2102-f1ca-43a4-80d4-9efc03cbc9a9"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("6ef22f13-96f9-4f6a-a828-789b7f8771b6"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("7726b965-9229-433e-b6c7-774425b641f7"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("7ec7af1c-2f7b-4c81-b003-9a2c42098c3e"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("844263ed-8a64-4537-b02c-c409d8e234ca"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("844a8806-4cb2-42e8-a970-fb6ac9411381"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("8d84d2ed-0381-4c20-b3ed-3e86116ff176"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("9e719618-3957-45f5-a579-84db93d75679"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("9e93f191-4112-49ee-8a8a-beb6efb5f98c"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("9ec6c1d6-14f0-496a-85f6-649c2b1942db"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("a139edc3-a54b-48a1-a41f-e26e49406068"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("a20cd4b1-626b-4d55-9636-c5abe59388c5"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("a361de63-7e01-4833-bc76-af3688ba0861"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("a4d2cb74-9c23-4629-9c3b-fa5dd7d8cb0f"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("aa3c70eb-c598-4ba3-9e60-9d10596b5bda"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("ac376ab4-ca67-4015-bb32-4937b2013f4c"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("b106231d-6747-42de-b599-fc3bbd88b5b6"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("b1c21999-f653-4c3b-ac25-4f978a2e03c6"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("b2276b1b-4e10-4361-9098-b9119a6a30a7"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("b29a2e94-bdd0-48dc-8c3c-bf6f1f7cf546"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("b779d65e-e66f-4320-9a5b-b55f7d54d4a8"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("bd8fd622-e592-4b3a-bb17-d9606b7aa5c2"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("bdc6e7dd-ece8-4ef8-b06b-dac3cb09cabc"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("be97eb44-72bc-4ead-ad82-4568cba67059"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("c135498f-f97c-457e-9a3c-d6e23dc578dd"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("c557a8d7-70f2-4752-914a-40cbd5c7f356"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("c570f1e7-090c-462f-aa6a-361b0109f561"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("c5bf888a-a578-4267-9301-a819269efdf5"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("c6f4bb5e-4653-4edf-bc00-63fea7d5276b"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("c74d197c-7d53-4385-a56d-68a8701b2a7c"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("c9d8d5e8-85ce-4254-bd81-813e367c7763"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("cbb70e24-54a7-4984-bb40-9280fe3a4dc1"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("cf84efdc-aa12-48c8-bd99-d6b41236dabd"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("d3b0da8d-49aa-4f45-9a04-da1629643f58"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("d3c30d3c-75b2-4fe5-ba31-18f309f3c587"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("d6416b77-e82b-4d3d-ae47-2e828bf4df32"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("d6adf7fa-98cd-4800-9594-dc270d7174cc"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("d7870492-791a-4703-b988-de79eb5fd243"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("d8d16893-49fd-4bad-b9f0-a769c05fafc8"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("df480d98-db6d-4700-a3ff-05f896ef7dc7"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("e51bd39b-d01e-4d64-82b5-74820f7f8298"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("ec72ed55-7737-4a17-940c-206cb755300f"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("eda699d8-8c96-46a3-8479-8df3a0d85df2"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("ef0a61de-fcd0-4d29-9c4f-f728710a3833"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("ef44000a-07c9-4bb5-91ff-af40b26a9169"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("ef872690-a08c-4498-9a4c-f94c22cf80cd"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("f0e8d288-1e01-454e-a8d7-60aedaa503cc"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("f129f9e5-3bf3-4b65-9a4d-51a6cc59ed97"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("f22b22cb-6507-45b3-82a7-7c6faec7919b"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("f752aee6-0190-4fee-88b2-54659742dc7c"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("f877f17d-92d7-4d29-8112-a8fa5b63609b"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("fcf3ec11-03cf-46e3-9e15-5dee1882b272"),
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("fd759b28-1d26-4c33-aefd-f0dbb8ce1787"),
                column: "Type",
                value: 1);

            migrationBuilder.InsertData(
                schema: "practice",
                table: "Nouns",
                columns: new[] { "Id", "PluralForm", "Text", "Type" },
                values: new object[,]
                {
                    { new Guid("055fe9d1-edec-4398-9880-6f781b2c7ec8"), "accountants", "accountant", 3 },
                    { new Guid("06b41465-0054-43e0-a604-eeaedd96d003"), "names", "name", 2 },
                    { new Guid("0728eca1-2889-4ed6-9a2b-cf36e0cab016"), "homes", "home", 2 },
                    { new Guid("080b75d8-eed4-41b8-b504-7e4e80fdc07b"), "faces", "face", 2 },
                    { new Guid("0d9d9c1c-c3f2-4696-80a6-125702b5ed5d"), "models", "model", 3 },
                    { new Guid("10621b0a-3611-4bb9-a957-f8c19dec236a"), "powers", "power", 2 },
                    { new Guid("133ff439-dc78-4724-aca4-ac6127199e15"), "cleaners", "cleaner", 3 },
                    { new Guid("1352b302-875f-4c0e-b030-d2d00f104124"), "guys", "guy", 2 },
                    { new Guid("156b01b8-5c94-4f6d-83fb-5aadea4df9c1"), "groups", "group", 2 },
                    { new Guid("162e288a-d060-41cd-8a6b-a42c16baff0f"), "receptionists", "receptionist", 3 },
                    { new Guid("170b8259-2556-4148-8cba-29b74f092b7a"), "lawyers", "lawyer", 3 },
                    { new Guid("1c0e049c-1e56-4982-b6b9-30770daff4c7"), "lecturers", "lecturer", 3 },
                    { new Guid("1e29bc31-f060-4bcc-9212-401f7536270d"), "drivers", "driver", 3 },
                    { new Guid("1e4d832a-f94b-4fb5-87da-45585523db2d"), "countries", "country", 2 },
                    { new Guid("22a1741d-4999-4b9c-b926-5a6e8f5ccae8"), "fathers", "father", 2 },
                    { new Guid("24f499a2-6b44-4fb5-81d4-53b47a2bd2a2"), "informatia", "information", 2 },
                    { new Guid("2511f5cf-0f09-4d4d-b5ad-73278fa65b5b"), "sides", "side", 2 },
                    { new Guid("2700812f-632a-4717-a69b-5ea51b49e315"), "gardeners", "gardener", 3 },
                    { new Guid("2bd613c3-bfc4-4922-beb2-007513e15818"), "journalists", "journalist", 3 },
                    { new Guid("2def382d-2002-4e39-ad5d-68a4331c992a"), "translators", "translator", 3 },
                    { new Guid("2f1a8f23-220b-4c76-911b-69cddd22d6af"), "kids", "kid", 2 },
                    { new Guid("2fc46f1b-a7bc-45ec-a7b4-2b5cb34e7166"), "schools", "school", 2 },
                    { new Guid("31dd7787-634a-43d7-8f08-08ae039e3489"), "hours", "hour", 2 },
                    { new Guid("31f59a36-25e5-4e93-87f8-c83e040429a2"), "educatia", "education", 2 },
                    { new Guid("34f7eb99-ed14-4e47-8720-ad048cfc29eb"), "things", "thing", 2 },
                    { new Guid("377325f0-561e-4ae0-a8a5-451d7449e9c0"), "pilots", "pilot", 3 },
                    { new Guid("3b73c619-56f1-4be5-b426-921a4b1a9de3"), "numbers", "number", 2 },
                    { new Guid("3c3eab92-6fb3-4525-a5fd-20dcb8b7ea7b"), "dentists", "dentist", 3 },
                    { new Guid("3cf788be-e267-4d66-9905-313f9f49b1f8"), "stories", "story", 2 },
                    { new Guid("3f3d7406-8d08-4d59-86ba-fa503f866b40"), "autumns", "autumn", 5 },
                    { new Guid("43467274-8382-47cf-93fc-a2ee8cd99915"), "problems", "problem", 2 },
                    { new Guid("4350d8a4-0e75-48cf-95aa-ff59dc6fad2d"), "levels", "level", 2 },
                    { new Guid("435360ae-25aa-4717-b0cc-83debd355db6"), "couriers", "courier", 3 },
                    { new Guid("43a676a6-e325-411a-b9bc-f9058f20eab1"), "plumbers", "plumber", 3 },
                    { new Guid("4504cf9a-e14c-4c5a-92a2-5be20df566a7"), "secretaries", "secretary", 3 },
                    { new Guid("45aa172e-1ab9-4747-a809-c4060a72c12b"), "doors", "door", 2 },
                    { new Guid("46528ce7-8f52-47ed-b39e-bdee68bbbad1"), "waters", "water", 2 },
                    { new Guid("4687b7e4-885f-4703-905c-9a6f2baa2326"), "wars", "war", 2 },
                    { new Guid("481c13ac-c43e-4fd3-ac17-3ba3c208fc96"), "authors", "author", 3 },
                    { new Guid("4c0835ec-a42a-467b-a204-2399339ff5f5"), "questia", "question", 2 },
                    { new Guid("4e101834-2d9c-4487-97c3-19a564cc49b5"), "bodies", "body", 2 },
                    { new Guid("4faa8802-2eb9-4267-90a9-da08e35c4d52"), "weeks", "week", 2 },
                    { new Guid("5059544c-cad0-43c4-bfab-712945cda6a3"), "jobs", "job", 2 },
                    { new Guid("50f9b3ff-063c-445a-91e9-994615f6a4a0"), "pharmacists", "pharmacist", 3 },
                    { new Guid("515ced18-6e2d-4360-9e4d-d9a24431d6e9"), "histories", "history", 2 },
                    { new Guid("5161f011-b8df-4e4c-909c-44fb8d4e80c1"), "kinds", "kind", 2 },
                    { new Guid("51907a8c-acd1-4176-8498-dcd6eed2a2d1"), "arts", "art", 2 },
                    { new Guid("528b4e51-9348-4f1c-bd4a-559ab40062e5"), "times", "time", 2 },
                    { new Guid("52a39a54-ca47-4548-8f25-f7b58eda97f6"), "bakers", "baker", 3 },
                    { new Guid("56816b39-edf8-4421-b9d3-75d8e05f5d72"), "students", "student", 2 },
                    { new Guid("57372e55-b9c9-47ab-8364-58f4ac1690f3"), "dustmans", "dustman", 3 },
                    { new Guid("57f5f0e2-104a-4fd5-9ab0-f8eabe35bd35"), "afternoons", "afternoon", 4 },
                    { new Guid("58f100cc-6dc3-411a-941d-af6ad4a13180"), "actors", "actor", 3 },
                    { new Guid("5d260a19-82f8-4ad1-81e1-7b0e3ae7d32d"), "cars", "car", 2 },
                    { new Guid("608074f5-faf1-436f-ac26-872c8266faad"), "airs", "air", 2 },
                    { new Guid("627b4a70-44eb-4428-8cea-6bfeb92a3d4d"), "parents", "parent", 2 },
                    { new Guid("63e88cde-d7c4-44ed-8428-cfb3fbed65e3"), "members", "member", 2 },
                    { new Guid("65638e34-2354-44e2-8348-36a739bf4922"), "hands", "hand", 2 },
                    { new Guid("67060766-de81-4cd7-b2cc-34d3f7ebf0b9"), "cities", "city", 2 },
                    { new Guid("685bc24c-dfa0-4818-a431-65091b5009d0"), "evenings", "evening", 4 },
                    { new Guid("6954d389-8c5e-4129-8352-267dad1ef7e1"), "chefs", "chef", 3 },
                    { new Guid("69f8049d-e810-4b0f-923e-b66c28cbc595"), "ends", "end", 2 },
                    { new Guid("6cc9a7a3-cb0b-4171-9ce1-35a9ddcaca3e"), "ideas", "idea", 2 },
                    { new Guid("6d2e41ae-33dd-45b5-ac89-94b94370dff1"), "teachers", "teacher", 3 },
                    { new Guid("6dea7038-8c39-460a-837a-e68debfe610c"), "judges", "judge", 3 },
                    { new Guid("6e7fa7ee-1bfe-4184-9de5-a49983288056"), "parts", "part", 2 },
                    { new Guid("718034f2-5601-4184-b268-f708e2dc7d16"), "houses", "house", 2 },
                    { new Guid("72d5ad38-35d4-4603-a33f-c96e6c7be57e"), "worlds", "world", 2 },
                    { new Guid("7656bd9b-e1a8-4eae-b1fd-9cab3efcac7c"), "tailors", "tailor", 3 },
                    { new Guid("76ebb3e6-6b35-4211-a942-c970f3a5ae70"), "farmers", "farmer", 3 },
                    { new Guid("779295d4-cf20-4cbb-9a38-7572c641f5ba"), "lifeguards", "lifeguard", 3 },
                    { new Guid("78123adf-756d-419b-8290-80e4377bbfcb"), "firemans", "fireman", 3 },
                    { new Guid("78b9c7b3-12aa-4f6a-95ba-81a2ed3d25bb"), "carpenters", "carpenter", 3 },
                    { new Guid("7ab1006d-c5ee-4d4d-b57c-2ca6a38fa580"), "games", "game", 2 },
                    { new Guid("7bad199d-a87f-4325-94b4-1351ef7365bc"), "moneys", "money", 2 },
                    { new Guid("7ed87e69-2afb-4a52-b2e0-bb229e18c0e5"), "businesses", "business", 2 },
                    { new Guid("7f1c580c-87ec-4e11-bef0-c5e1931272a8"), "ways", "way", 2 },
                    { new Guid("83566a4c-90ae-40e7-a2c8-9aa064b03919"), "moments", "moment", 2 },
                    { new Guid("86cd6d6d-2cfd-44ca-ad31-14c3b2ae5a42"), "doctors", "doctor", 3 },
                    { new Guid("86f42f23-b7ed-44f3-aace-5cc3723617be"), "postmans", "postman", 3 },
                    { new Guid("8ab835ec-4f1b-4b7a-ab04-7097fc541f3b"), "issues", "issue", 2 },
                    { new Guid("8cfd2035-9431-4297-8f32-be0c1e26e31d"), "heads", "head", 2 },
                    { new Guid("8eee8b6d-3289-4f18-b5fa-35e6201bc8e2"), "laws", "law", 2 },
                    { new Guid("8effd891-9f66-44d6-b77c-8d9ff446b6ab"), "teams", "team", 2 },
                    { new Guid("8f97c762-bbd8-4be9-9521-78a9c3267629"), "designers", "designer", 3 },
                    { new Guid("8fb5565a-862c-4d5f-83fe-240826140e50"), "waitresses", "waitress", 3 },
                    { new Guid("8fb6b0b2-e8c0-47b9-a5e7-b10f02d203cf"), "nights", "night", 4 },
                    { new Guid("9285bde5-981e-4aeb-89a2-40cb0aeceb1c"), "librarians", "librarian", 3 },
                    { new Guid("92e6c1bf-1c1b-4413-8c03-77487b2d119a"), "states", "state", 2 },
                    { new Guid("94605695-8060-4643-a2eb-e87795a377e0"), "newsreaders", "newsreader", 3 },
                    { new Guid("94ddcf5a-c8f1-4997-aa89-a396122543dd"), "cases", "case", 2 },
                    { new Guid("961fb472-9232-467d-87e5-1c03b10ea4c2"), "girls", "girl", 2 },
                    { new Guid("a091136a-6227-48e4-a6a1-c8070d5bc610"), "lines", "line", 2 },
                    { new Guid("a135fa3a-91e0-474e-9cd4-7d1cf1ea056a"), "mechanics", "mechanic", 3 },
                    { new Guid("a380b3cc-c753-4a76-a744-ad7783354e76"), "weekends", "weekend", 2 },
                    { new Guid("a4e594bb-3ef2-45ea-98a4-5d7294a2cf3c"), "florists", "florist", 3 },
                    { new Guid("aa8249a7-eb2d-4520-97eb-3824ee01d690"), "butchers", "butcher", 3 },
                    { new Guid("aa9aa506-df3b-4d94-8400-a15da489cdc3"), "programs", "program", 2 },
                    { new Guid("aae9ba77-77e8-4723-935e-1f6d9e8d7d38"), "engineers", "engineer", 3 },
                    { new Guid("aba004eb-6188-4e94-93e6-24a77bfda0e7"), "electricians", "electrician", 3 },
                    { new Guid("acaa7f8a-90a3-4b37-ae93-ea31a8a01a3c"), "facts", "fact", 2 },
                    { new Guid("aeeaa146-827d-467c-9d5b-770d99d1b8cb"), "services", "service", 2 },
                    { new Guid("b1a53f9d-910c-44e8-83c7-10267cfcf643"), "summers", "summer", 5 },
                    { new Guid("b33cca0d-89e3-41fc-a5a3-b585f4f2f037"), "soldiers", "soldier", 3 },
                    { new Guid("b3fffae9-2c61-43de-8f90-6f351f1e0bd5"), "points", "point", 2 },
                    { new Guid("b49cabb5-b209-48d9-aad0-6cd1647e905f"), "actresses", "actress", 3 },
                    { new Guid("b519ee27-47d8-486a-a0e4-3dfba526ca40"), "parties", "party", 2 },
                    { new Guid("b9ac7157-9847-465f-b288-26a5f471519c"), "lives", "life", 2 },
                    { new Guid("b9e13b57-0fd5-40ba-9f8c-0afdab9b4e1b"), "researches", "research", 2 },
                    { new Guid("bd0a481c-f9a2-419c-99b7-5f8352f17541"), "politicians", "politician", 3 },
                    { new Guid("bed75909-6f45-4a8c-a7cb-5dca3fc61adc"), "photographers", "photographer", 3 },
                    { new Guid("c06cd075-037a-466e-9180-2af65efeaeb1"), "governments", "government", 2 },
                    { new Guid("c0fcab94-33c9-41fe-9788-44561ac423a9"), "springs", "spring", 5 },
                    { new Guid("c5217814-da8d-497c-b7c5-12c12575d465"), "systems", "system", 2 },
                    { new Guid("c559c60d-28c9-4e51-b639-f8db426dd58c"), "healths", "health", 2 },
                    { new Guid("c5c45345-c601-4978-9808-06ad8b77fb62"), "astronomers", "astronomer", 3 },
                    { new Guid("c5ef7a7b-3832-493e-8c53-8d6bb05609e7"), "days", "day", 2 },
                    { new Guid("c622cb5d-4f34-4c81-aa41-752a0c55a514"), "minutes", "minute", 2 },
                    { new Guid("cba67a01-8895-4215-bc52-3cdf566a6fa5"), "nurses", "nurse", 3 },
                    { new Guid("cc13b733-19bc-4440-ba0d-fd9cb1b2f755"), "results", "result", 2 },
                    { new Guid("ccbd1a54-e85a-45ca-a125-69f9b85a04d1"), "buses", "bus", 3 },
                    { new Guid("ccc3e204-80c9-4104-a0a1-3cd421c3db78"), "mothers", "mother", 2 },
                    { new Guid("ccdaee0f-79cf-43da-a34b-4b4336ab5f32"), "mornings", "morning", 4 },
                    { new Guid("cd46c903-f640-4844-ad4c-e99d35ea7b5a"), "forces", "force", 2 },
                    { new Guid("ce173151-a957-48fb-87d7-77ef65ae422d"), "presidents", "president", 2 },
                    { new Guid("d310565f-0c1f-40d9-9166-80b404ec12fc"), "families", "family", 2 },
                    { new Guid("d475bfd3-5bc3-4185-8dbb-269a26ae50f3"), "offices", "office", 2 },
                    { new Guid("d6f1d49a-b4fb-45f1-bdf6-1924cb75add4"), "scientists", "scientist", 3 },
                    { new Guid("d810593c-5817-45f6-9292-fbe886c17c76"), "communities", "community", 2 },
                    { new Guid("dc5f756e-a1dd-409c-9e2d-8e98ebdbe791"), "waiters", "waiter", 3 },
                    { new Guid("dc91b3a0-23aa-4fd0-88e7-85ea8027ad8c"), "areas", "area", 2 },
                    { new Guid("dce4c333-d24b-4cc6-9297-873df89a2d21"), "policewomans", "policewoman", 3 },
                    { new Guid("e094c20b-6708-44fb-b11a-a4ce665366d2"), "reasa", "reason", 2 },
                    { new Guid("e4a9298b-58a6-4ae6-98d7-531dfc0e4558"), "companies", "company", 2 },
                    { new Guid("eba9e2d1-440b-49b8-8861-0f9bc7cf668c"), "months", "month", 2 },
                    { new Guid("ed701365-6da1-46fe-bdfd-a5ea549db565"), "painters", "painter", 3 },
                    { new Guid("ef9db620-dd0b-4f7a-8f7c-5feef834d084"), "hairdressers", "hairdresser", 3 },
                    { new Guid("f0b5c633-1f1b-4f36-ba29-89de161f147b"), "rooms", "room", 2 },
                    { new Guid("f1075b37-436f-406e-97ca-80df599e95ff"), "winters", "winter", 5 },
                    { new Guid("f246d643-818c-46a0-82d2-d3d5ba9f45be"), "changes", "change", 2 },
                    { new Guid("f2d72547-2049-42c6-ab5a-174bec4f0cf6"), "policemans", "policeman", 3 },
                    { new Guid("f4762345-53d0-4b4f-be1f-092affd937f4"), "places", "place", 2 },
                    { new Guid("f4ae5328-eecc-40f3-bbc3-6714438a8ce3"), "words", "word", 2 },
                    { new Guid("f55fcfba-dfc0-4a23-b80b-ae706a4f26da"), "opticians", "optician", 3 },
                    { new Guid("f585a5a5-6be4-4c6f-b985-e046b8f6bad1"), "architects", "architect", 3 },
                    { new Guid("f89dee56-49a6-4aba-a982-4c7023c079cd"), "otherses", "others", 2 },
                    { new Guid("f94a25e9-4c7a-49b1-9455-fdac5152b58e"), "fishermans", "fisherman", 3 },
                    { new Guid("fa35d904-5472-4177-9693-50b53aae2832"), "books", "book", 2 },
                    { new Guid("fc48c01b-2b53-416e-b00b-f840af122e86"), "eyes", "eye", 2 },
                    { new Guid("fdbe9e4a-affb-4a92-bd51-585b8afd95d1"), "bricklayers", "bricklayer", 3 },
                    { new Guid("fece8942-d66e-4eab-8490-39634b3696f6"), "years", "year", 2 },
                    { new Guid("ff1a4f2a-4b3f-4531-bd64-9452d9756ca5"), "friends", "friend", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("055fe9d1-edec-4398-9880-6f781b2c7ec8"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("06b41465-0054-43e0-a604-eeaedd96d003"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("0728eca1-2889-4ed6-9a2b-cf36e0cab016"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("080b75d8-eed4-41b8-b504-7e4e80fdc07b"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("0d9d9c1c-c3f2-4696-80a6-125702b5ed5d"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("10621b0a-3611-4bb9-a957-f8c19dec236a"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("133ff439-dc78-4724-aca4-ac6127199e15"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("1352b302-875f-4c0e-b030-d2d00f104124"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("156b01b8-5c94-4f6d-83fb-5aadea4df9c1"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("162e288a-d060-41cd-8a6b-a42c16baff0f"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("170b8259-2556-4148-8cba-29b74f092b7a"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("1c0e049c-1e56-4982-b6b9-30770daff4c7"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("1e29bc31-f060-4bcc-9212-401f7536270d"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("1e4d832a-f94b-4fb5-87da-45585523db2d"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("22a1741d-4999-4b9c-b926-5a6e8f5ccae8"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("24f499a2-6b44-4fb5-81d4-53b47a2bd2a2"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("2511f5cf-0f09-4d4d-b5ad-73278fa65b5b"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("2700812f-632a-4717-a69b-5ea51b49e315"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("2bd613c3-bfc4-4922-beb2-007513e15818"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("2def382d-2002-4e39-ad5d-68a4331c992a"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("2f1a8f23-220b-4c76-911b-69cddd22d6af"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("2fc46f1b-a7bc-45ec-a7b4-2b5cb34e7166"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("31dd7787-634a-43d7-8f08-08ae039e3489"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("31f59a36-25e5-4e93-87f8-c83e040429a2"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("34f7eb99-ed14-4e47-8720-ad048cfc29eb"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("377325f0-561e-4ae0-a8a5-451d7449e9c0"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("3b73c619-56f1-4be5-b426-921a4b1a9de3"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("3c3eab92-6fb3-4525-a5fd-20dcb8b7ea7b"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("3cf788be-e267-4d66-9905-313f9f49b1f8"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("3f3d7406-8d08-4d59-86ba-fa503f866b40"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("43467274-8382-47cf-93fc-a2ee8cd99915"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("4350d8a4-0e75-48cf-95aa-ff59dc6fad2d"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("435360ae-25aa-4717-b0cc-83debd355db6"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("43a676a6-e325-411a-b9bc-f9058f20eab1"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("4504cf9a-e14c-4c5a-92a2-5be20df566a7"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("45aa172e-1ab9-4747-a809-c4060a72c12b"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("46528ce7-8f52-47ed-b39e-bdee68bbbad1"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("4687b7e4-885f-4703-905c-9a6f2baa2326"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("481c13ac-c43e-4fd3-ac17-3ba3c208fc96"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("4c0835ec-a42a-467b-a204-2399339ff5f5"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("4e101834-2d9c-4487-97c3-19a564cc49b5"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("4faa8802-2eb9-4267-90a9-da08e35c4d52"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("5059544c-cad0-43c4-bfab-712945cda6a3"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("50f9b3ff-063c-445a-91e9-994615f6a4a0"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("515ced18-6e2d-4360-9e4d-d9a24431d6e9"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("5161f011-b8df-4e4c-909c-44fb8d4e80c1"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("51907a8c-acd1-4176-8498-dcd6eed2a2d1"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("528b4e51-9348-4f1c-bd4a-559ab40062e5"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("52a39a54-ca47-4548-8f25-f7b58eda97f6"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("56816b39-edf8-4421-b9d3-75d8e05f5d72"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("57372e55-b9c9-47ab-8364-58f4ac1690f3"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("57f5f0e2-104a-4fd5-9ab0-f8eabe35bd35"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("58f100cc-6dc3-411a-941d-af6ad4a13180"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("5d260a19-82f8-4ad1-81e1-7b0e3ae7d32d"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("608074f5-faf1-436f-ac26-872c8266faad"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("627b4a70-44eb-4428-8cea-6bfeb92a3d4d"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("63e88cde-d7c4-44ed-8428-cfb3fbed65e3"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("65638e34-2354-44e2-8348-36a739bf4922"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("67060766-de81-4cd7-b2cc-34d3f7ebf0b9"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("685bc24c-dfa0-4818-a431-65091b5009d0"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("6954d389-8c5e-4129-8352-267dad1ef7e1"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("69f8049d-e810-4b0f-923e-b66c28cbc595"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("6cc9a7a3-cb0b-4171-9ce1-35a9ddcaca3e"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("6d2e41ae-33dd-45b5-ac89-94b94370dff1"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("6dea7038-8c39-460a-837a-e68debfe610c"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("6e7fa7ee-1bfe-4184-9de5-a49983288056"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("718034f2-5601-4184-b268-f708e2dc7d16"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("72d5ad38-35d4-4603-a33f-c96e6c7be57e"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("7656bd9b-e1a8-4eae-b1fd-9cab3efcac7c"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("76ebb3e6-6b35-4211-a942-c970f3a5ae70"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("779295d4-cf20-4cbb-9a38-7572c641f5ba"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("78123adf-756d-419b-8290-80e4377bbfcb"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("78b9c7b3-12aa-4f6a-95ba-81a2ed3d25bb"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("7ab1006d-c5ee-4d4d-b57c-2ca6a38fa580"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("7bad199d-a87f-4325-94b4-1351ef7365bc"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("7ed87e69-2afb-4a52-b2e0-bb229e18c0e5"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("7f1c580c-87ec-4e11-bef0-c5e1931272a8"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("83566a4c-90ae-40e7-a2c8-9aa064b03919"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("86cd6d6d-2cfd-44ca-ad31-14c3b2ae5a42"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("86f42f23-b7ed-44f3-aace-5cc3723617be"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("8ab835ec-4f1b-4b7a-ab04-7097fc541f3b"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("8cfd2035-9431-4297-8f32-be0c1e26e31d"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("8eee8b6d-3289-4f18-b5fa-35e6201bc8e2"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("8effd891-9f66-44d6-b77c-8d9ff446b6ab"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("8f97c762-bbd8-4be9-9521-78a9c3267629"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("8fb5565a-862c-4d5f-83fe-240826140e50"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("8fb6b0b2-e8c0-47b9-a5e7-b10f02d203cf"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("9285bde5-981e-4aeb-89a2-40cb0aeceb1c"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("92e6c1bf-1c1b-4413-8c03-77487b2d119a"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("94605695-8060-4643-a2eb-e87795a377e0"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("94ddcf5a-c8f1-4997-aa89-a396122543dd"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("961fb472-9232-467d-87e5-1c03b10ea4c2"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("a091136a-6227-48e4-a6a1-c8070d5bc610"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("a135fa3a-91e0-474e-9cd4-7d1cf1ea056a"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("a380b3cc-c753-4a76-a744-ad7783354e76"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("a4e594bb-3ef2-45ea-98a4-5d7294a2cf3c"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("aa8249a7-eb2d-4520-97eb-3824ee01d690"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("aa9aa506-df3b-4d94-8400-a15da489cdc3"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("aae9ba77-77e8-4723-935e-1f6d9e8d7d38"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("aba004eb-6188-4e94-93e6-24a77bfda0e7"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("acaa7f8a-90a3-4b37-ae93-ea31a8a01a3c"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("aeeaa146-827d-467c-9d5b-770d99d1b8cb"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("b1a53f9d-910c-44e8-83c7-10267cfcf643"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("b33cca0d-89e3-41fc-a5a3-b585f4f2f037"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("b3fffae9-2c61-43de-8f90-6f351f1e0bd5"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("b49cabb5-b209-48d9-aad0-6cd1647e905f"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("b519ee27-47d8-486a-a0e4-3dfba526ca40"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("b9ac7157-9847-465f-b288-26a5f471519c"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("b9e13b57-0fd5-40ba-9f8c-0afdab9b4e1b"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("bd0a481c-f9a2-419c-99b7-5f8352f17541"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("bed75909-6f45-4a8c-a7cb-5dca3fc61adc"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("c06cd075-037a-466e-9180-2af65efeaeb1"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("c0fcab94-33c9-41fe-9788-44561ac423a9"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("c5217814-da8d-497c-b7c5-12c12575d465"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("c559c60d-28c9-4e51-b639-f8db426dd58c"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("c5c45345-c601-4978-9808-06ad8b77fb62"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("c5ef7a7b-3832-493e-8c53-8d6bb05609e7"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("c622cb5d-4f34-4c81-aa41-752a0c55a514"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("cba67a01-8895-4215-bc52-3cdf566a6fa5"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("cc13b733-19bc-4440-ba0d-fd9cb1b2f755"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("ccbd1a54-e85a-45ca-a125-69f9b85a04d1"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("ccc3e204-80c9-4104-a0a1-3cd421c3db78"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("ccdaee0f-79cf-43da-a34b-4b4336ab5f32"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("cd46c903-f640-4844-ad4c-e99d35ea7b5a"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("ce173151-a957-48fb-87d7-77ef65ae422d"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("d310565f-0c1f-40d9-9166-80b404ec12fc"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("d475bfd3-5bc3-4185-8dbb-269a26ae50f3"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("d6f1d49a-b4fb-45f1-bdf6-1924cb75add4"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("d810593c-5817-45f6-9292-fbe886c17c76"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("dc5f756e-a1dd-409c-9e2d-8e98ebdbe791"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("dc91b3a0-23aa-4fd0-88e7-85ea8027ad8c"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("dce4c333-d24b-4cc6-9297-873df89a2d21"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("e094c20b-6708-44fb-b11a-a4ce665366d2"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("e4a9298b-58a6-4ae6-98d7-531dfc0e4558"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("eba9e2d1-440b-49b8-8861-0f9bc7cf668c"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("ed701365-6da1-46fe-bdfd-a5ea549db565"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("ef9db620-dd0b-4f7a-8f7c-5feef834d084"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("f0b5c633-1f1b-4f36-ba29-89de161f147b"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("f1075b37-436f-406e-97ca-80df599e95ff"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("f246d643-818c-46a0-82d2-d3d5ba9f45be"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("f2d72547-2049-42c6-ab5a-174bec4f0cf6"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("f4762345-53d0-4b4f-be1f-092affd937f4"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("f4ae5328-eecc-40f3-bbc3-6714438a8ce3"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("f55fcfba-dfc0-4a23-b80b-ae706a4f26da"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("f585a5a5-6be4-4c6f-b985-e046b8f6bad1"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("f89dee56-49a6-4aba-a982-4c7023c079cd"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("f94a25e9-4c7a-49b1-9455-fdac5152b58e"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("fa35d904-5472-4177-9693-50b53aae2832"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("fc48c01b-2b53-416e-b00b-f840af122e86"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("fdbe9e4a-affb-4a92-bd51-585b8afd95d1"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("fece8942-d66e-4eab-8490-39634b3696f6"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Nouns",
                keyColumn: "Id",
                keyValue: new Guid("ff1a4f2a-4b3f-4531-bd64-9452d9756ca5"));

            migrationBuilder.DropColumn(
                name: "Type",
                schema: "practice",
                table: "Nouns");
        }
    }
}
