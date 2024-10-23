using Application.Common.Interfaces.Persistence.Practice;
using Application.Practice.Lessons.Common;
using Domain.Practice.Lessons;
using Domain.Practice.Lessons.ValueObjects;
using Domain.Practice.Scores;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories.Practice;

public class LessonRepository(AppDbContext _dbContext) : ILessonRepository
{
    public Task<bool> ExistsAsync(LessonId lessonId, CancellationToken cancellationToken)
    {
        return _dbContext
            .Set<Lesson>()
            .AnyAsync(l => l.Id == lessonId, cancellationToken);
    }
    
    public Task<LessonNumber?> GetLessonNumberAsync(LessonId lessonId, CancellationToken cancellationToken)
    {
        return _dbContext
            .Set<Lesson>()
            .Where(l => l.Id == lessonId)
            .Select(l => l.Number)
            .FirstOrDefaultAsync(cancellationToken);
    }

    public Task<Lesson?> GetAsync(LessonId lessonId, CancellationToken cancellationToken)
    {
        return _dbContext
            .Set<Lesson>()
            .FirstOrDefaultAsync(l => l.Id == lessonId, cancellationToken);
    }

    public Task<List<LessonResult>> GetRangeAsync(Guid? userId, CancellationToken cancellationToken)
    {
        return _dbContext
            .Set<Lesson>()
            .OrderBy(l => l.Number)
            .Select(l => new LessonResult(l.Id, l.Number, l.Name, 
                userId != null 
                ? _dbContext.Set<Score>().First(s => s.LessonId == l.Id && s.UserId == userId).Rating.Rate
                : null))
            .ToListAsync(cancellationToken);
    }
}