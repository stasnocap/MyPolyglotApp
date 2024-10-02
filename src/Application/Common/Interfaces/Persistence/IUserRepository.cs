using Domain.Users;
using Domain.Users.ValueObjects;

namespace Application.Common.Interfaces.Persistence;

public interface IUserRepository
{
    Task<User?> SingleOrDefaultAsync(Email email, CancellationToken cancellationToken);
    Task<User?> SingleOrDefaultAsync(UserId userId, CancellationToken cancellationToken);
    Task AddAsync(User user, CancellationToken cancellationToken);
}