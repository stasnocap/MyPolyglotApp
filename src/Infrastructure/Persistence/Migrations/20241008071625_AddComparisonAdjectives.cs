using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddComparisonAdjectives : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Text",
                schema: "practice",
                table: "Cities",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                schema: "practice",
                table: "Adverbs",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                schema: "practice",
                table: "Adjectives",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.CreateTable(
                name: "ComparisonAdjectives",
                schema: "practice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ComparativeForm = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    SuperlativeForm = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    SyllablesCount = table.Column<int>(type: "integer", nullable: false),
                    Text = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComparisonAdjectives", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "practice",
                table: "ComparisonAdjectives",
                columns: new[] { "Id", "ComparativeForm", "SuperlativeForm", "SyllablesCount", "Text" },
                values: new object[,]
                {
                    { new Guid("683eccbc-8eb0-4caf-8ea2-4b1d14d1dbf3"), "good", "better", 1, "good" },
                    { new Guid("86eef14e-c54d-4199-8cef-667bc5020581"), "bad", "worse", 1, "bad" },
                    { new Guid("f4b23d49-a74b-4c92-a6f5-17f62ef05196"), "little", "less", 1, "little" },
                    { new Guid("f8fa872b-1342-4768-ac8d-df3b0f2d4458"), "far", "farther", 1, "far" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComparisonAdjectives",
                schema: "practice");

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                schema: "practice",
                table: "Cities",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                schema: "practice",
                table: "Adverbs",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                schema: "practice",
                table: "Adjectives",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);
        }
    }
}
