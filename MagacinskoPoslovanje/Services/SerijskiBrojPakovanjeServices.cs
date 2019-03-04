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
   public class SerijskiBrojPakovanjeServices : IServices<SerijskiBrojPakovanje>
    {
        MpContext mp;
        GenericRepository<SerijskiBrojPakovanje> repoSerijskiBrojPakovanje;
        public SerijskiBrojPakovanjeServices()
        {
            mp = new MpContext("InfoContext");
            repoSerijskiBrojPakovanje = new GenericRepository<SerijskiBrojPakovanje>(mp);
        }

        public void Add(SerijskiBrojPakovanje entity)
        {
            repoSerijskiBrojPakovanje.Add(entity);
        }

        public void AddRange(IEnumerable<SerijskiBrojPakovanje> entities)
        {
            repoSerijskiBrojPakovanje.AddRange(entities);
        }

        public SerijskiBrojPakovanje Find(Expression<Func<SerijskiBrojPakovanje, bool>> predicate)
        {
            return repoSerijskiBrojPakovanje.Find(predicate);
        }

        public SerijskiBrojPakovanje Get(int id)
        {
            return repoSerijskiBrojPakovanje.Get(id);
        }

        public IEnumerable<SerijskiBrojPakovanje> GetAll()
        {
            return repoSerijskiBrojPakovanje.GetAll().ToList();
        }

        public void Remove(SerijskiBrojPakovanje entity)
        {
            repoSerijskiBrojPakovanje.Remove(entity);
        }

        public void RemoveEntity(SerijskiBrojPakovanje entityToDelete)
        {
            repoSerijskiBrojPakovanje.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<SerijskiBrojPakovanje> entities)
        {
            repoSerijskiBrojPakovanje.RemoveRange(entities);


        }

        public void UpdateEntity(SerijskiBrojPakovanje entityToUpdate)
        {
            repoSerijskiBrojPakovanje.UpdateEntity(entityToUpdate);
        }
    }
}
