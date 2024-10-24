using System.Linq.Expressions;
using Domain.Common.Models;

namespace Application.Common.Interfaces.Persistence;

public interface IRepository<TEntity, TId>
    where TEntity : Entity<TId>
    where TId : notnull
{
    Task<PagedList<TResult>> GetPagedAsync<TResult>(
        int page, 
        int pageSize, 
        string? sortColumn, 
        string? sortOrder,
        Expression<Func<TEntity, TResult>> select, 
        CancellationToken cancellationToken);
}