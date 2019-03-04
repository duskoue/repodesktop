using MagacinskoPoslovanje.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using MagacinskoPoslovanje.Data;

namespace MagacinskoPoslovanje.Services
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly MpContext _dbContext;
        protected DbSet<T> Entities;
        
        public GenericRepository(MpContext dbContext)
        {
            _dbContext = dbContext;
            Entities = dbContext.Set<T>();
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
        {
            IQueryable<T> query = Entities;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        internal IEnumerable<SifarnikEntiteta> where(Expression<Func<SifarnikEntiteta, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            return Entities.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return Entities.ToList();
        }

        public IEnumerable<T> Find1(Expression<Func<T, bool>> predicate)
        {
            return Entities.Where(predicate);
        }

        public T Find(Expression<Func<T, bool>> predicate)
        {
            return Entities.Where(predicate).SingleOrDefault();
        }

        public T FirstOrDefault()
        {
            return Entities.SingleOrDefault();
        }

        public void Add(T entity)
        {
            Entities.Add(entity);
            _dbContext.SaveChanges();
        }

        public void AddRange(IEnumerable<T> entities)
        {
            Entities.AddRange(entities);
            _dbContext.SaveChanges();
        }

        public void Remove(T entity)
        {
            Entities.Remove(entity);
            _dbContext.SaveChanges();
        }

        

        public void RemoveEntity(T entityToDelete)
        {
            if (_dbContext.Entry(entityToDelete).State == EntityState.Detached)
            {
                Entities.Attach(entityToDelete);
            }
            Entities.Remove(entityToDelete);
            _dbContext.SaveChanges();
        }

        public void UpdateEntity(T entityToUpdate)
        {
            Entities.Attach(entityToUpdate);
            _dbContext.Entry(entityToUpdate).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            Entities.RemoveRange(entities);
            _dbContext.SaveChanges();
        }

        IEnumerable<T> IRepository<T>.Find(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public T SingleOrDefault(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public static implicit operator GenericRepository<T>(GenericRepository<SifarnikEntiteta> v)
        {
            throw new NotImplementedException();
        }
    }
}
