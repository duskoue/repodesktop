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
   public class ArtikliIzlazServices : IServices<ArtikliIzlaz>
    {
        MpContext mp;
        GenericRepository<ArtikliIzlaz> repoArtikliIzlaz;
        public ArtikliIzlazServices()
        {
            repoArtikliIzlaz = new GenericRepository<ArtikliIzlaz>(mp);
            mp = new MpContext("InfoContext");
        }

        public void Add(ArtikliIzlaz entity)
        {
            repoArtikliIzlaz.Add(entity);
        }

        public void AddRange(IEnumerable<ArtikliIzlaz> entities)
        {
            repoArtikliIzlaz.AddRange(entities);
        }

        public ArtikliIzlaz Find(Expression<Func<ArtikliIzlaz, bool>> predicate)
        {
            return repoArtikliIzlaz.Find(predicate);
        }

        public ArtikliIzlaz Get(int id)
        {
            return repoArtikliIzlaz.Get(id);
        }

        public IEnumerable<ArtikliIzlaz> GetAll()
        {
           return   repoArtikliIzlaz.GetAll().ToList();
        }

        public void Remove(ArtikliIzlaz entity)
        {
            repoArtikliIzlaz.Remove(entity);
        }

        public void RemoveEntity(ArtikliIzlaz entityToDelete)
        {
            repoArtikliIzlaz.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<ArtikliIzlaz> entities)
        {
            repoArtikliIzlaz.RemoveRange(entities);
        }

        public void UpdateEntity(ArtikliIzlaz entityToUpdate)
        {
            repoArtikliIzlaz.UpdateEntity(entityToUpdate);
        }
    }
}
