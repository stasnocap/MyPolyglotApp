using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using MyPolyglotCore;
using MyPolyglotCore.Words;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Models.ViewModels;
using MyPolyglotWeb.Repositories.IRepositories;
using MyPolyglotWeb.Services.IServices;

namespace MyPolyglotWeb.Presentations
{
    public class HomePresentation
    {
        private IMapper _mapper;
        private IExerciseRepository _exerciseRepository;
        private IUserService _userService;
        private IScoreRepository _scoreRepository;
        private ILessonRepository _lessonRepository;

        public HomePresentation(IMapper mapper, IExerciseRepository exerciseRepository, IUserService userService, IScoreRepository scoreRepository, ILessonRepository lessonRepository)
        {
            _mapper = mapper;
            _exerciseRepository = exerciseRepository;
            _userService = userService;
            _scoreRepository = scoreRepository;
            _lessonRepository = lessonRepository;
        }

        public ExerciseVM GetExerciseVM(long lessonId)
        {
            var exerciseDB = _exerciseRepository.GetRandomExercise(lessonId);

            var exercise = new Exercise(exerciseDB.EngPhrase, _mapper.Map<IEnumerable<Word>>(exerciseDB.UnrecognizedWords));

            var exerciseVM = _mapper.Map<ExerciseVM>(exerciseDB);

            exerciseVM.OptionGroups = exercise.Words.Select(x => new OptionGroup() { Options = exercise.NextOptions().ToList() }).ToList();

            exerciseVM.LessonId = lessonId;

            return exerciseVM;
        }

        public bool CheckAnswer(long exerciseId, string userAnswer)
        {
            var exercise = _exerciseRepository.Get(exerciseId);
            return exercise.EngPhrase.SplitToStrings().SequenceEqual(userAnswer.SplitToStrings());
        }

        public void PlusPoint(long lessonId)
        {
            var user = _userService.GetCurrentUser();
            var lesson = _lessonRepository.Get(lessonId);
            var userScore = _scoreRepository.Get(user.Id, lessonId);

            if (userScore != null)
            {
                userScore.Points++;
                _scoreRepository.Save(userScore);
            }
            else
            {
                var score = new ScoreDB()
                {
                    Lesson = lesson,
                    User = user,
                    Points = 1,
                };
                _scoreRepository.Save(score);
            }
        }
    }
}