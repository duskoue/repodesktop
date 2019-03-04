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
   public class CarinskaOtpremnicaServices : IServices<CarinskaOtpremnica>
    {
        GenericRepository<CarinskaOtpremnica> repoCarinskaOtpremnica;
        MpContext mp;
        public CarinskaOtpremnicaServices()
        {
            mp = new MpContext("InfoContext");
            repoCarinskaOtpremnica = new GenericRepository<CarinskaOtpremnica>(mp);

        }

        public CarinskaOtpremnica Get(int id)
        {
           return repoCarinskaOtpremnica.Get(id);
        }

        public IEnumerable<CarinskaOtpremnica> GetAll()
        {
            return repoCarinskaOtpremnica.GetAll().ToList();
        }

        public void Add(CarinskaOtpremnica entity)
        {
            repoCarinskaOtpremnica.Add(entity);
        }

        public void AddRange(IEnumerable<CarinskaOtpremnica> entities)
        {
            repoCarinskaOtpremnica.AddRange(entities);
        }

        public void Remove(CarinskaOtpremnica entity)
        {
            repoCarinskaOtpremnica.Remove(entity);
        }

        public void UpdateEntity(CarinskaOtpremnica entityToUpdate)
        {
            repoCarinskaOtpremnica.UpdateEntity(entityToUpdate);
        }

        public void RemoveRange(IEnumerable<CarinskaOtpremnica> entities)
        {
            repoCarinskaOtpremnica.RemoveRange(entities);
        }

        public void RemoveEntity(CarinskaOtpremnica entityToDelete)
        {
            repoCarinskaOtpremnica.RemoveEntity(entityToDelete);
        }

        public CarinskaOtpremnica Find(Expression<Func<CarinskaOtpremnica, bool>> predicate)
        {
            return repoCarinskaOtpremnica.Find(predicate);
        }
    }
}
