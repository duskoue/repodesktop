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
  public  class EksterniPrenoServices : IServices<EksterniPreno>
    {
        MpContext mp;
        GenericRepository<EksterniPreno> repoEksterniPremos;

        public EksterniPrenoServices()
        {
            mp = new MpContext("InfoContext");
            repoEksterniPremos = new GenericRepository<EksterniPreno>(mp);

        }

        public void Add(EksterniPreno entity)
        {
            repoEksterniPremos.Add(entity);
        }

        public void AddRange(IEnumerable<EksterniPreno> entities)
        {
            repoEksterniPremos.AddRange(entities);
        }

        public EksterniPreno Find(Expression<Func<EksterniPreno, bool>> predicate)
        {
            return repoEksterniPremos.Find(predicate);
        }

        public EksterniPreno Get(int id)
        {
            return repoEksterniPremos.Get(id);
        }

        public IEnumerable<EksterniPreno> GetAll()
        {
            return repoEksterniPremos.GetAll().ToList();
        }

        public void Remove(EksterniPreno entity)
        {
            repoEksterniPremos.Remove(entity);
        }

        public void RemoveEntity(EksterniPreno entityToDelete)
        {
            repoEksterniPremos.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<EksterniPreno> entities)
        {
            repoEksterniPremos.RemoveRange(entities);

        }

        public void UpdateEntity(EksterniPreno entityToUpdate)
        {
            repoEksterniPremos.UpdateEntity(entityToUpdate);
        }
    }
}
