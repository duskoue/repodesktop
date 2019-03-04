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
  public  class RazduzenjaMBServices : IServices<RazduzenjaMB>
    {
        MpContext mp;
        GenericRepository<RazduzenjaMB> repoRazduzenjeMB;
        public RazduzenjaMBServices()
        {
            mp = new MpContext("InfoContext");
            repoRazduzenjeMB = new GenericRepository<RazduzenjaMB>(mp);
        }

        public void Add(RazduzenjaMB entity)
        {
            repoRazduzenjeMB.Add(entity);
        }

        public void AddRange(IEnumerable<RazduzenjaMB> entities)
        {
            repoRazduzenjeMB.AddRange(entities);
        }

        public RazduzenjaMB Find(Expression<Func<RazduzenjaMB, bool>> predicate)
        {
            return repoRazduzenjeMB.Find(predicate);
        }

        public RazduzenjaMB Get(int id)
        {
            return repoRazduzenjeMB.Get(id);
        }

        public IEnumerable<RazduzenjaMB> GetAll()
        {
            return repoRazduzenjeMB.GetAll().ToList();
        }

        public void Remove(RazduzenjaMB entity)
        {
            repoRazduzenjeMB.Remove(entity);
        }

        public void RemoveEntity(RazduzenjaMB entityToDelete)
        {
            repoRazduzenjeMB.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<RazduzenjaMB> entities)
        {
            repoRazduzenjeMB.RemoveRange(entities);
        }

        public void UpdateEntity(RazduzenjaMB entityToUpdate)
        {
            repoRazduzenjeMB.UpdateEntity(entityToUpdate);
        }
    }
}
