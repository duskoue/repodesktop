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
   
   public class KontaktServices :IServices<Kontakt>
    {
        MpContext mp;
        GenericRepository<Kontakt> repoKontakt;
        public KontaktServices()
        {
            mp = new MpContext("InfoContext");
            repoKontakt = new GenericRepository<Kontakt>(mp);
        }

        public void Add(Kontakt entity)
        {
            repoKontakt.Add(entity);
        }

        public void AddRange(IEnumerable<Kontakt> entities)
        {
            repoKontakt.AddRange(entities);
        }

        public Kontakt Find(Expression<Func<Kontakt, bool>> predicate)
        {
            return repoKontakt.Find(predicate);
        }

        public Kontakt Get(int id)
        {
            return repoKontakt.Get(id);
        }

        public IEnumerable<Kontakt> GetAll()
        {
            return repoKontakt.GetAll().ToList();
        }

        public void Remove(Kontakt entity)
        {
            repoKontakt.Remove(entity);
        }

        public void RemoveEntity(Kontakt entityToDelete)
        {
            repoKontakt.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<Kontakt> entities)
        {
            repoKontakt.RemoveRange(entities);
        }

        public void UpdateEntity(Kontakt entityToUpdate)
        {
            repoKontakt.UpdateEntity(entityToUpdate);
        }
    }
}
