using AutoMapper;
using Moq;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Presentations;
using MyPolyglotWeb.Repositories.IRepositories;
using MyPolyglotWeb.Services.IServices;
using Xunit;

namespace MyPolyglotWebTests.Presentations.HomePresentationTests
{
    public class PlusPointShould
    {
        private HomePresentation _homePresentation;
        private Mock<IMapper> _mapperMock;
        private Mock<IExerciseRepository> _exerciseRepositoryMock;
        private Mock<IUserService> _userService;
        private Mock<IScoreRepository> _scoreRepository;
        private Mock<ILessonRepository> _lessonRepository;

        public PlusPointShould()
        {
            _mapperMock = new Mock<IMapper>();
            _exerciseRepositoryMock = new Mock<IExerciseRepository>();
            _userService = new Mock<IUserService>();
            _scoreRepository = new Mock<IScoreRepository>();
            _lessonRepository = new Mock<ILessonRepository>();
            _homePresentation = new HomePresentation(_mapperMock.Object, _exerciseRepositoryMock.Object,
                _userService.Object, _scoreRepository.Object, _lessonRepository.Object);
        }

        [Fact]
        public void AddPoint()
        {
            var lessonId = 1;
            var userId = 2;
            var userScorePoints = 3;

            _userService.Setup(x => x.GetCurrentUserId()).Returns(userId);
            var userScoreMock = new Mock<ScoreDB>();
            userScoreMock.Setup(x => x.Points).Returns(userScorePoints);
            _scoreRepository.Setup(x => x.Get(userId, lessonId)).Returns(userScoreMock.Object);

            _homePresentation.PlusPoint(lessonId);

            _userService.Verify(x => x.GetCurrentUserId(), Times.Once);
            userScoreMock.VerifySet(x => x.Points = userScorePoints + 1, Times.Once);
            _scoreRepository.Verify(x => x.Save(userScoreMock.Object), Times.Once);
        }
    }
}
