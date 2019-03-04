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
   public class CarinskaPrijemnicaServices : IServices<CarinskaPrijemnica>
    {
        MpContext mp;
        GenericRepository<CarinskaPrijemnica> repoCarinskaPrijemnica;
        public CarinskaPrijemnicaServices()
        {
            mp = new MpContext("InfoContext");
            repoCarinskaPrijemnica = new GenericRepository<CarinskaPrijemnica>(mp);
        }

        public void Add(CarinskaPrijemnica entity)
        {
            repoCarinskaPrijemnica.Add(entity);
        }

        public void AddRange(IEnumerable<CarinskaPrijemnica> entities)
        {
            repoCarinskaPrijemnica.AddRange(entities);
        }

        public CarinskaPrijemnica Find(Expression<Func<CarinskaPrijemnica, bool>> predicate)
        {
            return repoCarinskaPrijemnica.Find(predicate);
        }

        public CarinskaPrijemnica Get(int id)
        {
            return repoCarinskaPrijemnica.Get(id);
        }

        public IEnumerable<CarinskaPrijemnica> GetAll()
        {
            return repoCarinskaPrijemnica.GetAll().ToList();
        }

        public void Remove(CarinskaPrijemnica entity)
        {
            repoCarinskaPrijemnica.Remove(entity);
        }

        public void RemoveEntity(CarinskaPrijemnica entityToDelete)
        {
            repoCarinskaPrijemnica.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<CarinskaPrijemnica> entities)
        {
            repoCarinskaPrijemnica.RemoveRange(entities);
        }

        public void UpdateEntity(CarinskaPrijemnica entityToUpdate)
        {
            repoCarinskaPrijemnica.UpdateEntity(entityToUpdate);
        }
    }
}
