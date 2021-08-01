using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Repositories.IRepository;

namespace MyPolyglotWeb.Repositories
{
    public class ExerciseRepository : BaseRepository<ExerciseDB>, IExerciseRepository
    {
        public ExerciseRepository(WebContext webContext) : base(webContext) { }
    }
}
