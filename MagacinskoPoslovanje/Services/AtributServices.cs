using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MagacinskoPoslovanje.Context;
using MagacinskoPoslovanje.Data;

namespace MagacinskoPoslovanje.Services
{
  public  class AtributServices : IServices<Atribut>
    {
        MpContext mp;
        GenericRepository<Atribut> repoAtribut;
        public AtributServices()
        {
            repoAtribut = new GenericRepository<Atribut>(mp);
            mp = new MpContext("InfoContext");
        }

        public void Add(Atribut entity)
        {
            repoAtribut.Add(entity);
        }

        public void AddRange(IEnumerable<Atribut> entities)
        {
            repoAtribut.AddRange(entities);
        }

        public Atribut Find(Expression<Func<Atribut, bool>> predicate)
        {
            return repoAtribut.Find(predicate);
        }

        public Atribut Get(int id)
        {
            return repoAtribut.Get(id);
        }

        public IEnumerable<Atribut> GetAll()
        {
            return repoAtribut.GetAll().ToList();
        }

        public void Remove(Atribut entity)
        {
            repoAtribut.Remove(entity);
        }

        public void RemoveEntity(Atribut entityToDelete)
        {
            repoAtribut.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<Atribut> entities)
        {
            repoAtribut.RemoveRange(entities);
        }

        public void UpdateEntity(Atribut entityToUpdate)
        {
            repoAtribut.UpdateEntity(entityToUpdate);
        }
    }
}
