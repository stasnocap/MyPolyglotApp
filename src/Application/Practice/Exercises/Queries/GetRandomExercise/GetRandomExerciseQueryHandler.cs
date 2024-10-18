using Application.Common.Interfaces.Persistence.Practice;
using Application.Common.Interfaces.Persistence.Vocabulary;
using Application.Practice.Exercises.Common;
using Domain.Practice.Exercises.Services;
using Domain.Practice.Lessons.Errors;
using ErrorOr;
using MediatR;

namespace Application.Practice.Exercises.Queries.GetRandomExercise;

public class GetRandomExerciseQueryHandler(
    IExerciseRepository _exerciseRepository, 
    ILessonRepository _lessonRepository,
    ExerciseConverter _exerciseConverter) : IRequestHandler<GetRandomExerciseQuery, ErrorOr<ExerciseResult>>
{
    
    public async Task<ErrorOr<ExerciseResult>> Handle(GetRandomExerciseQuery request, CancellationToken cancellationToken)
    {
        var lessonNumber = await _lessonRepository.GetLessonNumberAsync(request.LessonId, cancellationToken);
        
        if (lessonNumber is null)
        {
            return LessonErrors.NotFound;
        }

        var exercise = await _exerciseRepository.GetRandomAsync(request.LessonId, cancellationToken);

        var exerciseResult = await _exerciseConverter.ConvertAsync(exercise, lessonNumber, cancellationToken);

        return exerciseResult;
    }
}