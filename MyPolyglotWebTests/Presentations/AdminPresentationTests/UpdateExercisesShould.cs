using AutoMapper;
using Moq;
using MyPolyglotCore.Interfaces;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Models.ViewModels;
using MyPolyglotWeb.Presentations;
using MyPolyglotWeb.Repositories.IRepositories;
using System.Collections.Generic;
using Xunit;

namespace MyPolyglotWebTests.Presentations.AdminPresentationTests
{
    public class UpdateExercisesShould
    {
        private AdminPresentation _adminPresentation;
        private Mock<IMapper> _mapperMock;
        private Mock<ILessonRepository> _lessonRepositoryMock;
        private Mock<IExerciseRepository> _exerciseRepositoryMock;
        private Mock<IUnrecognizedWordRepository> _unrecognizedWordRepositoryMock;
        private Mock<IRecognizer> _recognizerMock;

        public UpdateExercisesShould()
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
        public void MapExerciseVMToExerciseDB()
        {
            var allExercisesVM = new AllExercisesVM();
            var exerciseVM = new ExerciseVM();
            allExercisesVM.Exercises = new List<ExerciseVM>();
            allExercisesVM.Exercises.Add(exerciseVM);
            exerciseVM.UnrecognizedWords = new List<UnrecognizedWordVM>();

            _adminPresentation.UpdateExercises(allExercisesVM);

            _mapperMock.Verify(x => x.Map<ExerciseDB>(exerciseVM), Times.Once);
        }

        [Fact]
        public void SaveExercise()
        {
            var allExercisesVM = new AllExercisesVM();
            var exerciseVM = new ExerciseVM();
            allExercisesVM.Exercises = new List<ExerciseVM>();
            allExercisesVM.Exercises.Add(exerciseVM);
            exerciseVM.UnrecognizedWords = new List<UnrecognizedWordVM>();
            var exerciseDB = new ExerciseDB();
            _mapperMock.Setup(x => x.Map<ExerciseDB>(exerciseVM)).Returns(exerciseDB);

            _adminPresentation.UpdateExercises(allExercisesVM);

            _exerciseRepositoryMock.Verify(x => x.Save(exerciseDB), Times.Once);
        }

        [Fact]
        public void MapUnrecognizedWordVMToUnrecognizedWordDB_IfTextIsNotEmpty()
        {
            var allExercisesVM = new AllExercisesVM();
            var exerciseVM = new ExerciseVM();
            var unrecognizedWordWithNotEmptyText = new UnrecognizedWordVM()
            {
                Text = "not empty",
            };
            allExercisesVM.Exercises = new List<ExerciseVM>();
            allExercisesVM.Exercises.Add(exerciseVM);
            exerciseVM.UnrecognizedWords = new List<UnrecognizedWordVM>();
            exerciseVM.UnrecognizedWords.Add(unrecognizedWordWithNotEmptyText);

            _adminPresentation.UpdateExercises(allExercisesVM);

            _mapperMock.Verify(x => x.Map<UnrecognizedWordDB>(unrecognizedWordWithNotEmptyText), Times.Once);
        }

        [Fact]
        public void SaveUnrecognizedWord_IfTextIsNotEmpty()
        {
            var allExercisesVM = new AllExercisesVM();
            var exerciseVM = new ExerciseVM();
            var unrecognizedWordWithNotEmptyText = new UnrecognizedWordVM()
            {
                Text = "not empty",
            };
            allExercisesVM.Exercises = new List<ExerciseVM>();
            allExercisesVM.Exercises.Add(exerciseVM);
            exerciseVM.UnrecognizedWords = new List<UnrecognizedWordVM>();
            exerciseVM.UnrecognizedWords.Add(unrecognizedWordWithNotEmptyText);
            var unrecognizedWordDB = new UnrecognizedWordDB();

            _mapperMock.Setup(x => x.Map<UnrecognizedWordDB>(unrecognizedWordWithNotEmptyText)).Returns(unrecognizedWordDB);

            _adminPresentation.UpdateExercises(allExercisesVM);

            _unrecognizedWordRepositoryMock.Verify(x => x.Save(unrecognizedWordDB), Times.Once);
        }

        [Fact]
        public void NotMapUnrecognizedWord_IfTextIsNullOrEmpty()
        {
            var allExercisesVM = new AllExercisesVM();
            var exerciseVM = new ExerciseVM();
            var unrecognizedWordWithNullText = new UnrecognizedWordVM();
            var unrecognizedWordWithEmptyText = new UnrecognizedWordVM()
            {
                Text = string.Empty,
            };
            allExercisesVM.Exercises = new List<ExerciseVM>();
            allExercisesVM.Exercises.Add(exerciseVM);
            exerciseVM.UnrecognizedWords = new List<UnrecognizedWordVM>();
            exerciseVM.UnrecognizedWords.Add(unrecognizedWordWithNullText);
            exerciseVM.UnrecognizedWords.Add(unrecognizedWordWithEmptyText);

            _adminPresentation.UpdateExercises(allExercisesVM);

            _mapperMock.Verify(x => x.Map<UnrecognizedWordDB>(unrecognizedWordWithNullText), Times.Never);
            _mapperMock.Verify(x => x.Map<UnrecognizedWordDB>(unrecognizedWordWithEmptyText), Times.Never);
        }

