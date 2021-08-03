using MyPolyglotWeb.Models.DomainModels.DomainWords;
using MyPolyglotWeb.Repositories.IRepository.IRepositoryWords;

namespace MyPolyglotWeb.Repositories.RepositoryWords
{
    public class AdjectiveRepository : BaseRepository<AdjectiveDB>, IAdjectiveRepository
    {
        public AdjectiveRepository(WebContext webContext) : base(webContext) { }
    }
}
