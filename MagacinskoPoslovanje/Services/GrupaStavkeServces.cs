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
    
 public   class GrupaStavkeServces : IServices<GrupaStavke>
    {
        MpContext mp;
        GenericRepository<GrupaStavke> repoGrupaStavke;
        public GrupaStavkeServces()
        {
            mp = new MpContext("InfoContext");
            repoGrupaStavke = new GenericRepository<GrupaStavke>(mp);
        }

        public void Add(GrupaStavke entity)
        {
            repoGrupaStavke.Add(entity);
        }

        public void AddRange(IEnumerable<GrupaStavke> entities)
        {
            repoGrupaStavke.AddRange(entities);
        }

        public GrupaStavke Find(Expression<Func<GrupaStavke, bool>> predicate)
        {
            return repoGrupaStavke.Find(predicate);
        }

        public GrupaStavke Get(int id)
        {
            return repoGrupaStavke.Get(id);
        }

        public IEnumerable<GrupaStavke> GetAll()
        {
            return repoGrupaStavke.GetAll().ToList();
        }

        public void Remove(GrupaStavke entity)
        {
            repoGrupaStavke.Remove(entity);
        }

        public void RemoveEntity(GrupaStavke entityToDelete)
        {
            repoGrupaStavke.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<GrupaStavke> entities)
        {
            repoGrupaStavke.RemoveRange(entities);
        }

        public void UpdateEntity(GrupaStavke entityToUpdate)
        {
            repoGrupaStavke.UpdateEntity(entityToUpdate);
        }
    }
}
