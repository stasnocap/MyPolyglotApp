using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddDeterminers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Determiners",
                schema: "practice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Determiners", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "practice",
                table: "Determiners",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { new Guid("586087f2-906f-4f2e-ac79-2b0f1f7c451a"), "a" },
                    { new Guid("b95eb82b-9a9b-45e9-8c27-3653515fc072"), "the" },
                    { new Guid("cbc50098-c6f7-4b4d-b0fd-8b168caabaee"), "an" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Determiners",
                schema: "practice");
        }
    }
}
