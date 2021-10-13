using Microsoft.EntityFrameworkCore.Migrations;

namespace MyPolyglotWeb.Migrations
{
    public partial class AddSyllablesInRegularComparisonAdjective : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SyllablesInRegularComparisonAdjective",
                table: "UnrecognizedWord",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SyllablesInRegularComparisonAdjective",
                table: "UnrecognizedWord");
        }
    }
}
