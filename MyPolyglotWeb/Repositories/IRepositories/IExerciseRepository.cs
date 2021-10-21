using MyPolyglotWeb.Models.DomainModels;

namespace MyPolyglotWeb.Repositories.IRepositories
{
    public interface IExerciseRepository : IBaseRepository<ExerciseDB>
    {
        ExerciseDB GetRandomExercise(long lessonId);
        bool IsExist(string engPhrase);
    }
}
