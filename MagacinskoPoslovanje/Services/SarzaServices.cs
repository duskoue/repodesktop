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
   public class SarzaServices : IServices<Sarza>
    {
        MpContext mp;
        GenericRepository<Sarza> repoSarza;
        public SarzaServices()
        {
            mp = new MpContext("InfoContext");
            repoSarza = new GenericRepository<Sarza>(mp);
        }

        public void Add(Sarza entity)
        {
            repoSarza.Add(entity);
        }

        public void AddRange(IEnumerable<Sarza> entities)
        {
            repoSarza.AddRange(entities);
        }

        public Sarza Find(Expression<Func<Sarza, bool>> predicate)
        {
            return repoSarza.Find(predicate);
        }

        public Sarza Get(int id)
        {
            return repoSarza.Get(id);
        }

        public IEnumerable<Sarza> GetAll()
        {
            return repoSarza.GetAll().ToList();
        }

        public void Remove(Sarza entity)
        {
            repoSarza.Remove(entity);
        }

        public void RemoveEntity(Sarza entityToDelete)
        {
            repoSarza.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<Sarza> entities)
        {
            repoSarza.RemoveRange(entities);
        }

        public void UpdateEntity(Sarza entityToUpdate)
        {
            repoSarza.UpdateEntity(entityToUpdate);
        }
    }
}
