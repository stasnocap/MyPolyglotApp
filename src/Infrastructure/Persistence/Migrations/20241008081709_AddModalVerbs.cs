using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddModalVerbs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ModalVerbs",
                schema: "practice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FullNegativeForm = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ShortNegativeForm = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Text = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModalVerbs", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "practice",
                table: "ModalVerbs",
                columns: new[] { "Id", "FullNegativeForm", "ShortNegativeForm", "Text" },
                values: new object[,]
                {
                    { new Guid("049459c0-d360-4e84-9499-f0156a12af0a"), "should not", "shouldn't", "should" },
                    { new Guid("07a979c4-4070-424f-9955-add7ec49d7c6"), "could not", "couldn't", "could" },
                    { new Guid("0865aeff-7a9f-463b-95f0-67f9cbf8135e"), "shall not", "shan't", "shall" },
                    { new Guid("1dc96fe8-384f-4d79-beac-bf986a7d53f6"), "must not", "mustn't", "must" },
                    { new Guid("58470a27-303f-41b5-8424-353ba5f82acb"), "would not", "wouldn't", "would" },
                    { new Guid("9e1402dd-db46-41b2-b142-d391b4b6af65"), "might not", "mightn't", "might" },
                    { new Guid("aa286b6f-7950-40c5-aa8b-64458a76f318"), "will not", "won't", "will" },
                    { new Guid("dd88989e-31bf-471e-931f-feb4033553b8"), "may not", "may not", "may" },
                    { new Guid("f4297e70-5d11-4212-adfa-a46e66da77b8"), "can not", "can't", "can" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModalVerbs",
                schema: "practice");
        }
    }
}
