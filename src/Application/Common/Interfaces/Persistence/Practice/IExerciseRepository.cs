using Domain.Practice.Exercises;
using Domain.Practice.Lessons.ValueObjects;

namespace Application.Common.Interfaces.Persistence.Practice;

public interface IExerciseRepository
{
    Task<Exercise> GetRandomExerciseAsync(LessonId lessonId, CancellationToken cancellationToken);
}