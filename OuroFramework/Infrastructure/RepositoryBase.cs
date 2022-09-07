using Microsoft.EntityFrameworkCore;
using OuroFramework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace OuroFramework.Infrastructure
{
    public class RepositoryBase<TKey, T> : IRepositoryBase<TKey, T> where T : class
    {
        private readonly DbContext _context;
        public RepositoryBase(DbContext context)
        {
            _context = context;
        }

        public void Create(T entity)
        {
            _context.Add(entity);
            Save();
        }

        public bool Exists(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Any(expression);
        }

        public List<T> Get()
        {
            return _context.Set<T>().ToList();
        }

        public T Get(TKey id)
        {
            return _context.Find<T>(id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
