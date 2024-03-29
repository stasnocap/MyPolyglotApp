﻿using MyPolyglotWeb.Models.DomainModels;

namespace MyPolyglotWeb.Repositories.IRepositories
{
    public interface ILessonRepository : IBaseRepository<LessonDB>
    {
        public bool IsExist(string lessonName);
    }
}
