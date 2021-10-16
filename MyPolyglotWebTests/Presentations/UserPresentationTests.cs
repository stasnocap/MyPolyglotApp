using AutoMapper;
using Moq;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Models.ViewModels;
using MyPolyglotWeb.Presentations;
using MyPolyglotWeb.Repositories.IRepositories;
using Xunit;

namespace MyPolyglotWebTests.Presentations
{
    public class UserPresentationTests
    {
        private UserPresentation _userPresentation;
        private Mock<IMapper> _mapperMock;
        private Mock<IUserRepository> _userRepository;

        public UserPresentationTests()
        {
            _mapperMock = new Mock<IMapper>();
            _userRepository = new Mock<IUserRepository>();
            _userPresentation = new UserPresentation(_userRepository.Object, _mapperMock.Object);
        }

        [Fact]
        public void Register()
        {
            var registerUserVMMock = new Mock<RegisterUserVM>();
            var userDBMock = new Mock<UserDB>();
            _mapperMock.Setup(x => x.Map<UserDB>(registerUserVMMock.Object)).Returns(userDBMock.Object);

            _userPresentation.Register(registerUserVMMock.Object);

            userDBMock.VerifySet(x => x.Role = UserRole.User);
            _mapperMock.Verify(x => x.Map<UserDB>(registerUserVMMock.Object), Times.Once);
            _userRepository.Verify(x => x.Save(userDBMock.Object), Times.Once);
        }

        [Fact]
        public void GetUser()
        {
            var email = "stas@stas.ru";
            var password = "stas";
            var userDBMock = new Mock<UserDB>();
            _userRepository.Setup(x => x.GetUser(email, password)).Returns(userDBMock.Object);

            var user = _userPresentation.GetUser(email, password);

            _userRepository.Verify(x => x.GetUser(email, password), Times.Once);
            Assert.Equal(user, userDBMock.Object);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void IsUserExist(bool existence)
        {
            var email = "stas@stas.ru";
            _userRepository.Setup(x => x.IsUserExist(email)).Returns(existence);

            var answer = _userPresentation.IsUserExist(email);

            _userRepository.Verify(x => x.IsUserExist(email), Times.Once);
            Assert.Equal(answer, existence);
        }

        [Fact]
        public void GetLoginClaims()
        {
            var email = "stas@stas.ru";
            var password = "stas";
            var userDBMock = new Mock<UserDB>();
            userDBMock.Setup(x => x.Id).Returns(1);
            _userRepository.Setup(x => x.GetUser(email, password)).Returns(userDBMock.Object);

            var claimsPrincipal = _userPresentation.GetLoginClaims(email, password);

            _userRepository.Verify(x => x.GetUser(email, password), Times.Once);
            Assert.Equal(claimsPrincipal.FindFirst("Id").Value, userDBMock.Object.Id.ToString());
        }
    }
}
