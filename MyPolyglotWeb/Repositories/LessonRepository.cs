using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Repositories.IRepository;

namespace MyPolyglotWeb.Repositories
{
    public class LessonRepository : BaseRepository<LessonDbModel>, ILessonRepository
    {
        public LessonRepository(WebContext webContext) : base(webContext) { }
    }
}
