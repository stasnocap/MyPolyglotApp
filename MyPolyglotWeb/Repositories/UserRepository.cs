using MyPolyglotWeb.Models;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Repositories.IRepository;
using System.Linq;

namespace MyPolyglotWeb.Repositories
{
    public class UserRepository : BaseRepository<UserDB>, IUserRepository
    {
        public UserRepository(WebContext webContext) : base(webContext) { }

        public UserDB GetUser(string email, string password)
        {
            return _dbSet.FirstOrDefault(x => x.Email == email && x.Password == password);
        }

        public bool IsUserExist(string email)
        {
            return _dbSet.FirstOrDefault(x => x.Email == email) != null;
        }
    }
}
