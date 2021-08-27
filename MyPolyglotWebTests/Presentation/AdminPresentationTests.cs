using AutoMapper;
using Moq;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Models.ViewModels;
using MyPolyglotWeb.Presentation;
using MyPolyglotWeb.Repositories.IRepository;
using Xunit;

namespace MyPolyglotWebTests.Presentation
{
    public class AdminPresentationTests
    {
        private AdminPresentation _adminPresentation;
        private Mock<IMapper> _mapperMock;
        private Mock<ILessonRepository> _lessonRepositoryMock;
        private Mock<IExerciseRepository> _exerciseRepositoryMock;

        public AdminPresentationTests()
        {
            _mapperMock = new Mock<IMapper>();
            _lessonRepositoryMock = new Mock<ILessonRepository>();
            _exerciseRepositoryMock = new Mock<IExerciseRepository>();
            _adminPresentation = new AdminPresentation(_mapperMock.Object, _lessonRepositoryMock.Object, _exerciseRepositoryMock.Object);
        }

        [Fact]
        public void AddExercise()
        {
            var lessonId = 1;
            var addExerciseVMMock = new Mock<AddExerciseVM>();
            var lessonDBMock = new Mock<LessonDB>();
            var exerciseDBMock = new Mock<ExerciseDB>();

            addExerciseVMMock.Setup(x => x.LessonId).Returns(lessonId.ToString());
            _mapperMock.Setup(x => x.Map<ExerciseDB>(addExerciseVMMock.Object)).Returns(exerciseDBMock.Object);
            _lessonRepositoryMock.Setup(x => x.Get(lessonId)).Returns(lessonDBMock.Object);

            _adminPresentation.AddExercise(addExerciseVMMock.Object);

            _mapperMock.Verify(x => x.Map<ExerciseDB>(addExerciseVMMock.Object), Times.Once);
            exerciseDBMock.VerifySet(x => x.Lesson = lessonDBMock.Object);
            _lessonRepositoryMock.Verify(x => x.Get(lessonId), Times.Once);
            _exerciseRepositoryMock.Verify(x => x.Save(exerciseDBMock.Object), Times.Once);
        }
    }
}
