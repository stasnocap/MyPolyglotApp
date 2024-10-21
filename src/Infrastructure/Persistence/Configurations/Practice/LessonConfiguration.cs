﻿using Domain.Practice.Lessons;
using Domain.Practice.Lessons.ValueObjects;
using Infrastructure.Persistence.Seed;
using Infrastructure.Persistence.Seed.Practice;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Practice;

public class LessonConfiguration : IEntityTypeConfiguration<Lesson>
{
    public void Configure(EntityTypeBuilder<Lesson> builder)
    {
        ConfigureLesson(builder);
        ConfigureExerciseIds(builder);
        ConfigureScoreIds(builder);
    }

    private void ConfigureExerciseIds(EntityTypeBuilder<Lesson> builder)
    {
        builder.OwnsMany(u => u.ExerciseIds, exerciseIds =>
        {
            exerciseIds.ToTable("LessonExerciseIds");

            exerciseIds.WithOwner().HasForeignKey("LessonId");

            exerciseIds.HasKey("Id");

            exerciseIds.Property(s => s.Value)
                .HasColumnName("ExerciseId")
                .ValueGeneratedNever();

            exerciseIds.HasData(LessonSeed.GetExerciseIdsForLesson1());
        });

        builder.Metadata.FindNavigation(nameof(Lesson.ExerciseIds))!.SetPropertyAccessMode(PropertyAccessMode.Field);
    }

    private void ConfigureScoreIds(EntityTypeBuilder<Lesson> builder)
    {
        builder.OwnsMany(u => u.ScoreIds, scoreIds =>
        {
            scoreIds.ToTable("LessonScoreIds");

            scoreIds.WithOwner().HasForeignKey("LessonId");

            scoreIds.HasKey("Id");

            scoreIds.Property(s => s.Value)
                .HasColumnName("ScoreId")
                .ValueGeneratedNever();
        });

        builder.Metadata.FindNavigation(nameof(Lesson.ScoreIds))!.SetPropertyAccessMode(PropertyAccessMode.Field);
    }

    private void ConfigureLesson(EntityTypeBuilder<Lesson> builder)
    {
        builder.ToTable("Lessons", schema: Schemas.Practice);
        
        builder.HasKey(l => l.Id);

        builder.Property(l => l.Id)
            .ValueGeneratedNever()
            .HasConversion(id => id.Value, value => LessonId.Create(value));

        builder.Property(l => l.Number)
            .HasMaxLength(255)
            .HasConversion(lessonNumber => lessonNumber.Value, value => LessonNumber.Create(value).Value);

        builder.Property(l => l.Name)
            .HasMaxLength(255)
            .HasConversion(lessonName => lessonName.Value, value => LessonName.Create(value).Value);
        
        builder.HasData(LessonSeed.GetLessons());
    }
}