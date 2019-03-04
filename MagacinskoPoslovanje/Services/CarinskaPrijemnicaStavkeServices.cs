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
   public class CarinskaPrijemnicaStavkeServices : IServices<CarinskaPrijemnicaStavke>
    {
        MpContext mp;
        GenericRepository<CarinskaPrijemnicaStavke> repoCarinskaPrijemnicaStavke;
        public CarinskaPrijemnicaStavkeServices()
        {
            mp = new MpContext("InfoContext");
            repoCarinskaPrijemnicaStavke = new GenericRepository<CarinskaPrijemnicaStavke>(mp);
        }

        public void Add(CarinskaPrijemnicaStavke entity)
        {
            repoCarinskaPrijemnicaStavke.Add(entity);
        }

        public void AddRange(IEnumerable<CarinskaPrijemnicaStavke> entities)
        {
            repoCarinskaPrijemnicaStavke.AddRange(entities);
        }

        public CarinskaPrijemnicaStavke Find(Expression<Func<CarinskaPrijemnicaStavke, bool>> predicate)
        {
            return repoCarinskaPrijemnicaStavke.Find(predicate);
        }

        public CarinskaPrijemnicaStavke Get(int id)
        {
            return repoCarinskaPrijemnicaStavke.Get(id);
                
        }

        public IEnumerable<CarinskaPrijemnicaStavke> GetAll()
        {
            return repoCarinskaPrijemnicaStavke.GetAll().ToList();
        }

        public void Remove(CarinskaPrijemnicaStavke entity)
        {
            repoCarinskaPrijemnicaStavke.Remove(entity);
        }

        public void RemoveEntity(CarinskaPrijemnicaStavke entityToDelete)
        {
            repoCarinskaPrijemnicaStavke.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<CarinskaPrijemnicaStavke> entities)
        {
            repoCarinskaPrijemnicaStavke.RemoveRange(entities);
        }

        public void UpdateEntity(CarinskaPrijemnicaStavke entityToUpdate)
        {
            repoCarinskaPrijemnicaStavke.UpdateEntity(entityToUpdate);

        }
    }
}
