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

        public DoExerciseVM GetExerciseVM(long lessonId)
        {
            var exerciseDB = _exerciseRepository.GetRandomExercise(lessonId);

            var exercise = new Exercise(exerciseDB.EngPhrase, _mapper.Map<IEnumerable<Word>>(exerciseDB.UnrecognizedWords));

            var exerciseVM = _mapper.Map<DoExerciseVM>(exerciseDB);

            exerciseVM.OptionGroups = exercise.Words.Select(x => new OptionGroupVM() { Options = exercise.NextOptions().ToList() }).ToList();

            exerciseVM.LessonId = lessonId;

            exerciseVM.UserPoints = GetCurrentUserPoints(lessonId);

            return exerciseVM;
        }

        private int GetCurrentUserPoints(long lessonId)
        {
            var user = _userService.GetCurrentUser();

            if (user == null)
            {
                return -1;
            }

            var score = _scoreRepository.Get(user.Id, lessonId);

            if (score != null)
            {
                return score.Points;
            }

            var initialScore = new ScoreDB()
            {
                Lesson = _lessonRepository.Get(lessonId),
                User = user,
                Points = 0
            };

            _scoreRepository.Save(initialScore);

            return initialScore.Points;
        }

        public bool CheckAnswer(long exerciseId, string userAnswer)
        {
            var exercise = _exerciseRepository.Get(exerciseId);
            return exercise.EngPhrase.SplitToStrings().SequenceEqual(userAnswer.SplitToStrings());
        }

        public void PlusPoint(long lessonId)
        {
            var userId = _userService.GetCurrentUserId();
            var userScore = _scoreRepository.Get(userId, lessonId);

            userScore.Points++;
            _scoreRepository.Save(userScore);
        }

        public void MinusPoint(long lessonId)
        {
            var user = _userService.GetCurrentUser();
            var userScore = _scoreRepository.Get(user.Id, lessonId);

            if (userScore.Points >= 0.5)
            {
                userScore.Points -= 0.5;
                _scoreRepository.Save(userScore);
            }
        }
    }
}