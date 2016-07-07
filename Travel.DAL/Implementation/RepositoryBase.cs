using Travel.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Travel.DAL.Implementation
{
    public class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private TravelEntities travelContext;
        private DbSet<TEntity> dbSet;

        public DbSet<TEntity> DbSet
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

        public TEntity Find (int id)
        {
            return dbSet.Find(id);
        }

        public void Update(TEntity entity, int id)
        {
            var existingEntity = dbSet.Find(id);
            if(existingEntity == null)
            {
                return;
            }

            travelContext.Entry(existingEntity).CurrentValues.SetValues(entity);
            travelContext.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            dbSet.Remove(entity);
            travelContext.SaveChanges();
        }

        public void Add(TEntity entity)
        {
            dbSet.Add(entity);
            travelContext.SaveChanges();
        }

        public void DeleteByID(int id)
        {
            var journeyType = dbSet.Find(id);
            dbSet.Remove(journeyType);
        }
    }
}
