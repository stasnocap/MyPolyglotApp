using Microsoft.EntityFrameworkCore.Migrations;

namespace MyPolyglotWeb.Migrations
{
    public partial class AddSavingBoolStressOnTheFinalSyllable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "StressOnTheFinalSyllableInRegularVerb",
                table: "UnrecognizedWord",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StressOnTheFinalSyllableInRegularVerb",
                table: "UnrecognizedWord");
        }
    }
}
