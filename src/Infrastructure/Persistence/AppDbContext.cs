using Domain.Identity;
using Infrastructure.Persistence.Configurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;

public class AppDbContext(DbContextOptions options) : IdentityDbContext<User, IdentityRole<Guid>, Guid>(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
                
        SetIdentitySchema(modelBuilder);
    }

    private static void SetIdentitySchema(ModelBuilder modelBuilder)
    {
        const string identitySchema = Schemas.Identity;
        modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AspNetRoleClaims", identitySchema);
        modelBuilder.Entity<IdentityRole<Guid>>().ToTable("AspNetRoles", identitySchema);
        modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AspNetUserClaims", identitySchema);
        modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AspNetUserLogins", identitySchema);
        modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AspNetUserRoles", identitySchema);
        modelBuilder.Entity<User>().ToTable("AspNetUsers", identitySchema);
        modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AspNetUserTokens", identitySchema);
    }
}