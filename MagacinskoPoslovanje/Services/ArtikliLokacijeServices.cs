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
   public class ArtikliLokacijeServices : IServices<ArtikliLokacije>
    {
        MpContext mp;
        GenericRepository<ArtikliLokacije> repoArtikliLokacije;
        public ArtikliLokacijeServices()
        {
            repoArtikliLokacije = new GenericRepository<ArtikliLokacije>(mp);
            mp = new MpContext("InfoContext");
        }

        public void Add(ArtikliLokacije entity)
        {
            repoArtikliLokacije.Add(entity);
        }

        public void AddRange(IEnumerable<ArtikliLokacije> entities)
        {
            repoArtikliLokacije.AddRange(entities);
        }

        public ArtikliLokacije Find(Expression<Func<ArtikliLokacije, bool>> predicate)
        {
            return repoArtikliLokacije.Find(predicate);
        }

        public ArtikliLokacije Get(int id)
        {
            return repoArtikliLokacije.Get(id);
        }

        public IEnumerable<ArtikliLokacije> GetAll()
        {
            return repoArtikliLokacije.GetAll().ToList();
        }

        public void Remove(ArtikliLokacije entity)
        {
            repoArtikliLokacije.Remove(entity);
        }

        public void RemoveEntity(ArtikliLokacije entityToDelete)
        {
            repoArtikliLokacije.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<ArtikliLokacije> entities)
        {
            repoArtikliLokacije.RemoveRange(entities);
        }

        public void UpdateEntity(ArtikliLokacije entityToUpdate)
        {
            repoArtikliLokacije.UpdateEntity(entityToUpdate);
        }
    }
}
