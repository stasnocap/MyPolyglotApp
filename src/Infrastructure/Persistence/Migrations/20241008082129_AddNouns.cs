using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddNouns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nouns",
                schema: "practice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PluralForm = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Text = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nouns", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "practice",
                table: "Nouns",
                columns: new[] { "Id", "PluralForm", "Text" },
                values: new object[,]
                {
                    { new Guid("02410ac9-865a-4ef4-bf35-a97c572c775d"), "parentheses", "parenthesis" },
                    { new Guid("055014c0-4580-4f66-8a26-909c81ada9ab"), "sheep", "sheep" },
                    { new Guid("0a5a1b84-4e5f-4491-a81b-1023baa21587"), "moose", "moose" },
                    { new Guid("0a97d081-940f-4ac2-be45-5415f901bfd3"), "formulae", "formula" },
                    { new Guid("0af3f8c9-04b7-4826-98f3-2eee9f18bf54"), "fezzes", "fez" },
                    { new Guid("0bb3c129-831b-4360-9405-c86ba88b2bd1"), "species", "species" },
                    { new Guid("0f1d1568-8748-434e-b393-13f3e76a890b"), "oases", "oasis" },
                    { new Guid("1031bfa3-afaa-4f8d-ba5c-67c4bd76e090"), "quizzes", "quiz" },
                    { new Guid("10a584ce-08d0-45a3-a2c1-60c0ed418ba5"), "referenda", "referendum" },
                    { new Guid("12bd1acd-141f-4248-8db5-e4a598317e88"), "dice", "die" },
                    { new Guid("14879bb3-f4f6-49eb-868c-756ec9b5eb75"), "apices", "apex" },
                    { new Guid("1a7c848f-23df-4a78-9922-5600755ac939"), "memoranda", "memorandum" },
                    { new Guid("1ec16fa1-e22e-460f-992f-ed1a5f6e6cdf"), "selves", "self" },
                    { new Guid("1f9d67de-d6b1-430a-91f5-ca59f2fefef0"), "vortices", "vortex" },
                    { new Guid("23a9befc-3bcb-4ba2-b10c-9d01815df55f"), "radii", "radius" },
                    { new Guid("23b223ea-134a-4d78-8cd0-375fe647016a"), "curricula", "curriculum" },
                    { new Guid("2788328f-fd07-4825-826b-dd5b84989b9e"), "antitheses", "antithesis" },
                    { new Guid("29fb9af0-59cd-45ef-b294-d6ef961d5f4d"), "oxen", "ox" },
                    { new Guid("2b64ff6f-e4fa-4cf7-8dc4-b58532d79dec"), "geese", "goose" },
                    { new Guid("2c2b0889-79f3-4f76-87db-3a5cc02011fd"), "data", "datum" },
                    { new Guid("3212ad08-807e-4c7d-9a38-65d76b3b8dc7"), "phenomena", "phenomenon" },
                    { new Guid("35926da0-252d-4b68-ba64-7e8a271e72a9"), "alumni", "alumnus" },
                    { new Guid("37e39b47-4899-4716-8ac8-484c2137d2b9"), "beaux", "beau" },
                    { new Guid("3a40539b-f6f7-4af5-97b9-797130ab9e3e"), "dwarves", "dwarf" },
                    { new Guid("3e84413f-4522-4cdd-8e01-d868a1d1495e"), "addenda", "addendum" },
                    { new Guid("3f3ed318-2891-4c78-924b-70ba61c288d6"), "grouse", "grouse" },
                    { new Guid("40ac69ca-7f16-4830-a6b1-d3f50ab7ca6a"), "criteria", "criterion" },
                    { new Guid("4476956e-2d7e-47ae-8ec9-73d1a091c0c8"), "media", "medium" },
                    { new Guid("472ae0b3-27d9-4488-998d-af50d84fde9d"), "lice", "louse" },
                    { new Guid("4869c0cb-2bcd-4b69-b0ef-4821a4c5f8c2"), "genera", "genus" },
                    { new Guid("488678df-1b0c-4049-99b4-2e6b77b64b56"), "symposia", "symposium" },
                    { new Guid("4be04cba-73f9-4ca9-ae4e-a20074556716"), "bureaux", "bureau" },
                    { new Guid("532cc556-74b3-445a-8032-5d931a579c6f"), "aircraft", "aircraft" },
                    { new Guid("5c17986c-b2e5-48fe-9ba2-1429d1f9d4f8"), "people", "person" },
                    { new Guid("61ae4477-73f5-49e4-a7f4-68a3279b709c"), "halves", "half" },
                    { new Guid("67907bc9-6be9-4e8a-a017-b1a1411e3d10"), "bases", "basis" },
                    { new Guid("69d77d54-8dc5-43c6-b4cc-a1fc81790ee4"), "codices", "codex" },
                    { new Guid("6c68af73-e165-42c1-8712-fc6321b85b3a"), "bison", "bison" },
                    { new Guid("6c7ed5f2-cc74-4b98-b44b-9c987fc57baa"), "antennae", "antenna" },
                    { new Guid("6cac2ba2-42c6-452e-8851-2e91113c08a2"), "strata", "stratum" },
                    { new Guid("6d3db140-c060-49c0-aa80-83269a7c1f92"), "diagnoses", "diagnosis" },
                    { new Guid("6eea2102-f1ca-43a4-80d4-9efc03cbc9a9"), "axes", "axis" },
                    { new Guid("6ef22f13-96f9-4f6a-a828-789b7f8771b6"), "deer", "deer" },
                    { new Guid("7726b965-9229-433e-b6c7-774425b641f7"), "bacilli", "bacillus" },
                    { new Guid("7ec7af1c-2f7b-4c81-b003-9a2c42098c3e"), "wharves", "wharf" },
                    { new Guid("844263ed-8a64-4537-b02c-c409d8e234ca"), "foci", "focus" },
                    { new Guid("844a8806-4cb2-42e8-a970-fb6ac9411381"), "vitae", "vita" },
                    { new Guid("8d84d2ed-0381-4c20-b3ed-3e86116ff176"), "errata", "erratum" },
                    { new Guid("9e719618-3957-45f5-a579-84db93d75679"), "swine", "swine" },
                    { new Guid("9e93f191-4112-49ee-8a8a-beb6efb5f98c"), "chateaux", "chateau" },
                    { new Guid("9ec6c1d6-14f0-496a-85f6-649c2b1942db"), "theses", "thesis" },
                    { new Guid("a139edc3-a54b-48a1-a41f-e26e49406068"), "concerti", "concerto" },
                    { new Guid("a20cd4b1-626b-4d55-9636-c5abe59388c5"), "hypotheses", "hypothesis" },
                    { new Guid("a361de63-7e01-4833-bc76-af3688ba0861"), "larvae", "larva" },
                    { new Guid("a4d2cb74-9c23-4629-9c3b-fa5dd7d8cb0f"), "men", "man" },
                    { new Guid("aa3c70eb-c598-4ba3-9e60-9d10596b5bda"), "salmon", "salmon" },
                    { new Guid("ac376ab4-ca67-4015-bb32-4937b2013f4c"), "syllabi", "syllabus" },
                    { new Guid("b106231d-6747-42de-b599-fc3bbd88b5b6"), "tableaux", "tableau" },
                    { new Guid("b1c21999-f653-4c3b-ac25-4f978a2e03c6"), "vertebrae", "vertebra" },
                    { new Guid("b2276b1b-4e10-4361-9098-b9119a6a30a7"), "thieves", "thief" },
                    { new Guid("b29a2e94-bdd0-48dc-8c3c-bf6f1f7cf546"), "matrices", "matrix" },
                    { new Guid("b779d65e-e66f-4320-9a5b-b55f7d54d4a8"), "nebulae", "nebula" },
                    { new Guid("bd8fd622-e592-4b3a-bb17-d9606b7aa5c2"), "libretti", "libretto" },
                    { new Guid("bdc6e7dd-ece8-4ef8-b06b-dac3cb09cabc"), "stimuli", "stimulus" },
                    { new Guid("be97eb44-72bc-4ead-ad82-4568cba67059"), "children", "child" },
                    { new Guid("c135498f-f97c-457e-9a3c-d6e23dc578dd"), "bacteria", "bacterium" },
                    { new Guid("c557a8d7-70f2-4752-914a-40cbd5c7f356"), "phyla", "phylum" },
                    { new Guid("c570f1e7-090c-462f-aa6a-361b0109f561"), "teeth", "tooth" },
                    { new Guid("c5bf888a-a578-4267-9301-a819269efdf5"), "nuclei", "nucleus" },
                    { new Guid("c6f4bb5e-4653-4edf-bc00-63fea7d5276b"), "wolves", "wolf" },
                    { new Guid("c74d197c-7d53-4385-a56d-68a8701b2a7c"), "synopses", "synopsis" },
                    { new Guid("c9d8d5e8-85ce-4254-bd81-813e367c7763"), "graffiti", "graffito" },
                    { new Guid("cbb70e24-54a7-4984-bb40-9280fe3a4dc1"), "crises", "crisis" },
                    { new Guid("cf84efdc-aa12-48c8-bd99-d6b41236dabd"), "analyses", "analysis" },
                    { new Guid("d3b0da8d-49aa-4f45-9a04-da1629643f58"), "wives", "wife" },
                    { new Guid("d3c30d3c-75b2-4fe5-ba31-18f309f3c587"), "indices", "index" },
                    { new Guid("d6416b77-e82b-4d3d-ae47-2e828bf4df32"), "feet", "foot" },
                    { new Guid("d6adf7fa-98cd-4800-9594-dc270d7174cc"), "loci", "locus" },
                    { new Guid("d7870492-791a-4703-b988-de79eb5fd243"), "scarves", "scarf" },
                    { new Guid("d8d16893-49fd-4bad-b9f0-a769c05fafc8"), "loaves", "loaf" },
                    { new Guid("df480d98-db6d-4700-a3ff-05f896ef7dc7"), "appendices", "appendix" },
                    { new Guid("e51bd39b-d01e-4d64-82b5-74820f7f8298"), "vertices", "vertex" },
                    { new Guid("ec72ed55-7737-4a17-940c-206cb755300f"), "mice", "mouse" },
                    { new Guid("eda699d8-8c96-46a3-8479-8df3a0d85df2"), "corpora", "corpus" },
                    { new Guid("ef0a61de-fcd0-4d29-9c4f-f728710a3833"), "ellipses", "ellipsis" },
                    { new Guid("ef44000a-07c9-4bb5-91ff-af40b26a9169"), "alumnae", "alumna" },
                    { new Guid("ef872690-a08c-4498-9a4c-f94c22cf80cd"), "women", "woman" },
                    { new Guid("f0e8d288-1e01-454e-a8d7-60aedaa503cc"), "ova", "ovum" },
                    { new Guid("f129f9e5-3bf3-4b65-9a4d-51a6cc59ed97"), "minutiae", "minutia" },
                    { new Guid("f22b22cb-6507-45b3-82a7-7c6faec7919b"), "hooves", "hoof" },
                    { new Guid("f752aee6-0190-4fee-88b2-54659742dc7c"), "cacti", "cactus" },
                    { new Guid("f877f17d-92d7-4d29-8112-a8fa5b63609b"), "opera", "opus" },
                    { new Guid("fcf3ec11-03cf-46e3-9e15-5dee1882b272"), "series", "series" },
                    { new Guid("fd759b28-1d26-4c33-aefd-f0dbb8ce1787"), "fungi", "fungus" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nouns",
                schema: "practice");
        }
    }
}
