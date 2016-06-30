using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Travel.DAL.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetByID(Expression<Func<TEntity, bool>> predicate);

        TEntity Find(Expression<Func<TEntity, bool>> predicate);

        void Update(TEntity entity, int id);

        void Delete(TEntity entity);

        void Add(TEntity entity);

    }
}