using System.Text.Json;
using Application.Practice.Exercises.Commands.CompleteExercise;
using Application.Practice.Exercises.Queries.GetExercise;
using Application.Practice.Exercises.Queries.GetRandomExercise;
using Contracts.Exercises.Requests;
using Contracts.Exercises.Responses;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ErrorOr;

namespace Web.Areas.Practice.Pages.Lessons;

[ValidateAntiForgeryToken]
public class Index(ISender _sender, IMapper _mapper, ILogger<Index> _logger) : PageModel
{
    public ExerciseResponse ExerciseResponse { get; private set; } = null!;

    public CompleteExerciseResponse? CompleteExerciseResponse { get; private set; }
    
    public bool HasErrors { get; private set; }

    public async Task<IActionResult> OnGet([FromRoute] Guid lessonId)
    {
        var completeExerciseResponseJson = TempData[nameof(CompleteExerciseResponse)];

        if (completeExerciseResponseJson is not null)
        {
            CompleteExerciseResponse =  JsonSerializer.Deserialize<CompleteExerciseResponse?>(completeExerciseResponseJson.ToString()!);
        }

        if (CompleteExerciseResponse?.Success ?? true)
        {
            return await GetRandomExerciseAsync(new GetRandomExerciseRequest(lessonId));
        }

        return await GetExerciseAsync(new GetExerciseRequest(CompleteExerciseResponse.ExerciseId, lessonId));
    }

    public async Task<IActionResult> OnPost(CompleteExerciseRequest request)
    {
        var query = _mapper.Map<CompleteExerciseCommand>(request);

        var result = await _sender.Send(query, HttpContext.RequestAborted);

        if (result.IsError)
        {
            LogError(result);
            return Page();
        }

        TempData[nameof(CompleteExerciseResponse)] = JsonSerializer.Serialize(_mapper.Map<CompleteExerciseResponse>(result.Value));
        
        return RedirectToPage();
    }

    private async Task<IActionResult> GetRandomExerciseAsync(GetRandomExerciseRequest request)
    {
        var query = _mapper.Map<GetRandomExerciseQuery>(request);

        var result = await _sender.Send(query, HttpContext.RequestAborted);

        if (result.IsError)
        {
            LogError(result);
            return Page();
        }

        ExerciseResponse = _mapper.Map<ExerciseResponse>(result.Value);

        return Page();
    }

    private async Task<IActionResult> GetExerciseAsync(GetExerciseRequest request)
    {
        var query = _mapper.Map<GetExerciseQuery>(request);
        
        var result = await _sender.Send(query, HttpContext.RequestAborted);

        if (result.IsError)
        {
            LogError(result);
            return Page();
        }

        ExerciseResponse = _mapper.Map<ExerciseResponse>(result.Value);

        return Page();
    }

    private void LogError(IErrorOr errorOr)
    {
        HasErrors = true;
        _logger.LogError(errorOr.ToString());
    }
}