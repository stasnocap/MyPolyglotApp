using AutoMapper;
using Moq;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Presentations;
using MyPolyglotWeb.Repositories.IRepositories;
using System.Security.Claims;
using Xunit;

namespace MyPolyglotWebTests.Presentations.UserPresentationTests
{
    public class GetLoginClaimsShould
    {
        private UserPresentation _userPresentation;
        private Mock<IMapper> _mapperMock;
        private Mock<IUserRepository> _userRepository;

        public GetLoginClaimsShould()
        {
            _mapperMock = new Mock<IMapper>();
            _userRepository = new Mock<IUserRepository>();
            _userPresentation = new UserPresentation(_userRepository.Object, _mapperMock.Object);
        }

        [Fact]
        public void GetUserFromRepository()
        {
            var email = "stas@stas.ru";
            var password = "stas";
            var userDB = new UserDB();
            _userRepository.Setup(x => x.GetUser(email, password)).Returns(userDB);

            var claimsPrincipal = _userPresentation.GetLoginClaims(email, password);

            _userRepository.Verify(x => x.GetUser(email, password), Times.Once);
        }

        [Fact]
        public void ContainsUserIdClaim()
        {
            var email = "stas@stas.ru";
            var password = "stas";
            var userDB = new UserDB()
            {
                Id = 1
            };
            _userRepository.Setup(x => x.GetUser(email, password)).Returns(userDB);

            var claimsPrincipal = _userPresentation.GetLoginClaims(email, password);

            Assert.Equal(claimsPrincipal.FindFirst("Id").Value, userDB.Id.ToString());
        }

        [Fact]
        public void ContainsUserRoleClaim()
        {
            var email = "stas@stas.ru";
            var password = "stas";
            var userDB = new UserDB()
            {
                Role = UserRole.User
            };
            _userRepository.Setup(x => x.GetUser(email, password)).Returns(userDB);

            var claimsPrincipal = _userPresentation.GetLoginClaims(email, password);

            Assert.Equal(claimsPrincipal.FindFirst(ClaimTypes.Role).Value, userDB.Role.ToString());
        }
    }
}
