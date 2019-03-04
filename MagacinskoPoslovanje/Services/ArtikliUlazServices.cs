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
  public  class ArtikliUlazServices : IServices<ArtikliUlaz>
    {
        MpContext mp;
        GenericRepository<ArtikliUlaz> repoArtikliUlaz;

        public ArtikliUlazServices()
        {
            repoArtikliUlaz = new GenericRepository<ArtikliUlaz>(mp);
            mp = new MpContext("InfoContext");
        }

        public void Add(ArtikliUlaz entity)
        {
            repoArtikliUlaz.Add(entity);
        }

        public void AddRange(IEnumerable<ArtikliUlaz> entities)
        {
            repoArtikliUlaz.AddRange(entities);
        }

        public ArtikliUlaz Find(Expression<Func<ArtikliUlaz, bool>> predicate)
        {
            return repoArtikliUlaz.Find(predicate);
        }

        public ArtikliUlaz Get(int id)
        {
            return repoArtikliUlaz.Get(id);
        }

        public IEnumerable<ArtikliUlaz> GetAll()
        {
            return repoArtikliUlaz.GetAll().ToList();
        }

        public void Remove(ArtikliUlaz entity)
        {
            repoArtikliUlaz.Remove(entity);
        }

        public void RemoveEntity(ArtikliUlaz entityToDelete)
        {
            repoArtikliUlaz.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<ArtikliUlaz> entities)
        {
            repoArtikliUlaz.RemoveRange(entities);
        }

        public void UpdateEntity(ArtikliUlaz entityToUpdate)
        {
            repoArtikliUlaz.UpdateEntity(entityToUpdate);
        }
    }
}
