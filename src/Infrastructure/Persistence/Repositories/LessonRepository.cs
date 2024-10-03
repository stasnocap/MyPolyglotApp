using Application.Common.Interfaces.Persistence;
using Domain.Practice.Lessons;
using Domain.Practice.Lessons.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories;

public class LessonRepository(AppDbContext _dbContext) : ILessonRepository
{
    public Task<bool> ExistsAsync(LessonId lessonId, CancellationToken cancellationToken)
    {
        return _dbContext
            .Set<Lesson>()
            .AnyAsync(l => l.Id == lessonId, cancellationToken);
    }
}