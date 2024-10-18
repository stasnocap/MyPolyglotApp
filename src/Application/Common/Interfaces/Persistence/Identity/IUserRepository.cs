using Domain.Identity;

namespace Application.Common.Interfaces.Persistence.Identity;

public interface IUserRepository
{
    Task<User?> GetAsync(Guid userId, CancellationToken cancellationToken);
}