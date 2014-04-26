using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cain.Domain.Shared
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Create(TEntity entity);
        void Remove(TEntity entity);
        void Update(TEntity entity);
        TEntity Find(object Id);
        IQueryable<TEntity> FindAll();
        IQueryable<TEntity> FindAllWhere(Func<TEntity, bool> predicate);
        IQueryable<TEntity> FindObjectGraph(Func<TEntity, bool> predicate, string descendants);
    }
}
