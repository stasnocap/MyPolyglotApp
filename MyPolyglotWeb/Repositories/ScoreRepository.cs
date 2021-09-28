using MyPolyglotWeb.Models;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Repositories.IRepositories;
using System.Linq;

namespace MyPolyglotWeb.Repositories
{
    public class ScoreRepository : BaseRepository<ScoreDB>, IScoreRepository
    {
        public ScoreRepository(WebContext webContext) : base(webContext) { }

        public ScoreDB Get(long userId, long lessonId)
        {
            return _dbSet.SingleOrDefault(x => x.User.Id == userId && x.Lesson.Id == lessonId);
        }
    }
}
