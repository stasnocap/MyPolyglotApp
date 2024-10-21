using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddRatingToScore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM practice.\"LessonScoreIds\"");
            migrationBuilder.Sql("DELETE FROM practice.\"Scores\"");
            migrationBuilder.Sql("DELETE FROM identity.\"UserScoreIds\"");
            
            migrationBuilder.RenameColumn(
                name: "ScoreValue",
                schema: "practice",
                table: "Scores",
                newName: "Rating_WrongNumber");

            migrationBuilder.AddColumn<int>(
                name: "Rating_CorrectNumber",
                schema: "practice",
                table: "Scores",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "Rating_Rate",
                schema: "practice",
                table: "Scores",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating_CorrectNumber",
                schema: "practice",
                table: "Scores");

            migrationBuilder.DropColumn(
                name: "Rating_Rate",
                schema: "practice",
                table: "Scores");

            migrationBuilder.RenameColumn(
                name: "Rating_WrongNumber",
                schema: "practice",
                table: "Scores",
                newName: "ScoreValue");
        }
    }
}
