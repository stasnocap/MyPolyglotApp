using MyPolyglotWeb.Models.DomainModels.DomainWords;
using MyPolyglotWeb.Repositories.IRepository.IRepositoryWords;

namespace MyPolyglotWeb.Repositories.RepositoryWords
{
    public class WordRepository : BaseRepository<WordDB>, IWordRepository
    {
        public WordRepository(WebContext webContext) : base(webContext) { }
    }
}
