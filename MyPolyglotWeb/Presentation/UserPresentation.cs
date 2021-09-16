using AutoMapper;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Models.ViewModels;
using MyPolyglotWeb.Repositories.IRepository;
using System;
using System.Security.Claims;

namespace MyPolyglotWeb.Presentation
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

        public ClaimsPrincipal GetLoginClaims(LoginVM loginVM)
        {
            var user = _userRepository.GetUser(loginVM.Email, loginVM.Password);

            var claims = new Claim[]
            {
                new Claim("Id", user.Id.ToString()),
            };

            var claimsIdentity = new ClaimsIdentity(claims, Startup.AuthMethod);

            return new ClaimsPrincipal(claimsIdentity);
        }
    }
}
