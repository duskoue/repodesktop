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
   public class OdabirReportServices : IServices<OdabirReport>
    {
        MpContext mp;
        GenericRepository<OdabirReport> repoOdabirReport;
        public OdabirReportServices()
        {
            mp = new MpContext("InfoContext");
            repoOdabirReport = new GenericRepository<OdabirReport>(mp);
        }

        public void Add(OdabirReport entity)
        {
            repoOdabirReport.Add(entity);
        }

        public void AddRange(IEnumerable<OdabirReport> entities)
        {
            repoOdabirReport.AddRange(entities);
        }

        public OdabirReport Find(Expression<Func<OdabirReport, bool>> predicate)
        {
            return repoOdabirReport.Find(predicate);
        }

        public OdabirReport Get(int id)
        {
            return repoOdabirReport.Get(id);
        }

        public IEnumerable<OdabirReport> GetAll()
        {
            return repoOdabirReport.GetAll().ToList();
        }

        public void Remove(OdabirReport entity)
        {
            repoOdabirReport.Remove(entity);
        }

        public void RemoveEntity(OdabirReport entityToDelete)
        {
            repoOdabirReport.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<OdabirReport> entities)
        {
            repoOdabirReport.RemoveRange(entities);
        }

        public void UpdateEntity(OdabirReport entityToUpdate)
        {
            repoOdabirReport.UpdateEntity(entityToUpdate);
        }
    }
}
