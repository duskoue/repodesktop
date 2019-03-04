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
   public class PrijemnicaStavkeServices : IServices<PrijemnicaStavke>
    {
        MpContext mp;
        GenericRepository<PrijemnicaStavke> repoPrijemnicaStavke;
        public PrijemnicaStavkeServices()
        {
            mp = new MpContext("InfoContext");
            repoPrijemnicaStavke = new GenericRepository<PrijemnicaStavke>(mp);
        }

        public void Add(PrijemnicaStavke entity)
        {
            repoPrijemnicaStavke.Add(entity);
        }

        public void AddRange(IEnumerable<PrijemnicaStavke> entities)
        {
            repoPrijemnicaStavke.AddRange(entities);
        }

        public PrijemnicaStavke Find(Expression<Func<PrijemnicaStavke, bool>> predicate)
        {
            return repoPrijemnicaStavke.Find(predicate);
        }

        public PrijemnicaStavke Get(int id)
        {
            return repoPrijemnicaStavke.Get(id);
        }

        public IEnumerable<PrijemnicaStavke> GetAll()
        {
            return repoPrijemnicaStavke.GetAll().ToList();
        }

        public void Remove(PrijemnicaStavke entity)
        {
            repoPrijemnicaStavke.Remove(entity);
        }

        public void RemoveEntity(PrijemnicaStavke entityToDelete)
        {
            repoPrijemnicaStavke.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<PrijemnicaStavke> entities)
        {
            repoPrijemnicaStavke.RemoveRange(entities);

        }

        public void UpdateEntity(PrijemnicaStavke entityToUpdate)
        {
            repoPrijemnicaStavke.UpdateEntity(entityToUpdate);
        }
    }
}
