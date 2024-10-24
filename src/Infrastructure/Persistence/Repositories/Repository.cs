using System.Linq.Expressions;
using Application.Common;
using Application.Common.Interfaces.Persistence;
using Domain.Common.Models;
using Infrastructure.Persistence.Extensions;
using Infrastructure.Persistence.Extensions.Queryable;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories;

public class Repository<TEntity, TId>(AppDbContext _dbContext) : IRepository<TEntity, TId> 
    where TEntity : Entity<TId>
    where TId : notnull
{
    public async Task<PagedList<TResult>> GetPagedAsync<TResult>(
        int page, 
        int pageSize, 
        string? sortColumn, 
        string? sortOrder,
        Expression<Func<TEntity, TResult>> select,
        CancellationToken cancellationToken)
    {
        var pagedList = await _dbContext
            .Set<TEntity>()
            .AsNoTracking()
            .OrderBy(sortColumn, sortOrder)
            .Select(select)
            .ToPagedListAsync(page, pageSize, sortColumn, sortOrder, cancellationToken);

        return pagedList;
    }
}