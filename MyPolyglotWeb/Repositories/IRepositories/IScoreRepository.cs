using MyPolyglotWeb.Models.DomainModels;

namespace MyPolyglotWeb.Repositories.IRepositories
{
    public interface IScoreRepository : IBaseRepository<ScoreDB>
    {
        ScoreDB Get(long userId, long lessonId);
    }
}
