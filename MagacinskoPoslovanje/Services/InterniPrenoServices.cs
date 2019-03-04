using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MagacinskoPoslovanje.Context;
using MagacinskoPoslovanje.Data;

namespace MagacinskoPoslovanje.Services
{
   public class InterniPrenoServices : IServices<InterniPreno>
    {
        MpContext mp;
        GenericRepository<InterniPreno> repoInterniPreno;
        public InterniPrenoServices()
        {
            mp = new MpContext("InfoContext");
            repoInterniPreno = new GenericRepository<InterniPreno>(mp);
        }

        public void Add(InterniPreno entity)
        {
            repoInterniPreno.Add(entity);
        }

        public void AddRange(IEnumerable<InterniPreno> entities)
        {
            repoInterniPreno.AddRange(entities);
        }

        public InterniPreno Find(Expression<Func<InterniPreno, bool>> predicate)
        {
            return repoInterniPreno.Find(predicate);
        }

        public InterniPreno Get(int id)
        {
           return repoInterniPreno.Get(id);
        }

        public IEnumerable<InterniPreno> GetAll()
        {
            return repoInterniPreno.GetAll().ToList();
        }

        public void Remove(InterniPreno entity)
        {
            repoInterniPreno.Remove(entity);
        }

        public void RemoveEntity(InterniPreno entityToDelete)
        {
            repoInterniPreno.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<InterniPreno> entities)
        {
            repoInterniPreno.RemoveRange(entities);
        }

        public void UpdateEntity(InterniPreno entityToUpdate)
        {
            repoInterniPreno.UpdateEntity(entityToUpdate);
        }
    }
}
