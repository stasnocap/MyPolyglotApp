using AutoMapper;
using Moq;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Presentations;
using MyPolyglotWeb.Repositories.IRepositories;
using MyPolyglotWeb.Services.IServices;
using Xunit;

namespace MyPolyglotWebTests.Presentations.HomePresentationTests
{
    public class MinusPointShould
    {
        private HomePresentation _homePresentation;
        private Mock<IMapper> _mapperMock;
        private Mock<IExerciseRepository> _exerciseRepositoryMock;
        private Mock<IUserService> _userService;
        private Mock<IScoreRepository> _scoreRepository;
        private Mock<ILessonRepository> _lessonRepository;

        public MinusPointShould()
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
        public void GetCurrentUser()
        {
            var lessonId = 1;
            var user = new UserDB()
            {
                Id = 2
            };
            _userService.Setup(x => x.GetCurrentUser()).Returns(user);

            var score = new ScoreDB()
            {
                Points = 3
            };
            _scoreRepository.Setup(x => x.Get(user.Id, lessonId)).Returns(score);


            _homePresentation.MinusPoint(lessonId);

            _userService.Verify(x => x.GetCurrentUser(), Times.Once);
        }

        [Fact]
        public void GetUserScore()
        {
            var lessonId = 1;
            var user = new UserDB()
            {
                Id = 2
            };
            _userService.Setup(x => x.GetCurrentUser()).Returns(user);

            var score = new ScoreDB()
            {
                Points = 3
            };
            _scoreRepository.Setup(x => x.Get(user.Id, lessonId)).Returns(score);


            _homePresentation.MinusPoint(lessonId);

            _scoreRepository.Verify(x => x.Get(user.Id, lessonId), Times.Once);
        }

        [Theory]
        [InlineData(0.5)]
        [InlineData(1)]
        public void MinusHalfOnePoint_ScorePointsEqualOrMoreThanHalfOne(double scorePoints)
        {
            var lessonId = 1;
            var user = new UserDB()
            {
                Id = 2
            };
            _userService.Setup(x => x.GetCurrentUser()).Returns(user);

            var scoreMock = new Mock<ScoreDB>();
            scoreMock.Setup(x => x.Points).Returns(scorePoints);
            _scoreRepository.Setup(x => x.Get(user.Id, lessonId)).Returns(scoreMock.Object);

            _homePresentation.MinusPoint(lessonId);

            scoreMock.VerifySet(x => x.Points = scorePoints - 0.5, Times.Once);
        }

        [Fact]
        public void SaveScore_ScorePointsEqualOrMoreThanHalfOne()
        {
            var lessonId = 1;
            var scorePoints = 5;
            var user = new UserDB()
            {
                Id = 2
            };
            _userService.Setup(x => x.GetCurrentUser()).Returns(user);

            var scoreMock = new Mock<ScoreDB>();
            scoreMock.Setup(x => x.Points).Returns(scorePoints);
            _scoreRepository.Setup(x => x.Get(user.Id, lessonId)).Returns(scoreMock.Object);

            _homePresentation.MinusPoint(lessonId);

            _scoreRepository.Verify(x => x.Save(scoreMock.Object), Times.Once);
        }

        [Fact]
        public void DoNothing_ScorePointsIsBelowHalfOne()
        {
            var lessonId = 1;
            var userId = 2;
            var userMock = new Mock<UserDB>();
            var scorePoints = 0;
            userMock.Setup(x => x.Id).Returns(userId);
            _userService.Setup(x => x.GetCurrentUser()).Returns(userMock.Object);
            var scoreMock = new Mock<ScoreDB>();
            scoreMock.Setup(x => x.Points).Returns(scorePoints);
            _scoreRepository.Setup(x => x.Get(userId, lessonId)).Returns(scoreMock.Object);

            _homePresentation.MinusPoint(lessonId);

            scoreMock.VerifySet(x => x.Points = scorePoints - 0.5, Times.Never);
            _scoreRepository.Verify(x => x.Save(scoreMock.Object), Times.Never);
        }
    }
}
