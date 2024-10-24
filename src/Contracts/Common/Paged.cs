namespace Contracts.Common;

public abstract record Paged(int Page, int PageSize, int TotalCount, string? SortColumn, string? SortOrder, bool HasNextPage, bool HasPreviousPage);