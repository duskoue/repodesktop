using MagacinskoPoslovanje.Context;
using MagacinskoPoslovanje.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using MagacinskoPoslovanje.Data;
using MagacinskoPoslovanje.Context;
namespace MagacinskoPoslovanje.Services
{
    public class SifanikEntitetaServices : IServices<SifarnikEntiteta>
    {
        MpContext mp;
        GenericRepository<SifarnikEntiteta> repo;
        public SifanikEntitetaServices()
        {
            mp = new MpContext("InfoContext");
            repo = new GenericRepository<SifarnikEntiteta>(mp);
        }

        public void Add(SifarnikEntiteta entity)
        {
            repo.Add(entity);
            
        }

        public void AddRange(IEnumerable<SifarnikEntiteta> entities)
        {
            repo.AddRange(entities);
        }

        public SifarnikEntiteta Find(Expression<Func<SifarnikEntiteta, bool>> predicate)
        {
            return repo.SingleOrDefault(predicate);
        }

        public SifarnikEntiteta Get(int id)
        {
            return repo.Get(id);
        }

        public IEnumerable<SifarnikEntiteta> GetAll()
        {
            return repo.GetAll().ToList();
            
        }

        public void Remove(SifarnikEntiteta entity)
        {
            repo.Remove(entity);
        }

        public void RemoveEntity(SifarnikEntiteta entityToDelete)
        {
            repo.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<SifarnikEntiteta> entities)
        {
            repo.RemoveRange(entities);
        }

       

        public void UpdateEntity(SifarnikEntiteta entityToUpdate)
        {
            repo.UpdateEntity(entityToUpdate);
        }
    }
}
    

    
    

