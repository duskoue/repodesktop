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
   public class PrilogServices : IServices<Prilog>
    {
        MpContext mp;
        GenericRepository<Prilog> repoPrilog;
        public PrilogServices()
        {
            mp = new MpContext("InfoContext");
            repoPrilog = new GenericRepository<Prilog>(mp);

        }

        public void Add(Prilog entity)
        {
            repoPrilog.Add(entity);
        }

        public void AddRange(IEnumerable<Prilog> entities)
        {
            repoPrilog.AddRange(entities);
        }

        public Prilog Find(Expression<Func<Prilog, bool>> predicate)
        {
            return repoPrilog.Find(predicate);
        }

        public Prilog Get(int id)
        {
            return repoPrilog.Get(id);
        }

        public IEnumerable<Prilog> GetAll()
        {
            return repoPrilog.GetAll().ToList();
        }

        public void Remove(Prilog entity)
        {
            repoPrilog.Remove(entity);
        }

        public void RemoveEntity(Prilog entityToDelete)
        {
            repoPrilog.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<Prilog> entities)
        {
            repoPrilog.RemoveRange(entities);
        }

        public void UpdateEntity(Prilog entityToUpdate)
        {
            repoPrilog.UpdateEntity(entityToUpdate);
        }
    }
}
