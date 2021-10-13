﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyPolyglotWeb.Models;

namespace MyPolyglotWeb.Migrations
{
    [DbContext(typeof(WebContext))]
    [Migration("20211012051335_AddSyllablesInRegularComparisonAdjective")]
    partial class AddSyllablesInRegularComparisonAdjective
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyPolyglotWeb.Models.DomainModels.ExerciseDB", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EngPhrase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("LessonId")
                        .HasColumnType("bigint");

                    b.Property<string>("RusPhrase")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LessonId");

                    b.ToTable("Exercise");
                });

            modelBuilder.Entity("MyPolyglotWeb.Models.DomainModels.LessonDB", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LessonName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Lesson");
                });

            modelBuilder.Entity("MyPolyglotWeb.Models.DomainModels.ScoreDB", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("LessonId")
                        .HasColumnType("bigint");

                    b.Property<double>("Points")
                        .HasColumnType("float");

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("LessonId");

                    b.HasIndex("UserId");

                    b.ToTable("Score");
                });

            modelBuilder.Entity("MyPolyglotWeb.Models.DomainModels.UnrecognizedWordDB", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("ExerciseId")
                        .HasColumnType("bigint");

                    b.Property<bool>("StressOnTheFinalSyllableInRegularVerb")
                        .HasColumnType("bit");

                    b.Property<int>("SyllablesInRegularComparisonAdjective")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.ToTable("UnrecognizedWord");
                });

            modelBuilder.Entity("MyPolyglotWeb.Models.DomainModels.UserDB", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("MyPolyglotWeb.Models.DomainModels.ExerciseDB", b =>
                {
                    b.HasOne("MyPolyglotWeb.Models.DomainModels.LessonDB", "Lesson")
                        .WithMany("Exercises")
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Lesson");
                });

            modelBuilder.Entity("MyPolyglotWeb.Models.DomainModels.ScoreDB", b =>
                {
                    b.HasOne("MyPolyglotWeb.Models.DomainModels.LessonDB", "Lesson")
                        .WithMany()
                        .HasForeignKey("LessonId");

                    b.HasOne("MyPolyglotWeb.Models.DomainModels.UserDB", "User")
                        .WithMany("Scores")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Lesson");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MyPolyglotWeb.Models.DomainModels.UnrecognizedWordDB", b =>
                {
                    b.HasOne("MyPolyglotWeb.Models.DomainModels.ExerciseDB", "Exercise")
                        .WithMany("UnrecognizedWords")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Exercise");
                });

            modelBuilder.Entity("MyPolyglotWeb.Models.DomainModels.ExerciseDB", b =>
                {
                    b.Navigation("UnrecognizedWords");
                });

            modelBuilder.Entity("MyPolyglotWeb.Models.DomainModels.LessonDB", b =>
                {
                    b.Navigation("Exercises");
                });

            modelBuilder.Entity("MyPolyglotWeb.Models.DomainModels.UserDB", b =>
                {
                    b.Navigation("Scores");
                });
#pragma warning restore 612, 618
        }
    }
}
