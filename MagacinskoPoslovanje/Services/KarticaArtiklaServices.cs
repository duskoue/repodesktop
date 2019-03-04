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
   public class KarticaArtiklaServices : IServices<KarticaArtikla>
    {
        MpContext mp;
        GenericRepository<KarticaArtikla> repoKarticaArtikala;
        public KarticaArtiklaServices()
        {
            mp = new MpContext("InfoContext");
            repoKarticaArtikala = new GenericRepository<KarticaArtikla>(mp);
        }

        public void Add(KarticaArtikla entity)
        {
            repoKarticaArtikala.Add(entity);
        }

        public void AddRange(IEnumerable<KarticaArtikla> entities)
        {
            repoKarticaArtikala.AddRange(entities);
        }

        public KarticaArtikla Find(Expression<Func<KarticaArtikla, bool>> predicate)
        {
            return repoKarticaArtikala.Find(predicate);
        }

        public KarticaArtikla Get(int id)
        {
            return repoKarticaArtikala.Get(id);
        }

        public IEnumerable<KarticaArtikla> GetAll()
        {
            return repoKarticaArtikala.GetAll().ToList();
        }

        public void Remove(KarticaArtikla entity)
        {
            repoKarticaArtikala.Remove(entity);
        }

        public void RemoveEntity(KarticaArtikla entityToDelete)
        {
            repoKarticaArtikala.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<KarticaArtikla> entities)
        {
            repoKarticaArtikala.RemoveRange(entities);
        }

        public void UpdateEntity(KarticaArtikla entityToUpdate)
        {
            repoKarticaArtikala.UpdateEntity(entityToUpdate);
        }
    }
}
