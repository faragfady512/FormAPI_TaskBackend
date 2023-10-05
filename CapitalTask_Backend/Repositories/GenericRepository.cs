using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
using CapitalTask_Backend.Interfaces;
using CaptialTask_Backend.Data;
using System.Linq;

namespace CapitalTask_Backend.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly TaskBackendContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(TaskBackendContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public TEntity GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var entity = _dbSet.Find(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
            }
        }
    }

}
