using Domain.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Identity;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        ConfigureScoreIds(builder);
    }
    
    private void ConfigureScoreIds(EntityTypeBuilder<User> builder)
    {
        builder.OwnsMany(u => u.ScoreIds, scoreIds =>
        {
            scoreIds.ToTable("UserScoreIds");

            scoreIds.WithOwner().HasForeignKey("UserId");

            scoreIds.HasKey("Id");

            scoreIds.Property(s => s.Value)
                .HasColumnName("ScoreId")
                .ValueGeneratedNever();
        });

        builder.Metadata.FindNavigation(nameof(User.ScoreIds))!.SetPropertyAccessMode(PropertyAccessMode.Field);
    }
}