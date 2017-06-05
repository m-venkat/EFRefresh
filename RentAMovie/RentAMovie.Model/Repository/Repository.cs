using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace RentAMovie.Model.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;
        private readonly DbSet<TEntity> _dbSet;

        public Repository(DbContext context)
        {
            Context = context;
            _dbSet = Context.Set<TEntity>();
        }

        public void Add(TEntity entityToAdd)
        {
            _dbSet.Add(entityToAdd);
        }

        public void AddRange(IEnumerable<TEntity> entitites)
        {
            _dbSet.AddRange(entitites);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Remove(TEntity entityToRemove)
        {
            _dbSet.Remove(entityToRemove);
        }

        public void RemoveRange(IEnumerable<TEntity> entitiesToRemove)
        {
            _dbSet.RemoveRange(entitiesToRemove);
        }
    }
}