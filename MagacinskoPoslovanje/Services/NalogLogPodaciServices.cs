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
  public  class NalogLogPodaciServices : IServices<NalogLogPodaci>
    {
        MpContext mp;
        GenericRepository<NalogLogPodaci> repoNalogLogPodaci;
        public NalogLogPodaciServices()
        {
            mp = new MpContext("InfoContext");
            repoNalogLogPodaci = new GenericRepository<NalogLogPodaci>(mp);
        }

        public void Add(NalogLogPodaci entity)
        {
            repoNalogLogPodaci.Add(entity);
        }

        public void AddRange(IEnumerable<NalogLogPodaci> entities)
        {
            repoNalogLogPodaci.AddRange(entities);
        }

        public NalogLogPodaci Find(Expression<Func<NalogLogPodaci, bool>> predicate)
        {
            return repoNalogLogPodaci.Find(predicate);
        }

        public NalogLogPodaci Get(int id)
        {
            return repoNalogLogPodaci.Get(id);
        }

        public IEnumerable<NalogLogPodaci> GetAll()
        {
            return repoNalogLogPodaci.GetAll().ToList();
        }

        public void Remove(NalogLogPodaci entity)
        {
            repoNalogLogPodaci.Remove(entity);
        }

        public void RemoveEntity(NalogLogPodaci entityToDelete)
        {
            repoNalogLogPodaci.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<NalogLogPodaci> entities)
        {
            repoNalogLogPodaci.RemoveRange(entities);
        }

        public void UpdateEntity(NalogLogPodaci entityToUpdate)
        {
            repoNalogLogPodaci.UpdateEntity(entityToUpdate);
        }
    }
}
