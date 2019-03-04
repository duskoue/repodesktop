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
  public  class StatusLogServices : IServices<StatusLog>
    {
        MpContext mp;
        GenericRepository<StatusLog> repoStatusLog;
        public StatusLogServices()
        {
            mp = new MpContext("InfoContext");
            repoStatusLog = new GenericRepository<StatusLog>(mp);
        }

        public void Add(StatusLog entity)
        {
            repoStatusLog.Add(entity);
        }

        public void AddRange(IEnumerable<StatusLog> entities)
        {
            repoStatusLog.AddRange(entities);
        }

        public StatusLog Find(Expression<Func<StatusLog, bool>> predicate)
        {
            return repoStatusLog.Find(predicate);
        }

        public StatusLog Get(int id)
        {
            return repoStatusLog.Get(id);
        }

        public IEnumerable<StatusLog> GetAll()
        {
            return repoStatusLog.GetAll().ToList();
        }

        public void Remove(StatusLog entity)
        {
            repoStatusLog.Remove(entity);
        }

        public void RemoveEntity(StatusLog entityToDelete)
        {
            repoStatusLog.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<StatusLog> entities)
        {
            repoStatusLog.RemoveRange(entities);
        }

        public void UpdateEntity(StatusLog entityToUpdate)
        {
            repoStatusLog.UpdateEntity(entityToUpdate);
        }
    }
}
