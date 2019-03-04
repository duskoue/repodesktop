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
   public class LokacijaKlijentaServices : IServices<LokacijaKlijenta>
    {
        MpContext mp;
        GenericRepository<LokacijaKlijenta> repoLokacijeKlijenta;
        public LokacijaKlijentaServices()
        {

        }

        public void Add(LokacijaKlijenta entity)
        {
            repoLokacijeKlijenta.Add(entity);
        }

        public void AddRange(IEnumerable<LokacijaKlijenta> entities)
        {
            repoLokacijeKlijenta.AddRange(entities);
        }

        public LokacijaKlijenta Find(Expression<Func<LokacijaKlijenta, bool>> predicate)
        {
            return repoLokacijeKlijenta.Find(predicate);
        }

        public LokacijaKlijenta Get(int id)
        {
            return repoLokacijeKlijenta.Get(id);
        }

        public IEnumerable<LokacijaKlijenta> GetAll()
        {
            return repoLokacijeKlijenta.GetAll().ToList();
        }

        public void Remove(LokacijaKlijenta entity)
        {
            repoLokacijeKlijenta.Remove(entity);
        }

        public void RemoveEntity(LokacijaKlijenta entityToDelete)
        {
            repoLokacijeKlijenta.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<LokacijaKlijenta> entities)
        {
            repoLokacijeKlijenta.RemoveRange(entities);
        }

        public void UpdateEntity(LokacijaKlijenta entityToUpdate)
        {
            repoLokacijeKlijenta.UpdateEntity(entityToUpdate);
        }
    }
}
