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
   public class StorageReportZenithServices : IServices<StorageReportZenith>
    {
        MpContext mp;
        GenericRepository<StorageReportZenith> repoStorageReportZenith;
        public StorageReportZenithServices()
        {
            mp = new MpContext("InfoContext");
            repoStorageReportZenith = new GenericRepository<StorageReportZenith>(mp);
         }

        public void Add(StorageReportZenith entity)
        {
            repoStorageReportZenith.Add(entity);
        }

        public void AddRange(IEnumerable<StorageReportZenith> entities)
        {
            repoStorageReportZenith.AddRange(entities);
        }

        public StorageReportZenith Find(Expression<Func<StorageReportZenith, bool>> predicate)
        {
            return repoStorageReportZenith.Find(predicate);
        }

        public StorageReportZenith Get(int id)
        {
            return repoStorageReportZenith.Get(id);
        }

        public IEnumerable<StorageReportZenith> GetAll()
        {
            return repoStorageReportZenith.GetAll().ToList();
        }

        public void Remove(StorageReportZenith entity)
        {
            repoStorageReportZenith.Remove(entity);
        }

        public void RemoveEntity(StorageReportZenith entityToDelete)
        {
            repoStorageReportZenith.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<StorageReportZenith> entities)
        {
            repoStorageReportZenith.RemoveRange(entities);
        }

        public void UpdateEntity(StorageReportZenith entityToUpdate)
        {
            repoStorageReportZenith.UpdateEntity(entityToUpdate);
        }
    }
}
