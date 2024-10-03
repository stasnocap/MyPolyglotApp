using Domain.Exercises;
using Domain.Lessons.ValueObjects;

namespace Application.Common.Interfaces.Persistence;

public interface IExerciseRepository
{
    Task<Exercise> GetRandomExerciseAsync(LessonId lessonId, CancellationToken cancellationToken);
}