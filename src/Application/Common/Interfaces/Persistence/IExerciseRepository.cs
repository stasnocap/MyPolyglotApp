using Domain.Exercises;

namespace Application.Common.Interfaces.Persistence;

public interface IExerciseRepository
{
    Task<Exercise> GetRandomExerciseAsync();
}