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
   public class PorukaKnjizenjaServices : IServices<PorukaKnjizenja>
    {
        MpContext mp;
        GenericRepository<PorukaKnjizenja> repoPorukaKnjizenja;
        public PorukaKnjizenjaServices()
        {
            mp = new MpContext("InfoContext");
            repoPorukaKnjizenja = new GenericRepository<PorukaKnjizenja>(mp);
        }

        public void Add(PorukaKnjizenja entity)
        {
            repoPorukaKnjizenja.Add(entity);
        }

        public void AddRange(IEnumerable<PorukaKnjizenja> entities)
        {
            repoPorukaKnjizenja.AddRange(entities);
        }

        public PorukaKnjizenja Find(Expression<Func<PorukaKnjizenja, bool>> predicate)
        {
            return repoPorukaKnjizenja.Find(predicate);
        }

        public PorukaKnjizenja Get(int id)
        {
            return repoPorukaKnjizenja.Get(id);
        }

        public IEnumerable<PorukaKnjizenja> GetAll()
        {
            return repoPorukaKnjizenja.GetAll().ToList();
        }

        public void Remove(PorukaKnjizenja entity)
        {
            repoPorukaKnjizenja.Remove(entity);
        }

        public void RemoveEntity(PorukaKnjizenja entityToDelete)
        {
            repoPorukaKnjizenja.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<PorukaKnjizenja> entities)
        {
            repoPorukaKnjizenja.RemoveRange(entities);
        }

        public void UpdateEntity(PorukaKnjizenja entityToUpdate)
        {
            repoPorukaKnjizenja.UpdateEntity(entityToUpdate);
        }
    }
}
