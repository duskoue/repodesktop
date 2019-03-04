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
   public class ZauzeteRegalneLokacijePoVlasnikuSUMServices : IServices<ZauzeteRegalneLokacijePoVlasnikuSUM>
    {
        MpContext mp;
        GenericRepository<ZauzeteRegalneLokacijePoVlasnikuSUM> repoZauzereREgalLokPoVlasnikuSUM;
        public ZauzeteRegalneLokacijePoVlasnikuSUMServices()
        {
            mp = new MpContext("InfoContext");
            repoZauzereREgalLokPoVlasnikuSUM = new GenericRepository<ZauzeteRegalneLokacijePoVlasnikuSUM>(mp);
        }

        public void Add(ZauzeteRegalneLokacijePoVlasnikuSUM entity)
        {
            repoZauzereREgalLokPoVlasnikuSUM.Add(entity);
        }

        public void AddRange(IEnumerable<ZauzeteRegalneLokacijePoVlasnikuSUM> entities)
        {
            repoZauzereREgalLokPoVlasnikuSUM.AddRange(entities);
        }

        public ZauzeteRegalneLokacijePoVlasnikuSUM Find(Expression<Func<ZauzeteRegalneLokacijePoVlasnikuSUM, bool>> predicate)
        {
            return repoZauzereREgalLokPoVlasnikuSUM.Find(predicate);
        }

        public ZauzeteRegalneLokacijePoVlasnikuSUM Get(int id)
        {
            return repoZauzereREgalLokPoVlasnikuSUM.Get(id);
        }

        public IEnumerable<ZauzeteRegalneLokacijePoVlasnikuSUM> GetAll()
        {
            return repoZauzereREgalLokPoVlasnikuSUM.GetAll().ToList();
        }

        public void Remove(ZauzeteRegalneLokacijePoVlasnikuSUM entity)
        {
            repoZauzereREgalLokPoVlasnikuSUM.Remove(entity);
        }

        public void RemoveEntity(ZauzeteRegalneLokacijePoVlasnikuSUM entityToDelete)
        {
            repoZauzereREgalLokPoVlasnikuSUM.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<ZauzeteRegalneLokacijePoVlasnikuSUM> entities)
        {
            repoZauzereREgalLokPoVlasnikuSUM.RemoveRange(entities);
        }

        public void UpdateEntity(ZauzeteRegalneLokacijePoVlasnikuSUM entityToUpdate)
        {
            repoZauzereREgalLokPoVlasnikuSUM.UpdateEntity(entityToUpdate);
        }
    }
}
