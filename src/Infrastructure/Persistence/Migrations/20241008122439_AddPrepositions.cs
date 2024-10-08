using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddPrepositions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prepositions",
                schema: "practice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prepositions", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "practice",
                table: "Prepositions",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { new Guid("0030e9fe-b7f2-44a0-9561-72312a3d90fd"), "opposite" },
                    { new Guid("03839a0b-94c8-4ecf-9e67-4952db8cfab3"), "ago" },
                    { new Guid("04b2ca86-608b-4b0c-9d67-ad756ca79f4e"), "near" },
                    { new Guid("0ae076f4-649a-4346-bd40-02b0b7d2c710"), "beyond" },
                    { new Guid("0c4294f3-327b-4eb9-8831-951c236b3e37"), "under" },
                    { new Guid("0f6fafc1-c5eb-4401-931a-debf4a65f728"), "across" },
                    { new Guid("0fe30342-b74c-4136-9636-4d89fff18de0"), "from" },
                    { new Guid("131fad37-0e85-4e99-9f26-3d20a989394a"), "toward" },
                    { new Guid("246fbad8-a590-423c-b9b5-48886501f621"), "aboard" },
                    { new Guid("26c92022-b7bc-4c95-ba23-f8eedccb2868"), "in" },
                    { new Guid("2ace2fa7-821b-4db1-8d98-d667cd2ae57c"), "round" },
                    { new Guid("2ef33252-685c-48e6-9281-3f609f66b7a0"), "as" },
                    { new Guid("3403ee74-673a-4bda-acfc-d135cbf468d7"), "than" },
                    { new Guid("3518e7c5-18c0-4624-9e57-39edd55e2c5b"), "off" },
                    { new Guid("35264b0e-a345-4a2a-97a0-77fac3077520"), "following" },
                    { new Guid("36a5ec67-8236-4633-95ea-2465b9333139"), "before" },
                    { new Guid("3e0b8392-0434-4351-9373-19a4be5f96e8"), "then" },
                    { new Guid("4fbfc4e5-495e-4ef1-9522-851483702851"), "per" },
                    { new Guid("516c2674-c9bf-4c0f-860a-976999751714"), "via" },
                    { new Guid("516d2b89-4ecc-4c59-a899-396c36bb0b2b"), "except" },
                    { new Guid("5516e049-ec23-4182-8046-b24465cca0b1"), "versus" },
                    { new Guid("5c9d8453-c5ae-49a7-a0b1-78c71d85224c"), "through" },
                    { new Guid("63992e57-31c2-4340-984d-a105ac52a865"), "minus" },
                    { new Guid("64db07d1-263c-4add-9b36-683706b9f171"), "of" },
                    { new Guid("663dbdc5-eee5-4a7d-ae6f-26ba63303f5c"), "anti" },
                    { new Guid("783d2ea9-3bcb-473a-af99-dd209f7e04ff"), "regarding" },
                    { new Guid("7b3c5115-faa0-4355-85dc-2ec976be3793"), "after" },
                    { new Guid("7f878ec0-1e74-41d4-aca7-b819d0b65ea6"), "into" },
                    { new Guid("82cb41ac-c41e-41db-a55e-9828e163f1d1"), "among" },
                    { new Guid("83192b0e-0caf-4dcd-a9d9-e0cb13b193f3"), "despite" },
                    { new Guid("83a7211c-fd5d-441e-b198-8b44befc2e1a"), "until" },
                    { new Guid("83d901e7-b772-4870-80f1-54dae00c64d8"), "down" },
                    { new Guid("87a385cd-306b-4c63-a75d-61878fe2e502"), "plus" },
                    { new Guid("8a9251d2-c821-4fe8-bc5d-ece189c72939"), "behind" },
                    { new Guid("8e95e1f5-c09d-4697-9b68-ef441df09af4"), "amid" },
                    { new Guid("9d77e7ff-bff5-41fa-b70c-164b45ead20a"), "underneath" },
                    { new Guid("9e87a351-3d94-4037-825a-8eda3d6f3650"), "but" },
                    { new Guid("9fd75223-53f7-4221-b4a8-01439e4e67b3"), "about" },
                    { new Guid("a121847c-af91-4c15-a095-b457ef6f1f78"), "beneath" },
                    { new Guid("a3d589cd-1c19-40c3-9637-fc365a9bc370"), "since" },
                    { new Guid("a8d9601e-466b-4692-b959-e052325cfbfc"), "besides" },
                    { new Guid("a9de3c60-e5a4-47e5-9d58-68e7ec493e0e"), "without" },
                    { new Guid("aa005900-1d04-499e-8623-d32fb6cbcc1f"), "up" },
                    { new Guid("aec0ce77-7a36-46d5-a071-fde8dd8dca3f"), "concerning" },
                    { new Guid("b3efaafb-1826-4548-879e-cb1366ec2753"), "between" },
                    { new Guid("b66ae075-99e9-435b-bf6a-dbdf5526dbdf"), "during" },
                    { new Guid("c3c80b52-c594-495f-9be5-43d2e6691eb4"), "around" },
                    { new Guid("c4a0c377-5159-4044-ac48-6d6f44baaad2"), "to" },
                    { new Guid("c6840982-5776-4f45-b3ce-4dc6724eb769"), "over" },
                    { new Guid("ca49d61b-8819-460d-8743-4b3de38b06be"), "save" },
                    { new Guid("ceefd2ed-ae04-427d-94ce-ece35551f504"), "onto" },
                    { new Guid("d1b35063-29c3-4d42-b169-6d955bc3cc2d"), "unlike" },
                    { new Guid("d3830f80-738e-487b-aba5-4f66a9bb171f"), "past" },
                    { new Guid("dbf3c1e1-dd11-433d-a2ac-e01dd197e056"), "excepting" },
                    { new Guid("e22c1b46-ef0b-4b79-ae79-19dbb6d481ec"), "along" },
                    { new Guid("e42d087f-cf56-4671-a7e9-b816b7fec5e0"), "with" },
                    { new Guid("e49816da-2b0c-4882-80de-1db6a3a46045"), "considering" },
                    { new Guid("e78fea2f-8aaf-49b2-bd9b-8456caa2430a"), "against" },
                    { new Guid("e797b489-9322-4d25-b9c5-140798975c21"), "by" },
                    { new Guid("e80f9dcf-9e7e-4260-b3e3-d4a9571a0fa6"), "for" },
                    { new Guid("e890b4a7-b2fa-4d74-968c-bd717f72b01e"), "within" },
                    { new Guid("ebbb3faf-b17a-40c8-b716-ffc09a3500fa"), "towards" },
                    { new Guid("ec5d1566-90d7-481a-8cc2-3ee9cfef9a93"), "beside" },
                    { new Guid("f0b7e1d1-d200-4783-b759-082a420f7ca1"), "at" },
                    { new Guid("f1b984b4-74e1-4811-b38a-03201124c205"), "upon" },
                    { new Guid("f8ca831c-7cde-4a51-bbbb-657ffac0f4e0"), "excluding" },
                    { new Guid("fc9455a5-bf8e-45ab-ae25-18a6b6085128"), "on" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prepositions",
                schema: "practice");
        }
    }
}
