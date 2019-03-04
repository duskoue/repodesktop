using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Services
{
   
        public interface IRepository<T> where T : class
        {
        IEnumerable<T> Get(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "");

        /// <summary>  
        /// Gets the specified identifier.  
        /// </summary>  
        /// <param name="id">The identifier.</param>  
        /// <returns></returns>  
        T Get(int id);

        /// <summary>  
        /// Gets all.  
        /// </summary>  
        /// <returns></returns>  
        IEnumerable<T> GetAll();

        /// <summary>  
        /// Finds the specified predicate.  
        /// </summary>  
        /// <param name="predicate">The predicate.</param>  
        /// <returns></returns>  
        IEnumerable<T> Find(System.Linq.Expressions.Expression<Func<T, bool>> predicate);

        /// <summary>  
        /// Singles the or default.  
        /// </summary>  
        /// <param name="predicate">The predicate.</param>  
        /// <returns></returns>  
        T SingleOrDefault(System.Linq.Expressions.Expression<Func<T, bool>> predicate);

        /// <summary>  
        /// First the or default.  
        /// </summary>  
        /// <returns></returns>  
        T FirstOrDefault();

        /// <summary>  
        /// Adds the specified entity.  
        /// </summary>  
        /// <param name="entity">The entity.</param>  
        void Add(T entity);

        /// <summary>  
        /// Adds the range.  
        /// </summary>  
        /// <param name="entities">The entities.</param>  
        void AddRange(IEnumerable<T> entities);

        /// <summary>  
        /// Removes the specified entity.  
        /// </summary>  
        /// <param name="entity">The entity.</param>  
        void Remove(T entity);

        /// <summary>  
        /// Removes the range.  
        /// </summary>  
        /// <param name="entities">The entities.</param>  
        void RemoveRange(IEnumerable<T> entities);

        /// <summary>  
        /// Removes the Entity  
        /// </summary>  
        /// <param name="entityToDelete"></param>  
        void RemoveEntity(T entityToDelete);

        /// <summary>  
        /// Update the Entity  
        /// </summary>  
        /// <param name="entityToUpdate"></param>  
        void UpdateEntity(T entityToUpdate);
    }
    }

