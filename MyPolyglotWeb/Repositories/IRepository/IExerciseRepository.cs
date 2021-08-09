﻿using MyPolyglotWeb.Models.DomainModels;

namespace MyPolyglotWeb.Repositories.IRepository
{
    public interface IExerciseRepository : IBaseRepository<ExerciseDB>
    {
        ExerciseDB GetRandomExerciseByLessonId(long id);
    }
}
