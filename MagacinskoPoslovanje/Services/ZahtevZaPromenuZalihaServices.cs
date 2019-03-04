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
  public  class ZahtevZaPromenuZalihaServices : IServices<ZahtevZaPromenuZaliha>
    {
        MpContext mp;
        GenericRepository<ZahtevZaPromenuZaliha> repoZahtevZaPromenuZaliha;
        public ZahtevZaPromenuZalihaServices()
        {
            mp = new MpContext("InfoContext");
            repoZahtevZaPromenuZaliha = new GenericRepository<ZahtevZaPromenuZaliha>(mp);
        }

        public void Add(ZahtevZaPromenuZaliha entity)
        {
            repoZahtevZaPromenuZaliha.Add(entity);
        }

        public void AddRange(IEnumerable<ZahtevZaPromenuZaliha> entities)
        {
            repoZahtevZaPromenuZaliha.AddRange(entities);
        }

        public ZahtevZaPromenuZaliha Find(Expression<Func<ZahtevZaPromenuZaliha, bool>> predicate)
        {
            return repoZahtevZaPromenuZaliha.Find(predicate);
        }

        public ZahtevZaPromenuZaliha Get(int id)
        {
            return repoZahtevZaPromenuZaliha.Get(id);
        }

        public IEnumerable<ZahtevZaPromenuZaliha> GetAll()
        {
            return repoZahtevZaPromenuZaliha.GetAll().ToList();
        }

        public void Remove(ZahtevZaPromenuZaliha entity)
        {
            repoZahtevZaPromenuZaliha.Remove(entity);
        }

        public void RemoveEntity(ZahtevZaPromenuZaliha entityToDelete)
        {
            repoZahtevZaPromenuZaliha.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<ZahtevZaPromenuZaliha> entities)
        {
            repoZahtevZaPromenuZaliha.RemoveRange(entities);
        }

        public void UpdateEntity(ZahtevZaPromenuZaliha entityToUpdate)
        {
            repoZahtevZaPromenuZaliha.UpdateEntity(entityToUpdate);
        }
    }
}
