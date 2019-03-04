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
   public class PosaoServices : IServices<Posao>
    {
        MpContext mp;
        GenericRepository<Posao> repoPosao;
        public PosaoServices()
        {
            mp = new MpContext("InfoContext");
            repoPosao = new GenericRepository<Posao>(mp);
        }

        public void Add(Posao entity)
        {
            repoPosao.Add(entity);
        }

        public void AddRange(IEnumerable<Posao> entities)
        {
            repoPosao.AddRange(entities);
        }

        public Posao Find(Expression<Func<Posao, bool>> predicate)
        {
            return repoPosao.Find(predicate);
        }

        public Posao Get(int id)
        {
            return repoPosao.Get(id);
        }

        public IEnumerable<Posao> GetAll()
        {
            return repoPosao.GetAll().ToList();
        }

        public void Remove(Posao entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveEntity(Posao entityToDelete)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<Posao> entities)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(Posao entityToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
