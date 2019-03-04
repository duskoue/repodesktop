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
  public  class UtovarStavkeServices : IServices<UtovarStavke>
    {
        MpContext mp;
        GenericRepository<UtovarStavke> repoUtovarStavke;
        public UtovarStavkeServices()
        {
            mp = new MpContext("InfoContext");
            repoUtovarStavke = new GenericRepository<UtovarStavke>(mp);
        }

        public void Add(UtovarStavke entity)
        {
            repoUtovarStavke.Add(entity);
        }

        public void AddRange(IEnumerable<UtovarStavke> entities)
        {
            repoUtovarStavke.AddRange(entities);
        }

        public UtovarStavke Find(Expression<Func<UtovarStavke, bool>> predicate)
        {
            return repoUtovarStavke.Find(predicate);
        }

        public UtovarStavke Get(int id)
        {
            return repoUtovarStavke.Get(id);
        }

        public IEnumerable<UtovarStavke> GetAll()
        {
            return repoUtovarStavke.GetAll().ToList();
        }

        public void Remove(UtovarStavke entity)
        {
            repoUtovarStavke.Remove(entity);
        }

        public void RemoveEntity(UtovarStavke entityToDelete)
        {
            repoUtovarStavke.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<UtovarStavke> entities)
        {
            repoUtovarStavke.RemoveRange(entities);
        }

        public void UpdateEntity(UtovarStavke entityToUpdate)
        {
            repoUtovarStavke.UpdateEntity(entityToUpdate);
        }
    }
}
