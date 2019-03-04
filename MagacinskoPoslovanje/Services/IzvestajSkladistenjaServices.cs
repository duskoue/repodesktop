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
  public  class IzvestajSkladistenjaServices : IServices<IzvestajSkladistenja>
    {
        MpContext mp;
        GenericRepository<IzvestajSkladistenja> repoIzvestajSkladistenja;
        public IzvestajSkladistenjaServices()
        {
            mp = new MpContext("InfoContext");
            repoIzvestajSkladistenja = new GenericRepository<IzvestajSkladistenja>(mp);
        }

        public void Add(IzvestajSkladistenja entity)
        {
            repoIzvestajSkladistenja.Add(entity);
        }

        public void AddRange(IEnumerable<IzvestajSkladistenja> entities)
        {
            repoIzvestajSkladistenja.AddRange(entities);
        }

        public IzvestajSkladistenja Find(Expression<Func<IzvestajSkladistenja, bool>> predicate)
        {

            return repoIzvestajSkladistenja.Find(predicate);
        }

        public IzvestajSkladistenja Get(int id)
        {
            return repoIzvestajSkladistenja.Get(id);
        }

        public IEnumerable<IzvestajSkladistenja> GetAll()
        {
            return repoIzvestajSkladistenja.GetAll().ToList();
        }

        public void Remove(IzvestajSkladistenja entity)
        {
            repoIzvestajSkladistenja.Remove(entity);
        }

        public void RemoveEntity(IzvestajSkladistenja entityToDelete)
        {
            repoIzvestajSkladistenja.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<IzvestajSkladistenja> entities)
        {
            repoIzvestajSkladistenja.RemoveRange(entities);
        }

        public void UpdateEntity(IzvestajSkladistenja entityToUpdate)
        {
            repoIzvestajSkladistenja.UpdateEntity(entityToUpdate);
        }
    }
}
