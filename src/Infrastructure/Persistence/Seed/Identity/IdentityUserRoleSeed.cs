using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Persistence.Seed.Identity;

public static class IdentityUserRoleSeed
{
    public static IReadOnlyList<IdentityUserRole<Guid>> GetUserRoles()
    {
        var adminRole = new IdentityUserRole<Guid>
        {
            RoleId = IdentityRoleSeed.AdminRoleId,
            UserId = UserSeed.AdminId
        };
        
        return
        [
            adminRole
        ];
    }
}