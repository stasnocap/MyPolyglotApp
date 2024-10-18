using Application.Common.Interfaces.Persistence.Practice;
using Application.Practice.Exercises.Common;
using Domain.Practice.Exercises.Errors;
using Domain.Practice.Lessons.Errors;
using ErrorOr;
using MediatR;

namespace Application.Practice.Exercises.Queries.GetExercise;

public class GetExerciseQueryHandler(
    IExerciseRepository _exerciseRepository,
    ILessonRepository _lessonRepository,
    ExerciseConverter _exerciseConverter) : IRequestHandler<GetExerciseQuery, ErrorOr<ExerciseResult>>
{
    public async Task<ErrorOr<ExerciseResult>> Handle(GetExerciseQuery request, CancellationToken cancellationToken)
    {
        var errors = new List<Error>();
        
        var exercise = await _exerciseRepository.GetAsync(request.ExerciseId, cancellationToken);

        if (exercise is null)
        {
            errors.Add(ExerciseErrors.NotFound);
        }

        var lessonNumber = await _lessonRepository.GetLessonNumberAsync(request.LessonId, cancellationToken);
        
        if (lessonNumber is null)
        {
            errors.Add(LessonErrors.NotFound);
        }

        if (errors.Count > 0)
        {
            return errors;
        }

        var exerciseResult = await _exerciseConverter.ConvertAsync(exercise!, lessonNumber!, cancellationToken);

        return exerciseResult;
    }
}