using AutoMapper;
using Moq;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Models.ViewModels;
using MyPolyglotWeb.Presentations;
using MyPolyglotWeb.Repositories.IRepositories;
using Xunit;

namespace MyPolyglotWebTests.Presentations.UserPresentationTests
{
    public class RegisterShould
    {
        private UserPresentation _userPresentation;
        private Mock<IMapper> _mapperMock;
        private Mock<IUserRepository> _userRepository;

        public RegisterShould()
        {
            _mapperMock = new Mock<IMapper>();
            _userRepository = new Mock<IUserRepository>();
            _userPresentation = new UserPresentation(_userRepository.Object, _mapperMock.Object);
        }

        [Fact]
        public void SaveUserToRepository()
        {
            var registerUserVM = new RegisterUserVM();
            var userDB = new UserDB();
            _mapperMock.Setup(x => x.Map<UserDB>(registerUserVM)).Returns(userDB);

            _userPresentation.Register(registerUserVM);

            _userRepository.Verify(x => x.Save(userDB), Times.Once);
        }

        [Fact]
        public void MapUserVMtoUserDB()
        {
            var registerUserVM = new RegisterUserVM();
            var userDB = new UserDB();
            _mapperMock.Setup(x => x.Map<UserDB>(registerUserVM)).Returns(userDB);

            _userPresentation.Register(registerUserVM);

            _mapperMock.Verify(x => x.Map<UserDB>(registerUserVM), Times.Once);
        }

        [Fact]
        public void SetUserRoleToUser()
        {
            var registerUserVM = new RegisterUserVM();
            var userDBMock = new Mock<UserDB>();
            _mapperMock.Setup(x => x.Map<UserDB>(registerUserVM)).Returns(userDBMock.Object);

            _userPresentation.Register(registerUserVM);

            userDBMock.VerifySet(x => x.Role = UserRole.User);
        }
    }
}
