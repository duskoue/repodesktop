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
  public  class SerijskiBrojServices : IServices<SerijskiBroj>
    {
        MpContext mp;
        GenericRepository<SerijskiBroj> repoSerijskiBroj;
        public SerijskiBrojServices()
        {
            mp = new MpContext("InfoContext");
            repoSerijskiBroj = new GenericRepository<SerijskiBroj>(mp);
        }

        public void Add(SerijskiBroj entity)
        {
            repoSerijskiBroj.Add(entity);
        }

        public void AddRange(IEnumerable<SerijskiBroj> entities)
        {
            repoSerijskiBroj.AddRange(entities);
        }

        public SerijskiBroj Find(Expression<Func<SerijskiBroj, bool>> predicate)
        {
            return repoSerijskiBroj.Find(predicate);
        }

        public SerijskiBroj Get(int id)
        {
            return repoSerijskiBroj.Get(id);
        }

        public IEnumerable<SerijskiBroj> GetAll()
        {
            return repoSerijskiBroj.GetAll().ToList();
        }

        public void Remove(SerijskiBroj entity)
        {
            repoSerijskiBroj.Remove(entity);
        }

        public void RemoveEntity(SerijskiBroj entityToDelete)
        {
            repoSerijskiBroj.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<SerijskiBroj> entities)
        {
            repoSerijskiBroj.RemoveRange(entities);
        }

        public void UpdateEntity(SerijskiBroj entityToUpdate)
        {
            repoSerijskiBroj.UpdateEntity(entityToUpdate);
        }
    }
}
