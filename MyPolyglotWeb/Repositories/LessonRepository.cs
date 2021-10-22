using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Repositories.IRepositories;
using System.Linq;

namespace MyPolyglotWeb.Models
{

    public class LessonRepository : BaseRepository<LessonDB>, ILessonRepository
    {
        public LessonRepository(WebContext webContext) : base(webContext) { }

        public bool IsExist(string lessonName)
        {
            return _dbSet.FirstOrDefault(x => x.LessonName == lessonName) != null;
        }
    }
}
