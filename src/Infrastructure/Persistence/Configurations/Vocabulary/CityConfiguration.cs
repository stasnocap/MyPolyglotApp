using Domain.Common.ValueObjects;
using Domain.Vocabulary.Cities;
using Domain.Vocabulary.Cities.ValueObjects;
using Infrastructure.Persistence.Seed.Practice;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Vocabulary;

public class CityConfiguration : IEntityTypeConfiguration<City>
{
    public void Configure(EntityTypeBuilder<City> builder)
    {
        builder.ToTable("Cities", schema: Schemas.Practice);

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
            .ValueGeneratedNever()
            .HasConversion(id => id.Value, value => CityId.Create(value));

        builder.Property(c => c.Text)
            .HasMaxLength(100)
            .HasConversion(text => text.Value, value => Text.Create(value).Value);

        builder.HasData(CitySeed.GetCities());
    }
}