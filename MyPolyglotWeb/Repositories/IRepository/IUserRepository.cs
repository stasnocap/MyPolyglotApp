using MyPolyglotWeb.Models.DomainModels;

namespace MyPolyglotWeb.Repositories.IRepository
{
    public interface IUserRepository : IBaseRepository<UserDB>
    {
        UserDB GetUser(string email, string password);
        bool IsUserExist(string email);
    }
}
