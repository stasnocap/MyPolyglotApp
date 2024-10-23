using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Persistence.Seed.Identity;

public static class IdentityRoleSeed
{
    public const string AdminRole = "admin";
    public static readonly Guid AdminRoleId = Guid.Parse("978a8de7-9ab5-4d52-84f8-59e7ebb48ae7");
    
    public static IReadOnlyList<IdentityRole<Guid>> GetRoles()
    {
        var role = new IdentityRole<Guid>()
        {
            Id = AdminRoleId,
            Name = AdminRole,
            NormalizedName = AdminRole.ToUpper(),
            ConcurrencyStamp = "d7e5d09c-a389-4773-82f7-043d780069aa"
        };
        
        return
        [
            role
        ];
    }
}