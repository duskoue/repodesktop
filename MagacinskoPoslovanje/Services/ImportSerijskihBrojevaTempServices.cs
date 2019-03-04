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
   public class ImportSerijskihBrojevaTempServices : IServices<ImportSerijskihBrojevaTemp>
    {
        MpContext mp;
        GenericRepository<ImportSerijskihBrojevaTemp> repoImportSerijskihBrojevaTemp;
        public ImportSerijskihBrojevaTempServices()
        {
            mp = new MpContext("InfoContext");
            repoImportSerijskihBrojevaTemp = new GenericRepository<ImportSerijskihBrojevaTemp>(mp);
        }

        public void Add(ImportSerijskihBrojevaTemp entity)
        {
            repoImportSerijskihBrojevaTemp.Add(entity);
        }

        public void AddRange(IEnumerable<ImportSerijskihBrojevaTemp> entities)
        {
            repoImportSerijskihBrojevaTemp.AddRange(entities);
        }

        public ImportSerijskihBrojevaTemp Find(Expression<Func<ImportSerijskihBrojevaTemp, bool>> predicate)
        {
            return repoImportSerijskihBrojevaTemp.Find(predicate);
        }

        public ImportSerijskihBrojevaTemp Get(int id)
        {
            return repoImportSerijskihBrojevaTemp.Get(id);
        }

        public IEnumerable<ImportSerijskihBrojevaTemp> GetAll()
        {
            return repoImportSerijskihBrojevaTemp.GetAll().ToList();
        }

        public void Remove(ImportSerijskihBrojevaTemp entity)
        {
            repoImportSerijskihBrojevaTemp.Remove(entity);
        }

        public void RemoveEntity(ImportSerijskihBrojevaTemp entityToDelete)
        {
            repoImportSerijskihBrojevaTemp.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<ImportSerijskihBrojevaTemp> entities)
        {
            repoImportSerijskihBrojevaTemp.RemoveRange(entities);
        }

        public void UpdateEntity(ImportSerijskihBrojevaTemp entityToUpdate)
        {
            repoImportSerijskihBrojevaTemp.UpdateEntity(entityToUpdate);
        }
    }
}
