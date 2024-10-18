using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddLessonIdToScore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM practice.\"Scores\"");
            migrationBuilder.Sql("DELETE FROM practice.\"LessonScoreIds\"");
            migrationBuilder.Sql("DELETE FROM identity.\"UserScoreIds\"");
            
            migrationBuilder.RenameColumn(
                name: "ExerciseId",
                schema: "practice",
                table: "Scores",
                newName: "LessonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LessonId",
                schema: "practice",
                table: "Scores",
                newName: "ExerciseId");
        }
    }
}
