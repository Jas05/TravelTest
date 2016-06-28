using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_DAL.Interfaces
{
    interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetByID(int id);

        TEntity GetSingle(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        void Add(TEntity entity);

    }
}