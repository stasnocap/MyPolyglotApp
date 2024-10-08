using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddCompounds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Compounds",
                schema: "practice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Text = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compounds", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "practice",
                table: "Compounds",
                columns: new[] { "Id", "Text", "Type" },
                values: new object[,]
                {
                    { new Guid("0a5d0c3c-9901-41aa-957d-e01d3c785690"), "everywhere", 3 },
                    { new Guid("1284f5ca-4e8c-4905-b7dd-bf66ee432a6f"), "somebody", 1 },
                    { new Guid("14937d44-2b42-4fcc-b1ad-9f98ac8e744d"), "anybody", 2 },
                    { new Guid("1e80b3b8-445a-428b-aac0-4077621f648d"), "sometimes", 1 },
                    { new Guid("1f912eca-38ee-4e38-b4eb-3f6de281ab06"), "something", 1 },
                    { new Guid("57ac0ad6-ae94-4123-b2d3-240f358fb949"), "everybody", 3 },
                    { new Guid("5f0d509b-9473-4fac-b8c7-8ddbe77e6d05"), "nothing", 4 },
                    { new Guid("7002f039-8a85-48f2-a37d-e50a9d560c38"), "someone", 1 },
                    { new Guid("7dafbc0e-13dd-4964-87de-8f260d32a335"), "anywhere", 2 },
                    { new Guid("9811f3cf-b01d-48d8-9b9f-3d04fdd173d7"), "anyone", 2 },
                    { new Guid("9d266ce8-561b-4121-9172-2f3d196813ba"), "anything", 2 },
                    { new Guid("c1be99b7-3d00-447e-92be-a78679082e82"), "somewhere", 1 },
                    { new Guid("d7b7eb2a-8001-48e5-985c-ca2ae236e86a"), "everyone", 3 },
                    { new Guid("dc8b90e3-5d5b-497d-ace9-46181b4cc5ec"), "everything", 3 },
                    { new Guid("fae6f4fa-886e-437d-ad3b-a3463e988216"), "nobody", 4 },
                    { new Guid("fe8150a2-b26f-499f-ae9b-57abb851cc00"), "nowhere", 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Compounds",
                schema: "practice");
        }
    }
}
