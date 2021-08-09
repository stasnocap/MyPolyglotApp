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
    [Migration("20210804064859_RemoveWordsAndAddUnrecognizedWord")]
    partial class RemoveWordsAndAddUnrecognizedWord
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

            modelBuilder.Entity("MyPolyglotWeb.Models.DomainModels.UnrecognizedWordDB", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("ExerciseId")
                        .HasColumnType("bigint");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.ToTable("UnrecognizedWord");
                });

            modelBuilder.Entity("MyPolyglotWeb.Models.DomainModels.ExerciseDB", b =>
                {
                    b.HasOne("MyPolyglotWeb.Models.DomainModels.LessonDB", "Lesson")
                        .WithMany("Exercises")
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Lesson");
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
#pragma warning restore 612, 618
        }
    }
}