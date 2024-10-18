using Domain.Practice.Lessons;
using Domain.Practice.Lessons.ValueObjects;

namespace Application.Common.Interfaces.Persistence.Practice;

public interface ILessonRepository
{
    Task<bool> ExistsAsync(LessonId lessonId, CancellationToken cancellationToken);
    Task<LessonNumber?> GetLessonNumberAsync(LessonId lessonId, CancellationToken cancellationToken);
    Task<Lesson?> GetAsync(LessonId lessonId, CancellationToken cancellationToken);
}