using Microsoft.EntityFrameworkCore.Migrations;

namespace MyPolyglotWeb.Migrations
{
    public partial class AddWasRecognizedFromPluralFormFieldToUnrecognizedWord : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "WasRecognizedFromPluralForm",
                table: "UnrecognizedWord",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WasRecognizedFromPluralForm",
                table: "UnrecognizedWord");
        }
    }
}
