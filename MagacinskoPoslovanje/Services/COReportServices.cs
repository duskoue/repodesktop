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
   public class COReportServices : IServices<COReport>
    {
        MpContext mp;
        GenericRepository<COReport> repoCOReport;
        public COReportServices()
        {
            mp = new MpContext("InfoContext");
            repoCOReport = new GenericRepository<COReport>(mp);
        }

        public void Add(COReport entity)
        {
            repoCOReport.Add(entity);
        }

        public void AddRange(IEnumerable<COReport> entities)
        {
            repoCOReport.AddRange(entities);
        }

        public COReport Find(Expression<Func<COReport, bool>> predicate)
        {
            return repoCOReport.Find(predicate);
        }

        public COReport Get(int id)
        {
            return repoCOReport.Get(id);
        }

        public IEnumerable<COReport> GetAll()
        {
            return repoCOReport.GetAll().ToList();
        }

        public void Remove(COReport entity)
        {
            repoCOReport.Remove(entity);
        }

        public void RemoveEntity(COReport entityToDelete)
        {
            repoCOReport.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<COReport> entities)
        {
            repoCOReport.RemoveRange(entities);
        }

        public void UpdateEntity(COReport entityToUpdate)
        {
            repoCOReport.UpdateEntity(entityToUpdate);
        }
    }
}
