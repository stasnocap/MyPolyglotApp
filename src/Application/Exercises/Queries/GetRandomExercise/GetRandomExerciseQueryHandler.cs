using Application.Common.Interfaces.Persistence;
using Domain.Exercises;
using MediatR;
using ErrorOr;

namespace Application.Exercises.Queries.GetRandomExercise;

public class GetRandomExerciseQueryHandler(IExerciseRepository _exerciseRepository) : IRequestHandler<GetRandomExerciseQuery, ErrorOr<Exercise>>
{
    public async Task<ErrorOr<Exercise>> Handle(GetRandomExerciseQuery request, CancellationToken cancellationToken)
    {
        var exercise = await _exerciseRepository.GetRandomExerciseAsync();
        return exercise;
    }
}