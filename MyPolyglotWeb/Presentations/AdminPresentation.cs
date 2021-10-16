using AutoMapper;
using Castle.Core.Internal;
using MyPolyglotCore;
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

        public AdminPresentation(IMapper mapper, ILessonRepository lessonRepository,
            IExerciseRepository exerciseRepository, IUnrecognizedWordRepository unrecognizedWordRepository)
        {
            _mapper = mapper;
            _lessonRepository = lessonRepository;
            _exerciseRepository = exerciseRepository;
            _unrecognizedWordRepository = unrecognizedWordRepository;
        }

        public void AddExercise(AddExerciseVM addExerciseVM)
        {
            var exerciseDB = _mapper.Map<ExerciseDB>(addExerciseVM);
            exerciseDB.Lesson = _lessonRepository.Get(long.TryParse(addExerciseVM.LessonId, out long result) ? result : -1);

            _exerciseRepository.Save(exerciseDB);
        }

        public IEnumerable<UnrecognizedWordVM> GetUnrecognizedWords(string engPhrase)
        {
            var recognizer = new Recognizer(engPhrase);
            recognizer.Recognize();

            return _mapper.Map<IEnumerable<UnrecognizedWordVM>>(recognizer.UnrecognizedWords);
        }

        public AllExercisesVM GetAllExercisesVM()
        {
            var exercisesDB = _exerciseRepository.GetAll().ToList();
            return _mapper.Map<AllExercisesVM>(exercisesDB);
        }

        public void UpdateExercises(AllExercisesVM allExercisesVM)
        {
            foreach (var exercise in allExercisesVM.Exercises)
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
                        _unrecognizedWordRepository.Save(_mapper.Map<UnrecognizedWordDB>(unrecognizedWordVM));
                    }
                }
                exercise.UnrecognizedWords.RemoveAll(x => unrecognizedWordsThatShouldBeRemoved.Contains(x));

                _exerciseRepository.Save(_mapper.Map<ExerciseDB>(exercise));
            }
        }

        public void DeleteExercise(long exerciseId)
        {
            _exerciseRepository.Remove(exerciseId);
        }
    }
}
