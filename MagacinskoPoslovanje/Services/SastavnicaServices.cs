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
   public class SastavnicaServices :IServices<Sastavnica>
    {
        MpContext mp;
        GenericRepository<Sastavnica> repoSastavnica;
        public SastavnicaServices()
        {
            mp = new MpContext("InfoContext");
            repoSastavnica = new GenericRepository<Sastavnica>(mp);
        }

        public void Add(Sastavnica entity)
        {
            repoSastavnica.Add(entity);
        }

        public void AddRange(IEnumerable<Sastavnica> entities)
        {
            repoSastavnica.AddRange(entities);
        }

        public Sastavnica Find(Expression<Func<Sastavnica, bool>> predicate)
        {
            return repoSastavnica.Find(predicate);
        }

        public Sastavnica Get(int id)
        {
            return repoSastavnica.Get(id);
        }

        public IEnumerable<Sastavnica> GetAll()
        {
            return repoSastavnica.GetAll().ToList();
        }

        public void Remove(Sastavnica entity)
        {
            repoSastavnica.Remove(entity);
        }

        public void RemoveEntity(Sastavnica entityToDelete)
        {
            repoSastavnica.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<Sastavnica> entities)
        {
            repoSastavnica.RemoveRange(entities);
        }

        public void UpdateEntity(Sastavnica entityToUpdate)
        {
            repoSastavnica.UpdateEntity(entityToUpdate);
        }
    }
}
