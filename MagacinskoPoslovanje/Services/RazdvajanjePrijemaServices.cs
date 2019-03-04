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
  public  class RazdvajanjePrijemaServices :IServices<RazdvajanjePrijema>
    {
        MpContext mp;
        GenericRepository<RazdvajanjePrijema> repoRazdvajanjePrijema;
        public RazdvajanjePrijemaServices()
        {
            mp = new MpContext("InfoContext");
            repoRazdvajanjePrijema = new GenericRepository<RazdvajanjePrijema>(mp);
        }

        public void Add(RazdvajanjePrijema entity)
        {
            repoRazdvajanjePrijema.Add(entity);
        }

        public void AddRange(IEnumerable<RazdvajanjePrijema> entities)
        {
            repoRazdvajanjePrijema.AddRange(entities);
        }

        public RazdvajanjePrijema Find(Expression<Func<RazdvajanjePrijema, bool>> predicate)
        {
            return repoRazdvajanjePrijema.Find(predicate);
        }

        public RazdvajanjePrijema Get(int id)
        {
            return repoRazdvajanjePrijema.Get(id);
        }

        public IEnumerable<RazdvajanjePrijema> GetAll()
        {
            return repoRazdvajanjePrijema.GetAll().ToList();
        }

        public void Remove(RazdvajanjePrijema entity)
        {
            repoRazdvajanjePrijema.Remove(entity);
        }

        public void RemoveEntity(RazdvajanjePrijema entityToDelete)
        {
            repoRazdvajanjePrijema.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<RazdvajanjePrijema> entities)
        {
            repoRazdvajanjePrijema.RemoveRange(entities);
        }

        public void UpdateEntity(RazdvajanjePrijema entityToUpdate)
        {
            repoRazdvajanjePrijema.UpdateEntity(entityToUpdate);
        }
    }
}
