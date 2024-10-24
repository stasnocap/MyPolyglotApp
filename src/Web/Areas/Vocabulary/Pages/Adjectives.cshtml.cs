using Application.Vocabulary.Adjectives.Queries.GetAdjectives;
using Contracts.Common;
using Contracts.Vocabulary.Adjectives.Requests;
using Contracts.Vocabulary.Adjectives.Responses;
using Infrastructure.Persistence.Seed.Identity;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Areas.Vocabulary.Pages;

[Authorize(Roles = IdentityRoleSeed.AdminRole)]
public class Adjectives(ISender _sender, IMapper _mapper) : PageModel
{
    public PagedList<AdjectiveResponse> AdjectivesPagedList { get; private set; }
    
    public async Task OnGet([FromQuery] GetAdjectivesRequest request)
    {
        var query = _mapper.Map<GetAdjectivesQuery>(request);

        var result = await _sender.Send(query, HttpContext.RequestAborted);

        AdjectivesPagedList = _mapper.Map<PagedList<AdjectiveResponse>>(result);
    }
}