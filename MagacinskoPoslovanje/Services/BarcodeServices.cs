using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MagacinskoPoslovanje.Context;
using MagacinskoPoslovanje.Data;

namespace MagacinskoPoslovanje.Services
{
   public class BarcodeServices : IServices<Barcode>
    {
        MpContext mp;
        GenericRepository<Barcode> repoBarcode;
        public BarcodeServices()
        {
            repoBarcode = new GenericRepository<Barcode>(mp);
            mp = new MpContext("InfoContext");
        }

        public void Add(Barcode entity)
        {
            repoBarcode.Add(entity);
        }

        public void AddRange(IEnumerable<Barcode> entities)
        {
            repoBarcode.AddRange(entities);
        }

        public Barcode Find(Expression<Func<Barcode, bool>> predicate)
        {
           return repoBarcode.Find(predicate);
        }

        public Barcode Get(int id)
        {
            return repoBarcode.Get(id);
        }

        public IEnumerable<Barcode> GetAll()
        {
            return repoBarcode.GetAll().ToList();
        }

        public void Remove(Barcode entity)
        {
            repoBarcode.Remove(entity);
        }

        public void RemoveEntity(Barcode entityToDelete)
        {
            repoBarcode.RemoveEntity(entityToDelete);
        }

        public void RemoveRange(IEnumerable<Barcode> entities)
        {
            repoBarcode.RemoveRange(entities);
        }

        public void UpdateEntity(Barcode entityToUpdate)
        {
            repoBarcode.UpdateEntity(entityToUpdate);
        }
    }
}
