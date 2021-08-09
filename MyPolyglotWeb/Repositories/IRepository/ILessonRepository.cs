using MyPolyglotWeb.Models.DomainModels;

namespace MyPolyglotWeb.Repositories.IRepository
{
    public interface ILessonRepository : IBaseRepository<LessonDB>
    {
        public bool IsExistByLessonName(string lessonName);
    }
}
