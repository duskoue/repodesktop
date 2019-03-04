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
  public  class PakovanjeServices : IServices<Pakovanje>
     {
        MpContext mp;
        GenericRepository<Pakovanje> repoPakovanje;
        public PakovanjeServices()
        {
            mp = new MpContext("InfoContext");
            repoPakovanje = new GenericRepository<Pakovanje>(mp);
        }

        public void Add(Pakovanje entity)
        {
            repoPakovanje.Add(entity);
        }

        public void AddRange(IEnumerable<Pakovanje> entities)
        {
            repoPakovanje.AddRange(entities);
        }

        public Pakovanje Find(Expression<Func<Pakovanje, bool>> predicate)
        {
            return repoPakovanje.Find(predicate);
        }

        public Pakovanje Get(int id)
        {
            return repoPakovanje.Get(id);
        }

        public IEnumerable<Pakovanje> GetAll()
        {
            return repoPakovanje.GetAll().ToList();
        }

        public void Remove(Pakovanje entity)
        {
            repoPakovanje.Remove(entity);
        }

        public void RemoveEntity(Pakovanje entityToDelete)
        {
            repoPakovanje.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<Pakovanje> entities)
        {
            repoPakovanje.RemoveRange(entities);
        }

        public void UpdateEntity(Pakovanje entityToUpdate)
        {
            repoPakovanje.UpdateEntity(entityToUpdate);
        }
    }
}
