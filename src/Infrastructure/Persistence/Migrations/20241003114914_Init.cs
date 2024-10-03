using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "identity");

            migrationBuilder.EnsureSchema(
                name: "practice");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                schema: "identity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                schema: "identity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exercises",
                schema: "practice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    LessonId = table.Column<Guid>(type: "uuid", nullable: false),
                    EngPhrase = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    RusPhrase = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                schema: "practice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Number = table.Column<int>(type: "integer", maxLength: 255, nullable: false),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                schema: "identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "identity",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                schema: "identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                schema: "identity",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                schema: "identity",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "identity",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                schema: "identity",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    LoginProvider = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserScoreIds",
                schema: "identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ScoreId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserScoreIds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserScoreIds_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Words",
                schema: "practice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ExerciseId = table.Column<Guid>(type: "uuid", nullable: false),
                    Number = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Words", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Words_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalSchema: "practice",
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LessonExerciseIds",
                schema: "practice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ExerciseId = table.Column<Guid>(type: "uuid", nullable: false),
                    LessonId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonExerciseIds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LessonExerciseIds_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalSchema: "practice",
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LessonScoreIds",
                schema: "practice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ScoreId = table.Column<Guid>(type: "uuid", nullable: false),
                    LessonId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonScoreIds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LessonScoreIds_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalSchema: "practice",
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "practice",
                table: "Exercises",
                columns: new[] { "Id", "EngPhrase", "LessonId", "RusPhrase" },
                values: new object[,]
                {
                    { new Guid("69dfc0ba-ac95-44bb-b412-b36b2a45f6bb"), "Will i look?", new Guid("099df6d4-f116-4b6e-8cae-96dd9f3623dd"), "Я посмотрю?" },
                    { new Guid("6ed88863-0c5d-45cd-b361-3071bf62a907"), "Ты не увидишь.", new Guid("099df6d4-f116-4b6e-8cae-96dd9f3623dd"), "You will not see." },
                    { new Guid("dacb0b73-7bb2-491f-9bf6-adb1f3e2f50f"), "She worked.", new Guid("099df6d4-f116-4b6e-8cae-96dd9f3623dd"), "Она работала." },
                    { new Guid("ec6ea7e1-3dbb-45a7-801c-3441c6ef962f"), "Will we show?", new Guid("099df6d4-f116-4b6e-8cae-96dd9f3623dd"), "Мы покажем?" },
                    { new Guid("f8d8fcb2-4df3-4321-9538-fe576ef04c2d"), "You didn't think.", new Guid("099df6d4-f116-4b6e-8cae-96dd9f3623dd"), "Ты не думал." }
                });

            migrationBuilder.InsertData(
                schema: "practice",
                table: "Lessons",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[] { new Guid("099df6d4-f116-4b6e-8cae-96dd9f3623dd"), "Базовая форма глагола", 1 });

            migrationBuilder.InsertData(
                schema: "practice",
                table: "LessonExerciseIds",
                columns: new[] { "Id", "LessonId", "ExerciseId" },
                values: new object[,]
                {
                    { 1, new Guid("099df6d4-f116-4b6e-8cae-96dd9f3623dd"), new Guid("6ed88863-0c5d-45cd-b361-3071bf62a907") },
                    { 2, new Guid("099df6d4-f116-4b6e-8cae-96dd9f3623dd"), new Guid("ec6ea7e1-3dbb-45a7-801c-3441c6ef962f") },
                    { 3, new Guid("099df6d4-f116-4b6e-8cae-96dd9f3623dd"), new Guid("dacb0b73-7bb2-491f-9bf6-adb1f3e2f50f") },
                    { 4, new Guid("099df6d4-f116-4b6e-8cae-96dd9f3623dd"), new Guid("f8d8fcb2-4df3-4321-9538-fe576ef04c2d") },
                    { 5, new Guid("099df6d4-f116-4b6e-8cae-96dd9f3623dd"), new Guid("69dfc0ba-ac95-44bb-b412-b36b2a45f6bb") }
                });

            migrationBuilder.InsertData(
                schema: "practice",
                table: "Words",
                columns: new[] { "Id", "ExerciseId", "Number", "Type" },
                values: new object[,]
                {
                    { new Guid("025b5bb4-c9e1-4e78-ba1c-fca0d1682c1d"), new Guid("6ed88863-0c5d-45cd-b361-3071bf62a907"), 3, 16 },
                    { new Guid("13394798-f440-42c6-a29c-f3b0a2c3ac75"), new Guid("f8d8fcb2-4df3-4321-9538-fe576ef04c2d"), 3, 16 },
                    { new Guid("266676ca-171d-4732-bc40-f12bd6df44f0"), new Guid("ec6ea7e1-3dbb-45a7-801c-3441c6ef962f"), 2, 14 },
                    { new Guid("275afd08-1346-4b40-bebb-da9c29191564"), new Guid("6ed88863-0c5d-45cd-b361-3071bf62a907"), 2, 9 },
                    { new Guid("367c462d-4ee7-4a18-a893-72f6d7f06627"), new Guid("6ed88863-0c5d-45cd-b361-3071bf62a907"), 1, 14 },
                    { new Guid("4e1ff101-6d6f-494c-9176-e7166141786a"), new Guid("ec6ea7e1-3dbb-45a7-801c-3441c6ef962f"), 1, 9 },
                    { new Guid("5d114101-ac9f-478d-a44d-a8eb62df31f4"), new Guid("f8d8fcb2-4df3-4321-9538-fe576ef04c2d"), 1, 14 },
                    { new Guid("8547f67c-ee17-4e52-be8c-0b1e36655e49"), new Guid("f8d8fcb2-4df3-4321-9538-fe576ef04c2d"), 2, 13 },
                    { new Guid("b0da53aa-6bd8-47c7-9d45-d52d4286f049"), new Guid("69dfc0ba-ac95-44bb-b412-b36b2a45f6bb"), 2, 14 },
                    { new Guid("b5ce28cb-d49e-4aee-a9f1-8f2fddfdfe7d"), new Guid("69dfc0ba-ac95-44bb-b412-b36b2a45f6bb"), 3, 16 },
                    { new Guid("b69c646d-0764-4f8b-babc-851202589f7d"), new Guid("69dfc0ba-ac95-44bb-b412-b36b2a45f6bb"), 1, 9 },
                    { new Guid("bb4b8972-c64c-4f87-a047-a04336a7f18e"), new Guid("ec6ea7e1-3dbb-45a7-801c-3441c6ef962f"), 3, 16 },
                    { new Guid("d5b8ee02-bea0-4b61-a911-d9d0a8b9d960"), new Guid("dacb0b73-7bb2-491f-9bf6-adb1f3e2f50f"), 2, 16 },
                    { new Guid("f0511203-5ae6-46cc-b5b7-c68e3b4f7057"), new Guid("dacb0b73-7bb2-491f-9bf6-adb1f3e2f50f"), 1, 14 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                schema: "identity",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "identity",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                schema: "identity",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                schema: "identity",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                schema: "identity",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "identity",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "identity",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LessonExerciseIds_LessonId",
                schema: "practice",
                table: "LessonExerciseIds",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonScoreIds_LessonId",
                schema: "practice",
                table: "LessonScoreIds",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_UserScoreIds_UserId",
                schema: "identity",
                table: "UserScoreIds",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Words_ExerciseId",
                schema: "practice",
                table: "Words",
                column: "ExerciseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "LessonExerciseIds",
                schema: "practice");

            migrationBuilder.DropTable(
                name: "LessonScoreIds",
                schema: "practice");

            migrationBuilder.DropTable(
                name: "UserScoreIds",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "Words",
                schema: "practice");

            migrationBuilder.DropTable(
                name: "AspNetRoles",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "Lessons",
                schema: "practice");

            migrationBuilder.DropTable(
                name: "AspNetUsers",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "Exercises",
                schema: "practice");
        }
    }
}
