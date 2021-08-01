using MyPolyglotWeb.Models.DomainModels.Words;
using MyPolyglotWeb.Repositories.IRepository;

namespace MyPolyglotWeb.Repositories
{
    public class WordRepository : BaseRepository<Word>, IWordRepository
    {
        public WordRepository(WebContext webContext) : base(webContext) { }
    }
}
