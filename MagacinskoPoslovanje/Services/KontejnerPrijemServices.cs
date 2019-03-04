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
   public class KontejnerPrijemServices : IServices<KontejnerPrijem>
    {
        MpContext mp;
        GenericRepository<KontejnerPrijem> repoKontejnerPrijem;
        public KontejnerPrijemServices()
        {
            mp = new MpContext("InfoContext");
            repoKontejnerPrijem = new GenericRepository<KontejnerPrijem>(mp);
        }

        public void Add(KontejnerPrijem entity)
        {
            repoKontejnerPrijem.Add(entity);
        }

        public void AddRange(IEnumerable<KontejnerPrijem> entities)
        {
            repoKontejnerPrijem.AddRange(entities);
        }

        public KontejnerPrijem Find(Expression<Func<KontejnerPrijem, bool>> predicate)
        {
          return  repoKontejnerPrijem.Find(predicate);
        }

        public KontejnerPrijem Get(int id)
        {
            return repoKontejnerPrijem.Get(id);
        }

        public IEnumerable<KontejnerPrijem> GetAll()
        {
            return repoKontejnerPrijem.GetAll().ToList();
        }

        public void Remove(KontejnerPrijem entity)
        {
            repoKontejnerPrijem.Remove(entity);
        }

        public void RemoveEntity(KontejnerPrijem entityToDelete)
        {
            repoKontejnerPrijem.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<KontejnerPrijem> entities)
        {
            repoKontejnerPrijem.RemoveRange(entities);
        }

        public void UpdateEntity(KontejnerPrijem entityToUpdate)
        {
            repoKontejnerPrijem.UpdateEntity(entityToUpdate);
        }
    }
}
