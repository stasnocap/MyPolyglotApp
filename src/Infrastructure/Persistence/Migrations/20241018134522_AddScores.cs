using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddScores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Scores",
                schema: "practice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ScoreValue = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ExerciseId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scores", x => x.Id);
                });

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("dacb0b73-7bb2-491f-9bf6-adb1f3e2f50f"),
                column: "RusPhrase",
                value: "Она работала?");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Scores",
                schema: "practice");

            migrationBuilder.UpdateData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("dacb0b73-7bb2-491f-9bf6-adb1f3e2f50f"),
                column: "RusPhrase",
                value: "Она работала.");
        }
    }
}
