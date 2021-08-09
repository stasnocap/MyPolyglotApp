using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using MyPolyglotCore;
using MyPolyglotWeb.Models.ViewModels;
using MyPolyglotWeb.Repositories.IRepository;

namespace MyPolyglotWeb.Presentation
{
    public class HomePresentation
    {
        private IMapper _mapper;
        private ILessonRepository _lessonRepository;
        private IExerciseRepository _exerciseRepository;

        public HomePresentation(IMapper mapper, ILessonRepository lessonRepository, IExerciseRepository exerciseRepository)
        {
            _mapper = mapper;
            _lessonRepository = lessonRepository;
            _exerciseRepository = exerciseRepository;
        }

        public ExerciseVM GetExerciseVM(long id)
        {
            var exerciseDB = _exerciseRepository.GetRandomExerciseByLessonId(id);
            return _mapper.Map<ExerciseVM>(exerciseDB);
        }
    }
}