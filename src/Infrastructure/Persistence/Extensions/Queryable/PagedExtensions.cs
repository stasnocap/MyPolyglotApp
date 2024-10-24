using Application.Common;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Extensions.Queryable;

public static class PagedExtensions
{
    public static async Task<PagedList<T>> ToPagedListAsync<T>(this IQueryable<T> query, int page, int pageSize, string? sortColumn, string? sortOrder, CancellationToken cancellationToken)
    {
        var totalCount = await query.CountAsync(cancellationToken);
        
        var items = await query
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync(cancellationToken);
        
        return new PagedList<T>(items, page, pageSize, totalCount, sortColumn, sortOrder);
    }
}