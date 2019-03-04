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
 public   class VerzijaServices : IServices<Verzija>
    {
        MpContext mp;
        GenericRepository<Verzija> repoVerzija;
        public VerzijaServices()
        {
            mp = new MpContext("InfoContex");
            repoVerzija = new GenericRepository<Verzija>(mp);
        }

        public void Add(Verzija entity)
        {
            repoVerzija.Add(entity);
        }

        public void AddRange(IEnumerable<Verzija> entities)
        {
            repoVerzija.AddRange(entities);
        }

        public Verzija Find(Expression<Func<Verzija, bool>> predicate)
        {
            return repoVerzija.Find(predicate);
        }

        public Verzija Get(int id)
        {
            return repoVerzija.Get(id);
        }

        public IEnumerable<Verzija> GetAll()
        {
            return repoVerzija.Get().ToList();
        }

        public void Remove(Verzija entity)
        {
            repoVerzija.Remove(entity);
        }

        public void RemoveEntity(Verzija entityToDelete)
        {
            repoVerzija.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<Verzija> entities)
        {
            repoVerzija.RemoveRange(entities);
        }

        public void UpdateEntity(Verzija entityToUpdate)
        {
            repoVerzija.UpdateEntity(entityToUpdate);
        }
    }
}
