using AutoMapper;
using Moq;
using MyPolyglotCore.Interfaces;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Models.ViewModels;
using MyPolyglotWeb.Presentations;
using MyPolyglotWeb.Repositories.IRepositories;
using Xunit;

namespace MyPolyglotWebTests.Presentations.AdminPresentationTests
{
    public class AddExerciseShould
    {
        private AdminPresentation _adminPresentation;
        private Mock<IMapper> _mapperMock;
        private Mock<ILessonRepository> _lessonRepositoryMock;
        private Mock<IExerciseRepository> _exerciseRepositoryMock;
        private Mock<IUnrecognizedWordRepository> _unrecognizedWordRepositoryMock;
        private Mock<IRecognizer> _recognizerMock;

        public AddExerciseShould()
        {
            _mapperMock = new Mock<IMapper>();
            _lessonRepositoryMock = new Mock<ILessonRepository>();
            _exerciseRepositoryMock = new Mock<IExerciseRepository>();
            _unrecognizedWordRepositoryMock = new Mock<IUnrecognizedWordRepository>();
            _recognizerMock = new Mock<IRecognizer>();
            _adminPresentation = new AdminPresentation(_mapperMock.Object, _lessonRepositoryMock.Object,
                _exerciseRepositoryMock.Object, _unrecognizedWordRepositoryMock.Object, _recognizerMock.Object);
        }

        [Fact]
        public void SaveExercise()
        {
            var addExerciseVM = new AddExerciseVM()
            {
                LessonId = "1"
            };
            var lessonDB = new LessonDB();
            var exerciseDBMock = new Mock<ExerciseDB>();

            _mapperMock.Setup(x => x.Map<ExerciseDB>(addExerciseVM)).Returns(exerciseDBMock.Object);
            _lessonRepositoryMock.Setup(x => x.Get(long.Parse(addExerciseVM.LessonId))).Returns(lessonDB);

            _adminPresentation.AddExercise(addExerciseVM);

            _mapperMock.Verify(x => x.Map<ExerciseDB>(addExerciseVM), Times.Once);
            exerciseDBMock.VerifySet(x => x.Lesson = lessonDB, Times.Once);
            _lessonRepositoryMock.Verify(x => x.Get(long.Parse(addExerciseVM.LessonId)), Times.Once);
            _exerciseRepositoryMock.Verify(x => x.Save(exerciseDBMock.Object), Times.Once);
        }
    }
}
