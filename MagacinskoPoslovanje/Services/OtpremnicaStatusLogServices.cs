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
  public  class OtpremnicaStatusLogServices : IServices<OtpremnicaStatusLog>
    {
        MpContext mp;
        GenericRepository<OtpremnicaStatusLog> repoOtpremnicaStatusiLog;
        public OtpremnicaStatusLogServices()
        {
            mp = new MpContext("InfoContext");
            repoOtpremnicaStatusiLog = new GenericRepository<OtpremnicaStatusLog>(mp);
        }

        public void Add(OtpremnicaStatusLog entity)
        {
            repoOtpremnicaStatusiLog.Add(entity);
        }

        public void AddRange(IEnumerable<OtpremnicaStatusLog> entities)
        {
            repoOtpremnicaStatusiLog.AddRange(entities);
        }

        public OtpremnicaStatusLog Find(Expression<Func<OtpremnicaStatusLog, bool>> predicate)
        {
            return repoOtpremnicaStatusiLog.Find(predicate);
        }

        public OtpremnicaStatusLog Get(int id)
        {
            return repoOtpremnicaStatusiLog.Get(id);
        }

        public IEnumerable<OtpremnicaStatusLog> GetAll()
        {
            return repoOtpremnicaStatusiLog.GetAll().ToList();
        }

        public void Remove(OtpremnicaStatusLog entity)
        {
            repoOtpremnicaStatusiLog.Remove(entity);
        }

        public void RemoveEntity(OtpremnicaStatusLog entityToDelete)
        {
            repoOtpremnicaStatusiLog.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<OtpremnicaStatusLog> entities)
        {
            repoOtpremnicaStatusiLog.RemoveRange(entities);
        }

        public void UpdateEntity(OtpremnicaStatusLog entityToUpdate)
        {
            repoOtpremnicaStatusiLog.UpdateEntity(entityToUpdate);
        }
    }
}
