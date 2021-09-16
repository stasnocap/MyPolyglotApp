using MyPolyglotWeb.Models.DomainModels;
using System.Linq;

namespace MyPolyglotWeb.Repositories.IRepositories
{
    public interface IBaseRepository<DbModel> where DbModel : BaseDB
    {
        DbModel Get(long id);
        void Remove(DbModel model);
        void Remove(long id);
        void Save(DbModel model);
    }
}