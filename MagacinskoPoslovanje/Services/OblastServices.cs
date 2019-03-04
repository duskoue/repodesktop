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
   public class OblastServices :IServices<Oblast>
    {
        MpContext mp;
        GenericRepository<Oblast> repoOblast;
        public OblastServices()
        {
            mp = new MpContext("InfoContext");
            repoOblast = new GenericRepository<Oblast>(mp);
        }

        public void Add(Oblast entity)
        {
            repoOblast.Add(entity);
        }

        public void AddRange(IEnumerable<Oblast> entities)
        {
            repoOblast.AddRange(entities);
        }

        public Oblast Find(Expression<Func<Oblast, bool>> predicate)
        {
            return repoOblast.Find(predicate);
        }

        public Oblast Get(int id)
        {
            return repoOblast.Get(id);
        }

        public IEnumerable<Oblast> GetAll()
        {
            return repoOblast.GetAll().ToList();
        }

        public void Remove(Oblast entity)
        {
            repoOblast.Remove(entity);
        }

        public void RemoveEntity(Oblast entityToDelete)
        {
            repoOblast.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<Oblast> entities)
        {
            repoOblast.RemoveRange(entities);
        }

        public void UpdateEntity(Oblast entityToUpdate)
        {
            repoOblast.UpdateEntity(entityToUpdate);
        }
    }
}
