using Application.Common.Interfaces.Persistence.Practice;
using Domain.Practice.Exercises;
using Domain.Practice.Exercises.ValueObjects;
using Domain.Practice.Lessons.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories.Practice;

public class ExerciseRepository(AppDbContext _dbContext) : IExerciseRepository
{
    public Task<Exercise> GetRandomAsync(LessonId lessonId, CancellationToken cancellationToken)
    {
        return _dbContext
            .Set<Exercise>()
            .AsNoTracking()
            .Where(e =>  e.LessonIds.Select(lId => lId.Value).Contains(lessonId.Value))
            .OrderBy(x => Guid.NewGuid())
            .FirstAsync(cancellationToken);
    }

    public Task<Exercise?> GetAsync(ExerciseId exerciseId, CancellationToken cancellationToken)
    {
        return _dbContext
            .Set<Exercise>()
            .AsNoTracking()
            .Where(e =>  e.Id == exerciseId)
            .FirstOrDefaultAsync(cancellationToken);
    }

    public Task<string?> GetAnswerAsync(ExerciseId exerciseId, CancellationToken cancellationToken)
    {
        return _dbContext
            .Set<Exercise>()
            .AsNoTracking()
            .Where(e => e.Id == exerciseId)
            .Select(e => string.Join(' ', e.Words.OrderBy(w => (int)w.Number).Select(w => (string)w.Text)))
            .FirstOrDefaultAsync(cancellationToken);
    }
}