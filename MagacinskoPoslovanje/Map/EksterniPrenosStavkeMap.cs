using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;

namespace MagacinskoPoslovanje.Map
{
  public  class EksterniPrenosStavkeMap : EntityTypeConfiguration<EksterniPrenosStavke>
    {
        public EksterniPrenosStavkeMap()
        {
            this.ToTable("EksterniPrenosStavke");
            this.HasKey(e => e.ID);
        }
    }
}
