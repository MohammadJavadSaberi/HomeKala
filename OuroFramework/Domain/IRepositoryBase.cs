using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace OuroFramework.Domain
{
    public interface IRepositoryBase<TKey, T> where T : class
    {
        void Create(T entity);
        List<T> Get();
        T Get(TKey id);
        bool Exists(Expression<Func<T, bool>> expression);
        void Save();
    }
}
