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
   public class StanjeZalihaServices : IServices<StanjeZaliha>
    {
        MpContext mp;
        GenericRepository<StanjeZaliha> repoStanjeZaliha;
        public StanjeZalihaServices()
        {
            mp = new MpContext("InfoContext");
            repoStanjeZaliha = new GenericRepository<StanjeZaliha>(mp);
        }

        public void Add(StanjeZaliha entity)
        {
            repoStanjeZaliha.Add(entity);
        }

        public void AddRange(IEnumerable<StanjeZaliha> entities)
        {
            repoStanjeZaliha.AddRange(entities);
        }

        public StanjeZaliha Find(Expression<Func<StanjeZaliha, bool>> predicate)
        {
            return repoStanjeZaliha.Find(predicate);
        }

        public StanjeZaliha Get(int id)
        {
            return repoStanjeZaliha.Get(id);
        }

        public IEnumerable<StanjeZaliha> GetAll()
        {
            return repoStanjeZaliha.GetAll().ToList();
        }

        public void Remove(StanjeZaliha entity)
        {
            repoStanjeZaliha.Remove(entity);
        }

        public void RemoveEntity(StanjeZaliha entityToDelete)
        {
            repoStanjeZaliha.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<StanjeZaliha> entities)
        {
            repoStanjeZaliha.RemoveRange(entities);
        }

        public void UpdateEntity(StanjeZaliha entityToUpdate)
        {
            repoStanjeZaliha.UpdateEntity(entityToUpdate);
        }
    }
}
