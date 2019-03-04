using MagacinskoPoslovanje.Context;
using MagacinskoPoslovanje.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace MagacinskoPoslovanje.Services
{
  public  class SifarnikEntitetaTipServices : IServices<SifarnikEntitetaTip>
    {
        MpContext mp;
        GenericRepository<SifarnikEntitetaTip> repoSifarnikEntitetaTip;
        public SifarnikEntitetaTipServices()
        {
            mp = new MpContext("InfoContext");
            repoSifarnikEntitetaTip = new GenericRepository<SifarnikEntitetaTip>(mp);
        }

        public void Add(SifarnikEntitetaTip entity)
        {
            repoSifarnikEntitetaTip.Add(entity);
        }

        public void AddRange(IEnumerable<SifarnikEntitetaTip> entities)
        {
            repoSifarnikEntitetaTip.AddRange(entities);
        }

        public SifarnikEntitetaTip Find(Expression<Func<SifarnikEntitetaTip, bool>> predicate)
        {
            return repoSifarnikEntitetaTip.SingleOrDefault(predicate);
        }

        public SifarnikEntitetaTip Get(int id)
        {
            return repoSifarnikEntitetaTip.Get(id);
        }

        public IEnumerable<SifarnikEntitetaTip> GetAll()
        {
            return repoSifarnikEntitetaTip.GetAll().ToList();
        }

        public void Remove(SifarnikEntitetaTip entity)
        {
            repoSifarnikEntitetaTip.Remove(entity);
        }

        public void RemoveEntity(SifarnikEntitetaTip entityToDelete)
        {
            repoSifarnikEntitetaTip.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<SifarnikEntitetaTip> entities)
        {
            repoSifarnikEntitetaTip.RemoveRange(entities);
        }

        public void UpdateEntity(SifarnikEntitetaTip entityToUpdate)
        {
            repoSifarnikEntitetaTip.UpdateEntity(entityToUpdate);
        }
    }
}
