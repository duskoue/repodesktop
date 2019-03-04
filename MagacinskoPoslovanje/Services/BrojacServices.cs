using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using MagacinskoPoslovanje.Context;
using MagacinskoPoslovanje.Data;

namespace MagacinskoPoslovanje.Services
{
  public  class BrojacServices : IServices<Brojac>
    {
        MpContext mp;
        GenericRepository<Brojac> repoBrojac;
        public BrojacServices()
        {
            repoBrojac = new GenericRepository<Brojac>(mp);
            mp = new MpContext("InfoContext");
        }

        public void Add(Brojac entity)
        {
            repoBrojac.Add(entity);
        }

        public void AddRange(IEnumerable<Brojac> entities)
        {
            repoBrojac.AddRange(entities);
        }

        public Brojac Find(Expression<Func<Brojac, bool>> predicate)
        {
            return repoBrojac.Find(predicate);
        }

        public Brojac Get(int id)
        {
            return repoBrojac.Get(id);
        }

        public IEnumerable<Brojac> GetAll()
        {
            return repoBrojac.GetAll().ToList();
        }

        public void Remove(Brojac entity)
        {
            repoBrojac.Remove(entity);
        }

        public void RemoveEntity(Brojac entityToDelete)
        {
            repoBrojac.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<Brojac> entities)
        {
            repoBrojac.RemoveRange(entities);
        }

        public void UpdateEntity(Brojac entityToUpdate)
        {
            repoBrojac.UpdateEntity(entityToUpdate);
        }
    }
}
