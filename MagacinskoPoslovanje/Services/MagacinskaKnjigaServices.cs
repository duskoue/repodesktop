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
   public class MagacinskaKnjigaServices : IServices<MagacinskaKnjiga>
    {
        MpContext mp;
        GenericRepository<MagacinskaKnjiga> repoMagacinskaKnjiga;
        public MagacinskaKnjigaServices()
        {
            mp = new MpContext("InfoContext");
            repoMagacinskaKnjiga = new GenericRepository<MagacinskaKnjiga>(mp);
        }

        public void Add(MagacinskaKnjiga entity)
        {
            repoMagacinskaKnjiga.Add(entity);
        }

        public void AddRange(IEnumerable<MagacinskaKnjiga> entities)
        {
            repoMagacinskaKnjiga.AddRange(entities);
        }

        public MagacinskaKnjiga Find(Expression<Func<MagacinskaKnjiga, bool>> predicate)
        {
           return repoMagacinskaKnjiga.Find(predicate);
        }

        public MagacinskaKnjiga Get(int id)
        {
            return repoMagacinskaKnjiga.Get(id);
        }

        public IEnumerable<MagacinskaKnjiga> GetAll()
        {
            return repoMagacinskaKnjiga.GetAll().ToList();
        }

        public void Remove(MagacinskaKnjiga entity)
        {
            repoMagacinskaKnjiga.Remove(entity);
        }

        public void RemoveEntity(MagacinskaKnjiga entityToDelete)
        {
            repoMagacinskaKnjiga.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<MagacinskaKnjiga> entities)
        {
            repoMagacinskaKnjiga.RemoveRange(entities);
        }

        public void UpdateEntity(MagacinskaKnjiga entityToUpdate)
        {
            repoMagacinskaKnjiga.UpdateEntity(entityToUpdate);
        }
    }
}
