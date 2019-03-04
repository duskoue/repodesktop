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
  public  class SkladisteServices : IServices<Skladiste>
    {
        MpContext mp;
        GenericRepository<Skladiste> repoSkladiste;
        public SkladisteServices()
        {
            mp = new MpContext("InfoContext");
            repoSkladiste = new GenericRepository<Skladiste>(mp);
        }

        public void Add(Skladiste entity)
        {
            repoSkladiste.Add(entity);
        }

        public void AddRange(IEnumerable<Skladiste> entities)
        {
            repoSkladiste.AddRange(entities);

        }

        public Skladiste Find(Expression<Func<Skladiste, bool>> predicate)
        {
            return repoSkladiste.Find(predicate);
            
        }

        public Skladiste Get(int id)
        {
            return repoSkladiste.Get(id);
        }

        public IEnumerable<Skladiste> GetAll()
        {
            return repoSkladiste.GetAll().ToList();
        }

        public void Remove(Skladiste entity)
        {
            repoSkladiste.Remove(entity);
        }

        public void RemoveEntity(Skladiste entityToDelete)
        {
            repoSkladiste.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<Skladiste> entities)
        {
            repoSkladiste.RemoveRange(entities);
        }

        public void UpdateEntity(Skladiste entityToUpdate)
        {
            repoSkladiste.UpdateEntity(entityToUpdate);
        }
    }
}
