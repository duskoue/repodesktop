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
   public class DupleSifreServices : IServices<DupleSifre>
    {
        MpContext mp;
        GenericRepository<DupleSifre> repoDupleSifre;
        public DupleSifreServices()
        {
            mp = new MpContext("InfoContext");
            repoDupleSifre = new GenericRepository<DupleSifre>(mp);
        }

        public void Add(DupleSifre entity)
        {
            repoDupleSifre.Add(entity);
        }

        public void AddRange(IEnumerable<DupleSifre> entities)
        {
            repoDupleSifre.AddRange(entities);
        }

        public DupleSifre Find(Expression<Func<DupleSifre, bool>> predicate)
        {
            return repoDupleSifre.Find(predicate);
        }

        public DupleSifre Get(int id)
        {
            return repoDupleSifre.Get(id);
        }

        public IEnumerable<DupleSifre> GetAll()
        {
            return repoDupleSifre.GetAll().ToList();
        }

        public void Remove(DupleSifre entity)
        {
            repoDupleSifre.Remove(entity);
        }

        public void RemoveEntity(DupleSifre entityToDelete)
        {
            repoDupleSifre.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<DupleSifre> entities)
        {
            repoDupleSifre.RemoveRange(entities);
        }

        public void UpdateEntity(DupleSifre entityToUpdate)
        {
            repoDupleSifre.UpdateEntity(entityToUpdate);
        }
    }
}
