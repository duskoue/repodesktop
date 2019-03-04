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
  public  class ValutaServices : IServices<Valuta>
    {
        MpContext mp;
        GenericRepository<Valuta> repoValuta;
        public ValutaServices()
        {
            mp = new MpContext("InfoContex");
            repoValuta = new GenericRepository<Valuta>(mp);
        }

        public void Add(Valuta entity)
        {
            repoValuta.Add(entity);
        }

        public void AddRange(IEnumerable<Valuta> entities)
        {
            repoValuta.AddRange(entities);
        }

        public Valuta Find(Expression<Func<Valuta, bool>> predicate)
        {
           return repoValuta.Find(predicate);
        }

        public Valuta Get(int id)
        {
            return repoValuta.Get(id);
        }

        public IEnumerable<Valuta> GetAll()
        {
            return repoValuta.GetAll().ToList();
        }

        public void Remove(Valuta entity)
        {
            repoValuta.Remove(entity);
        }

        public void RemoveEntity(Valuta entityToDelete)
        {
            repoValuta.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<Valuta> entities)
        {
            repoValuta.RemoveRange(entities);
        }

        public void UpdateEntity(Valuta entityToUpdate)
        {
            repoValuta.UpdateEntity(entityToUpdate);
        }
    }
}
