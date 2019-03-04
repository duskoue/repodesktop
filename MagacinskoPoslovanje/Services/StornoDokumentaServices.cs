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
   public class StornoDokumentaServices : IServices<StornoDokumenta>
    {
        MpContext mp;
        GenericRepository<StornoDokumenta> repoStornoDokumenta;
        public StornoDokumentaServices()
        {
            mp = new MpContext("InfoContext");
            repoStornoDokumenta = new GenericRepository<StornoDokumenta>(mp);
        }

        public void Add(StornoDokumenta entity)
        {
            repoStornoDokumenta.Add(entity);
        }

        public void AddRange(IEnumerable<StornoDokumenta> entities)
        {
            repoStornoDokumenta.AddRange(entities);
        }

        public StornoDokumenta Find(Expression<Func<StornoDokumenta, bool>> predicate)
        {
            return repoStornoDokumenta.Find(predicate);
        }

        public StornoDokumenta Get(int id)
        {
            return repoStornoDokumenta.Get(id);
        }

        public IEnumerable<StornoDokumenta> GetAll()
        {
            return repoStornoDokumenta.GetAll().ToList();
        }

        public void Remove(StornoDokumenta entity)
        {
            repoStornoDokumenta.Remove(entity);
        }

        public void RemoveEntity(StornoDokumenta entityToDelete)
        {
            repoStornoDokumenta.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<StornoDokumenta> entities)
        {
            repoStornoDokumenta.RemoveRange(entities);
        }

        public void UpdateEntity(StornoDokumenta entityToUpdate)
        {
            repoStornoDokumenta.UpdateEntity(entityToUpdate);
        }
    }
}
