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
    public class SortExercisesShould
    {
        private AdminPresentationPublic _adminPresentation;
        private Mock<IMapper> _mapperMock;
        private Mock<ILessonRepository> _lessonRepositoryMock;
        private Mock<IExerciseRepository> _exerciseRepositoryMock;
        private Mock<IUnrecognizedWordRepository> _unrecognizedWordRepositoryMock;
        private Mock<IRecognizer> _recognizerMock;

        public SortExercisesShould()
        {
            _mapperMock = new Mock<IMapper>();
            _lessonRepositoryMock = new Mock<ILessonRepository>();
            _exerciseRepositoryMock = new Mock<IExerciseRepository>();
            _unrecognizedWordRepositoryMock = new Mock<IUnrecognizedWordRepository>();
            _recognizerMock = new Mock<IRecognizer>();
            _adminPresentation = new AdminPresentationPublic(_mapperMock.Object, _lessonRepositoryMock.Object,
                _exerciseRepositoryMock.Object, _unrecognizedWordRepositoryMock.Object, _recognizerMock.Object);
        }

        private ExerciseDB CreateExerciseDB(int lessonId, string engPhrase, string rusPhrase)
        {
            return new ExerciseDB()
            {
                Lesson = new LessonDB() { Id = lessonId },
                EngPhrase = engPhrase,
                RusPhrase = rusPhrase
            };
        }

        [Theory]
        [MemberData(nameof(SortCasesData))]
        public void SortExercises(SortColumn sortColumn, SortDirection sortDirection)
        {
            var dbExercises = new ExerciseDB[]
            {
                CreateExerciseDB(1, "C", "Б"),
                CreateExerciseDB(3, "B", "А"),
                CreateExerciseDB(2, "A", "В"),
            };

            var sortedExercises = _adminPresentation
                .SortExercisesPublic(dbExercises.AsQueryable(), sortColumn, sortDirection)
                .ToArray();

            var expected = default(object);
            switch (sortColumn)
            {
                case SortColumn.LessonId:
                    expected = GetCorrectSortedExercisesForLessonId(dbExercises, sortDirection);
                    break;
                case SortColumn.RusPhrase:
                    expected = GetCorrectSortedExercisesForRusPhrase(dbExercises, sortDirection);
                    break;
                case SortColumn.EngPhrase:
                    expected = GetCorrectSortedExercisesForEngPhrase(dbExercises, sortDirection);
                    break;
            }

            Assert.Equal(expected, sortedExercises);
        }

        private object GetCorrectSortedExercisesForEngPhrase(ExerciseDB[] dbExercises, SortDirection sortDirection)
        {
            if (sortDirection == SortDirection.ASC)
            {
                return new ExerciseDB[] { dbExercises[2], dbExercises[1], dbExercises[0], };
            }
            return new ExerciseDB[] { dbExercises[0], dbExercises[1], dbExercises[2], };
        }

        private object GetCorrectSortedExercisesForRusPhrase(ExerciseDB[] dbExercises, SortDirection sortDirection)
        {
            if (sortDirection == SortDirection.ASC)
            {
                return new ExerciseDB[] { dbExercises[1], dbExercises[0], dbExercises[2], };
            }
            return new ExerciseDB[] { dbExercises[2], dbExercises[0], dbExercises[1], };
        }

        private object GetCorrectSortedExercisesForLessonId(ExerciseDB[] dbExercises, SortDirection sortDirection)
        {
            if (sortDirection == SortDirection.ASC)
            {
                return new ExerciseDB[] { dbExercises[0], dbExercises[2], dbExercises[1], };
            }

            return new ExerciseDB[] { dbExercises[1], dbExercises[2], dbExercises[0], };
        }

        public static IEnumerable<object[]> SortCasesData
        {
            get
            {
                var sortColumns = new SortColumn[]
                {
                    SortColumn.LessonId,
                    SortColumn.EngPhrase,
                    SortColumn.RusPhrase
                };

                foreach (var sortColumn in sortColumns)
                {
                    yield return new object[] { sortColumn, SortDirection.ASC };
                    yield return new object[] { sortColumn, SortDirection.DESC };
                }
            }
        }

        private class AdminPresentationPublic : AdminPresentation
        {
            public AdminPresentationPublic
                (IMapper mapper,
                ILessonRepository lessonRepository,
                IExerciseRepository exerciseRepository,
                IUnrecognizedWordRepository unrecognizedWordRepository,
                IRecognizer recognizer)
                : base(mapper,
                      lessonRepository,
                      exerciseRepository,
                      unrecognizedWordRepository,
                      recognizer)
            {
            }

            public IQueryable<ExerciseDB> SortExercisesPublic(IQueryable<ExerciseDB> dbExercises,
                SortColumn sortColumn, SortDirection sortDirection)
            {
                return SortExercises(dbExercises, sortColumn, sortDirection);
            }
        }
    }
}
