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
   public class CPReportServices : IServices<CPReport>
    {
        MpContext mp;
        GenericRepository<CPReport> repoCPReport;
        public CPReportServices()
        {
            mp = new MpContext("InfoContext");
            repoCPReport = new GenericRepository<CPReport>(mp);
        }

        public void Add(CPReport entity)
        {
            repoCPReport.Add(entity);
        }

        public void AddRange(IEnumerable<CPReport> entities)
        {
            repoCPReport.AddRange(entities);
        }

        public CPReport Find(Expression<Func<CPReport, bool>> predicate)
        {
            return repoCPReport.Find(predicate);
        }

        public CPReport Get(int id)
        {
            return repoCPReport.Get(id);
        }

        public IEnumerable<CPReport> GetAll()
        {
            return repoCPReport.GetAll().ToList();
        }

        public void Remove(CPReport entity)
        {
            repoCPReport.Remove(entity);
        }

        public void RemoveEntity(CPReport entityToDelete)
        {
            repoCPReport.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<CPReport> entities)
        {
            repoCPReport.RemoveRange(entities);
        }

        public void UpdateEntity(CPReport entityToUpdate)
        {
            repoCPReport.UpdateEntity(entityToUpdate);
        }
    }
}
