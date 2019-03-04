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
   public class NabavniNalogStavkeServices : IServices<NabavniNalogStavke>
    {
        MpContext mp;
        GenericRepository<NabavniNalogStavke> repoNabavniNalogStavke;
        public NabavniNalogStavkeServices()
        {
            mp = new MpContext("InfoContext");
            repoNabavniNalogStavke = new GenericRepository<NabavniNalogStavke>(mp);
        }

        public void Add(NabavniNalogStavke entity)
        {
            repoNabavniNalogStavke.Add(entity);
        }

        public void AddRange(IEnumerable<NabavniNalogStavke> entities)
        {
            repoNabavniNalogStavke.AddRange(entities);
        }

        public NabavniNalogStavke Find(Expression<Func<NabavniNalogStavke, bool>> predicate)
        {
            return repoNabavniNalogStavke.Find(predicate);
        }

        public NabavniNalogStavke Get(int id)
        {
            return repoNabavniNalogStavke.Get(id);
        }

        public IEnumerable<NabavniNalogStavke> GetAll()
        {
            return repoNabavniNalogStavke.GetAll().ToList();
        }

        public void Remove(NabavniNalogStavke entity)
        {
            repoNabavniNalogStavke.Remove(entity);
        }

        public void RemoveEntity(NabavniNalogStavke entityToDelete)
        {
            repoNabavniNalogStavke.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<NabavniNalogStavke> entities)
        {
            repoNabavniNalogStavke.RemoveRange(entities);
        }

        public void UpdateEntity(NabavniNalogStavke entityToUpdate)
        {
            repoNabavniNalogStavke.UpdateEntity(entityToUpdate);
        }
    }
}
