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
   public class PopiServices : IServices<Popi>
    {
        MpContext mp;
        GenericRepository<Popi> repoPopi;
        public PopiServices()
        {
            mp = new MpContext("InfoContext");
            repoPopi = new GenericRepository<Popi>(mp);
        }

        public void Add(Popi entity)
        {
            repoPopi.Add(entity);
        }

        public void AddRange(IEnumerable<Popi> entities)
        {
            repoPopi.AddRange(entities);
        }

        public Popi Find(Expression<Func<Popi, bool>> predicate)
        {
            return repoPopi.Find(predicate);
        }

        public Popi Get(int id)
        {
            return repoPopi.Get(id);
        }

        public IEnumerable<Popi> GetAll()
        {
            return repoPopi.GetAll().ToList();
        }

        public void Remove(Popi entity)
        {
            repoPopi.Remove(entity);
        }

        public void RemoveEntity(Popi entityToDelete)
        {
            repoPopi.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<Popi> entities)
        {
            repoPopi.RemoveRange(entities);
        }

        public void UpdateEntity(Popi entityToUpdate)
        {
            repoPopi.UpdateEntity(entityToUpdate);
        }
    }
}
