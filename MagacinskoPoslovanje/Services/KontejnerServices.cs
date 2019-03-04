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
  public  class KontejnerServices : IServices<Kontejner>
    {
        MpContext mp;
        GenericRepository<Kontejner> repoKontejner;
        public KontejnerServices()
        {
            mp = new MpContext("InfoContext");
            repoKontejner = new GenericRepository<Kontejner>(mp);
        }

        public void Add(Kontejner entity)
        {
            repoKontejner.Add(entity);
        }

        public void AddRange(IEnumerable<Kontejner> entities)
        {
            repoKontejner.AddRange(entities);
        }

        public Kontejner Find(Expression<Func<Kontejner, bool>> predicate)
        {
            return repoKontejner.Find(predicate);
        }

        public Kontejner Get(int id)
        {
            return repoKontejner.Get(id);
        }

        public IEnumerable<Kontejner> GetAll()
        {
            return repoKontejner.GetAll().ToList();
        }

        public void Remove(Kontejner entity)
        {
            repoKontejner.Remove(entity);
        }

        public void RemoveEntity(Kontejner entityToDelete)
        {
            repoKontejner.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<Kontejner> entities)
        {
            repoKontejner.RemoveRange(entities);
        }

        public void UpdateEntity(Kontejner entityToUpdate)
        {
            repoKontejner.UpdateEntity(entityToUpdate);
        }
    }
}
