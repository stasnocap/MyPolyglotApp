using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePrimaryVerbData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "vocabulary",
                table: "FullNegativeForms",
                keyColumn: "Id",
                keyValue: 6,
                column: "PrimaryVerbId",
                value: new Guid("aedf0d06-70b2-4270-8c69-6a5b7ce26d1c"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "vocabulary",
                table: "FullNegativeForms",
                keyColumn: "Id",
                keyValue: 6,
                column: "PrimaryVerbId",
                value: new Guid("928e8efd-1a11-4df9-9703-0631fa073ca3"));
        }
    }
}
