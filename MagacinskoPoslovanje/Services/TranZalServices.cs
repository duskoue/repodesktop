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
   public class TranZalServices : IServices<TranZal>
    {
        MpContext mp;
        GenericRepository<TranZal> repoTranzAL;
        public TranZalServices()
        {
            mp = new MpContext("InfoContext");
            repoTranzAL = new GenericRepository<TranZal>(mp);
        }

        public void Add(TranZal entity)
        {
            repoTranzAL.Add(entity);
        }

        public void AddRange(IEnumerable<TranZal> entities)
        {
            repoTranzAL.AddRange(entities);
        }

        public TranZal Find(Expression<Func<TranZal, bool>> predicate)
        {
            return repoTranzAL.Find(predicate);
        }

        public TranZal Get(int id)
        {
            return repoTranzAL.Get(id);
        }

        public IEnumerable<TranZal> GetAll()
        {
            return repoTranzAL.GetAll().ToList();

        }

        public void Remove(TranZal entity)
        {
            repoTranzAL.Remove(entity);
        }

        public void RemoveEntity(TranZal entityToDelete)
        {
            repoTranzAL.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<TranZal> entities)
        {
            repoTranzAL.RemoveRange(entities);
        }

        public void UpdateEntity(TranZal entityToUpdate)
        {
            repoTranzAL.UpdateEntity(entityToUpdate);
        }
    }
}
