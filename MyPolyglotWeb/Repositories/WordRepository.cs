using MyPolyglotWeb.Models.DomainModels.Words;
using MyPolyglotWeb.Repositories.IRepository;

namespace MyPolyglotWeb.Repositories
{
    public class WordRepository : BaseRepository<WordDB>, IWordRepository
    {
        public WordRepository(WebContext webContext) : base(webContext) { }
    }
}
