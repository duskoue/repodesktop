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
  public  class OtpremnicaServices : IServices<Otpremnica>
    {
        MpContext mp;
        GenericRepository<Otpremnica> repoOtpremnica;
        public OtpremnicaServices()
        {
            mp = new MpContext("InfoContext");
            repoOtpremnica = new GenericRepository<Otpremnica>(mp);
        }

        public void Add(Otpremnica entity)
        {
            repoOtpremnica.Add(entity);
        }

        public void AddRange(IEnumerable<Otpremnica> entities)
        {
            repoOtpremnica.AddRange(entities);
        }

        public Otpremnica Find(Expression<Func<Otpremnica, bool>> predicate)
        {
            return repoOtpremnica.Find(predicate);
        }

        public Otpremnica Get(int id)
        {
            return repoOtpremnica.Get(id);
        }

        public IEnumerable<Otpremnica> GetAll()
        {
            return repoOtpremnica.GetAll().ToList();
        }

        public void Remove(Otpremnica entity)
        {
            repoOtpremnica.Remove(entity);
        }

        public void RemoveEntity(Otpremnica entityToDelete)
        {
            repoOtpremnica.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<Otpremnica> entities)
        {
            repoOtpremnica.RemoveRange(entities);
        }

        public void UpdateEntity(Otpremnica entityToUpdate)
        {
            repoOtpremnica.UpdateEntity(entityToUpdate);
        }
    }
}
