using Microsoft.EntityFrameworkCore;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Repositories.IRepository;
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
            var filteredById = _dbSet.Where(x => x.Lesson.Id == lessonId).AsEnumerable();
            return filteredById?.ElementAt(_random.Next(filteredById.Count()));
        }
    }
}
