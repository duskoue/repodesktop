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
   public class CarinskaIspostavaServices : IServices<CarinskaIspostava>
    {
        MpContext mp;
        GenericRepository<CarinskaIspostava> repoCarinskaIspostava;
        public CarinskaIspostavaServices()
        {
            mp = new MpContext("InfoContext");
            repoCarinskaIspostava = new GenericRepository<CarinskaIspostava>(mp);

        }

        public void Add(CarinskaIspostava entity)
        {
            repoCarinskaIspostava.Add(entity);
        }

        public void AddRange(IEnumerable<CarinskaIspostava> entities)
        {
            repoCarinskaIspostava.AddRange(entities);
        }

        public CarinskaIspostava Find(Expression<Func<CarinskaIspostava, bool>> predicate)
        {
            return repoCarinskaIspostava.Find(predicate);
        }

        public CarinskaIspostava Get(int id)
        {
            return repoCarinskaIspostava.Get(id);
        }

        public IEnumerable<CarinskaIspostava> GetAll()
        {
            return repoCarinskaIspostava.GetAll().ToList();
        }

        public void Remove(CarinskaIspostava entity)
        {
            repoCarinskaIspostava.Remove(entity);
        }

        public void RemoveEntity(CarinskaIspostava entityToDelete)
        {
            repoCarinskaIspostava.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<CarinskaIspostava> entities)
        {
            repoCarinskaIspostava.RemoveRange(entities);
        }

        public void UpdateEntity(CarinskaIspostava entityToUpdate)
        {
            repoCarinskaIspostava.UpdateEntity(entityToUpdate);
        }
    }
}
