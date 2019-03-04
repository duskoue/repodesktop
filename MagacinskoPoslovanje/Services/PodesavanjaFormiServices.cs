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
  public  class PodesavanjaFormiServices :IServices<PodesavanjaFormi>
    {
        MpContext mp;
        GenericRepository<PodesavanjaFormi> repoPodesavanjaFormi;
        public PodesavanjaFormiServices()
        {
            mp = new MpContext("InfoContext");
            repoPodesavanjaFormi = new GenericRepository<PodesavanjaFormi>(mp);
        }

        public void Add(PodesavanjaFormi entity)
        {
            repoPodesavanjaFormi.Add(entity);
        }

        public void AddRange(IEnumerable<PodesavanjaFormi> entities)
        {
            repoPodesavanjaFormi.AddRange(entities);
        }

        public PodesavanjaFormi Find(Expression<Func<PodesavanjaFormi, bool>> predicate)
        {
            return repoPodesavanjaFormi.Find(predicate);
        }

        public PodesavanjaFormi Get(int id)
        {
            return repoPodesavanjaFormi.Get(id);
        }

        public IEnumerable<PodesavanjaFormi> GetAll()
        {
            return repoPodesavanjaFormi.GetAll().ToList();
        }

        public void Remove(PodesavanjaFormi entity)
        {
            repoPodesavanjaFormi.Remove(entity);
        }

        public void RemoveEntity(PodesavanjaFormi entityToDelete)
        {
            repoPodesavanjaFormi.RemoveEntity(entityToDelete);


        }

        public void RemoveRange(IEnumerable<PodesavanjaFormi> entities)
        {
            repoPodesavanjaFormi.RemoveRange(entities);
        }

        public void UpdateEntity(PodesavanjaFormi entityToUpdate)
        {
            repoPodesavanjaFormi.UpdateEntity(entityToUpdate);
        }
    }
}
