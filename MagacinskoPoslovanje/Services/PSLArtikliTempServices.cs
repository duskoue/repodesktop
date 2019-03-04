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
   public class PSLArtikliTempServices : IServices<PSLArtikliTemp>
    {
        MpContext mp;
        GenericRepository<PSLArtikliTemp> repoPSLArtikliTemp;
        public PSLArtikliTempServices()
        {
            mp = new MpContext("InfoContext");
            repoPSLArtikliTemp = new GenericRepository<PSLArtikliTemp>(mp);
        }

        public void Add(PSLArtikliTemp entity)
        {
            repoPSLArtikliTemp.Add(entity);
        }

        public void AddRange(IEnumerable<PSLArtikliTemp> entities)
        {
            repoPSLArtikliTemp.AddRange(entities);
        }

        public PSLArtikliTemp Find(Expression<Func<PSLArtikliTemp, bool>> predicate)
        {
            return repoPSLArtikliTemp.Find(predicate);
        }

        public PSLArtikliTemp Get(int id)
        {
            return repoPSLArtikliTemp.Get(id);
        }

        public IEnumerable<PSLArtikliTemp> GetAll()
        {
            return repoPSLArtikliTemp.GetAll().ToList();
        }

        public void Remove(PSLArtikliTemp entity)
        {
            repoPSLArtikliTemp.Remove(entity);
        }

        public void RemoveEntity(PSLArtikliTemp entityToDelete)
        {
            repoPSLArtikliTemp.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<PSLArtikliTemp> entities)
        {
            repoPSLArtikliTemp.RemoveRange(entities);
        }

        public void UpdateEntity(PSLArtikliTemp entityToUpdate)
        {
            repoPSLArtikliTemp.UpdateEntity(entityToUpdate);
        }
    }
}
