using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MagacinskoPoslovanje.Context;
using MagacinskoPoslovanje.Data;

namespace MagacinskoPoslovanje.Services
{
   public class CarinskaGrupaArtiklaServices : IServices<CarinskaGrupaArtikla>
    {
        MpContext mp;
        GenericRepository<CarinskaGrupaArtikla> repoCarinskaGrupaArtikla;
        public CarinskaGrupaArtiklaServices()
        {
            repoCarinskaGrupaArtikla = new GenericRepository<CarinskaGrupaArtikla>(mp);
            mp = new MpContext("InfoContext");
        }

        public void Add(CarinskaGrupaArtikla entity)
        {
            repoCarinskaGrupaArtikla.Add(entity);
        }

        public void AddRange(IEnumerable<CarinskaGrupaArtikla> entities)
        {
            repoCarinskaGrupaArtikla.AddRange(entities);
        }

        public CarinskaGrupaArtikla Find(Expression<Func<CarinskaGrupaArtikla, bool>> predicate)
        {
            return repoCarinskaGrupaArtikla.Find(predicate);
        }

        public CarinskaGrupaArtikla Get(int id)
        {
            return repoCarinskaGrupaArtikla.Get(id);
        }

        public IEnumerable<CarinskaGrupaArtikla> GetAll()
        {
            return repoCarinskaGrupaArtikla.GetAll().ToList();
        }

        public void Remove(CarinskaGrupaArtikla entity)
        {
            repoCarinskaGrupaArtikla.Remove(entity);
        }

        public void RemoveEntity(CarinskaGrupaArtikla entityToDelete)
        {
            repoCarinskaGrupaArtikla.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<CarinskaGrupaArtikla> entities)
        {
            repoCarinskaGrupaArtikla.RemoveRange(entities);
        }

        public void UpdateEntity(CarinskaGrupaArtikla entityToUpdate)
        {
            repoCarinskaGrupaArtikla.UpdateEntity(entityToUpdate);
        }
    }
}
