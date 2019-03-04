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
  public  class LogHostServices : IServices<LogHost>

    {
        MpContext mp;
        GenericRepository<LogHost> repoLogHost;
        public LogHostServices()
        {
            mp = new MpContext("InfoCotext");
            repoLogHost = new GenericRepository<LogHost>(mp);
        }

        public void Add(LogHost entity)
        {
            repoLogHost.Add(entity);
        }

        public void AddRange(IEnumerable<LogHost> entities)
        {
            repoLogHost.AddRange(entities);
        }

        public LogHost Find(Expression<Func<LogHost, bool>> predicate)
        {
            return repoLogHost.Find(predicate);
        }

        public LogHost Get(int id)
        {
            return repoLogHost.Get(id);
        }

        public IEnumerable<LogHost> GetAll()
        {
            return repoLogHost.GetAll().ToList();
        }

        public void Remove(LogHost entity)
        {
            repoLogHost.Remove(entity);
        }

        public void RemoveEntity(LogHost entityToDelete)
        {
            repoLogHost.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<LogHost> entities)
        {
            repoLogHost.RemoveRange(entities);
        }

        public void UpdateEntity(LogHost entityToUpdate)
        {
            repoLogHost.UpdateEntity(entityToUpdate);
        }
    }
}
