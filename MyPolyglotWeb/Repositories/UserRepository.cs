using MyPolyglotWeb.Models;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Repositories.IRepository;

namespace MyPolyglotWeb.Repositories
{
    public class UserRepository : BaseRepository<UserDB>, IUserRepository
    {
        public UserRepository(WebContext webContext) : base(webContext) { }
    }
}
