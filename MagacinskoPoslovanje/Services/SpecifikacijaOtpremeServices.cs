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
   public class SpecifikacijaOtpremeServices : IServices<SpecifikacijaOtpreme>
    {
        MpContext mp;
        GenericRepository<SpecifikacijaOtpreme> repoSpecifikacijaOtpreme;
        public SpecifikacijaOtpremeServices()
        {
            mp = new MpContext("InfoContext");
            repoSpecifikacijaOtpreme = new GenericRepository<SpecifikacijaOtpreme>(mp);
        }

        public void Add(SpecifikacijaOtpreme entity)
        {
            repoSpecifikacijaOtpreme.Add(entity);
        }

        public void AddRange(IEnumerable<SpecifikacijaOtpreme> entities)
        {
            repoSpecifikacijaOtpreme.AddRange(entities);
        }

        public SpecifikacijaOtpreme Find(Expression<Func<SpecifikacijaOtpreme, bool>> predicate)
        {
            return repoSpecifikacijaOtpreme.Find(predicate);
        }

        public SpecifikacijaOtpreme Get(int id)
        {
            return repoSpecifikacijaOtpreme.Get(id);
        }

        public IEnumerable<SpecifikacijaOtpreme> GetAll()
        {
            return repoSpecifikacijaOtpreme.GetAll().ToList();
        }

        public void Remove(SpecifikacijaOtpreme entity)
        {
            repoSpecifikacijaOtpreme.Remove(entity);
        }

        public void RemoveEntity(SpecifikacijaOtpreme entityToDelete)
        {
            repoSpecifikacijaOtpreme.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<SpecifikacijaOtpreme> entities)
        {
            repoSpecifikacijaOtpreme.RemoveRange(entities);
        }

        public void UpdateEntity(SpecifikacijaOtpreme entityToUpdate)
        {
            repoSpecifikacijaOtpreme.UpdateEntity(entityToUpdate);
        }
    }
}
