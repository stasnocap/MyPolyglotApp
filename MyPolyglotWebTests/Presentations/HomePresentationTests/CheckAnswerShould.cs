using AutoMapper;
using Moq;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Presentations;
using MyPolyglotWeb.Repositories.IRepositories;
using MyPolyglotWeb.Services.IServices;
using Xunit;

namespace MyPolyglotWebTests.Presentations.HomePresentationTests
{
    public class CheckAnswerShould
    {
        private HomePresentation _homePresentation;
        private Mock<IMapper> _mapperMock;
        private Mock<IExerciseRepository> _exerciseRepositoryMock;
        private Mock<IUserService> _userService;
        private Mock<IScoreRepository> _scoreRepository;
        private Mock<ILessonRepository> _lessonRepository;

        public CheckAnswerShould()
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
        public void ReturnTrue_GivenRightAnswer()
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
        public void ReturnFalse_GivenWrongAnswer()
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
    }
}
