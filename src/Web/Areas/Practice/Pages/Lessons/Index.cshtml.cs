using Application.Practice.Exercises.Commands.CompleteExercise;
using Application.Practice.Exercises.Common;
using Application.Practice.Exercises.Queries.GetExercise;
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
    
    public ErrorOr<CompleteExerciseResult>? ErrorOrCompleteExerciseResult { get; private set; }
    
    public Task OnGet([FromRoute] GetRandomExerciseRequest request) => GetRandomExerciseAsync(request);

    public async Task OnPost(CompleteExerciseRequest request)
    {
        var query = _mapper.Map<CompleteExerciseCommand>(request);

        var result = await _sender.Send(query, HttpContext.RequestAborted);

        ErrorOrCompleteExerciseResult = result;

        if (result is { IsError: false, Value.Success: true })
        {
            await GetRandomExerciseAsync(new GetRandomExerciseRequest(request.LessonId));
        }
        else
        {
            await GetExerciseAsync(new GetExerciseRequest(request.ExerciseId, request.LessonId));
        }
    }

    private async Task GetRandomExerciseAsync(GetRandomExerciseRequest request)
    {
        var query = _mapper.Map<GetRandomExerciseQuery>(request);

        ErrorOrExerciseResult = await _sender.Send(query, HttpContext.RequestAborted);
    }

    private async Task GetExerciseAsync(GetExerciseRequest request)
    {
        var query = _mapper.Map<GetExerciseQuery>(request);

        ErrorOrExerciseResult = await _sender.Send(query, HttpContext.RequestAborted);
    }
}