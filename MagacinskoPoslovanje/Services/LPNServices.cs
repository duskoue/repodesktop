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
   public class LPNServices : IServices<LPN>
    {
        MpContext mp;
        GenericRepository<LPN> repoLPN;
        public LPNServices()
        {
            mp = new MpContext("InfoContext");
            repoLPN = new GenericRepository<LPN>(mp);
        }

        public void Add(LPN entity)
        {
            repoLPN.Add(entity);
        }

        public void AddRange(IEnumerable<LPN> entities)
        {
            repoLPN.AddRange(entities);
        }

        public LPN Find(Expression<Func<LPN, bool>> predicate)
        {
            return repoLPN.Find(predicate);
        }

        public LPN Get(int id)
        {
            return repoLPN.Get(id);
        }

        public IEnumerable<LPN> GetAll()
        {
            return repoLPN.GetAll().ToList();
        }

        public void Remove(LPN entity)
        {
            repoLPN.Remove(entity);
        }

        public void RemoveEntity(LPN entityToDelete)
        {
            repoLPN.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<LPN> entities)
        {
            repoLPN.RemoveRange(entities);
        }

        public void UpdateEntity(LPN entityToUpdate)
        {
            repoLPN.UpdateEntity(entityToUpdate);
        }
    }
}
