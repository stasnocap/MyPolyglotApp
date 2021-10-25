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
        public void GetRandomExerciseFromRepository()
        {
            var lessonId = 1;
            var exerciseDB = new ExerciseDB()
            {
                EngPhrase = "not null"
            };
            _exerciseRepositoryMock.Setup(x => x.GetRandomExercise(lessonId)).Returns(exerciseDB);
            _mapperMock.Setup(x => x.Map<DoExerciseVM>(exerciseDB)).Returns(new DoExerciseVM());

            var exerciseVM = _homePresentation.GetDoExerciseVM(lessonId);

            _exerciseRepositoryMock.Verify(x => x.GetRandomExercise(lessonId), Times.Once);
        }

        [Fact]
        public void MapListUnrecognizedWordToIEnumerableWord()
        {
            var lessonId = 1;
            var exerciseDB = new ExerciseDB()
            {
                EngPhrase = "not null",
            };
            _exerciseRepositoryMock.Setup(x => x.GetRandomExercise(lessonId)).Returns(exerciseDB);
            _mapperMock.Setup(x => x.Map<DoExerciseVM>(exerciseDB)).Returns(new DoExerciseVM());

            var exerciseVM = _homePresentation.GetDoExerciseVM(lessonId);

            _mapperMock.Verify(x => x.Map<IEnumerable<Word>>(exerciseDB.UnrecognizedWords), Times.Once);
        }

        [Fact]
        public void MapExerciseDBToDoExerciseVM()
        {
            var lessonId = 1;
            var exerciseDB = new ExerciseDB()
            {
                EngPhrase = "not null",
            };
            _exerciseRepositoryMock.Setup(x => x.GetRandomExercise(lessonId)).Returns(exerciseDB);
            _mapperMock.Setup(x => x.Map<DoExerciseVM>(exerciseDB)).Returns(new DoExerciseVM());

            var exerciseVM = _homePresentation.GetDoExerciseVM(lessonId);

            _mapperMock.Verify(x => x.Map<DoExerciseVM>(exerciseDB), Times.Once);
        }

        [Fact]
        public void SetOptionsWithSomething()
        {
            var lessonId = 1;
            var exerciseDB = new ExerciseDB()
            {
                EngPhrase = "I am cool.",
            };
            _exerciseRepositoryMock.Setup(x => x.GetRandomExercise(lessonId)).Returns(exerciseDB);
            _mapperMock.Setup(x => x.Map<DoExerciseVM>(exerciseDB)).Returns(new DoExerciseVM());

            var exerciseVM = _homePresentation.GetDoExerciseVM(lessonId);

            foreach (var optionGroup in exerciseVM.OptionGroups)
            {
                Assert.NotNull(optionGroup);
                foreach (var option in optionGroup.Options)
                {
                    Assert.NotNull(option);
                    Assert.NotEmpty(option);
                }
            }
        }

        [Fact]
        public void SetLessonId()
        {
            var lessonId = 1;
            var exerciseDB = new ExerciseDB()
            {
                EngPhrase = "not null",
            };
            _exerciseRepositoryMock.Setup(x => x.GetRandomExercise(lessonId)).Returns(exerciseDB);
            _mapperMock.Setup(x => x.Map<DoExerciseVM>(exerciseDB)).Returns(new DoExerciseVM());

            var exerciseVM = _homePresentation.GetDoExerciseVM(lessonId);

            Assert.Equal(lessonId, exerciseVM.LessonId);
        }

        [Fact]
        public void SetUserPointsToMinusOne_WhenUserIsNotLoggedIn()
        {
            var lessonId = 1;
            var exerciseDB = new ExerciseDB()
            {
                EngPhrase = "not null",
            };
            _exerciseRepositoryMock.Setup(x => x.GetRandomExercise(lessonId)).Returns(exerciseDB);
            _mapperMock.Setup(x => x.Map<DoExerciseVM>(exerciseDB)).Returns(new DoExerciseVM());

            var exerciseVM = _homePresentation.GetDoExerciseVM(lessonId);

            Assert.Equal(-1, exerciseVM.UserPoints);
        }

        [Fact]
        public void SetUserPointsToUserPoints_WhenUserIsLoggedIn()
        {
            var lessonId = 1;
            var exerciseDB = new ExerciseDB()
            {
                EngPhrase = "not null",
            };
            _exerciseRepositoryMock.Setup(x => x.GetRandomExercise(lessonId)).Returns(exerciseDB);
            _mapperMock.Setup(x => x.Map<DoExerciseVM>(exerciseDB)).Returns(new DoExerciseVM());

            var userDB = new UserDB()
            {
                Id = 1
            };
            _userService.Setup(x => x.GetCurrentUser()).Returns(userDB);

            var scoreDB = new ScoreDB()
            {
                Points = 1
            };
            _scoreRepository.Setup(x => x.Get(userDB.Id, lessonId)).Returns(scoreDB);

            var exerciseVM = _homePresentation.GetDoExerciseVM(lessonId);

            Assert.Equal(scoreDB.Points, exerciseVM.UserPoints);
        }

        [Fact]
        public void SetUserPointsToZero_IfUserScoreDontExist()
        {
            var lessonId = 1;
            var exerciseDB = new ExerciseDB()
            {
                EngPhrase = "not null",
            };
            _exerciseRepositoryMock.Setup(x => x.GetRandomExercise(lessonId)).Returns(exerciseDB);
            _mapperMock.Setup(x => x.Map<DoExerciseVM>(exerciseDB)).Returns(new DoExerciseVM());

            var userDB = new UserDB()
            {
                Id = 1
            };
            _userService.Setup(x => x.GetCurrentUser()).Returns(userDB);

            var exerciseVM = _homePresentation.GetDoExerciseVM(lessonId);

            Assert.Equal(0, exerciseVM.UserPoints);
        }

        [Fact]
        public void GetLessonFromRepository_IfUserScoreDontExist()
        {
            var lessonId = 1;
            var exerciseDB = new ExerciseDB()
            {
                EngPhrase = "not null",
            };
            _exerciseRepositoryMock.Setup(x => x.GetRandomExercise(lessonId)).Returns(exerciseDB);
            _mapperMock.Setup(x => x.Map<DoExerciseVM>(exerciseDB)).Returns(new DoExerciseVM());

            var userDB = new UserDB()
            {
                Id = 1
            };
            _userService.Setup(x => x.GetCurrentUser()).Returns(userDB);

            var exerciseVM = _homePresentation.GetDoExerciseVM(lessonId);

            _lessonRepository.Verify(x => x.Get(lessonId), Times.Once);
        }

        [Fact]
        public void SaveNewUserScoreToRepository_IfUserScoreDontExist()
        {
            var lessonId = 1;
            var exerciseDB = new ExerciseDB()
            {
                EngPhrase = "not null",
            };
            _exerciseRepositoryMock.Setup(x => x.GetRandomExercise(lessonId)).Returns(exerciseDB);
            _mapperMock.Setup(x => x.Map<DoExerciseVM>(exerciseDB)).Returns(new DoExerciseVM());

            var userDB = new UserDB()
            {
                Id = 1
            };
            _userService.Setup(x => x.GetCurrentUser()).Returns(userDB);

            var lessonDB = new LessonDB();
            _lessonRepository.Setup(x => x.Get(lessonId)).Returns(lessonDB);

            var exerciseVM = _homePresentation.GetDoExerciseVM(lessonId);

            _scoreRepository.Verify(x => x.Save(It.Is<ScoreDB>(x => 
                                                    x.Lesson == lessonDB 
                                                    && x.User == userDB 
                                                    && x.Points == 0)), Times.Once);
        }

        [Fact]
        public void SetHint2TableWithSomething_IfLessonIdIs2()
        {
            var lessonId = 2;
            var exerciseDB = new ExerciseDB()
            {
                EngPhrase = "not null",
            };
            _exerciseRepositoryMock.Setup(x => x.GetRandomExercise(lessonId)).Returns(exerciseDB);
            _mapperMock.Setup(x => x.Map<DoExerciseVM>(exerciseDB)).Returns(new DoExerciseVM());

            var exerciseVM = _homePresentation.GetDoExerciseVM(lessonId);

            Assert.NotNull(exerciseVM.HintTable2VM);
            Assert.NotNull(exerciseVM.HintTable2VM.PresentForm);
            Assert.NotNull(exerciseVM.HintTable2VM.PastForm);
            Assert.NotNull(exerciseVM.HintTable2VM.ThirdPersonForm);
            Assert.NotEmpty(exerciseVM.HintTable2VM.PresentForm);
            Assert.NotEmpty(exerciseVM.HintTable2VM.PastForm);
            Assert.NotEmpty(exerciseVM.HintTable2VM.ThirdPersonForm);
        }

        [Fact]
        public void GetRandomExercise_IfThereIsNoExerciseInDatabase()
        {
            var lessonId = 1;

            _exerciseRepositoryMock.Setup(x => x.Get(lessonId)).Returns((ExerciseDB)null);

            var doExerciseVM = _homePresentation.GetDoExerciseVM(lessonId);

            _exerciseRepositoryMock.Verify(x => x.GetRandomExercise(1), Times.Once);
        }

        [Fact]
        public void ReturnNull_IfThereIsNoExerciseInDatabase()
        {
            var lessonId = 1;

            _exerciseRepositoryMock.Setup(x => x.Get(lessonId)).Returns((ExerciseDB)null);

            var doExerciseVM = _homePresentation.GetDoExerciseVM(lessonId);

            Assert.Null(doExerciseVM);
        }
    }
}
