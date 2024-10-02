using Application.Exercises.Queries.GetRandomExercise;
using Contracts.Exercises.Requests;
using Contracts.Exercises.Responses;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers;

namespace Web.Areas.Exercises.Controllers;

[Route("exercises")]
public class ExercisesController(ISender _sender, IMapper _mapper) : ApiController
{
    [HttpGet("random/{lessonId}")]
    public async Task<IActionResult> GetRandomExercise([FromRoute] GetRandomExerciseRequest request)
    {
        var query = _mapper.Map<GetRandomExerciseQuery>(request);

        var result = await _sender.Send(query, HttpContext.RequestAborted);

        return result.Match(x => Ok(_mapper.Map<ExerciseResponse>(x)), Problem);
    }
}