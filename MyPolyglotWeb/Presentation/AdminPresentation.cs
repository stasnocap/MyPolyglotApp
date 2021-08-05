using AutoMapper;
using MyPolyglotCore;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Models.ViewModels;
using MyPolyglotWeb.Repositories.IRepository;
using System.Collections.Generic;
using System.Linq;

namespace MyPolyglotWeb.Presentation
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

        public void AddExercise(AddExerciseVM viewModel)
        {
            var exerciseDB = _mapper.Map<ExerciseDB>(viewModel);
            exerciseDB.Lesson = _lessonRepository.Get(long.TryParse(viewModel.LessonId, out long result) ? result : -1); 

            _exerciseRepository.Save(exerciseDB);

            var a = 1;
        }

        public IEnumerable<UnrecognizedWordVM> GetUnrecognizedWords(string engPhrase)
        {
            var recognizer = new Recognizer(engPhrase);
            recognizer.Recognize();

            var unrecognizedWords = recognizer.UnrecognizedWords
                .Select(x => new UnrecognizedWordVM() { Text = x.Text });

            return unrecognizedWords;
        }
    }
}
