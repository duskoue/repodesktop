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
  public  class SastavnicaPrijemServices : IServices<SastavnicaPrijem>
    {
        MpContext mp;
        GenericRepository<SastavnicaPrijem> repoSastavnicaPrijem;
        public SastavnicaPrijemServices()
        {
            mp = new MpContext("InfoContext");
            repoSastavnicaPrijem = new GenericRepository<SastavnicaPrijem>(mp);
        }

        public void Add(SastavnicaPrijem entity)
        {
            repoSastavnicaPrijem.Add(entity);
        }

        public void AddRange(IEnumerable<SastavnicaPrijem> entities)
        {
            repoSastavnicaPrijem.AddRange(entities);
        }

        public SastavnicaPrijem Find(Expression<Func<SastavnicaPrijem, bool>> predicate)
        {
            return repoSastavnicaPrijem.Find(predicate);
        }

        public SastavnicaPrijem Get(int id)
        {
            return repoSastavnicaPrijem.Get(id);
        }

        public IEnumerable<SastavnicaPrijem> GetAll()
        {
            return repoSastavnicaPrijem.GetAll().ToList();
        }

        public void Remove(SastavnicaPrijem entity)
        {
            repoSastavnicaPrijem.Remove(entity);
        }

        public void RemoveEntity(SastavnicaPrijem entityToDelete)
        {
            repoSastavnicaPrijem.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<SastavnicaPrijem> entities)
        {
            repoSastavnicaPrijem.RemoveRange(entities);
        }

        public void UpdateEntity(SastavnicaPrijem entityToUpdate)
        {
            repoSastavnicaPrijem.UpdateEntity(entityToUpdate);
        }
    }
}
