using Application.Common.Interfaces.Persistence;
using Domain.Identity;
using Domain.Identity.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories;

public class UserRepository(AppDbContext _dbContext) : IUserRepository
{
    public Task<User?> SingleOrDefaultAsync(Email email, CancellationToken cancellationToken)
    {
        // return _dbContext
        //     .Set<User>()
        //     .SingleOrDefaultAsync(x => x.Email == email, cancellationToken);
        return null!;
    }

    public Task<User?> SingleOrDefaultAsync(UserId userId, CancellationToken cancellationToken)
    {
        return null!;

        // return _dbContext
        //     .Set<User>()
        //     .SingleOrDefaultAsync(x => x.Id == userId, cancellationToken);
    }

    public Task AddAsync(User user, CancellationToken cancellationToken)
    {
        return null!;

        // _dbContext
        //     .Set<User>()
        //     .Add(user);
        //
        // return _dbContext.SaveChangesAsync(cancellationToken);
    }
}