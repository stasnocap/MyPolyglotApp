using Application.Common.Interfaces.Persistence.Practice;
using Domain.Practice.Exercises;
using Domain.Practice.Lessons.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories.Practice;

public class ExerciseRepository(AppDbContext _dbContext) : IExerciseRepository
{
    public Task<Exercise> GetRandomExerciseAsync(LessonId lessonId, CancellationToken cancellationToken)
    {
        return _dbContext
            .Set<Exercise>()
            .AsNoTracking()
            .Where(x => x.LessonId == lessonId)
            .OrderBy(x => Guid.NewGuid())
            .FirstAsync(cancellationToken);
    }
}