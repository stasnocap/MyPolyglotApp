using Domain.Users;
using Domain.Users.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        ConfigureUser(builder);
        ConfigureScoreIds(builder);
    }

    private void ConfigureUser(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");

        builder.HasKey(u => u.Id);

        builder.Property(u => u.Id)
            .ValueGeneratedNever()
            .HasConversion(id => id.Value, value => UserId.Create(value));
        
        builder.Property(u => u.FirstName)
            .HasConversion(firstName => firstName.Value, value => FirstName.Create(value).Value)
            .HasMaxLength(100);
        
        builder.Property(u => u.LastName)
            .HasConversion(lastName => lastName.Value, value => LastName.Create(value).Value)
            .HasMaxLength(100);
        
        builder.Property(u => u.Email)
            .HasConversion(email => email.Value, value => Email.Create(value).Value)
            .HasMaxLength(100);
        
        builder.Property(u => u.PasswordHash)
            .HasConversion(passwordHash => passwordHash.Value, value => PasswordHash.Create(value).Value);
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