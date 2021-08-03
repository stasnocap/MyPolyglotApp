using MyPolyglotWeb.Models.DomainModels.DomainWords;
using MyPolyglotWeb.Repositories.IRepository.IRepositoryWords;

namespace MyPolyglotWeb.Repositories.RepositoryWords
{
    public class VerbRepository : BaseRepository<VerbDB>, IVerbRepository
    {
        public VerbRepository(WebContext webContext) : base(webContext) { }
    }
}
