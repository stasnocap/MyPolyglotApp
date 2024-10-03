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
                name: "Pronouns",
                schema: "practice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pronouns", x => x.Id);
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
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Text = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
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
                columns: new[] { "Id", "LessonId", "RusPhrase" },
                values: new object[,]
                {
                    { new Guid("69dfc0ba-ac95-44bb-b412-b36b2a45f6bb"), new Guid("099df6d4-f116-4b6e-8cae-96dd9f3623dd"), "Я посмотрю?" },
                    { new Guid("6ed88863-0c5d-45cd-b361-3071bf62a907"), new Guid("099df6d4-f116-4b6e-8cae-96dd9f3623dd"), "Ты не увидишь." },
                    { new Guid("dacb0b73-7bb2-491f-9bf6-adb1f3e2f50f"), new Guid("099df6d4-f116-4b6e-8cae-96dd9f3623dd"), "Она работала." },
                    { new Guid("ec6ea7e1-3dbb-45a7-801c-3441c6ef962f"), new Guid("099df6d4-f116-4b6e-8cae-96dd9f3623dd"), "Мы покажем?" },
                    { new Guid("f8d8fcb2-4df3-4321-9538-fe576ef04c2d"), new Guid("099df6d4-f116-4b6e-8cae-96dd9f3623dd"), "Ты не думал." }
                });

            migrationBuilder.InsertData(
                schema: "practice",
                table: "Lessons",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[] { new Guid("099df6d4-f116-4b6e-8cae-96dd9f3623dd"), "Базовая форма глагола", 1 });

            migrationBuilder.InsertData(
                schema: "practice",
                table: "Pronouns",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { new Guid("004a6a6b-bb91-4d03-bec1-ba2529fab0c0"), "he" },
                    { new Guid("0bb651d1-cc92-41a5-9b24-2934db01ed07"), "they" },
                    { new Guid("1a412290-7271-4385-8fc9-f08be3b0452c"), "she" },
                    { new Guid("575963a0-80f7-4024-9c82-90e52aea846a"), "it" },
                    { new Guid("60a86ad4-6d5f-4874-819a-61f9c200b7b1"), "we" },
                    { new Guid("95280413-d92d-4907-827e-1bd3fadd5f20"), "you" },
                    { new Guid("c5e9499f-6682-4de2-bb4c-f6cf2c3e5e7f"), "i" }
                });

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
                columns: new[] { "Id", "ExerciseId", "Number", "Text", "Type" },
                values: new object[,]
                {
                    { new Guid("03e9797f-ab16-4422-bfd9-bf76ca33f436"), new Guid("6ed88863-0c5d-45cd-b361-3071bf62a907"), 1, "You", 14 },
                    { new Guid("16738012-8d9a-4790-810e-bbf91672cdf6"), new Guid("ec6ea7e1-3dbb-45a7-801c-3441c6ef962f"), 1, "Will", 9 },
                    { new Guid("1deab725-e374-4ad7-a169-45a4e77d58f5"), new Guid("6ed88863-0c5d-45cd-b361-3071bf62a907"), 3, "see.", 16 },
                    { new Guid("37b924c3-3886-49a1-8c0a-07a718957e92"), new Guid("69dfc0ba-ac95-44bb-b412-b36b2a45f6bb"), 3, "look?", 16 },
                    { new Guid("4da38ea9-9eb1-4463-928b-5d38bea9c17b"), new Guid("ec6ea7e1-3dbb-45a7-801c-3441c6ef962f"), 3, "show?", 16 },
                    { new Guid("862f83cd-d378-410e-88d6-27b01a06a2dc"), new Guid("f8d8fcb2-4df3-4321-9538-fe576ef04c2d"), 1, "You", 14 },
                    { new Guid("9215550e-7cfd-4e41-a946-90e09def9e39"), new Guid("dacb0b73-7bb2-491f-9bf6-adb1f3e2f50f"), 2, "worked?", 16 },
                    { new Guid("a5915abb-95f9-425d-a054-5ee27997b634"), new Guid("ec6ea7e1-3dbb-45a7-801c-3441c6ef962f"), 2, "we", 14 },
                    { new Guid("c02b1a8b-0138-47d6-873b-16e084831444"), new Guid("6ed88863-0c5d-45cd-b361-3071bf62a907"), 2, "will not", 9 },
                    { new Guid("ccac4b45-c615-438b-aeb4-2ec52947e9c4"), new Guid("69dfc0ba-ac95-44bb-b412-b36b2a45f6bb"), 1, "Will", 9 },
                    { new Guid("d74bcb9b-36d6-4ec0-8cf8-b1a8be9624af"), new Guid("dacb0b73-7bb2-491f-9bf6-adb1f3e2f50f"), 1, "She", 14 },
                    { new Guid("dfd01a72-3ec6-47b1-8a40-32c3a32ad2da"), new Guid("69dfc0ba-ac95-44bb-b412-b36b2a45f6bb"), 2, "I", 14 },
                    { new Guid("e86dff93-aeb8-476b-bfe0-ded0dc21e2de"), new Guid("f8d8fcb2-4df3-4321-9538-fe576ef04c2d"), 2, "didn't", 13 },
                    { new Guid("ee70e409-d59e-4c23-86eb-1f2878181e1b"), new Guid("f8d8fcb2-4df3-4321-9538-fe576ef04c2d"), 3, "think.", 16 }
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
                name: "Pronouns",
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
