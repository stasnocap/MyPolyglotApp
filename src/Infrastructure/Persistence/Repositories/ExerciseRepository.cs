using Application.Common.Interfaces.Persistence;
using Domain.Exercises;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories;

public class ExerciseRepository(AppDbContext _dbContext) : IExerciseRepository
{
    public Task<Exercise> GetRandomExerciseAsync()
    {
        return _dbContext
            .Set<Exercise>()
            .AsNoTracking()
            .OrderBy(x => Guid.NewGuid())
            .FirstAsync();
    }
}