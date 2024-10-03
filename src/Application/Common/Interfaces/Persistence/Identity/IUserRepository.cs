using Domain.Identity;
using Domain.Identity.ValueObjects;

namespace Application.Common.Interfaces.Persistence.Identity;

public interface IUserRepository
{
    Task<User?> SingleOrDefaultAsync(Email email, CancellationToken cancellationToken);
    Task<User?> SingleOrDefaultAsync(UserId userId, CancellationToken cancellationToken);
    Task AddAsync(User user, CancellationToken cancellationToken);
}