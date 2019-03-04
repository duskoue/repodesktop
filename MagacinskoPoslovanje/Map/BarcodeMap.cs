using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;

namespace MagacinskoPoslovanje.Map
{
  public  class BarcodeMap : EntityTypeConfiguration<Barcode>
    {
        public BarcodeMap()
        {
            this.ToTable("Barcode");
            this.HasKey(e => e.Sifra);
        }
    }
}
