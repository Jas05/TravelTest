using Travel_DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Travel_DAL.Implementation
{
    public class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private TravelEntities travelContext;
        private DbSet<TEntity> dbSet;

        public DbSet<TEntity> MyProperty
        {
            get { return dbSet; }
        }

        public RepositoryBase(TravelEntities _travelContext)
        {
            this.travelContext = _travelContext;
            this.dbSet = travelContext.Set<TEntity>();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return dbSet;
        }

        public TEntity GetByID(Expression<Func<TEntity, bool>> predicate )
        {
            return dbSet.FirstOrDefault(predicate);
        }

        public TEntity GetSingle(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity GetByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
