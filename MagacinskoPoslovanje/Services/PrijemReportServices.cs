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
  public  class PrijemReportServices : IServices<PrijemReport>
    {
        MpContext mp;
        GenericRepository<PrijemReport> repoPrijemReport;
        public PrijemReportServices()
        {
            mp = new MpContext("InfoContext");
            repoPrijemReport = new GenericRepository<PrijemReport>(mp);

        }

        public void Add(PrijemReport entity)
        {
            repoPrijemReport.Add(entity);
        }

        public void AddRange(IEnumerable<PrijemReport> entities)
        {
            repoPrijemReport.AddRange(entities);
        }

        public PrijemReport Find(Expression<Func<PrijemReport, bool>> predicate)
        {
            return repoPrijemReport.Find(predicate);
        }

        public PrijemReport Get(int id)
        {
            return repoPrijemReport.Get(id);
        }

        public IEnumerable<PrijemReport> GetAll()
        {
            return repoPrijemReport.GetAll().ToList();
        }

        public void Remove(PrijemReport entity)
        {
            repoPrijemReport.Remove(entity); 
        }

        public void RemoveEntity(PrijemReport entityToDelete)
        {
            repoPrijemReport.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<PrijemReport> entities)
        {
            repoPrijemReport.RemoveRange(entities);
        }

        public void UpdateEntity(PrijemReport entityToUpdate)
        {
            repoPrijemReport.UpdateEntity(entityToUpdate);
        }
    }
}
