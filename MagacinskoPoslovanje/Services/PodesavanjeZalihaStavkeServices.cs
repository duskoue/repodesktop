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
   public class PodesavanjeZalihaStavkeServices : IServices<PodesavanjeZalihaStavke>
    {
        MpContext mp;
        GenericRepository<PodesavanjeZalihaStavke> repoPodesavanjaZalihaStavke;
        public PodesavanjeZalihaStavkeServices()
        {
            mp = new MpContext("InfoContext");
            repoPodesavanjaZalihaStavke = new GenericRepository<PodesavanjeZalihaStavke>(mp);
        }

        public void Add(PodesavanjeZalihaStavke entity)
        {
            repoPodesavanjaZalihaStavke.Add(entity);
        }

        public void AddRange(IEnumerable<PodesavanjeZalihaStavke> entities)
        {
            repoPodesavanjaZalihaStavke.AddRange(entities);
        }

        public PodesavanjeZalihaStavke Find(Expression<Func<PodesavanjeZalihaStavke, bool>> predicate)
        {
            return repoPodesavanjaZalihaStavke.Find(predicate);
        }

        public PodesavanjeZalihaStavke Get(int id)
        {
            return repoPodesavanjaZalihaStavke.Get(id);
        }

        public IEnumerable<PodesavanjeZalihaStavke> GetAll()
        {
            return repoPodesavanjaZalihaStavke.GetAll().ToList();
        }

        public void Remove(PodesavanjeZalihaStavke entity)
        {
            repoPodesavanjaZalihaStavke.Remove(entity);
        }

        public void RemoveEntity(PodesavanjeZalihaStavke entityToDelete)
        {
            repoPodesavanjaZalihaStavke.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<PodesavanjeZalihaStavke> entities)
        {
            repoPodesavanjaZalihaStavke.RemoveRange(entities);
        }

        public void UpdateEntity(PodesavanjeZalihaStavke entityToUpdate)
        {
            repoPodesavanjaZalihaStavke.UpdateEntity(entityToUpdate);
        }
    }
}
