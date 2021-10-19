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

namespace MyPolyglotWebTests.Presentations.HomePresentationTests
{
    public class GetDoExerciseVMShould
    {
        private HomePresentation _homePresentation;
        private Mock<IMapper> _mapperMock;
        private Mock<IExerciseRepository> _exerciseRepositoryMock;
        private Mock<IUserService> _userService;
        private Mock<IScoreRepository> _scoreRepository;
        private Mock<ILessonRepository> _lessonRepository;

        public GetDoExerciseVMShould()
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
        public void ReturnDoExerciseVM_WhenUserNotLoggedIn()
        {
            var lessonId = 1;
            var exerciseDBMock = new Mock<ExerciseDB>();
            exerciseDBMock.Setup(x => x.EngPhrase).Returns("I am cool.");
            var unrecognizedWords = new List<Word>()
            {
                new Adjective("cool")
            };

            var exerciseVMMock = new Mock<DoExerciseVM>();
            _mapperMock.Setup(x => x.Map<IEnumerable<Word>>(exerciseDBMock.Object.UnrecognizedWords)).Returns(unrecognizedWords);
            _mapperMock.Setup(x => x.Map<DoExerciseVM>(exerciseDBMock.Object)).Returns(exerciseVMMock.Object);
            _exerciseRepositoryMock.Setup(x => x.GetRandomExercise(lessonId)).Returns(exerciseDBMock.Object);

            _userService.Setup(x => x.GetCurrentUser()).Returns((UserDB)null);

            var exerciseVM = _homePresentation.GetDoExerciseVM(lessonId);

            _exerciseRepositoryMock.Verify(x => x.GetRandomExercise(lessonId), Times.Once);
            _mapperMock.Verify(x => x.Map<IEnumerable<Word>>(exerciseDBMock.Object.UnrecognizedWords), Times.Once);
            _mapperMock.Verify(x => x.Map<DoExerciseVM>(exerciseDBMock.Object), Times.Once);
            exerciseVMMock.VerifySet(x => x.OptionGroups = It.IsAny<List<OptionGroupVM>>(), Times.Once);
            exerciseVMMock.VerifySet(x => x.LessonId = lessonId, Times.Once);

            exerciseVMMock.VerifySet(x => x.UserPoints = -1, Times.Once);
            _userService.Verify(x => x.GetCurrentUser(), Times.Once);
        }

        [Fact]
        public void ReturnDoExerciseVM_WhenUserScoreIsNotNull()
        {
            var lessonId = 1;
            var userId = 2;
            var userScorePoints = 3;
            var exerciseDBMock = new Mock<ExerciseDB>();
            exerciseDBMock.Setup(x => x.EngPhrase).Returns("I am cool.");
            var unrecognizedWords = new List<Word>()
            {
                new Adjective("cool")
            };

            var exerciseVMMock = new Mock<DoExerciseVM>();
            _mapperMock.Setup(x => x.Map<IEnumerable<Word>>(exerciseDBMock.Object.UnrecognizedWords)).Returns(unrecognizedWords);
            _mapperMock.Setup(x => x.Map<DoExerciseVM>(exerciseDBMock.Object)).Returns(exerciseVMMock.Object);
            _exerciseRepositoryMock.Setup(x => x.GetRandomExercise(lessonId)).Returns(exerciseDBMock.Object);

            var userMock = new Mock<UserDB>();
            userMock.Setup(x => x.Id).Returns(userId);
            _userService.Setup(x => x.GetCurrentUser()).Returns(userMock.Object);

            var scoreMock = new Mock<ScoreDB>();
            scoreMock.Setup(x => x.Points).Returns(userScorePoints);
            _scoreRepository.Setup(x => x.Get(userId, lessonId)).Returns(scoreMock.Object);

            var exerciseVM = _homePresentation.GetDoExerciseVM(lessonId);

            _exerciseRepositoryMock.Verify(x => x.GetRandomExercise(lessonId), Times.Once);
            _mapperMock.Verify(x => x.Map<IEnumerable<Word>>(exerciseDBMock.Object.UnrecognizedWords), Times.Once);
            _mapperMock.Verify(x => x.Map<DoExerciseVM>(exerciseDBMock.Object), Times.Once);
            exerciseVMMock.VerifySet(x => x.OptionGroups = It.IsAny<List<OptionGroupVM>>(), Times.Once);
            exerciseVMMock.VerifySet(x => x.LessonId = lessonId, Times.Once);

            exerciseVMMock.VerifySet(x => x.UserPoints = userScorePoints, Times.Once);
            _userService.Verify(x => x.GetCurrentUser(), Times.Once);
        }

