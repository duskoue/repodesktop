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
   public class NerazduzeniMBServices :IServices<NerazduzeniMB>
    {
        MpContext mp;
        GenericRepository<NerazduzeniMB> repoNerazduzeniMB;
        public NerazduzeniMBServices()
        {
            mp = new MpContext("InfoContext");
            repoNerazduzeniMB = new GenericRepository<NerazduzeniMB>(mp);
        }

        public void Add(NerazduzeniMB entity)
        {
            repoNerazduzeniMB.Add(entity);
        }

        public void AddRange(IEnumerable<NerazduzeniMB> entities)
        {
            repoNerazduzeniMB.AddRange(entities);
        }

        public NerazduzeniMB Find(Expression<Func<NerazduzeniMB, bool>> predicate)
        {
           return repoNerazduzeniMB.Find(predicate);
        }

        public NerazduzeniMB Get(int id)
        {
           return repoNerazduzeniMB.Get(id);
        }

        public IEnumerable<NerazduzeniMB> GetAll()
        {
            return repoNerazduzeniMB.GetAll().ToList();
        }

        public void Remove(NerazduzeniMB entity)
        {
            repoNerazduzeniMB.Remove(entity);
        }

        public void RemoveEntity(NerazduzeniMB entityToDelete)
        {
            repoNerazduzeniMB.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<NerazduzeniMB> entities)
        {
            repoNerazduzeniMB.RemoveRange(entities);
        }

        public void UpdateEntity(NerazduzeniMB entityToUpdate)
        {
            repoNerazduzeniMB.UpdateEntity(entityToUpdate);
        }
    }
}
