using MyPolyglotWeb.Models.DomainModels;

namespace MyPolyglotWeb.Services.IServices
{
    public interface IUserService
    {
        UserDB GetCurrentUser();
    }
}