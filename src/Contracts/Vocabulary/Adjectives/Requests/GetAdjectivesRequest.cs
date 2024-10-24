namespace Contracts.Vocabulary.Adjectives.Requests;

public record GetAdjectivesRequest(int PageNumber, int PageSize, string? SortColumn, string? SortOrder);