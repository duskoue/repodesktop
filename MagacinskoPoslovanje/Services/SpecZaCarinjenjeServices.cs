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
   public class SpecZaCarinjenjeServices : IServices<SpecZaCarinjenje>
    {
        MpContext mp;
        GenericRepository<SpecZaCarinjenje> repoSpecZaCarinjenje;
        public SpecZaCarinjenjeServices()
        {
            mp = new MpContext("InfoContext");
            repoSpecZaCarinjenje = new GenericRepository<SpecZaCarinjenje>(mp);
        }

        public void Add(SpecZaCarinjenje entity)
        {
            repoSpecZaCarinjenje.Add(entity);
        }

        public void AddRange(IEnumerable<SpecZaCarinjenje> entities)
        {
            repoSpecZaCarinjenje.AddRange(entities);
        }

        public SpecZaCarinjenje Find(Expression<Func<SpecZaCarinjenje, bool>> predicate)
        {
            return repoSpecZaCarinjenje.Find(predicate);
        }

        public SpecZaCarinjenje Get(int id)
        {
           return repoSpecZaCarinjenje.Get(id);
        }

        public IEnumerable<SpecZaCarinjenje> GetAll()
        {
            return repoSpecZaCarinjenje.GetAll().ToList();
        }

        public void Remove(SpecZaCarinjenje entity)
        {
            repoSpecZaCarinjenje.Remove(entity);
        }

        public void RemoveEntity(SpecZaCarinjenje entityToDelete)
        {
            repoSpecZaCarinjenje.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<SpecZaCarinjenje> entities)
        {
            repoSpecZaCarinjenje.RemoveRange(entities);
        }

        public void UpdateEntity(SpecZaCarinjenje entityToUpdate)
        {
            repoSpecZaCarinjenje.UpdateEntity(entityToUpdate);
        }
    }
}
