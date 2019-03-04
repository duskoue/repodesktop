using MagacinskoPoslovanje.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Services
{
   public interface IServices<T>
    {
       
        T Get(int id);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);

        void Remove(T entity);
        
        void UpdateEntity(T entityToUpdate);
        void RemoveRange(IEnumerable<T> entities);
        void RemoveEntity(T entityToDelete);
       

        T Find(System.Linq.Expressions.Expression<Func<T, bool>> predicate);
    }
}