        [Fact]
        public void NotSaveUnrecognizedWord_IfTextIsNullOrEmpty()
        {
            var allExercisesVM = new AllExercisesVM();
            var exerciseVM = new ExerciseVM();
            var unrecognizedWordWithNullText = new UnrecognizedWordVM();
            var unrecognizedWordWithEmptyText = new UnrecognizedWordVM()
            {
                Text = string.Empty,
            };
            allExercisesVM.Exercises = new List<ExerciseVM>();
            allExercisesVM.Exercises.Add(exerciseVM);
            exerciseVM.UnrecognizedWords = new List<UnrecognizedWordVM>();
            exerciseVM.UnrecognizedWords.Add(unrecognizedWordWithNullText);
            exerciseVM.UnrecognizedWords.Add(unrecognizedWordWithEmptyText);
            var unrecognizedWordWithEmptyTextDB = new UnrecognizedWordDB();
            var unrecognizedWordWithNullTextDB = new UnrecognizedWordDB();

            _mapperMock.Setup(x => x.Map<UnrecognizedWordDB>(unrecognizedWordWithEmptyText)).Returns(unrecognizedWordWithEmptyTextDB);
            _mapperMock.Setup(x => x.Map<UnrecognizedWordDB>(unrecognizedWordWithNullText)).Returns(unrecognizedWordWithNullTextDB);

            _adminPresentation.UpdateExercises(allExercisesVM);

            _unrecognizedWordRepositoryMock.Verify(x => x.Save(unrecognizedWordWithEmptyTextDB), Times.Never);
            _unrecognizedWordRepositoryMock.Verify(x => x.Save(unrecognizedWordWithNullTextDB), Times.Never);
        }

        [Fact]
        public void RemoveUnrecognizedWordFromRepository_IfTextIsNullOrEmpty()
        {
            var allExercisesVM = new AllExercisesVM();
            var exerciseVM = new ExerciseVM();
            var unrecognizedWordWithNullText = new UnrecognizedWordVM()
            {
                UnrecognizedWordId = 122
            };
            var unrecognizedWordWithEmptyText = new UnrecognizedWordVM()
            {
                Text = string.Empty,
                UnrecognizedWordId = 123
            };
            allExercisesVM.Exercises = new List<ExerciseVM>();
            allExercisesVM.Exercises.Add(exerciseVM);
            exerciseVM.UnrecognizedWords = new List<UnrecognizedWordVM>();
            exerciseVM.UnrecognizedWords.Add(unrecognizedWordWithNullText);
            exerciseVM.UnrecognizedWords.Add(unrecognizedWordWithEmptyText);

            _mapperMock.Setup(x => x.Map<ExerciseDB>(exerciseVM)).Returns(new ExerciseDB());

            _adminPresentation.UpdateExercises(allExercisesVM);

            _unrecognizedWordRepositoryMock.Verify(x => x.Remove(unrecognizedWordWithEmptyText.UnrecognizedWordId), Times.Once);
            _unrecognizedWordRepositoryMock.Verify(x => x.Remove(unrecognizedWordWithNullText.UnrecognizedWordId), Times.Once);
        }

        [Fact]
        public void RemoveUnrecognizedWordFromViewModel_IfTextIsNullOrEmpty()
        {
            var allExercisesVM = new AllExercisesVM();
            var exerciseVM = new ExerciseVM();
            var unrecognizedWordWithNullText = new UnrecognizedWordVM()
            {
                UnrecognizedWordId = 122
            };
            var unrecognizedWordWithEmptyText = new UnrecognizedWordVM()
            {
                Text = string.Empty,
                UnrecognizedWordId = 123
            };
            allExercisesVM.Exercises = new List<ExerciseVM>();
            allExercisesVM.Exercises.Add(exerciseVM);
            exerciseVM.UnrecognizedWords = new List<UnrecognizedWordVM>();
            exerciseVM.UnrecognizedWords.Add(unrecognizedWordWithNullText);
            exerciseVM.UnrecognizedWords.Add(unrecognizedWordWithEmptyText);

            _mapperMock.Setup(x => x.Map<ExerciseDB>(exerciseVM)).Returns(new ExerciseDB());

            _adminPresentation.UpdateExercises(allExercisesVM);

            _unrecognizedWordRepositoryMock.Verify(x => x.Remove(unrecognizedWordWithEmptyText.UnrecognizedWordId), Times.Once);
            _unrecognizedWordRepositoryMock.Verify(x => x.Remove(unrecognizedWordWithNullText.UnrecognizedWordId), Times.Once);
        }
    }
}
