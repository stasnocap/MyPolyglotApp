using Domain.Common.ValueObjects;
using Domain.Practice.Exercises;
using Domain.Practice.Exercises.ValueObjects;
using Domain.Practice.Lessons.ValueObjects;
using Infrastructure.Persistence.Seed;
using Infrastructure.Persistence.Seed.Practice;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Practice;

public class ExerciseConfiguration : IEntityTypeConfiguration<Exercise>
{
    public void Configure(EntityTypeBuilder<Exercise> builder)
    {
        ConfigureExercises(builder);
        ConfigureWords(builder);
    }

    private void ConfigureWords(EntityTypeBuilder<Exercise> builder)
    {
        builder.OwnsMany(e => e.Words, wb =>
        {
            wb.ToTable("Words");

            wb.WithOwner().HasForeignKey("ExerciseId");

            wb.HasKey("Id");

            wb.Property(w => w.Id)
                .ValueGeneratedNever()
                .HasConversion(id => id.Value, value => WordId.Create(value));

            wb.Property(w => w.Number)
                .HasConversion(wordNumber => wordNumber.Value, value => WordNumber.Create(value).Value);
            
            wb.Property(e => e.Text)
                .HasMaxLength(100)
                .HasConversion(engPhrase => engPhrase.Value, value => Text.Create(value).Value);

            wb.Property(w => w.Type);

            wb.HasData(ExerciseSeed.GetSeedWordsForLesson1());
        });
        
        builder.Metadata.FindNavigation(nameof(Exercise.Words))!.SetPropertyAccessMode(PropertyAccessMode.Field);

    }

    private void ConfigureExercises(EntityTypeBuilder<Exercise> builder)
    {
        builder.ToTable("Exercises", schema: Schemas.Practice);

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .ValueGeneratedNever()
            .HasConversion(id => id.Value, value => ExerciseId.Create(value));

        builder.Property(e => e.LessonId)
            .HasConversion(id => id.Value, value => LessonId.Create(value));
        
        builder.Property(e => e.RusPhrase)
            .HasMaxLength(255)
            .HasConversion(rusPhrase => rusPhrase.Value, value => RusPhrase.Create(value).Value);
                
        builder.HasData(ExerciseSeed.GetSeedExercisesForLesson1());
    }
}