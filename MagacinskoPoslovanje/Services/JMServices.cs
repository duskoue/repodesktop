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
  public  class JMServices :IServices<JM>
    {
        MpContext mp;
        GenericRepository<JM> repoJM;
        public JMServices()
        {
            mp = new MpContext("InfoContext");
            repoJM = new GenericRepository<JM>(mp);
        }

        public void Add(JM entity)
        {
            repoJM.Add(entity);
        }

        public void AddRange(IEnumerable<JM> entities)
        {
            repoJM.AddRange(entities);
        }

        public JM Find(Expression<Func<JM, bool>> predicate)
        {
            return repoJM.Find(predicate);
        }

        public JM Get(int id)
        {
            return repoJM.Get(id);
        }

        public IEnumerable<JM> GetAll()
        {
            return repoJM.GetAll().ToList();
        }

        public void Remove(JM entity)
        {
            repoJM.Remove(entity);
        }

        public void RemoveEntity(JM entityToDelete)
        {
            repoJM.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<JM> entities)
        {
            repoJM.RemoveRange(entities);
        }

        public void UpdateEntity(JM entityToUpdate)
        {
            repoJM.UpdateEntity(entityToUpdate);
        }
    }
}
