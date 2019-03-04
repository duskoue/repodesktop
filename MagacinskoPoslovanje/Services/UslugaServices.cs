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
   public class UslugaServices : IServices<Usluga>
    {
        MpContext mp;
        GenericRepository<Usluga> repoUsluga;
        public UslugaServices()
        {
            mp = new MpContext("InfoContext");
            repoUsluga = new GenericRepository<Usluga>(mp);
        }

        public void Add(Usluga entity)
        {
            repoUsluga.Add(entity);
        }

        public void AddRange(IEnumerable<Usluga> entities)
        {
            repoUsluga.AddRange(entities);
        }

        public Usluga Find(Expression<Func<Usluga, bool>> predicate)
        {
            return repoUsluga.Find(predicate);
        }

        public Usluga Get(int id)
        {
            return repoUsluga.Get(id);
        }

        public IEnumerable<Usluga> GetAll()
        {
            return repoUsluga.GetAll().ToList();
        }

        public void Remove(Usluga entity)
        {
            repoUsluga.Remove(entity);
        }

        public void RemoveEntity(Usluga entityToDelete)
        {
            repoUsluga.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<Usluga> entities)
        {
            repoUsluga.RemoveRange(entities);
        }

        public void UpdateEntity(Usluga entityToUpdate)
        {
            repoUsluga.UpdateEntity(entityToUpdate);
        }
    }
}
