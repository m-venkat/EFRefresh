using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RentAMovie.Model.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        void Add(TEntity entityToAdd);
        void AddRange(IEnumerable<TEntity> entitites);
        void Remove(TEntity entityToRemove);
        void RemoveRange(IEnumerable<TEntity> entitiesToRemove);
    }
}
