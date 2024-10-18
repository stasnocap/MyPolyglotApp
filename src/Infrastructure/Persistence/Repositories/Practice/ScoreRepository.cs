using Application.Common.Interfaces.Persistence.Practice;
using Domain.Practice.Exercises.ValueObjects;
using Domain.Practice.Lessons.ValueObjects;
using Domain.Practice.Scores;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories.Practice;

public class ScoreRepository(AppDbContext _dbContext) : IScoreRepository
{
    public Task<Score?> GetAsync(LessonId lessonId, Guid userId, CancellationToken cancellationToken)
    {
        return _dbContext.Set<Score>()
            .FirstOrDefaultAsync(s => s.LessonId == lessonId && s.UserId == userId, cancellationToken);
    }

    public void Add(Score score) => _dbContext.Set<Score>().Add(score);
}