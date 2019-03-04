using MagacinskoPoslovanje.Context;
using MagacinskoPoslovanje.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace MagacinskoPoslovanje.Services
{
  public  class ArtikalServices : IServices<Artikal>
    {
        MpContext mp;
        GenericRepository<Artikal> repoArtikal;
        public ArtikalServices()
        {
            mp = new MpContext("InfoContext");
            repoArtikal = new GenericRepository<Artikal>(mp);
        }

        public void Add(Artikal entity)
        {
            repoArtikal.Add(entity);
        }

        public void AddRange(IEnumerable<Artikal> entities)
        {
            repoArtikal.AddRange(entities);
        }

        public Artikal Find(Expression<Func<Artikal, bool>> predicate)
        {
            return repoArtikal.Find(predicate);
        }

        public Artikal Get(int id)
        {
            return repoArtikal.Get(id);
               
        }

        public IEnumerable<Artikal> GetAll()
        {
            return repoArtikal.GetAll().ToList();
        }

        public void Remove(Artikal entity)
        {
            repoArtikal.Remove(entity);
        }

        public void RemoveEntity(Artikal entityToDelete)
        {
            repoArtikal.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<Artikal> entities)
        {
            repoArtikal.RemoveRange(entities);
        }

        public void UpdateEntity(Artikal entityToUpdate)
        {
            repoArtikal.UpdateEntity(entityToUpdate);
        }
    }
}
