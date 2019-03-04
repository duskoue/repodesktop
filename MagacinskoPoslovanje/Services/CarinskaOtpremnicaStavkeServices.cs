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
   public class CarinskaOtpremnicaStavkeServices : IServices<CarinskaOtpremnicaStavke>
    {
        MpContext mp;
        GenericRepository<CarinskaOtpremnicaStavke> repoCarinskaOtpremnicaStavke;
        public CarinskaOtpremnicaStavkeServices()
        {
            mp = new MpContext("InfoContext");
            repoCarinskaOtpremnicaStavke = new GenericRepository<CarinskaOtpremnicaStavke>(mp);
        }

        public void Add(CarinskaOtpremnicaStavke entity)
        {
            repoCarinskaOtpremnicaStavke.Add(entity);
        }

        public void AddRange(IEnumerable<CarinskaOtpremnicaStavke> entities)
        {
            repoCarinskaOtpremnicaStavke.AddRange(entities);
        }

        public CarinskaOtpremnicaStavke Find(Expression<Func<CarinskaOtpremnicaStavke, bool>> predicate)
        {
            return repoCarinskaOtpremnicaStavke.Find(predicate);
        }

        public CarinskaOtpremnicaStavke Get(int id)
        {
            return repoCarinskaOtpremnicaStavke.Get(id);
        }

        public IEnumerable<CarinskaOtpremnicaStavke> GetAll()
        {
            return repoCarinskaOtpremnicaStavke.GetAll().ToList();
        }

        public void Remove(CarinskaOtpremnicaStavke entity)
        {
            repoCarinskaOtpremnicaStavke.Remove(entity);
        }

        public void RemoveEntity(CarinskaOtpremnicaStavke entityToDelete)
        {
            repoCarinskaOtpremnicaStavke.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<CarinskaOtpremnicaStavke> entities)
        {
            repoCarinskaOtpremnicaStavke.RemoveRange(entities);
        }

        public void UpdateEntity(CarinskaOtpremnicaStavke entityToUpdate)
        {
            repoCarinskaOtpremnicaStavke.UpdateEntity(entityToUpdate);
        }
    }
}
