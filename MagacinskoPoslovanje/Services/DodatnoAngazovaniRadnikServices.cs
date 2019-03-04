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
   public class DodatnoAngazovaniRadnikServices : IServices<DodatnoAngazovaniRadnik>
    {
        MpContext mp;
        GenericRepository<DodatnoAngazovaniRadnik> repoDodatntnoAngazovaniRadnik;

        public DodatnoAngazovaniRadnikServices()
        {
            repoDodatntnoAngazovaniRadnik = new GenericRepository<DodatnoAngazovaniRadnik>(mp);
            mp = new MpContext("InfoContext");
                
        }

        public void Add(DodatnoAngazovaniRadnik entity)
        {
            repoDodatntnoAngazovaniRadnik.Add(entity);
        }

        public void AddRange(IEnumerable<DodatnoAngazovaniRadnik> entities)
        {
            repoDodatntnoAngazovaniRadnik.AddRange(entities);
        }

        public DodatnoAngazovaniRadnik Find(Expression<Func<DodatnoAngazovaniRadnik, bool>> predicate)
        {
            return repoDodatntnoAngazovaniRadnik.Find(predicate);
        }

        public DodatnoAngazovaniRadnik Get(int id)
        {
            return repoDodatntnoAngazovaniRadnik.Get(id);
        }

        public IEnumerable<DodatnoAngazovaniRadnik> GetAll()
        {
            return repoDodatntnoAngazovaniRadnik.GetAll().ToList();
        }

        public void Remove(DodatnoAngazovaniRadnik entity)
        {
            repoDodatntnoAngazovaniRadnik.Remove(entity);
        }

        public void RemoveEntity(DodatnoAngazovaniRadnik entityToDelete)
        {
            repoDodatntnoAngazovaniRadnik.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<DodatnoAngazovaniRadnik> entities)
        {
            repoDodatntnoAngazovaniRadnik.RemoveRange(entities);
        }

        public void UpdateEntity(DodatnoAngazovaniRadnik entityToUpdate)
        {
            repoDodatntnoAngazovaniRadnik.UpdateEntity(entityToUpdate);
        }
    }
}
