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
   public class PopisStavkeServices : IServices<PopisStavke>
    {
        MpContext mp;
        GenericRepository<PopisStavke> repoPopisStavke;
        public PopisStavkeServices()
        {
            mp = new MpContext("InfoContext");
            repoPopisStavke = new GenericRepository<PopisStavke>(mp);
        }

        public void Add(PopisStavke entity)
        {
            repoPopisStavke.Add(entity);
        }

        public void AddRange(IEnumerable<PopisStavke> entities)
        {
            repoPopisStavke.AddRange(entities);
        }

        public PopisStavke Find(Expression<Func<PopisStavke, bool>> predicate)
        {
            return repoPopisStavke.Find(predicate);
        }

        public PopisStavke Get(int id)
        {
            return repoPopisStavke.Get(id);
        }

        public IEnumerable<PopisStavke> GetAll()
        {
            return repoPopisStavke.GetAll().ToList();
        }

        public void Remove(PopisStavke entity)
        {
            repoPopisStavke.Remove(entity);
        }

        public void RemoveEntity(PopisStavke entityToDelete)
        {
            repoPopisStavke.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<PopisStavke> entities)
        {
            repoPopisStavke.RemoveRange(entities);
        }

        public void UpdateEntity(PopisStavke entityToUpdate)
        {
            repoPopisStavke.UpdateEntity(entityToUpdate);
        }
    }
}
