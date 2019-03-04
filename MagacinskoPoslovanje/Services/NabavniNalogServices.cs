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
   public class NabavniNalogServices : IServices<NabavniNalog>
    {
        MpContext mp;
        GenericRepository<NabavniNalog> repoNabavniNalog;
        public NabavniNalogServices()
        {
            mp = new MpContext("InfoContext");
            repoNabavniNalog = new GenericRepository<NabavniNalog>(mp);
        }

        public void Add(NabavniNalog entity)
        {
            repoNabavniNalog.Add(entity);
        }

        public void AddRange(IEnumerable<NabavniNalog> entities)
        {
            repoNabavniNalog.AddRange(entities);
        }

        public NabavniNalog Find(Expression<Func<NabavniNalog, bool>> predicate)
        {
            return repoNabavniNalog.Find(predicate);
        }

        public NabavniNalog Get(int id)
        {
            return repoNabavniNalog.Get(id);
        }

        public IEnumerable<NabavniNalog> GetAll()
        {
            return repoNabavniNalog.GetAll().ToList();
        }

        public void Remove(NabavniNalog entity)
        {
            repoNabavniNalog.Remove(entity);
        }

        public void RemoveEntity(NabavniNalog entityToDelete)
        {
            repoNabavniNalog.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<NabavniNalog> entities)
        {
            repoNabavniNalog.RemoveRange(entities);
        }

        public void UpdateEntity(NabavniNalog entityToUpdate)
        {
            repoNabavniNalog.UpdateEntity(entityToUpdate);
        }
    }
}
