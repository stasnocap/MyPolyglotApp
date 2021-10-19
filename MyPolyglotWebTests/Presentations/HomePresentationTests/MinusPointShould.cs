using AutoMapper;
using Moq;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Presentations;
using MyPolyglotWeb.Repositories.IRepositories;
using MyPolyglotWeb.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        [Theory]
        [InlineData(0.5)]
        [InlineData(1)]
        [InlineData(1.5)]
        [InlineData(2)]
        [InlineData(50)]
        public void MinusHalfOnePoint_ScorePointsEqualOrMoreThanHalfOne(double scorePoints)
        {
            var lessonId = 1;
            var userId = 2;
            var userMock = new Mock<UserDB>();
            userMock.Setup(x => x.Id).Returns(userId);
            _userService.Setup(x => x.GetCurrentUser()).Returns(userMock.Object);
            var scoreMock = new Mock<ScoreDB>();
            scoreMock.Setup(x => x.Points).Returns(scorePoints);
            _scoreRepository.Setup(x => x.Get(userId, lessonId)).Returns(scoreMock.Object);

            _homePresentation.MinusPoint(lessonId);

            _userService.Verify(x => x.GetCurrentUser(), Times.Once);
            _scoreRepository.Verify(x => x.Get(userId, lessonId), Times.Once);
            scoreMock.VerifySet(x => x.Points = scorePoints - 0.5, Times.Once);
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

            _userService.Verify(x => x.GetCurrentUser(), Times.Once);
            _scoreRepository.Verify(x => x.Get(userId, lessonId), Times.Once);
            scoreMock.VerifySet(x => x.Points = scorePoints - 0.5, Times.Never);
            _scoreRepository.Verify(x => x.Save(scoreMock.Object), Times.Never);
        }
    }
}
