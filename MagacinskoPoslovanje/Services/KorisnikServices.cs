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
  
   public class KorisnikServices : IServices<Korisnik>
    {
        MpContext mp;
        GenericRepository<Korisnik> repoKorisnik;
        public KorisnikServices()
        {
            mp = new MpContext("InfoContext");
            repoKorisnik = new GenericRepository<Korisnik>(mp);
        }

        public void Add(Korisnik entity)
        {
            repoKorisnik.Add(entity);
        }

        public void AddRange(IEnumerable<Korisnik> entities)
        {
            repoKorisnik.AddRange(entities);
        }

        public Korisnik Find(Expression<Func<Korisnik, bool>> predicate)
        {
            return repoKorisnik.Find(predicate);
        }

        public Korisnik Get(int id)
        {
            return repoKorisnik.Get(id);
        }

        public IEnumerable<Korisnik> GetAll()
        {
            return repoKorisnik.GetAll().ToList();
        }

        public void Remove(Korisnik entity)
        {
            repoKorisnik.Remove(entity);
        }

        public void RemoveEntity(Korisnik entityToDelete)
        {
            repoKorisnik.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<Korisnik> entities)
        {
            repoKorisnik.RemoveRange(entities);
        }

        public void UpdateEntity(Korisnik entityToUpdate)
        {
            repoKorisnik.UpdateEntity(entityToUpdate);
        }
    }
}
