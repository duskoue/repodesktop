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
    class StampaciNalepniceServices : IServices<StampaciNalepnice>
    {
        MpContext mp;
        GenericRepository<StampaciNalepnice> repoStampaciNalepnice;
        public StampaciNalepniceServices()
        {
            mp = new MpContext("InfoContext");
            repoStampaciNalepnice = new GenericRepository<StampaciNalepnice>(mp);
        }

        public void Add(StampaciNalepnice entity)
        {
            repoStampaciNalepnice.Add(entity);
        }

        public void AddRange(IEnumerable<StampaciNalepnice> entities)
        {
            repoStampaciNalepnice.AddRange(entities);
        }

        public StampaciNalepnice Find(Expression<Func<StampaciNalepnice, bool>> predicate)
        {
            return repoStampaciNalepnice.Find(predicate);
        }

        public StampaciNalepnice Get(int id)
        {
            return repoStampaciNalepnice.Get(id);
        }

        public IEnumerable<StampaciNalepnice> GetAll()
        {
            return repoStampaciNalepnice.GetAll().ToList();
        }

        public void Remove(StampaciNalepnice entity)
        {
            repoStampaciNalepnice.Remove(entity);
        }

        public void RemoveEntity(StampaciNalepnice entityToDelete)
        {
            repoStampaciNalepnice.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<StampaciNalepnice> entities)
        {
            repoStampaciNalepnice.RemoveRange(entities);
        }

        public void UpdateEntity(StampaciNalepnice entityToUpdate)
        {
            repoStampaciNalepnice.UpdateEntity(entityToUpdate);
        }
    }
}
