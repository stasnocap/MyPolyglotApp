using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Repositories.IRepository;
using System.Linq;

namespace MyPolyglotWeb.Models
{

    public class LessonRepository : BaseRepository<LessonDB>, ILessonRepository
    {
        public LessonRepository(WebContext webContext) : base(webContext) { }

        public bool IsExistByLessonName(string lessonName)
        {
            return _dbSet.FirstOrDefault(x => x.LessonName == lessonName) != null ? true : false;
        }
    }
}
