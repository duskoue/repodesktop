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
  public  class tmpArtikalServices : IServices<tmpArtikal>
    {
        MpContext mp;
        GenericRepository<tmpArtikal> repoTmpArtikal;
        public tmpArtikalServices()
        {
            mp = new MpContext("InfoContext");
            repoTmpArtikal = new GenericRepository<tmpArtikal>(mp);
        }

        public void Add(tmpArtikal entity)
        {
            repoTmpArtikal.Add(entity);
        }

        public void AddRange(IEnumerable<tmpArtikal> entities)
        {
            repoTmpArtikal.AddRange(entities);
        }

        public tmpArtikal Find(Expression<Func<tmpArtikal, bool>> predicate)
        {
            return repoTmpArtikal.Find(predicate);
        }

        public tmpArtikal Get(int id)
        {
            return repoTmpArtikal.Get(id);
        }

        public IEnumerable<tmpArtikal> GetAll()
        {
            return repoTmpArtikal.GetAll().ToList();
        }

        public void Remove(tmpArtikal entity)
        {
            repoTmpArtikal.Remove(entity);
        }

        public void RemoveEntity(tmpArtikal entityToDelete)
        {
            repoTmpArtikal.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<tmpArtikal> entities)
        {
            repoTmpArtikal.RemoveRange(entities);
        }

        public void UpdateEntity(tmpArtikal entityToUpdate)
        {
            repoTmpArtikal.UpdateEntity(entityToUpdate);
        }
    }
}
