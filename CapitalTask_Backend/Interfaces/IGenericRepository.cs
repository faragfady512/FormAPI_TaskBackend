using System.Collections.Generic;

namespace CapitalTask_Backend.Interfaces
{
    public interface IGenericRepository <TEntity> where TEntity : class
    {
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
    }
}
