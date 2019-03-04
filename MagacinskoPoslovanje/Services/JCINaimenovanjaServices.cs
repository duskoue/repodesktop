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
  public  class JCINaimenovanjaServices :IServices<JCINaimenovanja>
    {
        MpContext mp;
        GenericRepository<JCINaimenovanja> repoJCINaimenovanja;
        public JCINaimenovanjaServices()
        {
            mp = new MpContext("InfoContext");
            repoJCINaimenovanja = new GenericRepository<JCINaimenovanja>(mp);
        }

        public void Add(JCINaimenovanja entity)
        {
            repoJCINaimenovanja.Add(entity);
        }

        public void AddRange(IEnumerable<JCINaimenovanja> entities)
        {
            repoJCINaimenovanja.AddRange(entities);
        }

        public JCINaimenovanja Find(Expression<Func<JCINaimenovanja, bool>> predicate)
        {
           return repoJCINaimenovanja.Find(predicate);
        }

        public JCINaimenovanja Get(int id)
        {
            return repoJCINaimenovanja.Get(id);
        }

        public IEnumerable<JCINaimenovanja> GetAll()
        {
            return repoJCINaimenovanja.GetAll().ToList();
        }

        public void Remove(JCINaimenovanja entity)
        {
            repoJCINaimenovanja.Remove(entity);
        }

        public void RemoveEntity(JCINaimenovanja entityToDelete)
        {
            repoJCINaimenovanja.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<JCINaimenovanja> entities)
        {
            repoJCINaimenovanja.RemoveRange(entities);
        }

        public void UpdateEntity(JCINaimenovanja entityToUpdate)
        {
            repoJCINaimenovanja.UpdateEntity(entityToUpdate);
        }
    }
}
