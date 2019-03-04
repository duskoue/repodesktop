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
   public class UlaziIzlaziServices : IServices<UlaziIzlazi>
    {
        MpContext mp;
        GenericRepository<UlaziIzlazi> repoUlaziIzlazi;
        public UlaziIzlaziServices()
        {
            mp = new MpContext("InfoContext");
            repoUlaziIzlazi = new GenericRepository<UlaziIzlazi>(mp);
        }

        public void Add(UlaziIzlazi entity)
        {
            repoUlaziIzlazi.Add(entity);
        }

        public void AddRange(IEnumerable<UlaziIzlazi> entities)
        {
            repoUlaziIzlazi.AddRange(entities);
        }

        public UlaziIzlazi Find(Expression<Func<UlaziIzlazi, bool>> predicate)
        {
            return repoUlaziIzlazi.Find(predicate);
        }

        public UlaziIzlazi Get(int id)
        {
            return repoUlaziIzlazi.Get(id);
        }

        public IEnumerable<UlaziIzlazi> GetAll()
        {
            return repoUlaziIzlazi.GetAll().ToList();
        }

        public void Remove(UlaziIzlazi entity)
        {
            repoUlaziIzlazi.Remove(entity);
        }

        public void RemoveEntity(UlaziIzlazi entityToDelete)
        {
            repoUlaziIzlazi.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<UlaziIzlazi> entities)
        {
            repoUlaziIzlazi.RemoveRange(entities);
        }

        public void UpdateEntity(UlaziIzlazi entityToUpdate)
        {
            repoUlaziIzlazi.UpdateEntity(entityToUpdate);
        }
    }
}
