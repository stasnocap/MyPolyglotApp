using MyPolyglotWeb.Models;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Repositories.IRepositories;

namespace MyPolyglotWeb.Repositories
{
    public class UnrecognizedWordRepository : BaseRepository<UnrecognizedWordDB>, IUnrecognizedWordRepository
    {
        public UnrecognizedWordRepository(WebContext webContext) : base(webContext)
        {
        }
    }
}
