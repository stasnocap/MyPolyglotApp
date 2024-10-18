using Domain.Practice.Exercises.ValueObjects;
using Domain.Practice.Lessons.ValueObjects;
using Domain.Practice.Scores;

namespace Application.Common.Interfaces.Persistence.Practice;

public interface IScoreRepository
{
    Task<Score?> GetAsync(LessonId lessonId, Guid userId, CancellationToken cancellationToken);
    void Add(Score score);
}