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
  public  class ParametrizacijaServices :IServices<Parametrizacija>
    {
        MpContext mp;
        GenericRepository<Parametrizacija> repoParametrizacija;
        public ParametrizacijaServices()
        {
            mp = new MpContext("InfoContext");
            repoParametrizacija = new GenericRepository<Parametrizacija>(mp);
        }

        public void Add(Parametrizacija entity)
        {
            repoParametrizacija.Add(entity);
        }

        public void AddRange(IEnumerable<Parametrizacija> entities)
        {
            repoParametrizacija.AddRange(entities);
        }

        public Parametrizacija Find(Expression<Func<Parametrizacija, bool>> predicate)
        {
            return repoParametrizacija.Find(predicate);
        }

        public Parametrizacija Get(int id)
        {
           return repoParametrizacija.Get(id);
        }

        public IEnumerable<Parametrizacija> GetAll()
        {
            return repoParametrizacija.GetAll().ToList();
        }

        public void Remove(Parametrizacija entity)
        {
            repoParametrizacija.Remove(entity);
        }

        public void RemoveEntity(Parametrizacija entityToDelete)
        {
            repoParametrizacija.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<Parametrizacija> entities)
        {
            repoParametrizacija.RemoveRange(entities);
        }

        public void UpdateEntity(Parametrizacija entityToUpdate)
        {
            repoParametrizacija.UpdateEntity(entityToUpdate);
        }
    }
}
