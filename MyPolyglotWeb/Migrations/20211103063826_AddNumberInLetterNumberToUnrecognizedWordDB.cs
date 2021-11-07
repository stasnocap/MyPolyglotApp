using Microsoft.EntityFrameworkCore.Migrations;

namespace MyPolyglotWeb.Migrations
{
    public partial class AddNumberInLetterNumberToUnrecognizedWordDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberInLetterNumber",
                table: "UnrecognizedWord",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberInLetterNumber",
                table: "UnrecognizedWord");
        }
    }
}
