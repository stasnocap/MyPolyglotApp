using Application.Practice.Lessons.Common;
using Application.Practice.Lessons.Queries.GetLessons;
using Contracts.Practice.Lessons;
using Infrastructure.Persistence.Seed.Identity;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Areas.Practice.Pages;

public class Index(ISender _sender, IMapper _mapper) : PageModel
{
    public IReadOnlyList<LessonResponse> Lessons { get; private set; } = null!;
    
    public async Task OnGet()
    {
        var query = new GetLessonsQuery();
        
        var result = await _sender.Send(query, HttpContext.RequestAborted);

        Lessons = _mapper.Map<IReadOnlyList<LessonResponse>>(result);
    }
}