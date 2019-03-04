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
   public class MestoServices : IServices<Mesto>
    {
        MpContext mp;
        GenericRepository<Mesto> repoMesto;
        public MestoServices()
        {
            mp = new MpContext("InfoContext");
            repoMesto = new GenericRepository<Mesto>(mp);
        }

        public void Add(Mesto entity)
        {
            repoMesto.Add(entity);
        }

        public void AddRange(IEnumerable<Mesto> entities)
        {
            repoMesto.AddRange(entities);
        }

        public Mesto Find(Expression<Func<Mesto, bool>> predicate)
        {
            return repoMesto.Find(predicate);
        }

        public Mesto Get(int id)
        {
            return repoMesto.Get(id);

        }

        public IEnumerable<Mesto> GetAll()
        {
            return repoMesto.GetAll().ToList();
        }

        public void Remove(Mesto entity)
        {
            repoMesto.Remove(entity);
        }

        public void RemoveEntity(Mesto entityToDelete)
        {
            repoMesto.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<Mesto> entities)
        {
            repoMesto.RemoveRange(entities);
        }

        public void UpdateEntity(Mesto entityToUpdate)
        {
            repoMesto.UpdateEntity(entityToUpdate);
        }
    }
}
