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
  public  class OdabirServices : IServices<Odabir>
    {
        MpContext mp;
        GenericRepository<Odabir> repoOdabir;
        public OdabirServices()
        {
            mp = new MpContext("InfoContext");
            repoOdabir = new GenericRepository<Odabir>(mp);
        }

        public void Add(Odabir entity)
        {
            repoOdabir.Add(entity);
        }

        public void AddRange(IEnumerable<Odabir> entities)
        {
            repoOdabir.AddRange(entities);
        }

        public Odabir Find(Expression<Func<Odabir, bool>> predicate)
        {
            return repoOdabir.Find(predicate);
        }

        public Odabir Get(int id)
        {
            return repoOdabir.Get(id);
        }

        public IEnumerable<Odabir> GetAll()
        {
            return repoOdabir.GetAll().ToList();
        }

        public void Remove(Odabir entity)
        {
            repoOdabir.Remove(entity);
        }

        public void RemoveEntity(Odabir entityToDelete)
        {
            repoOdabir.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<Odabir> entities)
        {
            repoOdabir.RemoveRange(entities);
        }

        public void UpdateEntity(Odabir entityToUpdate)
        {
            repoOdabir.UpdateEntity(entityToUpdate);
        }
    }
}
