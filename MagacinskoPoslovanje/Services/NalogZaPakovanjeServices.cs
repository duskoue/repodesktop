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
  public  class NalogZaPakovanjeServices : IServices<NalogZaPakovanje>
    {
        MpContext mp;
        GenericRepository<NalogZaPakovanje> repoNalogZaPakovanje;
        public NalogZaPakovanjeServices()
        {
            mp = new MpContext("InfoContext");
            repoNalogZaPakovanje = new GenericRepository<NalogZaPakovanje>(mp);
        }

        public void Add(NalogZaPakovanje entity)
        {
            repoNalogZaPakovanje.Add(entity);
        }

        public void AddRange(IEnumerable<NalogZaPakovanje> entities)
        {
            repoNalogZaPakovanje.AddRange(entities);
        }

        public NalogZaPakovanje Find(Expression<Func<NalogZaPakovanje, bool>> predicate)
        {
            return repoNalogZaPakovanje.Find(predicate);
        }

        public NalogZaPakovanje Get(int id)
        {
            return repoNalogZaPakovanje.Get(id);
        }

        public IEnumerable<NalogZaPakovanje> GetAll()
        {
            return repoNalogZaPakovanje.GetAll().ToList();
        }

        public void Remove(NalogZaPakovanje entity)
        {
            repoNalogZaPakovanje.Remove(entity);
        }

        public void RemoveEntity(NalogZaPakovanje entityToDelete)
        {
            repoNalogZaPakovanje.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<NalogZaPakovanje> entities)
        {
            repoNalogZaPakovanje.RemoveRange(entities);
        }

        public void UpdateEntity(NalogZaPakovanje entityToUpdate)
        {
            repoNalogZaPakovanje.UpdateEntity(entityToUpdate);
        }
    }
}
