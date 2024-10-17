using Application.Practice.Exercises.Common;
using Application.Practice.Exercises.Queries.GetRandomExercise;
using Contracts.Exercises.Requests;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ErrorOr;

namespace Web.Areas.Practice.Pages.Lessons;

public class Index(ISender _sender, IMapper _mapper) : PageModel
{
    public ErrorOr<ExerciseResult> ErrorOrExerciseResult { get; private set; }
    
    public async Task OnGet([FromRoute] GetRandomExerciseRequest request)
    {
        var query = _mapper.Map<GetRandomExerciseQuery>(request);

        ErrorOrExerciseResult = await _sender.Send(query, HttpContext.RequestAborted);
    }
}