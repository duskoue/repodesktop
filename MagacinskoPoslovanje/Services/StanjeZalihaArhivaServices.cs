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
   public class StanjeZalihaArhivaServices : IServices<StanjeZalihaArhiva>
    {
        MpContext mp;
        GenericRepository<StanjeZalihaArhiva> repoStanjeZalihaArhiva;
        public StanjeZalihaArhivaServices()
        {
            mp = new MpContext("InfoContext");
            repoStanjeZalihaArhiva = new GenericRepository<StanjeZalihaArhiva>(mp); 

        }

        public void Add(StanjeZalihaArhiva entity)
        {
            repoStanjeZalihaArhiva.Add(entity);
        }

        public void AddRange(IEnumerable<StanjeZalihaArhiva> entities)
        {
            repoStanjeZalihaArhiva.AddRange(entities);
        }

        public StanjeZalihaArhiva Find(Expression<Func<StanjeZalihaArhiva, bool>> predicate)
        {
            return repoStanjeZalihaArhiva.Find(predicate);
        }

        public StanjeZalihaArhiva Get(int id)
        {
            return repoStanjeZalihaArhiva.Get(id);
        }

        public IEnumerable<StanjeZalihaArhiva> GetAll()
        {
            return repoStanjeZalihaArhiva.GetAll().ToList();
        }

        public void Remove(StanjeZalihaArhiva entity)
        {
            repoStanjeZalihaArhiva.Remove(entity);
        }

        public void RemoveEntity(StanjeZalihaArhiva entityToDelete)
        {
            repoStanjeZalihaArhiva.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<StanjeZalihaArhiva> entities)
        {
            repoStanjeZalihaArhiva.RemoveRange(entities);
        }

        public void UpdateEntity(StanjeZalihaArhiva entityToUpdate)
        {
            repoStanjeZalihaArhiva.UpdateEntity(entityToUpdate);
        }
    }
}
