using Application.Common.Interfaces.Persistence;
using Domain.Exercises;
using Domain.Lessons.Errors;
using MediatR;
using ErrorOr;

namespace Application.Exercises.Queries.GetRandomExercise;

public class GetRandomExerciseQueryHandler(IExerciseRepository _exerciseRepository, ILessonRepository _lessonRepository) : IRequestHandler<GetRandomExerciseQuery, ErrorOr<Exercise>>
{
    public async Task<ErrorOr<Exercise>> Handle(GetRandomExerciseQuery request, CancellationToken cancellationToken)
    {
        if (!await _lessonRepository.ExistsAsync(request.LessonId, cancellationToken))
        {
            return LessonErrors.NotFound;
        }

        var exercise = await _exerciseRepository.GetRandomExerciseAsync(request.LessonId, cancellationToken);

        return exercise;
    }
}