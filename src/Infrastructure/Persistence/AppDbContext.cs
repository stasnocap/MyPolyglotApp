using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Domain.Common.Models;
using Domain.Identity;
using Infrastructure.Persistence.Configurations;
using Infrastructure.Persistence.Configurations.Interceptors;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace Infrastructure.Persistence;

public class AppDbContext(DbContextOptions options, PublishDomainEventsInterceptor _publishDomainEventsInterceptor) : IdentityDbContext<User, IdentityRole<Guid>, Guid>(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder
            .Ignore<List<IDomainEvent>>()
            .ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
                
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
    
            
    [SuppressMessage("Usage", "EF1001:Internal EF Core API usage.")]
    public IQueryable<object> GetAll(Type type)
    {
        MethodInfo setSource = GetType() .GetMethod("Microsoft.EntityFrameworkCore.Internal.IDbContextDependencies.get_SetSource", BindingFlags.NonPublic | BindingFlags.Instance)!;

        return (IQueryable<object>)((IDbSetCache)this).GetOrAddSet((IDbSetSource)setSource.Invoke(this, null!)!, type);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.AddInterceptors(_publishDomainEventsInterceptor);
        base.OnConfiguring(optionsBuilder);
    }
}