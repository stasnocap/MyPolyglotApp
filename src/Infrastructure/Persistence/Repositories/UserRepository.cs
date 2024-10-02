using Application.Common.Interfaces.Persistence;
using Domain.Users;
using Domain.Users.ValueObjects;

namespace Infrastructure.Persistence.Repositories;

public class UserRepository : IUserRepository
{
    public Task<User?> SingleOrDefaultAsync(string email, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<User?> SingleOrDefaultAsync(UserId userId, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(User user, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}