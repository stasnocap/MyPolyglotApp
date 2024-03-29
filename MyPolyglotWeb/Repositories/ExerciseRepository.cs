﻿using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Repositories.IRepositories;
using System;
using System.Linq;

namespace MyPolyglotWeb.Models
{
    public class ExerciseRepository : BaseRepository<ExerciseDB>, IExerciseRepository
    {
        private Random _random;

        public ExerciseRepository(WebContext webContext, Random random) : base(webContext)
        {
            _random = random;
        }

        public ExerciseDB GetRandomExercise(long lessonId)
        {
            var filteredById = _dbSet.Where(x => x.Lesson.Id == lessonId).ToArray();
            return filteredById.Length > 0 
                ? filteredById[_random.Next(filteredById.Length)]
                : null;
        }

        public bool IsExist(string engPhrase, long lessonId)
        {
            return _dbSet.FirstOrDefault(x => x.EngPhrase == engPhrase && x.Lesson.Id == lessonId) != null;
        }
    }
}
