using AutoMapper;
using MyPolyglotCore;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Models.ViewModels;
using MyPolyglotWeb.Repositories.IRepositories;
using System.Collections.Generic;
using System.Linq;

namespace MyPolyglotWeb.Presentations
{
    public class AdminPresentation
    {
        public ILessonRepository _lessonRepository;
        public IExerciseRepository _exerciseRepository;
        public IMapper _mapper;

        public AdminPresentation(IMapper mapper, ILessonRepository lessonRepository, 
            IExerciseRepository exerciseRepository)
        {
            _mapper = mapper;
            _lessonRepository = lessonRepository;
            _exerciseRepository = exerciseRepository;
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

        public void DeleteExercise(long exerciseId)
        {
            _exerciseRepository.Remove(exerciseId);
        }
    }
}
