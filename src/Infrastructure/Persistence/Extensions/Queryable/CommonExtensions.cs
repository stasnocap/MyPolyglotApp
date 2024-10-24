﻿using System.Linq.Expressions;

namespace Infrastructure.Persistence.Extensions.Queryable;

public static class CommonExtensions
{
    public static IQueryable<T> WhereIf<T>(this IQueryable<T> queryable, bool condition, Expression<Func<T, bool>> predicate)
    {
        if (condition)
        {
            return queryable.Where(predicate);
        }

        return queryable;
    }
}