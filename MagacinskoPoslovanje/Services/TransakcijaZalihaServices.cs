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
   public class TransakcijaZalihaServices : IServices<TransakcijaZaliha>
    {
        MpContext mp;
        GenericRepository<TransakcijaZaliha> repoTransakcijaZaliha;
        public TransakcijaZalihaServices()
        {
            mp = new MpContext("InfoContext");
            repoTransakcijaZaliha = new GenericRepository<TransakcijaZaliha>(mp);
        }

        public void Add(TransakcijaZaliha entity)
        {
            repoTransakcijaZaliha.Add(entity);
        }

        public void AddRange(IEnumerable<TransakcijaZaliha> entities)
        {
            repoTransakcijaZaliha.AddRange(entities);
        }

        public TransakcijaZaliha Find(Expression<Func<TransakcijaZaliha, bool>> predicate)
        {
            return repoTransakcijaZaliha.Find(predicate);
        }

        public TransakcijaZaliha Get(int id)
        {
            return repoTransakcijaZaliha.Get(id);
        }

        public IEnumerable<TransakcijaZaliha> GetAll()
        {
            return repoTransakcijaZaliha.GetAll().ToList();
        }

        public void Remove(TransakcijaZaliha entity)
        {
            repoTransakcijaZaliha.Remove(entity);
        }

        public void RemoveEntity(TransakcijaZaliha entityToDelete)
        {
            repoTransakcijaZaliha.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<TransakcijaZaliha> entities)
        {
            repoTransakcijaZaliha.RemoveRange(entities);
        }

        public void UpdateEntity(TransakcijaZaliha entityToUpdate)
        {
            repoTransakcijaZaliha.UpdateEntity(entityToUpdate);
        }
    }
}
