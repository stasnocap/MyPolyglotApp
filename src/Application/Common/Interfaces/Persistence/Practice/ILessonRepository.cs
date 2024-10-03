using Domain.Practice.Lessons.ValueObjects;

namespace Application.Common.Interfaces.Persistence.Practice;

public interface ILessonRepository
{
    Task<bool> ExistsAsync(LessonId lessonId, CancellationToken cancellationToken);
}