using Application.Common.Interfaces.Persistence.Practice;
using Domain.Practice.Lessons;
using Domain.Practice.Lessons.ValueObjects;
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
}