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
  public  class InterfaceLogServices : IServices<InterfaceLog>
    {
        MpContext mp;
        GenericRepository<InterfaceLog> repoInterfaceLog;
        public InterfaceLogServices()
        {
            mp = new MpContext("InfoContext");
            repoInterfaceLog = new GenericRepository<InterfaceLog>(mp);
        }

        public void Add(InterfaceLog entity)
        {
            repoInterfaceLog.Add(entity);
        }

        public void AddRange(IEnumerable<InterfaceLog> entities)
        {
            repoInterfaceLog.AddRange(entities);
        }

        public InterfaceLog Find(Expression<Func<InterfaceLog, bool>> predicate)
        {
            return repoInterfaceLog.Find(predicate);
        }

        public InterfaceLog Get(int id)
        {
            return repoInterfaceLog.Get(id);
        }

        public IEnumerable<InterfaceLog> GetAll()
        {
            return repoInterfaceLog.GetAll().ToList();
        }

        public void Remove(InterfaceLog entity)
        {
            repoInterfaceLog.Remove(entity);
        }

        public void RemoveEntity(InterfaceLog entityToDelete)
        {
             repoInterfaceLog.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<InterfaceLog> entities)
        {
            repoInterfaceLog.RemoveRange(entities);
        }

        public void UpdateEntity(InterfaceLog entityToUpdate)
        {
            repoInterfaceLog.UpdateEntity(entityToUpdate);
        }
    }
}
