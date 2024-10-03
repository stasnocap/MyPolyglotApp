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
                name: "lessons");

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
                schema: "lessons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    EngPhrase = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    RusPhrase = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                schema: "lessons",
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
                schema: "lessons",
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
                        principalSchema: "lessons",
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LessonExerciseIds",
                schema: "lessons",
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
                        principalSchema: "lessons",
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LessonScoreIds",
                schema: "lessons",
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
                        principalSchema: "lessons",
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "lessons",
                table: "Exercises",
                columns: new[] { "Id", "EngPhrase", "RusPhrase" },
                values: new object[,]
                {
                    { new Guid("69dfc0ba-ac95-44bb-b412-b36b2a45f6bb"), "Will i look?", "Я посмотрю?" },
                    { new Guid("6ed88863-0c5d-45cd-b361-3071bf62a907"), "Ты не увидишь.", "You will not see." },
                    { new Guid("dacb0b73-7bb2-491f-9bf6-adb1f3e2f50f"), "She worked.", "Она работала." },
                    { new Guid("ec6ea7e1-3dbb-45a7-801c-3441c6ef962f"), "Will we show?", "Мы покажем?" },
                    { new Guid("f8d8fcb2-4df3-4321-9538-fe576ef04c2d"), "You didn't think.", "Ты не думал." }
                });

            migrationBuilder.InsertData(
                schema: "lessons",
                table: "Lessons",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[] { new Guid("099df6d4-f116-4b6e-8cae-96dd9f3623dd"), "Базовая форма глагола", 1 });

            migrationBuilder.InsertData(
                schema: "lessons",
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
                schema: "lessons",
                table: "Words",
                columns: new[] { "Id", "ExerciseId", "Number", "Type" },
                values: new object[,]
                {
                    { new Guid("048a3fde-45da-4846-b695-46a84a6a0ab7"), new Guid("69dfc0ba-ac95-44bb-b412-b36b2a45f6bb"), 2, 14 },
                    { new Guid("0b73df81-66af-4114-ad46-2de5277e873d"), new Guid("69dfc0ba-ac95-44bb-b412-b36b2a45f6bb"), 1, 9 },
                    { new Guid("1b4bcdc8-e2a3-4d19-9881-082cb4498fbd"), new Guid("f8d8fcb2-4df3-4321-9538-fe576ef04c2d"), 2, 13 },
                    { new Guid("248c01ec-7b14-4f91-a9ed-9390bd0f13d4"), new Guid("dacb0b73-7bb2-491f-9bf6-adb1f3e2f50f"), 2, 16 },
                    { new Guid("2aab0806-f1b2-4b07-b6cb-e8c9990cf577"), new Guid("f8d8fcb2-4df3-4321-9538-fe576ef04c2d"), 3, 16 },
                    { new Guid("37312666-31bc-4ba6-819b-cfeeebddd54c"), new Guid("6ed88863-0c5d-45cd-b361-3071bf62a907"), 2, 9 },
                    { new Guid("460e1c54-fb25-4d6e-b937-864515821542"), new Guid("69dfc0ba-ac95-44bb-b412-b36b2a45f6bb"), 3, 16 },
                    { new Guid("5a31e7cc-939b-4ee8-afcf-d99662d80a4c"), new Guid("6ed88863-0c5d-45cd-b361-3071bf62a907"), 1, 14 },
                    { new Guid("5ade30d1-77bb-43f6-bd92-82aec6aa3222"), new Guid("ec6ea7e1-3dbb-45a7-801c-3441c6ef962f"), 2, 14 },
                    { new Guid("6781979f-ea8a-44a9-be13-93944ff40345"), new Guid("dacb0b73-7bb2-491f-9bf6-adb1f3e2f50f"), 1, 14 },
                    { new Guid("900133cd-7e00-4ce5-b2d8-87ba098ccf6c"), new Guid("f8d8fcb2-4df3-4321-9538-fe576ef04c2d"), 1, 14 },
                    { new Guid("9f902885-4e65-4b7d-a72b-7dab937a8498"), new Guid("6ed88863-0c5d-45cd-b361-3071bf62a907"), 3, 16 },
                    { new Guid("b1218895-1d15-4bb5-9da6-0f5aa9766724"), new Guid("ec6ea7e1-3dbb-45a7-801c-3441c6ef962f"), 1, 9 },
                    { new Guid("d2d2dabb-4033-4fee-abec-8eab0c408c84"), new Guid("ec6ea7e1-3dbb-45a7-801c-3441c6ef962f"), 3, 16 }
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
                schema: "lessons",
                table: "LessonExerciseIds",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonScoreIds_LessonId",
                schema: "lessons",
                table: "LessonScoreIds",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_UserScoreIds_UserId",
                schema: "identity",
                table: "UserScoreIds",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Words_ExerciseId",
                schema: "lessons",
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
                schema: "lessons");

            migrationBuilder.DropTable(
                name: "LessonScoreIds",
                schema: "lessons");

            migrationBuilder.DropTable(
                name: "UserScoreIds",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "Words",
                schema: "lessons");

            migrationBuilder.DropTable(
                name: "AspNetRoles",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "Lessons",
                schema: "lessons");

            migrationBuilder.DropTable(
                name: "AspNetUsers",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "Exercises",
                schema: "lessons");
        }
    }
}
