using Microsoft.EntityFrameworkCore.Migrations;

namespace MyPolyglotWeb.Migrations
{
    public partial class DeleteForeignKeyFromScore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Score_Lesson_LessonId",
                table: "Score");

            migrationBuilder.DropIndex(
                name: "IX_Score_LessonId",
                table: "Score");

            migrationBuilder.AlterColumn<long>(
                name: "LessonId",
                table: "Score",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.CreateIndex(
                name: "IX_Score_LessonId",
                table: "Score",
                column: "LessonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Score_Lesson_LessonId",
                table: "Score",
                column: "LessonId",
                principalTable: "Lesson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Score_Lesson_LessonId",
                table: "Score");

            migrationBuilder.DropIndex(
                name: "IX_Score_LessonId",
                table: "Score");

            migrationBuilder.AlterColumn<long>(
                name: "LessonId",
                table: "Score",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Score_LessonId",
                table: "Score",
                column: "LessonId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Score_Lesson_LessonId",
                table: "Score",
                column: "LessonId",
                principalTable: "Lesson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
