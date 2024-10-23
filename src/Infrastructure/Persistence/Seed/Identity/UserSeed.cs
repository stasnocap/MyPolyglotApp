using Domain.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Persistence.Seed.Identity;

public static class UserSeed
{
    public static IReadOnlyList<User> GetUsers(IPasswordHasher<User> passwordHasher)
    {
        const string email = "admin@admin.com";
        var normalizedEmail = email.ToUpper();
        var user = new User
        {
            Id = Guid.Parse("af800c3d-717a-48b3-8181-3b432a450f5e"),
            Email = email,
            UserName = email,
            NormalizedEmail = normalizedEmail,
            NormalizedUserName = normalizedEmail,
            EmailConfirmed = true,
            SecurityStamp = nameof(User.SecurityStamp)
        };

        user.PasswordHash = passwordHasher.HashPassword(user, "admin");

        return
        [
            user
        ];
    }
}