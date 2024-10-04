using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddAdjectives : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adjectives",
                schema: "practice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adjectives", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "practice",
                table: "Adjectives",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { new Guid("001ea687-2f01-4707-9777-d643ebb7b3e8"), "human" },
                    { new Guid("09d933a8-b8e8-4127-97d1-3b194a3a45fb"), "black" },
                    { new Guid("0f3734e6-0a3e-488e-860d-63adc8c1b54a"), "important" },
                    { new Guid("12a4278f-cdbb-45d3-94f1-8f0c60baacc5"), "long" },
                    { new Guid("26d25d94-60a0-4180-bc40-e2ae17a0d32f"), "public" },
                    { new Guid("2d43b70f-6a8a-4787-8c0a-8a3e1f14b7bf"), "strong" },
                    { new Guid("33b401e3-28e8-4ce8-952f-8ed0c124d062"), "small" },
                    { new Guid("3ac69980-9dfb-46b5-8805-a4ed17f28dd3"), "special" },
                    { new Guid("49d9e76c-7eb9-4f74-94d2-8d7dbf63ebfb"), "certain" },
                    { new Guid("4b431829-1a43-4494-89bb-ce500ca1eb61"), "economic" },
                    { new Guid("4d60b419-3040-4b89-a633-c628129d9374"), "recent" },
                    { new Guid("53e66e87-89fd-4813-b111-c672d5af5b45"), "true" },
                    { new Guid("592a18a7-f26f-43af-92c9-6bb16b33ac33"), "great" },
                    { new Guid("61f2f73e-bfb2-435f-ac09-697b6bf5ed76"), "hard" },
                    { new Guid("62adbba2-6052-4c06-90b3-87977b1aaa40"), "local" },
                    { new Guid("6cd412b7-34e5-439e-95d8-55b61db1cfa9"), "able" },
                    { new Guid("74df4727-1d71-466a-8dab-b1b552113f34"), "young" },
                    { new Guid("75b94ead-b444-4f1e-8bec-33e0d48141eb"), "easy" },
                    { new Guid("7a63d507-b061-42c1-b5f8-e386b5230724"), "new" },
                    { new Guid("7d0e593f-15fc-4c8b-bc48-72af46277bdf"), "political" },
                    { new Guid("86c28a12-8fa6-450f-84e8-fad454383431"), "late" },
                    { new Guid("8c0c10db-9f9b-4dec-8f11-72951152f6cf"), "free" },
                    { new Guid("8c42d1f8-d954-4f3e-ad59-69ec2728916e"), "other" },
                    { new Guid("8d50e8e9-c3b4-491e-ad36-1452e7fb0590"), "big" },
                    { new Guid("8f7a4db3-1bae-4a67-9fe8-e0901444b592"), "real" },
                    { new Guid("95172ed1-a690-4e59-a2d5-b969f711cf7b"), "federal" },
                    { new Guid("96028aa6-1dc7-4d38-b079-be0fc9b51d89"), "large" },
                    { new Guid("9fff9195-bb56-4c0f-85d6-9f7ee47142c6"), "social" },
                    { new Guid("b3e9a613-bb8e-43a0-80b0-50f74552e2e9"), "full" },
                    { new Guid("bcef7759-b7d8-4933-82ad-47edb5826296"), "different" },
                    { new Guid("c23d8e73-e9cc-4be1-aef7-f5b3e4e92c50"), "right" },
                    { new Guid("c616a9b0-e5a1-4e84-82b5-f8706a1c97f0"), "international" },
                    { new Guid("cb511321-ac54-4017-b4ea-8b53ea4d45de"), "possible" },
                    { new Guid("ce5944fa-27e6-4d6f-8a08-59681108a44f"), "whole" },
                    { new Guid("cec6a73d-7aad-4cc0-a1d4-c502b7315c79"), "low" },
                    { new Guid("e1c01e50-ec4c-4a89-822b-013ef61c04c2"), "national" },
                    { new Guid("eaff4bab-3c7c-4050-9f89-0707b328f1dc"), "high" },
                    { new Guid("ed995c14-bf43-4457-9a7d-a7a3564ee5f6"), "military" },
                    { new Guid("f0ad9463-7127-48d3-a731-0102fd1f7756"), "clear" },
                    { new Guid("f773e2ba-0ab9-49ea-8a3f-cf90d13b0092"), "old" },
                    { new Guid("fa6cc476-482f-4c12-8a38-e98b847e4a45"), "major" },
                    { new Guid("fca7cc2a-34f1-4c02-8528-52892dc0630e"), "white" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adjectives",
                schema: "practice");
        }
    }
}
