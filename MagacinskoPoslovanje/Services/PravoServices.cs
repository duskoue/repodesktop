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
   public class PravoServices : IServices<Pravo>
    {
        MpContext mp;
        GenericRepository<Pravo> repoPravo;
        public PravoServices()
        {
            mp = new MpContext("InfoContext");
            repoPravo = new GenericRepository<Pravo>(mp);
        }

        public void Add(Pravo entity)
        {
            repoPravo.Add(entity);
        }

        public void AddRange(IEnumerable<Pravo> entities)
        {
            repoPravo.AddRange(entities);
        }

        public Pravo Find(Expression<Func<Pravo, bool>> predicate)
        {
            return repoPravo.Find(predicate);
        }

        public Pravo Get(int id)
        {
            return repoPravo.Get(id);
        }

        public IEnumerable<Pravo> GetAll()
        {
            return repoPravo.GetAll().ToList();
        }

        public void Remove(Pravo entity)
        {
            repoPravo.Remove(entity);
        }

        public void RemoveEntity(Pravo entityToDelete)
        {
            repoPravo.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<Pravo> entities)
        {
            repoPravo.RemoveRange(entities);
        }

        public void UpdateEntity(Pravo entityToUpdate)
        {
            repoPravo.UpdateEntity(entityToUpdate);
        }
    }
}
