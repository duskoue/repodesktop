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
   public class SastavnicaStavkeServices : IServices<SastavnicaStavke>
    {
        MpContext mp;
        GenericRepository<SastavnicaStavke> repoSastavnicaStavke;
        public SastavnicaStavkeServices()
        {
            mp = new MpContext("InfoContext");
           repoSastavnicaStavke = new GenericRepository<SastavnicaStavke>(mp);
        }

        public void Add(SastavnicaStavke entity)
        {
            repoSastavnicaStavke.Add(entity);
        }

        public void AddRange(IEnumerable<SastavnicaStavke> entities)
        {
            repoSastavnicaStavke.AddRange(entities);
        }

        public SastavnicaStavke Find(Expression<Func<SastavnicaStavke, bool>> predicate)
        {
            return repoSastavnicaStavke.Find(predicate);
        }

        public SastavnicaStavke Get(int id)
        {
            return repoSastavnicaStavke.Get(id);
        }

        public IEnumerable<SastavnicaStavke> GetAll()
        {
            return repoSastavnicaStavke.GetAll().ToList();
        }

        public void Remove(SastavnicaStavke entity)
        {
            repoSastavnicaStavke.Remove(entity);
        }

        public void RemoveEntity(SastavnicaStavke entityToDelete)
        {
            repoSastavnicaStavke.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<SastavnicaStavke> entities)
        {
            repoSastavnicaStavke.RemoveRange(entities);
        }

        public void UpdateEntity(SastavnicaStavke entityToUpdate)
        {
            repoSastavnicaStavke.UpdateEntity(entityToUpdate);
        }
    }
}
