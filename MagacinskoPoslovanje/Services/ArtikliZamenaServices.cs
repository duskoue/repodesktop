using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MagacinskoPoslovanje.Context;
using MagacinskoPoslovanje.Data;

namespace MagacinskoPoslovanje.Services
{
  public  class ArtikliZamenaServices : IServices<ArtikliZamena>
    {
        MpContext mp;
        GenericRepository<ArtikliZamena> repoArtikliZamena;

        public ArtikliZamenaServices()
        {
            repoArtikliZamena = new GenericRepository<ArtikliZamena>(mp);
            mp = new MpContext("InfoContext");
        }

        public void Add(ArtikliZamena entity)
        {
            repoArtikliZamena.Add(entity);
        }

        public void AddRange(IEnumerable<ArtikliZamena> entities)
        {
            repoArtikliZamena.AddRange(entities);
        }

        public ArtikliZamena Find(Expression<Func<ArtikliZamena, bool>> predicate)
        {
            return repoArtikliZamena.Find(predicate);
        }

        public ArtikliZamena Get(int id)
        {
            return repoArtikliZamena.Get(id);
        }

        public IEnumerable<ArtikliZamena> GetAll()
        {
            return repoArtikliZamena.GetAll().ToList();
        }

        public void Remove(ArtikliZamena entity)
        {
            repoArtikliZamena.Remove(entity);
        }

        public void RemoveEntity(ArtikliZamena entityToDelete)
        {
            repoArtikliZamena.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<ArtikliZamena> entities)
        {
            repoArtikliZamena.RemoveRange(entities);
        }

        public void UpdateEntity(ArtikliZamena entityToUpdate)
        {
            repoArtikliZamena.UpdateEntity(entityToUpdate);
        }
    }
}
