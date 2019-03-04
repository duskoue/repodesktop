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
   public class PrijemnicaServices : IServices<Prijemnica>
    {
        MpContext mp;
        GenericRepository<Prijemnica> repoPrijemnica;
        public PrijemnicaServices()
        {
            mp = new MpContext("InfoContext");
            repoPrijemnica = new GenericRepository<Prijemnica>(mp);
        }

        public void Add(Prijemnica entity)
        {
            repoPrijemnica.Add(entity);
        }

        public void AddRange(IEnumerable<Prijemnica> entities)
        {
            repoPrijemnica.AddRange(entities);
        }

        public Prijemnica Find(Expression<Func<Prijemnica, bool>> predicate)
        {
            return repoPrijemnica.Find(predicate);
        }

        public Prijemnica Get(int id)
        {
            return repoPrijemnica.Get(id);
        }

        public IEnumerable<Prijemnica> GetAll()
        {
            return repoPrijemnica.GetAll().ToList();
        }

        public void Remove(Prijemnica entity)
        {
            repoPrijemnica.Remove(entity);
        }

        public void RemoveEntity(Prijemnica entityToDelete)
        {
            repoPrijemnica.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<Prijemnica> entities)
        {
            repoPrijemnica.RemoveRange(entities);
        }

        public void UpdateEntity(Prijemnica entityToUpdate)
        {
            repoPrijemnica.UpdateEntity(entityToUpdate);
        }
    }
}
