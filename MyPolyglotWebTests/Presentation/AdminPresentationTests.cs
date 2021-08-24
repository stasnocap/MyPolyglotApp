using AutoMapper;
using Moq;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Models.ViewModels;
using MyPolyglotWeb.Presentation;
using MyPolyglotWeb.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(31)]
        public void AddExercise_GivenValidLessonId(int lessonId)
        {
            var addExerciseVMMock = new Mock<AddExerciseVM>();
            addExerciseVMMock.Setup(x => x.LessonId).Returns(lessonId.ToString);

            _adminPresentation.AddExercise(addExerciseVMMock.Object);

            _mapperMock.Verify(x => x.Map<ExerciseDB>(addExerciseVMMock.Object), Times.Once);
            _lessonRepositoryMock.Verify(x => x.Get(lessonId), Times.Once);
            _exerciseRepositoryMock.Verify(x => x.Save(It.IsAny<ExerciseDB>()), Times.Once);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(32)]
        [InlineData(33)]
        public void AddExercise_GivenInvalidLessonId(int lessonId)
        {
            var addExerciseVMMock = new Mock<AddExerciseVM>();
            addExerciseVMMock.Setup(x => x.LessonId).Returns(lessonId.ToString);

            _adminPresentation.AddExercise(addExerciseVMMock.Object);

            _mapperMock.Verify(x => x.Map<ExerciseDB>(addExerciseVMMock.Object), Times.Never);
            _lessonRepositoryMock.Verify(x => x.Get(lessonId), Times.Never);
            _exerciseRepositoryMock.Verify(x => x.Save(It.IsAny<ExerciseDB>()), Times.Never);
        }
    }
}
