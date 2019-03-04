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
   public class UtovarServices : IServices<Utovar>
    {
        MpContext mp;
        GenericRepository<Utovar> repoUtovar;
        public UtovarServices()
        {
            mp = new MpContext("InfoContext");
            repoUtovar = new GenericRepository<Utovar>(mp);
        }

        public void Add(Utovar entity)
        {
            repoUtovar.Add(entity);
        }

        public void AddRange(IEnumerable<Utovar> entities)
        {
            repoUtovar.AddRange(entities);
        }

        public Utovar Find(Expression<Func<Utovar, bool>> predicate)
        {
            return repoUtovar.Find(predicate);
        }

        public Utovar Get(int id)
        {
            return repoUtovar.Get(id);
        }

        public IEnumerable<Utovar> GetAll()
        {
            return repoUtovar.GetAll().ToList();
        }

        public void Remove(Utovar entity)
        {
            repoUtovar.Remove(entity);
        }

        public void RemoveEntity(Utovar entityToDelete)
        {
            repoUtovar.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<Utovar> entities)
        {
            repoUtovar.RemoveRange(entities);
        }

        public void UpdateEntity(Utovar entityToUpdate)
        {
            repoUtovar.UpdateEntity(entityToUpdate);
        }
    }
}
