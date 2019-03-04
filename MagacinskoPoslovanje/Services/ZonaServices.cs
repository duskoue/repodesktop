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
  public  class ZonaServices : IServices<Zona>
    {
        MpContext mp;
        GenericRepository<Zona> repoZona;
        public ZonaServices()
        {
            mp = new MpContext("InfoContext");
            repoZona = new GenericRepository<Zona>(mp);
        }

        public void Add(Zona entity)
        {
            repoZona.Add(entity);
        }

        public void AddRange(IEnumerable<Zona> entities)
        {
            repoZona.AddRange(entities);
        }

        public Zona Find(Expression<Func<Zona, bool>> predicate)
        {
            return repoZona.Find(predicate);
        }

        public Zona Get(int id)
        {
            return repoZona.Get(id);
        }

        public IEnumerable<Zona> GetAll()
        {
            return repoZona.GetAll().ToList();
        }

        public void Remove(Zona entity)
        {
            repoZona.Remove(entity);
        }

        public void RemoveEntity(Zona entityToDelete)
        {
            repoZona.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<Zona> entities)
        {
            repoZona.RemoveRange(entities);
        }

        public void UpdateEntity(Zona entityToUpdate)
        {
            repoZona.UpdateEntity(entityToUpdate);
        }
    }
}
