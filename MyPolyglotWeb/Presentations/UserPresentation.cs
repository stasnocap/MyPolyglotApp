using AutoMapper;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Models.ViewModels;
using MyPolyglotWeb.Repositories.IRepositories;
using System.Security.Claims;

namespace MyPolyglotWeb.Presentations
{
    public class UserPresentation
    {
        private IUserRepository _userRepository;
        private IMapper _mapper;

        public UserPresentation(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public void Register(RegisterUserVM registerUserVM)
        {
            var userDB = _mapper.Map<UserDB>(registerUserVM);
            userDB.Role = UserRole.User;
            _userRepository.Save(userDB);
        }

        public UserDB GetUser(string email, string password)
        {
            return _userRepository.GetUser(email, password);
        }

        public bool IsUserExist(string email)
        {
            return _userRepository.IsUserExist(email);
        }

        public ClaimsPrincipal GetLoginClaims(string email, string password)
        {
            var user = _userRepository.GetUser(email, password);

            var claims = new Claim[]
            {
                new Claim("Id", user.Id.ToString()),
            };

            var claimsIdentity = new ClaimsIdentity(claims, Startup.AuthMethod);

            return new ClaimsPrincipal(claimsIdentity);
        }
    }
}
