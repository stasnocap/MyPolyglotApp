using Microsoft.AspNetCore.Http;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Repositories.IRepositories;
using MyPolyglotWeb.Services.IServices;

namespace MyPolyglotWeb.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        private IHttpContextAccessor _httpContextAccessor;

        public UserService(IUserRepository userRepository, IHttpContextAccessor httpContextAccessor)
        {
            _userRepository = userRepository;
            _httpContextAccessor = httpContextAccessor;
        }

        public UserDB GetCurrentUser()
        {
            var id = GetCurrentUserId();

            if (id == -1)
            {
                return null;
            }

            return _userRepository.Get(id);
        }

        public long GetCurrentUserId()
        {
            var idStr = _httpContextAccessor.HttpContext.User.FindFirst("Id")?.Value;
            return long.TryParse(idStr, out long result) ? result : -1;
        }
    }
}