        [Fact]
        public void ReturnDoExerciseVM_WhenUserScoreIsNull()
        {
            var lessonId = 1;
            var userId = 2;
            var exerciseDBMock = new Mock<ExerciseDB>();
            exerciseDBMock.Setup(x => x.EngPhrase).Returns("I am cool.");
            var unrecognizedWords = new List<Word>()
            {
                new Adjective("cool")
            };

            var exerciseVMMock = new Mock<DoExerciseVM>();
            _mapperMock.Setup(x => x.Map<IEnumerable<Word>>(exerciseDBMock.Object.UnrecognizedWords)).Returns(unrecognizedWords);
            _mapperMock.Setup(x => x.Map<DoExerciseVM>(exerciseDBMock.Object)).Returns(exerciseVMMock.Object);
            _exerciseRepositoryMock.Setup(x => x.GetRandomExercise(lessonId)).Returns(exerciseDBMock.Object);

            var userMock = new Mock<UserDB>();
            userMock.Setup(x => x.Id).Returns(userId);
            _userService.Setup(x => x.GetCurrentUser()).Returns(userMock.Object);

            _scoreRepository.Setup(x => x.Get(userId, lessonId)).Returns((ScoreDB)null);

            var exerciseVM = _homePresentation.GetDoExerciseVM(lessonId);

            _exerciseRepositoryMock.Verify(x => x.GetRandomExercise(lessonId), Times.Once);
            _mapperMock.Verify(x => x.Map<IEnumerable<Word>>(exerciseDBMock.Object.UnrecognizedWords), Times.Once);
            _mapperMock.Verify(x => x.Map<DoExerciseVM>(exerciseDBMock.Object), Times.Once);
            exerciseVMMock.VerifySet(x => x.OptionGroups = It.IsAny<List<OptionGroupVM>>(), Times.Once);
            exerciseVMMock.VerifySet(x => x.LessonId = lessonId, Times.Once);

            exerciseVMMock.VerifySet(x => x.UserPoints = 0, Times.Once);
            _userService.Verify(x => x.GetCurrentUser(), Times.Once);
            _lessonRepository.Verify(x => x.Get(lessonId), Times.Once);
        }

        [Fact]
        public void ReturnDoExerciseVM_ForSecondLessonWhenUserIsNull()
        {
            var lessonId = 2;
            var exerciseDBMock = new Mock<ExerciseDB>();
            exerciseDBMock.Setup(x => x.EngPhrase).Returns("I am cool.");
            var unrecognizedWords = new List<Word>()
            {
                new Adjective("cool")
            };

            var exerciseVMMock = new Mock<DoExerciseVM>();
            _mapperMock.Setup(x => x.Map<IEnumerable<Word>>(exerciseDBMock.Object.UnrecognizedWords)).Returns(unrecognizedWords);
            _mapperMock.Setup(x => x.Map<DoExerciseVM>(exerciseDBMock.Object)).Returns(exerciseVMMock.Object);
            _exerciseRepositoryMock.Setup(x => x.GetRandomExercise(lessonId)).Returns(exerciseDBMock.Object);

            _userService.Setup(x => x.GetCurrentUser()).Returns((UserDB)null);

            var exerciseVM = _homePresentation.GetDoExerciseVM(lessonId);

            Assert.NotNull(exerciseVM.HintTable2VM);
            Assert.NotNull(exerciseVM.HintTable2VM.PresentForm);
            Assert.NotNull(exerciseVM.HintTable2VM.PastForm);
            Assert.NotNull(exerciseVM.HintTable2VM.ThirdPersonForm);

            _exerciseRepositoryMock.Verify(x => x.GetRandomExercise(lessonId), Times.Once);
            _mapperMock.Verify(x => x.Map<IEnumerable<Word>>(exerciseDBMock.Object.UnrecognizedWords), Times.Once);
            _mapperMock.Verify(x => x.Map<DoExerciseVM>(exerciseDBMock.Object), Times.Once);
            exerciseVMMock.VerifySet(x => x.OptionGroups = It.IsAny<List<OptionGroupVM>>(), Times.Once);
            exerciseVMMock.VerifySet(x => x.LessonId = lessonId, Times.Once);

            exerciseVMMock.VerifySet(x => x.UserPoints = -1, Times.Once);
            _userService.Verify(x => x.GetCurrentUser(), Times.Once);
        }
    }
}
