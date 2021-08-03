using MyPolyglotWeb.Models.DomainModels.DomainWords;
using MyPolyglotWeb.Repositories.IRepository.IRepositoryWords;

namespace MyPolyglotWeb.Repositories.RepositoryWords
{
    public class NounRepository : BaseRepository<NounDB>, INounRepository
    {
        public NounRepository(WebContext webContext) : base(webContext) { }
    }
}
