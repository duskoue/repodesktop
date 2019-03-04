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
   public class ObracunKomercijalniServices : IServices<ObracunKomercijalni>
    {
        MpContext mp;
        GenericRepository<ObracunKomercijalni> repoObracunKomercijalni;
        public ObracunKomercijalniServices()
        {
            mp = new MpContext("InfoContext");
            repoObracunKomercijalni = new GenericRepository<ObracunKomercijalni>(mp);
        }

        public void Add(ObracunKomercijalni entity)
        {
            repoObracunKomercijalni.Add(entity);
        }

        public void AddRange(IEnumerable<ObracunKomercijalni> entities)
        {
            repoObracunKomercijalni.AddRange(entities);
        }

        public ObracunKomercijalni Find(Expression<Func<ObracunKomercijalni, bool>> predicate)
        {
            return repoObracunKomercijalni.Find(predicate);
        }

        public ObracunKomercijalni Get(int id)
        {
            return repoObracunKomercijalni.Get(id);
        }

        public IEnumerable<ObracunKomercijalni> GetAll()
        {
            return repoObracunKomercijalni.GetAll().ToList();
        }

        public void Remove(ObracunKomercijalni entity)
        {
            repoObracunKomercijalni.Remove(entity);
        }

        public void RemoveEntity(ObracunKomercijalni entityToDelete)
        {
            repoObracunKomercijalni.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<ObracunKomercijalni> entities)
        {
            repoObracunKomercijalni.RemoveRange(entities);
        }

        public void UpdateEntity(ObracunKomercijalni entityToUpdate)
        {
            repoObracunKomercijalni.UpdateEntity(entityToUpdate);
        }
    }
}
