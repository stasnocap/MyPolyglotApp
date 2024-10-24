using Application.Common;
using Application.Common.Interfaces.Persistence;
using Application.Vocabulary.Adjectives.Common;
using Domain.Vocabulary.Adjectives;
using Domain.Vocabulary.Adjectives.ValueObjects;
using MediatR;

namespace Application.Vocabulary.Adjectives.Queries.GetAdjectives;

public class GetAdjectivesQueryHandler(IRepository<Adjective, AdjectiveId> _repository) : IRequestHandler<GetAdjectivesQuery, PagedList<AdjectiveResult>>
{
    public async Task<PagedList<AdjectiveResult>> Handle(GetAdjectivesQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetPagedAsync(
            request.Page, 
            request.PageSize,
            request.SortColumn, 
            request.SortOrder,
            a => new AdjectiveResult(a.Id, a.Text),
            cancellationToken);

        return result;
    }
}