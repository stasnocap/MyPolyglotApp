using AutoMapper;
using Castle.Core.Internal;
using MyPolyglotCore.Interfaces;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Models.ViewModels;
using MyPolyglotWeb.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyPolyglotWeb.Presentations
{
    public class AdminPresentation
    {
        public ILessonRepository _lessonRepository;
        public IExerciseRepository _exerciseRepository;
        public IUnrecognizedWordRepository _unrecognizedWordRepository;
        public IMapper _mapper;
        public IRecognizer _recognizer;

        public AdminPresentation(IMapper mapper, ILessonRepository lessonRepository,
            IExerciseRepository exerciseRepository, IUnrecognizedWordRepository unrecognizedWordRepository,
            IRecognizer recognizer)
        {
            _mapper = mapper;
            _lessonRepository = lessonRepository;
            _exerciseRepository = exerciseRepository;
            _unrecognizedWordRepository = unrecognizedWordRepository;
            _recognizer = recognizer;
        }

        public void AddExercise(AddExerciseVM addExerciseVM)
        {
            var exerciseDB = _mapper.Map<ExerciseDB>(addExerciseVM);

            exerciseDB.Lesson = _lessonRepository.Get(long.Parse(addExerciseVM.LessonId));

            _exerciseRepository.Save(exerciseDB);
        }

        public IEnumerable<UnrecognizedWordVM> GetUnrecognizedWords(string engPhrase)
        {
            _recognizer.Recognize(engPhrase);

            return _mapper.Map<IEnumerable<UnrecognizedWordVM>>(_recognizer.UnrecognizedWords);
        }

        public AllExercisesVM GetAllExercisesVM(int page, int pageSize, SortColumn sortColumn, SortDirection sortDirection)
        {
            var dbExercises = _exerciseRepository.GetAll();
            var sortedExercises = SortExercises(dbExercises, sortColumn, sortDirection);

            sortedExercises = sortedExercises
                .Skip(page * pageSize)
                .Take(pageSize);

            var allExercisesVM = _mapper.Map<AllExercisesVM>(sortedExercises.ToList());

            allExercisesVM.PaginatorVM = new PaginatorVM()
            {
                Page = page,
                PageSize = pageSize,
                TotalRecordCount = dbExercises.Count(),
                SortColumn = sortColumn,
                SortDirection = sortDirection,
            };

            return allExercisesVM;
        }

        private IQueryable<ExerciseDB> SortExercises(IQueryable<ExerciseDB> dbExercises, SortColumn sortColumn, SortDirection sortDirection)
        {
            dbExercises = sortColumn switch
            {
                SortColumn.LessonId => dbExercises.OrderBy(x => x.Lesson.Id),
                SortColumn.RusPhrase => dbExercises.OrderBy(x => x.RusPhrase),
                SortColumn.EngPhrase => dbExercises.OrderBy(x => x.EngPhrase),
                _ => throw new NotImplementedException(),
            };

            if (sortDirection == SortDirection.DESC)
            {
                dbExercises = dbExercises.Reverse();
            }

            return dbExercises;
        }

        public void UpdateExercises(AllExercisesVM allExercisesVM)
        {
            foreach (var exercise in allExercisesVM.Exercises)
            {
                if (exercise.UnrecognizedWords != null)
                {
                    var unrecognizedWordsThatShouldBeRemoved = new List<UnrecognizedWordVM>();
                    foreach (var unrecognizedWordVM in exercise.UnrecognizedWords)
                    {
                        if (unrecognizedWordVM.Text.IsNullOrEmpty())
                        {
                            _unrecognizedWordRepository.Remove(unrecognizedWordVM.UnrecognizedWordId);
                            unrecognizedWordsThatShouldBeRemoved.Add(unrecognizedWordVM);
                        }
                        else
                        {
                            var unrecognizedWordDB = _mapper.Map<UnrecognizedWordDB>(unrecognizedWordVM);
                            _unrecognizedWordRepository.Save(unrecognizedWordDB);
                        }
                    }
                    exercise.UnrecognizedWords.RemoveAll(x => unrecognizedWordsThatShouldBeRemoved.Contains(x));
                    }

                var exerciseDB = _mapper.Map<ExerciseDB>(exercise);
                _exerciseRepository.Save(exerciseDB);
            }
        }

        public void DeleteExercise(long exerciseId)
        {
            _exerciseRepository.Remove(exerciseId);
        }
    }
}
