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
  public  class LokacijaServices : IServices<Lokacija>
    {
        MpContext mp;
        GenericRepository<Lokacija> repoLokacija;
        public LokacijaServices()
        {
            mp = new MpContext("InfoContext");
            repoLokacija = new GenericRepository<Lokacija>(mp);
        }

        public void Add(Lokacija entity)
        {
            repoLokacija.Add(entity);
        }

        public void AddRange(IEnumerable<Lokacija> entities)
        {
            repoLokacija.AddRange(entities);
        }

        public Lokacija Find(Expression<Func<Lokacija, bool>> predicate)
        {
           return repoLokacija.Find(predicate);
        }

        public Lokacija Get(int id)
        {
            return repoLokacija.Get(id);
        }

        public IEnumerable<Lokacija> GetAll()
        {
            return repoLokacija.GetAll().ToList();
        }

        public void Remove(Lokacija entity)
        {
            repoLokacija.Remove(entity);
        }

        public void RemoveEntity(Lokacija entityToDelete)
        {
            repoLokacija.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<Lokacija> entities)
        {
            repoLokacija.RemoveRange(entities);
        }

        public void UpdateEntity(Lokacija entityToUpdate)
        {
            repoLokacija.UpdateEntity(entityToUpdate);
        }
    }
}
