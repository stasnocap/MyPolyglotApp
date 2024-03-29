﻿using Microsoft.EntityFrameworkCore;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Repositories.IRepositories;
using System.Linq;

namespace MyPolyglotWeb.Models
{
    public abstract class BaseRepository<DbModel> : IBaseRepository<DbModel> where DbModel : BaseDB
    {
        protected WebContext _webContext;
        protected DbSet<DbModel> _dbSet;

        public BaseRepository(WebContext webContext)
        {
            _webContext = webContext;
            _dbSet = _webContext.Set<DbModel>();
        }

        public DbModel Get(long id)
        {
            return _dbSet.SingleOrDefault(x => x.Id == id);
        }

        public virtual void Save(DbModel model)
        {
            if (model.Id > 0)
            {
                DetachLocalIfExist(model.Id);
                if (_webContext.Entry(model).State == EntityState.Detached)
                {
                    _dbSet.Attach(model);
                }

                _webContext.Entry(model).State = EntityState.Modified;
                _webContext.SaveChanges();
                return;
            }

            _dbSet.Add(model);
            _webContext.SaveChanges();
        }

        public void Remove(long id)
        {
            Remove(Get(id));
        }

        public void Remove(DbModel model)
        {
            _dbSet.Remove(model);
            _webContext.SaveChanges();
        }

        private void DetachLocalIfExist(long entryId)
        {
            var local = _webContext.Set<DbModel>()
                .Local
                .FirstOrDefault(entry => entry.Id == entryId);
            if (local != null)
            {
                _webContext.Entry(local).State = EntityState.Detached;
            }
        }

        public IQueryable<DbModel> GetAll()
        {
            return _dbSet;
        }
    }
}
