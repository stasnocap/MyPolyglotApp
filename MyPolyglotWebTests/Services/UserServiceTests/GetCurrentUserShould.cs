using Microsoft.AspNetCore.Http;
using Moq;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Repositories.IRepositories;
using MyPolyglotWeb.Services;
using MyPolyglotWeb.Services.IServices;
using System.Security.Claims;
using Xunit;

namespace MyPolyglotWebTests.Services.UserServiceTests
{
    public class GetCurrentUserShould
    {
        private IUserService _userService;
        private Mock<IUserRepository> _userRepository;
        private Mock<IHttpContextAccessor> _httpContextAccessor;

        public GetCurrentUserShould()
        {
            _userRepository = new Mock<IUserRepository>();
            _httpContextAccessor = new Mock<IHttpContextAccessor>();
            _userService = new UserService(_userRepository.Object, _httpContextAccessor.Object); ;
        }

        [Fact]
        public void GetUserFromRepository_IfIdIsNotMinusOne()
        {
            var idStr = "1";
            var httpContextMock = new Mock<HttpContext>();
            var claimsPrincipalMock = new Mock<ClaimsPrincipal>();
            var idClaim = new Claim("Id", idStr);

            claimsPrincipalMock.Setup(x => x.FindFirst("Id")).Returns(idClaim);
            httpContextMock.Setup(x => x.User).Returns(claimsPrincipalMock.Object);
            _httpContextAccessor.Setup(x => x.HttpContext).Returns(httpContextMock.Object);

            _userService.GetCurrentUser();

            _userRepository.Verify(x => x.Get(long.Parse(idStr)), Times.Once);
        }

        [Fact]
        public void ReturnUser_IfIdIsNotMinusOne()
        {
            var idStr = "1";
            var httpContextMock = new Mock<HttpContext>();
            var claimsPrincipalMock = new Mock<ClaimsPrincipal>();
            var idClaim = new Claim("Id", idStr);
            var user = new UserDB();

            claimsPrincipalMock.Setup(x => x.FindFirst("Id")).Returns(idClaim);
            httpContextMock.Setup(x => x.User).Returns(claimsPrincipalMock.Object);
            _httpContextAccessor.Setup(x => x.HttpContext).Returns(httpContextMock.Object);
            _userRepository.Setup(x => x.Get(long.Parse(idStr))).Returns(user);

            var result = _userService.GetCurrentUser();

            Assert.Equal(user, result);
        }

        [Fact]
        public void ReturnNull_IfIdIsMinusOne()
        {
            var httpContextMock = new Mock<HttpContext>();
            var claimsPrincipalMock = new Mock<ClaimsPrincipal>();

            claimsPrincipalMock.Setup(x => x.FindFirst("Id")).Returns((Claim)null);
            httpContextMock.Setup(x => x.User).Returns(claimsPrincipalMock.Object);
            _httpContextAccessor.Setup(x => x.HttpContext).Returns(httpContextMock.Object);

            var user = _userService.GetCurrentUser();

            Assert.Null(user);
        }

        [Fact]
        public void FindUserIdFromClaims()
        {
            var httpContextMock = new Mock<HttpContext>();
            var claimsPrincipalMock = new Mock<ClaimsPrincipal>();
            var idClaim = new Claim("Id", "1");

            claimsPrincipalMock.Setup(x => x.FindFirst("Id")).Returns(idClaim);
            httpContextMock.Setup(x => x.User).Returns(claimsPrincipalMock.Object);
            _httpContextAccessor.Setup(x => x.HttpContext).Returns(httpContextMock.Object);

            _userService.GetCurrentUser();

            _httpContextAccessor.Verify(x => x.HttpContext.User.FindFirst("Id"), Times.Once);
        }
    }
}
