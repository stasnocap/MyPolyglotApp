using Domain.Practice.Exercises;
using Domain.Practice.Exercises.ValueObjects;
using Domain.Practice.Lessons.ValueObjects;

namespace Application.Common.Interfaces.Persistence.Practice;

public interface IExerciseRepository
{
    Task<Exercise> GetRandomAsync(LessonId lessonId, CancellationToken cancellationToken);
    Task<Exercise?> GetAsync(ExerciseId exerciseId, CancellationToken cancellationToken);
    Task<string?> GetAnswerAsync(ExerciseId exerciseId, CancellationToken cancellationToken);
}