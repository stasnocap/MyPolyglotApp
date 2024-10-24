namespace Contracts.Common;

public record PagedList<T>(List<T> Items, int Page, int PageSize, int TotalCount, bool HasNextPage, bool HasPreviousPage, string? SortColumn, string? SortOrder) 
    : Paged(Page, PageSize, TotalCount, SortColumn, SortOrder, HasNextPage, HasPreviousPage);