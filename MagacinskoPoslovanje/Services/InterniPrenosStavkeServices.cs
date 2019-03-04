using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MagacinskoPoslovanje.Context;
using MagacinskoPoslovanje.Data;

namespace MagacinskoPoslovanje.Services
{
    
  public  class InterniPrenosStavkeServices : IServices<InterniPrenosStavke>
    {
        MpContext mp;
        GenericRepository<InterniPrenosStavke> repoInterniPremosStavke;
        public InterniPrenosStavkeServices()
        {
            mp = new MpContext("InfoContext");
            repoInterniPremosStavke = new GenericRepository<InterniPrenosStavke>(mp);
        }

        public void Add(InterniPrenosStavke entity)
        {
            repoInterniPremosStavke.Add(entity);
        }

        public void AddRange(IEnumerable<InterniPrenosStavke> entities)
        {
            repoInterniPremosStavke.AddRange(entities);
        }

        public InterniPrenosStavke Find(Expression<Func<InterniPrenosStavke, bool>> predicate)
        {
            return repoInterniPremosStavke.Find(predicate);
        }

        public InterniPrenosStavke Get(int id)
        {
            return repoInterniPremosStavke.Get(id);
        }

        public IEnumerable<InterniPrenosStavke> GetAll()
        {
            return repoInterniPremosStavke.GetAll().ToList();
        }

        public void Remove(InterniPrenosStavke entity)
        {
            repoInterniPremosStavke.Remove(entity);
        }

        public void RemoveEntity(InterniPrenosStavke entityToDelete)
        {
            repoInterniPremosStavke.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<InterniPrenosStavke> entities)
        {
            repoInterniPremosStavke.RemoveRange(entities);
        }

        public void UpdateEntity(InterniPrenosStavke entityToUpdate)
        {
            repoInterniPremosStavke.UpdateEntity(entityToUpdate);
        }
    }
}
