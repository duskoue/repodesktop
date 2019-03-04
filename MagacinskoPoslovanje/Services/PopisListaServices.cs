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
   public class PopisListaServices : IServices<PopisLista>
    {
        MpContext mp;
        GenericRepository<PopisLista> repoPopisLista;
        public PopisListaServices()
        {
            mp = new MpContext("InfoContext");
            repoPopisLista = new GenericRepository<PopisLista>(mp);
        }

        public void Add(PopisLista entity)
        {
            repoPopisLista.Add(entity);
        }

        public void AddRange(IEnumerable<PopisLista> entities)
        {
            repoPopisLista.AddRange(entities);
        }

        public PopisLista Find(Expression<Func<PopisLista, bool>> predicate)
        {
            return repoPopisLista.Find(predicate);
        }

        public PopisLista Get(int id)
        {
            return repoPopisLista.Get(id);
        }

        public IEnumerable<PopisLista> GetAll()
        {
            return repoPopisLista.GetAll().ToList();
        }

        public void Remove(PopisLista entity)
        {
            repoPopisLista.Remove(entity);
        }

        public void RemoveEntity(PopisLista entityToDelete)
        {
            repoPopisLista.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<PopisLista> entities)
        {
            repoPopisLista.RemoveRange(entities);
        }

        public void UpdateEntity(PopisLista entityToUpdate)
        {
            repoPopisLista.UpdateEntity(entityToUpdate);
        }
    }
}
