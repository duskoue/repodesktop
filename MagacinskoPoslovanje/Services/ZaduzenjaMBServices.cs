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
   public class ZaduzenjaMBServices : IServices<ZaduzenjaMB>
    {
        MpContext mp;
        GenericRepository<ZaduzenjaMB> repoZaduzenjaMB;
        public ZaduzenjaMBServices()
        {
            mp = new MpContext("InfoContext");
            repoZaduzenjaMB = new GenericRepository<ZaduzenjaMB>(mp);
        }

        public void Add(ZaduzenjaMB entity)
        {
            repoZaduzenjaMB.Add(entity);
        }

        public void AddRange(IEnumerable<ZaduzenjaMB> entities)
        {
            repoZaduzenjaMB.AddRange(entities);
        }

        public ZaduzenjaMB Find(Expression<Func<ZaduzenjaMB, bool>> predicate)
        {
            return repoZaduzenjaMB.Find(predicate);
        }

        public ZaduzenjaMB Get(int id)
        {
            return repoZaduzenjaMB.Get(id);
        }

        public IEnumerable<ZaduzenjaMB> GetAll()
        {
            return repoZaduzenjaMB.GetAll().ToList();
        }

        public void Remove(ZaduzenjaMB entity)
        {
            repoZaduzenjaMB.Remove(entity);
        }

        public void RemoveEntity(ZaduzenjaMB entityToDelete)
        {
            repoZaduzenjaMB.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<ZaduzenjaMB> entities)
        {
            repoZaduzenjaMB.RemoveRange(entities);
        }

        public void UpdateEntity(ZaduzenjaMB entityToUpdate)
        {
            repoZaduzenjaMB.UpdateEntity(entityToUpdate);
        }
    }
}
