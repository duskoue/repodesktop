using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagacinskoPoslovanje.Data;
using MagacinskoPoslovanje.Context;
using System.Linq.Expressions;

namespace MagacinskoPoslovanje.Services
{
   public class RolaServices : IServices<Rola>
    {
        MpContext mp;
        GenericRepository<Rola> repoRola;
        public RolaServices()
        {
            mp = new MpContext("InfoContext");
            repoRola = new GenericRepository<Rola>(mp);
        }

        public void Add(Rola entity)
        {
            repoRola.Add(entity);
        }

        public void AddRange(IEnumerable<Rola> entities)
        {
            repoRola.AddRange(entities);
        }

        public Rola Find(Expression<Func<Rola, bool>> predicate)
        {
            return repoRola.Find(predicate);
        }

        public Rola Get(int id)
        {
            return repoRola.Get(id);
        }

        public IEnumerable<Rola> GetAll()
        {
            return repoRola.GetAll().ToList();
        }

        public void Remove(Rola entity)
        {
            repoRola.Remove(entity);
        }

        public void RemoveEntity(Rola entityToDelete)
        {
            repoRola.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<Rola> entities)
        {
            repoRola.RemoveRange(entities);
        }

        public void UpdateEntity(Rola entityToUpdate)
        {
            repoRola.UpdateEntity(entityToUpdate);
        }
    }
}
