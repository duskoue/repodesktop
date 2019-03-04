using MagacinskoPoslovanje.Context;
using MagacinskoPoslovanje.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace MagacinskoPoslovanje.Services
{
   public class SifarnikServis : IServices<Sifarnik>
    {
        MpContext mp;
        GenericRepository<Sifarnik> repoSifarnik;
        public SifarnikServis()
        {
            mp = new MpContext("InfoContext");
            repoSifarnik = new GenericRepository<Sifarnik>(mp);
        }

        public void Add(Sifarnik entity)
        {
            repoSifarnik.Add(entity);
        }

        public void AddRange(IEnumerable<Sifarnik> entities)
        {
            repoSifarnik.AddRange(entities);
        }

        public Sifarnik Find(Expression<Func<Sifarnik, bool>> predicate)
        {
          return  repoSifarnik.Find(predicate);
        }

        public Sifarnik Get(int id)
        {
           return repoSifarnik.Get(id);
        }

        public IEnumerable<Sifarnik> GetAll()
        {
            return repoSifarnik.GetAll().ToList();
        }

        public void Remove(Sifarnik entity)
        {
            repoSifarnik.Remove(entity);
        }

        public void RemoveEntity(Sifarnik entityToDelete)
        {
             repoSifarnik.RemoveEntity(entityToDelete);        }

        public void RemoveRange(IEnumerable<Sifarnik> entities)
        {
            repoSifarnik.RemoveRange(entities);
        }

        public void UpdateEntity(Sifarnik entityToUpdate)
        {
            repoSifarnik.UpdateEntity(entityToUpdate);
        }
    }
}
