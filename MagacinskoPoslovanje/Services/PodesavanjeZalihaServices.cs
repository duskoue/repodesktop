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
   public class PodesavanjeZalihaServices : IServices<PodesavanjeZaliha>
    {
        MpContext mp;
        GenericRepository<PodesavanjeZaliha> repoPodesavanjaZaliha;
        public PodesavanjeZalihaServices()
        {
            mp = new MpContext("InfoContext");
            repoPodesavanjaZaliha = new GenericRepository<PodesavanjeZaliha>(mp);
        }

        public void Add(PodesavanjeZaliha entity)
        {
            repoPodesavanjaZaliha.Add(entity);
        }

        public void AddRange(IEnumerable<PodesavanjeZaliha> entities)
        {
            repoPodesavanjaZaliha.AddRange(entities);
        }

        public PodesavanjeZaliha Find(Expression<Func<PodesavanjeZaliha, bool>> predicate)
        {
            return repoPodesavanjaZaliha.Find(predicate);
        }

        public PodesavanjeZaliha Get(int id)
        {
            return repoPodesavanjaZaliha.Get(id);
        }

        public IEnumerable<PodesavanjeZaliha> GetAll()
        {
            return repoPodesavanjaZaliha.GetAll().ToList();
        }

        public void Remove(PodesavanjeZaliha entity)
        {
            repoPodesavanjaZaliha.Remove(entity);
        }

        public void RemoveEntity(PodesavanjeZaliha entityToDelete)
        {
            repoPodesavanjaZaliha.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<PodesavanjeZaliha> entities)
        {
            repoPodesavanjaZaliha.RemoveRange(entities);
        }

        public void UpdateEntity(PodesavanjeZaliha entityToUpdate)
        {
            repoPodesavanjaZaliha.UpdateEntity(entityToUpdate);
        }
    }
}
