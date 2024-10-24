using Application.Common;
using Application.Vocabulary.Adjectives.Common;
using MediatR;

namespace Application.Vocabulary.Adjectives.Queries.GetAdjectives;

public record GetAdjectivesQuery(int Page, int PageSize, string? SortColumn, string? SortOrder) : IRequest<PagedList<AdjectiveResult>>;