using AutoMapper;
using Moq;
using MyPolyglotCore.Words;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Models.ViewModels;
using MyPolyglotWeb.Presentations;
using MyPolyglotWeb.Repositories.IRepositories;
using MyPolyglotWeb.Services.IServices;
using System.Collections.Generic;
using Xunit;

namespace MyPolyglotWebTests.Presentation
{
    public class HomePresentationTests
    {
        private HomePresentation _homePresentation;
        private Mock<IMapper> _mapperMock;
        private Mock<IExerciseRepository> _exerciseRepositoryMock;
        private Mock<IUserService> _userService;
        private Mock<IScoreRepository> _scoreRepository;
        private Mock<ILessonRepository> _lessonRepository;

        public HomePresentationTests()
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
        public void GetExerciseVM()
        {
            var lessonId = 1;
            var exerciseDBMock = new Mock<ExerciseDB>();

            exerciseDBMock.Setup(x => x.EngPhrase).Returns("I am cool.");
            var unrecognizedWords = new List<Word>()
            {
                new Adjective("cool")
            };

            var exerciseVMMock = new Mock<ShowExerciseVM>();

            _mapperMock.Setup(x => x.Map<IEnumerable<Word>>(exerciseDBMock.Object.UnrecognizedWords)).Returns(unrecognizedWords);
            _mapperMock.Setup(x => x.Map<ShowExerciseVM>(exerciseDBMock.Object)).Returns(exerciseVMMock.Object);

            _exerciseRepositoryMock.Setup(x => x.GetRandomExercise(lessonId)).Returns(exerciseDBMock.Object);

            var exerciseVM = _homePresentation.GetExerciseVM(lessonId);

            _exerciseRepositoryMock.Verify(x => x.GetRandomExercise(lessonId), Times.Once);
            _mapperMock.Verify(x => x.Map<IEnumerable<Word>>(exerciseDBMock.Object.UnrecognizedWords), Times.Once);
            _mapperMock.Verify(x => x.Map<ShowExerciseVM>(exerciseDBMock.Object), Times.Once);
            exerciseVMMock.VerifySet(x => x.OptionGroups = It.IsAny<List<OptionGroupVM>>(), Times.Once);
            exerciseVMMock.VerifySet(x => x.LessonId = lessonId, Times.Once);
        }

        [Fact]
        public void CheckAnswer_GivenRightAnswer()
        {
            var exerciseId = 1;
            var userAnswer = "I am cool.";
            var exerciseDBMock = new Mock<ExerciseDB>();
            _exerciseRepositoryMock.Setup(x => x.Get(exerciseId)).Returns(exerciseDBMock.Object);
            exerciseDBMock.Setup(x => x.EngPhrase).Returns(userAnswer);

            var result = _homePresentation.CheckAnswer(exerciseId, userAnswer);

            _exerciseRepositoryMock.Verify(x => x.Get(exerciseId), Times.Once);
            Assert.True(result);
        }

        [Fact]
        public void CheckAnswer_GivenWrongAnswer()
        {
            var exerciseId = 1;
            var wrongUserAnswer = "I was cool.";
            var rightAnswer = "I am cool.";
            var exerciseDBMock = new Mock<ExerciseDB>();
            _exerciseRepositoryMock.Setup(x => x.Get(exerciseId)).Returns(exerciseDBMock.Object);
            exerciseDBMock.Setup(x => x.EngPhrase).Returns(rightAnswer);

            var result = _homePresentation.CheckAnswer(exerciseId, wrongUserAnswer);

            _exerciseRepositoryMock.Verify(x => x.Get(exerciseId), Times.Once);
            Assert.False(result);
        }

        [Fact]
        public void PlusPoint_FirstUserPoint()
        {
            var lessonId = 1;
            var userId = 2;
            var userMock = new Mock<UserDB>();
            userMock.Setup(x => x.Id).Returns(userId);
            _userService.Setup(x => x.GetCurrentUser()).Returns(userMock.Object);
            var lessonMock = new Mock<LessonDB>();
            _lessonRepository.Setup(x => x.Get(lessonId)).Returns(lessonMock.Object);
            _scoreRepository.Setup(x => x.Get(userId, lessonId)).Returns((ScoreDB)null);

            _homePresentation.PlusPoint(lessonId);

            userMock.VerifyGet(x => x.Id, Times.Once);
            _userService.Verify(x => x.GetCurrentUser(), Times.Once);
            _lessonRepository.Verify(x => x.Get(lessonId), Times.Once);
            _scoreRepository.Verify(x => x.Save(It.IsAny<ScoreDB>()), Times.Once);
        }

        [Fact]
        public void PlusPoint_NotFirstUserPoint()
        {
            var lessonId = 1;
            var userId = 2;
            var userScorePoints = 3;
            var userMock = new Mock<UserDB>();
            userMock.Setup(x => x.Id).Returns(userId);
            _userService.Setup(x => x.GetCurrentUser()).Returns(userMock.Object);
            var lessonMock = new Mock<LessonDB>();
            _lessonRepository.Setup(x => x.Get(lessonId)).Returns(lessonMock.Object);
            var userScoreMock = new Mock<ScoreDB>();
            userScoreMock.Setup(x => x.Points).Returns(userScorePoints);
            _scoreRepository.Setup(x => x.Get(userId, lessonId)).Returns(userScoreMock.Object);

            _homePresentation.PlusPoint(lessonId);

            userMock.VerifyGet(x => x.Id, Times.Once);
            _userService.Verify(x => x.GetCurrentUser(), Times.Once);
            _lessonRepository.Verify(x => x.Get(lessonId), Times.Once);
            userScoreMock.VerifySet(x => x.Points = userScorePoints + 1, Times.Once);
            _scoreRepository.Verify(x => x.Save(userScoreMock.Object), Times.Once);
        }
    }
}
