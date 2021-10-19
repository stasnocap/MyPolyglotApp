using AutoMapper;
using Moq;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Presentations;
using MyPolyglotWeb.Repositories.IRepositories;
using Xunit;

namespace MyPolyglotWebTests.Presentations.UserPresentationTests
{
    public class GetUserShould
    {
        private UserPresentation _userPresentation;
        private Mock<IMapper> _mapperMock;
        private Mock<IUserRepository> _userRepository;

        public GetUserShould()
        {
            _mapperMock = new Mock<IMapper>();
            _userRepository = new Mock<IUserRepository>();
            _userPresentation = new UserPresentation(_userRepository.Object, _mapperMock.Object);
        }

        [Fact]
        public void ReturnUser_GivenRightEmailAndPassword()
        {
            var email = "stas@stas.ru";
            var password = "stas";
            var userDB = new UserDB();
            _userRepository.Setup(x => x.GetUser(email, password)).Returns(userDB);

            var user = _userPresentation.GetUser(email, password);

            _userRepository.Verify(x => x.GetUser(email, password), Times.Once);
            Assert.Equal(user, userDB);
        }


        [Fact]
        public void ReturnNull_GivenWrongEmail()
        {
            var email = "wrongstas@stas.ru";
            var password = "stas";
            var userDB = (UserDB)null;
            _userRepository.Setup(x => x.GetUser(email, password)).Returns(userDB);

            var user = _userPresentation.GetUser(email, password);

            _userRepository.Verify(x => x.GetUser(email, password), Times.Once);
            Assert.Equal(user, userDB);
        }

        [Fact]
        public void ReturnNull_GivenWrongPassword()
        {
            var email = "stas@stas.ru";
            var password = "wrongstas";
            var userDB = (UserDB)null;
            _userRepository.Setup(x => x.GetUser(email, password)).Returns(userDB);

            var user = _userPresentation.GetUser(email, password);

            _userRepository.Verify(x => x.GetUser(email, password), Times.Once);
            Assert.Equal(user, userDB);
        }
    }
}
