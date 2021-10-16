using AutoMapper;
using Moq;
using MyPolyglotCore.Interfaces;
using MyPolyglotWeb.Presentations;
using MyPolyglotWeb.Repositories.IRepositories;
using Xunit;

namespace MyPolyglotWebTests.Presentations.AdminPresentationTests
{
    public class DeleteExerciseShould
    {
        private AdminPresentation _adminPresentation;
        private Mock<IMapper> _mapperMock;
        private Mock<ILessonRepository> _lessonRepositoryMock;
        private Mock<IExerciseRepository> _exerciseRepositoryMock;
        private Mock<IUnrecognizedWordRepository> _unrecognizedWordRepositoryMock;
        private Mock<IRecognizer> _recognizerMock;

        public DeleteExerciseShould()
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
        public void RemoveExerciseFromRepository()
        {
            var exerciseId = 1;

            _adminPresentation.DeleteExercise(exerciseId);

            _exerciseRepositoryMock.Verify(x => x.Remove(exerciseId), Times.Once);
        }
    }
}
