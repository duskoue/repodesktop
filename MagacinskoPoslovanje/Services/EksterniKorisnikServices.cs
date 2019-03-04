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
  public  class EksterniKorisnikServices : IServices<EksterniKorisnik>
    {
        MpContext mp;
        GenericRepository<EksterniKorisnik> repoEksterniKorisnik;
        public EksterniKorisnikServices()
        {
            mp = new MpContext("InfoContext");
            repoEksterniKorisnik = new GenericRepository<EksterniKorisnik>(mp);
        }

        public void Add(EksterniKorisnik entity)
        {
            repoEksterniKorisnik.Add(entity);
        }

        public void AddRange(IEnumerable<EksterniKorisnik> entities)
        {
            repoEksterniKorisnik.AddRange(entities);
        }

        public EksterniKorisnik Find(Expression<Func<EksterniKorisnik, bool>> predicate)
        {
            return repoEksterniKorisnik.Find(predicate);
        }

        public EksterniKorisnik Get(int id)
        {
            return repoEksterniKorisnik.Get(id);
        }

        public IEnumerable<EksterniKorisnik> GetAll()
        {
            return repoEksterniKorisnik.GetAll().ToList();
        }

        public void Remove(EksterniKorisnik entity)
        {
            repoEksterniKorisnik.Remove(entity);
        }

        public void RemoveEntity(EksterniKorisnik entityToDelete)
        {
            repoEksterniKorisnik.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<EksterniKorisnik> entities)
        {
            repoEksterniKorisnik.RemoveRange(entities);
        }

        public void UpdateEntity(EksterniKorisnik entityToUpdate)
        {
            repoEksterniKorisnik.UpdateEntity(entityToUpdate);
        }
    }
}
