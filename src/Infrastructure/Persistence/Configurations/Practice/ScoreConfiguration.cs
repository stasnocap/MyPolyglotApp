using Domain.Practice.Exercises.ValueObjects;
using Domain.Practice.Lessons.ValueObjects;
using Domain.Practice.Scores;
using Domain.Practice.Scores.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Practice;

public class ScoreConfiguration : IEntityTypeConfiguration<Score>
{
    public void Configure(EntityTypeBuilder<Score> builder)
    {
        builder.ToTable("Scores", Schemas.Practice);
        
        builder.HasKey(s => s.Id);

        builder.Property(s => s.Id)
            .ValueGeneratedNever()
            .HasConversion(id => id.Value, value => ScoreId.Create(value));

        builder.Property(e => e.LessonId)
            .HasConversion(id => id.Value, value => LessonId.Create(value));

        builder.Property(s => s.UserId);
        
        builder.Property(s => s.ScoreValue)
            .HasConversion(sv => sv.Value, value => ScoreValue.Create(value));
    }
}