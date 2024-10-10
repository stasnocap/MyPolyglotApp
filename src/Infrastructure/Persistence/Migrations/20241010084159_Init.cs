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
                name: "vocabulary");

            migrationBuilder.EnsureSchema(
                name: "identity");

            migrationBuilder.EnsureSchema(
                name: "practice");

            migrationBuilder.CreateTable(
                name: "Adjectives",
                schema: "vocabulary",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adjectives", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Adverbs",
                schema: "vocabulary",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Text = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adverbs", x => x.Id);
                });

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
                name: "Cities",
                schema: "vocabulary",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ComparisonAdjectives",
                schema: "vocabulary",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ComparativeForm = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    SuperlativeForm = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Text = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComparisonAdjectives", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Compounds",
                schema: "vocabulary",
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

            migrationBuilder.CreateTable(
                name: "Determiners",
                schema: "vocabulary",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Determiners", x => x.Id);
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
                name: "Languages",
                schema: "vocabulary",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
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
                name: "LetterNumbers",
                schema: "vocabulary",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Number = table.Column<int>(type: "integer", nullable: false),
                    Text = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LetterNumbers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModalVerbs",
                schema: "vocabulary",
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

            migrationBuilder.CreateTable(
                name: "Nouns",
                schema: "vocabulary",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PluralForm = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Text = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nouns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prepositions",
                schema: "vocabulary",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prepositions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PrimaryVerbs",
                schema: "vocabulary",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PastForm = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    PastParticipleForm = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    PresentParticipleForm = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ThirdPersonForm = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Text = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrimaryVerbs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pronouns",
                schema: "vocabulary",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pronouns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestionWords",
                schema: "vocabulary",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionWords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Verbs",
                schema: "vocabulary",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PastForm = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    PastParticipleForm = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    PresentParticipleForm = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ThirdPersonForm = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    IsIrregularVerb = table.Column<bool>(type: "boolean", nullable: false),
                    Text = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Verbs", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "AdditionalForms",
                schema: "vocabulary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Text = table.Column<string>(type: "text", nullable: false),
                    PrimaryVerbId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdditionalForms_PrimaryVerbs_PrimaryVerbId",
                        column: x => x.PrimaryVerbId,
                        principalSchema: "vocabulary",
                        principalTable: "PrimaryVerbs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FullNegativeForms",
                schema: "vocabulary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Text = table.Column<string>(type: "text", nullable: false),
                    PrimaryVerbId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FullNegativeForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FullNegativeForms_PrimaryVerbs_PrimaryVerbId",
                        column: x => x.PrimaryVerbId,
                        principalSchema: "vocabulary",
                        principalTable: "PrimaryVerbs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShortNegativeForms",
                schema: "vocabulary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Text = table.Column<string>(type: "text", nullable: false),
                    PrimaryVerbId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShortNegativeForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShortNegativeForms_PrimaryVerbs_PrimaryVerbId",
                        column: x => x.PrimaryVerbId,
                        principalSchema: "vocabulary",
                        principalTable: "PrimaryVerbs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "vocabulary",
                table: "Adjectives",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { new Guid("001ea687-2f01-4707-9777-d643ebb7b3e8"), "human" },
                    { new Guid("09d933a8-b8e8-4127-97d1-3b194a3a45fb"), "black" },
                    { new Guid("0f3734e6-0a3e-488e-860d-63adc8c1b54a"), "important" },
                    { new Guid("12a4278f-cdbb-45d3-94f1-8f0c60baacc5"), "long" },
                    { new Guid("26d25d94-60a0-4180-bc40-e2ae17a0d32f"), "public" },
                    { new Guid("2d43b70f-6a8a-4787-8c0a-8a3e1f14b7bf"), "strong" },
                    { new Guid("33b401e3-28e8-4ce8-952f-8ed0c124d062"), "small" },
                    { new Guid("3ac69980-9dfb-46b5-8805-a4ed17f28dd3"), "special" },
                    { new Guid("49d9e76c-7eb9-4f74-94d2-8d7dbf63ebfb"), "certain" },
                    { new Guid("4b431829-1a43-4494-89bb-ce500ca1eb61"), "economic" },
                    { new Guid("4d60b419-3040-4b89-a633-c628129d9374"), "recent" },
                    { new Guid("53e66e87-89fd-4813-b111-c672d5af5b45"), "true" },
                    { new Guid("592a18a7-f26f-43af-92c9-6bb16b33ac33"), "great" },
                    { new Guid("61f2f73e-bfb2-435f-ac09-697b6bf5ed76"), "hard" },
                    { new Guid("62adbba2-6052-4c06-90b3-87977b1aaa40"), "local" },
                    { new Guid("6cd412b7-34e5-439e-95d8-55b61db1cfa9"), "able" },
                    { new Guid("74df4727-1d71-466a-8dab-b1b552113f34"), "young" },
                    { new Guid("75b94ead-b444-4f1e-8bec-33e0d48141eb"), "easy" },
                    { new Guid("7a63d507-b061-42c1-b5f8-e386b5230724"), "new" },
                    { new Guid("7d0e593f-15fc-4c8b-bc48-72af46277bdf"), "political" },
                    { new Guid("86c28a12-8fa6-450f-84e8-fad454383431"), "late" },
                    { new Guid("8c0c10db-9f9b-4dec-8f11-72951152f6cf"), "free" },
                    { new Guid("8c42d1f8-d954-4f3e-ad59-69ec2728916e"), "other" },
                    { new Guid("8d50e8e9-c3b4-491e-ad36-1452e7fb0590"), "big" },
                    { new Guid("8f7a4db3-1bae-4a67-9fe8-e0901444b592"), "real" },
                    { new Guid("95172ed1-a690-4e59-a2d5-b969f711cf7b"), "federal" },
                    { new Guid("96028aa6-1dc7-4d38-b079-be0fc9b51d89"), "large" },
                    { new Guid("9fff9195-bb56-4c0f-85d6-9f7ee47142c6"), "social" },
                    { new Guid("b3e9a613-bb8e-43a0-80b0-50f74552e2e9"), "full" },
                    { new Guid("bcef7759-b7d8-4933-82ad-47edb5826296"), "different" },
                    { new Guid("c23d8e73-e9cc-4be1-aef7-f5b3e4e92c50"), "right" },
                    { new Guid("c616a9b0-e5a1-4e84-82b5-f8706a1c97f0"), "international" },
                    { new Guid("cb511321-ac54-4017-b4ea-8b53ea4d45de"), "possible" },
                    { new Guid("ce5944fa-27e6-4d6f-8a08-59681108a44f"), "whole" },
                    { new Guid("cec6a73d-7aad-4cc0-a1d4-c502b7315c79"), "low" },
                    { new Guid("e1c01e50-ec4c-4a89-822b-013ef61c04c2"), "national" },
                    { new Guid("eaff4bab-3c7c-4050-9f89-0707b328f1dc"), "high" },
                    { new Guid("ed995c14-bf43-4457-9a7d-a7a3564ee5f6"), "military" },
                    { new Guid("f0ad9463-7127-48d3-a731-0102fd1f7756"), "clear" },
                    { new Guid("f773e2ba-0ab9-49ea-8a3f-cf90d13b0092"), "old" },
                    { new Guid("fa6cc476-482f-4c12-8a38-e98b847e4a45"), "major" },
                    { new Guid("fca7cc2a-34f1-4c02-8528-52892dc0630e"), "white" }
                });

            migrationBuilder.InsertData(
                schema: "vocabulary",
                table: "Adverbs",
                columns: new[] { "Id", "Text", "Type" },
                values: new object[,]
                {
                    { new Guid("06b63f96-d867-4089-a444-afdad6f686a1"), "cheerfully", 4 },
                    { new Guid("07315eee-23d9-4eef-81aa-e1d83e2185a6"), "now", 6 },
                    { new Guid("073df645-a63a-46e7-a527-ef018cdd9a09"), "just", 5 },
                    { new Guid("08da3304-edd0-4b51-afac-df4d9df6aadc"), "wholeheartedly", 4 },
                    { new Guid("08eeb1ba-1d56-4c87-ab23-f026508cd2f9"), "hardly", 5 },
                    { new Guid("09b7f46c-4213-409c-92e4-92a3b54b8a74"), "more", 5 },
                    { new Guid("0d154711-11f1-45ce-baa7-9e5199ec7bb1"), "happily", 3 },
                    { new Guid("138d4000-8884-444f-bee3-6b6216470deb"), "randomly", 4 },
                    { new Guid("146ba32f-dfdf-4d6d-bfb1-fab8e3ff6b18"), "regularly", 6 },
                    { new Guid("1d2b9ee7-cfe2-40d1-bd95-848b278c9473"), "totally", 2 },
                    { new Guid("1dcf9d91-267d-4ca4-b7f5-f1d80311d097"), "anymore", 5 },
                    { new Guid("1f297c5b-a8e7-44e4-b1a1-405c6d92509d"), "quickly", 3 },
                    { new Guid("251b0b09-d512-4ab7-9c91-8a96aab9146c"), "sloppily", 4 },
                    { new Guid("27d9a98b-acbf-4495-ab35-53951c9a0b4b"), "completely", 2 },
                    { new Guid("27db08cb-be2e-4280-9596-9f52d45875a4"), "below", 7 },
                    { new Guid("2a7fc2c7-0538-4574-b9c8-bc34908d5362"), "absolutely", 2 },
                    { new Guid("2d1aa07e-5472-44b7-a9ba-994f5b54dc5c"), "already", 6 },
                    { new Guid("2f032241-0194-4311-b015-a4c4f7f9aa86"), "only", 5 },
                    { new Guid("2f5e80a3-7744-4124-8d39-46e5b1fe04b9"), "softly", 3 },
                    { new Guid("38ea8366-d332-4576-83d1-afdc67703961"), "lately", 6 },
                    { new Guid("3959a763-5335-46a9-bae0-a32481172ecd"), "tonight", 6 },
                    { new Guid("3c740b58-f15f-4dc2-8e8f-b51c56b97e36"), "recently", 6 },
                    { new Guid("3dfd6253-296a-49ab-804a-241f0aeab532"), "later", 6 },
                    { new Guid("421d81cd-f9ad-4b20-b5f6-246462868462"), "mildly", 2 },
                    { new Guid("42c179af-b28c-4ca5-9301-9cd84f00bb79"), "last", 6 },
                    { new Guid("46055f33-27eb-4a2e-a0c1-9e88a2342af6"), "somewhat", 2 },
                    { new Guid("4613d83e-7a11-4429-a1e6-936b6ff7328d"), "yesterday", 6 },
                    { new Guid("47b31618-2e23-4294-8607-ad3f0fea8075"), "early", 6 },
                    { new Guid("497c17e2-cc84-4264-b899-90165b8272e0"), "neatly", 3 },
                    { new Guid("57a34429-a06b-425e-9baf-f926908f06c3"), "inside", 7 },
                    { new Guid("57dbb0ea-e426-4697-8d72-3db14f08def7"), "today", 6 },
                    { new Guid("5d0249b7-3a78-4d4d-b50c-7b359955a73e"), "lot", 5 },
                    { new Guid("5e925101-d482-4747-9604-3faf6a90a40d"), "patiently", 3 },
                    { new Guid("5f93a2d5-a9cc-4503-9d1b-ea80f67a8840"), "brutally", 4 },
                    { new Guid("60e819ce-1567-4133-b355-298dee29e9f5"), "quite", 5 },
                    { new Guid("627af486-ea38-44bd-8905-a4169104134d"), "so", 5 },
                    { new Guid("6785ecf8-6e16-4077-b65d-f030e25ec0f7"), "beautifully", 3 },
                    { new Guid("67b2f05a-a95c-4eb0-9b6d-3b03dd16e567"), "yet", 6 },
                    { new Guid("6980e458-ba5c-4b84-95b4-13d88a6d963e"), "finally", 3 },
                    { new Guid("6c5732d1-b30f-4376-b455-d3a8837b6adb"), "out", 7 },
                    { new Guid("6e6bfa3e-b872-4d40-a2ee-bca8b38df735"), "simply", 2 },
                    { new Guid("708edf03-6d6d-405e-a0c7-1137c6b322c9"), "noon", 6 },
                    { new Guid("73558002-dae1-4454-81e1-0ac91efd8543"), "really", 2 },
                    { new Guid("792bec50-bec4-43c2-8cd9-616357017b48"), "immediately", 6 },
                    { new Guid("7a6db825-b1bd-4b62-a38a-3f2d8bbeaec2"), "literally", 2 },
                    { new Guid("7ba93fa2-407b-4994-bccb-864ee3a3bacb"), "weirdly", 4 },
                    { new Guid("84bfcd78-65f7-462e-b14d-e968b60953e9"), "too", 5 },
                    { new Guid("84f6104b-22dd-4c7e-80ec-41e4d00fe22a"), "seldom", 1 },
                    { new Guid("8a9e842b-c20e-45b4-be2d-a58e42af182e"), "heartily", 2 },
                    { new Guid("8b4bca03-4b4f-4248-b965-2622a89a060c"), "some", 5 },
                    { new Guid("943847f3-1b60-4408-b426-e199c63feb9e"), "tomorrow", 6 },
                    { new Guid("952d6138-1e4b-4c2a-b501-c148951ec6ff"), "always", 1 },
                    { new Guid("96c1eab2-3c6e-4c61-ad14-c843169d7a99"), "soon", 6 },
                    { new Guid("99a909cb-3009-4db8-9784-799eff895f79"), "upstairs", 7 },
                    { new Guid("a1939cfc-1e06-45a7-9cde-8e8cf4615dc7"), "sure", 2 },
                    { new Guid("a4898e30-5cee-47af-8a82-930ca3ce6876"), "outside", 7 },
                    { new Guid("a9cd5877-b24c-4461-a249-ba138b7a865a"), "generously", 3 },
                    { new Guid("abb47450-ac60-4f2e-977e-669994062522"), "enough", 5 },
                    { new Guid("ad9f2bf6-c4fa-41e5-8ec4-67a99b368acc"), "first", 6 },
                    { new Guid("afc31295-9ca9-4e89-8c60-2a3b2386fb81"), "wickedly", 4 },
                    { new Guid("b1753526-2137-4f69-a477-d14177461043"), "normally", 1 },
                    { new Guid("b2608bc3-b018-463c-a991-eab9905e9a3c"), "expertly", 4 },
                    { new Guid("b4b603f7-325d-43c2-a46f-66c819ab46c4"), "no", 5 },
                    { new Guid("b7e195e5-e48f-4316-bfd5-937ce78018d5"), "back", 7 },
                    { new Guid("bc4f6294-b052-4e2e-8af0-76c09b7c8269"), "briskly", 4 },
                    { new Guid("bdd55547-2594-47ac-b133-dc65acd18caa"), "nearly", 5 },
                    { new Guid("c0553b92-071e-40ff-a2b0-151130618165"), "here", 7 },
                    { new Guid("c53aa959-925f-4d15-af41-e7d164d39e44"), "much", 5 },
                    { new Guid("c7b98dc0-9ee8-478a-8fbb-b65ddf996f05"), "very", 5 },
                    { new Guid("c9c178f6-425e-40ba-aa56-2e9df2189b21"), "almost", 5 },
                    { new Guid("ca4baf2b-f932-4341-bec7-6424620c2267"), "there", 7 },
                    { new Guid("caa4f524-5ab2-4513-b481-ebc398a02949"), "above", 7 },
                    { new Guid("cbafdc35-f148-42e4-91b8-c83942ff57f7"), "uneasily", 4 },
                    { new Guid("ccec5fd1-67c3-4a74-b975-7df7b2894297"), "usually", 1 },
                    { new Guid("e1d1c0d9-c2a0-46e5-86f5-1ad64584f7fd"), "well", 3 },
                    { new Guid("e3b0d5ef-dbbc-4a7e-b85c-dab9f7e49b83"), "also", 5 },
                    { new Guid("e7e0ea1f-839f-4410-9194-372f9dbeb5ec"), "underground", 7 },
                    { new Guid("ecbd054c-2179-45cd-9246-dda528c03808"), "rarely", 1 },
                    { new Guid("f3118375-021a-4c5b-b982-8c110861e56b"), "again", 1 },
                    { new Guid("f63c6bf3-e505-41e7-a506-59aa2ef5cde0"), "never", 1 },
                    { new Guid("f9e765ea-191e-4557-b871-c409f4da39ed"), "rather", 5 },
                    { new Guid("fe6f939d-2a3a-4ddc-af91-3352759f278e"), "every", 1 },
                    { new Guid("ff0c21ee-0c28-4267-aa0a-afac141db998"), "downstairs", 7 }
                });

            migrationBuilder.InsertData(
                schema: "vocabulary",
                table: "Cities",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { new Guid("004e1489-47fc-42d5-b64b-973d22792703"), "shenzhen" },
                    { new Guid("00d87649-e848-45b1-87d7-7a8caa57bef7"), "honolulu" },
                    { new Guid("00fba333-8a13-4180-937e-34accb4c96d2"), "heraklion" },
                    { new Guid("0217ca8b-a9d6-4ea1-b13a-2e905616bd8d"), "quito" },
                    { new Guid("02db7066-6020-4097-bd0b-06153a4b9d9f"), "kolkata" },
                    { new Guid("02ffe2cf-76e8-434d-8978-0531086da81d"), "auckland" },
                    { new Guid("0458e481-64d6-4446-bab0-0b255b87f14c"), "jeju" },
                    { new Guid("04a0a5cb-3f3f-4ce1-8130-dab87a736116"), "istanbul" },
                    { new Guid("09006d2d-30a7-4f1c-be93-e0e8df119635"), "durban" },
                    { new Guid("0cfe4419-a010-448b-a074-aa44f1019dcf"), "rome" },
                    { new Guid("0f0bf4d4-91e3-4613-8ba9-e378d8e722da"), "athens" },
                    { new Guid("1239dfd2-a03c-4e29-b5ea-c5a6667e751f"), "bangalore" },
                    { new Guid("12aae4af-77fc-40ef-9586-0ced382f4737"), "berlin" },
                    { new Guid("147e1912-38db-4a44-9905-20d1e8787bbe"), "denpasar" },
                    { new Guid("16e13ea0-3614-4068-b583-b0c19ed91856"), "hurghada" },
                    { new Guid("1cd0f9dd-a6ec-41f8-968e-59984671001d"), "chicago" },
                    { new Guid("211f4b1d-f082-472d-af62-096ebd07af03"), "osaka" },
                    { new Guid("217c5228-554d-40e5-ba7a-3c4aa44f72b6"), "dammam" },
                    { new Guid("2197793b-0ac2-4cdf-a594-cd6408f6a257"), "pattaya" },
                    { new Guid("237775bd-b5cf-4565-8d60-255b01c8c82c"), "geneva" },
                    { new Guid("288e3e2e-85b1-4fc0-8962-31385368f62e"), "stockholm" },
                    { new Guid("299f8056-6ff8-413d-8547-99861911b5b2"), "cairo" },
                    { new Guid("2b91063b-1dae-4fc8-8b36-3043b56a44e7"), "jaipur" },
                    { new Guid("2c54f958-f8b8-4d2a-874c-25127b9c55cd"), "agra" },
                    { new Guid("2c74f26c-ccd6-4464-b843-26ca5fef0801"), "san francisco" },
                    { new Guid("2d11b8c4-0565-4fd8-ae98-616c03f51d85"), "dublin" },
                    { new Guid("2e808832-8c5b-4d33-8952-4857221651d8"), "kyoto" },
                    { new Guid("2eb4968e-6094-4863-af50-f8b3f963bae8"), "bangkok" },
                    { new Guid("31a79e07-e061-463d-9ade-623e7d3e710f"), "saint petersburg" },
                    { new Guid("31f6225d-bedd-4c21-bce5-f27866e06001"), "sofia" },
                    { new Guid("32076951-2dca-4f5f-8b80-4cbc51b7048f"), "fukuoka" },
                    { new Guid("324cbf57-43a1-45b8-80b8-438a43a87f49"), "pune" },
                    { new Guid("334a7510-0bd7-44bb-84e4-0930ede3bf71"), "beirut" },
                    { new Guid("397454c6-3a76-4b73-b6c1-3c0056641c9c"), "cape town" },
                    { new Guid("3c13e5a2-2e26-46c4-af1c-cf380274a8a6"), "hong kong" },
                    { new Guid("3c51135c-c844-41fc-abab-5f1095cf953a"), "prague" },
                    { new Guid("3dc60e53-c9c4-40ad-8126-90015cc2fe59"), "hangzhou" },
                    { new Guid("3e2bc2f9-54d3-40fb-8bb3-552a2e524822"), "milan" },
                    { new Guid("3f50f11c-a1cd-457e-a8b9-5e537f639645"), "lima" },
                    { new Guid("3fd58a75-d3d5-4be7-8234-8ab14a25d4d9"), "riyadh" },
                    { new Guid("442aa21f-09ec-4127-a086-b4e4046a75a1"), "washington" },
                    { new Guid("454d2a0c-7e06-4bbd-8e9f-9b1b7b9e7f3e"), "antalya" },
                    { new Guid("46a88740-0bfa-40c2-b55b-6d791f9107eb"), "mexico city" },
                    { new Guid("47d98f58-4e3c-4753-ae50-99f5b973bd97"), "chiang mai" },
                    { new Guid("4a16e73a-5ef4-4eb4-add4-610760a774b0"), "dalian" },
                    { new Guid("4a2c2179-2087-4506-bb26-1a8f23a823d2"), "johor bahru" },
                    { new Guid("4deb9131-1686-4530-ae84-4baabddfbb89"), "paris" },
                    { new Guid("4e79b4b8-c155-4c9a-aec8-78ca8e11b67a"), "moscow" },
                    { new Guid("4f5a3efb-cb57-4b1b-b996-8270775dbbb1"), "ho chi minh city" },
                    { new Guid("51596f2e-d716-44c2-879b-62cd4cd22aed"), "chiba" },
                    { new Guid("52384405-f92a-4621-9121-c542463dfa52"), "singapore" },
                    { new Guid("54cab79a-3904-4e41-996e-262ba04cf25c"), "jerusalem" },
                    { new Guid("5543b786-84d3-4bbe-85e2-3d9bcd3a0104"), "dallas" },
                    { new Guid("57313435-831d-4922-ab82-76b256ecf11b"), "frankfurt am main" },
                    { new Guid("583e37d6-8519-4990-bbc3-f40752b64bf0"), "da nang" },
                    { new Guid("59f0fdee-a284-4ebd-9097-edc9ff623d81"), "brussels" },
                    { new Guid("5d56c3d8-baff-4f34-9780-ea0005a23f2c"), "qingdao" },
                    { new Guid("60b6abbb-01be-41e7-b619-b1ac1a1cc7a8"), "vienna" },
                    { new Guid("610fd267-5d9f-4c94-bfa8-61c33fcb5337"), "mecca" },
                    { new Guid("6117189b-1123-4bd4-a1c7-2aab6e2749b7"), "dubai" },
                    { new Guid("625b3f03-f8cf-43f7-be27-c46bdb449b16"), "atlanta" },
                    { new Guid("6547f467-d4b2-4434-988d-1a1beca40e40"), "kuala lumpur" },
                    { new Guid("67cc3cd9-722e-4a1a-967d-844e30cb7432"), "jakarta" },
                    { new Guid("69e72711-1514-4a92-a9b3-efaf1c0579e3"), "manila" },
                    { new Guid("6aa5f8d9-986f-45c9-b3d2-670f068651ba"), "houston" },
                    { new Guid("6b2e6086-ccc7-418e-bddd-3cb4e22ca84c"), "rio de janeiro" },
                    { new Guid("6d84a430-e682-4bcf-a374-a20f08163362"), "melbourne" },
                    { new Guid("6e03ee8c-bf54-458b-be1d-1526ec5d34ad"), "munich" },
                    { new Guid("6e8c591e-8ebf-4593-8cae-9d887936b441"), "marrakesh" },
                    { new Guid("6eff63a1-f1fd-41a3-a5c0-ddad077711ea"), "los angeles" },
                    { new Guid("70d83a46-5373-4ea8-97b4-2157a82bb319"), "amman" },
                    { new Guid("71f4bd84-ea1d-4bf4-ae68-005d3102ae1e"), "macau" },
                    { new Guid("74dd48a4-3eaa-4ad8-a1e3-bfdfff4fa07c"), "tokyo" },
                    { new Guid("76c96e30-678c-4eff-bd06-cedd5eb17471"), "orlando" },
                    { new Guid("77c06ec9-1099-4f81-afe0-71793a907636"), "abu dhabi" },
                    { new Guid("7814d421-cc69-4d17-a59f-d0bf13eaf30c"), "dusseldorf" },
                    { new Guid("7b1c5db4-a002-4d21-ac61-1139daa3f062"), "penang island" },
                    { new Guid("7bf5a42c-2859-460e-ba9d-4b698192b094"), "sao paulo" },
                    { new Guid("7d78c2c6-a6c8-4c72-be61-5e501234080c"), "san jose" },
                    { new Guid("7dc58758-f757-4c4e-9cef-f112be31930b"), "batam" },
                    { new Guid("86e837b1-21c0-4f2c-a803-78e3f060074e"), "guilin" },
                    { new Guid("8a63f2dc-87cc-4777-b767-8888a9611401"), "madrid" },
                    { new Guid("8f830b09-9b1a-440d-bdad-304c1a6f0839"), "lagos" },
                    { new Guid("909cf9b8-2db0-4643-8bd3-c27cce4a0247"), "punta cana" },
                    { new Guid("91b2ea5a-a5f6-4c96-820a-160035220d6a"), "phuket" },
                    { new Guid("943c7df3-b164-4fa0-9dfa-138e82f326ef"), "guangzhou" },
                    { new Guid("951ab533-4c68-4641-b930-644817b887de"), "cancun" },
                    { new Guid("957089f4-d3e3-4d0b-b36f-154ec06a60d1"), "taipei" },
                    { new Guid("9676472d-30fe-4b59-874b-db284b941ee7"), "zurich" },
                    { new Guid("984fdcaa-c922-42c1-a92e-15cc7b64d9f7"), "miami" },
                    { new Guid("99715af8-9b96-462b-904b-18142d608c2f"), "seoul" },
                    { new Guid("9b86c86b-c601-4c2a-b411-84b4f682bcef"), "hanoi" },
                    { new Guid("9d975109-24b7-4830-8d46-bafee5215980"), "copenhagen" },
                    { new Guid("9e1a1e3b-1ba4-40ee-8e86-bce4c7b62695"), "porto" },
                    { new Guid("9e44cc96-1cd2-4fbf-a9bf-f33c1976d41e"), "montevideo" },
                    { new Guid("9e4e14b5-cbab-4997-99e8-42059b1ee58c"), "ha long" },
                    { new Guid("a04d9cea-3071-4d69-8475-43be05d62d4d"), "tehran" },
                    { new Guid("a08bac8e-26e8-4d10-9284-a7552592b76a"), "johannesburg" },
                    { new Guid("a29062ff-06b4-4195-a6f0-065c53bbb1d4"), "chengdu" },
                    { new Guid("a2aab779-e37c-4355-8210-6b36f33cf570"), "edinburgh" },
                    { new Guid("a45c1999-c0c9-4b9b-a880-8a3a1987902b"), "delhi" },
                    { new Guid("a6bdba2c-600b-44b9-9c42-20ee3cbe817e"), "mugla" },
                    { new Guid("a7a8747a-8b0d-49d5-816f-2a1534f0cf63"), "buenos aires" },
                    { new Guid("aa672cc4-af1e-4191-a4f2-51c5269a4833"), "casablanca" },
                    { new Guid("ab4fd608-c983-4c55-9a56-9f0b14c3c8dd"), "cebu city" },
                    { new Guid("ac524206-43a4-41f7-94eb-62b58f4b1fe9"), "amsterdam" },
                    { new Guid("ac831b02-f212-402d-afcd-db8ca45a5628"), "beijing" },
                    { new Guid("ade16c64-1dd7-4a8f-9922-62165c7938e4"), "vancouver" },
                    { new Guid("afdf6e98-7e6a-454e-8c76-42413f45e3ea"), "lisbon" },
                    { new Guid("b11315b8-0ad3-4a55-a394-87a9db87d4a4"), "tel aviv" },
                    { new Guid("b290112a-c08b-440f-a207-97153fe17c34"), "bogota" },
                    { new Guid("b36f9dd4-9bf0-4aff-9fd9-48d826cf85bc"), "philadelphia" },
                    { new Guid("b4b5ded2-3056-43d8-82c9-4016206fb801"), "montreal" },
                    { new Guid("b4ddff71-34fe-4c62-a72f-283aedfb2384"), "sydney" },
                    { new Guid("b4e1e648-ac52-4af9-8aff-c2e63a2ca706"), "krabi" },
                    { new Guid("bbdb61a5-0609-49ca-a8d2-4a03b73015d7"), "las vegas" },
                    { new Guid("bd14f206-55ab-4787-9a12-f6d378bd724b"), "bucharest" },
                    { new Guid("c029ae46-040d-40a6-a0ed-abc90d4e082a"), "new york city" },
                    { new Guid("c243e28a-ef15-49aa-b681-735dba0d44e6"), "krakow" },
                    { new Guid("c7965ec1-a12a-4537-a5f2-ce8fbe20fcff"), "rhodes" },
                    { new Guid("cab88083-48e9-4f93-bade-6ec2617f42c5"), "toronto" },
                    { new Guid("cae872e9-9f82-4b58-8774-757d28164901"), "warsaw" },
                    { new Guid("caf3fde6-d053-4a21-ac1c-699775806ac5"), "zhuhai" },
                    { new Guid("cb7bda95-575f-4085-989e-fc35fff05756"), "boston" },
                    { new Guid("d3aef908-7852-4ea3-857a-29edf0273a5b"), "xiamen" },
                    { new Guid("d8061e66-6f1b-49a6-803a-4b1ec261a5a0"), "chennai" },
                    { new Guid("d8261afa-a0c4-4e3a-9594-d45d8166e50c"), "venice" },
                    { new Guid("de6d2828-1689-473d-a338-b4991d2cfc98"), "colombo" },
                    { new Guid("df18d59f-262f-4c3d-9e9a-d3b6fd27414b"), "barcelona" },
                    { new Guid("dfe1f1b0-b204-4fdb-a12e-9d25011ece3d"), "accra" },
                    { new Guid("e4618222-8af5-4e83-a108-499a6fc7ec1e"), "hamburg" },
                    { new Guid("e744d5f8-cbb3-4e6c-bb0a-073ba6e10617"), "budapest" },
                    { new Guid("e864a2fc-ee08-40b5-8b16-c511f4b06cc6"), "shanghai" },
                    { new Guid("ecec291b-bf10-4e56-b249-f31d80361187"), "london" },
                    { new Guid("f0225d18-cdd3-471d-bcb3-2ff288061d1d"), "mumbai" },
                    { new Guid("f2ec18b5-c484-409e-85f6-7bde52bbb416"), "tianjin" },
                    { new Guid("f649e87f-c026-4fb1-b251-15c98fd8492c"), "medina" },
                    { new Guid("fb365a07-c256-4ec0-9fb0-17716b60195e"), "florence" }
                });

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
                    { new Guid("683eccbc-8eb0-4caf-8ea2-4b1d14d1dbf3"), "good", "better", "good" },
                    { new Guid("86eef14e-c54d-4199-8cef-667bc5020581"), "bad", "worse", "bad" },
                    { new Guid("c3df608b-c2cf-446d-9678-f426e523bc16"), "fatter", "fattest", "fat" },
                    { new Guid("e3d68928-1a39-449f-b285-92fee63f0d98"), "nicer", "nicest", "nice" },
                    { new Guid("f4b23d49-a74b-4c92-a6f5-17f62ef05196"), "little", "less", "little" },
                    { new Guid("f8fa872b-1342-4768-ac8d-df3b0f2d4458"), "far", "farther", "far" }
                });

            migrationBuilder.InsertData(
                schema: "vocabulary",
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

            migrationBuilder.InsertData(
                schema: "vocabulary",
                table: "Determiners",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { new Guid("586087f2-906f-4f2e-ac79-2b0f1f7c451a"), "a" },
                    { new Guid("b95eb82b-9a9b-45e9-8c27-3653515fc072"), "the" },
                    { new Guid("cbc50098-c6f7-4b4d-b0fd-8b168caabaee"), "an" }
                });

            migrationBuilder.InsertData(
                schema: "practice",
                table: "Exercises",
                columns: new[] { "Id", "LessonId", "RusPhrase" },
                values: new object[,]
                {
                    { new Guid("05882a8b-9897-4793-8a1e-dd0cf841c95b"), new Guid("8eca71ba-7524-4b77-8dc3-5c3e2b051613"), "Ты открываешь ей." },
                    { new Guid("24de4efb-c76c-4d7c-ab9d-914a272962f7"), new Guid("8eca71ba-7524-4b77-8dc3-5c3e2b051613"), "Я показал им?" },
                    { new Guid("69dfc0ba-ac95-44bb-b412-b36b2a45f6bb"), new Guid("099df6d4-f116-4b6e-8cae-96dd9f3623dd"), "Я посмотрю?" },
                    { new Guid("6ed88863-0c5d-45cd-b361-3071bf62a907"), new Guid("099df6d4-f116-4b6e-8cae-96dd9f3623dd"), "Ты не увидишь." },
                    { new Guid("7f44ae6d-6b28-47aa-9d9b-500a632303ef"), new Guid("8eca71ba-7524-4b77-8dc3-5c3e2b051613"), "Он поймёт тебя." },
                    { new Guid("7fafec3f-f7fe-46d7-962d-79d62dc13f66"), new Guid("8eca71ba-7524-4b77-8dc3-5c3e2b051613"), "Я сломаю?" },
                    { new Guid("8cb2fa8b-6886-4fcd-a596-ecc8f15b406c"), new Guid("8eca71ba-7524-4b77-8dc3-5c3e2b051613"), "Мы не оставили его." },
                    { new Guid("dacb0b73-7bb2-491f-9bf6-adb1f3e2f50f"), new Guid("099df6d4-f116-4b6e-8cae-96dd9f3623dd"), "Она работала." },
                    { new Guid("ec6ea7e1-3dbb-45a7-801c-3441c6ef962f"), new Guid("099df6d4-f116-4b6e-8cae-96dd9f3623dd"), "Мы покажем?" },
                    { new Guid("f8d8fcb2-4df3-4321-9538-fe576ef04c2d"), new Guid("099df6d4-f116-4b6e-8cae-96dd9f3623dd"), "Ты не думал." }
                });

            migrationBuilder.InsertData(
                schema: "vocabulary",
                table: "Languages",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { new Guid("05fe75f9-6796-4c72-8a89-489c8d52f75d"), "south levantine arabic" },
                    { new Guid("0c6fb9bd-d798-4999-81e2-802b0a92d7d5"), "portuguese" },
                    { new Guid("0ec5d630-52e2-47e2-bd3c-aa5d558245c5"), "sudanese arabic" },
                    { new Guid("127f0d9f-ffb2-464e-acb5-fb56138d1bc2"), "cebuano" },
                    { new Guid("12df8673-0312-442d-8fd4-2a859b2cc684"), "bengali" },
                    { new Guid("1394dd73-1a4f-4d4a-879e-76f941fd1c5f"), "deccan" },
                    { new Guid("15d6f62b-8de9-4128-84e7-7935de4f73c5"), "korean" },
                    { new Guid("16914e1e-78c3-402d-a7be-2263fc6949f8"), "kazakh" },
                    { new Guid("1b286aad-c6c5-4fb4-ab1b-d14abadacbf6"), "gujarati" },
                    { new Guid("1c8d22a0-77f7-487d-9ce1-c495c60dadff"), "southern pashto" },
                    { new Guid("1ce69f17-8e7b-4b85-bff6-9fe41e697f4f"), "urdu" },
                    { new Guid("22ca4647-b89c-48a2-9bbb-4d9f14895887"), "assamese" },
                    { new Guid("2398731a-9c7b-4783-b666-77d340f6fcda"), "zulu" },
                    { new Guid("2661a965-a510-43c2-9f0b-3e992ea95ea1"), "moroccan arabic" },
                    { new Guid("2a42e510-4d68-4c95-aaf2-1e21d46dcd2b"), "burmese" },
                    { new Guid("31a6b8c2-f157-4e41-b2c0-336ca50c9507"), "chhattisgarhi" },
                    { new Guid("3288e392-6d22-4a8b-9106-94b70baba22f"), "eastern punjabi" },
                    { new Guid("36354dac-9c60-411d-816c-3e252de2df81"), "ta?izzi-adeni arabic" },
                    { new Guid("37bd1f60-8836-40dc-8088-552154d7bdd5"), "kinyarwanda" },
                    { new Guid("3b8a9bef-fcd5-4d66-9bb8-9d1b2f884781"), "jin chinese" },
                    { new Guid("3be86fab-c7d5-4efd-9346-f605fe823383"), "southern min" },
                    { new Guid("3d2e2737-03e7-4ede-92a3-924c5074e26c"), "tagalog" },
                    { new Guid("3e3d20f3-f7f7-4afe-8717-1fb96d3264be"), "western punjabi" },
                    { new Guid("4457ce47-bd82-41d1-87ac-7fdba55e2483"), "northern pashto" },
                    { new Guid("4696be38-54c4-411a-ba12-1ba4dae9feb8"), "odia" },
                    { new Guid("4a4eec31-fedd-45ea-9135-0a20e9cb264c"), "gan chinese" },
                    { new Guid("507ffed0-a57b-4f32-a8a3-137ff2264ae9"), "bavarian" },
                    { new Guid("58c26460-99cc-4f77-9977-af6d92ad49ba"), "south azerbaijani" },
                    { new Guid("5b0ced9e-6cc6-40d3-a89d-b3913d603700"), "javanese" },
                    { new Guid("5b59631d-dedd-41f6-8324-24200a1697d0"), "turkish" },
                    { new Guid("5ca70bdb-188e-4238-b312-1eb634c6a1a6"), "tunisian arabic" },
                    { new Guid("5d71e38e-110c-4da0-aab4-99dff6d649e5"), "xiang chinese" },
                    { new Guid("6368bc2e-4f36-497e-9a55-818e183149e9"), "wu chinese" },
                    { new Guid("6393822a-625f-4054-b8ae-5872dc246889"), "sanaani spoken arabic" },
                    { new Guid("673361d6-7d32-4944-98ee-4a7a354655b2"), "tamil" },
                    { new Guid("6a833428-0ac5-4f5a-a115-b9225514fa44"), "nigerian fulfulde" },
                    { new Guid("6c546a84-186a-4681-88a4-de913fbe4331"), "vietnamese" },
                    { new Guid("6cef15b5-fb9a-4992-9c7a-c37836c707cf"), "northern min" },
                    { new Guid("70ba1044-a598-4a1a-a451-4dba9cd3d549"), "malaysian" },
                    { new Guid("71704395-6919-4ddc-97ab-3222c3b06833"), "egyptian arabic" },
                    { new Guid("7558116a-387e-4b36-b8e0-8d1175cc8149"), "chittagonian" },
                    { new Guid("7cf32237-ea01-4d0c-9a23-89ed7edeb88d"), "yoruba" },
                    { new Guid("81cf3dcd-39da-4b39-8deb-7935a12be238"), "indonesian" },
                    { new Guid("834aeb5d-cc64-4f28-8ed3-5866c00b8bfd"), "czech" },
                    { new Guid("85b755ae-595e-4205-8a80-130a085d6707"), "romanian" },
                    { new Guid("89b8772b-6169-4fab-b305-65ccd46b6867"), "mesopotamian arabic" },
                    { new Guid("8c387e4d-812e-4699-acc2-d83817dd9cf5"), "marathi" },
                    { new Guid("90cac461-3cd8-4b1a-87dc-8965eb4109ea"), "nepali" },
                    { new Guid("913295ed-d47e-494f-807a-c8d18d866038"), "telugu" },
                    { new Guid("91b5ca59-9c4e-4c33-be2c-6b53dcb2d563"), "eastern min" },
                    { new Guid("95ede413-1620-48ea-90e5-415d32d3136f"), "hindi" },
                    { new Guid("96373b8c-3a10-430f-a0e8-487d7cd0a61f"), "sunda" },
                    { new Guid("968b9167-9ca8-4721-9ec2-9b8689671d3e"), "amharic" },
                    { new Guid("97719b21-50bc-4545-bbac-d3259c477c22"), "khmer" },
                    { new Guid("97b6e62a-8f05-48fc-971f-308572ffbfb3"), "japanese" },
                    { new Guid("9a03a8ec-8353-408c-b651-03ab17615f1e"), "uyghur" },
                    { new Guid("9b34f793-e999-4129-8b02-84e0ddea5ed7"), "mandarin chinese" },
                    { new Guid("9b5579a2-47d0-4096-9a2f-5d419e9bd7c9"), "northern uzbek" },
                    { new Guid("9c9b8a57-f2bc-45e7-860a-bd347ab45463"), "dutch" },
                    { new Guid("9d025102-c785-4c1e-9d66-6fa50edfd5c4"), "hakka" },
                    { new Guid("a1766dc0-2e54-42d5-a6b4-f81827903762"), "sinhalese" },
                    { new Guid("a40ae7ca-9561-4adc-aa70-45fe9f35a182"), "maithili" },
                    { new Guid("a4932f62-6a1e-4a21-a90a-55f615175328"), "north levantine arabic" },
                    { new Guid("a6ccc444-5e36-4126-9287-18944c3efe43"), "yue chinese" },
                    { new Guid("a7c1d64a-5994-4e7a-b9dc-b136d1c194a7"), "somali" },
                    { new Guid("a9ad5bb1-a485-4651-a1ba-fa6a3c464611"), "thai" },
                    { new Guid("b0dcf460-c418-4e0d-a29b-d9e4ab5e743f"), "sindhi" },
                    { new Guid("b6457d47-e469-44f6-9b02-836ca0ea268e"), "algerian arabic" },
                    { new Guid("b678be2e-9b78-4815-99e9-11ff110b8a00"), "rundi" },
                    { new Guid("bb4e540a-3058-4fe5-a999-fe6788fa354e"), "bhojpuri" },
                    { new Guid("bbd2c377-ef0e-4fa2-826b-64399b09c844"), "italian" },
                    { new Guid("c0d613e2-9fc4-4db9-b1c0-3f25b432e19a"), "saraiki" },
                    { new Guid("c10c047e-a8e8-4b8e-9bc2-0bb8a4c15814"), "ukrainian" },
                    { new Guid("cb5aa02e-6c20-47a9-ae60-38bae2796a90"), "english" },
                    { new Guid("cee97e98-3e18-4a44-859a-19bf4a9d94f7"), "hejazi arabic" },
                    { new Guid("d376604d-187b-44de-9bbf-3f8afd799120"), "northern kurdish" },
                    { new Guid("d8c23f83-1d83-4ff9-a6ce-0dc6e633fc36"), "polish" },
                    { new Guid("d9710773-5393-4ad7-8750-2b919fe1f182"), "iranian persian" },
                    { new Guid("dbc15f01-8b9f-414b-9289-16ba38ce025c"), "spanish" },
                    { new Guid("ddb8c1c2-e641-46e4-aeb5-063221d778b2"), "sa?idi arabic" },
                    { new Guid("e285a34d-ad4a-456c-a828-cb2b27108add"), "hausa" },
                    { new Guid("e7068004-70af-487e-9ea1-db94dc876c71"), "malayalam" },
                    { new Guid("e70ebfb6-30e8-4b2c-9d61-78d7c3a8fa71"), "french" },
                    { new Guid("eaad2199-ab5c-4a71-9118-2bfbebcff6fe"), "igbo" },
                    { new Guid("eaf19085-2520-4407-a24d-54a648e94867"), "kannada" },
                    { new Guid("eb367b00-bd5b-410c-a03d-7d6e21f2f702"), "sylheti" },
                    { new Guid("ecef3e89-4eb9-4ca3-83e0-df6a49b5011e"), "greek" },
                    { new Guid("ef5ef238-125e-40bd-bd5a-c4854011a8a9"), "hungarian" },
                    { new Guid("f3bef354-8344-4b02-8ed0-6f1bed89790c"), "german" },
                    { new Guid("f4c1939d-a5d8-4d82-9900-e10076eb635c"), "magahi" },
                    { new Guid("f78be4bd-e17d-4c70-8a41-2e16f4da061f"), "russian" }
                });

            migrationBuilder.InsertData(
                schema: "practice",
                table: "Lessons",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("06e34fe3-489b-4fce-ba46-f9e30c63146f"), "Фразовые глаголы", 15 },
                    { new Guid("099df6d4-f116-4b6e-8cae-96dd9f3623dd"), "Базовая форма глагола", 1 },
                    { new Guid("168e4970-41f5-441b-aedb-092556b63775"), "Present Perfect", 16 },
                    { new Guid("18da835a-791c-4dd7-915f-09abf79219d1"), "Предлоги и параметры времени", 8 },
                    { new Guid("19e63968-9aa1-4196-af9b-020bd589103c"), "Глагол to be. Предлоги места. Like/Want", 3 },
                    { new Guid("1d883b60-88a9-4186-a003-9939210b3fe2"), "Степени сравнения прилагательных. Указательные местоимения", 6 },
                    { new Guid("21b08001-36e3-4770-affa-e4a7e87e4c7e"), "Present Perfect Continuous", 20 },
                    { new Guid("255d72a1-b6e7-4fbb-bc5a-362f2b0c4efe"), "Continuous", 12 },
                    { new Guid("28d10443-9ac8-43e7-b176-2e40cb1565df"), "Simple Passive", 28 },
                    { new Guid("302c1e93-e339-4850-9bc9-47dd5e37decb"), "Повелительное наклонение", 14 },
                    { new Guid("35c865ea-0c11-4a46-a5f0-d8c168f88907"), "Модальные глаголы can, must, should", 11 },
                    { new Guid("441161d5-3f41-4e50-9655-a62c971b06b6"), "Past Perfect Continuous", 21 },
                    { new Guid("49723cf9-e420-4608-a368-f2ffbd006242"), "Предлоги направления и движения", 10 },
                    { new Guid("60b8431c-0450-4143-9baf-ca627495d7f5"), "The Participle", 27 },
                    { new Guid("614a255e-2239-42ef-95e6-101f95c28499"), "Present Participle Perfect", 26 },
                    { new Guid("65f77c8e-3d17-419e-9529-4326811c732c"), "Future Perfect", 18 },
                    { new Guid("7407b5e3-bcc3-4853-ba1c-740985bf7d52"), "Past Perfect", 17 },
                    { new Guid("7db36b76-017d-484b-b367-d82cea8b5036"), "Continuous Passive", 29 },
                    { new Guid("85f6a657-c644-4ef9-9454-37202576c089"), "Present Participle Simple", 24 },
                    { new Guid("8eca71ba-7524-4b77-8dc3-5c3e2b051613"), "Местоимения. Вопросительные слова", 2 },
                    { new Guid("8fdffe09-48a4-4b02-91ed-f808c121f45e"), "Passive Voice", 31 },
                    { new Guid("946446db-a1da-422e-bad6-ab7972987ae4"), "There is / There are", 9 },
                    { new Guid("95079976-cc2e-4d0b-a4c3-42c772ce35b9"), "Perfect Passive", 30 },
                    { new Guid("974db683-7a40-4a0a-84a4-afc012855961"), "Future Perfect Continuous", 22 },
                    { new Guid("a184277b-edcc-4af1-9c17-a2b11140be2f"), "Past Participle", 25 },
                    { new Guid("a26e89e2-cafd-4126-bc63-5ba53645ed6d"), "Описание людей. Погода", 13 },
                    { new Guid("a6c000b2-2aa9-4372-8788-aa7b7045b0c2"), "Perfect Tenses", 19 },
                    { new Guid("c61b363f-290f-4ff4-8cd3-1845414c680f"), "Профессии. Этикет", 5 },
                    { new Guid("d7b96b18-f735-43cd-bd5f-0aa0cfeab504"), "Perfect Continuous Tenses", 23 },
                    { new Guid("d9dadc04-9197-4b7a-aca6-c9ce18c1fef5"), "Слова-параметры. Употребление muck и many, little и few", 7 },
                    { new Guid("ef710306-a1b1-4823-93eb-64d8357ed6ea"), "Притяжательные местоимения", 4 }
                });

            migrationBuilder.InsertData(
                schema: "vocabulary",
                table: "LetterNumbers",
                columns: new[] { "Id", "Number", "Text" },
                values: new object[,]
                {
                    { new Guid("007e1cc4-4403-4c5c-8a6d-d6b62b964b1d"), 39, "thirty-nine" },
                    { new Guid("01046733-a412-4c24-815c-2a68dee2cf20"), 30, "thirty" },
                    { new Guid("01d35dd1-71d8-4a14-99ce-a48ecbebf689"), 61, "sixty-one" },
                    { new Guid("0255269d-6498-43d9-8aae-3ab1110fd028"), 52, "fifty-two" },
                    { new Guid("02f6a04b-8ed7-4b05-9a3d-564b81edf7ed"), 6, "six" },
                    { new Guid("03e8727d-68ae-425c-990e-9d4896b4d451"), 42, "forty-two" },
                    { new Guid("04b42253-9ef9-48ee-acc8-5734fde1ff70"), 11, "eleven" },
                    { new Guid("08111950-4e88-467a-8c28-3dc848d78f8e"), 32, "thirty-two" },
                    { new Guid("0868f9fa-0038-4292-9bf1-d924519310c4"), 70, "seventy" },
                    { new Guid("0b078125-628b-4352-8e89-620c85f2b03d"), 24, "twenty-four" },
                    { new Guid("0e1bffde-e29f-451e-ab86-a289fb036fc3"), 86, "eighty-six" },
                    { new Guid("0f3c2978-043e-471c-926c-f1e57b56a810"), 80, "eighty" },
                    { new Guid("1107d8c7-61e4-45f2-a17f-3186852a51fd"), 29, "twenty-nine" },
                    { new Guid("11c740ab-5b7b-49b9-9211-fe0befb8a4aa"), 26, "twenty-six" },
                    { new Guid("11caac34-9fa4-469d-aa02-549edcfe39d6"), 65, "sixty-five" },
                    { new Guid("135736d0-8177-4328-9ca3-86712e973f0e"), 36, "thirty-six" },
                    { new Guid("15353a5d-f508-4248-b5a8-abf3b01932d1"), 16, "sixteen" },
                    { new Guid("1b01ce84-b2f1-442d-8a14-52f598653d43"), 46, "forty-six" },
                    { new Guid("1dce1bfe-29f7-4617-aa28-763e0ed98037"), 66, "sixty-six" },
                    { new Guid("1eaab961-feb8-4a6a-a23f-2b77a577b3f6"), 8, "eight" },
                    { new Guid("1f82d796-520c-4527-98ec-84ea883d5b1a"), 95, "ninety-five" },
                    { new Guid("22052436-99b3-49d0-8e70-1a84c654ed0e"), 83, "eighty-three" },
                    { new Guid("2454aea7-4a69-49ac-9433-629d7c881573"), 50, "fifty" },
                    { new Guid("25fc39d2-0ac8-41b0-9a64-f786282252d0"), 53, "fifty-three" },
                    { new Guid("269baed0-35f9-4609-982e-3fe12aa9ab53"), 48, "forty-eight" },
                    { new Guid("2757998a-de32-437a-892c-d9415f071ef3"), 69, "sixty-nine" },
                    { new Guid("2b18ad8e-9f6c-450b-847e-0aafb398dd2a"), 73, "seventy-three" },
                    { new Guid("34c74263-c160-4960-bc8b-0903d225481c"), 55, "fifty-five" },
                    { new Guid("35cf48bb-6018-4cd8-83c6-618b678a3c80"), 40, "forty" },
                    { new Guid("37626cac-43ea-49fa-85d4-9d4dd4c376d8"), 89, "eighty-nine" },
                    { new Guid("39b0f634-0de8-43db-8d50-650109f1341d"), 3, "three" },
                    { new Guid("3a905451-6596-4c9a-ae48-0b2e4ca6bac9"), 78, "seventy-eight" },
                    { new Guid("3e70c5de-cf66-415c-a09e-c968d4f3a9a5"), 68, "sixty-eight" },
                    { new Guid("3ee0734b-2893-4018-8727-bf42ef307120"), 97, "ninety-seven" },
                    { new Guid("3f417c1d-b53c-42a1-8fa0-8d7d5733570f"), 23, "twenty-three" },
                    { new Guid("40ef9508-9b6d-480f-8b8f-ee0f9a85f252"), 47, "forty-seven" },
                    { new Guid("421029dc-7a27-436d-ab00-c235ac380e4a"), 21, "twenty-one" },
                    { new Guid("42cff7d8-51c4-4aed-b4c9-9da6829b8bf2"), 5, "five" },
                    { new Guid("4860b06c-6dd7-4f6a-9ca1-0d4f9a007576"), 67, "sixty-seven" },
                    { new Guid("4a0da1f4-b538-4227-93b5-c631d9de651a"), 10, "ten" },
                    { new Guid("4cf2f685-ac7f-4bc3-8939-9b594cbde698"), 9, "nine" },
                    { new Guid("4dcbc5ff-80c6-469e-b307-007194ceb16d"), 82, "eighty-two" },
                    { new Guid("4ebfa152-e905-4f41-9378-3e8620115ba3"), 81, "eighty-one" },
                    { new Guid("4f0bfbac-3c80-425c-8b4f-857a6c8fecd1"), 33, "thirty-three" },
                    { new Guid("553b5338-715f-4950-afc8-e7954e39c5d3"), 96, "ninety-six" },
                    { new Guid("55e71bb3-b2cb-43d1-9ee8-f22ccc38f548"), 34, "thirty-four" },
                    { new Guid("572f7ff0-fedd-489b-92d7-dc0bc227463c"), 98, "ninety-eight" },
                    { new Guid("5c91a43f-8cee-482f-bf73-a4a7c4f62ec8"), 43, "forty-three" },
                    { new Guid("5d9b8aeb-e17e-4ba9-a373-753332c93ffc"), 87, "eighty-seven" },
                    { new Guid("60692ba5-80f6-4940-aceb-962e398ea161"), 37, "thirty-seven" },
                    { new Guid("61281bcd-4e84-4a5d-a002-394a4b3cf303"), 94, "ninety-four" },
                    { new Guid("617cae68-ce4d-4d69-bcbd-d9618d6fc449"), 76, "seventy-six" },
                    { new Guid("639a3054-40bf-4c07-adb1-73269f1e021d"), 59, "fifty-nine" },
                    { new Guid("669879fa-9081-4c08-b54e-64bce8ab0f79"), 72, "seventy-two" },
                    { new Guid("684fd478-6f63-4ee2-bd45-9c11fb1cc736"), 19, "nineteen" },
                    { new Guid("68c7c1d4-b663-4cb7-8725-97c3d3d94bc2"), 85, "eighty-five" },
                    { new Guid("6b09d505-80c6-4186-aa53-710320abb10f"), 1, "one" },
                    { new Guid("729ba1f8-52b1-4b6a-bf38-9cf51996c0e9"), 28, "twenty-eight" },
                    { new Guid("78211122-72b5-4ca0-a42b-a4801ef54db3"), 45, "forty-five" },
                    { new Guid("80060c39-93d8-491e-be01-f2953dad6789"), 60, "sixty" },
                    { new Guid("834314e8-14bb-41fa-acb5-73afa141c4cf"), 18, "eighteen" },
                    { new Guid("83fa51b9-5bcb-463d-9db4-9e1a5da28ef5"), 71, "seventy-one" },
                    { new Guid("8435914c-28f3-4df1-b561-0d99011cb85c"), 75, "seventy-five" },
                    { new Guid("8551febd-fd92-4c57-9e19-1f3d0ab86712"), 93, "ninety-three" },
                    { new Guid("8589ecea-2987-4ea1-a301-f5b2541b5e76"), 84, "eighty-four" },
                    { new Guid("8757fac7-89fd-4032-a444-1f2cd87718cd"), 57, "fifty-seven" },
                    { new Guid("896e0ff6-667a-4128-ba04-f26e98f5fc75"), 20, "twenty" },
                    { new Guid("8a498a60-30a0-4f79-b777-137a2a0b691c"), 79, "seventy-nine" },
                    { new Guid("8fba2cb3-307e-407d-8eec-f80aebb2bfcd"), 17, "seventeen" },
                    { new Guid("93dc9095-495f-4b6e-8039-066890870a0c"), 62, "sixty-two" },
                    { new Guid("94de0b1c-52b5-4085-98b7-653e62e1f975"), 7, "seven" },
                    { new Guid("9a29c102-a93d-47a9-98d8-6336b1ff17ff"), 27, "twenty-seven" },
                    { new Guid("a6fa3fce-9967-4a97-b11d-331c1b1e9dc4"), 63, "sixty-three" },
                    { new Guid("ac0950de-887f-4435-9f7d-1ef57956556b"), 54, "fifty-four" },
                    { new Guid("b8b02125-232f-4b11-b7e0-591b0403aa9b"), 4, "four" },
                    { new Guid("b917daf0-33ea-41ba-abd5-ecff4d5b0d31"), 64, "sixty-four" },
                    { new Guid("ba67dc5b-4d46-4594-bd01-7c93c7f75426"), 15, "fifteen" },
                    { new Guid("c046da85-260e-4957-9386-450f8e61559c"), 38, "thirty-eight" },
                    { new Guid("c07f3eec-b8d6-4a1e-9718-af39c6c13ae8"), 92, "ninety-two" },
                    { new Guid("ca09d016-14c5-453a-8bf4-bf9740206cdf"), 49, "forty-nine" },
                    { new Guid("cf423234-f663-4210-aaa9-b0aae93ba656"), 14, "fourteen" },
                    { new Guid("cfc00c0a-8caa-47fc-bc82-3538ed003c37"), 58, "fifty-eight" },
                    { new Guid("d0e65ed5-a4eb-49dc-8252-efb269fb3b9b"), 12, "twelve" },
                    { new Guid("d4718aef-13ba-4e92-a194-afce949975e9"), 41, "forty-one" },
                    { new Guid("d5df26d6-7436-4536-8242-0140182dc075"), 25, "twenty-five" },
                    { new Guid("da00dbd2-04af-479a-9c8b-6bce0fc10e08"), 88, "eighty-eight" },
                    { new Guid("dc6bf804-430c-44c3-86eb-5fa260394800"), 51, "fifty-one" },
                    { new Guid("de13aaf7-26de-49c9-a85d-30f75b33b31f"), 22, "twenty-two" },
                    { new Guid("df39a80b-4cbe-4b43-b577-7d0b588eac5e"), 74, "seventy-four" },
                    { new Guid("e0a48aaa-2a6e-42c9-9b18-2eed32bbcac3"), 99, "ninety-nine" },
                    { new Guid("e0b9229e-af33-415a-91e3-3efdca665c19"), 90, "ninety" },
                    { new Guid("ec005fcd-89a1-40f4-a4ba-de08e226ee55"), 35, "thirty-five" },
                    { new Guid("ec6fbb46-bfef-490a-afd0-f677b303c0f3"), 91, "ninety-one" },
                    { new Guid("eeda83b1-4243-419e-95c8-4a652616019f"), 31, "thirty-one" },
                    { new Guid("f1f0fe79-ec14-4513-9d70-c12d29f75f28"), 13, "thirteen" },
                    { new Guid("f2ec932a-5cbc-47d6-b194-6f351f465a93"), 44, "forty-four" },
                    { new Guid("f45f2ec4-6080-4a1a-a401-1e7da8d83138"), 56, "fifty-six" },
                    { new Guid("f948b80e-cb25-47d3-8f6f-0dc6461dbdd8"), 77, "seventy-seven" },
                    { new Guid("fa968d49-9ca7-45d0-aff8-9d89ed0772b8"), 2, "two" }
                });

            migrationBuilder.InsertData(
                schema: "vocabulary",
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

            migrationBuilder.InsertData(
                schema: "vocabulary",
                table: "Nouns",
                columns: new[] { "Id", "PluralForm", "Text", "Type" },
                values: new object[,]
                {
                    { new Guid("02410ac9-865a-4ef4-bf35-a97c572c775d"), "parentheses", "parenthesis", 1 },
                    { new Guid("055014c0-4580-4f66-8a26-909c81ada9ab"), "sheep", "sheep", 1 },
                    { new Guid("055fe9d1-edec-4398-9880-6f781b2c7ec8"), "accountants", "accountant", 3 },
                    { new Guid("06b41465-0054-43e0-a604-eeaedd96d003"), "names", "name", 2 },
                    { new Guid("0728eca1-2889-4ed6-9a2b-cf36e0cab016"), "homes", "home", 2 },
                    { new Guid("080b75d8-eed4-41b8-b504-7e4e80fdc07b"), "faces", "face", 2 },
                    { new Guid("0a5a1b84-4e5f-4491-a81b-1023baa21587"), "moose", "moose", 1 },
                    { new Guid("0a97d081-940f-4ac2-be45-5415f901bfd3"), "formulae", "formula", 1 },
                    { new Guid("0af3f8c9-04b7-4826-98f3-2eee9f18bf54"), "fezzes", "fez", 1 },
                    { new Guid("0bb3c129-831b-4360-9405-c86ba88b2bd1"), "species", "species", 1 },
                    { new Guid("0d9d9c1c-c3f2-4696-80a6-125702b5ed5d"), "models", "model", 3 },
                    { new Guid("0f1d1568-8748-434e-b393-13f3e76a890b"), "oases", "oasis", 1 },
                    { new Guid("1031bfa3-afaa-4f8d-ba5c-67c4bd76e090"), "quizzes", "quiz", 1 },
                    { new Guid("10621b0a-3611-4bb9-a957-f8c19dec236a"), "powers", "power", 2 },
                    { new Guid("10a584ce-08d0-45a3-a2c1-60c0ed418ba5"), "referenda", "referendum", 1 },
                    { new Guid("12bd1acd-141f-4248-8db5-e4a598317e88"), "dice", "die", 1 },
                    { new Guid("133ff439-dc78-4724-aca4-ac6127199e15"), "cleaners", "cleaner", 3 },
                    { new Guid("1352b302-875f-4c0e-b030-d2d00f104124"), "guys", "guy", 2 },
                    { new Guid("14879bb3-f4f6-49eb-868c-756ec9b5eb75"), "apices", "apex", 1 },
                    { new Guid("156b01b8-5c94-4f6d-83fb-5aadea4df9c1"), "groups", "group", 2 },
                    { new Guid("162e288a-d060-41cd-8a6b-a42c16baff0f"), "receptionists", "receptionist", 3 },
                    { new Guid("170b8259-2556-4148-8cba-29b74f092b7a"), "lawyers", "lawyer", 3 },
                    { new Guid("1a7c848f-23df-4a78-9922-5600755ac939"), "memoranda", "memorandum", 1 },
                    { new Guid("1c0e049c-1e56-4982-b6b9-30770daff4c7"), "lecturers", "lecturer", 3 },
                    { new Guid("1e29bc31-f060-4bcc-9212-401f7536270d"), "drivers", "driver", 3 },
                    { new Guid("1e4d832a-f94b-4fb5-87da-45585523db2d"), "countries", "country", 2 },
                    { new Guid("1ec16fa1-e22e-460f-992f-ed1a5f6e6cdf"), "selves", "self", 1 },
                    { new Guid("1f9d67de-d6b1-430a-91f5-ca59f2fefef0"), "vortices", "vortex", 1 },
                    { new Guid("22a1741d-4999-4b9c-b926-5a6e8f5ccae8"), "fathers", "father", 2 },
                    { new Guid("23a9befc-3bcb-4ba2-b10c-9d01815df55f"), "radii", "radius", 1 },
                    { new Guid("23b223ea-134a-4d78-8cd0-375fe647016a"), "curricula", "curriculum", 1 },
                    { new Guid("24f499a2-6b44-4fb5-81d4-53b47a2bd2a2"), "informatia", "information", 2 },
                    { new Guid("2511f5cf-0f09-4d4d-b5ad-73278fa65b5b"), "sides", "side", 2 },
                    { new Guid("2700812f-632a-4717-a69b-5ea51b49e315"), "gardeners", "gardener", 3 },
                    { new Guid("2788328f-fd07-4825-826b-dd5b84989b9e"), "antitheses", "antithesis", 1 },
                    { new Guid("29fb9af0-59cd-45ef-b294-d6ef961d5f4d"), "oxen", "ox", 1 },
                    { new Guid("2b64ff6f-e4fa-4cf7-8dc4-b58532d79dec"), "geese", "goose", 1 },
                    { new Guid("2bd613c3-bfc4-4922-beb2-007513e15818"), "journalists", "journalist", 3 },
                    { new Guid("2c2b0889-79f3-4f76-87db-3a5cc02011fd"), "data", "datum", 1 },
                    { new Guid("2def382d-2002-4e39-ad5d-68a4331c992a"), "translators", "translator", 3 },
                    { new Guid("2f1a8f23-220b-4c76-911b-69cddd22d6af"), "kids", "kid", 2 },
                    { new Guid("2fc46f1b-a7bc-45ec-a7b4-2b5cb34e7166"), "schools", "school", 2 },
                    { new Guid("31dd7787-634a-43d7-8f08-08ae039e3489"), "hours", "hour", 2 },
                    { new Guid("31f59a36-25e5-4e93-87f8-c83e040429a2"), "educatia", "education", 2 },
                    { new Guid("3212ad08-807e-4c7d-9a38-65d76b3b8dc7"), "phenomena", "phenomenon", 1 },
                    { new Guid("34f7eb99-ed14-4e47-8720-ad048cfc29eb"), "things", "thing", 2 },
                    { new Guid("35926da0-252d-4b68-ba64-7e8a271e72a9"), "alumni", "alumnus", 1 },
                    { new Guid("377325f0-561e-4ae0-a8a5-451d7449e9c0"), "pilots", "pilot", 3 },
                    { new Guid("37e39b47-4899-4716-8ac8-484c2137d2b9"), "beaux", "beau", 1 },
                    { new Guid("3a40539b-f6f7-4af5-97b9-797130ab9e3e"), "dwarves", "dwarf", 1 },
                    { new Guid("3b73c619-56f1-4be5-b426-921a4b1a9de3"), "numbers", "number", 2 },
                    { new Guid("3c3eab92-6fb3-4525-a5fd-20dcb8b7ea7b"), "dentists", "dentist", 3 },
                    { new Guid("3cf788be-e267-4d66-9905-313f9f49b1f8"), "stories", "story", 2 },
                    { new Guid("3e84413f-4522-4cdd-8e01-d868a1d1495e"), "addenda", "addendum", 1 },
                    { new Guid("3f3d7406-8d08-4d59-86ba-fa503f866b40"), "autumns", "autumn", 5 },
                    { new Guid("3f3ed318-2891-4c78-924b-70ba61c288d6"), "grouse", "grouse", 1 },
                    { new Guid("40ac69ca-7f16-4830-a6b1-d3f50ab7ca6a"), "criteria", "criterion", 1 },
                    { new Guid("43467274-8382-47cf-93fc-a2ee8cd99915"), "problems", "problem", 2 },
                    { new Guid("4350d8a4-0e75-48cf-95aa-ff59dc6fad2d"), "levels", "level", 2 },
                    { new Guid("435360ae-25aa-4717-b0cc-83debd355db6"), "couriers", "courier", 3 },
                    { new Guid("43a676a6-e325-411a-b9bc-f9058f20eab1"), "plumbers", "plumber", 3 },
                    { new Guid("4476956e-2d7e-47ae-8ec9-73d1a091c0c8"), "media", "medium", 1 },
                    { new Guid("4504cf9a-e14c-4c5a-92a2-5be20df566a7"), "secretaries", "secretary", 3 },
                    { new Guid("45aa172e-1ab9-4747-a809-c4060a72c12b"), "doors", "door", 2 },
                    { new Guid("46528ce7-8f52-47ed-b39e-bdee68bbbad1"), "waters", "water", 2 },
                    { new Guid("4687b7e4-885f-4703-905c-9a6f2baa2326"), "wars", "war", 2 },
                    { new Guid("472ae0b3-27d9-4488-998d-af50d84fde9d"), "lice", "louse", 1 },
                    { new Guid("481c13ac-c43e-4fd3-ac17-3ba3c208fc96"), "authors", "author", 3 },
                    { new Guid("4869c0cb-2bcd-4b69-b0ef-4821a4c5f8c2"), "genera", "genus", 1 },
                    { new Guid("488678df-1b0c-4049-99b4-2e6b77b64b56"), "symposia", "symposium", 1 },
                    { new Guid("4be04cba-73f9-4ca9-ae4e-a20074556716"), "bureaux", "bureau", 1 },
                    { new Guid("4c0835ec-a42a-467b-a204-2399339ff5f5"), "questia", "question", 2 },
                    { new Guid("4e101834-2d9c-4487-97c3-19a564cc49b5"), "bodies", "body", 2 },
                    { new Guid("4faa8802-2eb9-4267-90a9-da08e35c4d52"), "weeks", "week", 2 },
                    { new Guid("5059544c-cad0-43c4-bfab-712945cda6a3"), "jobs", "job", 2 },
                    { new Guid("50f9b3ff-063c-445a-91e9-994615f6a4a0"), "pharmacists", "pharmacist", 3 },
                    { new Guid("515ced18-6e2d-4360-9e4d-d9a24431d6e9"), "histories", "history", 2 },
                    { new Guid("5161f011-b8df-4e4c-909c-44fb8d4e80c1"), "kinds", "kind", 2 },
                    { new Guid("51907a8c-acd1-4176-8498-dcd6eed2a2d1"), "arts", "art", 2 },
                    { new Guid("528b4e51-9348-4f1c-bd4a-559ab40062e5"), "times", "time", 2 },
                    { new Guid("52a39a54-ca47-4548-8f25-f7b58eda97f6"), "bakers", "baker", 3 },
                    { new Guid("532cc556-74b3-445a-8032-5d931a579c6f"), "aircraft", "aircraft", 1 },
                    { new Guid("56816b39-edf8-4421-b9d3-75d8e05f5d72"), "students", "student", 2 },
                    { new Guid("57372e55-b9c9-47ab-8364-58f4ac1690f3"), "dustmans", "dustman", 3 },
                    { new Guid("57f5f0e2-104a-4fd5-9ab0-f8eabe35bd35"), "afternoons", "afternoon", 4 },
                    { new Guid("58f100cc-6dc3-411a-941d-af6ad4a13180"), "actors", "actor", 3 },
                    { new Guid("5c17986c-b2e5-48fe-9ba2-1429d1f9d4f8"), "people", "person", 1 },
                    { new Guid("5d260a19-82f8-4ad1-81e1-7b0e3ae7d32d"), "cars", "car", 2 },
                    { new Guid("608074f5-faf1-436f-ac26-872c8266faad"), "airs", "air", 2 },
                    { new Guid("61ae4477-73f5-49e4-a7f4-68a3279b709c"), "halves", "half", 1 },
                    { new Guid("627b4a70-44eb-4428-8cea-6bfeb92a3d4d"), "parents", "parent", 2 },
                    { new Guid("63e88cde-d7c4-44ed-8428-cfb3fbed65e3"), "members", "member", 2 },
                    { new Guid("65638e34-2354-44e2-8348-36a739bf4922"), "hands", "hand", 2 },
                    { new Guid("67060766-de81-4cd7-b2cc-34d3f7ebf0b9"), "cities", "city", 2 },
                    { new Guid("67907bc9-6be9-4e8a-a017-b1a1411e3d10"), "bases", "basis", 1 },
                    { new Guid("685bc24c-dfa0-4818-a431-65091b5009d0"), "evenings", "evening", 4 },
                    { new Guid("6954d389-8c5e-4129-8352-267dad1ef7e1"), "chefs", "chef", 3 },
                    { new Guid("69d77d54-8dc5-43c6-b4cc-a1fc81790ee4"), "codices", "codex", 1 },
                    { new Guid("69f8049d-e810-4b0f-923e-b66c28cbc595"), "ends", "end", 2 },
                    { new Guid("6c68af73-e165-42c1-8712-fc6321b85b3a"), "bison", "bison", 1 },
                    { new Guid("6c7ed5f2-cc74-4b98-b44b-9c987fc57baa"), "antennae", "antenna", 1 },
                    { new Guid("6cac2ba2-42c6-452e-8851-2e91113c08a2"), "strata", "stratum", 1 },
                    { new Guid("6cc9a7a3-cb0b-4171-9ce1-35a9ddcaca3e"), "ideas", "idea", 2 },
                    { new Guid("6d2e41ae-33dd-45b5-ac89-94b94370dff1"), "teachers", "teacher", 3 },
                    { new Guid("6d3db140-c060-49c0-aa80-83269a7c1f92"), "diagnoses", "diagnosis", 1 },
                    { new Guid("6dea7038-8c39-460a-837a-e68debfe610c"), "judges", "judge", 3 },
                    { new Guid("6e7fa7ee-1bfe-4184-9de5-a49983288056"), "parts", "part", 2 },
                    { new Guid("6eea2102-f1ca-43a4-80d4-9efc03cbc9a9"), "axes", "axis", 1 },
                    { new Guid("6ef22f13-96f9-4f6a-a828-789b7f8771b6"), "deer", "deer", 1 },
                    { new Guid("718034f2-5601-4184-b268-f708e2dc7d16"), "houses", "house", 2 },
                    { new Guid("72d5ad38-35d4-4603-a33f-c96e6c7be57e"), "worlds", "world", 2 },
                    { new Guid("7656bd9b-e1a8-4eae-b1fd-9cab3efcac7c"), "tailors", "tailor", 3 },
                    { new Guid("76ebb3e6-6b35-4211-a942-c970f3a5ae70"), "farmers", "farmer", 3 },
                    { new Guid("7726b965-9229-433e-b6c7-774425b641f7"), "bacilli", "bacillus", 1 },
                    { new Guid("779295d4-cf20-4cbb-9a38-7572c641f5ba"), "lifeguards", "lifeguard", 3 },
                    { new Guid("78123adf-756d-419b-8290-80e4377bbfcb"), "firemans", "fireman", 3 },
                    { new Guid("78b9c7b3-12aa-4f6a-95ba-81a2ed3d25bb"), "carpenters", "carpenter", 3 },
                    { new Guid("7ab1006d-c5ee-4d4d-b57c-2ca6a38fa580"), "games", "game", 2 },
                    { new Guid("7bad199d-a87f-4325-94b4-1351ef7365bc"), "moneys", "money", 2 },
                    { new Guid("7ec7af1c-2f7b-4c81-b003-9a2c42098c3e"), "wharves", "wharf", 1 },
                    { new Guid("7ed87e69-2afb-4a52-b2e0-bb229e18c0e5"), "businesses", "business", 2 },
                    { new Guid("7f1c580c-87ec-4e11-bef0-c5e1931272a8"), "ways", "way", 2 },
                    { new Guid("83566a4c-90ae-40e7-a2c8-9aa064b03919"), "moments", "moment", 2 },
                    { new Guid("844263ed-8a64-4537-b02c-c409d8e234ca"), "foci", "focus", 1 },
                    { new Guid("844a8806-4cb2-42e8-a970-fb6ac9411381"), "vitae", "vita", 1 },
                    { new Guid("86cd6d6d-2cfd-44ca-ad31-14c3b2ae5a42"), "doctors", "doctor", 3 },
                    { new Guid("86f42f23-b7ed-44f3-aace-5cc3723617be"), "postmans", "postman", 3 },
                    { new Guid("8ab835ec-4f1b-4b7a-ab04-7097fc541f3b"), "issues", "issue", 2 },
                    { new Guid("8cfd2035-9431-4297-8f32-be0c1e26e31d"), "heads", "head", 2 },
                    { new Guid("8d84d2ed-0381-4c20-b3ed-3e86116ff176"), "errata", "erratum", 1 },
                    { new Guid("8eee8b6d-3289-4f18-b5fa-35e6201bc8e2"), "laws", "law", 2 },
                    { new Guid("8effd891-9f66-44d6-b77c-8d9ff446b6ab"), "teams", "team", 2 },
                    { new Guid("8f97c762-bbd8-4be9-9521-78a9c3267629"), "designers", "designer", 3 },
                    { new Guid("8fb5565a-862c-4d5f-83fe-240826140e50"), "waitresses", "waitress", 3 },
                    { new Guid("8fb6b0b2-e8c0-47b9-a5e7-b10f02d203cf"), "nights", "night", 4 },
                    { new Guid("9285bde5-981e-4aeb-89a2-40cb0aeceb1c"), "librarians", "librarian", 3 },
                    { new Guid("92e6c1bf-1c1b-4413-8c03-77487b2d119a"), "states", "state", 2 },
                    { new Guid("94605695-8060-4643-a2eb-e87795a377e0"), "newsreaders", "newsreader", 3 },
                    { new Guid("94ddcf5a-c8f1-4997-aa89-a396122543dd"), "cases", "case", 2 },
                    { new Guid("961fb472-9232-467d-87e5-1c03b10ea4c2"), "girls", "girl", 2 },
                    { new Guid("9e719618-3957-45f5-a579-84db93d75679"), "swine", "swine", 1 },
                    { new Guid("9e93f191-4112-49ee-8a8a-beb6efb5f98c"), "chateaux", "chateau", 1 },
                    { new Guid("9ec6c1d6-14f0-496a-85f6-649c2b1942db"), "theses", "thesis", 1 },
                    { new Guid("a091136a-6227-48e4-a6a1-c8070d5bc610"), "lines", "line", 2 },
                    { new Guid("a135fa3a-91e0-474e-9cd4-7d1cf1ea056a"), "mechanics", "mechanic", 3 },
                    { new Guid("a139edc3-a54b-48a1-a41f-e26e49406068"), "concerti", "concerto", 1 },
                    { new Guid("a20cd4b1-626b-4d55-9636-c5abe59388c5"), "hypotheses", "hypothesis", 1 },
                    { new Guid("a361de63-7e01-4833-bc76-af3688ba0861"), "larvae", "larva", 1 },
                    { new Guid("a380b3cc-c753-4a76-a744-ad7783354e76"), "weekends", "weekend", 2 },
                    { new Guid("a4d2cb74-9c23-4629-9c3b-fa5dd7d8cb0f"), "men", "man", 1 },
                    { new Guid("a4e594bb-3ef2-45ea-98a4-5d7294a2cf3c"), "florists", "florist", 3 },
                    { new Guid("aa3c70eb-c598-4ba3-9e60-9d10596b5bda"), "salmon", "salmon", 1 },
                    { new Guid("aa8249a7-eb2d-4520-97eb-3824ee01d690"), "butchers", "butcher", 3 },
                    { new Guid("aa9aa506-df3b-4d94-8400-a15da489cdc3"), "programs", "program", 2 },
                    { new Guid("aae9ba77-77e8-4723-935e-1f6d9e8d7d38"), "engineers", "engineer", 3 },
                    { new Guid("aba004eb-6188-4e94-93e6-24a77bfda0e7"), "electricians", "electrician", 3 },
                    { new Guid("ac376ab4-ca67-4015-bb32-4937b2013f4c"), "syllabi", "syllabus", 1 },
                    { new Guid("acaa7f8a-90a3-4b37-ae93-ea31a8a01a3c"), "facts", "fact", 2 },
                    { new Guid("aeeaa146-827d-467c-9d5b-770d99d1b8cb"), "services", "service", 2 },
                    { new Guid("b106231d-6747-42de-b599-fc3bbd88b5b6"), "tableaux", "tableau", 1 },
                    { new Guid("b1a53f9d-910c-44e8-83c7-10267cfcf643"), "summers", "summer", 5 },
                    { new Guid("b1c21999-f653-4c3b-ac25-4f978a2e03c6"), "vertebrae", "vertebra", 1 },
                    { new Guid("b2276b1b-4e10-4361-9098-b9119a6a30a7"), "thieves", "thief", 1 },
                    { new Guid("b29a2e94-bdd0-48dc-8c3c-bf6f1f7cf546"), "matrices", "matrix", 1 },
                    { new Guid("b33cca0d-89e3-41fc-a5a3-b585f4f2f037"), "soldiers", "soldier", 3 },
                    { new Guid("b3fffae9-2c61-43de-8f90-6f351f1e0bd5"), "points", "point", 2 },
                    { new Guid("b49cabb5-b209-48d9-aad0-6cd1647e905f"), "actresses", "actress", 3 },
                    { new Guid("b519ee27-47d8-486a-a0e4-3dfba526ca40"), "parties", "party", 2 },
                    { new Guid("b779d65e-e66f-4320-9a5b-b55f7d54d4a8"), "nebulae", "nebula", 1 },
                    { new Guid("b9ac7157-9847-465f-b288-26a5f471519c"), "lives", "life", 2 },
                    { new Guid("b9e13b57-0fd5-40ba-9f8c-0afdab9b4e1b"), "researches", "research", 2 },
                    { new Guid("bd0a481c-f9a2-419c-99b7-5f8352f17541"), "politicians", "politician", 3 },
                    { new Guid("bd8fd622-e592-4b3a-bb17-d9606b7aa5c2"), "libretti", "libretto", 1 },
                    { new Guid("bdc6e7dd-ece8-4ef8-b06b-dac3cb09cabc"), "stimuli", "stimulus", 1 },
                    { new Guid("be97eb44-72bc-4ead-ad82-4568cba67059"), "children", "child", 1 },
                    { new Guid("bed75909-6f45-4a8c-a7cb-5dca3fc61adc"), "photographers", "photographer", 3 },
                    { new Guid("c06cd075-037a-466e-9180-2af65efeaeb1"), "governments", "government", 2 },
                    { new Guid("c0fcab94-33c9-41fe-9788-44561ac423a9"), "springs", "spring", 5 },
                    { new Guid("c135498f-f97c-457e-9a3c-d6e23dc578dd"), "bacteria", "bacterium", 1 },
                    { new Guid("c5217814-da8d-497c-b7c5-12c12575d465"), "systems", "system", 2 },
                    { new Guid("c557a8d7-70f2-4752-914a-40cbd5c7f356"), "phyla", "phylum", 1 },
                    { new Guid("c559c60d-28c9-4e51-b639-f8db426dd58c"), "healths", "health", 2 },
                    { new Guid("c570f1e7-090c-462f-aa6a-361b0109f561"), "teeth", "tooth", 1 },
                    { new Guid("c5bf888a-a578-4267-9301-a819269efdf5"), "nuclei", "nucleus", 1 },
                    { new Guid("c5c45345-c601-4978-9808-06ad8b77fb62"), "astronomers", "astronomer", 3 },
                    { new Guid("c5ef7a7b-3832-493e-8c53-8d6bb05609e7"), "days", "day", 2 },
                    { new Guid("c622cb5d-4f34-4c81-aa41-752a0c55a514"), "minutes", "minute", 2 },
                    { new Guid("c6f4bb5e-4653-4edf-bc00-63fea7d5276b"), "wolves", "wolf", 1 },
                    { new Guid("c74d197c-7d53-4385-a56d-68a8701b2a7c"), "synopses", "synopsis", 1 },
                    { new Guid("c9d8d5e8-85ce-4254-bd81-813e367c7763"), "graffiti", "graffito", 1 },
                    { new Guid("cba67a01-8895-4215-bc52-3cdf566a6fa5"), "nurses", "nurse", 3 },
                    { new Guid("cbb70e24-54a7-4984-bb40-9280fe3a4dc1"), "crises", "crisis", 1 },
                    { new Guid("cc13b733-19bc-4440-ba0d-fd9cb1b2f755"), "results", "result", 2 },
                    { new Guid("ccbd1a54-e85a-45ca-a125-69f9b85a04d1"), "buses", "bus", 3 },
                    { new Guid("ccc3e204-80c9-4104-a0a1-3cd421c3db78"), "mothers", "mother", 2 },
                    { new Guid("ccdaee0f-79cf-43da-a34b-4b4336ab5f32"), "mornings", "morning", 4 },
                    { new Guid("cd46c903-f640-4844-ad4c-e99d35ea7b5a"), "forces", "force", 2 },
                    { new Guid("ce173151-a957-48fb-87d7-77ef65ae422d"), "presidents", "president", 2 },
                    { new Guid("cf84efdc-aa12-48c8-bd99-d6b41236dabd"), "analyses", "analysis", 1 },
                    { new Guid("d310565f-0c1f-40d9-9166-80b404ec12fc"), "families", "family", 2 },
                    { new Guid("d3b0da8d-49aa-4f45-9a04-da1629643f58"), "wives", "wife", 1 },
                    { new Guid("d3c30d3c-75b2-4fe5-ba31-18f309f3c587"), "indices", "index", 1 },
                    { new Guid("d475bfd3-5bc3-4185-8dbb-269a26ae50f3"), "offices", "office", 2 },
                    { new Guid("d6416b77-e82b-4d3d-ae47-2e828bf4df32"), "feet", "foot", 1 },
                    { new Guid("d6adf7fa-98cd-4800-9594-dc270d7174cc"), "loci", "locus", 1 },
                    { new Guid("d6f1d49a-b4fb-45f1-bdf6-1924cb75add4"), "scientists", "scientist", 3 },
                    { new Guid("d7870492-791a-4703-b988-de79eb5fd243"), "scarves", "scarf", 1 },
                    { new Guid("d810593c-5817-45f6-9292-fbe886c17c76"), "communities", "community", 2 },
                    { new Guid("d8d16893-49fd-4bad-b9f0-a769c05fafc8"), "loaves", "loaf", 1 },
                    { new Guid("dc5f756e-a1dd-409c-9e2d-8e98ebdbe791"), "waiters", "waiter", 3 },
                    { new Guid("dc91b3a0-23aa-4fd0-88e7-85ea8027ad8c"), "areas", "area", 2 },
                    { new Guid("dce4c333-d24b-4cc6-9297-873df89a2d21"), "policewomans", "policewoman", 3 },
                    { new Guid("df480d98-db6d-4700-a3ff-05f896ef7dc7"), "appendices", "appendix", 1 },
                    { new Guid("e094c20b-6708-44fb-b11a-a4ce665366d2"), "reasa", "reason", 2 },
                    { new Guid("e4a9298b-58a6-4ae6-98d7-531dfc0e4558"), "companies", "company", 2 },
                    { new Guid("e51bd39b-d01e-4d64-82b5-74820f7f8298"), "vertices", "vertex", 1 },
                    { new Guid("eba9e2d1-440b-49b8-8861-0f9bc7cf668c"), "months", "month", 2 },
                    { new Guid("ec72ed55-7737-4a17-940c-206cb755300f"), "mice", "mouse", 1 },
                    { new Guid("ed701365-6da1-46fe-bdfd-a5ea549db565"), "painters", "painter", 3 },
                    { new Guid("eda699d8-8c96-46a3-8479-8df3a0d85df2"), "corpora", "corpus", 1 },
                    { new Guid("ef0a61de-fcd0-4d29-9c4f-f728710a3833"), "ellipses", "ellipsis", 1 },
                    { new Guid("ef44000a-07c9-4bb5-91ff-af40b26a9169"), "alumnae", "alumna", 1 },
                    { new Guid("ef872690-a08c-4498-9a4c-f94c22cf80cd"), "women", "woman", 1 },
                    { new Guid("ef9db620-dd0b-4f7a-8f7c-5feef834d084"), "hairdressers", "hairdresser", 3 },
                    { new Guid("f0b5c633-1f1b-4f36-ba29-89de161f147b"), "rooms", "room", 2 },
                    { new Guid("f0e8d288-1e01-454e-a8d7-60aedaa503cc"), "ova", "ovum", 1 },
                    { new Guid("f1075b37-436f-406e-97ca-80df599e95ff"), "winters", "winter", 5 },
                    { new Guid("f129f9e5-3bf3-4b65-9a4d-51a6cc59ed97"), "minutiae", "minutia", 1 },
                    { new Guid("f22b22cb-6507-45b3-82a7-7c6faec7919b"), "hooves", "hoof", 1 },
                    { new Guid("f246d643-818c-46a0-82d2-d3d5ba9f45be"), "changes", "change", 2 },
                    { new Guid("f2d72547-2049-42c6-ab5a-174bec4f0cf6"), "policemans", "policeman", 3 },
                    { new Guid("f4762345-53d0-4b4f-be1f-092affd937f4"), "places", "place", 2 },
                    { new Guid("f4ae5328-eecc-40f3-bbc3-6714438a8ce3"), "words", "word", 2 },
                    { new Guid("f55fcfba-dfc0-4a23-b80b-ae706a4f26da"), "opticians", "optician", 3 },
                    { new Guid("f585a5a5-6be4-4c6f-b985-e046b8f6bad1"), "architects", "architect", 3 },
                    { new Guid("f752aee6-0190-4fee-88b2-54659742dc7c"), "cacti", "cactus", 1 },
                    { new Guid("f877f17d-92d7-4d29-8112-a8fa5b63609b"), "opera", "opus", 1 },
                    { new Guid("f89dee56-49a6-4aba-a982-4c7023c079cd"), "otherses", "others", 2 },
                    { new Guid("f94a25e9-4c7a-49b1-9455-fdac5152b58e"), "fishermans", "fisherman", 3 },
                    { new Guid("fa35d904-5472-4177-9693-50b53aae2832"), "books", "book", 2 },
                    { new Guid("fc48c01b-2b53-416e-b00b-f840af122e86"), "eyes", "eye", 2 },
                    { new Guid("fcf3ec11-03cf-46e3-9e15-5dee1882b272"), "series", "series", 1 },
                    { new Guid("fd759b28-1d26-4c33-aefd-f0dbb8ce1787"), "fungi", "fungus", 1 },
                    { new Guid("fdbe9e4a-affb-4a92-bd51-585b8afd95d1"), "bricklayers", "bricklayer", 3 },
                    { new Guid("fece8942-d66e-4eab-8490-39634b3696f6"), "years", "year", 2 },
                    { new Guid("ff1a4f2a-4b3f-4531-bd64-9452d9756ca5"), "friends", "friend", 2 }
                });

            migrationBuilder.InsertData(
                schema: "vocabulary",
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

            migrationBuilder.InsertData(
                schema: "vocabulary",
                table: "PrimaryVerbs",
                columns: new[] { "Id", "PastForm", "PastParticipleForm", "PresentParticipleForm", "Text", "ThirdPersonForm" },
                values: new object[,]
                {
                    { new Guid("928e8efd-1a11-4df9-9703-0631fa073ca3"), "did", "done", "doing", "do", "does" },
                    { new Guid("aedf0d06-70b2-4270-8c69-6a5b7ce26d1c"), "had", "had", "having", "have", "has" },
                    { new Guid("f286ad7c-e394-42b6-ad07-4be4a8bb137c"), "was", "been", "being", "be", "is" }
                });

            migrationBuilder.InsertData(
                schema: "vocabulary",
                table: "Pronouns",
                columns: new[] { "Id", "Text", "Type" },
                values: new object[,]
                {
                    { new Guid("004a6a6b-bb91-4d03-bec1-ba2529fab0c0"), "he", 1 },
                    { new Guid("03186e19-aab4-4442-8fb3-e178e9fb4677"), "our", 3 },
                    { new Guid("0bb651d1-cc92-41a5-9b24-2934db01ed07"), "they", 1 },
                    { new Guid("0bb8b56e-3c71-44e0-bc1b-55ed5d41aeb4"), "those", 6 },
                    { new Guid("0d48da8a-6d21-4049-a26b-b4f37f170b4e"), "himself", 5 },
                    { new Guid("0e33bc11-5692-4d61-b989-0b7d143a809d"), "theirs", 4 },
                    { new Guid("1a412290-7271-4385-8fc9-f08be3b0452c"), "she", 1 },
                    { new Guid("1b868392-10c9-4b9f-92d7-bb085fcd1c6c"), "ours", 4 },
                    { new Guid("228e5431-fa5b-474b-bff1-f91431f08ba1"), "me", 2 },
                    { new Guid("37d4d557-1584-48ce-88e0-700d83e673a9"), "my", 3 },
                    { new Guid("3a17671e-a6f1-4370-af2a-ce6f43f5312e"), "myself", 5 },
                    { new Guid("3d4024e5-6111-4228-a0a1-f5afd3d5c73b"), "his", 3 },
                    { new Guid("3d4d59db-0f70-4705-adf1-99301046f8f8"), "your", 3 },
                    { new Guid("453d730c-7540-4f26-bc99-688ca2317bdd"), "that", 6 },
                    { new Guid("4574e7fe-0563-415e-9b18-982918d7e632"), "him", 2 },
                    { new Guid("4760d1a2-ed1c-4f5e-94b6-0c71248ebb89"), "yourself", 5 },
                    { new Guid("575963a0-80f7-4024-9c82-90e52aea846a"), "it", 1 },
                    { new Guid("60a86ad4-6d5f-4874-819a-61f9c200b7b1"), "we", 1 },
                    { new Guid("788528a7-d7c4-4818-ae8e-8a41cf9f694e"), "herself", 5 },
                    { new Guid("95280413-d92d-4907-827e-1bd3fadd5f20"), "you", 1 },
                    { new Guid("95dd9857-02a2-4549-bfb7-28d7468edc8a"), "their", 3 },
                    { new Guid("975f6fa2-8822-433c-a05f-32b97741b648"), "them", 2 },
                    { new Guid("997eb939-e004-4a5b-be05-3cd2a641bd59"), "itself", 5 },
                    { new Guid("a2c14ea9-87a6-4a3d-9f1c-751431e7ef9e"), "its", 3 },
                    { new Guid("a34ed880-662b-47b2-9688-f21dc2a5fc04"), "hers", 4 },
                    { new Guid("b0118050-1f65-44f5-99aa-f4af33665c51"), "us", 2 },
                    { new Guid("bfb1e919-377d-45b8-b9b7-9a3d15dae126"), "her", 3 },
                    { new Guid("c5e9499f-6682-4de2-bb4c-f6cf2c3e5e7f"), "i", 1 },
                    { new Guid("d06a468e-4330-42ac-ab1b-a89b4b89abaa"), "this", 6 },
                    { new Guid("d3a118c2-e428-4fd6-a728-19fd4888f838"), "these", 6 },
                    { new Guid("d9fd3895-0795-41d4-93c0-9dc36f589a9d"), "mine", 4 },
                    { new Guid("dc37db89-eda0-4a30-9284-b3b1712d87c9"), "themselves", 5 },
                    { new Guid("de86911d-4934-4415-a3cf-48332c3ef873"), "ourselves", 5 },
                    { new Guid("f9c20a04-e3c2-45a0-b994-245699ca0727"), "yourselves", 5 }
                });

            migrationBuilder.InsertData(
                schema: "vocabulary",
                table: "QuestionWords",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { new Guid("28a50d80-9744-419f-ab08-a69cfcc80fd4"), "how" },
                    { new Guid("377f7b4a-765b-4ac4-87e0-343b645cbc7c"), "what" },
                    { new Guid("3db6df5d-e140-4d7f-a231-c9a356e725fe"), "who" },
                    { new Guid("95aaeb38-63a9-4933-9aa0-78363d5ce039"), "why" },
                    { new Guid("9dffa778-547f-45e5-8e6e-22bdaef6d2f9"), "when" },
                    { new Guid("c92e0865-0310-4f68-89f5-6f23c38c40b2"), "where" }
                });

            migrationBuilder.InsertData(
                schema: "vocabulary",
                table: "Verbs",
                columns: new[] { "Id", "IsIrregularVerb", "PastForm", "PastParticipleForm", "PresentParticipleForm", "Text", "ThirdPersonForm" },
                values: new object[,]
                {
                    { new Guid("04a72eda-53b6-493d-b25e-f347b9c47d6f"), true, "swung", "swung", "Domain.Common.ValueObjects.Texting", "swing", "swings" },
                    { new Guid("06427786-569b-4223-a6eb-684494ea262b"), true, "cut", "cut", "cutting", "cut", "cuts" },
                    { new Guid("0764754b-2dfe-477b-be38-239cded26c61"), true, "slew", "slain", "Domain.Common.ValueObjects.Texting", "slay", "slays" },
                    { new Guid("080ca9f8-b293-464d-91f7-48e5cadee032"), true, "thought", "thought", "Domain.Common.ValueObjects.Texting", "think", "thinks" },
                    { new Guid("088de34d-a32a-4fea-a64e-af5e3ad516cf"), true, "sped", "sped", "speedding", "speed", "speeds" },
                    { new Guid("08b0300b-35fd-4b9a-a281-a5816e6bafee"), true, "drew", "drawn", "drawwing", "draw", "draws" },
                    { new Guid("08fa6d47-2392-4a24-a852-4cb0c979f5d2"), true, "heard", "heard", "hearring", "hear", "hears" },
                    { new Guid("098d7331-be3b-49cd-ae17-e1f058049949"), true, "fell", "fallen", "Domain.Common.ValueObjects.Texting", "fall", "falls" },
                    { new Guid("0ab08388-0598-44ed-868c-1710e684d6c7"), true, "lent", "lent", "Domain.Common.ValueObjects.Texting", "lend", "lends" },
                    { new Guid("0d48ccf2-83be-4124-bc0b-c354bf72b6b0"), true, "let", "let", "letting", "let", "lets" },
                    { new Guid("0dce8088-31b1-455d-a725-3fadefe06f4c"), true, "shut", "shut", "shutting", "shut", "shuts" },
                    { new Guid("0df3959a-9857-46df-afc2-26600d78f00b"), true, "gave", "given", "giving", "give", "gives" },
                    { new Guid("0ed5f9db-d1ae-4d2b-b6c5-82674b728385"), true, "found", "found", "Domain.Common.ValueObjects.Texting", "find", "finds" },
                    { new Guid("1222c440-64e7-4515-a858-457378ff0b82"), true, "leant", "leant", "leanning", "lean", "leans" },
                    { new Guid("127f441c-e486-43c6-8881-ccb18e57f407"), true, "quit", "quit", "quitting", "quit", "quits" },
                    { new Guid("152748d4-96a3-4b2f-8fd1-1cf452611903"), true, "throve", "thriven", "thriving", "thrive", "thrives" },
                    { new Guid("158cac94-063a-4758-a869-be0c1684a43a"), true, "bent", "bent", "Domain.Common.ValueObjects.Texting", "bend", "bends" },
                    { new Guid("1673a086-7cf3-4ea0-ad83-09acc782570f"), true, "knelt", "knelt", "kneelling", "kneel", "kneels" },
                    { new Guid("173345e5-0dc9-4b71-a500-92a4353ebea8"), true, "taught", "taught", "Domain.Common.ValueObjects.Texting", "teach", "teaches" },
                    { new Guid("19c8a9bf-1119-4630-bd1d-7530032ff5b9"), true, "wound", "wound", "Domain.Common.ValueObjects.Texting", "wind", "winds" },
                    { new Guid("1a0abad8-b485-47ba-922b-8959d38ef117"), true, "spoilt", "spoilt", "spoilling", "spoil", "spoils" },
                    { new Guid("1a5688fa-d1f7-484a-8096-f17505b13b31"), true, "said", "said", "Domain.Common.ValueObjects.Texting", "say", "says" },
                    { new Guid("212f73fc-1723-467c-bce0-ed86b0562968"), true, "took", "taken", "taking", "take", "takes" },
                    { new Guid("21c80b82-aeea-4909-b3a7-4a1262b55087"), true, "made", "made", "making", "make", "makes" },
                    { new Guid("25a5199c-93c3-4be9-8efe-ebee1f8790e2"), true, "built", "built", "Domain.Common.ValueObjects.Texting", "build", "builds" },
                    { new Guid("26350c1b-2247-465f-beb4-ea783f1c4d0d"), true, "shed", "shed", "shedding", "shed", "sheds" },
                    { new Guid("26e6b636-b240-4890-9ae8-8350e43a3e07"), true, "went", "gone", "Domain.Common.ValueObjects.Texting", "go", "goes" },
                    { new Guid("2761cd31-5b0d-40b0-b623-6e34130635eb"), true, "clung", "clung", "Domain.Common.ValueObjects.Texting", "cling", "clings" },
                    { new Guid("2a738136-3ae1-4924-b5fb-3f36876be47c"), true, "felt", "felt", "feelling", "feel", "feels" },
                    { new Guid("2b98a90c-fd7d-4985-8390-4105c4a840fa"), true, "forecast", "forecast", "Domain.Common.ValueObjects.Texting", "forecast", "forecasts" },
                    { new Guid("2f5d0a03-9cb1-43ce-93d8-43eab5a2d44c"), true, "shod", "shod", "shoing", "shoe", "shoes" },
                    { new Guid("3844a8ab-9c33-4163-b2f7-33f6e033fba9"), true, "spilt", "spilt", "Domain.Common.ValueObjects.Texting", "spill", "spills" },
                    { new Guid("395bcf7c-6c11-49c3-a48b-fdd25a012965"), true, "split", "split", "splitting", "split", "splits" },
                    { new Guid("3c27cf22-018c-4e74-98da-214856aa6f9c"), true, "dealt", "dealt", "dealling", "deal", "deals" },
                    { new Guid("3d73ca6c-bebc-4d3d-8333-d3bb8152fb7c"), true, "kept", "kept", "keepping", "keep", "keeps" },
                    { new Guid("3e629f3c-3b99-4213-8a09-3de389f68a15"), true, "sowed", "sown", "sowwing", "sow", "sows" },
                    { new Guid("3ef19c91-2e94-4fb7-bd66-58f3dbd5273e"), true, "underwent", "undergone", "Domain.Common.ValueObjects.Texting", "undergo", "undergos" },
                    { new Guid("3f227149-0a0e-4c4b-964d-2aab47b367c2"), true, "sweated", "swollen", "Domain.Common.ValueObjects.Texting", "swell", "swells" },
                    { new Guid("3fbe704d-e885-4f10-8d1c-f740b40b7aca"), true, "swore", "sworn", "swearring", "swear", "swears" },
                    { new Guid("3fce18bd-a3de-4b95-b072-b156ba86762d"), true, "sang", "sung", "Domain.Common.ValueObjects.Texting", "sing", "sings" },
                    { new Guid("4098a85e-ef2b-4074-8ae6-a45ff5e15d51"), true, "bade", "bidden", "bidding", "bid", "bids" },
                    { new Guid("436330f7-5fc3-41f5-8618-ce373125aa7f"), true, "shot", "shot", "shootting", "shoot", "shoots" },
                    { new Guid("4805b2d0-c197-4e5f-af3b-0a73279b01f0"), true, "began", "begun", "beginning", "begin", "begins" },
                    { new Guid("49413c3b-d69b-4da0-809f-5418c5c59433"), true, "swam", "swum", "swimming", "swim", "swims" },
                    { new Guid("4a6faca6-8c13-4866-8720-902208050e57"), true, "awoke", "awoken", "awaking", "awake", "awakes" },
                    { new Guid("4d62450a-6de9-4c0a-be8e-c8a1bef0064a"), true, "ate", "eaten", "eatting", "eat", "eats" },
                    { new Guid("4d70edf3-9322-44be-af1e-a63944bb5322"), true, "crept", "crept", "creepping", "creep", "creeps" },
                    { new Guid("4ea1553e-6516-4de5-a674-c963fb2efa22"), true, "forbade", "forbidden", "forbidding", "forbid", "forbids" },
                    { new Guid("502109a1-2505-4d98-97af-7beb39769996"), true, "overcame", "overcome", "overcoming", "overcome", "overcomes" },
                    { new Guid("5532f559-1fee-43d7-a14b-ff84f4b52d83"), true, "burnt", "burnt", "Domain.Common.ValueObjects.Texting", "burn", "burns" },
                    { new Guid("554f731e-250c-47c8-8b41-7fd78324c09f"), true, "ground", "ground", "Domain.Common.ValueObjects.Texting", "grind", "grinds" },
                    { new Guid("5a14ab27-fc58-4521-81d0-02e5677646b4"), true, "broadcast", "broadcast", "Domain.Common.ValueObjects.Texting", "broadcast", "broadcasts" },
                    { new Guid("611b238f-7a9f-4b73-af3c-b9f31acb2998"), true, "clad", "clad", "clothing", "clothe", "clothes" },
                    { new Guid("61a3c2be-e5d0-4584-9b50-bfa927717ae1"), true, "blew", "blown", "blowwing", "blow", "blows" },
                    { new Guid("6685d3ee-7bfe-4568-bb04-eb12cbaa4723"), true, "stole", "stolen", "stealling", "steal", "steals" },
                    { new Guid("6abbd57b-093d-4cb5-817e-b7e66eb08125"), true, "cost", "cost", "Domain.Common.ValueObjects.Texting", "cost", "costs" },
                    { new Guid("6f256de3-b725-49ca-a5f4-6da70d42b129"), true, "spread", "spread", "spreadding", "spread", "spreads" },
                    { new Guid("7034c0c8-5b47-46bb-a134-07dde1ee5c1a"), true, "put", "put", "putting", "put", "puts" },
                    { new Guid("70885a73-7dc3-4051-a7a7-9a9f02c53577"), true, "forgave", "forgiven", "forgiving", "forgive", "forgives" },
                    { new Guid("71a0001c-2c55-4acf-b8e2-281d6a88d7b3"), true, "proved", "proven", "proving", "prove", "proves" },
                    { new Guid("73c5d350-28b0-4e73-bb3b-5db644a42c2a"), true, "read", "read", "readding", "read", "reads" },
                    { new Guid("748672bd-4337-4a13-84fc-26ef9e330385"), true, "wrung", "wrung", "Domain.Common.ValueObjects.Texting", "wring", "wrings" },
                    { new Guid("750957e2-7499-48e1-86e6-bbc2b6e44f9e"), true, "rid", "rid", "ridding", "rid", "rids" },
                    { new Guid("77ed9757-f9bf-4d6f-89df-d7e2551ca5d1"), true, "struck", "stricken", "striking", "strike", "strikes" },
                    { new Guid("79940793-9681-4072-8a8d-38faafffb3bd"), true, "rose", "risen", "rising", "rise", "rises" },
                    { new Guid("79f3cd18-6c93-4179-9682-b97501edd5f4"), true, "sent", "sent", "Domain.Common.ValueObjects.Texting", "send", "sends" },
                    { new Guid("7a22ad10-f387-4575-af64-dca2fc91034d"), true, "stuck", "stuck", "Domain.Common.ValueObjects.Texting", "stick", "sticks" },
                    { new Guid("7a455aff-4665-444d-84f9-8e72bdd6fbec"), true, "rang", "rung", "Domain.Common.ValueObjects.Texting", "ring", "rings" },
                    { new Guid("7a5fca8f-db9e-466b-98c7-bd0496dead20"), true, "learnt", "learnt", "Domain.Common.ValueObjects.Texting", "learn", "learns" },
                    { new Guid("7b6c7a3e-d252-4f9d-a64d-817015a797d1"), true, "grew", "grown", "growwing", "grow", "grows" },
                    { new Guid("7ba25920-32eb-4272-a737-915fc7ddb55e"), true, "sweat", "sweat", "sweatting", "sweat", "sweats" },
                    { new Guid("7c1495a8-f1ba-4b01-b788-a85a283ba32d"), true, "dug", "dug", "digging", "dig", "digs" },
                    { new Guid("7e38585c-2be1-47f3-bc9d-216658fdcbdc"), true, "withdrew", "withdrawn", "withdrawwing", "withdraw", "withdraws" },
                    { new Guid("7e74a77c-657c-4a1e-8c3b-64cebe8c0e26"), true, "sat", "sat", "sitting", "sit", "sits" },
                    { new Guid("7ec3b062-c755-4be1-a81a-e1c26549e894"), true, "fled", "fled", "fleing", "flee", "flees" },
                    { new Guid("7f81be1c-f743-43cf-aff6-5a5304faa629"), true, "dived", "dove", "diving", "dive", "dives" },
                    { new Guid("82178b0c-7097-4d53-b1fe-b306b748d5f3"), true, "flew", "flown", "Domain.Common.ValueObjects.Texting", "fly", "flies" },
                    { new Guid("82b38513-75c6-483c-895f-1450b1808446"), true, "preset", "preset", "presetting", "preset", "presets" },
                    { new Guid("8300a19e-0ebb-4db6-bc4e-cd52365f2f5e"), true, "cast", "cast", "Domain.Common.ValueObjects.Texting", "cast", "casts" },
                    { new Guid("84c4f361-df60-42f2-99f4-1cbec1bfa2c0"), true, "knew", "known", "knowwing", "know", "knows" },
                    { new Guid("85157b6e-e03e-4965-b70b-f8a0189ecdf6"), true, "beat", "beaten", "beatting", "beat", "beats" },
                    { new Guid("852d7c61-79d8-471a-b65b-ee68e54de4b5"), true, "typeset", "typeset", "typesetting", "typeset", "typesets" },
                    { new Guid("860a328d-fd17-4928-ab76-b965477ce613"), true, "hit", "hit", "hitting", "hit", "hits" },
                    { new Guid("87c4e6a2-d3e5-4233-b66a-c39edfbc7a2a"), true, "understood", "understood", "Domain.Common.ValueObjects.Texting", "understand", "understands" },
                    { new Guid("889d8c29-a848-416e-8989-2f320a764d7a"), true, "relaid", "relaid", "Domain.Common.ValueObjects.Texting", "relay", "relays" },
                    { new Guid("89ee0d44-f1fd-43fd-8c81-d078a22dd83d"), true, "caught", "caught", "Domain.Common.ValueObjects.Texting", "catch", "catches" },
                    { new Guid("8bcb4916-3727-476f-a651-9ca122860264"), true, "fought", "fought", "Domain.Common.ValueObjects.Texting", "fight", "fights" },
                    { new Guid("8e64f20e-d532-4a1b-befc-1d828e224b8e"), true, "froze", "frozen", "freezing", "freeze", "freezes" },
                    { new Guid("8ed7e97a-8abe-4b3e-b9fa-e13784a61c7e"), true, "mowed", "mown", "mowwing", "mow", "mows" },
                    { new Guid("9032bf12-4097-4f76-8292-458bb6f0de71"), true, "slit", "slit", "slitting", "slit", "slits" },
                    { new Guid("90401257-cf69-4236-a93b-6b5e128da8bc"), true, "leapt", "leapt", "leapping", "leap", "leaps" },
                    { new Guid("913e3089-5c81-4667-8c14-f2d2b6dd0006"), true, "slept", "slept", "sleepping", "sleep", "sleeps" },
                    { new Guid("91744462-e0d2-47ce-8eb5-9253c0af16ed"), true, "chid", "chidden", "chiding", "chide", "chides" },
                    { new Guid("92fb4a16-dd8c-4852-b06e-fd3fff0326d7"), true, "told", "told", "Domain.Common.ValueObjects.Texting", "tell", "tells" },
                    { new Guid("938ea4bf-d4b7-4cd3-9901-aeeff2856c3a"), true, "chose", "chosen", "choosing", "choose", "chooses" },
                    { new Guid("94cd5eac-9aa7-4949-81ae-b7b6d973e375"), true, "foresaw", "foreseen", "foreseing", "foresee", "foresees" },
                    { new Guid("96be195b-163b-46b4-b0aa-daddef5906d5"), true, "rent", "rent", "Domain.Common.ValueObjects.Texting", "rend", "rends" },
                    { new Guid("97b38d61-b8ca-4263-8a18-b85b50c0bbed"), true, "begot", "begotten", "begetting", "beget", "begets" },
                    { new Guid("9af79d54-7da4-4c95-81b1-cb80100d3c9e"), true, "drank", "drunk", "Domain.Common.ValueObjects.Texting", "drink", "drinks" },
                    { new Guid("9b997b2a-5c4a-412c-82c9-0afefbcc509f"), true, "ran", "run", "running", "run", "runs" },
                    { new Guid("9c47b4b4-0811-400e-bd0e-eb501ecfcf0b"), true, "strove", "striven", "striving", "strive", "strives" },
                    { new Guid("9f234f2c-d977-4ce5-88e8-3eb982d9a65b"), true, "shone", "shone", "shining", "shine", "shines" },
                    { new Guid("a0defac1-5990-4a9e-8ad0-4cb059080d53"), true, "wept", "wept", "weepping", "weep", "weeps" },
                    { new Guid("a4e177a4-7c4a-48eb-a1ee-c2755ccfa190"), true, "bit", "bitten", "biting", "bite", "bites" },
                    { new Guid("a4f228c6-6276-40f9-a535-583b4bf288ae"), true, "fed", "fed", "feedding", "feed", "feeds" },
                    { new Guid("a58a1299-b66a-45fb-9d57-df2744a61b10"), true, "bet", "bet", "betting", "bet", "bets" },
                    { new Guid("a5cbe034-b84b-4e47-a8ed-bb2ead73882f"), true, "bled", "bled", "bleedding", "bleed", "bleeds" },
                    { new Guid("a6d8aa1f-8022-4197-9446-bbb014d20803"), true, "swept", "swept", "sweepping", "sweep", "sweeps" },
                    { new Guid("a74a87b4-aa94-4467-a781-a3b2cdc8a200"), true, "stank", "stunk", "Domain.Common.ValueObjects.Texting", "stink", "stinks" },
                    { new Guid("a8095252-e298-4c2a-b273-5a879b60663a"), true, "wrote", "written", "writing", "write", "writes" },
                    { new Guid("a8384112-316d-462b-bcd6-7f1684fa129b"), true, "wet", "wet", "wetting", "wet", "wets" },
                    { new Guid("ab5892f9-80ef-49d8-aaba-245b64fb2177"), true, "spelt", "spelt", "Domain.Common.ValueObjects.Texting", "spell", "spells" },
                    { new Guid("abd6465a-a429-4e7b-a2f1-c787e3388e52"), true, "left", "left", "leaving", "leave", "leaves" },
                    { new Guid("abe95156-5447-4598-aa44-d76b85c32763"), true, "burst", "burst", "Domain.Common.ValueObjects.Texting", "burst", "bursts" },
                    { new Guid("acb9b244-8b67-439a-b518-aab7e685afa1"), true, "brought", "brought", "Domain.Common.ValueObjects.Texting", "bring", "brings" },
                    { new Guid("af5372e8-fef0-4167-a9f7-8a496bb48e22"), true, "held", "held", "Domain.Common.ValueObjects.Texting", "hold", "holds" },
                    { new Guid("b1494345-3795-46ed-b4d6-89225b6b4780"), true, "abode", "abode", "abiding", "abide", "abides" },
                    { new Guid("b3a6f96a-20fc-403e-b58b-8fc437d0572c"), true, "sought", "sought", "seekking", "seek", "seeks" },
                    { new Guid("b67ca360-ab47-4943-b96b-5fdb2c6e4975"), true, "threw", "thrown", "throwwing", "throw", "throws" },
                    { new Guid("b7268c58-3613-4c82-a8fc-128651ec4bb8"), true, "woke", "woken", "waking", "wake", "wakes" },
                    { new Guid("b81fb64f-1e58-4794-ba7d-504f9458d134"), true, "offset", "offset", "offsetting", "offset", "offsets" },
                    { new Guid("b968739c-3347-49f7-883a-544ecfd2e3c2"), true, "forgot", "forgotten", "forgetting", "forget", "forgets" },
                    { new Guid("bc0fc4dd-9706-46ab-90ca-ce1e5a658cd0"), true, "forsook", "forsaken", "forsaking", "forsake", "forsakes" },
                    { new Guid("c1d02fd0-3597-4e99-973b-a9b226278804"), true, "bought", "bought", "Domain.Common.ValueObjects.Texting", "buy", "buys" },
                    { new Guid("c2f578f8-c4d1-4c6a-af64-29b8b2b765b8"), true, "became", "become", "becoming", "become", "becomes" },
                    { new Guid("c359384e-c2da-426e-994e-a52d7a0270c2"), true, "stung", "stung", "Domain.Common.ValueObjects.Texting", "sting", "stings" },
                    { new Guid("c3fab5ba-ca4b-4bce-ae97-60204ce6c4c6"), true, "spent", "spent", "Domain.Common.ValueObjects.Texting", "spend", "spends" },
                    { new Guid("c4b30f8a-01ba-4b2c-8ded-67e7885f3316"), true, "won", "won", "winning", "win", "wins" },
                    { new Guid("c6ab312d-6ed1-4f5d-87b8-a9bfab2e2574"), true, "slid", "slid", "sliding", "slide", "slides" },
                    { new Guid("c7470fca-80d5-4d71-8c7d-b67a97a7d575"), true, "smelt", "smelt", "Domain.Common.ValueObjects.Texting", "smell", "smells" },
                    { new Guid("c76194e3-5c0a-4409-9e3a-0ee53699a4df"), true, "sold", "sold", "Domain.Common.ValueObjects.Texting", "sell", "sells" },
                    { new Guid("c97d9f53-ce6a-4a24-8a1d-5b169ee70b03"), true, "arose", "arisen", "arising", "arise", "arises" },
                    { new Guid("cba1fa00-2b55-49aa-ae64-4a1fab683af7"), true, "partook", "partaken", "partaking", "partake", "partakes" },
                    { new Guid("cc37c5e2-984c-40c1-a262-c868c764fa43"), true, "spat", "spat", "spitting", "spit", "spits" },
                    { new Guid("cd81482c-117f-4e42-9381-aabea7644bc4"), true, "broke", "broken", "breakking", "break", "breaks" },
                    { new Guid("ce39bc7e-7215-4631-906c-25bd5b842bb4"), true, "saw", "seen", "seing", "see", "sees" },
                    { new Guid("cfa7a5d6-23d8-420a-afa2-93fa6756605c"), true, "sank", "sunk", "Domain.Common.ValueObjects.Texting", "sink", "sinks" },
                    { new Guid("d2dc4e1f-dc32-4063-9d06-4887333902c7"), true, "spoke", "spoken", "speakking", "speak", "speaks" },
                    { new Guid("d3222b12-b5cd-4110-a73d-1913f89dcba1"), true, "lost", "lost", "losing", "lose", "loses" },
                    { new Guid("d423ff7a-2b86-4d9e-b384-d39fba3cb911"), true, "hung", "hung", "Domain.Common.ValueObjects.Texting", "hang", "hangs" },
                    { new Guid("d5d93861-bbe7-40aa-81b3-3d56b579dcab"), true, "spun", "spun", "spinning", "spin", "spins" },
                    { new Guid("da2c4743-6a2d-4f2c-a16d-fcc67f487fc7"), true, "dreamt", "dreamt", "dreamming", "dream", "dreams" },
                    { new Guid("daf80c76-a3e8-46f5-b1e9-9da5153639c7"), true, "strewed", "strewn", "strewwing", "strew", "strews" },
                    { new Guid("dbbd1b3b-dff7-401e-9f6e-05ac28aab49d"), true, "dwelt", "dwelt", "Domain.Common.ValueObjects.Texting", "dwell", "dwells" },
                    { new Guid("dda3e8d9-7d3b-471c-86b6-6662fc266186"), true, "met", "met", "meetting", "meet", "meets" },
                    { new Guid("de80680e-085f-4411-80a9-c7ee92f98b1c"), true, "paid", "paid", "Domain.Common.ValueObjects.Texting", "pay", "pays" },
                    { new Guid("df985827-fbba-4f62-b61c-9b5cf771cc08"), true, "set", "set", "setting", "set", "sets" },
                    { new Guid("e0d4995c-c46d-405b-98d7-3f6a7c8c3f77"), true, "hurt", "hurt", "Domain.Common.ValueObjects.Texting", "hurt", "hurts" },
                    { new Guid("e52e7fbc-3382-45f6-9cdc-fd28f4553499"), true, "stood", "stood", "Domain.Common.ValueObjects.Texting", "stand", "stands" },
                    { new Guid("e567a9c0-da5e-4ee0-b4e4-e3caa71eb981"), true, "lay", "lain", "lying", "lie", "lies" },
                    { new Guid("e6afcdc5-4a80-4351-8f9e-625b49997d84"), true, "thrust", "thrust", "Domain.Common.ValueObjects.Texting", "thrust", "thrusts" },
                    { new Guid("e6d94b61-d7ba-45fb-8f38-f923dff8838c"), true, "flung", "flung", "Domain.Common.ValueObjects.Texting", "fling", "flings" },
                    { new Guid("e72e57c4-99d6-47d9-9e9f-b138aa4ffd34"), true, "drove", "driven", "driving", "drive", "drives" },
                    { new Guid("e7707ca6-f16a-4ab3-9593-8fec65260e61"), true, "meant", "meant", "meanning", "mean", "means" },
                    { new Guid("e918e2ec-50c0-474f-bd68-fe5e50dd1439"), true, "shook", "shaken", "shaking", "shake", "shakes" },
                    { new Guid("ea7a0759-f64e-4d54-800a-eb11e578892d"), true, "laid", "laid", "Domain.Common.ValueObjects.Texting", "lay", "lays" },
                    { new Guid("ed068755-e3ff-4d7c-98bc-b1d966bcb018"), true, "showed", "shown", "showwing", "show", "shows" },
                    { new Guid("edc9d6e1-b311-40ac-bc21-14458f2de1e7"), true, "got", "gotten", "getting", "get", "gets" },
                    { new Guid("ee423aa3-4f92-4e8e-b393-7d28b288e3b8"), true, "tore", "torn", "tearring", "tear", "tears" },
                    { new Guid("f18bb6cc-df77-478e-a111-7c6d24225dfc"), true, "bore", "born", "bearring", "bear", "bears" },
                    { new Guid("f59dc9cd-2fd4-4f0c-ad56-e33cfa7fce49"), true, "wore", "worn", "wearring", "wear", "wears" },
                    { new Guid("fc0ca563-4b36-451f-bb87-506f25bd77d7"), true, "hid", "hidden", "hiding", "hide", "hides" },
                    { new Guid("fc67d2ae-8e41-4ef7-a30f-acd00f396762"), true, "led", "led", "leadding", "lead", "leads" },
                    { new Guid("fca52707-889b-43ea-a2d3-5ff2045a7f02"), true, "came", "come", "coming", "come", "comes" },
                    { new Guid("ffc5ecd7-4914-4fb2-b9d5-51b81359b3f2"), true, "pled", "pled", "pleadding", "plead", "pleads" }
                });

            migrationBuilder.InsertData(
                schema: "vocabulary",
                table: "AdditionalForms",
                columns: new[] { "Id", "PrimaryVerbId", "Text" },
                values: new object[,]
                {
                    { 1, new Guid("f286ad7c-e394-42b6-ad07-4be4a8bb137c"), "were" },
                    { 2, new Guid("f286ad7c-e394-42b6-ad07-4be4a8bb137c"), "am" },
                    { 3, new Guid("f286ad7c-e394-42b6-ad07-4be4a8bb137c"), "are" }
                });

            migrationBuilder.InsertData(
                schema: "vocabulary",
                table: "FullNegativeForms",
                columns: new[] { "Id", "PrimaryVerbId", "Text" },
                values: new object[,]
                {
                    { 1, new Guid("928e8efd-1a11-4df9-9703-0631fa073ca3"), "do not" },
                    { 2, new Guid("928e8efd-1a11-4df9-9703-0631fa073ca3"), "did not" },
                    { 3, new Guid("928e8efd-1a11-4df9-9703-0631fa073ca3"), "does not" },
                    { 4, new Guid("aedf0d06-70b2-4270-8c69-6a5b7ce26d1c"), "have not" },
                    { 5, new Guid("aedf0d06-70b2-4270-8c69-6a5b7ce26d1c"), "had not" },
                    { 6, new Guid("aedf0d06-70b2-4270-8c69-6a5b7ce26d1c"), "has not" },
                    { 7, new Guid("f286ad7c-e394-42b6-ad07-4be4a8bb137c"), "was not" },
                    { 8, new Guid("f286ad7c-e394-42b6-ad07-4be4a8bb137c"), "were not" },
                    { 9, new Guid("f286ad7c-e394-42b6-ad07-4be4a8bb137c"), "am not" },
                    { 10, new Guid("f286ad7c-e394-42b6-ad07-4be4a8bb137c"), "is not" },
                    { 11, new Guid("f286ad7c-e394-42b6-ad07-4be4a8bb137c"), "are not" }
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
                schema: "vocabulary",
                table: "ShortNegativeForms",
                columns: new[] { "Id", "PrimaryVerbId", "Text" },
                values: new object[,]
                {
                    { 1, new Guid("928e8efd-1a11-4df9-9703-0631fa073ca3"), "don't" },
                    { 2, new Guid("928e8efd-1a11-4df9-9703-0631fa073ca3"), "didn't" },
                    { 3, new Guid("928e8efd-1a11-4df9-9703-0631fa073ca3"), "doesn't" },
                    { 4, new Guid("aedf0d06-70b2-4270-8c69-6a5b7ce26d1c"), "haven't" },
                    { 5, new Guid("aedf0d06-70b2-4270-8c69-6a5b7ce26d1c"), "hadn't" },
                    { 6, new Guid("aedf0d06-70b2-4270-8c69-6a5b7ce26d1c"), "hasn't" },
                    { 7, new Guid("f286ad7c-e394-42b6-ad07-4be4a8bb137c"), "wasn't" },
                    { 8, new Guid("f286ad7c-e394-42b6-ad07-4be4a8bb137c"), "weren't" },
                    { 9, new Guid("f286ad7c-e394-42b6-ad07-4be4a8bb137c"), "am not" },
                    { 10, new Guid("f286ad7c-e394-42b6-ad07-4be4a8bb137c"), "isn't" },
                    { 11, new Guid("f286ad7c-e394-42b6-ad07-4be4a8bb137c"), "aren't" }
                });

            migrationBuilder.InsertData(
                schema: "practice",
                table: "Words",
                columns: new[] { "Id", "ExerciseId", "Number", "Text", "Type" },
                values: new object[,]
                {
                    { new Guid("0343e0cf-6886-4dff-a5f5-3465c15de0ca"), new Guid("7f44ae6d-6b28-47aa-9d9b-500a632303ef"), 4, "you.", 14 },
                    { new Guid("03e9797f-ab16-4422-bfd9-bf76ca33f436"), new Guid("6ed88863-0c5d-45cd-b361-3071bf62a907"), 1, "You", 14 },
                    { new Guid("09eab928-69c6-4ff3-ac10-a26d66bef69a"), new Guid("8cb2fa8b-6886-4fcd-a596-ecc8f15b406c"), 3, "leave", 16 },
                    { new Guid("16738012-8d9a-4790-810e-bbf91672cdf6"), new Guid("ec6ea7e1-3dbb-45a7-801c-3441c6ef962f"), 1, "Will", 9 },
                    { new Guid("1deab725-e374-4ad7-a169-45a4e77d58f5"), new Guid("6ed88863-0c5d-45cd-b361-3071bf62a907"), 3, "see.", 16 },
                    { new Guid("37b924c3-3886-49a1-8c0a-07a718957e92"), new Guid("69dfc0ba-ac95-44bb-b412-b36b2a45f6bb"), 3, "look?", 16 },
                    { new Guid("49defb22-e6eb-4690-94e7-f801c8a8d14a"), new Guid("7f44ae6d-6b28-47aa-9d9b-500a632303ef"), 1, "He", 14 },
                    { new Guid("4da38ea9-9eb1-4463-928b-5d38bea9c17b"), new Guid("ec6ea7e1-3dbb-45a7-801c-3441c6ef962f"), 3, "show?", 16 },
                    { new Guid("5554f1d6-d563-42fa-85a0-dda3d3d32e64"), new Guid("24de4efb-c76c-4d7c-ab9d-914a272962f7"), 3, "show", 16 },
                    { new Guid("67d10373-c942-46de-87ad-c8c746bd4394"), new Guid("24de4efb-c76c-4d7c-ab9d-914a272962f7"), 2, "i", 14 },
                    { new Guid("6ff589b9-3040-4f64-a428-8627bc337907"), new Guid("8cb2fa8b-6886-4fcd-a596-ecc8f15b406c"), 2, "didn't", 13 },
                    { new Guid("7b4a0424-5599-4ad4-9609-059205257ae7"), new Guid("8cb2fa8b-6886-4fcd-a596-ecc8f15b406c"), 4, "him.", 14 },
                    { new Guid("7da2bb0a-474c-4631-ab65-16301dff24d1"), new Guid("7fafec3f-f7fe-46d7-962d-79d62dc13f66"), 3, "break?", 16 },
                    { new Guid("862f83cd-d378-410e-88d6-27b01a06a2dc"), new Guid("f8d8fcb2-4df3-4321-9538-fe576ef04c2d"), 1, "You", 14 },
                    { new Guid("90293e3d-2b54-41ce-a778-505d4957e7dc"), new Guid("05882a8b-9897-4793-8a1e-dd0cf841c95b"), 2, "open", 16 },
                    { new Guid("9127d763-820f-4a77-8019-2ff8742fa03b"), new Guid("7fafec3f-f7fe-46d7-962d-79d62dc13f66"), 2, "i", 14 },
                    { new Guid("9215550e-7cfd-4e41-a946-90e09def9e39"), new Guid("dacb0b73-7bb2-491f-9bf6-adb1f3e2f50f"), 2, "worked?", 16 },
                    { new Guid("a5915abb-95f9-425d-a054-5ee27997b634"), new Guid("ec6ea7e1-3dbb-45a7-801c-3441c6ef962f"), 2, "we", 14 },
                    { new Guid("bc701d83-279f-4912-83ca-d194e0c47c04"), new Guid("7fafec3f-f7fe-46d7-962d-79d62dc13f66"), 1, "Will", 13 },
                    { new Guid("c02b1a8b-0138-47d6-873b-16e084831444"), new Guid("6ed88863-0c5d-45cd-b361-3071bf62a907"), 2, "will not", 9 },
                    { new Guid("c94b4187-1a22-419a-8ba4-4b83f42e133b"), new Guid("05882a8b-9897-4793-8a1e-dd0cf841c95b"), 3, "her.", 14 },
                    { new Guid("cad3b0f3-cbe2-4388-8498-1373966c8f80"), new Guid("24de4efb-c76c-4d7c-ab9d-914a272962f7"), 1, "Did", 13 },
                    { new Guid("ccac4b45-c615-438b-aeb4-2ec52947e9c4"), new Guid("69dfc0ba-ac95-44bb-b412-b36b2a45f6bb"), 1, "Will", 9 },
                    { new Guid("d3362e8e-2991-4333-a43b-6872b98f4867"), new Guid("7f44ae6d-6b28-47aa-9d9b-500a632303ef"), 2, "will", 13 },
                    { new Guid("d74bcb9b-36d6-4ec0-8cf8-b1a8be9624af"), new Guid("dacb0b73-7bb2-491f-9bf6-adb1f3e2f50f"), 1, "She", 14 },
                    { new Guid("da4ec215-746b-4fe6-9676-4e8070e16097"), new Guid("05882a8b-9897-4793-8a1e-dd0cf841c95b"), 1, "You", 14 },
                    { new Guid("dbb5722c-0428-41b5-8de8-281036a10116"), new Guid("8cb2fa8b-6886-4fcd-a596-ecc8f15b406c"), 1, "We", 14 },
                    { new Guid("dfd01a72-3ec6-47b1-8a40-32c3a32ad2da"), new Guid("69dfc0ba-ac95-44bb-b412-b36b2a45f6bb"), 2, "I", 14 },
                    { new Guid("e17c03b2-dcb5-4b43-ba00-c4e98b800fc9"), new Guid("7f44ae6d-6b28-47aa-9d9b-500a632303ef"), 3, "understand", 16 },
                    { new Guid("e86dff93-aeb8-476b-bfe0-ded0dc21e2de"), new Guid("f8d8fcb2-4df3-4321-9538-fe576ef04c2d"), 2, "didn't", 13 },
                    { new Guid("ee70e409-d59e-4c23-86eb-1f2878181e1b"), new Guid("f8d8fcb2-4df3-4321-9538-fe576ef04c2d"), 3, "think.", 16 },
                    { new Guid("f9f305a2-e2c8-4cca-a69c-1c1a28f92361"), new Guid("24de4efb-c76c-4d7c-ab9d-914a272962f7"), 4, "them?", 14 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalForms_PrimaryVerbId",
                schema: "vocabulary",
                table: "AdditionalForms",
                column: "PrimaryVerbId");

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
                name: "IX_FullNegativeForms_PrimaryVerbId",
                schema: "vocabulary",
                table: "FullNegativeForms",
                column: "PrimaryVerbId");

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
                name: "IX_ShortNegativeForms_PrimaryVerbId",
                schema: "vocabulary",
                table: "ShortNegativeForms",
                column: "PrimaryVerbId");

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
                name: "AdditionalForms",
                schema: "vocabulary");

            migrationBuilder.DropTable(
                name: "Adjectives",
                schema: "vocabulary");

            migrationBuilder.DropTable(
                name: "Adverbs",
                schema: "vocabulary");

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
                name: "Cities",
                schema: "vocabulary");

            migrationBuilder.DropTable(
                name: "ComparisonAdjectives",
                schema: "vocabulary");

            migrationBuilder.DropTable(
                name: "Compounds",
                schema: "vocabulary");

            migrationBuilder.DropTable(
                name: "Determiners",
                schema: "vocabulary");

            migrationBuilder.DropTable(
                name: "FullNegativeForms",
                schema: "vocabulary");

            migrationBuilder.DropTable(
                name: "Languages",
                schema: "vocabulary");

            migrationBuilder.DropTable(
                name: "LessonExerciseIds",
                schema: "practice");

            migrationBuilder.DropTable(
                name: "LessonScoreIds",
                schema: "practice");

            migrationBuilder.DropTable(
                name: "LetterNumbers",
                schema: "vocabulary");

            migrationBuilder.DropTable(
                name: "ModalVerbs",
                schema: "vocabulary");

            migrationBuilder.DropTable(
                name: "Nouns",
                schema: "vocabulary");

            migrationBuilder.DropTable(
                name: "Prepositions",
                schema: "vocabulary");

            migrationBuilder.DropTable(
                name: "Pronouns",
                schema: "vocabulary");

            migrationBuilder.DropTable(
                name: "QuestionWords",
                schema: "vocabulary");

            migrationBuilder.DropTable(
                name: "ShortNegativeForms",
                schema: "vocabulary");

            migrationBuilder.DropTable(
                name: "UserScoreIds",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "Verbs",
                schema: "vocabulary");

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
                name: "PrimaryVerbs",
                schema: "vocabulary");

            migrationBuilder.DropTable(
                name: "AspNetUsers",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "Exercises",
                schema: "practice");
        }
    }
}
