using AutoMapper;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Models.ViewModels;
using MyPolyglotWeb.Repositories.IRepository;
using System;

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
    }
}
