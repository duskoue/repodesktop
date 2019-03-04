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
   public class OtpremnicaStavkeServices : IServices<OtpremnicaStavke>
    {
        MpContext mp;
        GenericRepository<OtpremnicaStavke> repoOtpremnicaStavke;
        public OtpremnicaStavkeServices()
        {
           
             mp = new MpContext("InfoContext");
            repoOtpremnicaStavke = new GenericRepository<OtpremnicaStavke>(mp);
        }

        public void Add(OtpremnicaStavke entity)
        {
            repoOtpremnicaStavke.Add(entity);
        }

        public void AddRange(IEnumerable<OtpremnicaStavke> entities)
        {
            repoOtpremnicaStavke.AddRange(entities);
        }

        public OtpremnicaStavke Find(Expression<Func<OtpremnicaStavke, bool>> predicate)
        {
            return repoOtpremnicaStavke.Find(predicate);
        }

        public OtpremnicaStavke Get(int id)
        {
            return repoOtpremnicaStavke.Get(id);
        }

        public IEnumerable<OtpremnicaStavke> GetAll()
        {
            return repoOtpremnicaStavke.GetAll().ToList();
        }

        public void Remove(OtpremnicaStavke entity)
        {
            repoOtpremnicaStavke.Remove(entity);
        }

        public void RemoveEntity(OtpremnicaStavke entityToDelete)
        {
            repoOtpremnicaStavke.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<OtpremnicaStavke> entities)
        {
            repoOtpremnicaStavke.RemoveRange(entities);
        }

        public void UpdateEntity(OtpremnicaStavke entityToUpdate)
        {
            repoOtpremnicaStavke.UpdateEntity(entityToUpdate);
        }
    }
}
