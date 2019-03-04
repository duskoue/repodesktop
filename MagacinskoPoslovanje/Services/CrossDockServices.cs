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
   public class CrossDockServices : IServices<CrossDock>
    {
        MpContext mp;
        GenericRepository<CrossDock> repoCrossDock;
        public CrossDockServices()

        {
            mp = new MpContext("InfoContext");
            repoCrossDock = new GenericRepository<CrossDock>(mp);
        }

        public void Add(CrossDock entity)
        {
            repoCrossDock.Add(entity);
        }

        public void AddRange(IEnumerable<CrossDock> entities)
        {
            repoCrossDock.AddRange(entities);
        }

        public CrossDock Find(Expression<Func<CrossDock, bool>> predicate)
        {
            return repoCrossDock.Find(predicate);
        }

        public CrossDock Get(int id)
        {
            return repoCrossDock.Get(id);
        }

        public IEnumerable<CrossDock> GetAll()
        {
            return repoCrossDock.GetAll().ToList();
        }

        public void Remove(CrossDock entity)
        {
            repoCrossDock.Remove(entity);
        }

        public void RemoveEntity(CrossDock entityToDelete)
        {
            repoCrossDock.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<CrossDock> entities)
        {
            repoCrossDock.RemoveRange(entities);
        }

        public void UpdateEntity(CrossDock entityToUpdate)
        {
            repoCrossDock.UpdateEntity(entityToUpdate);
        }
    }
}
