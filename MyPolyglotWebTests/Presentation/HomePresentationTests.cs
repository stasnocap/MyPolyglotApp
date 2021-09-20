using AutoMapper;
using Moq;
using MyPolyglotCore.Words;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Models.ViewModels;
using MyPolyglotWeb.Presentation;
using MyPolyglotWeb.Repositories.IRepository;
using System.Collections.Generic;
using Xunit;

namespace MyPolyglotWebTests.Presentation
{
    public class HomePresentationTests
    {
        private HomePresentation _homePresentation;
        private Mock<IMapper> _mapperMock;
        private Mock<IExerciseRepository> _exerciseRepositoryMock;

        public HomePresentationTests()
        {
            _mapperMock = new Mock<IMapper>();
            _exerciseRepositoryMock = new Mock<IExerciseRepository>();
            _homePresentation = new HomePresentation(_mapperMock.Object, _exerciseRepositoryMock.Object);
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
            exerciseVMMock.VerifySet(x => x.OptionGroups = It.IsAny<List<OptionGroup>>(), Times.Once);
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
    }
}
