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
   public class NeradniDaniServices :IServices<NeradniDani>
    {
        MpContext mp;
        GenericRepository<NeradniDani> repoNeradniDani;
        public NeradniDaniServices()
        {
            mp = new MpContext("InfoContext");
            repoNeradniDani = new GenericRepository<NeradniDani>(mp);
        }

        public void Add(NeradniDani entity)
        {
            repoNeradniDani.Add(entity);
        }

        public void AddRange(IEnumerable<NeradniDani> entities)
        {
            repoNeradniDani.AddRange(entities);
        }

        public NeradniDani Find(Expression<Func<NeradniDani, bool>> predicate)
        {
            return repoNeradniDani.Find(predicate);
        }

        public NeradniDani Get(int id)
        {
            return repoNeradniDani.Get(id);
        }

        public IEnumerable<NeradniDani> GetAll()
        {
            return repoNeradniDani.GetAll().ToList();
        }

        public void Remove(NeradniDani entity)
        {
            repoNeradniDani.RemoveEntity(entity);
        }

        public void RemoveEntity(NeradniDani entityToDelete)
        {
            repoNeradniDani.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<NeradniDani> entities)
        {
            repoNeradniDani.RemoveRange(entities);
        }

        public void UpdateEntity(NeradniDani entityToUpdate)
        {
            repoNeradniDani.UpdateEntity(entityToUpdate);
        }
    }
}
