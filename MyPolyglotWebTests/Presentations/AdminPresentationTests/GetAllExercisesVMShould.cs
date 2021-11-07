using AutoMapper;
using Moq;
using MyPolyglotCore.Interfaces;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Models.ViewModels;
using MyPolyglotWeb.Presentations;
using MyPolyglotWeb.Repositories.IRepositories;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace MyPolyglotWebTests.Presentations.AdminPresentationTests
{
    public class GetAllExercisesVMShould
    {
        private AdminPresentation _adminPresentation;
        private Mock<IMapper> _mapperMock;
        private Mock<ILessonRepository> _lessonRepositoryMock;
        private Mock<IExerciseRepository> _exerciseRepositoryMock;
        private Mock<IUnrecognizedWordRepository> _unrecognizedWordRepositoryMock;
        private Mock<IRecognizer> _recognizerMock;

        public GetAllExercisesVMShould()
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
        public void GetAllExercisesFromRepository()
        {
            _mapperMock.Setup(x => x.Map<AllExercisesVM>(It.IsAny<List<ExerciseDB>>())).Returns(new AllExercisesVM());
            _adminPresentation.GetAllExercisesVM();

            _exerciseRepositoryMock.Verify(x => x.GetAll(), Times.Once);
        }

        [Fact]
        public void MapListExerciseDBToAllExercisesVM()
        {
            var exercisesDB = Enumerable.Empty<ExerciseDB>().AsQueryable();

            _exerciseRepositoryMock.Setup(x => x.GetAll()).Returns(exercisesDB);
            _mapperMock.Setup(x => x.Map<AllExercisesVM>(It.IsAny<List<ExerciseDB>>())).Returns(new AllExercisesVM());

            _adminPresentation.GetAllExercisesVM();

            _mapperMock.Verify(x => x.Map<AllExercisesVM>(exercisesDB), Times.Once);
        }

        [Fact]
        public void ReturnMappedAllExercisesVM()
        {
            var exercisesDB = Enumerable.Empty<ExerciseDB>().AsQueryable();
            var allExercisesVM = new AllExercisesVM();

            _exerciseRepositoryMock.Setup(x => x.GetAll()).Returns(exercisesDB);
            _mapperMock.Setup(x => x.Map<AllExercisesVM>(exercisesDB)).Returns(allExercisesVM);

            var result = _adminPresentation.GetAllExercisesVM();

            Assert.Equal(result, allExercisesVM);
        }

        [Fact]
        public void SetPaginatorVMPropertiesToDefault_WhenArgumentsDoNotPassed()
        {
            var defaultPage = 0;
            var defaultPageSize = 10;
            var defaultSortColumn = SortColumn.LessonId;
            var defaultSortDirection = SortDirection.ASC;

            _mapperMock.Setup(x => x.Map<AllExercisesVM>(It.IsAny<List<ExerciseDB>>())).Returns(new AllExercisesVM());

            var allExerciseVM = _adminPresentation.GetAllExercisesVM();

            Assert.Equal(defaultPage, allExerciseVM.PaginatorVM.Page);
            Assert.Equal(defaultPageSize, allExerciseVM.PaginatorVM.PageSize);
            Assert.Equal(defaultSortColumn, allExerciseVM.PaginatorVM.SortColumn);
            Assert.Equal(defaultSortDirection, allExerciseVM.PaginatorVM.SortDirection);
        }

        [Fact]
        public void SetPaginatorVMProperties_WhenArgumentsPassed()
        {
            var page = 1;
            var pageSize = 20;
            var sortColumn = SortColumn.RusPhrase;
            var sortDirection = SortDirection.DESC;

            _mapperMock.Setup(x => x.Map<AllExercisesVM>(It.IsAny<List<ExerciseDB>>())).Returns(new AllExercisesVM());

            var allExerciseVM = _adminPresentation.GetAllExercisesVM(page, pageSize, sortColumn, sortDirection);

            Assert.Equal(page, allExerciseVM.PaginatorVM.Page);
            Assert.Equal(pageSize, allExerciseVM.PaginatorVM.PageSize);
            Assert.Equal(sortColumn, allExerciseVM.PaginatorVM.SortColumn);
            Assert.Equal(sortDirection, allExerciseVM.PaginatorVM.SortDirection);
        }
    }
}
