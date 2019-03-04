using MagacinskoPoslovanje.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using MagacinskoPoslovanje.Context;

namespace MagacinskoPoslovanje.Services
{
   public class BlokadaServices : IServices<Blokada>
    {
        MpContext mp;
        GenericRepository<Blokada> repoBlokada;
        public BlokadaServices()
        {
            repoBlokada = new GenericRepository<Blokada>(mp);
            mp = new MpContext("InfoContext");
        }

        public void Add(Blokada entity)
        {
            repoBlokada.Add(entity);
        }

        public void AddRange(IEnumerable<Blokada> entities)
        {
            repoBlokada.AddRange(entities);
        }

        public Blokada Find(Expression<Func<Blokada, bool>> predicate)
        {
            return repoBlokada.Find(predicate);
        }

        public Blokada Get(int id)
        {
            return repoBlokada.Get(id);
        }

        public IEnumerable<Blokada> GetAll()
        {
            return repoBlokada.GetAll().ToList();
        }

        public void Remove(Blokada entity)
        {
            repoBlokada.Remove(entity);
        }

        public void RemoveEntity(Blokada entityToDelete)
        {
            repoBlokada.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<Blokada> entities)
        {
            repoBlokada.RemoveRange(entities);
        }

        public void UpdateEntity(Blokada entityToUpdate)
        {
            repoBlokada.UpdateEntity(entityToUpdate);
        }
    }
}
