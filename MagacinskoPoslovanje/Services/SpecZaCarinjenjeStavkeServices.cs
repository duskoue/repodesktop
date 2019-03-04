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
   public class SpecZaCarinjenjeStavkeServices : IServices<SpecZaCarinjenjeStavke>
    {
        MpContext mp;
        GenericRepository<SpecZaCarinjenjeStavke> repoSpecZaCarinjenjeStavke;
        public SpecZaCarinjenjeStavkeServices()
        {
            mp = new MpContext("InfoContext");
            repoSpecZaCarinjenjeStavke = new GenericRepository<SpecZaCarinjenjeStavke>(mp);
        }

        public void Add(SpecZaCarinjenjeStavke entity)
        {
            repoSpecZaCarinjenjeStavke.Add(entity);
        }

        public void AddRange(IEnumerable<SpecZaCarinjenjeStavke> entities)
        {
            repoSpecZaCarinjenjeStavke.AddRange(entities);
        }

        public SpecZaCarinjenjeStavke Find(Expression<Func<SpecZaCarinjenjeStavke, bool>> predicate)
        {
            return repoSpecZaCarinjenjeStavke.Find(predicate);
        }

        public SpecZaCarinjenjeStavke Get(int id)
        {
            return repoSpecZaCarinjenjeStavke.Get(id);
        }

        public IEnumerable<SpecZaCarinjenjeStavke> GetAll()
        {
            return repoSpecZaCarinjenjeStavke.GetAll().ToList();
        }

        public void Remove(SpecZaCarinjenjeStavke entity)
        {
            repoSpecZaCarinjenjeStavke.Remove(entity);
        }

        public void RemoveEntity(SpecZaCarinjenjeStavke entityToDelete)
        {
            repoSpecZaCarinjenjeStavke.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<SpecZaCarinjenjeStavke> entities)
        {
            repoSpecZaCarinjenjeStavke.RemoveRange(entities);
        }

        public void UpdateEntity(SpecZaCarinjenjeStavke entityToUpdate)
        {
            repoSpecZaCarinjenjeStavke.UpdateEntity(entityToUpdate);
        }
    }
}
