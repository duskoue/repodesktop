using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;

namespace MagacinskoPoslovanje.Map
{
  public  class SastavnicaMap : EntityTypeConfiguration<Sastavnica>
    {
        public SastavnicaMap()
        {
            this.ToTable("Sastavnica");
            this.HasKey(e => e.ID);
        }
    }
}
