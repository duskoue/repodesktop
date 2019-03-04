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
   public class SumaSarzaMBServices : IServices<SumaSarzaMB>
    {
        MpContext mp;
        GenericRepository<SumaSarzaMB> repoSumaSarzaMB;
        public SumaSarzaMBServices()
        {
            mp = new MpContext("InfoContext");
            repoSumaSarzaMB = new GenericRepository<SumaSarzaMB>(mp);
        }

        public void Add(SumaSarzaMB entity)
        {
            repoSumaSarzaMB.Add(entity);
        }

        public void AddRange(IEnumerable<SumaSarzaMB> entities)
        {
            repoSumaSarzaMB.AddRange(entities);
        }

        public SumaSarzaMB Find(Expression<Func<SumaSarzaMB, bool>> predicate)
        {
            return repoSumaSarzaMB.Find(predicate);
        }

        public SumaSarzaMB Get(int id)
        {
            return repoSumaSarzaMB.Get(id);
        }

        public IEnumerable<SumaSarzaMB> GetAll()
        {
            return repoSumaSarzaMB.GetAll().ToList();
        }

        public void Remove(SumaSarzaMB entity)
        {
            repoSumaSarzaMB.Remove(entity);
        }

        public void RemoveEntity(SumaSarzaMB entityToDelete)
        {
            repoSumaSarzaMB.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<SumaSarzaMB> entities)
        {
            repoSumaSarzaMB.RemoveRange(entities);
        }

        public void UpdateEntity(SumaSarzaMB entityToUpdate)
        {
            repoSumaSarzaMB.UpdateEntity(entityToUpdate);
        }
    }
}
