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
   public class ObracunServices : IServices<Obracun>
    {
        MpContext mp;
        GenericRepository<Obracun> repoObracun;
        public ObracunServices()
        {
            mp = new MpContext("InfoContext");
            repoObracun = new GenericRepository<Obracun>(mp);
        }

        public void Add(Obracun entity)
        {
            repoObracun.Add(entity);
        }

        public void AddRange(IEnumerable<Obracun> entities)
        {
            repoObracun.AddRange(entities);
        }

        public Obracun Find(Expression<Func<Obracun, bool>> predicate)
        {
            return repoObracun.Find(predicate);
                
        }

        public Obracun Get(int id)
        {
            return repoObracun.Get(id);
        }

        public IEnumerable<Obracun> GetAll()
        {
            return repoObracun.GetAll().ToList();
        }

        public void Remove(Obracun entity)
        {
            repoObracun.Remove(entity);
        }

        public void RemoveEntity(Obracun entityToDelete)
        {
            repoObracun.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<Obracun> entities)
        {
            repoObracun.RemoveRange(entities);
        }

        public void UpdateEntity(Obracun entityToUpdate)
        {
            repoObracun.UpdateEntity(entityToUpdate);
        
        }
    }
}
