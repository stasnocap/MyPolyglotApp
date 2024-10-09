using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateComparisonAdjectives : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SyllablesCount",
                schema: "vocabulary",
                table: "ComparisonAdjectives");

            migrationBuilder.InsertData(
                schema: "vocabulary",
                table: "ComparisonAdjectives",
                columns: new[] { "Id", "ComparativeForm", "SuperlativeForm", "Text" },
                values: new object[,]
                {
                    { new Guid("2d76caf4-8636-4c12-987f-07feae8fd132"), "longer", "longest", "long" },
                    { new Guid("41744192-d34c-45a7-94e3-08685846f217"), "larger", "largest", "large" },
                    { new Guid("4b0c784e-f29d-49aa-9c8d-36ed4e54adf9"), "older", "oldest", "old" },
                    { new Guid("5132409c-4c9f-4f6c-8ebe-200087832496"), "happier", "happiest", "happy" },
                    { new Guid("5b0c5468-ba63-469b-9512-ca826287401a"), "sillier", "silliest", "silly" },
                    { new Guid("624a2190-1a68-46e4-be85-b9fff1198db5"), "bigger", "biggest", "big" },
                    { new Guid("c3df608b-c2cf-446d-9678-f426e523bc16"), "fatter", "fattest", "fat" },
                    { new Guid("e3d68928-1a39-449f-b285-92fee63f0d98"), "nicer", "nicest", "nice" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "vocabulary",
                table: "ComparisonAdjectives",
                keyColumn: "Id",
                keyValue: new Guid("2d76caf4-8636-4c12-987f-07feae8fd132"));

            migrationBuilder.DeleteData(
                schema: "vocabulary",
                table: "ComparisonAdjectives",
                keyColumn: "Id",
                keyValue: new Guid("41744192-d34c-45a7-94e3-08685846f217"));

            migrationBuilder.DeleteData(
                schema: "vocabulary",
                table: "ComparisonAdjectives",
                keyColumn: "Id",
                keyValue: new Guid("4b0c784e-f29d-49aa-9c8d-36ed4e54adf9"));

            migrationBuilder.DeleteData(
                schema: "vocabulary",
                table: "ComparisonAdjectives",
                keyColumn: "Id",
                keyValue: new Guid("5132409c-4c9f-4f6c-8ebe-200087832496"));

            migrationBuilder.DeleteData(
                schema: "vocabulary",
                table: "ComparisonAdjectives",
                keyColumn: "Id",
                keyValue: new Guid("5b0c5468-ba63-469b-9512-ca826287401a"));

            migrationBuilder.DeleteData(
                schema: "vocabulary",
                table: "ComparisonAdjectives",
                keyColumn: "Id",
                keyValue: new Guid("624a2190-1a68-46e4-be85-b9fff1198db5"));

            migrationBuilder.DeleteData(
                schema: "vocabulary",
                table: "ComparisonAdjectives",
                keyColumn: "Id",
                keyValue: new Guid("c3df608b-c2cf-446d-9678-f426e523bc16"));

            migrationBuilder.DeleteData(
                schema: "vocabulary",
                table: "ComparisonAdjectives",
                keyColumn: "Id",
                keyValue: new Guid("e3d68928-1a39-449f-b285-92fee63f0d98"));

            migrationBuilder.AddColumn<int>(
                name: "SyllablesCount",
                schema: "vocabulary",
                table: "ComparisonAdjectives",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                schema: "vocabulary",
                table: "ComparisonAdjectives",
                keyColumn: "Id",
                keyValue: new Guid("683eccbc-8eb0-4caf-8ea2-4b1d14d1dbf3"),
                column: "SyllablesCount",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "vocabulary",
                table: "ComparisonAdjectives",
                keyColumn: "Id",
                keyValue: new Guid("86eef14e-c54d-4199-8cef-667bc5020581"),
                column: "SyllablesCount",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "vocabulary",
                table: "ComparisonAdjectives",
                keyColumn: "Id",
                keyValue: new Guid("f4b23d49-a74b-4c92-a6f5-17f62ef05196"),
                column: "SyllablesCount",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "vocabulary",
                table: "ComparisonAdjectives",
                keyColumn: "Id",
                keyValue: new Guid("f8fa872b-1342-4768-ac8d-df3b0f2d4458"),
                column: "SyllablesCount",
                value: 1);
        }
    }
}
