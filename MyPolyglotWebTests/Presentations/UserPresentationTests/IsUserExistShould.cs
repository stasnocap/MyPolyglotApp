using AutoMapper;
using Moq;
using MyPolyglotWeb.Presentations;
using MyPolyglotWeb.Repositories.IRepositories;
using Xunit;

namespace MyPolyglotWebTests.Presentations.UserPresentationTests
{
    public class IsUserExistShould
    {
        private UserPresentation _userPresentation;
        private Mock<IMapper> _mapperMock;
        private Mock<IUserRepository> _userRepository;

        public IsUserExistShould()
        {
            _mapperMock = new Mock<IMapper>();
            _userRepository = new Mock<IUserRepository>();
            _userPresentation = new UserPresentation(_userRepository.Object, _mapperMock.Object);
        }

        [Fact]
        public void ReturnTrue_WhenUserExistInRepository()
        {
            var email = "stas@stas.ru";
            _userRepository.Setup(x => x.IsUserExist(email)).Returns(true);

            var answer = _userPresentation.IsUserExist(email);

            _userRepository.Verify(x => x.IsUserExist(email), Times.Once);
            Assert.True(answer);
        }

        [Fact]
        public void ReturnFalse_WhenUserNotExistInRepository()
        {
            var email = "wrongstas@stas.ru";
            _userRepository.Setup(x => x.IsUserExist(email)).Returns(false);

            var answer = _userPresentation.IsUserExist(email);

            _userRepository.Verify(x => x.IsUserExist(email), Times.Once);
            Assert.False(answer);
        }
    }
}
