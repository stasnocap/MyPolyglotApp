using Microsoft.EntityFrameworkCore.Migrations;

namespace MyPolyglotWeb.Migrations
{
    public partial class RenameWasRecognizedFromPluralFormToWasRecognizedFromPluralFormInNoun : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WasRecognizedFromPluralForm",
                table: "UnrecognizedWord",
                newName: "WasRecognizedFromPluralFormInNoun");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WasRecognizedFromPluralFormInNoun",
                table: "UnrecognizedWord",
                newName: "WasRecognizedFromPluralForm");
        }
    }
}
