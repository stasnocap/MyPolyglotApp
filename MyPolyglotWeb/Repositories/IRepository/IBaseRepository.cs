using MyPolyglotWeb.Models.DomainModels;
using System.Linq;

namespace MyPolyglotWeb.Repositories.IRepository
{
    public interface IBaseRepository<DbModel> where DbModel : BaseDbModel
    {
        int Count();
        DbModel Get(long id);
        IQueryable<DbModel> GetAll();
        bool IsAny();
        void Remove(DbModel model);
        void Remove(long id);
        void Save(DbModel model);
    }
}