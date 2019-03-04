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
   public class IzlazniIDServices : IServices<IzlazniID>
    {
        MpContext mp;
        GenericRepository<IzlazniID> repoIzlazniID;
        public IzlazniIDServices()
        {
            mp = new MpContext("InfoContext");
            repoIzlazniID = new GenericRepository<IzlazniID>(mp);
        }

        public void Add(IzlazniID entity)
        {
            repoIzlazniID.Add(entity);
        }

        public void AddRange(IEnumerable<IzlazniID> entities)
        {
            repoIzlazniID.AddRange(entities);
        }

        public IzlazniID Find(Expression<Func<IzlazniID, bool>> predicate)
        {
            return repoIzlazniID.Find(predicate);
        }

        public IzlazniID Get(int id)
        {
            return repoIzlazniID.Get(id);
        }

        public IEnumerable<IzlazniID> GetAll()
        {
            return repoIzlazniID.GetAll().ToList();
        }

        public void Remove(IzlazniID entity)
        {
            repoIzlazniID.Remove(entity);
        }

        public void RemoveEntity(IzlazniID entityToDelete)
        {
            repoIzlazniID.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<IzlazniID> entities)
        {
            repoIzlazniID.RemoveRange(entities);
        }

        public void UpdateEntity(IzlazniID entityToUpdate)
        {
            repoIzlazniID.UpdateEntity(entityToUpdate);
        }
    }
}
