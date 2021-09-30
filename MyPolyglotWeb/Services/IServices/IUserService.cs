using MyPolyglotWeb.Models.DomainModels;
using System.Diagnostics.Eventing.Reader;

namespace MyPolyglotWeb.Services.IServices
{
    public interface IUserService
    {
        UserDB GetCurrentUser();
        long GetCurrentUserId();
    }
}