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
  public  class ZaliheZaPremestajTempServices : IServices<ZaliheZaPremestajTemp>
    {
        MpContext mp;
        GenericRepository<ZaliheZaPremestajTemp> repoZaliheZaPremestajTemp;
        public ZaliheZaPremestajTempServices()
        {
            mp = new MpContext("InfoContext");
            repoZaliheZaPremestajTemp = new GenericRepository<ZaliheZaPremestajTemp>(mp);
        }

        public void Add(ZaliheZaPremestajTemp entity)
        {
            repoZaliheZaPremestajTemp.Add(entity);
        }

        public void AddRange(IEnumerable<ZaliheZaPremestajTemp> entities)
        {
            repoZaliheZaPremestajTemp.AddRange(entities);
        }

        public ZaliheZaPremestajTemp Find(Expression<Func<ZaliheZaPremestajTemp, bool>> predicate)
        {
            return repoZaliheZaPremestajTemp.Find(predicate);
        }

        public ZaliheZaPremestajTemp Get(int id)
        {
            return repoZaliheZaPremestajTemp.Get(id);
        }

        public IEnumerable<ZaliheZaPremestajTemp> GetAll()
        {
            return repoZaliheZaPremestajTemp.GetAll().ToList();
        }

        public void Remove(ZaliheZaPremestajTemp entity)
        {
            repoZaliheZaPremestajTemp.Remove(entity);
        }

        public void RemoveEntity(ZaliheZaPremestajTemp entityToDelete)
        {
            repoZaliheZaPremestajTemp.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<ZaliheZaPremestajTemp> entities)
        {
            repoZaliheZaPremestajTemp.RemoveRange(entities);
        }

        public void UpdateEntity(ZaliheZaPremestajTemp entityToUpdate)
        {
            repoZaliheZaPremestajTemp.UpdateEntity(entityToUpdate);
        }
    }
}
