using Application.Common.Interfaces.Persistence;

namespace Infrastructure.Persistence;

public class UnitOfWork(AppDbContext _dbContext) : IUnitOfWork
{
    public Task SaveChangesAsync(CancellationToken cancellationToken) => _dbContext.SaveChangesAsync(cancellationToken);
}