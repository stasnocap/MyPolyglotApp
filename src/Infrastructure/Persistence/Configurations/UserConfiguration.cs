using Domain.Users;
using Domain.Users.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        ConfigureScoreIds(builder);
    }
    
    private void ConfigureScoreIds(EntityTypeBuilder<User> builder)
    {
        builder.OwnsMany(u => u.ScoreIds, score =>
        {
            score.ToTable("UserScoreIds");

            score.WithOwner().HasForeignKey("UserId");

            score.HasKey("Id");

            score.Property(s => s.Value)
                .HasColumnName("ScoreId")
                .ValueGeneratedNever();
        });

        builder.Metadata.FindNavigation(nameof(User.ScoreIds))!.SetPropertyAccessMode(PropertyAccessMode.Field);
    }
}