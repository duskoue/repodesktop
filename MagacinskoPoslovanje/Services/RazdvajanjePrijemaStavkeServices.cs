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
   public class RazdvajanjePrijemaStavkeServices : IServices<RazdvajanjePrijemaStavke>
    {

        MpContext mp;
        GenericRepository<RazdvajanjePrijemaStavke> repoRazdvajanjePrijemaStavke;
        public RazdvajanjePrijemaStavkeServices()
        {
            mp = new MpContext("InfoContext");
            repoRazdvajanjePrijemaStavke = new GenericRepository<RazdvajanjePrijemaStavke>(mp);
        }

        public void Add(RazdvajanjePrijemaStavke entity)
        {
            repoRazdvajanjePrijemaStavke.Add(entity);
        }

        public void AddRange(IEnumerable<RazdvajanjePrijemaStavke> entities)
        {
            repoRazdvajanjePrijemaStavke.AddRange(entities);
        }

        public RazdvajanjePrijemaStavke Find(Expression<Func<RazdvajanjePrijemaStavke, bool>> predicate)
        {
            return repoRazdvajanjePrijemaStavke.Find(predicate);
        }

        public RazdvajanjePrijemaStavke Get(int id)
        {
            return repoRazdvajanjePrijemaStavke.Get(id);
        }

        public IEnumerable<RazdvajanjePrijemaStavke> GetAll()
        {
            return repoRazdvajanjePrijemaStavke.GetAll().ToList();
        }

        public void Remove(RazdvajanjePrijemaStavke entity)
        {
            repoRazdvajanjePrijemaStavke.Remove(entity);
        }

        public void RemoveEntity(RazdvajanjePrijemaStavke entityToDelete)
        {
            repoRazdvajanjePrijemaStavke.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<RazdvajanjePrijemaStavke> entities)
        {
            repoRazdvajanjePrijemaStavke.RemoveRange(entities);
        }

        public void UpdateEntity(RazdvajanjePrijemaStavke entityToUpdate)
        {
            repoRazdvajanjePrijemaStavke.UpdateEntity(entityToUpdate);
        }
    }
}
