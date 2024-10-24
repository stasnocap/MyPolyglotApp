using System.Linq.Expressions;

namespace Infrastructure.Persistence.Extensions.Queryable;

public static class OrderByExtensions
{
    public static IQueryable<T> OrderBy<T>(this IQueryable<T> query, string? sortColumn, string? sortOrder)
    {
        if (string.IsNullOrWhiteSpace(sortColumn))
        {
            return query;
        }

        var entityType = typeof(T);

        var propertyInfo = entityType.GetProperty(sortColumn);

        if (propertyInfo is null)
        {
            return query;
        }

        var propertyType = propertyInfo.PropertyType;

        var orderMethodName = sortOrder == "desc"
            ? nameof(System.Linq.Queryable.OrderDescending)
            : nameof(System.Linq.Queryable.OrderBy);

        // x => x.{sortColumn}
        var parameter = Expression.Parameter(entityType);
        var property = Expression.Property(parameter, propertyInfo);
        var lambda = Expression.Lambda(property, parameter);

        var orderByExpression = Expression.Call(
            typeof(System.Linq.Queryable),
            orderMethodName,
            [entityType, propertyType],
            query.Expression,
            lambda
        );

        return query.Provider.CreateQuery<T>(orderByExpression);
    }
}