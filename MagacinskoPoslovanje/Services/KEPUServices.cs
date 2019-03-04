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
   public class KEPUServices : IServices<KEPU>
    {
        MpContext mp;
        GenericRepository<KEPU> repoKEPU;
        public KEPUServices()
        {
            mp = new MpContext("InfoContext");
            repoKEPU = new GenericRepository<KEPU>(mp);
        }

        public void Add(KEPU entity)
        {
            repoKEPU.Add(entity);
        }

        public void AddRange(IEnumerable<KEPU> entities)
        {
            repoKEPU.AddRange(entities);
        }

        public KEPU Find(Expression<Func<KEPU, bool>> predicate)
        {
            return repoKEPU.Find(predicate);
        }

        public KEPU Get(int id)
        {
            return repoKEPU.Get(id);
        }

        public IEnumerable<KEPU> GetAll()
        {
            return repoKEPU.GetAll().ToList();
        }

        public void Remove(KEPU entity)
        {
            repoKEPU.Remove(entity);
        }

        public void RemoveEntity(KEPU entityToDelete)
        {
            repoKEPU.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<KEPU> entities)
        {
            repoKEPU.RemoveRange(entities);
        }

        public void UpdateEntity(KEPU entityToUpdate)
        {
            repoKEPU.UpdateEntity(entityToUpdate);
        }
    }
}
