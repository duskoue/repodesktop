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
   public class ObracunCarinskiServices : IServices<ObracunCarinski>
    {
        MpContext mp;
        GenericRepository<ObracunCarinski> repoObracunCarinski;
        public ObracunCarinskiServices()
        {
            mp = new MpContext("InfoContext");
            repoObracunCarinski = new GenericRepository<ObracunCarinski>(mp);
        }

        public void Add(ObracunCarinski entity)
        {
            repoObracunCarinski.Add(entity);
        }

        public void AddRange(IEnumerable<ObracunCarinski> entities)
        {
            repoObracunCarinski.AddRange(entities);
        }

        public ObracunCarinski Find(Expression<Func<ObracunCarinski, bool>> predicate)
        {
           return repoObracunCarinski.Find(predicate);
        }

        public ObracunCarinski Get(int id)
        {
            return repoObracunCarinski.Get(id);
        }

        public IEnumerable<ObracunCarinski> GetAll()
        {
            return repoObracunCarinski.GetAll().ToList();
        }

        public void Remove(ObracunCarinski entity)
        {
            repoObracunCarinski.Remove(entity);
        }

        public void RemoveEntity(ObracunCarinski entityToDelete)
        {
            repoObracunCarinski.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<ObracunCarinski> entities)
        {
            repoObracunCarinski.RemoveRange(entities);
        }

        public void UpdateEntity(ObracunCarinski entityToUpdate)
        {
            repoObracunCarinski.UpdateEntity(entityToUpdate);
        }
    }
}
