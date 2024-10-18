using Application.Common.Interfaces.Persistence.Identity;
using Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories.Identity;

public class UserRepository(UserManager<User> _userManager) : IUserRepository
{
    public Task<User?> GetAsync(Guid userId, CancellationToken cancellationToken)
    {
        return _userManager.Users
            .Where(u => u.Id == userId)
            .FirstOrDefaultAsync(cancellationToken);
    }
}