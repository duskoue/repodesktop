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
   public class GrupaServices :IServices<Grupa>
    {
        MpContext mp;
        GenericRepository<Grupa> repoGrupa;
        public GrupaServices()
        {
            mp = new MpContext("InfoContext");
            repoGrupa = new GenericRepository<Grupa>(mp);
        }

        public void Add(Grupa entity)
        {
            repoGrupa.Add(entity);
        }

        public void AddRange(IEnumerable<Grupa> entities)
        {
            repoGrupa.AddRange(entities);
        }

        public Grupa Find(Expression<Func<Grupa, bool>> predicate)
        {
            return repoGrupa.Find(predicate);
        }

        public Grupa Get(int id)
        {
            return repoGrupa.Get(id);
        }

        public IEnumerable<Grupa> GetAll()
        {
            return repoGrupa.GetAll().ToList();
        }

        public void Remove(Grupa entity)
        {
            repoGrupa.Remove(entity);
        }

        public void RemoveEntity(Grupa entityToDelete)
        {
            repoGrupa.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<Grupa> entities)
        {
            repoGrupa.RemoveRange(entities);
        }

        public void UpdateEntity(Grupa entityToUpdate)
        {
            repoGrupa.UpdateEntity(entityToUpdate);
        }
    }
}
