using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using MyPolyglotCore;
using MyPolyglotCore.Words;
using MyPolyglotWeb.Models.ViewModels;
using MyPolyglotWeb.Repositories.IRepository;

namespace MyPolyglotWeb.Presentation
{
    public class HomePresentation
    {
        private IMapper _mapper;
        private IExerciseRepository _exerciseRepository;

        public HomePresentation(IMapper mapper, IExerciseRepository exerciseRepository)
        {
            _mapper = mapper;
            _exerciseRepository = exerciseRepository;
        }

        public ExerciseVM GetExerciseVM(long id)
        {
            var exerciseDB = _exerciseRepository.GetRandomExerciseByLessonId(id);

            var exercise = new Exercise(exerciseDB.EngPhrase, _mapper.Map<IEnumerable<Word>>(exerciseDB.UnrecognizedWords));

            var exerciseVM = _mapper.Map<ExerciseVM>(exerciseDB);

            exerciseVM.OptionGroups = exercise.Words.Select(x => new OptionGroup() { Options = exercise.NextOptions() }).ToList();

            return exerciseVM;
        }
    }
}