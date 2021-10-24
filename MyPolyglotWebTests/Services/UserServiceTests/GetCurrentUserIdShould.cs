using Microsoft.AspNetCore.Http;
using Moq;
using MyPolyglotWeb.Repositories.IRepositories;
using MyPolyglotWeb.Services;
using MyPolyglotWeb.Services.IServices;
using System.Security.Claims;
using Xunit;

namespace MyPolyglotWebTests.Services.UserServiceTests
{
    public class GetCurrentUserIdShould
    {
        private IUserService _userService;
        private Mock<IUserRepository> _userRepository;
        private Mock<IHttpContextAccessor> _httpContextAccessor;

        public GetCurrentUserIdShould()
        {
            _userRepository = new Mock<IUserRepository>();
            _httpContextAccessor = new Mock<IHttpContextAccessor>();
            _userService = new UserService(_userRepository.Object, _httpContextAccessor.Object); ;
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

            _userService.GetCurrentUserId();

            _httpContextAccessor.Verify(x => x.HttpContext.User.FindFirst("Id"), Times.Once);
        }

        [Fact]
        public void ReturnParsedIdFromClaim_IfUserLoggedIn()
        {
            var idStr = "1";
            var httpContextMock = new Mock<HttpContext>();
            var claimsPrincipalMock = new Mock<ClaimsPrincipal>();
            var idClaim = new Claim("Id", idStr);

            claimsPrincipalMock.Setup(x => x.FindFirst("Id")).Returns(idClaim);
            httpContextMock.Setup(x => x.User).Returns(claimsPrincipalMock.Object);
            _httpContextAccessor.Setup(x => x.HttpContext).Returns(httpContextMock.Object);

            var userId = _userService.GetCurrentUserId();

            Assert.Equal(long.Parse(idStr), userId);
        }

        [Fact]
        public void ReturnMinusOne_IfUserNotLoggedIn()
        {
            var httpContextMock = new Mock<HttpContext>();
            var claimsPrincipalMock = new Mock<ClaimsPrincipal>();

            claimsPrincipalMock.Setup(x => x.FindFirst("Id")).Returns((Claim)null);
            httpContextMock.Setup(x => x.User).Returns(claimsPrincipalMock.Object);
            _httpContextAccessor.Setup(x => x.HttpContext).Returns(httpContextMock.Object);

            var userId = _userService.GetCurrentUserId();

            Assert.Equal(-1, userId);
        }
    }
}
