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
  public  class EksterniPrenosStavkeServices : IServices<EksterniPrenosStavke>
    {
        MpContext mp;
        GenericRepository<EksterniPrenosStavke> repoEksterniPrenosStavke;

        public EksterniPrenosStavkeServices()
        {
            mp = new MpContext("InfoContext");
            repoEksterniPrenosStavke = new GenericRepository<EksterniPrenosStavke>(mp);
        }

        public void Add(EksterniPrenosStavke entity)
        {
            repoEksterniPrenosStavke.Add(entity);
        }

        public void AddRange(IEnumerable<EksterniPrenosStavke> entities)
        {
            repoEksterniPrenosStavke.AddRange(entities);
        }

        public EksterniPrenosStavke Find(Expression<Func<EksterniPrenosStavke, bool>> predicate)
        {
            return repoEksterniPrenosStavke.Find(predicate);
        }

        public EksterniPrenosStavke Get(int id)
        {
            return repoEksterniPrenosStavke.Get(id);
        }

        public IEnumerable<EksterniPrenosStavke> GetAll()
        {
            return repoEksterniPrenosStavke.GetAll().ToList();
        }

        public void Remove(EksterniPrenosStavke entity)
        {
            repoEksterniPrenosStavke.Remove(entity);
        }

        public void RemoveEntity(EksterniPrenosStavke entityToDelete)
        {
            repoEksterniPrenosStavke.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<EksterniPrenosStavke> entities)
        {
            repoEksterniPrenosStavke.RemoveRange(entities);
        }

        public void UpdateEntity(EksterniPrenosStavke entityToUpdate)
        {
            repoEksterniPrenosStavke.UpdateEntity(entityToUpdate);
        }
    }
}
