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
   public class OtpremnicaKontrolaServices : IServices<OtpremnicaKontrola>
    {
        MpContext mp;
        GenericRepository<OtpremnicaKontrola> repoOtpremnicaKontrola;
        public OtpremnicaKontrolaServices()
        {
            mp = new MpContext("InfoContext");
            repoOtpremnicaKontrola = new GenericRepository<OtpremnicaKontrola>(mp);
        }

        public void Add(OtpremnicaKontrola entity)
        {
            repoOtpremnicaKontrola.Add(entity);
        }

        public void AddRange(IEnumerable<OtpremnicaKontrola> entities)
        {
            repoOtpremnicaKontrola.AddRange(entities);
        }

        public OtpremnicaKontrola Find(Expression<Func<OtpremnicaKontrola, bool>> predicate)
        {
            return repoOtpremnicaKontrola.Find(predicate);
        }

        public OtpremnicaKontrola Get(int id)
        {
            return repoOtpremnicaKontrola.Get(id);
        }

        public IEnumerable<OtpremnicaKontrola> GetAll()
        {
            return repoOtpremnicaKontrola.GetAll().ToList();
        }

        public void Remove(OtpremnicaKontrola entity)
        {
            repoOtpremnicaKontrola.Remove(entity);
        }

        public void RemoveEntity(OtpremnicaKontrola entityToDelete)
        {
            repoOtpremnicaKontrola.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<OtpremnicaKontrola> entities)
        {
            repoOtpremnicaKontrola.RemoveRange(entities);
        }

        public void UpdateEntity(OtpremnicaKontrola entityToUpdate)
        {
            repoOtpremnicaKontrola.UpdateEntity(entityToUpdate);
        }
    }
}
