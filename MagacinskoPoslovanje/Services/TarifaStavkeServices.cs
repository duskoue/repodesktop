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
   public class TarifaStavkeServices : IServices<TarifaStavke>
    {
        MpContext mp;
        GenericRepository<TarifaStavke> repoTarifaStavke;
        public TarifaStavkeServices()
        {
            mp = new MpContext("InfoContext");
            repoTarifaStavke = new GenericRepository<TarifaStavke>(mp);
        }

        public void Add(TarifaStavke entity)
        {
            repoTarifaStavke.Add(entity);
        }

        public void AddRange(IEnumerable<TarifaStavke> entities)
        {
            repoTarifaStavke.AddRange(entities);
        }

        public TarifaStavke Find(Expression<Func<TarifaStavke, bool>> predicate)
        {
            return repoTarifaStavke.Find(predicate);
        }

        public TarifaStavke Get(int id)
        {
            return repoTarifaStavke.Get(id);
        }

        public IEnumerable<TarifaStavke> GetAll()
        {
            return repoTarifaStavke.GetAll().ToList();
        }

        public void Remove(TarifaStavke entity)
        {
            repoTarifaStavke.Remove(entity);
        }

        public void RemoveEntity(TarifaStavke entityToDelete)
        {
            repoTarifaStavke.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<TarifaStavke> entities)
        {
            repoTarifaStavke.RemoveRange(entities);
        }

        public void UpdateEntity(TarifaStavke entityToUpdate)
        {
            repoTarifaStavke.UpdateEntity(entityToUpdate);
        }
    }
}
