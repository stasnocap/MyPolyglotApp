using Domain.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Persistence.Seed.Identity;

public static class UserSeed
{
    public static readonly Guid AdminId = Guid.Parse("af800c3d-717a-48b3-8181-3b432a450f5e");
    
    public static IReadOnlyList<User> GetUsers()
    {
        const string email = "admin@admin.com";
        var normalizedEmail = email.ToUpper();
        
        var user = new User
        {
            Id = AdminId,
            Email = email,
            UserName = email,
            NormalizedEmail = normalizedEmail,
            NormalizedUserName = normalizedEmail,
            EmailConfirmed = true,
            SecurityStamp = nameof(User.SecurityStamp),
            PasswordHash = "AQAAAAIAAYagAAAAEISIuwx4yaEzj/8dcZXIjGZE2F5xCxUrTRsb2KlQrgYSZjlYbCkCRECCG05HC8h2mw==",
            ConcurrencyStamp = "4cc9228b-2fa9-4750-af70-9d28c1550373"
        };

        return
        [
            user
        ];
    }
}