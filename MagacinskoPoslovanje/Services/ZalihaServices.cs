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
  public  class ZalihaServices : IServices<Zaliha>
    {
        MpContext mp;
        GenericRepository<Zaliha> repoZaliha;
        public ZalihaServices()
        {
            mp = new MpContext("InfoContext");
            repoZaliha = new GenericRepository<Zaliha>(mp);
        }

        public void Add(Zaliha entity)
        {
            repoZaliha.Add(entity);
        }

        public void AddRange(IEnumerable<Zaliha> entities)
        {
            repoZaliha.AddRange(entities);
        }

        public Zaliha Find(Expression<Func<Zaliha, bool>> predicate)
        {
            return repoZaliha.Find(predicate);
        }

        public Zaliha Get(int id)
        {
            return repoZaliha.Get(id);
        }

        public IEnumerable<Zaliha> GetAll()
        {
            return repoZaliha.GetAll().ToList();
        }

        public void Remove(Zaliha entity)
        {
            repoZaliha.Remove(entity);
        }

        public void RemoveEntity(Zaliha entityToDelete)
        {
            repoZaliha.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<Zaliha> entities)
        {
            repoZaliha.RemoveRange(entities);
        }

        public void UpdateEntity(Zaliha entityToUpdate)
        {
            repoZaliha.UpdateEntity(entityToUpdate);
        }
    }
}
