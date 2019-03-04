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
  public  class ZauzeteRegalneLokacijePoVlasnikuServices : IServices<ZauzeteRegalneLokacijePoVlasniku>
    {
        MpContext mp;
        GenericRepository<ZauzeteRegalneLokacijePoVlasniku> repoZauzereREgalLokPoVlasniku;
        public ZauzeteRegalneLokacijePoVlasnikuServices()
        {
            mp = new MpContext("InfoContext");
            repoZauzereREgalLokPoVlasniku = new GenericRepository<ZauzeteRegalneLokacijePoVlasniku>(mp);
        }

        public void Add(ZauzeteRegalneLokacijePoVlasniku entity)
        {
            repoZauzereREgalLokPoVlasniku.Add(entity);
        }

        public void AddRange(IEnumerable<ZauzeteRegalneLokacijePoVlasniku> entities)
        {
            repoZauzereREgalLokPoVlasniku.AddRange(entities);
        }

        public ZauzeteRegalneLokacijePoVlasniku Find(Expression<Func<ZauzeteRegalneLokacijePoVlasniku, bool>> predicate)
        {
            return repoZauzereREgalLokPoVlasniku.Find(predicate);
        }

        public ZauzeteRegalneLokacijePoVlasniku Get(int id)
        {
            return repoZauzereREgalLokPoVlasniku.Get(id);
        }

        public IEnumerable<ZauzeteRegalneLokacijePoVlasniku> GetAll()
        {
            return repoZauzereREgalLokPoVlasniku.GetAll().ToList();
        }

        public void Remove(ZauzeteRegalneLokacijePoVlasniku entity)
        {
            repoZauzereREgalLokPoVlasniku.Remove(entity);
        }

        public void RemoveEntity(ZauzeteRegalneLokacijePoVlasniku entityToDelete)
        {
            repoZauzereREgalLokPoVlasniku.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<ZauzeteRegalneLokacijePoVlasniku> entities)
        {
            repoZauzereREgalLokPoVlasniku.RemoveRange(entities);

        }

        public void UpdateEntity(ZauzeteRegalneLokacijePoVlasniku entityToUpdate)
        {
            repoZauzereREgalLokPoVlasniku.UpdateEntity(entityToUpdate);
        }
    }
}
